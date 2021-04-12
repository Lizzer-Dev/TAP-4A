
namespace ejercicio5
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
            this.area_pintable.Location = new System.Drawing.Point(2, 2);
            this.area_pintable.Name = "area_pintable";
            this.area_pintable.Size = new System.Drawing.Size(984, 415);
            this.area_pintable.TabIndex = 0;
            this.area_pintable.TabStop = false;
            this.area_pintable.Click += new System.EventHandler(this.area_pintable_Click);
            this.area_pintable.Paint += new System.Windows.Forms.PaintEventHandler(this.area_pintable_Paint);
            this.area_pintable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area_pintable_MouseClick);
            this.area_pintable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.area_pintable_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.area_pintable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.area_pintable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox area_pintable;
    }
}

