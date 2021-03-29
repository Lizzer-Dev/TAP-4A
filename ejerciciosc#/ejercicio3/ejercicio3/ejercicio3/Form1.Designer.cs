
namespace ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aceptar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.ListBox();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(670, 32);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(83, 290);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(12, 32);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(81, 290);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el texto en la parte inferior de la ventana";
            // 
            // caja
            // 
            this.caja.FormattingEnabled = true;
            this.caja.ItemHeight = 15;
            this.caja.Location = new System.Drawing.Point(100, 32);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(564, 259);
            this.caja.TabIndex = 3;
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(100, 299);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(564, 23);
            this.txt_in.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 334);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox caja;
        private System.Windows.Forms.TextBox txt_in;
    }
}

