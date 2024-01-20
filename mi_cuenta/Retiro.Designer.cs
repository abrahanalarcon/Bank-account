namespace mi_cuenta
{
    partial class Retiro
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
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(289, 231);
            this.txtRetiro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(111, 20);
            this.txtRetiro.TabIndex = 6;
            this.txtRetiro.TextChanged += new System.EventHandler(this.txtRetiro_TextChanged);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(311, 273);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(64, 27);
            this.btnRetirar.TabIndex = 7;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese la cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "¿Cuanto quieres retirar?";
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtRetiro);
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}