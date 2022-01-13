
namespace ProyectoBD.Forms.Locales
{
    partial class CancelarLocalesForm
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
            this.dgvLocales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocales
            // 
            this.dgvLocales.AllowUserToAddRows = false;
            this.dgvLocales.AllowUserToDeleteRows = false;
            this.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocales.Location = new System.Drawing.Point(112, 157);
            this.dgvLocales.Name = "dgvLocales";
            this.dgvLocales.ReadOnly = true;
            this.dgvLocales.RowHeadersWidth = 51;
            this.dgvLocales.RowTemplate.Height = 24;
            this.dgvLocales.Size = new System.Drawing.Size(825, 294);
            this.dgvLocales.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(393, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Eliminar local";
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
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(416, 101);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.Size = new System.Drawing.Size(118, 22);
            this.codigo_tbx.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(182, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Codigo del local: ";
            // 
            // CancelarLocalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1048, 550);
            this.Controls.Add(this.dgvLocales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelarLocalesForm";
            this.Text = "CancelarLocalesForm";
            this.Load += new System.EventHandler(this.CancelarLocalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.Label label3;
    }
}