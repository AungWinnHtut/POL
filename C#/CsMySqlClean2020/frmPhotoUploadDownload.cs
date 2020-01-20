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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class frmPhotoUploadDownload : Form
    {
        public frmPhotoUploadDownload()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog1.FileName;
                    txtPicFname.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    picPhoto .Image = Image.FromFile(openFileDialog1.FileName);
                    FileInfo fi = new FileInfo(openFileDialog1 .FileName );
                    double fsize = fi.Length;
                    double fsizeM = 0;
                    double fsizeK = 0;
                    if(fsize >1048576)
                    {
                        fsizeM = fsize / 1048576;
                        txtSize.Text = fsizeM.ToString() + "  Mbytes";
                    }
                    else if (fsize > 1024)
                    {
                        fsizeK = fsize / 1024;
                        txtSize.Text = fsizeK.ToString() + "  Kbytes";
                    }
                    else
                    {
                        txtSize.Text = fsize.ToString() + " Bytes";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            try
            {
                if (txtPicFname .Text.Length > 0 && txtPath .Text .Length >0)
                {
                    string FileName = txtPath .Text;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                    string CmdString = "INSERT INTO student.pic_tb( pic_name, pic_photo) VALUES( @name, @Image)";
                    cmd = new MySqlCommand(CmdString, con);                 
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Image", MySqlDbType.Blob);               
                   
                    cmd.Parameters["@name"].Value = txtPicFname .Text;
                    cmd.Parameters["@Image"].Value = ImageData;
                   
                    con.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Image saved sucessfully!");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnPicDownload_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            MemoryStream ms;
            try
            {
                if (txtPicFname.Text.Length > 0 )
                {
                    string FileName = txtPicFname .Text;
                    byte[] ImageData;
                  
                    string CmdString = "SELECT * FROM student.pic_tb where pic_name = '"+FileName +"'";
                    con.Open();
                    cmd = new MySqlCommand(CmdString, con);                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ImageData = (byte[])dt.Rows[0][2];
                    ms = new MemoryStream(ImageData );
                    picPhoto.Image = Image.FromStream(ms);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
