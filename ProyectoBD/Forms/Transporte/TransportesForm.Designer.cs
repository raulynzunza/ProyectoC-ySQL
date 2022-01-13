
namespace ProyectoBD
{
    partial class TransportesForm
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
            this.panelTransporte = new System.Windows.Forms.Panel();
            this.cancelarTransporte_btn = new System.Windows.Forms.Button();
            this.modificarTransporte_btn = new System.Windows.Forms.Button();
            this.verTransporte_btn = new System.Windows.Forms.Button();
            this.ingresarTransporte_btn = new System.Windows.Forms.Button();
            this.panelTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransporte
            // 
            this.panelTransporte.Controls.Add(this.cancelarTransporte_btn);
            this.panelTransporte.Controls.Add(this.modificarTransporte_btn);
            this.panelTransporte.Controls.Add(this.verTransporte_btn);
            this.panelTransporte.Controls.Add(this.ingresarTransporte_btn);
            this.panelTransporte.Location = new System.Drawing.Point(0, 0);
            this.panelTransporte.Name = "panelTransporte";
            this.panelTransporte.Size = new System.Drawing.Size(1099, 597);
            this.panelTransporte.TabIndex = 0;
            // 
            // cancelarTransporte_btn
            // 
            this.cancelarTransporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarTransporte_btn.Location = new System.Drawing.Point(453, 369);
            this.cancelarTransporte_btn.Name = "cancelarTransporte_btn";
            this.cancelarTransporte_btn.Size = new System.Drawing.Size(191, 62);
            this.cancelarTransporte_btn.TabIndex = 15;
            this.cancelarTransporte_btn.Text = "Eliminar transporte";
            this.cancelarTransporte_btn.UseVisualStyleBackColor = true;
            this.cancelarTransporte_btn.Click += new System.EventHandler(this.cancelarTransporte_btn_Click);
            // 
            // modificarTransporte_btn
            // 
            this.modificarTransporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarTransporte_btn.Location = new System.Drawing.Point(453, 301);
            this.modificarTransporte_btn.Name = "modificarTransporte_btn";
            this.modificarTransporte_btn.Size = new System.Drawing.Size(191, 62);
            this.modificarTransporte_btn.TabIndex = 14;
            this.modificarTransporte_btn.Text = "Modificar transporte";
            this.modificarTransporte_btn.UseVisualStyleBackColor = true;
            this.modificarTransporte_btn.Click += new System.EventHandler(this.modificarTransporte_btn_Click);
            // 
            // verTransporte_btn
            // 
            this.verTransporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verTransporte_btn.Location = new System.Drawing.Point(453, 233);
            this.verTransporte_btn.Name = "verTransporte_btn";
            this.verTransporte_btn.Size = new System.Drawing.Size(191, 62);
            this.verTransporte_btn.TabIndex = 13;
            this.verTransporte_btn.Text = "Ver transporte";
            this.verTransporte_btn.UseVisualStyleBackColor = true;
            this.verTransporte_btn.Click += new System.EventHandler(this.verTransporte_btn_Click);
            // 
            // ingresarTransporte_btn
            // 
            this.ingresarTransporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarTransporte_btn.Location = new System.Drawing.Point(453, 165);
            this.ingresarTransporte_btn.Name = "ingresarTransporte_btn";
            this.ingresarTransporte_btn.Size = new System.Drawing.Size(191, 62);
            this.ingresarTransporte_btn.TabIndex = 12;
            this.ingresarTransporte_btn.Text = "Ingresar nuevo transporte";
            this.ingresarTransporte_btn.UseVisualStyleBackColor = true;
            this.ingresarTransporte_btn.Click += new System.EventHandler(this.ingresarTransporte_btn_Click);
            // 
            // TransportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1097, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportesForm";
            this.Text = "TransportesForm";
            this.panelTransporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransporte;
        private System.Windows.Forms.Button cancelarTransporte_btn;
        private System.Windows.Forms.Button modificarTransporte_btn;
        private System.Windows.Forms.Button verTransporte_btn;
        private System.Windows.Forms.Button ingresarTransporte_btn;
    }
}