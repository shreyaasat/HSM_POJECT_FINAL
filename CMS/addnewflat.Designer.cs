
namespace CMS
{
    partial class Frm_addflat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.cb_flattype = new System.Windows.Forms.ComboBox();
            this.cb_noofcarpark = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_flatnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_ownermobile = new System.Windows.Forms.DataGridView();
            this.mobiledg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_owneremail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ownername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ownermobile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.groupBox2.Controls.Add(this.cb_area);
            this.groupBox2.Controls.Add(this.cb_flattype);
            this.groupBox2.Controls.Add(this.cb_noofcarpark);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_flatnum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(42, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 482);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD NEW FLAT";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cb_area
            // 
            this.cb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Items.AddRange(new object[] {
            "625",
            "1250",
            "1500",
            "1750",
            "1900",
            "2500",
            "2850"});
            this.cb_area.Location = new System.Drawing.Point(347, 61);
            this.cb_area.Margin = new System.Windows.Forms.Padding(5);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(189, 33);
            this.cb_area.TabIndex = 1;
            this.cb_area.Text = "--SELECT--";
            this.cb_area.Validated += new System.EventHandler(this.cb_area_Validated);
            // 
            // cb_flattype
            // 
            this.cb_flattype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_flattype.FormattingEnabled = true;
            this.cb_flattype.Items.AddRange(new object[] {
            "1 BHK",
            "2 BHK",
            "2.5 BHK",
            "3 BHK",
            "3 BHK + MAIDS ROOM",
            "4 BHK",
            "4 BHK + MAIDS ROOM"});
            this.cb_flattype.Location = new System.Drawing.Point(347, 104);
            this.cb_flattype.Margin = new System.Windows.Forms.Padding(5);
            this.cb_flattype.Name = "cb_flattype";
            this.cb_flattype.Size = new System.Drawing.Size(189, 33);
            this.cb_flattype.TabIndex = 2;
            this.cb_flattype.Text = "--SELECT--";
            // 
            // cb_noofcarpark
            // 
            this.cb_noofcarpark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_noofcarpark.FormattingEnabled = true;
            this.cb_noofcarpark.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_noofcarpark.Location = new System.Drawing.Point(347, 150);
            this.cb_noofcarpark.Margin = new System.Windows.Forms.Padding(5);
            this.cb_noofcarpark.Name = "cb_noofcarpark";
            this.cb_noofcarpark.Size = new System.Drawing.Size(189, 33);
            this.cb_noofcarpark.TabIndex = 3;
            this.cb_noofcarpark.Text = "--SELECT--";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Location = new System.Drawing.Point(245, 432);
            this.bt_add.Margin = new System.Windows.Forms.Padding(5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(220, 32);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "TYPE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_flatnum
            // 
            this.tb_flatnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flatnum.Location = new System.Drawing.Point(347, 23);
            this.tb_flatnum.Margin = new System.Windows.Forms.Padding(5);
            this.tb_flatnum.Name = "tb_flatnum";
            this.tb_flatnum.Size = new System.Drawing.Size(189, 30);
            this.tb_flatnum.TabIndex = 0;
            this.tb_flatnum.TextChanged += new System.EventHandler(this.tb_flatnum_TextChanged);
            this.tb_flatnum.Validated += new System.EventHandler(this.tb_flatnum_Validated);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "NO. OF CAR PARKING SPACE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "AREA (Sft)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "FLAT NUMBER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_ownermobile);
            this.groupBox1.Controls.Add(this.tb_owneremail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_ownername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(645, 223);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OWNER DETAILS";
            // 
            // dg_ownermobile
            // 
            this.dg_ownermobile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ownermobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ownermobile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mobiledg});
            this.dg_ownermobile.Location = new System.Drawing.Point(316, 114);
            this.dg_ownermobile.Name = "dg_ownermobile";
            this.dg_ownermobile.RowHeadersWidth = 62;
            this.dg_ownermobile.RowTemplate.Height = 28;
            this.dg_ownermobile.Size = new System.Drawing.Size(316, 101);
            this.dg_ownermobile.TabIndex = 3;
            this.dg_ownermobile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ownermobile_CellContentClick);
            this.dg_ownermobile.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_ownermobile_EditingControlShowing);
            this.dg_ownermobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg_ownermobile_KeyPress);
            // 
            // mobiledg
            // 
            this.mobiledg.HeaderText = "MOBILE NUMBER";
            this.mobiledg.MaxInputLength = 11;
            this.mobiledg.MinimumWidth = 8;
            this.mobiledg.Name = "mobiledg";
            // 
            // tb_owneremail
            // 
            this.tb_owneremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_owneremail.Location = new System.Drawing.Point(316, 73);
            this.tb_owneremail.Margin = new System.Windows.Forms.Padding(5);
            this.tb_owneremail.Name = "tb_owneremail";
            this.tb_owneremail.Size = new System.Drawing.Size(316, 30);
            this.tb_owneremail.TabIndex = 1;
            this.tb_owneremail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_owneremail_KeyPress);
            this.tb_owneremail.Leave += new System.EventHandler(this.tb_owneremail_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "MOBILE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "NAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_ownername
            // 
            this.tb_ownername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ownername.Location = new System.Drawing.Point(316, 33);
            this.tb_ownername.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ownername.Name = "tb_ownername";
            this.tb_ownername.Size = new System.Drawing.Size(316, 30);
            this.tb_ownername.TabIndex = 0;
            this.tb_ownername.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "E-MAIL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_addflat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(173)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(791, 506);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(425, 180);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_addflat";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ADD NEW FLAT";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ownermobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_flattype;
        private System.Windows.Forms.ComboBox cb_noofcarpark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_flatnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_ownermobile;
        private System.Windows.Forms.TextBox tb_owneremail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ownername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobiledg;
    }
}