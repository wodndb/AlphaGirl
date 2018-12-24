using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace AlphaGirlProto
{
    public partial class mFormGoogleCalList : Form
    {
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public mFormGoogleCalList()
        {
            InitializeComponent();
        }

        private void mFormGoogleCalList_Load(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                mListViewGoogleCalEvent.View = View.Details;
                mListViewGoogleCalEvent.BeginUpdate();

                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }

                    ListViewItem lvi = new ListViewItem(eventItem.Id);
                    lvi.SubItems.Add(eventItem.Summary);
                    lvi.SubItems.Add(when);

                    mListViewGoogleCalEvent.Items.Add(lvi);

                    //Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }

                mListViewGoogleCalEvent.Columns.Add("ID", 30, HorizontalAlignment.Left);
                mListViewGoogleCalEvent.Columns.Add("Summary", 300, HorizontalAlignment.Left);
                mListViewGoogleCalEvent.Columns.Add("When", 150, HorizontalAlignment.Left);

                mListViewGoogleCalEvent.EndUpdate();
            }
            else
            {
                MessageBox.Show("No upcoming events found.");
            }
            Console.Read();
        }
    }
}
