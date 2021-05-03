namespace FinalProjectOOP
{
    partial class interForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interForm));
            this.header1 = new System.Windows.Forms.Label();
            this.body1 = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.body2 = new System.Windows.Forms.Label();
            this.header3 = new System.Windows.Forms.Label();
            this.body3 = new System.Windows.Forms.Label();
            this.videolink1 = new System.Windows.Forms.LinkLabel();
            this.videolink2 = new System.Windows.Forms.LinkLabel();
            this.homebtn = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(12, 9);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(197, 30);
            this.header1.TabIndex = 0;
            this.header1.Text = "Combos and Strings";
            // 
            // body1
            // 
            this.body1.AutoSize = true;
            this.body1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body1.Location = new System.Drawing.Point(14, 39);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(1229, 95);
            this.body1.TabIndex = 1;
            this.body1.Text = resources.GetString("body1.Text");
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2.Location = new System.Drawing.Point(14, 102);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(284, 30);
            this.header2.TabIndex = 2;
            this.header2.Text = "Understading Your Character";
            // 
            // body2
            // 
            this.body2.AutoSize = true;
            this.body2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body2.Location = new System.Drawing.Point(15, 134);
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(973, 38);
            this.body2.TabIndex = 3;
            this.body2.Text = resources.GetString("body2.Text");
            // 
            // header3
            // 
            this.header3.AutoSize = true;
            this.header3.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header3.Location = new System.Drawing.Point(16, 172);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(87, 30);
            this.header3.TabIndex = 4;
            this.header3.Text = "Practice\r\n";
            // 
            // body3
            // 
            this.body3.AutoSize = true;
            this.body3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body3.Location = new System.Drawing.Point(18, 202);
            this.body3.Name = "body3";
            this.body3.Size = new System.Drawing.Size(682, 57);
            this.body3.TabIndex = 5;
            this.body3.Text = resources.GetString("body3.Text");
            // 
            // videolink1
            // 
            this.videolink1.AutoSize = true;
            this.videolink1.Location = new System.Drawing.Point(631, 342);
            this.videolink1.Name = "videolink1";
            this.videolink1.Size = new System.Drawing.Size(224, 13);
            this.videolink1.TabIndex = 6;
            this.videolink1.TabStop = true;
            this.videolink1.Text = "Click Here For A Combo With Every Character";
            this.videolink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.video1_LinkClicked);
            // 
            // videolink2
            // 
            this.videolink2.AutoSize = true;
            this.videolink2.Location = new System.Drawing.Point(664, 366);
            this.videolink2.Name = "videolink2";
            this.videolink2.Size = new System.Drawing.Size(151, 13);
            this.videolink2.TabIndex = 7;
            this.videolink2.TabStop = true;
            this.videolink2.Text = "Click Here For A Combo Guide\r\n";
            this.videolink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.video2_LinkClicked);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(22, 415);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 8;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.home_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(134, 415);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(177, 23);
            this.selectbtn.TabIndex = 9;
            this.selectbtn.Text = "Back To Game Selection";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.select_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(341, 415);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 10;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.back_Click);
            // 
            // interForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.videolink2);
            this.Controls.Add(this.videolink1);
            this.Controls.Add(this.body3);
            this.Controls.Add(this.header3);
            this.Controls.Add(this.body2);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.header1);
            this.Name = "interForm";
            this.Text = "Intermediate";
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
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Button backbtn;
    }
}