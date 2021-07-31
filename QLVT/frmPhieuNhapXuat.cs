using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmPhieuNhapXuat : Form
    {
        String mPhieu = "";
        public frmPhieuNhapXuat()
        {
            InitializeComponent();
        }

        private void pHATSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPHATSINH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmPhieuNhapXuat_Load(object sender, EventArgs e)
        {


            qLVTDataSet.EnforceConstraints = false;

            this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
           
            this.pHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHATSINHTableAdapter.Fill(this.qLVTDataSet.PHATSINH);

            cmbLOAI.SelectedIndex = 0;
            txtLOAI.Text = "N";
            txtPHIEU.Enabled = txtMaNV.Enabled  = txtHOTENKH.Enabled = false;
            DateEdit.Enabled = false;
            cmbLOAI.Enabled = false;
            btnGHI.Enabled = false;
          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bdsPHATSINH.AddNew();
            txtPHIEU.Enabled = txtMaNV.Enabled = txtHOTENKH.Enabled = true;
            DateEdit.Enabled = true;
            cmbLOAI.Enabled = true;
            btnGHI.Enabled = true;
            btnXOA.Enabled = false;
            btnOK.Enabled = false;
        }


        private void btnGHI_Click(object sender, EventArgs e)
        {
            // mPhieu = ((DataRowView)bdsPHATSINH[0])["PHIEU"].ToString();
            try
            {
                if (txtPHIEU.Text == "")
                {
                    MessageBox.Show("PHIẾU KHÔNG ĐƯỢC RỖNG!");
                }
                else if (txtHOTENKH.Text == "")
                {
                    MessageBox.Show("HỌ TÊN KHÁCH HÀNG KHÔNG ĐƯỢC RỖNG!");
                }
                else if (txtMaNV.Text == "")
                {
                    MessageBox.Show("MÃ NHÂN VIÊN KHÔNG ĐƯỢC RỖNG KHÔNG ĐƯỢC RỖNG!");
                }
                else if (DateEdit.Text == "")
                {
                    MessageBox.Show("MÃ NHÂN VIÊN KHÔNG ĐƯỢC RỖNG KHÔNG ĐƯỢC RỖNG!");
                }
                else
                {
                    bdsPHATSINH.EndEdit();
                    bdsPHATSINH.ResetCurrentItem();
                    this.pHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH);
                    txtPHIEU.Enabled = txtMaNV.Enabled = txtHOTENKH.Enabled = false;
                    DateEdit.Enabled = false;
                    cmbLOAI.Enabled = false;
                    btnGHI.Enabled = false;
                    btnOK.Enabled = true;
                    btnXOA.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã phiếu không được trùng!", "", MessageBoxButtons.OK);
            }

        }

        private void cmbLOAI_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLOAI.SelectedItem.ToString().Equals("NHẬP"))
                txtLOAI.Text = "N";
            else
                txtLOAI.Text = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bds_CT_PHATSINH.Count > 0)
            {
                MessageBox.Show("PHIẾU ĐANG CÓ VẬT TƯ NHẬP XUẤT KHÔNG THỂ XÓA!");
            }
            else
            {
                bdsPHATSINH.RemoveCurrent();
                this.pHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHATSINHTableAdapter.Update(this.qLVTDataSet.PHATSINH);
            }
          
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            bdsPHATSINH.CancelEdit();
            this.pHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHATSINHTableAdapter.Fill(this.qLVTDataSet.PHATSINH);
            txtPHIEU.Enabled = txtMaNV.Enabled = txtHOTENKH.Enabled = false;
            DateEdit.Enabled = false;
            cmbLOAI.Enabled = false;
            btnGHI.Enabled = false;
            btnOK.Enabled = true;
            btnXOA.Enabled = true;
        }
    }
}
