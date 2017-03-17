using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product();
            Console.Write("請輸入產品名稱:");
            product.Name = Console.ReadLine();
            Console.Write("請輸入{0}的價錢:", product.Name);
            try
            {
                int price = 0;
                price = int.Parse(Console.ReadLine());
                product.SetPrice(price);
                Console.WriteLine("產品:{0}的價格是{1}", product.Name, product.GetPrice());
            }
            catch
            {
                Console.WriteLine("價格輸入錯誤");
                return;
            }

            Product product2 = new Product();
            Console.Write("請輸入產品名稱:");
            product2.Name = Console.ReadLine();
            Console.Write("請輸入{0}的價錢:", product2.Name);
            int price2 = 0;
            price2 = int.Parse(Console.ReadLine());
            product2.SetPrice(price2);
        }
    }
}