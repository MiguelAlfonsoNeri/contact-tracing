namespace Contact_Tracing_Project
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
            this.btnshow = new System.Windows.Forms.Button();
            this.showtxbx = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.dtptxbx = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(62, 30);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(164, 34);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "show all records:";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // showtxbx
            // 
            this.showtxbx.Location = new System.Drawing.Point(27, 70);
            this.showtxbx.Multiline = true;
            this.showtxbx.Name = "showtxbx";
            this.showtxbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showtxbx.Size = new System.Drawing.Size(239, 325);
            this.showtxbx.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(82, 404);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 34);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dtptxbx
            // 
            this.dtptxbx.Location = new System.Drawing.Point(330, 70);
            this.dtptxbx.Name = "dtptxbx";
            this.dtptxbx.Size = new System.Drawing.Size(290, 31);
            this.dtptxbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtptxbx);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.showtxbx);
            this.Controls.Add(this.btnshow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnshow;
        private TextBox showtxbx;
        private Button btndelete;
        private DateTimePicker dtptxbx;
        private Label label1;
    }
}