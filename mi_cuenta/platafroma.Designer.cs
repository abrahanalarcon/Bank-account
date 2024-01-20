namespace mi_cuenta
{
    partial class platafroma
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
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Location = new System.Drawing.Point(354, 143);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(187, 64);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar ";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Location = new System.Drawing.Point(354, 239);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(187, 64);
            this.btnRetirar.TabIndex = 1;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Location = new System.Drawing.Point(354, 334);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(187, 64);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(354, 426);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 64);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(191, 85);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 25);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // platafroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "platafroma";
            this.Text = "platafroma";
            this.Load += new System.EventHandler(this.platafroma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBienvenida;
    }
}