namespace FinalProjectOOP
{
    partial class aboutForm
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
            this.btnHome = new System.Windows.Forms.Button();
            this.selectionbtn = new System.Windows.Forms.Button();
            this.header1 = new System.Windows.Forms.Label();
            this.body1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.home_Click);
            // 
            // selectionbtn
            // 
            this.selectionbtn.Location = new System.Drawing.Point(93, 415);
            this.selectionbtn.Name = "selectionbtn";
            this.selectionbtn.Size = new System.Drawing.Size(106, 23);
            this.selectionbtn.TabIndex = 1;
            this.selectionbtn.Text = "Game Selection";
            this.selectionbtn.UseVisualStyleBackColor = true;
            this.selectionbtn.Click += new System.EventHandler(this.selection2_Click);
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(9, 9);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(64, 30);
            this.header1.TabIndex = 2;
            this.header1.Text = "Goals\r\n";
            // 
            // body1
            // 
            this.body1.AutoSize = true;
            this.body1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body1.Location = new System.Drawing.Point(9, 39);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(462, 76);
            this.body1.TabIndex = 3;
            this.body1.Text = "My goals behind this project are as follows:\r\n- To give tips and tricks that help" +
    " people improve at their prefered game.\r\n- To expose people to new games they ma" +
    "y enjoy\r\n- To improve my coding skills";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.selectionbtn);
            this.Controls.Add(this.btnHome);
            this.Name = "aboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button selectionbtn;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label body1;
    }
}