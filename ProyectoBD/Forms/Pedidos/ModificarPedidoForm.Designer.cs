
namespace ProyectoBD.Forms.Pedidos
{
    partial class ModificarPedidoForm
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
            this.codigoPedido_cbx = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codigoArticulo_cbx = new System.Windows.Forms.ComboBox();
            this.codigoTransporte_cbx = new System.Windows.Forms.ComboBox();
            this.codigoCliente_cbx = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cantidad_tbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPedido_cbx
            // 
            this.codigoPedido_cbx.FormattingEnabled = true;
            this.codigoPedido_cbx.Location = new System.Drawing.Point(264, 108);
            this.codigoPedido_cbx.Name = "codigoPedido_cbx";
            this.codigoPedido_cbx.Size = new System.Drawing.Size(145, 24);
            this.codigoPedido_cbx.TabIndex = 65;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(415, 83);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(643, 420);
            this.dgvPedidos.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Codigo de articulo:";
            // 
            // modificar_btn
            // 
            this.modificar_btn.Location = new System.Drawing.Point(261, 429);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(148, 47);
            this.modificar_btn.TabIndex = 61;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "Codigo de pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "Codigo de cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Codigo de transporte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(344, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "Modificar pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cantidad:";
            // 
            // codigoArticulo_cbx
            // 
            this.codigoArticulo_cbx.FormattingEnabled = true;
            this.codigoArticulo_cbx.Location = new System.Drawing.Point(264, 153);
            this.codigoArticulo_cbx.Name = "codigoArticulo_cbx";
            this.codigoArticulo_cbx.Size = new System.Drawing.Size(145, 24);
            this.codigoArticulo_cbx.TabIndex = 68;
            // 
            // codigoTransporte_cbx
            // 
            this.codigoTransporte_cbx.FormattingEnabled = true;
            this.codigoTransporte_cbx.Location = new System.Drawing.Point(264, 198);
            this.codigoTransporte_cbx.Name = "codigoTransporte_cbx";
            this.codigoTransporte_cbx.Size = new System.Drawing.Size(145, 24);
            this.codigoTransporte_cbx.TabIndex = 69;
            // 
            // codigoCliente_cbx
            // 
            this.codigoCliente_cbx.FormattingEnabled = true;
            this.codigoCliente_cbx.Location = new System.Drawing.Point(264, 243);
            this.codigoCliente_cbx.Name = "codigoCliente_cbx";
            this.codigoCliente_cbx.Size = new System.Drawing.Size(145, 24);
            this.codigoCliente_cbx.TabIndex = 70;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(149, 288);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(260, 22);
            this.fecha.TabIndex = 71;
            // 
            // cantidad_tbx
            // 
            this.cantidad_tbx.Location = new System.Drawing.Point(264, 337);
            this.cantidad_tbx.Name = "cantidad_tbx";
            this.cantidad_tbx.Size = new System.Drawing.Size(145, 22);
            this.cantidad_tbx.TabIndex = 72;
            // 
            // ModificarPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1159, 526);
            this.Controls.Add(this.cantidad_tbx);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.codigoCliente_cbx);
            this.Controls.Add(this.codigoTransporte_cbx);
            this.Controls.Add(this.codigoArticulo_cbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codigoPedido_cbx);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPedidoForm";
            this.Text = "ModificarPedidoForm";
            this.Load += new System.EventHandler(this.ModificarPedidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox codigoPedido_cbx;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox codigoArticulo_cbx;
        private System.Windows.Forms.ComboBox codigoTransporte_cbx;
        private System.Windows.Forms.ComboBox codigoCliente_cbx;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox cantidad_tbx;
    }
}