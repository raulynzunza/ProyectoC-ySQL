
namespace ProyectoBD
{
    partial class LocalesForm
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
            this.panelLocales = new System.Windows.Forms.Panel();
            this.cancelarLocales_btn = new System.Windows.Forms.Button();
            this.modificarLocales_btn = new System.Windows.Forms.Button();
            this.verLocales_btn = new System.Windows.Forms.Button();
            this.ingresarLocales_btn = new System.Windows.Forms.Button();
            this.panelLocales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLocales
            // 
            this.panelLocales.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLocales.Controls.Add(this.cancelarLocales_btn);
            this.panelLocales.Controls.Add(this.modificarLocales_btn);
            this.panelLocales.Controls.Add(this.verLocales_btn);
            this.panelLocales.Controls.Add(this.ingresarLocales_btn);
            this.panelLocales.Location = new System.Drawing.Point(3, 4);
            this.panelLocales.Name = "panelLocales";
            this.panelLocales.Size = new System.Drawing.Size(1093, 594);
            this.panelLocales.TabIndex = 0;
            // 
            // cancelarLocales_btn
            // 
            this.cancelarLocales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarLocales_btn.Location = new System.Drawing.Point(452, 368);
            this.cancelarLocales_btn.Name = "cancelarLocales_btn";
            this.cancelarLocales_btn.Size = new System.Drawing.Size(191, 62);
            this.cancelarLocales_btn.TabIndex = 19;
            this.cancelarLocales_btn.Text = "Cancelar local";
            this.cancelarLocales_btn.UseVisualStyleBackColor = true;
            this.cancelarLocales_btn.Click += new System.EventHandler(this.cancelarLocales_btn_Click);
            // 
            // modificarLocales_btn
            // 
            this.modificarLocales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarLocales_btn.Location = new System.Drawing.Point(452, 300);
            this.modificarLocales_btn.Name = "modificarLocales_btn";
            this.modificarLocales_btn.Size = new System.Drawing.Size(191, 62);
            this.modificarLocales_btn.TabIndex = 18;
            this.modificarLocales_btn.Text = "Modificar locales";
            this.modificarLocales_btn.UseVisualStyleBackColor = true;
            this.modificarLocales_btn.Click += new System.EventHandler(this.modificarLocales_btn_Click);
            // 
            // verLocales_btn
            // 
            this.verLocales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLocales_btn.Location = new System.Drawing.Point(452, 232);
            this.verLocales_btn.Name = "verLocales_btn";
            this.verLocales_btn.Size = new System.Drawing.Size(191, 62);
            this.verLocales_btn.TabIndex = 17;
            this.verLocales_btn.Text = "Ver locales";
            this.verLocales_btn.UseVisualStyleBackColor = true;
            this.verLocales_btn.Click += new System.EventHandler(this.verLocales_btn_Click);
            // 
            // ingresarLocales_btn
            // 
            this.ingresarLocales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarLocales_btn.Location = new System.Drawing.Point(452, 164);
            this.ingresarLocales_btn.Name = "ingresarLocales_btn";
            this.ingresarLocales_btn.Size = new System.Drawing.Size(191, 62);
            this.ingresarLocales_btn.TabIndex = 16;
            this.ingresarLocales_btn.Text = "Ingresar nuevo local";
            this.ingresarLocales_btn.UseVisualStyleBackColor = true;
            this.ingresarLocales_btn.Click += new System.EventHandler(this.ingresarLocales_btn_Click);
            // 
            // LocalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1097, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelLocales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalesForm";
            this.Text = "LocalesForm";
            this.panelLocales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLocales;
        private System.Windows.Forms.Button cancelarLocales_btn;
        private System.Windows.Forms.Button modificarLocales_btn;
        private System.Windows.Forms.Button verLocales_btn;
        private System.Windows.Forms.Button ingresarLocales_btn;
    }
}