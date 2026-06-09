using System;
using System.Drawing;
using System.Windows.Forms;

namespace SupermarketCheckout
{
    public partial class FormQuanity : Form
    {
        public int Quantity;  // количество которое ввёл пользователь

        public FormQuanity()
        {
            InitializeComponent();
            Quantity = 1;  // по умолчанию 1 штука
        }

        private void FormQuanity_Load(object sender, EventArgs e)
        {
            
        }

        // Когда форма закрывается
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
        }
    }
}