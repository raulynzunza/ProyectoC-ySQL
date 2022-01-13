
namespace ProyectoBD
{
    partial class ArticulosForm
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
            this.ingresarArt_btn = new System.Windows.Forms.Button();
            this.verArt_btn = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.eliminarArt_btn = new System.Windows.Forms.Button();
            this.modificarArt_btn = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresarArt_btn
            // 
            this.ingresarArt_btn.Location = new System.Drawing.Point(432, 165);
            this.ingresarArt_btn.Name = "ingresarArt_btn";
            this.ingresarArt_btn.Size = new System.Drawing.Size(191, 62);
            this.ingresarArt_btn.TabIndex = 0;
            this.ingresarArt_btn.Text = "Ingresar articulo";
            this.ingresarArt_btn.UseVisualStyleBackColor = true;
            this.ingresarArt_btn.Click += new System.EventHandler(this.ingresarArt_btn_Click);
            // 
            // verArt_btn
            // 
            this.verArt_btn.Location = new System.Drawing.Point(432, 233);
            this.verArt_btn.Name = "verArt_btn";
            this.verArt_btn.Size = new System.Drawing.Size(191, 62);
            this.verArt_btn.TabIndex = 1;
            this.verArt_btn.Text = "Ver articulos";
            this.verArt_btn.UseVisualStyleBackColor = true;
            this.verArt_btn.Click += new System.EventHandler(this.verArt_btn_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.PowderBlue;
            this.panelInfo.Controls.Add(this.eliminarArt_btn);
            this.panelInfo.Controls.Add(this.modificarArt_btn);
            this.panelInfo.Controls.Add(this.verArt_btn);
            this.panelInfo.Controls.Add(this.ingresarArt_btn);
            this.panelInfo.Location = new System.Drawing.Point(2, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1095, 598);
            this.panelInfo.TabIndex = 2;
            // 
            // eliminarArt_btn
            // 
            this.eliminarArt_btn.Location = new System.Drawing.Point(432, 369);
            this.eliminarArt_btn.Name = "eliminarArt_btn";
            this.eliminarArt_btn.Size = new System.Drawing.Size(191, 62);
            this.eliminarArt_btn.TabIndex = 3;
            this.eliminarArt_btn.Text = "Eliminar articulo";
            this.eliminarArt_btn.UseVisualStyleBackColor = true;
            this.eliminarArt_btn.Click += new System.EventHandler(this.eliminarArt_btn_Click);
            // 
            // modificarArt_btn
            // 
            this.modificarArt_btn.Location = new System.Drawing.Point(432, 301);
            this.modificarArt_btn.Name = "modificarArt_btn";
            this.modificarArt_btn.Size = new System.Drawing.Size(191, 62);
            this.modificarArt_btn.TabIndex = 2;
            this.modificarArt_btn.Text = "Modificar articulo existente";
            this.modificarArt_btn.UseVisualStyleBackColor = true;
            this.modificarArt_btn.Click += new System.EventHandler(this.modificarArt_btn_Click);
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1097, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticulosForm";
            this.Text = "ArticulosForm";
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ingresarArt_btn;
        private System.Windows.Forms.Button verArt_btn;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button eliminarArt_btn;
        private System.Windows.Forms.Button modificarArt_btn;
    }
}