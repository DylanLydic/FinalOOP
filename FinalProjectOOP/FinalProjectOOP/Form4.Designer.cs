namespace FinalProjectOOP
{
    partial class ssbForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gspbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.bgbtn = new System.Windows.Forms.Button();
            this.interbtn = new System.Windows.Forms.Button();
            this.advbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(94, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(588, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Enter Your GSP (Global Smash Power):";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gspbtn
            // 
            this.gspbtn.Location = new System.Drawing.Point(303, 381);
            this.gspbtn.Name = "gspbtn";
            this.gspbtn.Size = new System.Drawing.Size(164, 27);
            this.gspbtn.TabIndex = 1;
            this.gspbtn.Text = "GSP Explination";
            this.gspbtn.UseVisualStyleBackColor = true;
            this.gspbtn.Click += new System.EventHandler(this.gsp_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textbox_Enter);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(303, 352);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(164, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back to Game Selection";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.back_Click);
            // 
            // bgbtn
            // 
            this.bgbtn.Location = new System.Drawing.Point(94, 110);
            this.bgbtn.Name = "bgbtn";
            this.bgbtn.Size = new System.Drawing.Size(75, 23);
            this.bgbtn.TabIndex = 4;
            this.bgbtn.Text = "Beginner";
            this.bgbtn.UseVisualStyleBackColor = true;
            this.bgbtn.Click += new System.EventHandler(this.bg_Click);
            // 
            // interbtn
            // 
            this.interbtn.Location = new System.Drawing.Point(342, 110);
            this.interbtn.Name = "interbtn";
            this.interbtn.Size = new System.Drawing.Size(75, 23);
            this.interbtn.TabIndex = 5;
            this.interbtn.Text = "Intermediate";
            this.interbtn.UseVisualStyleBackColor = true;
            this.interbtn.Click += new System.EventHandler(this.inter_Click);
            // 
            // advbtn
            // 
            this.advbtn.Location = new System.Drawing.Point(607, 110);
            this.advbtn.Name = "advbtn";
            this.advbtn.Size = new System.Drawing.Size(75, 23);
            this.advbtn.TabIndex = 6;
            this.advbtn.Text = "Advanced";
            this.advbtn.UseVisualStyleBackColor = true;
            this.advbtn.Click += new System.EventHandler(this.adv_Click);
            // 
            // ssbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.advbtn);
            this.Controls.Add(this.interbtn);
            this.Controls.Add(this.bgbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gspbtn);
            this.Controls.Add(this.textBox1);
            this.Name = "ssbForm";
            this.Text = "Super Smash Bros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gspbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button bgbtn;
        private System.Windows.Forms.Button interbtn;
        private System.Windows.Forms.Button advbtn;
    }
}