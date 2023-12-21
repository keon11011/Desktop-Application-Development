using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmDSBaoGiaCuaLead : Form
    {
        BUS_BaoGia busBaoGia = new BUS_BaoGia();
        DTO_BaoGia newBaoGia = new DTO_BaoGia();
        DTO_BaoGia tempBaoGia = new DTO_BaoGia();
        //frmBaoGia frmBaoGia = new frmBaoGia();
        //frmSuaBaoGia frmSuaBaoGia = new frmSuaBaoGia();
        DataTable dt = new DataTable();
        public frmDSBaoGiaCuaLead()
        {
            InitializeComponent();
        }
        void LoadDSBaoGiaCuaLead()
        {
            dt = busBaoGia.SelectBaoGiaCuaLead(newBaoGia);
            //MaBaoGia, TenBaoGia, MaLead, HoTenLead, TongTienTruocGiam, MaGiamGia, PhanTramGiamGia, TongTien, TrangThaiBaoGia
            dt.Columns[0].ColumnName = "Mã báo giá";
            dt.Columns[1].ColumnName = "Tên báo giá";
            dt.Columns[2].ColumnName = "Mã Lead";
            dt.Columns[3].ColumnName = "Họ tên Lead";
            dt.Columns[4].ColumnName = "Tổng tiền trước giảm";
            dt.Columns[5].ColumnName = "Mã giảm giá";
            dt.Columns[6].ColumnName = "Phần trăm giảm giá";
            dt.Columns[7].ColumnName = "Thành tiền";
            dt.Columns[8].ColumnName = "Trạng thái";

            dataGridView1.DataSource = dt;

            dataGridView1.ReadOnly = true;
        }

        private void frmDSBaoGiaCuaLead_Load(object sender, EventArgs e)
        {
            newBaoGia.MaLead = SharedResources.MaLead;

            txtHoTenLead.Enabled = false;
            txtHoTenLead.Text = SharedResources.TenLead;  // fix cứng

            LoadDSBaoGiaCuaLead();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmBaoGia = new frmBaoGia();
            frmBaoGia.Closed += (s, args) => this.Close();
            frmBaoGia.Show();
            LoadDSBaoGiaCuaLead();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tempBaoGia = null;
            if (dataGridView1.RowCount > 0)
            {
                /*
                frmBaoGia.txtMaBaoGia.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                frmBaoGia.txtTenBaoGia.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                frmBaoGia.txtBaoGiaCuaLead.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                frmBaoGia.txtTongTienTrcGiam.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                frmBaoGia.txtThanhTien.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
 
                frmBaoGia.txtSoTienGiamGia.Text = ((float.Parse(dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString()) - (float.Parse(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString())).ToString();
                
                tempBaoGia.MaBaoGia = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                tempBaoGia.TenBaoGia = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                tempBaoGia.MaLead = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                tempBaoGia.HoTenLead = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                tempBaoGia.TongTienTruocGiam = float.Parse(dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString());
                tempBaoGia.MaGiamGia = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                if(dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString() == "")
                {
                    tempBaoGia.PhanTramGiamGia = 0;
                }
                else
                {
                    tempBaoGia.PhanTramGiamGia = int.Parse(dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString());
                }
                tempBaoGia.TongTien = float.Parse(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
                tempBaoGia.TrangThaiBaoGia = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                */
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*
            try 
            { 
                
                frmBaoGia.txtMaBaoGia.Text = tempBaoGia.MaBaoGia; 
            }
            catch (Exception ex)
            {
                return;
            }
            
            frmBaoGia.txtTenBaoGia.Text = tempBaoGia.TenBaoGia;
            // khóa học xử lý sau
            frmBaoGia.txtTongTienTrcGiam.Text = tempBaoGia.TongTienTruocGiam.ToString();
            //frmBaoGia.numUpDownPhanTramGiamGia.Value = (decimal)tempBaoGia.PhanTramGiamGia;
            frmBaoGia.txtSoTienGiamGia.Text = (tempBaoGia.TongTienTruocGiam - tempBaoGia.TongTien).ToString();
            frmBaoGia.txtThanhTien.Text = tempBaoGia.TongTien.ToString();
            

            this.Hide();
            frmBaoGia.ShowDialog();
            frmBaoGia = null;
            this.Show();
            LoadDSBaoGiaCuaLead();
            */

            DTO_BaoGia xoaBaoGia = new DTO_BaoGia();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Báo giá?", "Xác nhận xóa", MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        xoaBaoGia.MaBaoGia = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        xoaBaoGia.TrangThaiBaoGia = "Xóa mềm";

                        switch (busBaoGia.XoaBaoGia(xoaBaoGia))
                        {
                            case "Success":
                                MessageBox.Show("Xóa báo giá thành công");
                                LoadDSBaoGiaCuaLead();
                                break;

                            case "Fail":
                                MessageBox.Show("Xóa báo giá thất bại");
                                LoadDSBaoGiaCuaLead();
                                break;

                            case "Exception":
                                MessageBox.Show("Lỗi khác!");
                                break;
                        }
                    }
                    break;

                case DialogResult.Cancel:
                    this.TopMost = true;
                    break;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /*
            frmBaoGia.txtMaBaoGia.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            this.Hide();
            frmBaoGia.ShowDialog();
            frmBaoGia = null;
            this.Show();
            LoadDSBaoGiaCuaLead();
            */
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmSuaBaoGia = new frmSuaBaoGia();
            frmSuaBaoGia.Closed += (s, args) => this.Close();
            frmSuaBaoGia.Show();
            LoadDSBaoGiaCuaLead();
        }

        private void yêuCầuTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmThongTinLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
            LoadDSBaoGiaCuaLead();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm1 = new frmDSHoatDongLead();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
            LoadDSBaoGiaCuaLead();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                SharedResources.MaBaoGia = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                SharedResources.TenBaoGia = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                SharedResources.TongTienTrcGiam = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                SharedResources.ThanhTien = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                int a = int.Parse(SharedResources.TongTienTrcGiam);
                int b = int.Parse(SharedResources.ThanhTien);
                SharedResources.SoTienGiamGia =  (a-b).ToString();
                SharedResources.TrangThaiBaoGia = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                SharedResources.TenLead = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                this.Hide();
                var form2 = new frmSuaBaoGia();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmDSLead();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}