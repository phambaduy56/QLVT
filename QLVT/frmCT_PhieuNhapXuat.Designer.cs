namespace QLVT
{
    partial class frmCT_PhieuNhapXuat
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.qLVTDataSet = new QLVT.QLVTDataSet();
            this.bds_PHATSINH = new System.Windows.Forms.BindingSource(this.components);
            this.pHATSINHTableAdapter = new QLVT.QLVTDataSetTableAdapters.PHATSINHTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cT_PHATSINHTableAdapter = new QLVT.QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter();
            this.pHATSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMAVT = new System.Windows.Forms.ComboBox();
            this.bdsVATTU = new System.Windows.Forms.BindingSource(this.components);
            this.txtDONGIA = new DevExpress.XtraEditors.TextEdit();
            this.bdsCT_PHATSINH = new System.Windows.Forms.BindingSource(this.components);
            this.SpinSOLUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.txtPHIEU = new DevExpress.XtraEditors.TextEdit();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnGHI = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.vatTuTableAdapter = new QLVT.QLVTDataSetTableAdapters.VatTuTableAdapter();
            this.cT_PHATSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPHIEU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            pHIEULabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PHATSINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVATTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHATSINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinSOLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHIEU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pHIEULabel
            // 
            pHIEULabel.AutoSize = true;
            pHIEULabel.Location = new System.Drawing.Point(8, 49);
            pHIEULabel.Name = "pHIEULabel";
            pHIEULabel.Size = new System.Drawing.Size(53, 17);
            pHIEULabel.TabIndex = 12;
            pHIEULabel.Text = "PHIEU:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(11, 147);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(50, 17);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(339, 51);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 17);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(339, 145);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(66, 17);
            dONGIALabel.TabIndex = 15;
            dONGIALabel.Text = "DONGIA:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_PHATSINH
            // 
            this.bds_PHATSINH.DataMember = "PHATSINH";
            this.bds_PHATSINH.DataSource = this.qLVTDataSet;
            // 
            // pHATSINHTableAdapter
            // 
            this.pHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = this.cT_PHATSINHTableAdapter;
            this.tableAdapterManager.PHATSINHTableAdapter = this.pHATSINHTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // cT_PHATSINHTableAdapter
            // 
            this.cT_PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // pHATSINHGridControl
            // 
            this.pHATSINHGridControl.DataSource = this.bds_PHATSINH;
            this.pHATSINHGridControl.Location = new System.Drawing.Point(810, 285);
            this.pHATSINHGridControl.MainView = this.gridView1;
            this.pHATSINHGridControl.Name = "pHATSINHGridControl";
            this.pHATSINHGridControl.Size = new System.Drawing.Size(565, 319);
            this.pHATSINHGridControl.TabIndex = 1;
            this.pHATSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU,
            this.colNGAY,
            this.colLOAI,
            this.colHOTENKH,
            this.colMANV});
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
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.ReadOnly = true;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colLOAI
            // 
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.MinWidth = 25;
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.OptionsColumn.ReadOnly = true;
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 2;
            this.colLOAI.Width = 94;
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
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMAVT);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.txtDONGIA);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(this.SpinSOLUONG);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.txtMAVT);
            this.groupBox1.Controls.Add(pHIEULabel);
            this.groupBox1.Controls.Add(this.txtPHIEU);
            this.groupBox1.Controls.Add(this.btnHUY);
            this.groupBox1.Controls.Add(this.btnGHI);
            this.groupBox1.Controls.Add(this.btnXOA);
            this.groupBox1.Controls.Add(this.btnSUA);
            this.groupBox1.Controls.Add(this.btnTHEM);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 319);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbMAVT
            // 
            this.cmbMAVT.DataSource = this.bdsVATTU;
            this.cmbMAVT.DisplayMember = "TENVL";
            this.cmbMAVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAVT.FormattingEnabled = true;
            this.cmbMAVT.Location = new System.Drawing.Point(67, 114);
            this.cmbMAVT.Name = "cmbMAVT";
            this.cmbMAVT.Size = new System.Drawing.Size(213, 24);
            this.cmbMAVT.TabIndex = 17;
            this.cmbMAVT.ValueMember = "MAVT";
            this.cmbMAVT.SelectedIndexChanged += new System.EventHandler(this.cmbMAVT_SelectedIndexChanged_1);
            // 
            // bdsVATTU
            // 
            this.bdsVATTU.DataMember = "VatTu";
            this.bdsVATTU.DataSource = this.qLVTDataSet;
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PHATSINH, "DONGIA", true));
            this.txtDONGIA.Location = new System.Drawing.Point(427, 142);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Size = new System.Drawing.Size(213, 22);
            this.txtDONGIA.TabIndex = 16;
            // 
            // bdsCT_PHATSINH
            // 
            this.bdsCT_PHATSINH.DataMember = "FK_CT_PHATSINH_PHATSINH1";
            this.bdsCT_PHATSINH.DataSource = this.bds_PHATSINH;
            // 
            // SpinSOLUONG
            // 
            this.SpinSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PHATSINH, "SOLUONG", true));
            this.SpinSOLUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinSOLUONG.Location = new System.Drawing.Point(427, 48);
            this.SpinSOLUONG.Name = "SpinSOLUONG";
            this.SpinSOLUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinSOLUONG.Size = new System.Drawing.Size(213, 24);
            this.SpinSOLUONG.TabIndex = 15;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PHATSINH, "MAVT", true));
            this.txtMAVT.Enabled = false;
            this.txtMAVT.Location = new System.Drawing.Point(67, 144);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(213, 22);
            this.txtMAVT.TabIndex = 14;
            this.txtMAVT.EditValueChanged += new System.EventHandler(this.txtLOAI_EditValueChanged);
            // 
            // txtPHIEU
            // 
            this.txtPHIEU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PHATSINH, "PHIEU", true));
            this.txtPHIEU.Location = new System.Drawing.Point(67, 46);
            this.txtPHIEU.Name = "txtPHIEU";
            this.txtPHIEU.Size = new System.Drawing.Size(213, 22);
            this.txtPHIEU.TabIndex = 13;
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(663, 217);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(93, 38);
            this.btnHUY.TabIndex = 12;
            this.btnHUY.Text = "HỦY";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.Location = new System.Drawing.Point(509, 217);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(93, 38);
            this.btnGHI.TabIndex = 11;
            this.btnGHI.Text = "GHI";
            this.btnGHI.UseVisualStyleBackColor = true;
            this.btnGHI.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(347, 217);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(93, 38);
            this.btnXOA.TabIndex = 10;
            this.btnXOA.Text = "XÓA";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(187, 217);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(93, 38);
            this.btnSUA.TabIndex = 9;
            this.btnSUA.Text = "SỬA";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(30, 217);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(93, 38);
            this.btnTHEM.TabIndex = 8;
            this.btnTHEM.Text = "THÊM";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHATSINHGridControl
            // 
            this.cT_PHATSINHGridControl.DataSource = this.bdsCT_PHATSINH;
            this.cT_PHATSINHGridControl.Location = new System.Drawing.Point(12, 12);
            this.cT_PHATSINHGridControl.MainView = this.gridView2;
            this.cT_PHATSINHGridControl.Name = "cT_PHATSINHGridControl";
            this.cT_PHATSINHGridControl.Size = new System.Drawing.Size(1371, 267);
            this.cT_PHATSINHGridControl.TabIndex = 2;
            this.cT_PHATSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cT_PHATSINHGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colPHIEU1
            // 
            this.colPHIEU1.FieldName = "PHIEU";
            this.colPHIEU1.MinWidth = 25;
            this.colPHIEU1.Name = "colPHIEU1";
            this.colPHIEU1.OptionsColumn.ReadOnly = true;
            this.colPHIEU1.Visible = true;
            this.colPHIEU1.VisibleIndex = 0;
            this.colPHIEU1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.ReadOnly = true;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.ReadOnly = true;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.ReadOnly = true;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // frmCT_PhieuNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 624);
            this.Controls.Add(this.cT_PHATSINHGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pHATSINHGridControl);
            this.Name = "frmCT_PhieuNhapXuat";
            this.Text = "frmCT_PhieuNhapXuat";
            this.Load += new System.EventHandler(this.frmCT_PhieuNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PHATSINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVATTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHATSINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinSOLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHIEU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bds_PHATSINH;
        private QLVTDataSetTableAdapters.PHATSINHTableAdapter pHATSINHTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter cT_PHATSINHTableAdapter;
        private DevExpress.XtraGrid.GridControl pHATSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnGHI;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.BindingSource bdsVATTU;
        private QLVTDataSetTableAdapters.VatTuTableAdapter vatTuTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_PHATSINH;
        private DevExpress.XtraGrid.GridControl cT_PHATSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtDONGIA;
        private DevExpress.XtraEditors.SpinEdit SpinSOLUONG;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.ComboBox cmbMAVT;
    }
}