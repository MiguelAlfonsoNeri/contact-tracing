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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnshow = new System.Windows.Forms.Button();
            this.showtxbx = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnfilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnshow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnshow.Location = new System.Drawing.Point(30, 404);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(164, 34);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "show all records";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // showtxbx
            // 
            this.showtxbx.Location = new System.Drawing.Point(30, 24);
            this.showtxbx.Multiline = true;
            this.showtxbx.Name = "showtxbx";
            this.showtxbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showtxbx.Size = new System.Drawing.Size(746, 337);
            this.showtxbx.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btndelete.Location = new System.Drawing.Point(664, 404);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 34);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.date.Location = new System.Drawing.Point(215, 407);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(300, 31);
            this.date.TabIndex = 3;
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnfilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnfilter.Location = new System.Drawing.Point(531, 404);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(112, 34);
            this.btnfilter.TabIndex = 6;
            this.btnfilter.Text = "search date";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.date);
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
        private DateTimePicker date;
        private Label label1;
        private TextBox filtertxbx;
        private Button btnfilter;
    }
}