namespace CONTACT_TRACING_FINAL
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.qrtxbx = new System.Windows.Forms.TextBox();
            this.Btnstart = new System.Windows.Forms.Button();
            this.Btnread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.timerscanner = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(90, 18);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(473, 28);
            this.cmb.TabIndex = 0;
            // 
            // qrtxbx
            // 
            this.qrtxbx.Location = new System.Drawing.Point(623, 92);
            this.qrtxbx.Multiline = true;
            this.qrtxbx.Name = "qrtxbx";
            this.qrtxbx.Size = new System.Drawing.Size(289, 338);
            this.qrtxbx.TabIndex = 1;
            // 
            // Btnstart
            // 
            this.Btnstart.Location = new System.Drawing.Point(667, 23);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(75, 29);
            this.Btnstart.TabIndex = 2;
            this.Btnstart.Text = "Start";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // Btnread
            // 
            this.Btnread.Location = new System.Drawing.Point(806, 23);
            this.Btnread.Name = "Btnread";
            this.Btnread.Size = new System.Drawing.Size(75, 29);
            this.Btnread.TabIndex = 3;
            this.Btnread.Text = "Read";
            this.Btnread.UseVisualStyleBackColor = true;
            this.Btnread.Click += new System.EventHandler(this.Btnread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera";
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(27, 92);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(536, 338);
            this.pcbox.TabIndex = 5;
            this.pcbox.TabStop = false;
            // 
            // timerscanner
            // 
            this.timerscanner.Tick += new System.EventHandler(this.timerscanner_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.pcbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnread);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.qrtxbx);
            this.Controls.Add(this.cmb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox qrtxbx;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.Button Btnread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Timer timerscanner;
    }
}