namespace AlphaGirlProto
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mCheckBoxTimeNotiEventHour = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mCheckBoxSpEventStart = new System.Windows.Forms.CheckBox();
            this.mButtonSave = new System.Windows.Forms.Button();
            this.mButtonInit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mCheckBoxTimeNotiEventHour);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "알림";
            // 
            // mCheckBoxTimeNotiEventHour
            // 
            this.mCheckBoxTimeNotiEventHour.AutoSize = true;
            this.mCheckBoxTimeNotiEventHour.Location = new System.Drawing.Point(6, 20);
            this.mCheckBoxTimeNotiEventHour.Name = "mCheckBoxTimeNotiEventHour";
            this.mCheckBoxTimeNotiEventHour.Size = new System.Drawing.Size(140, 16);
            this.mCheckBoxTimeNotiEventHour.TabIndex = 0;
            this.mCheckBoxTimeNotiEventHour.Text = "정각에 보이스로 알림";
            this.mCheckBoxTimeNotiEventHour.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mCheckBoxSpEventStart);
            this.groupBox2.Location = new System.Drawing.Point(9, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "인사";
            // 
            // mCheckBoxSpEventStart
            // 
            this.mCheckBoxSpEventStart.AutoSize = true;
            this.mCheckBoxSpEventStart.Location = new System.Drawing.Point(6, 20);
            this.mCheckBoxSpEventStart.Name = "mCheckBoxSpEventStart";
            this.mCheckBoxSpEventStart.Size = new System.Drawing.Size(144, 16);
            this.mCheckBoxSpEventStart.TabIndex = 1;
            this.mCheckBoxSpEventStart.Text = "프로그램 기동 시 인사";
            this.mCheckBoxSpEventStart.UseVisualStyleBackColor = true;
            // 
            // mButtonSave
            // 
            this.mButtonSave.Location = new System.Drawing.Point(195, 123);
            this.mButtonSave.Name = "mButtonSave";
            this.mButtonSave.Size = new System.Drawing.Size(75, 23);
            this.mButtonSave.TabIndex = 2;
            this.mButtonSave.Text = "저장";
            this.mButtonSave.UseVisualStyleBackColor = true;
            this.mButtonSave.Click += new System.EventHandler(this.mButtonSave_Click);
            // 
            // mButtonInit
            // 
            this.mButtonInit.Location = new System.Drawing.Point(114, 123);
            this.mButtonInit.Name = "mButtonInit";
            this.mButtonInit.Size = new System.Drawing.Size(75, 23);
            this.mButtonInit.TabIndex = 3;
            this.mButtonInit.Text = "초기화";
            this.mButtonInit.UseVisualStyleBackColor = true;
            this.mButtonInit.Click += new System.EventHandler(this.mButtonInit_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.mButtonInit);
            this.Controls.Add(this.mButtonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mCheckBoxTimeNotiEventHour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox mCheckBoxSpEventStart;
        private System.Windows.Forms.Button mButtonSave;
        private System.Windows.Forms.Button mButtonInit;
    }
}