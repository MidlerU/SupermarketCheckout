namespace SupermarketCheckout
{
    partial class FormMain
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
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.buttonGenerateReceipt = new System.Windows.Forms.Button();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxProducts.SuspendLayout();
            this.groupBoxReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.listBoxProducts);
            this.groupBoxProducts.Location = new System.Drawing.Point(10, 10);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(300, 450);
            this.groupBoxProducts.TabIndex = 0;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Товары";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(15, 30);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(270, 368);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.Click += new System.EventHandler(this.listBoxProducts_Click);
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.Controls.Add(this.buttonGenerateReceipt);
            this.groupBoxReceipt.Controls.Add(this.listBoxCart);
            this.groupBoxReceipt.Location = new System.Drawing.Point(330, 10);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(400, 428);
            this.groupBoxReceipt.TabIndex = 1;
            this.groupBoxReceipt.TabStop = false;
            this.groupBoxReceipt.Tag = "";
            this.groupBoxReceipt.Text = "Чек";
            // 
            // buttonGenerateReceipt
            // 
            this.buttonGenerateReceipt.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGenerateReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGenerateReceipt.Location = new System.Drawing.Point(15, 390);
            this.buttonGenerateReceipt.Name = "buttonGenerateReceipt";
            this.buttonGenerateReceipt.Size = new System.Drawing.Size(370, 40);
            this.buttonGenerateReceipt.TabIndex = 1;
            this.buttonGenerateReceipt.Text = "Формировать Чек";
            this.buttonGenerateReceipt.UseVisualStyleBackColor = false;
            this.buttonGenerateReceipt.Click += new System.EventHandler(this.buttonGenerateReceipt_Click);
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(15, 30);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(370, 342);
            this.listBoxCart.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotal.Location = new System.Drawing.Point(341, 459);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(91, 20);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Итог: 0 руб";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonGenerateReceipt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.groupBoxReceipt);
            this.Controls.Add(this.groupBoxProducts);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxReceipt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.Button buttonGenerateReceipt;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label labelTotal;
    }
}