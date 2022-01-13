
namespace ProyectoBD.Forms.Transporte
{
    partial class ModificarTransporteForm
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
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.apellidoMaterno_tbx = new System.Windows.Forms.TextBox();
            this.apellidoPaterno_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoTransporte_cbx = new System.Windows.Forms.ComboBox();
            this.codigoLocal_cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Location = new System.Drawing.Point(513, 84);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.RowHeadersWidth = 51;
            this.dgvTransportes.RowTemplate.Height = 24;
            this.dgvTransportes.Size = new System.Drawing.Size(568, 420);
            this.dgvTransportes.TabIndex = 51;
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(312, 153);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(186, 22);
            this.nombre_tbx.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(60, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nombre:";
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(350, 443);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(148, 47);
            this.modificar_btn.TabIndex = 48;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // apellidoMaterno_tbx
            // 
            this.apellidoMaterno_tbx.Location = new System.Drawing.Point(312, 243);
            this.apellidoMaterno_tbx.Name = "apellidoMaterno_tbx";
            this.apellidoMaterno_tbx.Size = new System.Drawing.Size(186, 22);
            this.apellidoMaterno_tbx.TabIndex = 45;
            // 
            // apellidoPaterno_tbx
            // 
            this.apellidoPaterno_tbx.Location = new System.Drawing.Point(312, 198);
            this.apellidoPaterno_tbx.Name = "apellidoPaterno_tbx";
            this.apellidoPaterno_tbx.Size = new System.Drawing.Size(186, 22);
            this.apellidoPaterno_tbx.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Codigo de local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Codigo de transporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(60, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Apellido paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Modificar transporte";
            // 
            // codigoTransporte_cbx
            // 
            this.codigoTransporte_cbx.FormattingEnabled = true;
            this.codigoTransporte_cbx.Location = new System.Drawing.Point(312, 108);
            this.codigoTransporte_cbx.Name = "codigoTransporte_cbx";
            this.codigoTransporte_cbx.Size = new System.Drawing.Size(186, 24);
            this.codigoTransporte_cbx.TabIndex = 52;
            // 
            // codigoLocal_cbx
            // 
            this.codigoLocal_cbx.FormattingEnabled = true;
            this.codigoLocal_cbx.Location = new System.Drawing.Point(312, 288);
            this.codigoLocal_cbx.Name = "codigoLocal_cbx";
            this.codigoLocal_cbx.Size = new System.Drawing.Size(186, 24);
            this.codigoLocal_cbx.TabIndex = 53;
            // 
            // ModificarTransporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1159, 526);
            this.Controls.Add(this.codigoLocal_cbx);
            this.Controls.Add(this.codigoTransporte_cbx);
            this.Controls.Add(this.dgvTransportes);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.apellidoMaterno_tbx);
            this.Controls.Add(this.apellidoPaterno_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarTransporteForm";
            this.Text = "ModificarTransporteForm";
            this.Load += new System.EventHandler(this.ModificarTransporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox apellidoMaterno_tbx;
        private System.Windows.Forms.TextBox apellidoPaterno_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox codigoTransporte_cbx;
        private System.Windows.Forms.ComboBox codigoLocal_cbx;
    }
}