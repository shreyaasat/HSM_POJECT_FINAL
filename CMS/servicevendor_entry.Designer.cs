
namespace CMS
{
    partial class servicevendor_entry
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_sv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_entry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.tb_sv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_entry);
            this.panel1.Location = new System.Drawing.Point(45, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 334);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.Visible = false;
            // 
            // tb_sv
            // 
            this.tb_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sv.Location = new System.Drawing.Point(331, 78);
            this.tb_sv.Margin = new System.Windows.Forms.Padding(8);
            this.tb_sv.Name = "tb_sv";
            this.tb_sv.Size = new System.Drawing.Size(338, 39);
            this.tb_sv.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(73, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 30);
            this.label6.TabIndex = 59;
            this.label6.Text = "REGISTERED ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.RosyBrown;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bt_exit.FlatAppearance.BorderSize = 2;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(394, 192);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(184, 51);
            this.bt_exit.TabIndex = 44;
            this.bt_exit.Text = "LEFT";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_entry
            // 
            this.bt_entry.BackColor = System.Drawing.Color.RosyBrown;
            this.bt_entry.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bt_entry.FlatAppearance.BorderSize = 2;
            this.bt_entry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entry.Location = new System.Drawing.Point(164, 192);
            this.bt_entry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_entry.Name = "bt_entry";
            this.bt_entry.Size = new System.Drawing.Size(184, 51);
            this.bt_entry.TabIndex = 43;
            this.bt_entry.Text = "ENTERED";
            this.bt_entry.UseVisualStyleBackColor = false;
            this.bt_entry.Click += new System.EventHandler(this.bt_entry_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 41);
            this.button1.TabIndex = 63;
            this.button1.Text = "SERVICE VENDOR ENTRY / EXIT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // servicevendor_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 250);
            this.Name = "servicevendor_entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "dailyhelp_entry";
            this.Load += new System.EventHandler(this.dailyhelp_entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_sv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_entry;
        private System.Windows.Forms.Button button1;
    }
}