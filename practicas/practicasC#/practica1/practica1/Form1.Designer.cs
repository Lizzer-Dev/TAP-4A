
namespace practica1
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
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.OP = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_entrada
            // 
            this.txt_entrada.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_entrada.Location = new System.Drawing.Point(13, 12);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(459, 23);
            this.txt_entrada.TabIndex = 0;
            this.txt_entrada.Text = "123456789";
            this.txt_entrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_entrada_MouseClick);
            this.txt_entrada.TextChanged += new System.EventHandler(this.txt_entrada_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_resultado);
            this.panel1.Controls.Add(this.btn_potencia);
            this.panel1.Controls.Add(this.btn_0);
            this.panel1.Controls.Add(this.btn_mult);
            this.panel1.Controls.Add(this.btn_dividir);
            this.panel1.Controls.Add(this.btn_9);
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.btn_7);
            this.panel1.Controls.Add(this.btn_resta);
            this.panel1.Controls.Add(this.btn_6);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.btn_suma);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.OP);
            this.panel1.Controls.Add(this.C3);
            this.panel1.Controls.Add(this.C2);
            this.panel1.Controls.Add(this.C1);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 297);
            this.panel1.TabIndex = 1;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(356, 215);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(76, 49);
            this.btn_resultado.TabIndex = 19;
            this.btn_resultado.Text = "=";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Location = new System.Drawing.Point(238, 215);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(75, 49);
            this.btn_potencia.TabIndex = 18;
            this.btn_potencia.Text = "^";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(121, 215);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(74, 49);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(21, 215);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(70, 49);
            this.btn_mult.TabIndex = 16;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(356, 159);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(76, 50);
            this.btn_dividir.TabIndex = 15;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(238, 159);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 50);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(121, 159);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(73, 50);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(21, 159);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(70, 50);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(356, 102);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(76, 49);
            this.btn_resta.TabIndex = 11;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(238, 102);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 49);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(121, 102);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(73, 49);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(21, 103);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(70, 50);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(356, 45);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(76, 51);
            this.btn_suma.TabIndex = 7;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(238, 47);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 49);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(121, 47);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(74, 50);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(21, 47);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(70, 50);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // OP
            // 
            this.OP.AutoSize = true;
            this.OP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OP.Location = new System.Drawing.Point(379, 9);
            this.OP.Name = "OP";
            this.OP.Size = new System.Drawing.Size(37, 25);
            this.OP.TabIndex = 3;
            this.OP.Text = "OP";
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(260, 9);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(34, 25);
            this.C3.TabIndex = 2;
            this.C3.Text = "C3";
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(145, 9);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(34, 25);
            this.C2.TabIndex = 1;
            this.C2.Text = "C2";
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(32, 9);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(34, 25);
            this.C1.TabIndex = 0;
            this.C1.Text = "C1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_entrada);
            this.Name = "Form1";
            this.Text = "Calculadora Simple";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label OP;
        private System.Windows.Forms.Label C3;
        private System.Windows.Forms.Label C2;
    }
}

