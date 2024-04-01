
namespace PresentationLayer
{
    partial class PL_UniqueMemberForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ücret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Üyelik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.Ücret,
            this.Tarih,
            this.Durum,
            this.odeme_tarihi,
            this.Üyelik,
            this.Eposta,
            this.ids,
            this.kimlik});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1062, 426);
            this.dataGridView2.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.FillWeight = 98.82489F;
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Soyad
            // 
            this.Soyad.FillWeight = 97.72397F;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ücret
            // 
            this.Ücret.FillWeight = 57.06898F;
            this.Ücret.HeaderText = "Ücret";
            this.Ücret.MinimumWidth = 6;
            this.Ücret.Name = "Ücret";
            this.Ücret.ReadOnly = true;
            this.Ücret.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tarih
            // 
            this.Tarih.FillWeight = 88.69212F;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // odeme_tarihi
            // 
            this.odeme_tarihi.HeaderText = "Ödeme Tarihi";
            this.odeme_tarihi.MinimumWidth = 6;
            this.odeme_tarihi.Name = "odeme_tarihi";
            this.odeme_tarihi.ReadOnly = true;
            this.odeme_tarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Üyelik
            // 
            this.Üyelik.HeaderText = "Üyelik";
            this.Üyelik.MinimumWidth = 6;
            this.Üyelik.Name = "Üyelik";
            this.Üyelik.ReadOnly = true;
            this.Üyelik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Üyelik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Eposta
            // 
            this.Eposta.FillWeight = 176.4706F;
            this.Eposta.HeaderText = "E-posta";
            this.Eposta.MinimumWidth = 6;
            this.Eposta.Name = "Eposta";
            this.Eposta.ReadOnly = true;
            this.Eposta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ids
            // 
            this.ids.HeaderText = "Id";
            this.ids.MinimumWidth = 6;
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            this.ids.Visible = false;
            // 
            // kimlik
            // 
            this.kimlik.HeaderText = "Kimlik_no";
            this.kimlik.MinimumWidth = 6;
            this.kimlik.Name = "kimlik";
            this.kimlik.ReadOnly = true;
            this.kimlik.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // PL_UniqueMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "PL_UniqueMemberForm";
            this.Text = "PL_UniqueMemberForm";
            this.Load += new System.EventHandler(this.PL_UniqueMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ücret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Üyelik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlik;
        private System.Windows.Forms.Label label1;
    }
}