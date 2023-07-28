
namespace CMS
{
    partial class resident_lst_view
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.rb_search = new System.Windows.Forms.RadioButton();
            this.refresh_button = new System.Windows.Forms.Button();
            this.rb_resiowner = new System.Windows.Forms.RadioButton();
            this.rb_tenant = new System.Windows.Forms.RadioButton();
            this.rb_vacant = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1440, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(457, 58);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(324, 32);
            this.tb_search.TabIndex = 73;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // rb_search
            // 
            this.rb_search.AutoSize = true;
            this.rb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_search.ForeColor = System.Drawing.Color.Black;
            this.rb_search.Location = new System.Drawing.Point(144, 58);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(284, 33);
            this.rb_search.TabIndex = 72;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Search by Flat Number";
            this.rb_search.UseVisualStyleBackColor = true;
            this.rb_search.CheckedChanged += new System.EventHandler(this.rb_search_CheckedChanged);
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button.ForeColor = System.Drawing.Color.White;
            this.refresh_button.Location = new System.Drawing.Point(815, 46);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(152, 55);
            this.refresh_button.TabIndex = 71;
            this.refresh_button.Text = "REFRESH";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // rb_resiowner
            // 
            this.rb_resiowner.AutoSize = true;
            this.rb_resiowner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_resiowner.ForeColor = System.Drawing.Color.Black;
            this.rb_resiowner.Location = new System.Drawing.Point(1012, 8);
            this.rb_resiowner.Name = "rb_resiowner";
            this.rb_resiowner.Size = new System.Drawing.Size(212, 33);
            this.rb_resiowner.TabIndex = 74;
            this.rb_resiowner.TabStop = true;
            this.rb_resiowner.Text = "Resident Owner";
            this.rb_resiowner.UseVisualStyleBackColor = true;
            this.rb_resiowner.CheckedChanged += new System.EventHandler(this.rb_resiowner_CheckedChanged);
            this.rb_resiowner.Click += new System.EventHandler(this.rb_resiowner_Click);
            // 
            // rb_tenant
            // 
            this.rb_tenant.AutoSize = true;
            this.rb_tenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tenant.ForeColor = System.Drawing.Color.Black;
            this.rb_tenant.Location = new System.Drawing.Point(1012, 53);
            this.rb_tenant.Name = "rb_tenant";
            this.rb_tenant.Size = new System.Drawing.Size(113, 33);
            this.rb_tenant.TabIndex = 75;
            this.rb_tenant.TabStop = true;
            this.rb_tenant.Text = "Tenant";
            this.rb_tenant.UseVisualStyleBackColor = true;
            this.rb_tenant.CheckedChanged += new System.EventHandler(this.rb_tenant_CheckedChanged);
            // 
            // rb_vacant
            // 
            this.rb_vacant.AutoSize = true;
            this.rb_vacant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_vacant.ForeColor = System.Drawing.Color.Black;
            this.rb_vacant.Location = new System.Drawing.Point(1012, 101);
            this.rb_vacant.Name = "rb_vacant";
            this.rb_vacant.Size = new System.Drawing.Size(168, 33);
            this.rb_vacant.TabIndex = 77;
            this.rb_vacant.TabStop = true;
            this.rb_vacant.Text = "Vacant Flats";
            this.rb_vacant.UseVisualStyleBackColor = true;
            this.rb_vacant.CheckedChanged += new System.EventHandler(this.rb_vacant_CheckedChanged);
            // 
            // resident_lst_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1445, 820);
            this.Controls.Add(this.rb_vacant);
            this.Controls.Add(this.rb_tenant);
            this.Controls.Add(this.rb_resiowner);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.rb_search);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(312, 180);
            this.Name = "resident_lst_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "resident_lst_view";
            this.Load += new System.EventHandler(this.resident_lst_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.RadioButton rb_search;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.RadioButton rb_resiowner;
        private System.Windows.Forms.RadioButton rb_tenant;
        private System.Windows.Forms.RadioButton rb_vacant;
    }
}