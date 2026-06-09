using System;

namespace SupermarketCheckout
{
    public class Product //класс товара
    {
        public int Id; //айди товара
        public string Name; //название
        public int Price; //цена

        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString() //вид в списке
        {
            return Name + "-" + Price + "руб.";
        }
    }

    public class CartItem //класс элемента в корзине
    {
        public Product Product; //товар
        public int Quanity; //количество

        public CartItem(Product product, int quanity)
        {
            Product = product;
            Quanity = quanity;
        }

        public int GetTotal() //общая стоимость товара
        {
            return Product.Price * Quanity;
        }

        public override string ToString() //вид в списке
        {
            return Product.Name + " x" + Quanity + " = " + GetTotal() + " руб.";
        }
    }
}