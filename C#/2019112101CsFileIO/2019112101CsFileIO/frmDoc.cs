using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _2019112101CsFileIO
{
    public partial class frmDoc : Form
    {
        public frmDoc()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sFname = "";
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Title = "Save your file!";
            savefiledialog.DefaultExt = "txt";
            savefiledialog.Filter = "txt file (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                sFname = savefiledialog.FileName;
                StreamWriter sw = new StreamWriter(sFname);
                String text = txtDoc.Text.ToString();
                sw.Write(text);
                sw.Close();
            }
            

          
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "txt file (*.txt)|*.txt|All files (*.*)|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openfiledialog.FileName);
                String text = sr.ReadToEnd();
                txtDoc.Text = text;
                sr.Close();
            }
        }
    }
}
