namespace Login
{
    partial class Ventas
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(57, 63);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(176, 47);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(57, 150);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(176, 47);
            this.btn_baja.TabIndex = 1;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            // 
            // btn_modifica
            // 
            this.btn_modifica.Location = new System.Drawing.Point(57, 246);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(176, 47);
            this.btn_modifica.TabIndex = 2;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 382);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modifica;
    }
}