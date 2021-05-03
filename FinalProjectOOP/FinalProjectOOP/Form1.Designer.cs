namespace FinalProjectOOP
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.BTselection = new System.Windows.Forms.Button();
            this.welcomeheader = new System.Windows.Forms.Label();
            this.body1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.about_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.about_MouseClick);
            // 
            // BTselection
            // 
            this.BTselection.Location = new System.Drawing.Point(425, 242);
            this.BTselection.Name = "BTselection";
            this.BTselection.Size = new System.Drawing.Size(135, 23);
            this.BTselection.TabIndex = 1;
            this.BTselection.Text = "Game Selection";
            this.BTselection.UseVisualStyleBackColor = true;
            this.BTselection.Click += new System.EventHandler(this.selection_Click);
            // 
            // welcomeheader
            // 
            this.welcomeheader.AutoSize = true;
            this.welcomeheader.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeheader.Location = new System.Drawing.Point(329, 9);
            this.welcomeheader.Name = "welcomeheader";
            this.welcomeheader.Size = new System.Drawing.Size(95, 30);
            this.welcomeheader.TabIndex = 2;
            this.welcomeheader.Text = "Welcome";
            // 
            // body1
            // 
            this.body1.AutoSize = true;
            this.body1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body1.Location = new System.Drawing.Point(86, 39);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(551, 19);
            this.body1.TabIndex = 3;
            this.body1.Text = "Welcome, if you are looking to improve at a certain game select the Game Select b" +
    "utton.\r\n";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 430);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.welcomeheader);
            this.Controls.Add(this.BTselection);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTselection;
        private System.Windows.Forms.Label welcomeheader;
        private System.Windows.Forms.Label body1;
    }
}

