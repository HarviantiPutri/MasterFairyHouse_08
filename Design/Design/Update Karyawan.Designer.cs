namespace Design
{
    partial class UpdateKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateKaryawan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtTempatLahirKaryawan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailKaryawan = new System.Windows.Forms.TextBox();
            this.txtAlamatKaryawan = new System.Windows.Forms.TextBox();
            this.txtTeleponKaryawan = new System.Windows.Forms.TextBox();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatlahirkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKaryawan = new Design.dsKaryawan();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRole = new Design.dsRole();
            this.karyawanTableAdapter = new Design.dsKaryawanTableAdapters.KaryawanTableAdapter();
            this.karyawanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Design.dsRoleTableAdapters.RoleTableAdapter();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(233)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1150, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 147;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Data Karyawan";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(860, 281);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 26);
            this.txtPassword.TabIndex = 132;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(861, 225);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 26);
            this.txtUsername.TabIndex = 131;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(832, 225);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 25);
            this.label20.TabIndex = 130;
            this.label20.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(832, 280);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 25);
            this.label19.TabIndex = 129;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(660, 280);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 25);
            this.label18.TabIndex = 128;
            this.label18.Text = "Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(658, 225);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 25);
            this.label17.TabIndex = 127;
            this.label17.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 126;
            this.label10.Text = ":";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(453, 192);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(116, 24);
            this.rbPerempuan.TabIndex = 125;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.rbPerempuan_CheckedChanged);
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(315, 192);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(97, 24);
            this.rbLaki.TabIndex = 124;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            this.rbLaki.CheckedChanged += new System.EventHandler(this.rbLaki_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 123;
            this.label1.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 122;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 121;
            this.label5.Text = "Tanggal Lahir";
            // 
            // DatePicker
            // 
            this.DatePicker.BackColor = System.Drawing.Color.Gray;
            this.DatePicker.BorderRadius = 0;
            this.DatePicker.ForeColor = System.Drawing.Color.White;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePicker.FormatCustom = null;
            this.DatePicker.Location = new System.Drawing.Point(315, 297);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(261, 46);
            this.DatePicker.TabIndex = 120;
            this.DatePicker.Value = new System.DateTime(2020, 5, 14, 2, 7, 55, 274);
            // 
            // txtTempatLahirKaryawan
            // 
            this.txtTempatLahirKaryawan.Location = new System.Drawing.Point(315, 240);
            this.txtTempatLahirKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempatLahirKaryawan.Name = "txtTempatLahirKaryawan";
            this.txtTempatLahirKaryawan.Size = new System.Drawing.Size(220, 26);
            this.txtTempatLahirKaryawan.TabIndex = 119;
            this.txtTempatLahirKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempatLahirKaryawan_KeyPress);
            this.txtTempatLahirKaryawan.Leave += new System.EventHandler(this.txtTempatLahirKaryawan_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 118;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tempat Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 116;
            this.label2.Text = "Telepon";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(832, 171);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 25);
            this.label16.TabIndex = 115;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(832, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 25);
            this.label15.TabIndex = 114;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 368);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 25);
            this.label14.TabIndex = 113;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(288, 137);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 25);
            this.label13.TabIndex = 112;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 25);
            this.label12.TabIndex = 111;
            this.label12.Text = ":";
            // 
            // txtEmailKaryawan
            // 
            this.txtEmailKaryawan.Location = new System.Drawing.Point(860, 170);
            this.txtEmailKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailKaryawan.Name = "txtEmailKaryawan";
            this.txtEmailKaryawan.Size = new System.Drawing.Size(266, 26);
            this.txtEmailKaryawan.TabIndex = 110;
            this.txtEmailKaryawan.Leave += new System.EventHandler(this.txtEmailKaryawan_Leave);
            // 
            // txtAlamatKaryawan
            // 
            this.txtAlamatKaryawan.Location = new System.Drawing.Point(860, 78);
            this.txtAlamatKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlamatKaryawan.Multiline = true;
            this.txtAlamatKaryawan.Name = "txtAlamatKaryawan";
            this.txtAlamatKaryawan.Size = new System.Drawing.Size(286, 55);
            this.txtAlamatKaryawan.TabIndex = 109;
            this.txtAlamatKaryawan.Leave += new System.EventHandler(this.txtAlamatKaryawan_Leave);
            // 
            // txtTeleponKaryawan
            // 
            this.txtTeleponKaryawan.Location = new System.Drawing.Point(315, 368);
            this.txtTeleponKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeleponKaryawan.Name = "txtTeleponKaryawan";
            this.txtTeleponKaryawan.Size = new System.Drawing.Size(199, 26);
            this.txtTeleponKaryawan.TabIndex = 108;
            this.txtTeleponKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeleponKaryawan_KeyPress);
            this.txtTeleponKaryawan.Leave += new System.EventHandler(this.txtTeleponKaryawan_Leave);
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(315, 137);
            this.txtNamaKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(246, 26);
            this.txtNamaKaryawan.TabIndex = 107;
            this.txtNamaKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaKaryawan_KeyPress);
            this.txtNamaKaryawan.Leave += new System.EventHandler(this.txtNamaKaryawan_Leave);
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.Location = new System.Drawing.Point(315, 78);
            this.txtIdKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdKaryawan.Multiline = true;
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(148, 29);
            this.txtIdKaryawan.TabIndex = 106;
            this.txtIdKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdKaryawan_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(660, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 105;
            this.label11.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 104;
            this.label9.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 103;
            this.label8.Text = "Nama ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Karyawan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkaryawanDataGridViewTextBoxColumn,
            this.idroleDataGridViewTextBoxColumn,
            this.namakaryawanDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.tempatlahirkaryawanDataGridViewTextBoxColumn,
            this.tgllahirkaryawanDataGridViewTextBoxColumn,
            this.teleponkaryawanDataGridViewTextBoxColumn,
            this.alamatkaryawanDataGridViewTextBoxColumn,
            this.emailkaryawanDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.karyawanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 433);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 254);
            this.dataGridView1.TabIndex = 133;
            // 
            // idkaryawanDataGridViewTextBoxColumn
            // 
            this.idkaryawanDataGridViewTextBoxColumn.DataPropertyName = "id_karyawan";
            this.idkaryawanDataGridViewTextBoxColumn.HeaderText = "id_karyawan";
            this.idkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idkaryawanDataGridViewTextBoxColumn.Name = "idkaryawanDataGridViewTextBoxColumn";
            this.idkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // idroleDataGridViewTextBoxColumn
            // 
            this.idroleDataGridViewTextBoxColumn.DataPropertyName = "id_role";
            this.idroleDataGridViewTextBoxColumn.HeaderText = "id_role";
            this.idroleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idroleDataGridViewTextBoxColumn.Name = "idroleDataGridViewTextBoxColumn";
            this.idroleDataGridViewTextBoxColumn.Width = 150;
            // 
            // namakaryawanDataGridViewTextBoxColumn
            // 
            this.namakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan";
            this.namakaryawanDataGridViewTextBoxColumn.HeaderText = "nama_karyawan";
            this.namakaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namakaryawanDataGridViewTextBoxColumn.Name = "namakaryawanDataGridViewTextBoxColumn";
            this.namakaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.Width = 150;
            // 
            // tempatlahirkaryawanDataGridViewTextBoxColumn
            // 
            this.tempatlahirkaryawanDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir_karyawan";
            this.tempatlahirkaryawanDataGridViewTextBoxColumn.HeaderText = "tempat_lahir_karyawan";
            this.tempatlahirkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempatlahirkaryawanDataGridViewTextBoxColumn.Name = "tempatlahirkaryawanDataGridViewTextBoxColumn";
            this.tempatlahirkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // tgllahirkaryawanDataGridViewTextBoxColumn
            // 
            this.tgllahirkaryawanDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir_karyawan";
            this.tgllahirkaryawanDataGridViewTextBoxColumn.HeaderText = "tgl_lahir_karyawan";
            this.tgllahirkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tgllahirkaryawanDataGridViewTextBoxColumn.Name = "tgllahirkaryawanDataGridViewTextBoxColumn";
            this.tgllahirkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // teleponkaryawanDataGridViewTextBoxColumn
            // 
            this.teleponkaryawanDataGridViewTextBoxColumn.DataPropertyName = "telepon_karyawan";
            this.teleponkaryawanDataGridViewTextBoxColumn.HeaderText = "telepon_karyawan";
            this.teleponkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teleponkaryawanDataGridViewTextBoxColumn.Name = "teleponkaryawanDataGridViewTextBoxColumn";
            this.teleponkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatkaryawanDataGridViewTextBoxColumn
            // 
            this.alamatkaryawanDataGridViewTextBoxColumn.DataPropertyName = "alamat_karyawan";
            this.alamatkaryawanDataGridViewTextBoxColumn.HeaderText = "alamat_karyawan";
            this.alamatkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatkaryawanDataGridViewTextBoxColumn.Name = "alamatkaryawanDataGridViewTextBoxColumn";
            this.alamatkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailkaryawanDataGridViewTextBoxColumn
            // 
            this.emailkaryawanDataGridViewTextBoxColumn.DataPropertyName = "email_karyawan";
            this.emailkaryawanDataGridViewTextBoxColumn.HeaderText = "email_karyawan";
            this.emailkaryawanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailkaryawanDataGridViewTextBoxColumn.Name = "emailkaryawanDataGridViewTextBoxColumn";
            this.emailkaryawanDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.dsKaryawan;
            // 
            // dsKaryawan
            // 
            this.dsKaryawan.DataSetName = "dsKaryawan";
            this.dsKaryawan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(734, 697);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(112, 35);
            this.btnBatal.TabIndex = 136;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(560, 697);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(112, 35);
            this.btnHapus.TabIndex = 135;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Location = new System.Drawing.Point(390, 697);
            this.btnPerbarui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(112, 35);
            this.btnPerbarui.TabIndex = 134;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(474, 75);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(112, 35);
            this.btnCari.TabIndex = 145;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(830, 329);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 25);
            this.label22.TabIndex = 147;
            this.label22.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(658, 329);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 25);
            this.label23.TabIndex = 146;
            this.label23.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DataSource = this.roleBindingSource;
            this.cmbRole.DisplayMember = "nama_role";
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(860, 330);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 28);
            this.cmbRole.TabIndex = 148;
            this.cmbRole.ValueMember = "id_role";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.dsRole;
            // 
            // dsRole
            // 
            this.dsRole.DataSetName = "dsRole";
            this.dsRole.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // karyawanBindingSource1
            // 
            this.karyawanBindingSource1.DataMember = "Karyawan";
            this.karyawanBindingSource1.DataSource = this.dsKaryawan;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
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
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // UpdateKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1200, 771);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnPerbarui);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.txtTempatLahirKaryawan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmailKaryawan);
            this.Controls.Add(this.txtAlamatKaryawan);
            this.Controls.Add(this.txtTeleponKaryawan);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateKaryawan";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.UpdateKaryawan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker DatePicker;
        private System.Windows.Forms.TextBox txtTempatLahirKaryawan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailKaryawan;
        private System.Windows.Forms.TextBox txtAlamatKaryawan;
        private System.Windows.Forms.TextBox txtTeleponKaryawan;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.TextBox txtIdKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.Button btnCari;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private dsKaryawan dsKaryawan;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private dsKaryawanTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatlahirkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource karyawanBindingSource1;
        private dsRole dsRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private dsRoleTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}