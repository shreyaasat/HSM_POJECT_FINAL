
namespace CMS
{
    partial class invoicelist1
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
            this.bt_home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.tb_duedate = new System.Windows.Forms.TextBox();
            this.tb_ownername = new System.Windows.Forms.TextBox();
            this.tb_gst = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_gst = new System.Windows.Forms.Label();
            this.tb_flatno = new System.Windows.Forms.TextBox();
            this.lb_duedate = new System.Windows.Forms.Label();
            this.tb_ratesft = new System.Windows.Forms.TextBox();
            this.lb_rate = new System.Windows.Forms.Label();
            this.lb_billno = new System.Windows.Forms.Label();
            this.tb_billno = new System.Windows.Forms.TextBox();
            this.tb_area = new System.Windows.Forms.TextBox();
            this.lb_area = new System.Windows.Forms.Label();
            this.lb_flatno = new System.Windows.Forms.Label();
            this.lb_billdate = new System.Windows.Forms.Label();
            this.tb_billdate = new System.Windows.Forms.TextBox();
            this.rb_flatnosearch = new System.Windows.Forms.RadioButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.rb_due = new System.Windows.Forms.RadioButton();
            this.rb_paid = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.bt_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.ForeColor = System.Drawing.Color.White;
            this.bt_home.Location = new System.Drawing.Point(1791, 9);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(115, 43);
            this.bt_home.TabIndex = 69;
            this.bt_home.Text = "BACK";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_refresh);
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.tb_amount);
            this.panel1.Controls.Add(this.lb_amount);
            this.panel1.Controls.Add(this.tb_duedate);
            this.panel1.Controls.Add(this.tb_ownername);
            this.panel1.Controls.Add(this.tb_gst);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.lb_gst);
            this.panel1.Controls.Add(this.tb_flatno);
            this.panel1.Controls.Add(this.lb_duedate);
            this.panel1.Controls.Add(this.tb_ratesft);
            this.panel1.Controls.Add(this.lb_rate);
            this.panel1.Controls.Add(this.lb_billno);
            this.panel1.Controls.Add(this.tb_billno);
            this.panel1.Controls.Add(this.tb_area);
            this.panel1.Controls.Add(this.lb_area);
            this.panel1.Controls.Add(this.lb_flatno);
            this.panel1.Controls.Add(this.lb_billdate);
            this.panel1.Controls.Add(this.tb_billdate);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 1090);
            this.panel1.TabIndex = 70;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(167, 762);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(143, 41);
            this.bt_update.TabIndex = 21;
            this.bt_update.Text = "UPDATE";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click_1);
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.bt_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Location = new System.Drawing.Point(27, 762);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(145, 41);
            this.bt_refresh.TabIndex = 20;
            this.bt_refresh.Text = "REFRESH";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click_1);
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "DUE",
            "PAID"});
            this.cb_status.Location = new System.Drawing.Point(193, 379);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(141, 35);
            this.cb_status.TabIndex = 9;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // lb_status
            // 
            this.lb_status.AutoEllipsis = true;
            this.lb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_status.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_status.Location = new System.Drawing.Point(10, 374);
            this.lb_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(109, 40);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "STATUS";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_status.Click += new System.EventHandler(this.lb_status_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amount.Location = new System.Drawing.Point(193, 685);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.ReadOnly = true;
            this.tb_amount.Size = new System.Drawing.Size(141, 34);
            this.tb_amount.TabIndex = 19;
            // 
            // lb_amount
            // 
            this.lb_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_amount.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_amount.Location = new System.Drawing.Point(10, 677);
            this.lb_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(145, 40);
            this.lb_amount.TabIndex = 18;
            this.lb_amount.Text = "AMOUNT";
            this.lb_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_amount.Click += new System.EventHandler(this.lb_amount_Click);
            // 
            // tb_duedate
            // 
            this.tb_duedate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_duedate.Location = new System.Drawing.Point(143, 328);
            this.tb_duedate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_duedate.Name = "tb_duedate";
            this.tb_duedate.ReadOnly = true;
            this.tb_duedate.Size = new System.Drawing.Size(187, 34);
            this.tb_duedate.TabIndex = 7;
            this.tb_duedate.TextChanged += new System.EventHandler(this.tb_duedate_TextChanged);
            // 
            // tb_ownername
            // 
            this.tb_ownername.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ownername.Location = new System.Drawing.Point(15, 184);
            this.tb_ownername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ownername.Name = "tb_ownername";
            this.tb_ownername.ReadOnly = true;
            this.tb_ownername.Size = new System.Drawing.Size(303, 34);
            this.tb_ownername.TabIndex = 3;
            this.tb_ownername.TextChanged += new System.EventHandler(this.tb_ownername_TextChanged);
            // 
            // tb_gst
            // 
            this.tb_gst.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gst.Location = new System.Drawing.Point(193, 619);
            this.tb_gst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_gst.Name = "tb_gst";
            this.tb_gst.ReadOnly = true;
            this.tb_gst.Size = new System.Drawing.Size(141, 34);
            this.tb_gst.TabIndex = 17;
            this.tb_gst.TextChanged += new System.EventHandler(this.tb_gst_TextChanged);
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_name.Location = new System.Drawing.Point(15, 142);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(175, 40);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "OWNER NAME";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_gst
            // 
            this.lb_gst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_gst.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_gst.Location = new System.Drawing.Point(10, 614);
            this.lb_gst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gst.Name = "lb_gst";
            this.lb_gst.Size = new System.Drawing.Size(175, 40);
            this.lb_gst.TabIndex = 16;
            this.lb_gst.Text = "GST (%)";
            this.lb_gst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_flatno
            // 
            this.tb_flatno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flatno.Location = new System.Drawing.Point(193, 441);
            this.tb_flatno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_flatno.Name = "tb_flatno";
            this.tb_flatno.ReadOnly = true;
            this.tb_flatno.Size = new System.Drawing.Size(141, 34);
            this.tb_flatno.TabIndex = 11;
            this.tb_flatno.TextChanged += new System.EventHandler(this.tb_flatno_TextChanged);
            // 
            // lb_duedate
            // 
            this.lb_duedate.AutoEllipsis = true;
            this.lb_duedate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_duedate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duedate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_duedate.Location = new System.Drawing.Point(10, 320);
            this.lb_duedate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_duedate.Name = "lb_duedate";
            this.lb_duedate.Size = new System.Drawing.Size(175, 40);
            this.lb_duedate.TabIndex = 6;
            this.lb_duedate.Text = "DUE DATE";
            this.lb_duedate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_duedate.Click += new System.EventHandler(this.lb_duedate_Click);
            // 
            // tb_ratesft
            // 
            this.tb_ratesft.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ratesft.Location = new System.Drawing.Point(193, 561);
            this.tb_ratesft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ratesft.Name = "tb_ratesft";
            this.tb_ratesft.ReadOnly = true;
            this.tb_ratesft.Size = new System.Drawing.Size(141, 34);
            this.tb_ratesft.TabIndex = 15;
            this.tb_ratesft.TextChanged += new System.EventHandler(this.tb_ratesft_TextChanged);
            // 
            // lb_rate
            // 
            this.lb_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_rate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_rate.Location = new System.Drawing.Point(10, 553);
            this.lb_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rate.Name = "lb_rate";
            this.lb_rate.Size = new System.Drawing.Size(175, 40);
            this.lb_rate.TabIndex = 14;
            this.lb_rate.Text = "RATE/Sft (Rs.)";
            this.lb_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_billno
            // 
            this.lb_billno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_billno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_billno.Location = new System.Drawing.Point(15, 61);
            this.lb_billno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_billno.Name = "lb_billno";
            this.lb_billno.Size = new System.Drawing.Size(175, 40);
            this.lb_billno.TabIndex = 0;
            this.lb_billno.Text = "BILL NO.";
            this.lb_billno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_billno.Click += new System.EventHandler(this.lb_billno_Click);
            // 
            // tb_billno
            // 
            this.tb_billno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_billno.Location = new System.Drawing.Point(15, 105);
            this.tb_billno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_billno.Name = "tb_billno";
            this.tb_billno.ReadOnly = true;
            this.tb_billno.Size = new System.Drawing.Size(303, 34);
            this.tb_billno.TabIndex = 1;
            this.tb_billno.TextChanged += new System.EventHandler(this.tb_billno_TextChanged);
            // 
            // tb_area
            // 
            this.tb_area.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_area.Location = new System.Drawing.Point(193, 500);
            this.tb_area.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_area.Name = "tb_area";
            this.tb_area.ReadOnly = true;
            this.tb_area.Size = new System.Drawing.Size(141, 34);
            this.tb_area.TabIndex = 13;
            this.tb_area.TextChanged += new System.EventHandler(this.tb_area_TextChanged);
            // 
            // lb_area
            // 
            this.lb_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_area.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_area.Location = new System.Drawing.Point(10, 495);
            this.lb_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(175, 40);
            this.lb_area.TabIndex = 12;
            this.lb_area.Text = "AREA (Sft)";
            this.lb_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_flatno
            // 
            this.lb_flatno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_flatno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flatno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_flatno.Location = new System.Drawing.Point(10, 436);
            this.lb_flatno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_flatno.Name = "lb_flatno";
            this.lb_flatno.Size = new System.Drawing.Size(175, 40);
            this.lb_flatno.TabIndex = 10;
            this.lb_flatno.Text = "FLAT NUMBER";
            this.lb_flatno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_flatno.Click += new System.EventHandler(this.lb_flatno_Click);
            // 
            // lb_billdate
            // 
            this.lb_billdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(203)))));
            this.lb_billdate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_billdate.Location = new System.Drawing.Point(10, 263);
            this.lb_billdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_billdate.Name = "lb_billdate";
            this.lb_billdate.Size = new System.Drawing.Size(131, 40);
            this.lb_billdate.TabIndex = 4;
            this.lb_billdate.Text = "BILL DATE";
            this.lb_billdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_billdate.Click += new System.EventHandler(this.lb_billdate_Click);
            // 
            // tb_billdate
            // 
            this.tb_billdate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_billdate.Location = new System.Drawing.Point(143, 268);
            this.tb_billdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_billdate.Name = "tb_billdate";
            this.tb_billdate.ReadOnly = true;
            this.tb_billdate.Size = new System.Drawing.Size(187, 34);
            this.tb_billdate.TabIndex = 5;
            this.tb_billdate.TextChanged += new System.EventHandler(this.tb_billdate_TextChanged);
            // 
            // rb_flatnosearch
            // 
            this.rb_flatnosearch.AutoSize = true;
            this.rb_flatnosearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_flatnosearch.Location = new System.Drawing.Point(766, 20);
            this.rb_flatnosearch.Name = "rb_flatnosearch";
            this.rb_flatnosearch.Size = new System.Drawing.Size(261, 30);
            this.rb_flatnosearch.TabIndex = 0;
            this.rb_flatnosearch.TabStop = true;
            this.rb_flatnosearch.Text = "Search by Flat Number";
            this.rb_flatnosearch.UseVisualStyleBackColor = true;
            this.rb_flatnosearch.CheckedChanged += new System.EventHandler(this.rb_flatnosearch_CheckedChanged_1);
            this.rb_flatnosearch.Click += new System.EventHandler(this.rb_flatnosearch_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1034, 20);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(175, 32);
            this.tb_search.TabIndex = 1;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click_1);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // rb_due
            // 
            this.rb_due.AutoSize = true;
            this.rb_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_due.Location = new System.Drawing.Point(1372, 20);
            this.rb_due.Name = "rb_due";
            this.rb_due.Size = new System.Drawing.Size(84, 30);
            this.rb_due.TabIndex = 3;
            this.rb_due.TabStop = true;
            this.rb_due.Text = "DUE";
            this.rb_due.UseVisualStyleBackColor = true;
            this.rb_due.Click += new System.EventHandler(this.rb_due_Click);
            // 
            // rb_paid
            // 
            this.rb_paid.AutoSize = true;
            this.rb_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_paid.Location = new System.Drawing.Point(1260, 20);
            this.rb_paid.Name = "rb_paid";
            this.rb_paid.Size = new System.Drawing.Size(89, 30);
            this.rb_paid.TabIndex = 2;
            this.rb_paid.TabStop = true;
            this.rb_paid.Text = "PAID";
            this.rb_paid.UseVisualStyleBackColor = true;
            this.rb_paid.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.rb_paid.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(354, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 935);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint_1);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint_1);
            // 
            // invoicelist1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1044);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rb_due);
            this.Controls.Add(this.rb_paid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.rb_flatnosearch);
            this.Controls.Add(this.tb_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoicelist1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invoicelist1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.invoicelist1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_flatnosearch;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_billno;
        private System.Windows.Forms.TextBox tb_billno;
        private System.Windows.Forms.TextBox tb_area;
        private System.Windows.Forms.TextBox tb_flatno;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_ownername;
        private System.Windows.Forms.Label lb_flatno;
        private System.Windows.Forms.Label lb_billdate;
        private System.Windows.Forms.TextBox tb_billdate;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.TextBox tb_duedate;
        private System.Windows.Forms.TextBox tb_gst;
        private System.Windows.Forms.Label lb_gst;
        private System.Windows.Forms.TextBox tb_ratesft;
        private System.Windows.Forms.Label lb_duedate;
        private System.Windows.Forms.Label lb_rate;
        private System.Windows.Forms.RadioButton rb_due;
        private System.Windows.Forms.RadioButton rb_paid;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}