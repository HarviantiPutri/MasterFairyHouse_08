namespace Bahan_dan_Jenis
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIdBahan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStokBahan = new System.Windows.Forms.TextBox();
            this.txtWarnaBahan = new System.Windows.Forms.TextBox();
            this.txtHargaBahan = new System.Windows.Forms.TextBox();
            this.txtNamaBahan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHapus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPerbarui = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.rbRusak = new System.Windows.Forms.RadioButton();
            this.rbBaik = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dsBahan = new Design.dsBahan();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter = new Design.dsBahanTableAdapters.BahanTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Bahan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(188)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(764, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 132;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(189, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 123;
            this.label20.Text = "Rp.";
            // 
            // txtIdBahan
            // 
            this.txtIdBahan.Location = new System.Drawing.Point(192, 85);
            this.txtIdBahan.Name = "txtIdBahan";
            this.txtIdBahan.Size = new System.Drawing.Size(131, 20);
            this.txtIdBahan.TabIndex = 118;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(558, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 16);
            this.label16.TabIndex = 117;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(558, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 116;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(174, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 115;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(174, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 114;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(174, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 113;
            this.label12.Text = ":";
            // 
            // txtStokBahan
            // 
            this.txtStokBahan.Location = new System.Drawing.Point(576, 123);
            this.txtStokBahan.Name = "txtStokBahan";
            this.txtStokBahan.Size = new System.Drawing.Size(73, 20);
            this.txtStokBahan.TabIndex = 112;
            this.txtStokBahan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokBahan_KeyPress);
            this.txtStokBahan.Leave += new System.EventHandler(this.txtStokBahan_Leave);
            // 
            // txtWarnaBahan
            // 
            this.txtWarnaBahan.Location = new System.Drawing.Point(576, 80);
            this.txtWarnaBahan.Name = "txtWarnaBahan";
            this.txtWarnaBahan.Size = new System.Drawing.Size(136, 20);
            this.txtWarnaBahan.TabIndex = 111;
            this.txtWarnaBahan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarnaBahan_KeyPress);
            this.txtWarnaBahan.Leave += new System.EventHandler(this.txtWarnaBahan_Leave);
            // 
            // txtHargaBahan
            // 
            this.txtHargaBahan.Location = new System.Drawing.Point(213, 161);
            this.txtHargaBahan.Name = "txtHargaBahan";
            this.txtHargaBahan.Size = new System.Drawing.Size(120, 20);
            this.txtHargaBahan.TabIndex = 110;
            this.txtHargaBahan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBahan_KeyPress);
            this.txtHargaBahan.Leave += new System.EventHandler(this.txtHargaBahan_Leave);
            // 
            // txtNamaBahan
            // 
            this.txtNamaBahan.Location = new System.Drawing.Point(192, 123);
            this.txtNamaBahan.Name = "txtNamaBahan";
            this.txtNamaBahan.Size = new System.Drawing.Size(181, 20);
            this.txtNamaBahan.TabIndex = 109;
            this.txtNamaBahan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaBahan_KeyPress);
            this.txtNamaBahan.Leave += new System.EventHandler(this.txtNamaBahan_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 108;
            this.label11.Text = "Stok Bahan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Stok Bahan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(447, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "Warna Bahan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Warna Bahan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 104;
            this.label9.Text = "Harga Bahan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Harga Bahan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Nama Bahan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Nama Bahan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 100;
            this.label7.Text = "ID Bahan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "ID Bahan";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Black;
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.ImageActive = null;
            this.btnCari.Location = new System.Drawing.Point(329, 77);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(30, 28);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCari.TabIndex = 98;
            this.btnCari.TabStop = false;
            this.btnCari.Zoom = 10;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHapus.BackColor = System.Drawing.Color.Gray;
            this.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapus.BorderRadius = 0;
            this.btnHapus.ButtonText = "     Hapus";
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.btnHapus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapus.Iconimage = null;
            this.btnHapus.Iconimage_right = null;
            this.btnHapus.Iconimage_right_Selected = null;
            this.btnHapus.Iconimage_Selected = null;
            this.btnHapus.IconMarginLeft = 0;
            this.btnHapus.IconMarginRight = 0;
            this.btnHapus.IconRightVisible = true;
            this.btnHapus.IconRightZoom = 0D;
            this.btnHapus.IconVisible = true;
            this.btnHapus.IconZoom = 90D;
            this.btnHapus.IsTab = false;
            this.btnHapus.Location = new System.Drawing.Point(339, 386);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.Gray;
            this.btnHapus.OnHovercolor = System.Drawing.Color.Red;
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(79, 37);
            this.btnHapus.TabIndex = 126;
            this.btnHapus.Text = "     Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Textcolor = System.Drawing.Color.Black;
            this.btnHapus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPerbarui.BackColor = System.Drawing.Color.Gray;
            this.btnPerbarui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerbarui.BorderRadius = 0;
            this.btnPerbarui.ButtonText = "   Perbarui";
            this.btnPerbarui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerbarui.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.btnPerbarui.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerbarui.Iconimage = null;
            this.btnPerbarui.Iconimage_right = null;
            this.btnPerbarui.Iconimage_right_Selected = null;
            this.btnPerbarui.Iconimage_Selected = null;
            this.btnPerbarui.IconMarginLeft = 0;
            this.btnPerbarui.IconMarginRight = 0;
            this.btnPerbarui.IconRightVisible = true;
            this.btnPerbarui.IconRightZoom = 0D;
            this.btnPerbarui.IconVisible = true;
            this.btnPerbarui.IconZoom = 90D;
            this.btnPerbarui.IsTab = false;
            this.btnPerbarui.Location = new System.Drawing.Point(213, 386);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Normalcolor = System.Drawing.Color.Gray;
            this.btnPerbarui.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPerbarui.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPerbarui.selected = false;
            this.btnPerbarui.Size = new System.Drawing.Size(79, 37);
            this.btnPerbarui.TabIndex = 125;
            this.btnPerbarui.Text = "   Perbarui";
            this.btnPerbarui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerbarui.Textcolor = System.Drawing.Color.Black;
            this.btnPerbarui.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(471, 386);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.Gray;
            this.btnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(79, 37);
            this.btnBatal.TabIndex = 124;
            this.btnBatal.Text = "       Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.Black;
            this.btnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bunifuCustomDataGrid1.DataSource = this.bahanBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SandyBrown;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(77, 230);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(653, 150);
            this.bunifuCustomDataGrid1.TabIndex = 127;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(559, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 16);
            this.label22.TabIndex = 135;
            this.label22.Text = ":";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(577, 191);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplier.TabIndex = 134;
            this.cmbSupplier.ValueMember = "id_supplier";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(447, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 16);
            this.label21.TabIndex = 133;
            this.label21.Text = "ID Supplier";
            // 
            // rbRusak
            // 
            this.rbRusak.AutoSize = true;
            this.rbRusak.Location = new System.Drawing.Point(656, 158);
            this.rbRusak.Name = "rbRusak";
            this.rbRusak.Size = new System.Drawing.Size(56, 17);
            this.rbRusak.TabIndex = 132;
            this.rbRusak.TabStop = true;
            this.rbRusak.Text = "Rusak";
            this.rbRusak.UseVisualStyleBackColor = true;
            // 
            // rbBaik
            // 
            this.rbBaik.AutoSize = true;
            this.rbBaik.Location = new System.Drawing.Point(590, 159);
            this.rbBaik.Name = "rbBaik";
            this.rbBaik.Size = new System.Drawing.Size(46, 17);
            this.rbBaik.TabIndex = 131;
            this.rbBaik.TabStop = true;
            this.rbBaik.Text = "Baik";
            this.rbBaik.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(559, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 16);
            this.label23.TabIndex = 130;
            this.label23.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(451, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 16);
            this.label24.TabIndex = 128;
            this.label24.Text = "Kondisi Bahan";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(460, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 129;
            this.label25.Text = "Stok Bahan";
            // 
            // dsBahan
            // 
            this.dsBahan.DataSetName = "dsBahan";
            this.dsBahan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bahanBindingSource
            // 
            this.bahanBindingSource.DataMember = "Bahan";
            this.bahanBindingSource.DataSource = this.dsBahan;
            // 
            // bahanTableAdapter
            // 
            this.bahanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bahan";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bahan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_bahan";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_bahan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "warna_bahan";
            this.dataGridViewTextBoxColumn3.HeaderText = "warna_bahan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stok_bahan";
            this.dataGridViewTextBoxColumn4.HeaderText = "stok_bahan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "harga_bahan";
            this.dataGridViewTextBoxColumn5.HeaderText = "harga_bahan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kondisi_bahan";
            this.dataGridViewTextBoxColumn6.HeaderText = "kondisi_bahan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rbRusak);
            this.Controls.Add(this.rbBaik);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnPerbarui);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtIdBahan);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStokBahan);
            this.Controls.Add(this.txtWarnaBahan);
            this.Controls.Add(this.txtHargaBahan);
            this.Controls.Add(this.txtNamaBahan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapus;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerbarui;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIdBahan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStokBahan;
        private System.Windows.Forms.TextBox txtWarnaBahan;
        private System.Windows.Forms.TextBox txtHargaBahan;
        private System.Windows.Forms.TextBox txtNamaBahan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnCari;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton rbRusak;
        private System.Windows.Forms.RadioButton rbBaik;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn idbahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warnabahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisibahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupplierDataGridViewTextBoxColumn;
        private Design.dsBahan dsBahan;
        private System.Windows.Forms.BindingSource bahanBindingSource;
        private Design.dsBahanTableAdapters.BahanTableAdapter bahanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}