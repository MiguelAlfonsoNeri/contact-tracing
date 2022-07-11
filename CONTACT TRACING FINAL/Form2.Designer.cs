namespace CONTACT_TRACING_FINAL
{
    partial class Form2
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
            this.showtxbx = new System.Windows.Forms.TextBox();
            this.Showallbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // showtxbx
            // 
            this.showtxbx.Location = new System.Drawing.Point(65, 43);
            this.showtxbx.Multiline = true;
            this.showtxbx.Name = "showtxbx";
            this.showtxbx.Size = new System.Drawing.Size(663, 234);
            this.showtxbx.TabIndex = 0;
            // 
            // Showallbtn
            // 
            this.Showallbtn.Location = new System.Drawing.Point(95, 391);
            this.Showallbtn.Name = "Showallbtn";
            this.Showallbtn.Size = new System.Drawing.Size(108, 26);
            this.Showallbtn.TabIndex = 1;
            this.Showallbtn.Text = "Show All";
            this.Showallbtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(522, 391);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 27);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(653, 391);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 27);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.Showallbtn);
            this.Controls.Add(this.showtxbx);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showtxbx;
        private System.Windows.Forms.Button Showallbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}