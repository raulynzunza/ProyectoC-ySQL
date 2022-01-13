
namespace ProyectoBD.Forms.Clientes
{
    partial class ModificarClientesForm
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.direccion_tbx = new System.Windows.Forms.TextBox();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_tbx = new System.Windows.Forms.TextBox();
            this.apellidoPaterno_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telefono_tbx = new System.Windows.Forms.TextBox();
            this.correo_tbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(478, 85);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(568, 420);
            this.dgvClientes.TabIndex = 34;
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(277, 154);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(186, 22);
            this.nombre_tbx.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nombre:";
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(315, 444);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(148, 47);
            this.modificar_btn.TabIndex = 31;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // direccion_tbx
            // 
            this.direccion_tbx.Location = new System.Drawing.Point(277, 289);
            this.direccion_tbx.Name = "direccion_tbx";
            this.direccion_tbx.Size = new System.Drawing.Size(186, 22);
            this.direccion_tbx.TabIndex = 30;
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(277, 109);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.Size = new System.Drawing.Size(186, 22);
            this.codigo_tbx.TabIndex = 29;
            // 
            // apellidoMaterno_tbx
            // 
            this.apellidoMaterno_tbx.Location = new System.Drawing.Point(277, 244);
            this.apellidoMaterno_tbx.Name = "apellidoMaterno_tbx";
            this.apellidoMaterno_tbx.Size = new System.Drawing.Size(186, 22);
            this.apellidoMaterno_tbx.TabIndex = 28;
            // 
            // apellidoPaterno_tbx
            // 
            this.apellidoPaterno_tbx.Location = new System.Drawing.Point(277, 199);
            this.apellidoPaterno_tbx.Name = "apellidoPaterno_tbx";
            this.apellidoPaterno_tbx.Size = new System.Drawing.Size(186, 22);
            this.apellidoPaterno_tbx.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Codigo de cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Apellido paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Modificar cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Correo:";
            // 
            // telefono_tbx
            // 
            this.telefono_tbx.Location = new System.Drawing.Point(277, 334);
            this.telefono_tbx.Name = "telefono_tbx";
            this.telefono_tbx.Size = new System.Drawing.Size(186, 22);
            this.telefono_tbx.TabIndex = 37;
            // 
            // correo_tbx
            // 
            this.correo_tbx.Location = new System.Drawing.Point(277, 379);
            this.correo_tbx.Name = "correo_tbx";
            this.correo_tbx.Size = new System.Drawing.Size(186, 22);
            this.correo_tbx.TabIndex = 38;
            // 
            // ModificarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 526);
            this.Controls.Add(this.correo_tbx);
            this.Controls.Add(this.telefono_tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.direccion_tbx);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.apellidoMaterno_tbx);
            this.Controls.Add(this.apellidoPaterno_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarClientesForm";
            this.Text = "ModificarClientesForm";
            this.Load += new System.EventHandler(this.ModificarClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox direccion_tbx;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.TextBox apellidoMaterno_tbx;
        private System.Windows.Forms.TextBox apellidoPaterno_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefono_tbx;
        private System.Windows.Forms.TextBox correo_tbx;
    }
}