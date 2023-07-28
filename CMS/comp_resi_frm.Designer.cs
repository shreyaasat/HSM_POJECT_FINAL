
namespace CMS
{
    partial class comp_resi_frm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb_closed = new System.Windows.Forms.RadioButton();
            this.rb_pending = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_compid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_mycomp = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.rtb_newcomp = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(19, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 715);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.bt_refresh);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.rb_closed);
            this.tabPage1.Controls.Add(this.rb_pending);
            this.tabPage1.Controls.Add(this.rb_active);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Complaints";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // rb_closed
            // 
            this.rb_closed.AutoSize = true;
            this.rb_closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_closed.ForeColor = System.Drawing.Color.Black;
            this.rb_closed.Location = new System.Drawing.Point(574, 277);
            this.rb_closed.Name = "rb_closed";
            this.rb_closed.Size = new System.Drawing.Size(128, 30);
            this.rb_closed.TabIndex = 106;
            this.rb_closed.TabStop = true;
            this.rb_closed.Text = "CLOSED";
            this.rb_closed.UseVisualStyleBackColor = true;
            this.rb_closed.Click += new System.EventHandler(this.rb_closed_Click);
            // 
            // rb_pending
            // 
            this.rb_pending.AutoSize = true;
            this.rb_pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pending.ForeColor = System.Drawing.Color.Black;
            this.rb_pending.Location = new System.Drawing.Point(574, 241);
            this.rb_pending.Name = "rb_pending";
            this.rb_pending.Size = new System.Drawing.Size(138, 30);
            this.rb_pending.TabIndex = 105;
            this.rb_pending.TabStop = true;
            this.rb_pending.Text = "PENDING";
            this.rb_pending.UseVisualStyleBackColor = true;
            this.rb_pending.Click += new System.EventHandler(this.rb_pending_Click);
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.ForeColor = System.Drawing.Color.Black;
            this.rb_active.Location = new System.Drawing.Point(574, 205);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(116, 30);
            this.rb_active.TabIndex = 104;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "ACTIVE";
            this.rb_active.UseVisualStyleBackColor = true;
            this.rb_active.CheckedChanged += new System.EventHandler(this.rb_active_CheckedChanged);
            this.rb_active.Click += new System.EventHandler(this.rb_active_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_refresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Location = new System.Drawing.Point(364, 229);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(182, 48);
            this.bt_refresh.TabIndex = 74;
            this.bt_refresh.Text = "REFRESH";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 344);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(250, 50);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(247, 34);
            this.tb_date.TabIndex = 72;
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(250, 132);
            this.tb_category.Name = "tb_category";
            this.tb_category.ReadOnly = true;
            this.tb_category.Size = new System.Drawing.Size(247, 34);
            this.tb_category.TabIndex = 71;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(250, 91);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(247, 34);
            this.tb_status.TabIndex = 70;
            // 
            // tb_compid
            // 
            this.tb_compid.Location = new System.Drawing.Point(250, 10);
            this.tb_compid.Name = "tb_compid";
            this.tb_compid.ReadOnly = true;
            this.tb_compid.Size = new System.Drawing.Size(247, 34);
            this.tb_compid.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSalmon;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 26);
            this.label9.TabIndex = 68;
            this.label9.Text = "COMPLAINT ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_mycomp
            // 
            this.rtb_mycomp.Location = new System.Drawing.Point(709, 11);
            this.rtb_mycomp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_mycomp.Name = "rtb_mycomp";
            this.rtb_mycomp.ReadOnly = true;
            this.rtb_mycomp.Size = new System.Drawing.Size(473, 156);
            this.rtb_mycomp.TabIndex = 66;
            this.rtb_mycomp.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSalmon;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(535, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 26);
            this.label12.TabIndex = 67;
            this.label12.Text = "DESCRIPTION";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSalmon;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(15, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 26);
            this.label13.TabIndex = 65;
            this.label13.Text = "COMPLAINT DATE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSalmon;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(15, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 26);
            this.label14.TabIndex = 63;
            this.label14.Text = "STATUS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkSalmon;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(15, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 26);
            this.label15.TabIndex = 61;
            this.label15.Text = "CATEGORY";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabPage2.Controls.Add(this.bt_clear);
            this.tabPage2.Controls.Add(this.bt_register);
            this.tabPage2.Controls.Add(this.rtb_newcomp);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cb_category);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Complaint";
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(640, 453);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(206, 54);
            this.bt_clear.TabIndex = 61;
            this.bt_clear.Text = "CLEAR";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_register.ForeColor = System.Drawing.Color.White;
            this.bt_register.Location = new System.Drawing.Point(372, 453);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(221, 54);
            this.bt_register.TabIndex = 60;
            this.bt_register.Text = "REGISTER";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // rtb_newcomp
            // 
            this.rtb_newcomp.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_newcomp.Location = new System.Drawing.Point(290, 154);
            this.rtb_newcomp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_newcomp.Name = "rtb_newcomp";
            this.rtb_newcomp.Size = new System.Drawing.Size(755, 244);
            this.rtb_newcomp.TabIndex = 58;
            this.rtb_newcomp.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSalmon;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(55, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 28);
            this.label11.TabIndex = 59;
            this.label11.Text = "DESCRIPTION";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cb_category.Location = new System.Drawing.Point(290, 87);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(294, 36);
            this.cb_category.TabIndex = 52;
            this.cb_category.Text = "--SELECT--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(55, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 28);
            this.label8.TabIndex = 53;
            this.label8.Text = "CATEGORY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_date);
            this.panel1.Controls.Add(this.tb_category);
            this.panel1.Controls.Add(this.tb_status);
            this.panel1.Controls.Add(this.tb_compid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rtb_mycomp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 187);
            this.panel1.TabIndex = 107;
            // 
            // comp_resi_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1250, 739);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 200);
            this.Name = "comp_resi_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "comp_resi_frm";
            this.Load += new System.EventHandler(this.comp_resi_frm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_compid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_mycomp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.RichTextBox rtb_newcomp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_pending;
        private System.Windows.Forms.RadioButton rb_active;
        private System.Windows.Forms.RadioButton rb_closed;
        private System.Windows.Forms.Panel panel1;
    }
}