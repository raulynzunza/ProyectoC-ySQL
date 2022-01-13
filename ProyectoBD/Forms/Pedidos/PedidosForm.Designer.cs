
namespace ProyectoBD
{
    partial class PedidosForm
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
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.cancelarPedido_btn = new System.Windows.Forms.Button();
            this.modificarPedido_btn = new System.Windows.Forms.Button();
            this.verPedido_btn = new System.Windows.Forms.Button();
            this.ingresarPedido_btn = new System.Windows.Forms.Button();
            this.panelPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPedidos
            // 
            this.panelPedidos.Controls.Add(this.cancelarPedido_btn);
            this.panelPedidos.Controls.Add(this.modificarPedido_btn);
            this.panelPedidos.Controls.Add(this.verPedido_btn);
            this.panelPedidos.Controls.Add(this.ingresarPedido_btn);
            this.panelPedidos.Location = new System.Drawing.Point(0, 0);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(1099, 601);
            this.panelPedidos.TabIndex = 0;
            // 
            // cancelarPedido_btn
            // 
            this.cancelarPedido_btn.Location = new System.Drawing.Point(454, 371);
            this.cancelarPedido_btn.Name = "cancelarPedido_btn";
            this.cancelarPedido_btn.Size = new System.Drawing.Size(191, 62);
            this.cancelarPedido_btn.TabIndex = 11;
            this.cancelarPedido_btn.Text = "Cancelar pedido";
            this.cancelarPedido_btn.UseVisualStyleBackColor = true;
            this.cancelarPedido_btn.Click += new System.EventHandler(this.cancelarPedido_btn_Click);
            // 
            // modificarPedido_btn
            // 
            this.modificarPedido_btn.Location = new System.Drawing.Point(454, 303);
            this.modificarPedido_btn.Name = "modificarPedido_btn";
            this.modificarPedido_btn.Size = new System.Drawing.Size(191, 62);
            this.modificarPedido_btn.TabIndex = 10;
            this.modificarPedido_btn.Text = "Modificar pedido";
            this.modificarPedido_btn.UseVisualStyleBackColor = true;
            this.modificarPedido_btn.Click += new System.EventHandler(this.modificarPedido_btn_Click);
            // 
            // verPedido_btn
            // 
            this.verPedido_btn.Location = new System.Drawing.Point(454, 235);
            this.verPedido_btn.Name = "verPedido_btn";
            this.verPedido_btn.Size = new System.Drawing.Size(191, 62);
            this.verPedido_btn.TabIndex = 9;
            this.verPedido_btn.Text = "Ver pedidos";
            this.verPedido_btn.UseVisualStyleBackColor = true;
            this.verPedido_btn.Click += new System.EventHandler(this.verPedido_btn_Click);
            // 
            // ingresarPedido_btn
            // 
            this.ingresarPedido_btn.Location = new System.Drawing.Point(454, 167);
            this.ingresarPedido_btn.Name = "ingresarPedido_btn";
            this.ingresarPedido_btn.Size = new System.Drawing.Size(191, 62);
            this.ingresarPedido_btn.TabIndex = 8;
            this.ingresarPedido_btn.Text = "Ingresar nuevo pedido";
            this.ingresarPedido_btn.UseVisualStyleBackColor = true;
            this.ingresarPedido_btn.Click += new System.EventHandler(this.ingresarPedido_btn_Click);
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosForm";
            this.Text = "PedidosForm";
            this.panelPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPedidos;
        private System.Windows.Forms.Button cancelarPedido_btn;
        private System.Windows.Forms.Button modificarPedido_btn;
        private System.Windows.Forms.Button verPedido_btn;
        private System.Windows.Forms.Button ingresarPedido_btn;
    }
}