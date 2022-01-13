
namespace ProyectoBD.Forms.Transporte
{
    partial class EliminarTransporteForm
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
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo_cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransporte
            // 
            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransporte.Location = new System.Drawing.Point(112, 157);
            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.RowHeadersWidth = 51;
            this.dgvTransporte.RowTemplate.Height = 24;
            this.dgvTransporte.Size = new System.Drawing.Size(825, 294);
            this.dgvTransporte.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(393, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Eliminar transporte";
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Location = new System.Drawing.Point(699, 467);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(148, 47);
            this.eliminar_btn.TabIndex = 37;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(182, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Codigo de transporte: ";
            // 
            // codigo_cbx
            // 
            this.codigo_cbx.FormattingEnabled = true;
            this.codigo_cbx.Location = new System.Drawing.Point(440, 99);
            this.codigo_cbx.Name = "codigo_cbx";
            this.codigo_cbx.Size = new System.Drawing.Size(171, 24);
            this.codigo_cbx.TabIndex = 40;
            // 
            // EliminarTransporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1048, 550);
            this.Controls.Add(this.codigo_cbx);
            this.Controls.Add(this.dgvTransporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarTransporteForm";
            this.Text = "EliminarTransporteForm";
            this.Load += new System.EventHandler(this.EliminarTransporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox codigo_cbx;
    }
}