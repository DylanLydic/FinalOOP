namespace FinalProjectOOP
{
    partial class beginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beginForm));
            this.header1 = new System.Windows.Forms.Label();
            this.body1 = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.body2 = new System.Windows.Forms.Label();
            this.header3 = new System.Windows.Forms.Label();
            this.body3 = new System.Windows.Forms.Label();
            this.videolink1 = new System.Windows.Forms.LinkLabel();
            this.videolink2 = new System.Windows.Forms.LinkLabel();
            this.homebtn = new System.Windows.Forms.Button();
            this.gameselect = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(12, 9);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(110, 30);
            this.header1.TabIndex = 0;
            this.header1.Text = "The Basics";
            // 
            // body1
            // 
            this.body1.AutoSize = true;
            this.body1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body1.Location = new System.Drawing.Point(14, 39);
            this.body1.Name = "body1";
            this.body1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.body1.Size = new System.Drawing.Size(1347, 257);
            this.body1.TabIndex = 1;
            this.body1.Text = resources.GetString("body1.Text");
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2.Location = new System.Drawing.Point(15, 296);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(113, 30);
            this.header2.TabIndex = 2;
            this.header2.Text = "Characters";
            // 
            // body2
            // 
            this.body2.AutoSize = true;
            this.body2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body2.Location = new System.Drawing.Point(17, 326);
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(1108, 190);
            this.body2.TabIndex = 3;
            this.body2.Text = resources.GetString("body2.Text");
            // 
            // header3
            // 
            this.header3.AutoSize = true;
            this.header3.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header3.Location = new System.Drawing.Point(18, 516);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(98, 30);
            this.header3.TabIndex = 4;
            this.header3.Text = "Recovery";
            // 
            // body3
            // 
            this.body3.AutoSize = true;
            this.body3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body3.Location = new System.Drawing.Point(20, 546);
            this.body3.Name = "body3";
            this.body3.Size = new System.Drawing.Size(680, 38);
            this.body3.TabIndex = 5;
            this.body3.Text = "Learning recoveries are crucial to playing Smash.\r\nA recovery is done by pointing" +
    " the analog stick upward and pressing the \"B\" button for almost all characters.";
            // 
            // videolink1
            // 
            this.videolink1.AutoSize = true;
            this.videolink1.Location = new System.Drawing.Point(645, 651);
            this.videolink1.Name = "videolink1";
            this.videolink1.Size = new System.Drawing.Size(167, 13);
            this.videolink1.TabIndex = 6;
            this.videolink1.TabStop = true;
            this.videolink1.Text = "Click Here For A Beginner Tutorial";
            this.videolink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.video_LinkClicked);
            // 
            // videolink2
            // 
            this.videolink2.AutoSize = true;
            this.videolink2.Location = new System.Drawing.Point(645, 681);
            this.videolink2.Name = "videolink2";
            this.videolink2.Size = new System.Drawing.Size(208, 13);
            this.videolink2.TabIndex = 7;
            this.videolink2.TabStop = true;
            this.videolink2.Text = "Click Here For A Beginner Character Video";
            this.videolink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.video2_LinkClicked);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(24, 732);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 8;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.home_Click);
            // 
            // gameselect
            // 
            this.gameselect.Location = new System.Drawing.Point(120, 732);
            this.gameselect.Name = "gameselect";
            this.gameselect.Size = new System.Drawing.Size(101, 23);
            this.gameselect.TabIndex = 9;
            this.gameselect.Text = "Game Selection";
            this.gameselect.UseVisualStyleBackColor = true;
            this.gameselect.Click += new System.EventHandler(this.select_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(242, 732);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 10;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.back_Click);
            // 
            // beginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 767);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.gameselect);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.videolink2);
            this.Controls.Add(this.videolink1);
            this.Controls.Add(this.body3);
            this.Controls.Add(this.header3);
            this.Controls.Add(this.body2);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.header1);
            this.Name = "beginForm";
            this.Text = "Beginner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label body1;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.Label body2;
        private System.Windows.Forms.Label header3;
        private System.Windows.Forms.Label body3;
        private System.Windows.Forms.LinkLabel videolink1;
        private System.Windows.Forms.LinkLabel videolink2;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button gameselect;
        private System.Windows.Forms.Button backbtn;
    }
}