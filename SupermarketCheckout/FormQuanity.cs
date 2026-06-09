using System;
using System.Drawing;
using System.Windows.Forms;

namespace SupermarketCheckout
{
    public partial class FormQuanity : Form
    {
        public int Quantity;

        public FormQuanity()
        {
            InitializeComponent();
            Quantity = 1;
        }
        private void FormQuanity_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Quantity = (int)numericUpDownQuanity.Value;
            }
            base.OnFormClosing(e);
        }
    }
}