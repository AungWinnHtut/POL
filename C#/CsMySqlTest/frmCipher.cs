using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace WindowsFormsApp5
{
    public partial class frmCipher : Form
    {
        public frmCipher()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String sPlain = txtPlain.Text.ToString();
            String sKey = "nhjuiy789ikoiujy";
            String sCipher = Encrypt(sPlain, sKey);
            txtCipher.Text = sCipher;

        }
        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string input, string key)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String sCipher = txtCipher.Text.ToString();
            String sKey = "nhjuiy789ikoiujy";
            String sPlain = Decrypt(sCipher, sKey);
            txtPlain .Text = sPlain;
        }

        private void txtPlain_TextChanged(object sender, EventArgs e)
        {

            String sPlain = txtPlain.Text.ToString();
            String sKey = "nhjuiy789ikoiujy";
            String sCipher = Encrypt(sPlain, sKey);
            txtCipher.Text = sCipher;
        }

        private void frmCipher_Load(object sender, EventArgs e)
        {

        }

        private void btnEncFile_Click(object sender, EventArgs e)
        {
            String sInFile = txtIfile.Text.ToString();
            String sOutFile = txtOfile.Text.ToString();


        }

        public void funEnFile(String sPlainFile,String sCiperFile)
        {
            String sPlain;
            String sKey;
            String sCipher;
            using (StreamReader sr = new StreamReader(sPlainFile))
            {
                sPlain = sr.ReadToEnd();
                sKey = txtKey.Text.ToString();
                sCipher = Encrypt(sPlain, sKey);
                txtOutput.Text = sCipher;
            }
            using(StreamWriter sw = new StreamWriter(sCiperFile ))
            {
                sw.Write(sCipher);
            }
        }

        public void funDecFile(String sCiperFile , String sPlainFile)
        {
            String sPlain;
            String sKey;
            String sCipher;
            using (StreamReader sr = new StreamReader(sCiperFile ))
            {
                sCipher = sr.ReadToEnd();
                sKey = txtKey.Text.ToString();
                sPlain  = Decrypt(sCipher, sKey);
                txtOutput.Text = sPlain;
            }
            using (StreamWriter sw = new StreamWriter(sPlainFile))
            {
                sw.Write(sPlain);
            }
        }



        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            openFileDialog1 .InitialDirectory = @"K:\!Han Zaw Nyein\Database";
            if(openFileDialog1 .ShowDialog()==DialogResult.OK )
            {
                String sfname = openFileDialog1.FileName;
                txtIfile.Text = sfname;
                String pth = Path.GetDirectoryName(sfname);
                String scfname = pth+@"\"+Path.GetFileNameWithoutExtension(sfname )+".cip";
                txtOfile.Text = sfname;
                funEnFile(sfname, scfname);
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"K:\!Han Zaw Nyein\Database";
            openFileDialog1.Filter = "Cipher Files(*.cip)|*.cip";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String sfname = openFileDialog1.FileName;
                txtOfile.Text = sfname;
                String scfname = Path.GetDirectoryName(sfname) +@"\"+ Path.GetFileNameWithoutExtension(sfname) + ".sql";
                txtIfile.Text = sfname;
                funDecFile(sfname, scfname);
            }
        }
    }
}
