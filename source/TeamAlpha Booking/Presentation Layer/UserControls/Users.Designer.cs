﻿namespace Presentation_Layer.UserControls
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.userDGW = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 21.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(41, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "Korisnici";
            // 
            // userDGW
            // 
            this.userDGW.AllowUserToAddRows = false;
            this.userDGW.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.userDGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.userDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDGW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.userDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.userDGW.ColumnHeadersHeight = 50;
            this.userDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDGW.DefaultCellStyle = dataGridViewCellStyle7;
            this.userDGW.EnableHeadersVisualStyles = false;
            this.userDGW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userDGW.Location = new System.Drawing.Point(0, 130);
            this.userDGW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userDGW.MultiSelect = false;
            this.userDGW.Name = "userDGW";
            this.userDGW.ReadOnly = true;
            this.userDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDGW.RowHeadersVisible = false;
            this.userDGW.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.userDGW.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.userDGW.RowTemplate.Height = 31;
            this.userDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDGW.Size = new System.Drawing.Size(786, 478);
            this.userDGW.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lozinka";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Datum rođenja";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Broj telefona";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 82.91032F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label9.Location = new System.Drawing.Point(46, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(473, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Za brisanje zapisa selektuj red i stisni Obrisati.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(582, 43);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 56);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Obrisati";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.userDGW);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(786, 608);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDGW)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.DataGridView userDGW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;


        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
    }
}
