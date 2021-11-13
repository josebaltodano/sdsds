
namespace ProductosApp.Formularios
{
    partial class fmrdemos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgbProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "crear producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgbProducts
            // 
            this.dgbProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbProducts.Location = new System.Drawing.Point(12, 103);
            this.dgbProducts.Name = "dgbProducts";
            this.dgbProducts.Size = new System.Drawing.Size(357, 203);
            this.dgbProducts.TabIndex = 2;
            // 
            // fmrdemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbProducts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fmrdemos";
            this.Text = "fmrdemos";
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgbProducts;
    }
}