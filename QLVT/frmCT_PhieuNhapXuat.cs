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
    public partial class frmCT_PhieuNhapXuat : Form
    {
        String contro = "";
        public frmCT_PhieuNhapXuat()
        {
            InitializeComponent();
        }

        private void pHATSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_PHATSINH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void frmCT_PhieuNhapXuat_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qLVTDataSet.VatTu);

            this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);

            this.pHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHATSINHTableAdapter.Fill(this.qLVTDataSet.PHATSINH);
            btnbandau();
            txtMAVT.Text = cmbMAVT.SelectedValue.ToString();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            Program.control = "THEM";
            bdsCT_PHATSINH.AddNew();
            txtPHIEU.Text = ((DataRowView)bds_PHATSINH[bds_PHATSINH.Position])["PHIEU"].ToString();

            txtPHIEU.Enabled = false;
            btnTHEM.Enabled = false;
            btnSUA.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnHUY.Enabled = true;
            txtDONGIA.Enabled = true;
            SpinSOLUONG.Enabled = true;
            cmbMAVT.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.control == "THEM")
                {
                     bdsCT_PHATSINH.EndEdit();
                     bdsCT_PHATSINH.ResetCurrentItem();
                     this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
                     this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH);                                            
                     MessageBox.Show("THÊM THÀNH CÔNG", "", MessageBoxButtons.OK);
                     btnbandau();
                }
                if (Program.control == "SUA")
                {

                     bdsCT_PHATSINH.EndEdit();
                     bdsCT_PHATSINH.ResetCurrentItem();
                     this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
                     this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH);                   
                     MessageBox.Show("SỬA THÀNH CÔNG", "", MessageBoxButtons.OK);
                     btnbandau();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbMAVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtMVATTU.Text = cmbMVATTU.SelectedValue.ToString();
        }

        private void cmbMAVT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMAVT.SelectedIndex < 0) return;
            txtMAVT.Text = cmbMAVT.SelectedValue.ToString();
            
        }

        private void txtLOAI_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            Program.control = "SUA";
            txtPHIEU.Enabled = false;
            btnTHEM.Enabled = false;
            btnSUA.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnHUY.Enabled = true;
            txtDONGIA.Enabled = true;
            SpinSOLUONG.Enabled = true;
            
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            bdsCT_PHATSINH.RemoveCurrent();
            this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHATSINHTableAdapter.Update(this.qLVTDataSet.CT_PHATSINH);
            MessageBox.Show("XÓA THÀNH CÔNG", "", MessageBoxButtons.OK);
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            bdsCT_PHATSINH.CancelEdit();
            this.cT_PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHATSINHTableAdapter.Fill(this.qLVTDataSet.CT_PHATSINH);
            btnbandau();
        }

        private void btnbandau()
        {
            btnTHEM.Enabled = true;
            btnSUA.Enabled = true;
            btnXOA.Enabled = true;
            btnGHI.Enabled = false;
            btnHUY.Enabled = false;
            txtPHIEU.Enabled = false;
            txtDONGIA.Enabled = false;
            SpinSOLUONG.Enabled = false;
            cmbMAVT.Enabled = false;
        }
    }
}
