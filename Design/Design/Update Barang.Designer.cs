namespace Design
{
    partial class UpdateBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBarang));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.jenisBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJenisBarang = new Design.dsJenisBarang();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStokBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bttnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodejenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisibarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarang = new Design.dsBarang();
            this.btnCari = new System.Windows.Forms.Button();
            this.barangTableAdapter = new Design.dsBarangTableAdapters.BarangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.jenisBarangTableAdapter = new Design.dsJenisBarangTableAdapters.JenisBarangTableAdapter();
            this.rbRusak = new System.Windows.Forms.RadioButton();
            this.rbBaik = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dsSupplier = new Design.dsSupplier();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Design.dsSupplierTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJenisBarang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmbJenis
            // 
            this.cmbJenis.DataSource = this.jenisBarangBindingSource;
            this.cmbJenis.DisplayMember = "nama_jenis";
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(901, 154);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(136, 28);
            this.cmbJenis.TabIndex = 70;
            this.cmbJenis.ValueMember = "kode_jenis";
            // 
            // jenisBarangBindingSource
            // 
            this.jenisBarangBindingSource.DataMember = "JenisBarang";
            this.jenisBarangBindingSource.DataSource = this.dsJenisBarang;
            // 
            // dsJenisBarang
            // 
            this.dsJenisBarang.DataSetName = "dsJenisBarang";
            this.dsJenisBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(874, 211);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 25);
            this.label17.TabIndex = 69;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(707, 210);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 25);
            this.label18.TabIndex = 68;
            this.label18.Text = "Kondisi Barang";
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(325, 96);
            this.txtIdBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(114, 26);
            this.txtIdBarang.TabIndex = 67;
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBatal.BackColor = System.Drawing.Color.Gray;
            this.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatal.BorderRadius = 0;
            this.btnBatal.ButtonText = "       Batal";
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.btnBatal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatal.Iconimage = null;
            this.btnBatal.Iconimage_right = null;
            this.btnBatal.Iconimage_right_Selected = null;
            this.btnBatal.Iconimage_Selected = null;
            this.btnBatal.IconMarginLeft = 0;
            this.btnBatal.IconMarginRight = 0;
            this.btnBatal.IconRightVisible = true;
            this.btnBatal.IconRightZoom = 0D;
            this.btnBatal.IconVisible = true;
            this.btnBatal.IconZoom = 90D;
            this.btnBatal.IsTab = false;
            this.btnBatal.Location = new System.Drawing.Point(647, 405);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.Gray;
            this.btnBatal.OnHovercolor = System.Drawing.Color.Red;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(118, 57);
            this.btnBatal.TabIndex = 66;
            this.btnBatal.Text = "       Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.Black;
            this.btnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSimpan.BackColor = System.Drawing.Color.Gray;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "     Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSimpan.Iconimage = null;
            this.btnSimpan.Iconimage_right = null;
            this.btnSimpan.Iconimage_right_Selected = null;
            this.btnSimpan.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Iconimage_Selected")));
            this.btnSimpan.IconMarginLeft = 0;
            this.btnSimpan.IconMarginRight = 0;
            this.btnSimpan.IconRightVisible = true;
            this.btnSimpan.IconRightZoom = 0D;
            this.btnSimpan.IconVisible = true;
            this.btnSimpan.IconZoom = 90D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(345, 405);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.Gray;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(118, 57);
            this.btnSimpan.TabIndex = 65;
            this.btnSimpan.Text = "     Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.Black;
            this.btnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(874, 156);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 25);
            this.label16.TabIndex = 64;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(874, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 25);
            this.label15.TabIndex = 63;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 214);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 25);
            this.label14.TabIndex = 62;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 25);
            this.label13.TabIndex = 61;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(298, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 25);
            this.label12.TabIndex = 60;
            this.label12.Text = ":";
            // 
            // txtStokBarang
            // 
            this.txtStokBarang.Location = new System.Drawing.Point(901, 88);
            this.txtStokBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStokBarang.Name = "txtStokBarang";
            this.txtStokBarang.Size = new System.Drawing.Size(202, 26);
            this.txtStokBarang.TabIndex = 59;
            this.txtStokBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokBarang_KeyPress);
            this.txtStokBarang.Leave += new System.EventHandler(this.txtStokBarang_Leave);
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.Location = new System.Drawing.Point(366, 216);
            this.txtHargaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(145, 26);
            this.txtHargaBarang.TabIndex = 58;
            this.txtHargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBarang_KeyPress);
            this.txtHargaBarang.Leave += new System.EventHandler(this.txtHargaBarang_Leave);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(325, 154);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(270, 26);
            this.txtNamaBarang.TabIndex = 57;
            this.txtNamaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaBarang_KeyPress);
            this.txtNamaBarang.Leave += new System.EventHandler(this.txtNamaBarang_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(707, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Jenis Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(707, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "Stok Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Harga Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Nama Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "ID Barang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 60);
            this.panel2.TabIndex = 72;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(188)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1143, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 147;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bttnBatal
            // 
            this.bttnBatal.Location = new System.Drawing.Point(754, 583);
            this.bttnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnBatal.Name = "bttnBatal";
            this.bttnBatal.Size = new System.Drawing.Size(112, 35);
            this.bttnBatal.TabIndex = 77;
            this.bttnBatal.Text = "Batal";
            this.bttnBatal.UseVisualStyleBackColor = true;
            this.bttnBatal.Click += new System.EventHandler(this.bttnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(573, 583);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(112, 35);
            this.btnHapus.TabIndex = 76;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Location = new System.Drawing.Point(400, 583);
            this.btnPerbarui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(112, 35);
            this.btnPerbarui.TabIndex = 75;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.kodejenisDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokbarangDataGridViewTextBoxColumn,
            this.hargabarangDataGridViewTextBoxColumn,
            this.kondisibarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 305);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 268);
            this.dataGridView1.TabIndex = 74;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodejenisDataGridViewTextBoxColumn
            // 
            this.kodejenisDataGridViewTextBoxColumn.DataPropertyName = "kode_jenis";
            this.kodejenisDataGridViewTextBoxColumn.HeaderText = "kode_jenis";
            this.kodejenisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodejenisDataGridViewTextBoxColumn.Name = "kodejenisDataGridViewTextBoxColumn";
            this.kodejenisDataGridViewTextBoxColumn.Width = 150;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // stokbarangDataGridViewTextBoxColumn
            // 
            this.stokbarangDataGridViewTextBoxColumn.DataPropertyName = "stok_barang";
            this.stokbarangDataGridViewTextBoxColumn.HeaderText = "stok_barang";
            this.stokbarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stokbarangDataGridViewTextBoxColumn.Name = "stokbarangDataGridViewTextBoxColumn";
            this.stokbarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargabarangDataGridViewTextBoxColumn
            // 
            this.hargabarangDataGridViewTextBoxColumn.DataPropertyName = "harga_barang";
            this.hargabarangDataGridViewTextBoxColumn.HeaderText = "harga_barang";
            this.hargabarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargabarangDataGridViewTextBoxColumn.Name = "hargabarangDataGridViewTextBoxColumn";
            this.hargabarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // kondisibarangDataGridViewTextBoxColumn
            // 
            this.kondisibarangDataGridViewTextBoxColumn.DataPropertyName = "kondisi_barang";
            this.kondisibarangDataGridViewTextBoxColumn.HeaderText = "kondisi_barang";
            this.kondisibarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kondisibarangDataGridViewTextBoxColumn.Name = "kondisibarangDataGridViewTextBoxColumn";
            this.kondisibarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dsBarang;
            // 
            // dsBarang
            // 
            this.dsBarang.DataSetName = "dsBarang";
            this.dsBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(460, 92);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(112, 35);
            this.btnCari.TabIndex = 73;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Rp.";
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // jenisBarangTableAdapter
            // 
            this.jenisBarangTableAdapter.ClearBeforeFill = true;
            // 
            // rbRusak
            // 
            this.rbRusak.AutoSize = true;
            this.rbRusak.Location = new System.Drawing.Point(1035, 212);
            this.rbRusak.Name = "rbRusak";
            this.rbRusak.Size = new System.Drawing.Size(80, 24);
            this.rbRusak.TabIndex = 84;
            this.rbRusak.TabStop = true;
            this.rbRusak.Text = "Rusak";
            this.rbRusak.UseVisualStyleBackColor = true;
            this.rbRusak.CheckedChanged += new System.EventHandler(this.rbRusak_CheckedChanged);
            // 
            // rbBaik
            // 
            this.rbBaik.AutoSize = true;
            this.rbBaik.Location = new System.Drawing.Point(901, 212);
            this.rbBaik.Name = "rbBaik";
            this.rbBaik.Size = new System.Drawing.Size(65, 24);
            this.rbBaik.TabIndex = 83;
            this.rbBaik.TabStop = true;
            this.rbBaik.Text = "Baik";
            this.rbBaik.UseVisualStyleBackColor = true;
            this.rbBaik.CheckedChanged += new System.EventHandler(this.rbBaik_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(874, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "ID Supplier";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DataSource = this.supplierBindingSource;
            this.cmbSupplier.DisplayMember = "nama_supplier";
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(901, 255);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(136, 28);
            this.cmbSupplier.TabIndex = 87;
            this.cmbSupplier.ValueMember = "id_supplier";
            // 
            // dsSupplier
            // 
            this.dsSupplier.DataSetName = "dsSupplier";
            this.dsSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.dsSupplier;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1202, 632);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbRusak);
            this.Controls.Add(this.rbBaik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnPerbarui);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIdBarang);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStokBarang);
            this.Controls.Add(this.txtHargaBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBarang";
            this.Text = "UpdateBarang";
            this.Load += new System.EventHandler(this.UpdateBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJenisBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdBarang;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStokBarang;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Button bttnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCari;
        private dsBarang dsBarang;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private dsBarangTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodejenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisibarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private dsJenisBarang dsJenisBarang;
        private System.Windows.Forms.BindingSource jenisBarangBindingSource;
        private dsJenisBarangTableAdapters.JenisBarangTableAdapter jenisBarangTableAdapter;
        private System.Windows.Forms.RadioButton rbRusak;
        private System.Windows.Forms.RadioButton rbBaik;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private dsSupplier dsSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private dsSupplierTableAdapters.SupplierTableAdapter supplierTableAdapter;
    }
}