
namespace ProyectoBD.Forms.Transporte
{
    partial class VerTransporteForm
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
            this.dgvTransportes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Location = new System.Drawing.Point(97, 136);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.RowHeadersWidth = 51;
            this.dgvTransportes.RowTemplate.Height = 24;
            this.dgvTransportes.Size = new System.Drawing.Size(880, 409);
            this.dgvTransportes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(393, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lista de transportes";
            // 
            // VerTransporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1075, 615);
            this.Controls.Add(this.dgvTransportes);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerTransporteForm";
            this.Text = "VerTransporteForm";
            this.Load += new System.EventHandler(this.VerTransporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.Label label5;
    }
}