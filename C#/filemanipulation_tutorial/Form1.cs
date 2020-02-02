using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace filemanipulation_tutorial
{
    public partial class Form1 : Form
    {
        static long count = 0;
        static long fcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestFile_Click(object sender, EventArgs e)
        {
            
            String fname = "D:\\dir.txt";
            File.WriteAllText(fname, "I am aung win htut");
            byte[] output = File.ReadAllBytes(fname);
            //txtOutput.Text = output.ToString ();
            if(File.Exists(fname))
            {
                File.Delete(fname);
                MessageBox.Show(fname+" File is Deleted");
            }
            else
            {
                MessageBox.Show("file not found");
            }
            
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            String dirPath = "d:\\dirtest";
            //MessageBox.Show ("Creation time: " + Directory.GetCreationTime(dirPath));

            //// Last Write time.
            //MessageBox.Show("Last Write Time: " + Directory.GetLastWriteTime(dirPath));
            //MessageBox.Show(Directory.GetCurrentDirectory());
            funTree("D:\\");
            this.Text = count.ToString() + " directories listed and "+fcount.ToString ()+" files listed";

        }

        public void funTree(String path)
        {
            try
            {
                List<String> dl = new List<string>(Directory.EnumerateDirectories(path));
                foreach (String dir in dl)
                {
                    listBox1.Items.Add(dir);
                    List<String> fl = new List<string>(Directory.EnumerateFiles(dir, "*.*"));
                    foreach (String fil in fl)
                    {
                        listBox1.Items.Add("-->" + fil);
                        fcount++;
                    }
                    count++;
                    funTree(dir);//recursion

                }
            }
            catch(Exception ex)
            {
                listBox2.Items.Add(ex.ToString());
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("d:\\c");
            FileInfo fi = new FileInfo("d:\\c\\test.txt");

            MessageBox.Show(fi.DirectoryName);
        }
    }
}
