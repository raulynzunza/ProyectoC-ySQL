
namespace ProyectoBD.Forms.Locales
{
    partial class IngresarLocalesForm
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
            this.agregarLocales_btn = new System.Windows.Forms.Button();
            this.direccion_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregarLocales_btn
            // 
            this.agregarLocales_btn.Location = new System.Drawing.Point(564, 412);
            this.agregarLocales_btn.Name = "agregarLocales_btn";
            this.agregarLocales_btn.Size = new System.Drawing.Size(148, 47);
            this.agregarLocales_btn.TabIndex = 36;
            this.agregarLocales_btn.Text = "Agregar";
            this.agregarLocales_btn.UseVisualStyleBackColor = true;
            this.agregarLocales_btn.Click += new System.EventHandler(this.agregarLocales_btn_Click);
            // 
            // direccion_tbx
            // 
            this.direccion_tbx.Location = new System.Drawing.Point(492, 305);
            this.direccion_tbx.Name = "direccion_tbx";
            this.direccion_tbx.Size = new System.Drawing.Size(187, 22);
            this.direccion_tbx.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Direccion:";
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(493, 254);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(187, 22);
            this.nombre_tbx.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre:";
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(493, 203);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.ReadOnly = true;
            this.codigo_tbx.Size = new System.Drawing.Size(186, 22);
            this.codigo_tbx.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo de local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ingresar nuevo local";
            // 
            // IngresarLocalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 513);
            this.Controls.Add(this.agregarLocales_btn);
            this.Controls.Add(this.direccion_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarLocalesForm";
            this.Text = "IngresarLocalesForm";
            this.Load += new System.EventHandler(this.IngresarLocalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarLocales_btn;
        private System.Windows.Forms.TextBox direccion_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}