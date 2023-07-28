
namespace CMS
{
    partial class complaint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_save = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_flatno = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_compid2 = new System.Windows.Forms.TextBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_desc2 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_flatno2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_status2 = new System.Windows.Forms.ComboBox();
            this.rb_pending = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.rb_flatnosearch = new System.Windows.Forms.RadioButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(400, 620);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(180, 47);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "REGISTER";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1238, 752);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.bt_close);
            this.tabPage1.Controls.Add(this.bt_reset);
            this.tabPage1.Controls.Add(this.bt_save);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  New Complaint";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.White;
            this.bt_close.Location = new System.Drawing.Point(834, 620);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(180, 47);
            this.bt_close.TabIndex = 66;
            this.bt_close.Text = "CLOSE";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Visible = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.White;
            this.bt_reset.Location = new System.Drawing.Point(606, 620);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(180, 47);
            this.bt_reset.TabIndex = 65;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rtb_desc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_flatno);
            this.groupBox1.Location = new System.Drawing.Point(62, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 569);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD COMPLAINT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "FLAT NUMBER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "PLUMBING",
            "ELECTRICAL",
            "CIVIL",
            "HOUSEKEEPING",
            "LIFT",
            "SWIMMING POOL",
            "GYM EQUIPMENT REPAIR",
            "OTHERS"});
            this.cb_category.Location = new System.Drawing.Point(231, 126);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(294, 34);
            this.cb_category.TabIndex = 1;
            this.cb_category.Text = "--SELECT--";
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "CATEGORY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(231, 200);
            this.rtb_desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(755, 296);
            this.rtb_desc.TabIndex = 5;
            this.rtb_desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "DESCRIPTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_flatno
            // 
            this.tb_flatno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flatno.Location = new System.Drawing.Point(231, 54);
            this.tb_flatno.Margin = new System.Windows.Forms.Padding(8);
            this.tb_flatno.Name = "tb_flatno";
            this.tb_flatno.Size = new System.Drawing.Size(213, 32);
            this.tb_flatno.TabIndex = 0;
            this.tb_flatno.TextChanged += new System.EventHandler(this.tb_flatno_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 710);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Complaint Update";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 345);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.rb_pending);
            this.panel2.Controls.Add(this.rb_active);
            this.panel2.Controls.Add(this.rb_flatnosearch);
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 695);
            this.panel2.TabIndex = 105;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.tb_date);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.tb_compid2);
            this.panel1.Controls.Add(this.bt_refresh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rtb_desc2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_flatno2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_status2);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 257);
            this.panel1.TabIndex = 104;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(238, 57);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(212, 32);
            this.tb_date.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(17, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 26);
            this.label13.TabIndex = 73;
            this.label13.Text = "COMPLAINT DATE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(76, 197);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(143, 49);
            this.bt_update.TabIndex = 60;
            this.bt_update.Text = "UPDATE";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // tb_compid2
            // 
            this.tb_compid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compid2.Location = new System.Drawing.Point(238, 18);
            this.tb_compid2.Margin = new System.Windows.Forms.Padding(8);
            this.tb_compid2.Name = "tb_compid2";
            this.tb_compid2.ReadOnly = true;
            this.tb_compid2.Size = new System.Drawing.Size(210, 32);
            this.tb_compid2.TabIndex = 62;
            this.tb_compid2.TextChanged += new System.EventHandler(this.tb_compid2_TextChanged);
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Location = new System.Drawing.Point(225, 197);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(143, 49);
            this.bt_refresh.TabIndex = 59;
            this.bt_refresh.Text = "REFRESH";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 26);
            this.label9.TabIndex = 63;
            this.label9.Text = "COMPLAINT ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_desc2
            // 
            this.rtb_desc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_desc2.Location = new System.Drawing.Point(678, 18);
            this.rtb_desc2.Name = "rtb_desc2";
            this.rtb_desc2.Size = new System.Drawing.Size(499, 210);
            this.rtb_desc2.TabIndex = 58;
            this.rtb_desc2.Text = "";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(501, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 44);
            this.label11.TabIndex = 57;
            this.label11.Text = "DESCRIPTION";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "FLAT NUMBER";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_flatno2
            // 
            this.tb_flatno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flatno2.Location = new System.Drawing.Point(238, 99);
            this.tb_flatno2.Margin = new System.Windows.Forms.Padding(8);
            this.tb_flatno2.Name = "tb_flatno2";
            this.tb_flatno2.ReadOnly = true;
            this.tb_flatno2.Size = new System.Drawing.Size(210, 32);
            this.tb_flatno2.TabIndex = 50;
            this.tb_flatno2.TextChanged += new System.EventHandler(this.tb_flatno2_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 44);
            this.label10.TabIndex = 56;
            this.label10.Text = "STATUS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_status2
            // 
            this.cb_status2.FormattingEnabled = true;
            this.cb_status2.Items.AddRange(new object[] {
            "ACTIVE",
            "PENDING",
            "CLOSED"});
            this.cb_status2.Location = new System.Drawing.Point(238, 143);
            this.cb_status2.Name = "cb_status2";
            this.cb_status2.Size = new System.Drawing.Size(210, 34);
            this.cb_status2.TabIndex = 55;
            this.cb_status2.Text = "--SELECT--";
            // 
            // rb_pending
            // 
            this.rb_pending.AutoSize = true;
            this.rb_pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pending.ForeColor = System.Drawing.Color.Black;
            this.rb_pending.Location = new System.Drawing.Point(832, 280);
            this.rb_pending.Name = "rb_pending";
            this.rb_pending.Size = new System.Drawing.Size(138, 30);
            this.rb_pending.TabIndex = 103;
            this.rb_pending.TabStop = true;
            this.rb_pending.Text = "PENDING";
            this.rb_pending.UseVisualStyleBackColor = true;
            this.rb_pending.CheckedChanged += new System.EventHandler(this.rb_pending_CheckedChanged);
            this.rb_pending.Click += new System.EventHandler(this.rb_pending_Click);
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.ForeColor = System.Drawing.Color.Black;
            this.rb_active.Location = new System.Drawing.Point(710, 281);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(116, 30);
            this.rb_active.TabIndex = 102;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "ACTIVE";
            this.rb_active.UseVisualStyleBackColor = true;
            this.rb_active.CheckedChanged += new System.EventHandler(this.rb_active_CheckedChanged);
            this.rb_active.Click += new System.EventHandler(this.rb_active_Click);
            // 
            // rb_flatnosearch
            // 
            this.rb_flatnosearch.AutoSize = true;
            this.rb_flatnosearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_flatnosearch.ForeColor = System.Drawing.Color.Black;
            this.rb_flatnosearch.Location = new System.Drawing.Point(245, 280);
            this.rb_flatnosearch.Name = "rb_flatnosearch";
            this.rb_flatnosearch.Size = new System.Drawing.Size(261, 30);
            this.rb_flatnosearch.TabIndex = 100;
            this.rb_flatnosearch.TabStop = true;
            this.rb_flatnosearch.Text = "Search by Flat Number";
            this.rb_flatnosearch.UseVisualStyleBackColor = true;
            this.rb_flatnosearch.Click += new System.EventHandler(this.rb_flatnosearch_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(513, 280);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(175, 32);
            this.tb_search.TabIndex = 101;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1238, 761);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(430, 175);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "complaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.complaint_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_flatno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_desc2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_status2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_flatno2;
        private System.Windows.Forms.RadioButton rb_pending;
        private System.Windows.Forms.RadioButton rb_active;
        private System.Windows.Forms.RadioButton rb_flatnosearch;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_compid2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_close;
    }
}