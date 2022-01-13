
namespace ProyectoBD
{
    partial class ClientesForm
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
            this.panelClientes = new System.Windows.Forms.Panel();
            this.eliminarCliente_btn = new System.Windows.Forms.Button();
            this.modificarClientes_btn = new System.Windows.Forms.Button();
            this.verClientes_btn = new System.Windows.Forms.Button();
            this.ingresarCliente_btn = new System.Windows.Forms.Button();
            this.panelClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelClientes.Controls.Add(this.eliminarCliente_btn);
            this.panelClientes.Controls.Add(this.modificarClientes_btn);
            this.panelClientes.Controls.Add(this.verClientes_btn);
            this.panelClientes.Controls.Add(this.ingresarCliente_btn);
            this.panelClientes.Location = new System.Drawing.Point(0, 1);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(1090, 599);
            this.panelClientes.TabIndex = 0;
            // 
            // eliminarCliente_btn
            // 
            this.eliminarCliente_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCliente_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarCliente_btn.Location = new System.Drawing.Point(454, 370);
            this.eliminarCliente_btn.Name = "eliminarCliente_btn";
            this.eliminarCliente_btn.Size = new System.Drawing.Size(191, 62);
            this.eliminarCliente_btn.TabIndex = 11;
            this.eliminarCliente_btn.Text = "Eliminar cliente";
            this.eliminarCliente_btn.UseVisualStyleBackColor = true;
            this.eliminarCliente_btn.Click += new System.EventHandler(this.eliminarCliente_btn_Click);
            // 
            // modificarClientes_btn
            // 
            this.modificarClientes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarClientes_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificarClientes_btn.Location = new System.Drawing.Point(454, 302);
            this.modificarClientes_btn.Name = "modificarClientes_btn";
            this.modificarClientes_btn.Size = new System.Drawing.Size(191, 62);
            this.modificarClientes_btn.TabIndex = 10;
            this.modificarClientes_btn.Text = "Modificar cliente existente";
            this.modificarClientes_btn.UseVisualStyleBackColor = true;
            this.modificarClientes_btn.Click += new System.EventHandler(this.modificarClientes_btn_Click);
            // 
            // verClientes_btn
            // 
            this.verClientes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verClientes_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verClientes_btn.Location = new System.Drawing.Point(454, 234);
            this.verClientes_btn.Name = "verClientes_btn";
            this.verClientes_btn.Size = new System.Drawing.Size(191, 62);
            this.verClientes_btn.TabIndex = 9;
            this.verClientes_btn.Text = "Ver clientes";
            this.verClientes_btn.UseVisualStyleBackColor = true;
            this.verClientes_btn.Click += new System.EventHandler(this.verClientes_btn_Click);
            // 
            // ingresarCliente_btn
            // 
            this.ingresarCliente_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarCliente_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ingresarCliente_btn.Location = new System.Drawing.Point(454, 166);
            this.ingresarCliente_btn.Name = "ingresarCliente_btn";
            this.ingresarCliente_btn.Size = new System.Drawing.Size(191, 62);
            this.ingresarCliente_btn.TabIndex = 8;
            this.ingresarCliente_btn.Text = "Ingresar nuevo cliente";
            this.ingresarCliente_btn.UseVisualStyleBackColor = true;
            this.ingresarCliente_btn.Click += new System.EventHandler(this.ingresarCliente_btn_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1091, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.panelClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Button eliminarCliente_btn;
        private System.Windows.Forms.Button modificarClientes_btn;
        private System.Windows.Forms.Button verClientes_btn;
        private System.Windows.Forms.Button ingresarCliente_btn;
    }
}