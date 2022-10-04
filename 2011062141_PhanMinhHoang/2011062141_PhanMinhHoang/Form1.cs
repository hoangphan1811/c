using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _2011062141_PhanMinhHoang
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }
        public bool Ketnoi(string sever, string database)
        {
            try
            {
                string s ="Data source=" + sever +";database" + ";Intergrated Security= true";
                con = new SqlConnection(s);
                con.Open();
                return true; 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        DataTable TruyVan(string s)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(s, con);
                da.Fill(ds, "KQ");
                con.Close();
                return ds.Tables["KQ"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi truy van CSDL,");
                return new DataTable();
            }
        }
        bool ThemXoaSua (string s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi cap nhat CSDL. ");
                return false;
            }
                
        }
        void LayDuLieu_Len_listview()
        {
            string s = "select *from Sinhvien a, Lophoc b where a.Malophoc =b.Malophoc";
            DataTable dt = new DataTable();
            dt = TruyVan (s);
            for (int i=0; i<dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSinhvien.Items.Add(dt.Rows[i]["Masv"].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenLopHoc"].ToString());
            }
        }
        void NapLopHocVaoComboBox()
        {
            string s = "select TenMaLop form MaLop";
            DataTable dt =new DataTable();
            dt = TruyVan(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbbLop.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        void Xoa()
        {
            txbHoten.Clear();
            txbMaSV.Clear();
            dtpNgaysinh.Value = DateTime.Now;
            cbbLop.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xoa();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnKluu.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnKluu.Enabled=false;
            if (Ketnoi("LAPTOP-F29V2RKS\\SQLEXPRESS","QLSV"))
            {
                LayDuLieu_Len_listview();
                NapLopHocVaoComboBox();
            }
            else
            {
                MessageBox.Show("Nhan OK để thoát","Kết nối không thành công",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Ketnoi("LAPTOP-F29V2RKS\\SQLEXPRESS","QLSV") == false)
            {
                MessageBox.Show("Nhan OK de thoat", "ket noi thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string ht = txbHoten.Text;
            string ns = dtpNgaysinh.Value.ToString();
            string ml = cbbLop.SelectedIndex.ToString();
            string s = "insert into SINHVIEN values(N'" + ht +"','" + ns +"'N'"+ ml+"','"+ ml + "')";
            if (ThemXoaSua(s) ==true)
            {
                lsvSinhvien.Items.Clear();
                LayDuLieu_Len_listview();
                    
            }
        }

        private void lsvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhvien.SelectedItems.Count > 0)
            {
                txbHoten.Text = lsvSinhvien.SelectedItems[0].SubItems[0].Text;
                dtpNgaysinh.Text = lsvSinhvien.SelectedItems[0].SubItems[1].Text;
                txbMaSV.Text = lsvSinhvien.SelectedItems[0].SubItems[2].Text; ;
                cbbLop.SelectedIndex = cbbLop.FindString(lsvSinhvien.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSinhvien.Items.Count == 0)
            {
                MessageBox.Show("hay chon dong de xoa");
                return;
            }
            if (Ketnoi("LAPTOP-F29V2RKS\\SQLEXPRESS","QLSV")==false)
            {
                MessageBox.Show("nhan ok de thoat chuong trinh", "khong ket noi voi CSDL duoc", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            foreach (ListViewItem i in lsvSinhvien.SelectedItems)
            {
                string s = "delete from SINHVIEN where SINHVIEN = N" + i.SubItems[0].Text + "'";
                SqlCommand cmd = new SqlCommand(s,con);
                ThemXoaSua(s);
            }
            con.Close();
            lsvSinhvien.Items.Clear();
            LayDuLieu_Len_listview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Ketnoi("LAPTOP-F29V2RKS\\SQLEXPRESS", "QLSV") == false) ;
            {
                MessageBox.Show("nhan ok de thoat chuong trinh", "khong ket noi CSDL duoc", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string ht = txbHoten.Text;
            string ns = dtpNgaysinh.Value.ToString();
            string ml = cbbLop.SelectedIndex.ToString();
            string s = "update SINHVIEN set Hotensinhvien = N "+ ht +"',ngaysinh='"+ ns +"'malop'"+ml;
            if (ThemXoaSua (s)==true)
            {
                con.Close();
                lsvSinhvien.Items.Clear();
                LayDuLieu_Len_listview();
            }
        }
    }
}

