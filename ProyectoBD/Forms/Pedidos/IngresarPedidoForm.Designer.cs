
namespace ProyectoBD.Forms.Pedidos
{
    partial class IngresarPedidoForm
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
            this.agregar_btn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidad_tbx = new System.Windows.Forms.TextBox();
            this.codigoCliente_cbx = new System.Windows.Forms.ComboBox();
            this.codigoTransporte_cbx = new System.Windows.Forms.ComboBox();
            this.codigoArticulo_cbx = new System.Windows.Forms.ComboBox();
            this.fecha_dt = new System.Windows.Forms.DateTimePicker();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar_btn
            // 
            this.agregar_btn.Location = new System.Drawing.Point(363, 472);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(148, 47);
            this.agregar_btn.TabIndex = 48;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(11, 297);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(222, 29);
            this.label.TabIndex = 45;
            this.label.Text = "Codigo del articulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codigo de transporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo de cliente:";
            // 
            // codigo_tbx
            // 
            this.codigo_tbx.Location = new System.Drawing.Point(263, 166);
            this.codigo_tbx.Name = "codigo_tbx";
            this.codigo_tbx.ReadOnly = true;
            this.codigo_tbx.Size = new System.Drawing.Size(247, 22);
            this.codigo_tbx.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Codigo de pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ingresar nuevo pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cantidad:";
            // 
            // cantidad_tbx
            // 
            this.cantidad_tbx.Location = new System.Drawing.Point(263, 398);
            this.cantidad_tbx.Name = "cantidad_tbx";
            this.cantidad_tbx.Size = new System.Drawing.Size(248, 22);
            this.cantidad_tbx.TabIndex = 51;
            // 
            // codigoCliente_cbx
            // 
            this.codigoCliente_cbx.FormattingEnabled = true;
            this.codigoCliente_cbx.Location = new System.Drawing.Point(263, 212);
            this.codigoCliente_cbx.Name = "codigoCliente_cbx";
            this.codigoCliente_cbx.Size = new System.Drawing.Size(245, 24);
            this.codigoCliente_cbx.TabIndex = 52;
            // 
            // codigoTransporte_cbx
            // 
            this.codigoTransporte_cbx.FormattingEnabled = true;
            this.codigoTransporte_cbx.Location = new System.Drawing.Point(263, 258);
            this.codigoTransporte_cbx.Name = "codigoTransporte_cbx";
            this.codigoTransporte_cbx.Size = new System.Drawing.Size(245, 24);
            this.codigoTransporte_cbx.TabIndex = 53;
            // 
            // codigoArticulo_cbx
            // 
            this.codigoArticulo_cbx.FormattingEnabled = true;
            this.codigoArticulo_cbx.Location = new System.Drawing.Point(263, 304);
            this.codigoArticulo_cbx.Name = "codigoArticulo_cbx";
            this.codigoArticulo_cbx.Size = new System.Drawing.Size(245, 24);
            this.codigoArticulo_cbx.TabIndex = 54;
            // 
            // fecha_dt
            // 
            this.fecha_dt.Location = new System.Drawing.Point(263, 350);
            this.fecha_dt.Name = "fecha_dt";
            this.fecha_dt.Size = new System.Drawing.Size(248, 22);
            this.fecha_dt.TabIndex = 55;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(517, 84);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(564, 475);
            this.dgvPedidos.TabIndex = 56;
            // 
            // IngresarPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 601);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.fecha_dt);
            this.Controls.Add(this.codigoArticulo_cbx);
            this.Controls.Add(this.codigoTransporte_cbx);
            this.Controls.Add(this.codigoCliente_cbx);
            this.Controls.Add(this.cantidad_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarPedidoForm";
            this.Text = "IngresarPedidoForm";
            this.Load += new System.EventHandler(this.IngresarPedidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cantidad_tbx;
        private System.Windows.Forms.ComboBox codigoCliente_cbx;
        private System.Windows.Forms.ComboBox codigoTransporte_cbx;
        private System.Windows.Forms.ComboBox codigoArticulo_cbx;
        private System.Windows.Forms.DateTimePicker fecha_dt;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}