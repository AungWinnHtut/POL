using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class frmShowAll : Form
    {
        public frmShowAll()
        {
            InitializeComponent();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            funClearDatagridView();
            funShowAll();
        }

        private void frmShowAll_Load(object sender, EventArgs e)
        {
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //Image image = Image.FromFile("steam.png");
            //img.Image = image;
            //dgvStuData.Columns.Add(img);
            //img.HeaderText = "Image";
            //img.Name = "img";
            


            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.HeaderText = "Select Data";
            //cmb.Name = "cmb";
            //cmb.MaxDropDownItems = 4;
            //cmb.Items.Add("True");
            //cmb.Items.Add("False");
            //dgvStuData.Columns.Add(cmb);

            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //dgvStuData.Columns.Add(chk);
            //chk.HeaderText = "Check Data";
            //chk.Name = "chk";
            //dgvStuData.Rows[1].Cells[0].Value = true;


            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgvStuData.Columns.Add(btn);
            //btn.HeaderText = "Click Data";
            //btn.Text = "Click Here";
            //btn.Name = "btn";
            //btn.UseColumnTextForButtonValue = true;
            funShowAll();
        }
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter;
        MySqlCommandBuilder bdrcmd;
        public void funShowAll()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                adapter = new MySqlDataAdapter("Select * from student.student_tb", con);
                bdrcmd = new MySqlCommandBuilder(adapter);
                con.Open();
                
                adapter.Fill(ds, "student_tb");

                dgvStuData.DataSource = ds.Tables["student_tb"]; 
                //DataView dv;
                //dv = new DataView(ds.Tables[0], "course = 'C#' ", "course Asc", DataViewRowState.CurrentRows);
                //dgvStuData.DataSource = dv; // ds.Tables["student_tb"]; 

                //dgvStuData.Sort(dgvStuData.Columns[1], ListSortDirection.Descending);
                dgvStuData.Columns[5].Visible = false;
                //dgvStuData.Rows[1].Visible = false;
                //dgvStuData.Sort(dgvStuData.Columns[2], ListSortDirection.Descending);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            funClearDatagridView();
        }

        private void dgvStuData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 3)
            //{
                //MessageBox.Show((e.RowIndex ) + "  Row  " + (e.ColumnIndex ) + "  Column button clicked ");
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row "+ dgvStuData.SelectedRows[0].Index.ToString (), "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvStuData.Rows.RemoveAt(dgvStuData.SelectedRows[0].Index);
                adapter.Update(ds.Tables["student_tb"]);
            }
        }
        private int rowIndex = 0;
        private void dgvStuData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvStuData.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvStuData.CurrentCell = this.dgvStuData.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvStuData, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dgvStuData.Rows[this.rowIndex].IsNewRow)
            {

                if (MessageBox.Show("Do you want to delete this row " + dgvStuData.SelectedRows[0].Index.ToString(), "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.dgvStuData.Rows.RemoveAt(this.rowIndex);
                    adapter.Update(ds.Tables["student_tb"]);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void funClearDatagridView()
        {
            //    int limit = dgvStuData.Rows.Count;
            //    for (int i = 0; i <limit-1 ; i++)
            //    {
            //        this.dgvStuData.Rows.RemoveAt(0);
            //    }
        }
    }
}

