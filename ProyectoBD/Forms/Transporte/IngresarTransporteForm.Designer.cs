
namespace ProyectoBD.Forms.Transporte
{
    partial class IngresarTransporteForm
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
            this.agregarTransporte_btn = new System.Windows.Forms.Button();
            this.apellidoPaterno_tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_tbx = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoLocal_cbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // agregarTransporte_btn
            // 
            this.agregarTransporte_btn.Location = new System.Drawing.Point(610, 450);
            this.agregarTransporte_btn.Name = "agregarTransporte_btn";
            this.agregarTransporte_btn.Size = new System.Drawing.Size(148, 47);
            this.agregarTransporte_btn.TabIndex = 36;
            this.agregarTransporte_btn.Text = "Agregar";
            this.agregarTransporte_btn.UseVisualStyleBackColor = true;
            this.agregarTransporte_btn.Click += new System.EventHandler(this.agregarTransporte_btn_Click);
            // 
            // apellidoPaterno_tbx
            // 
            this.apellidoPaterno_tbx.Location = new System.Drawing.Point(404, 232);
            this.apellidoPaterno_tbx.Name = "apellidoPaterno_tbx";
            this.apellidoPaterno_tbx.Size = new System.Drawing.Size(187, 22);
            this.apellidoPaterno_tbx.TabIndex = 35;
            // 
            // apellidoMaterno_tbx
            // 
            this.apellidoMaterno_tbx.Location = new System.Drawing.Point(404, 278);
            this.apellidoMaterno_tbx.Name = "apellidoMaterno_tbx";
            this.apellidoMaterno_tbx.Size = new System.Drawing.Size(187, 22);
            this.apellidoMaterno_tbx.TabIndex = 33;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(152, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(181, 25);
            this.label.TabIndex = 32;
            this.label.Text = "Apellido materno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(152, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Codigo de local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido paterno:";
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(404, 186);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(187, 22);
            this.nombre_tbx.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre:";
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(404, 140);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.ReadOnly = true;
            this.codigo_tbx.Size = new System.Drawing.Size(186, 22);
            this.codigo_tbx.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo de transporte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(298, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ingresar nuevo transporte";
            // 
            // codigoLocal_cbx
            // 
            this.codigoLocal_cbx.FormattingEnabled = true;
            this.codigoLocal_cbx.Location = new System.Drawing.Point(404, 324);
            this.codigoLocal_cbx.Name = "codigoLocal_cbx";
            this.codigoLocal_cbx.Size = new System.Drawing.Size(184, 24);
            this.codigoLocal_cbx.TabIndex = 37;
            // 
            // IngresarTransporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(911, 549);
            this.Controls.Add(this.codigoLocal_cbx);
            this.Controls.Add(this.agregarTransporte_btn);
            this.Controls.Add(this.apellidoPaterno_tbx);
            this.Controls.Add(this.apellidoMaterno_tbx);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarTransporteForm";
            this.Text = "IngresarTransporteForm";
            this.Load += new System.EventHandler(this.IngresarTransporteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarTransporte_btn;
        private System.Windows.Forms.TextBox apellidoPaterno_tbx;
        private System.Windows.Forms.TextBox apellidoMaterno_tbx;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox codigoLocal_cbx;
    }
}