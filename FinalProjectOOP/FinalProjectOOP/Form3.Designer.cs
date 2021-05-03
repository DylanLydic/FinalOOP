namespace FinalProjectOOP
{
    partial class selectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectionForm));
            this.homebtn2 = new System.Windows.Forms.Button();
            this.about3btn = new System.Windows.Forms.Button();
            this.ssbbtn = new System.Windows.Forms.Button();
            this.explination1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homebtn2
            // 
            this.homebtn2.Location = new System.Drawing.Point(12, 415);
            this.homebtn2.Name = "homebtn2";
            this.homebtn2.Size = new System.Drawing.Size(75, 23);
            this.homebtn2.TabIndex = 0;
            this.homebtn2.Text = "Home";
            this.homebtn2.UseVisualStyleBackColor = true;
            this.homebtn2.Click += new System.EventHandler(this.home3_Click);
            // 
            // about3btn
            // 
            this.about3btn.Location = new System.Drawing.Point(93, 415);
            this.about3btn.Name = "about3btn";
            this.about3btn.Size = new System.Drawing.Size(75, 23);
            this.about3btn.TabIndex = 1;
            this.about3btn.Text = "About";
            this.about3btn.UseVisualStyleBackColor = true;
            this.about3btn.Click += new System.EventHandler(this.about3_Click);
            // 
            // ssbbtn
            // 
            this.ssbbtn.BackColor = System.Drawing.Color.Transparent;
            this.ssbbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ssbbtn.BackgroundImage")));
            this.ssbbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ssbbtn.Location = new System.Drawing.Point(12, 189);
            this.ssbbtn.Name = "ssbbtn";
            this.ssbbtn.Size = new System.Drawing.Size(51, 49);
            this.ssbbtn.TabIndex = 2;
            this.ssbbtn.UseVisualStyleBackColor = false;
            this.ssbbtn.Click += new System.EventHandler(this.ssb_Click);
            // 
            // explination1
            // 
            this.explination1.AutoSize = true;
            this.explination1.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explination1.Location = new System.Drawing.Point(12, 92);
            this.explination1.Name = "explination1";
            this.explination1.Size = new System.Drawing.Size(630, 69);
            this.explination1.TabIndex = 3;
            this.explination1.Text = resources.GetString("explination1.Text");
            // 
            // selectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.explination1);
            this.Controls.Add(this.ssbbtn);
            this.Controls.Add(this.about3btn);
            this.Controls.Add(this.homebtn2);
            this.Name = "selectionForm";
            this.Text = "Game Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebtn2;
        private System.Windows.Forms.Button about3btn;
        private System.Windows.Forms.Button ssbbtn;
        private System.Windows.Forms.Label explination1;
    }
}