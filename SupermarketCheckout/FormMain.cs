using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupermarketCheckout
{
    public partial class FormMain : Form
    {
        private List<Product> products;
        private List<CartItem> cart;

        public FormMain()
        {
            InitializeComponent();
            InitializeProducts();
            cart = new List<CartItem>();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void InitializeProducts()
        {
            products = new List<Product>();

            products.Add(new Product(1, "Молоко 1л", 85));
            products.Add(new Product(2, "Хлеб бородинский", 45));
            products.Add(new Product(3, "Яйца (10 шт)", 95));
            products.Add(new Product(4, "Сыр российский 200г", 180));
            products.Add(new Product(5, "Колбаса докторская 300г", 250));
            products.Add(new Product(6, "Сахар 1кг", 65));
            products.Add(new Product(7, "Чай черный 100г", 120));
            products.Add(new Product(8, "Кофе молотый 250г", 350));
            products.Add(new Product(9, "Масло сливочное 180г", 145));
            products.Add(new Product(10, "Шоколад молочный 100г", 95));

            listBoxProducts.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                listBoxProducts.Items.Add(products[i]);
            }
        }

        private void listBoxProducts_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem == null)
                return;

            Product selectedProduct = (Product)listBoxProducts.SelectedItem;

            FormQuanity dialog = new FormQuanity();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int quantity = dialog.Quantity;

                CartItem existingItem = null;
                for (int i = 0; i < cart.Count; i++)
                {
                    if (cart[i].Product.Id == selectedProduct.Id)
                    {
                        existingItem = cart[i];
                        break;
                    }
                }

                if (existingItem != null)
                {
                    existingItem.Quanity = existingItem.Quanity + quantity;
                }
                else
                {
                    CartItem newItem = new CartItem(selectedProduct, quantity);
                    cart.Add(newItem);
                }

                UpdateCartDisplay();
            }
        }

        private void UpdateCartDisplay()
        {
            listBoxCart.Items.Clear();

            decimal total = 0;

            for (int i = 0; i < cart.Count; i++)
            {
                CartItem item = cart[i];
                listBoxCart.Items.Add(item);
                total = total + item.GetTotal();
            }

            labelTotal.Text = "Итого: " + total + " руб.";
        }

        private void buttonGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Корзина пуста! Добавьте товары.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string receipt = "=== ЧЕК ПОКУПКИ ===\n\n";
            decimal total = 0;

            for (int i = 0; i < cart.Count; i++)
            {
                CartItem item = cart[i];
                receipt = receipt + item.Product.Name + "\n";
                receipt = receipt + "  Цена: " + item.Product.Price + " руб.\n";
                receipt = receipt + "  Количество: " + item.Quanity + " шт.\n";
                receipt = receipt + "  Сумма: " + item.GetTotal() + " руб.\n\n";
                total = total + item.GetTotal();
            }

            receipt = receipt + "===================\n";
            receipt = receipt + "ИТОГО: " + total + " руб.\n";
            receipt = receipt + "===================\n";
            receipt = receipt + "Спасибо за покупку!";

            MessageBox.Show(receipt, "Чек", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cart.Clear();
            UpdateCartDisplay();
        }
    }
}