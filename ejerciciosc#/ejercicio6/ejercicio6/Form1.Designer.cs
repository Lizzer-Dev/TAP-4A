﻿
namespace ejercicio6
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
            this.area_pintable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.area_pintable)).BeginInit();
            this.SuspendLayout();
            // 
            // area_pintable
            // 
            this.area_pintable.Location = new System.Drawing.Point(4, 5);
            this.area_pintable.Name = "area_pintable";
            this.area_pintable.Size = new System.Drawing.Size(978, 452);
            this.area_pintable.TabIndex = 0;
            this.area_pintable.TabStop = false;
            this.area_pintable.Paint += new System.Windows.Forms.PaintEventHandler(this.area_pintable_Paint);
            this.area_pintable.DoubleClick += new System.EventHandler(this.area_pintable_DoubleClick);
            this.area_pintable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area_pintable_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.area_pintable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.area_pintable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox area_pintable;
    }
}
