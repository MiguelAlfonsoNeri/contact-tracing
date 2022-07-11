﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CONTACT_TRACING_FINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var dataFiles = Directory.GetFiles(@"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses");
            foreach (string file in dataFiles)
            {
                string date = File.ReadAllText(file);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Showallbtn_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\";
            string path2 = @"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\all recs\";
            string[] files = Directory.GetFiles(path1, "*.txt", SearchOption.TopDirectoryOnly);

            using (var output = File.Create(path2 + "specific records.txt"))
            {
                foreach (var file in files)
                {
                    using (var data = File.OpenRead(file))
                    {
                        data.CopyTo(output);
                    }
                }
            }
            string path3 = @"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\all recs\specific records.txt";
            var show = File.ReadAllText(path3);
            showtxbx.Text = show;

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            showtxbx.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string path4 = @"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\";
            string path5 = @"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\specific search date\";
            string[] docs = Directory.GetFiles(path4, dtp.Text + ".txt", SearchOption.TopDirectoryOnly);

            using (var showfilter = File.Create(path5 + dtp.Text + "(SEARCH).txt"))
            {
                foreach (var doc in docs)
                {
                    using (var data = File.OpenRead(doc))
                    {
                        data.CopyTo(showfilter);
                    }
                }
            }
            var show = File.ReadAllText(path5 + dtp.Text + "(SEARCH).txt");
            showtxbx.Text = show;
        }
    }
}
