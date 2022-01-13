
namespace ProyectoBD
{
    partial class IngresoArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.precio_tbx = new System.Windows.Forms.TextBox();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.descripcion_tbx = new System.Windows.Forms.TextBox();
            this.agregarArt_btn = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.Label();
            this.cantidad_tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo del articulo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(126, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(381, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresar nuevo articulo";
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(361, 145);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(186, 22);
            this.nombre_tbx.TabIndex = 5;
            // 
            // precio_tbx
            // 
            this.precio_tbx.Location = new System.Drawing.Point(361, 240);
            this.precio_tbx.Name = "precio_tbx";
            this.precio_tbx.Size = new System.Drawing.Size(186, 22);
            this.precio_tbx.TabIndex = 6;
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(361, 295);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.ReadOnly = true;
            this.codigo_tbx.Size = new System.Drawing.Size(118, 22);
            this.codigo_tbx.TabIndex = 7;
            // 
            // descripcion_tbx
            // 
            this.descripcion_tbx.Location = new System.Drawing.Point(361, 342);
            this.descripcion_tbx.Multiline = true;
            this.descripcion_tbx.Name = "descripcion_tbx";
            this.descripcion_tbx.Size = new System.Drawing.Size(262, 159);
            this.descripcion_tbx.TabIndex = 8;
            // 
            // agregarArt_btn
            // 
            this.agregarArt_btn.Location = new System.Drawing.Point(636, 529);
            this.agregarArt_btn.Name = "agregarArt_btn";
            this.agregarArt_btn.Size = new System.Drawing.Size(148, 47);
            this.agregarArt_btn.TabIndex = 9;
            this.agregarArt_btn.Text = "Agregar";
            this.agregarArt_btn.UseVisualStyleBackColor = true;
            this.agregarArt_btn.Click += new System.EventHandler(this.agregarArt_btn_Click);
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cantidad.Location = new System.Drawing.Point(126, 191);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(106, 25);
            this.cantidad.TabIndex = 10;
            this.cantidad.Text = "Cantidad:";
            // 
            // cantidad_tbx
            // 
            this.cantidad_tbx.Location = new System.Drawing.Point(361, 198);
            this.cantidad_tbx.Name = "cantidad_tbx";
            this.cantidad_tbx.Size = new System.Drawing.Size(186, 22);
            this.cantidad_tbx.TabIndex = 11;
            // 
            // IngresoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1095, 597);
            this.Controls.Add(this.cantidad_tbx);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.agregarArt_btn);
            this.Controls.Add(this.descripcion_tbx);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.precio_tbx);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoArticulos";
            this.Load += new System.EventHandler(this.IngresoArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.TextBox precio_tbx;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.TextBox descripcion_tbx;
        private System.Windows.Forms.Button agregarArt_btn;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.TextBox cantidad_tbx;
    }
}