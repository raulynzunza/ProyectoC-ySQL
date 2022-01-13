
namespace ProyectoBD
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.articulos_btn = new FontAwesome.Sharp.IconButton();
            this.pedidos_btn = new FontAwesome.Sharp.IconButton();
            this.transporte_btn = new FontAwesome.Sharp.IconButton();
            this.locales_btn = new FontAwesome.Sharp.IconButton();
            this.clientes_btn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelInfo.Location = new System.Drawing.Point(202, 21);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1097, 624);
            this.panelInfo.TabIndex = 5;
            // 
            // articulos_btn
            // 
            this.articulos_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.articulos_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.articulos_btn.FlatAppearance.BorderSize = 0;
            this.articulos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articulos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulos_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articulos_btn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.articulos_btn.IconColor = System.Drawing.Color.SteelBlue;
            this.articulos_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.articulos_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.articulos_btn.Location = new System.Drawing.Point(0, 197);
            this.articulos_btn.Name = "articulos_btn";
            this.articulos_btn.Size = new System.Drawing.Size(196, 71);
            this.articulos_btn.TabIndex = 6;
            this.articulos_btn.Text = "Articulos";
            this.articulos_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.articulos_btn.UseVisualStyleBackColor = false;
            this.articulos_btn.Click += new System.EventHandler(this.articulos_btn_Click);
            // 
            // pedidos_btn
            // 
            this.pedidos_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.pedidos_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pedidos_btn.FlatAppearance.BorderSize = 0;
            this.pedidos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidos_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pedidos_btn.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.pedidos_btn.IconColor = System.Drawing.Color.SteelBlue;
            this.pedidos_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pedidos_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pedidos_btn.Location = new System.Drawing.Point(0, 284);
            this.pedidos_btn.Name = "pedidos_btn";
            this.pedidos_btn.Size = new System.Drawing.Size(196, 71);
            this.pedidos_btn.TabIndex = 7;
            this.pedidos_btn.Text = "Pedidos";
            this.pedidos_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pedidos_btn.UseVisualStyleBackColor = false;
            this.pedidos_btn.Click += new System.EventHandler(this.pedidos_btn_Click);
            // 
            // transporte_btn
            // 
            this.transporte_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.transporte_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transporte_btn.FlatAppearance.BorderSize = 0;
            this.transporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transporte_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transporte_btn.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.transporte_btn.IconColor = System.Drawing.Color.SteelBlue;
            this.transporte_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transporte_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transporte_btn.Location = new System.Drawing.Point(0, 371);
            this.transporte_btn.Name = "transporte_btn";
            this.transporte_btn.Size = new System.Drawing.Size(196, 71);
            this.transporte_btn.TabIndex = 8;
            this.transporte_btn.Text = "Transporte";
            this.transporte_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transporte_btn.UseVisualStyleBackColor = false;
            this.transporte_btn.Click += new System.EventHandler(this.transporte_btn_Click);
            // 
            // locales_btn
            // 
            this.locales_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.locales_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locales_btn.FlatAppearance.BorderSize = 0;
            this.locales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locales_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locales_btn.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.locales_btn.IconColor = System.Drawing.Color.SteelBlue;
            this.locales_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.locales_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locales_btn.Location = new System.Drawing.Point(0, 458);
            this.locales_btn.Name = "locales_btn";
            this.locales_btn.Size = new System.Drawing.Size(196, 71);
            this.locales_btn.TabIndex = 9;
            this.locales_btn.Text = "Locales";
            this.locales_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.locales_btn.UseVisualStyleBackColor = false;
            this.locales_btn.Click += new System.EventHandler(this.locales_btn_Click);
            // 
            // clientes_btn
            // 
            this.clientes_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.clientes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientes_btn.FlatAppearance.BorderSize = 0;
            this.clientes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientes_btn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.clientes_btn.IconColor = System.Drawing.Color.SteelBlue;
            this.clientes_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientes_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientes_btn.Location = new System.Drawing.Point(0, 545);
            this.clientes_btn.Name = "clientes_btn";
            this.clientes_btn.Size = new System.Drawing.Size(196, 71);
            this.clientes_btn.TabIndex = 10;
            this.clientes_btn.Text = "Clientes";
            this.clientes_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientes_btn.UseVisualStyleBackColor = false;
            this.clientes_btn.Click += new System.EventHandler(this.clientes_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1309, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientes_btn);
            this.Controls.Add(this.locales_btn);
            this.Controls.Add(this.transporte_btn);
            this.Controls.Add(this.pedidos_btn);
            this.Controls.Add(this.articulos_btn);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private FontAwesome.Sharp.IconButton articulos_btn;
        private FontAwesome.Sharp.IconButton pedidos_btn;
        private FontAwesome.Sharp.IconButton transporte_btn;
        private FontAwesome.Sharp.IconButton locales_btn;
        private FontAwesome.Sharp.IconButton clientes_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

