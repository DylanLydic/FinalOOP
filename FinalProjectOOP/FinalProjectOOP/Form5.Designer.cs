namespace FinalProjectOOP
{
    partial class gspForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gspForm));
            this.gspHeader1 = new System.Windows.Forms.TextBox();
            this.gspTB1 = new System.Windows.Forms.TextBox();
            this.gspHeader2 = new System.Windows.Forms.TextBox();
            this.gspTextBox2 = new System.Windows.Forms.TextBox();
            this.gspbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gspHeader1
            // 
            this.gspHeader1.BackColor = System.Drawing.SystemColors.Control;
            this.gspHeader1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gspHeader1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gspHeader1.Location = new System.Drawing.Point(12, 37);
            this.gspHeader1.Name = "gspHeader1";
            this.gspHeader1.Size = new System.Drawing.Size(324, 28);
            this.gspHeader1.TabIndex = 1;
            this.gspHeader1.Text = "What is Global Smash Power?\r\n";
            // 
            // gspTB1
            // 
            this.gspTB1.BackColor = System.Drawing.SystemColors.Control;
            this.gspTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gspTB1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gspTB1.Location = new System.Drawing.Point(12, 71);
            this.gspTB1.Multiline = true;
            this.gspTB1.Name = "gspTB1";
            this.gspTB1.Size = new System.Drawing.Size(717, 74);
            this.gspTB1.TabIndex = 2;
            this.gspTB1.Text = resources.GetString("gspTB1.Text");
            // 
            // gspHeader2
            // 
            this.gspHeader2.BackColor = System.Drawing.SystemColors.Control;
            this.gspHeader2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gspHeader2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gspHeader2.Location = new System.Drawing.Point(12, 151);
            this.gspHeader2.Name = "gspHeader2";
            this.gspHeader2.Size = new System.Drawing.Size(187, 28);
            this.gspHeader2.TabIndex = 3;
            this.gspHeader2.Text = "Elite Smash";
            // 
            // gspTextBox2
            // 
            this.gspTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.gspTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gspTextBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gspTextBox2.Location = new System.Drawing.Point(12, 185);
            this.gspTextBox2.Multiline = true;
            this.gspTextBox2.Name = "gspTextBox2";
            this.gspTextBox2.Size = new System.Drawing.Size(717, 97);
            this.gspTextBox2.TabIndex = 4;
            this.gspTextBox2.Text = resources.GetString("gspTextBox2.Text");
            // 
            // gspbtn
            // 
            this.gspbtn.Location = new System.Drawing.Point(287, 288);
            this.gspbtn.Name = "gspbtn";
            this.gspbtn.Size = new System.Drawing.Size(141, 23);
            this.gspbtn.TabIndex = 5;
            this.gspbtn.Text = "Return to Smash Page";
            this.gspbtn.UseVisualStyleBackColor = true;
            this.gspbtn.Click += new System.EventHandler(this.gspbt_Click);
            // 
            // gspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gspbtn);
            this.Controls.Add(this.gspTextBox2);
            this.Controls.Add(this.gspHeader2);
            this.Controls.Add(this.gspTB1);
            this.Controls.Add(this.gspHeader1);
            this.Name = "gspForm";
            this.Text = "Global Smash Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gspHeader1;
        private System.Windows.Forms.TextBox gspTB1;
        private System.Windows.Forms.TextBox gspHeader2;
        private System.Windows.Forms.TextBox gspTextBox2;
        private System.Windows.Forms.Button gspbtn;
    }
}