namespace AlphaGirlProto
{
    partial class mFormGoogleCalList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mListViewGoogleCalEvent = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // mListViewGoogleCalEvent
            // 
            this.mListViewGoogleCalEvent.Location = new System.Drawing.Point(13, 13);
            this.mListViewGoogleCalEvent.Name = "mListViewGoogleCalEvent";
            this.mListViewGoogleCalEvent.Size = new System.Drawing.Size(447, 103);
            this.mListViewGoogleCalEvent.TabIndex = 0;
            this.mListViewGoogleCalEvent.UseCompatibleStateImageBehavior = false;
            // 
            // mFormGoogleCalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 128);
            this.Controls.Add(this.mListViewGoogleCalEvent);
            this.Name = "mFormGoogleCalList";
            this.Text = "mFormGoogleCalList";
            this.Load += new System.EventHandler(this.mFormGoogleCalList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mListViewGoogleCalEvent;
    }
}