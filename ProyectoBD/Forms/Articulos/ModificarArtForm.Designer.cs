
namespace ProyectoBD.Forms
{
    partial class ModificarArtForm
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
            this.modificar_btn = new System.Windows.Forms.Button();
            this.descripcion_tbx = new System.Windows.Forms.TextBox();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.precio_tbx = new System.Windows.Forms.TextBox();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidad_tbx = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(281, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar articulo";
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(372, 489);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(148, 47);
            this.modificar_btn.TabIndex = 18;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // descripcion_tbx
            // 
            this.descripcion_tbx.Location = new System.Drawing.Point(258, 324);
            this.descripcion_tbx.Multiline = true;
            this.descripcion_tbx.Name = "descripcion_tbx";
            this.descripcion_tbx.Size = new System.Drawing.Size(262, 159);
            this.descripcion_tbx.TabIndex = 17;
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(258, 143);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.Size = new System.Drawing.Size(118, 22);
            this.codigo_tbx.TabIndex = 16;
            // 
            // precio_tbx
            // 
            this.precio_tbx.Location = new System.Drawing.Point(258, 280);
            this.precio_tbx.Name = "precio_tbx";
            this.precio_tbx.Size = new System.Drawing.Size(186, 22);
            this.precio_tbx.TabIndex = 15;
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(258, 232);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(186, 22);
            this.nombre_tbx.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripcion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo del articulo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cantidad:";
            // 
            // cantidad_tbx
            // 
            this.cantidad_tbx.Location = new System.Drawing.Point(258, 192);
            this.cantidad_tbx.Name = "cantidad_tbx";
            this.cantidad_tbx.Size = new System.Drawing.Size(118, 22);
            this.cantidad_tbx.TabIndex = 20;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(538, 116);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(502, 420);
            this.dgvArticulos.TabIndex = 21;
            // 
            // ModificarArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1080, 561);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.cantidad_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.descripcion_tbx);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.precio_tbx);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarArtForm";
            this.Text = "ModificarArtForm";
            this.Load += new System.EventHandler(this.ModificarArtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox descripcion_tbx;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.TextBox precio_tbx;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cantidad_tbx;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}