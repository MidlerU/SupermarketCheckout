namespace SupermarketCheckout
{
    partial class FormQuanity
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
            this.labelQuanity = new System.Windows.Forms.Label();
            this.numericUpDownQuanity = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuanity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuanity
            // 
            this.labelQuanity.AutoSize = true;
            this.labelQuanity.Location = new System.Drawing.Point(108, 14);
            this.labelQuanity.Name = "labelQuanity";
            this.labelQuanity.Size = new System.Drawing.Size(69, 13);
            this.labelQuanity.TabIndex = 0;
            this.labelQuanity.Text = "Количество:";
            // 
            // numericUpDownQuanity
            // 
            this.numericUpDownQuanity.Location = new System.Drawing.Point(82, 30);
            this.numericUpDownQuanity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownQuanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuanity.Name = "numericUpDownQuanity";
            this.numericUpDownQuanity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuanity.TabIndex = 1;
            this.numericUpDownQuanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(163, 56);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(30, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(82, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormQuanity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownQuanity);
            this.Controls.Add(this.labelQuanity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите количество";
            this.Load += new System.EventHandler(this.FormQuanity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuanity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuanity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuanity;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}