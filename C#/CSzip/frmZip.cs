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
using System.IO.Compression;

namespace CSzip
{
    public partial class frmZip : Form
    {
        public frmZip()
        {
            InitializeComponent();
        }

        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.*|*.*";
            String pathAndFname;
            if(openFileDialog1 .ShowDialog ()==DialogResult.OK)
            {
                pathAndFname = openFileDialog1.FileName;
                txtFilePath.Text = pathAndFname;
                String inputFolder = Path.GetDirectoryName(pathAndFname);
                int count = pathAndFname.LastIndexOf(@"\");
                
                String folder = pathAndFname.Substring(0, count);
                int len = pathAndFname.Length;
                String file = pathAndFname.Substring(count+1, len-count-1 );
                MessageBox.Show(file);


                int count2 = file.LastIndexOf(@".");

                String fn = file.Substring(0, count2);
                int len2 = file.Length;
                String ext = file.Substring(count2 , len2 - count2);
                MessageBox.Show(ext);


                DirectoryInfo dir= new DirectoryInfo ( inputFolder) ;
                String dirname = dir.Name;
                String outputFname = @"d:\"+dirname  + ".zip";
                txtOutputPath.Text = outputFname;

                FileInfo f = new FileInfo(@"C:\tc\bin\bat.txt");
                MessageBox.Show(f.Name);
                MessageBox.Show(f.FullName);
                MessageBox.Show(f.Extension );
                MessageBox.Show(f.DirectoryName);

                
                //Directory.GetParent(inputFolder).ToString();
                //ZipFile.CreateFromDirectory(inputFolder, outputFname);
                //MessageBox.Show("Done");
            }
        }
    }
}
