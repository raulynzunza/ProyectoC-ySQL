
namespace ProyectoBD.Forms.Locales
{
    partial class ModificarLocalesForm
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
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.direccion_tbx = new System.Windows.Forms.TextBox();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modificar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocales
            // 
            this.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocales.Location = new System.Drawing.Point(471, 128);
            this.dgvLocales.Name = "dgvLocales";
            this.dgvLocales.RowHeadersWidth = 51;
            this.dgvLocales.RowTemplate.Height = 24;
            this.dgvLocales.Size = new System.Drawing.Size(568, 303);
            this.dgvLocales.TabIndex = 50;
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(270, 197);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(186, 22);
            this.nombre_tbx.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(36, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nombre:";
            // 
            // direccion_tbx
            // 
            this.direccion_tbx.Location = new System.Drawing.Point(270, 248);
            this.direccion_tbx.Name = "direccion_tbx";
            this.direccion_tbx.Size = new System.Drawing.Size(186, 22);
            this.direccion_tbx.TabIndex = 47;
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(270, 152);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.Size = new System.Drawing.Size(186, 22);
            this.codigo_tbx.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Codigo de local:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(293, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Modificar local";
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(308, 384);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(148, 47);
            this.modificar_btn.TabIndex = 51;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // ModificarLocalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1075, 477);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.dgvLocales);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direccion_tbx);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarLocalesForm";
            this.Text = "ModificarLocalesForm";
            this.Load += new System.EventHandler(this.ModificarLocalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox direccion_tbx;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificar_btn;
    }
}