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
    }
}
