
namespace CMS
{
    partial class guest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_addnew = new System.Windows.Forms.Button();
            this.tb_flatno1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name1 = new System.Windows.Forms.TextBox();
            this.tb_veh1 = new System.Windows.Forms.TextBox();
            this.tb_contact1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_searchflat = new System.Windows.Forms.RadioButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rb_searchvehicle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.bt_addnew);
            this.groupBox1.Controls.Add(this.tb_flatno1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_name1);
            this.groupBox1.Controls.Add(this.tb_veh1);
            this.groupBox1.Controls.Add(this.tb_contact1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUEST DETAILS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.MistyRose;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.Black;
            this.bt_save.Location = new System.Drawing.Point(654, 71);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(189, 48);
            this.bt_save.TabIndex = 72;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_addnew
            // 
            this.bt_addnew.BackColor = System.Drawing.Color.MistyRose;
            this.bt_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_addnew.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addnew.ForeColor = System.Drawing.Color.Black;
            this.bt_addnew.Location = new System.Drawing.Point(654, 138);
            this.bt_addnew.Name = "bt_addnew";
            this.bt_addnew.Size = new System.Drawing.Size(189, 48);
            this.bt_addnew.TabIndex = 69;
            this.bt_addnew.Text = "Clear";
            this.bt_addnew.UseVisualStyleBackColor = false;
            this.bt_addnew.Click += new System.EventHandler(this.bt_addnew_Click);
            // 
            // tb_flatno1
            // 
            this.tb_flatno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flatno1.Location = new System.Drawing.Point(315, 169);
            this.tb_flatno1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_flatno1.Name = "tb_flatno1";
            this.tb_flatno1.Size = new System.Drawing.Size(290, 32);
            this.tb_flatno1.TabIndex = 71;
            this.tb_flatno1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tb_flatno1.Validated += new System.EventHandler(this.tb_flatno1_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(122, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 70;
            this.label5.Text = "MOBILE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(122, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 69;
            this.label4.Text = "FLAT NO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_name1
            // 
            this.tb_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name1.Location = new System.Drawing.Point(315, 48);
            this.tb_name1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_name1.Name = "tb_name1";
            this.tb_name1.Size = new System.Drawing.Size(290, 32);
            this.tb_name1.TabIndex = 68;
            // 
            // tb_veh1
            // 
            this.tb_veh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_veh1.Location = new System.Drawing.Point(315, 130);
            this.tb_veh1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_veh1.Name = "tb_veh1";
            this.tb_veh1.Size = new System.Drawing.Size(290, 32);
            this.tb_veh1.TabIndex = 67;
            this.tb_veh1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_contact1
            // 
            this.tb_contact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact1.Location = new System.Drawing.Point(315, 89);
            this.tb_contact1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_contact1.MaxLength = 11;
            this.tb_contact1.Name = "tb_contact1";
            this.tb_contact1.Size = new System.Drawing.Size(290, 32);
            this.tb_contact1.TabIndex = 66;
            this.tb_contact1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contact1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(122, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 64;
            this.label3.Text = "NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(122, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 63;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(122, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "VEHICLE NO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rb_searchflat
            // 
            this.rb_searchflat.AutoSize = true;
            this.rb_searchflat.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_searchflat.Location = new System.Drawing.Point(115, 275);
            this.rb_searchflat.Name = "rb_searchflat";
            this.rb_searchflat.Size = new System.Drawing.Size(291, 32);
            this.rb_searchflat.TabIndex = 73;
            this.rb_searchflat.TabStop = true;
            this.rb_searchflat.Text = "Search by Flat Number";
            this.rb_searchflat.UseVisualStyleBackColor = true;
            this.rb_searchflat.CheckedChanged += new System.EventHandler(this.rb_searchflat_CheckedChanged);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(455, 295);
            this.tb_search.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(291, 32);
            this.tb_search.TabIndex = 74;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.MistyRose;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reset.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.Black;
            this.bt_reset.Location = new System.Drawing.Point(775, 285);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(189, 48);
            this.bt_reset.TabIndex = 75;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(899, 342);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.TabStop = false;
            // 
            // rb_searchvehicle
            // 
            this.rb_searchvehicle.AutoSize = true;
            this.rb_searchvehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_searchvehicle.Location = new System.Drawing.Point(114, 313);
            this.rb_searchvehicle.Name = "rb_searchvehicle";
            this.rb_searchvehicle.Size = new System.Drawing.Size(328, 32);
            this.rb_searchvehicle.TabIndex = 77;
            this.rb_searchvehicle.TabStop = true;
            this.rb_searchvehicle.Text = "Search by Vehicle Number";
            this.rb_searchvehicle.UseVisualStyleBackColor = true;
            // 
            // guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1055, 715);
            this.Controls.Add(this.rb_searchvehicle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.rb_searchflat);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(350, 220);
            this.Name = "guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "guest";
            this.Load += new System.EventHandler(this.guest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_flatno1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name1;
        private System.Windows.Forms.TextBox tb_veh1;
        private System.Windows.Forms.TextBox tb_contact1;
        private System.Windows.Forms.Button bt_addnew;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.RadioButton rb_searchflat;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rb_searchvehicle;
    }
}