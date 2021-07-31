namespace QLVT
{
    partial class frmPhieuNhapXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pHIEULabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel1;
            System.Windows.Forms.Label lOAILabel1;
            System.Windows.Forms.Label label1;
            this.qLVTDataSet = new QLVT.QLVTDataSet();
            this.bdsPHATSINH = new System.Windows.Forms.BindingSource(this.components);
            this.pHATSINHTableAdapter = new QLVT.QLVTDataSetTableAdapters.PHATSINHTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXOA = new System.Windows.Forms.Button();
            this.cmbLOAI = new System.Windows.Forms.ComboBox();
            this.txtLOAI = new DevExpress.XtraEditors.TextEdit();
            this.btnGHI = new System.Windows.Forms.Button();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtHOTENKH = new DevExpress.XtraEditors.TextEdit();
            this.txtPHIEU = new DevExpress.XtraEditors.TextEdit();
            this.cT_PHATSINHTableAdapter = new QLVT.QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter();
            this.pHATSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_CT_PHATSINH = new System.Windows.Forms.BindingSource(this.components);
            pHIEULabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel1 = new System.Windows.Forms.Label();
            lOAILabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHATSINH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHIEU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_PHATSINH)).BeginInit();
            this.SuspendLayout();
            // 
            // pHIEULabel
            // 
            pHIEULabel.AutoSize = true;
            pHIEULabel.Location = new System.Drawing.Point(15, 39);
            pHIEULabel.Name = "pHIEULabel";
            pHIEULabel.Size = new System.Drawing.Size(53, 17);
            pHIEULabel.TabIndex = 0;
            pHIEULabel.Text = "PHIEU:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(16, 82);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(80, 17);
            hOTENKHLabel.TabIndex = 2;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(599, 36);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(51, 17);
            nGAYLabel.TabIndex = 6;
            nGAYLabel.Text = "NGAY:";
            // 
            // mANVLabel1
            // 
            mANVLabel1.AutoSize = true;
            mANVLabel1.Location = new System.Drawing.Point(599, 83);
            mANVLabel1.Name = "mANVLabel1";
            mANVLabel1.Size = new System.Drawing.Size(51, 17);
            mANVLabel1.TabIndex = 11;
            mANVLabel1.Text = "MANV:";
            // 
            // lOAILabel1
            // 
            lOAILabel1.AutoSize = true;
            lOAILabel1.Location = new System.Drawing.Point(338, 83);
            lOAILabel1.Name = "lOAILabel1";
            lOAILabel1.Size = new System.Drawing.Size(43, 17);
            lOAILabel1.TabIndex = 13;
            lOAILabel1.Text = "LOAI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(341, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 17);
            label1.TabIndex = 16;
            label1.Text = "LOAI:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPHATSINH
            // 
            this.bdsPHATSINH.DataMember = "PHATSINH";
            this.bdsPHATSINH.DataSource = this.qLVTDataSet;
            // 
            // pHATSINHTableAdapter
            // 
            this.pHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = null;
            this.tableAdapterManager.PHATSINHTableAdapter = this.pHATSINHTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXOA);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.cmbLOAI);
            this.groupBox1.Controls.Add(lOAILabel1);
            this.groupBox1.Controls.Add(this.txtLOAI);
            this.groupBox1.Controls.Add(this.btnGHI);
            this.groupBox1.Controls.Add(mANVLabel1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.btnHUY);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.DateEdit);
            this.groupBox1.Controls.Add(hOTENKHLabel);
            this.groupBox1.Controls.Add(this.txtHOTENKH);
            this.groupBox1.Controls.Add(pHIEULabel);
            this.groupBox1.Controls.Add(this.txtPHIEU);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(905, 57);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(116, 42);
            this.btnXOA.TabIndex = 17;
            this.btnXOA.Text = "XÓA";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLOAI
            // 
            this.cmbLOAI.FormattingEnabled = true;
            this.cmbLOAI.Items.AddRange(new object[] {
            "NHẬP",
            "XUẤT"});
            this.cmbLOAI.Location = new System.Drawing.Point(387, 33);
            this.cmbLOAI.Name = "cmbLOAI";
            this.cmbLOAI.Size = new System.Drawing.Size(186, 24);
            this.cmbLOAI.TabIndex = 15;
            this.cmbLOAI.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtLOAI
            // 
            this.txtLOAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPHATSINH, "LOAI", true));
            this.txtLOAI.Enabled = false;
            this.txtLOAI.Location = new System.Drawing.Point(387, 80);
            this.txtLOAI.Name = "txtLOAI";
            this.txtLOAI.Size = new System.Drawing.Size(186, 22);
            this.txtLOAI.TabIndex = 14;
            // 
            // btnGHI
            // 
            this.btnGHI.Location = new System.Drawing.Point(905, 111);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(116, 34);
            this.btnGHI.TabIndex = 13;
            this.btnGHI.Text = "GHI";
            this.btnGHI.UseVisualStyleBackColor = true;
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPHATSINH, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(656, 80);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(220, 22);
            this.txtMaNV.TabIndex = 12;
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(905, 161);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(116, 30);
            this.btnHUY.TabIndex = 11;
            this.btnHUY.Text = "HUY";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(905, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 30);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "THÊM";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DateEdit
            // 
            this.DateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPHATSINH, "NGAY", true));
            this.DateEdit.EditValue = null;
            this.DateEdit.Location = new System.Drawing.Point(656, 33);
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.Size = new System.Drawing.Size(220, 22);
            this.DateEdit.TabIndex = 7;
            // 
            // txtHOTENKH
            // 
            this.txtHOTENKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPHATSINH, "HOTENKH", true));
            this.txtHOTENKH.Location = new System.Drawing.Point(102, 79);
            this.txtHOTENKH.Name = "txtHOTENKH";
            this.txtHOTENKH.Size = new System.Drawing.Size(210, 22);
            this.txtHOTENKH.TabIndex = 3;
            // 
            // txtPHIEU
            // 
            this.txtPHIEU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPHATSINH, "PHIEU", true));
            this.txtPHIEU.Location = new System.Drawing.Point(102, 33);
            this.txtPHIEU.Name = "txtPHIEU";
            this.txtPHIEU.Size = new System.Drawing.Size(210, 22);
            this.txtPHIEU.TabIndex = 1;
            // 
            // cT_PHATSINHTableAdapter
            // 
            this.cT_PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // pHATSINHGridControl
            // 
            this.pHATSINHGridControl.DataSource = this.bdsPHATSINH;
            this.pHATSINHGridControl.Location = new System.Drawing.Point(12, 12);
            this.pHATSINHGridControl.MainView = this.gridView1;
            this.pHATSINHGridControl.Name = "pHATSINHGridControl";
            this.pHATSINHGridControl.Size = new System.Drawing.Size(1066, 334);
            this.pHATSINHGridControl.TabIndex = 2;
            this.pHATSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU,
            this.colLOAI,
            this.colMANV,
            this.colHOTENKH,
            this.colNGAY});
            this.gridView1.GridControl = this.pHATSINHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colPHIEU
            // 
            this.colPHIEU.FieldName = "PHIEU";
            this.colPHIEU.MinWidth = 25;
            this.colPHIEU.Name = "colPHIEU";
            this.colPHIEU.OptionsColumn.ReadOnly = true;
            this.colPHIEU.Visible = true;
            this.colPHIEU.VisibleIndex = 0;
            this.colPHIEU.Width = 94;
            // 
            // colLOAI
            // 
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.MinWidth = 25;
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.OptionsColumn.ReadOnly = true;
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 1;
            this.colLOAI.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            this.colMANV.Width = 94;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.ReadOnly = true;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 3;
            this.colHOTENKH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.ReadOnly = true;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 4;
            this.colNGAY.Width = 94;
            // 
            // bds_CT_PHATSINH
            // 
            this.bds_CT_PHATSINH.DataMember = "FK_CT_PHATSINH_PHATSINH1";
            this.bds_CT_PHATSINH.DataSource = this.bdsPHATSINH;
            // 
            // frmPhieuNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 574);
            this.Controls.Add(this.pHATSINHGridControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuNhapXuat";
            this.Text = "frmPhieuNhapXuat";
            this.Load += new System.EventHandler(this.frmPhieuNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHATSINH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHIEU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_PHATSINH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bdsPHATSINH;
        private QLVTDataSetTableAdapters.PHATSINHTableAdapter pHATSINHTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.DateEdit DateEdit;
        private DevExpress.XtraEditors.TextEdit txtHOTENKH;
        private DevExpress.XtraEditors.TextEdit txtPHIEU;
        private System.Windows.Forms.Button btnGHI;
        private DevExpress.XtraEditors.TextEdit txtLOAI;
        private System.Windows.Forms.ComboBox cmbLOAI;
        private System.Windows.Forms.Button btnXOA;
        private QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter cT_PHATSINHTableAdapter;
        private DevExpress.XtraGrid.GridControl pHATSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private System.Windows.Forms.BindingSource bds_CT_PHATSINH;
    }
}