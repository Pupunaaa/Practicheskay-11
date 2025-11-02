using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Без названия", 0, 10);

            Console.Write("Введите цену товара: ");
            int priceInput;
            if (int.TryParse(Console.ReadLine(), out priceInput))
            {
                product.Price = priceInput;
            }
            else
            {
                Console.WriteLine("Некорректный ввод цены товара, установлена цена 0.");
            }

            Console.Write("Введите скидку на товар: ");
            int discountInput;
            if (int.TryParse(Console.ReadLine(), out discountInput))
            {
                product.Discount = discountInput;
            }
            else
            {
                Console.WriteLine("Некорректный ввод скидки, установлено значение скидки 10%");
            }

            product.FinalPrice();
            product.Show();
        }
    }

    class Product
    {
        private string name;
        private int price;
        private int discount;
        private int finalPrice;

        public Product(string ProductName, int ProductPrice, int ProductDiscount)
        {
            name = ProductName;
            price = ProductPrice;
            discount = ProductDiscount;
        }

        public string Name { get; set; } = "Без названия";

        public int Price
        {
            get => price;
            set => price = value >= 0 ? value : 0;
        }

        public int Discount
        {
            get => discount;
            set => discount = value >= 0 && value <= 100 ? value : 10;
        }

        public void FinalPrice()
        {
            finalPrice = (price * (100 - discount) / 100);
        }

        public void Show()
        {
            Console.WriteLine($"{name}: {finalPrice} (скидка: {discount}%)");
        }
    }
}