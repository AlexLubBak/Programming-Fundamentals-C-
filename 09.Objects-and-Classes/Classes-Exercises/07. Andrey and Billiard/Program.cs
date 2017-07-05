using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopingList { get; set; }

        public decimal Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<Customer> customerList = new List<Customer>();

            for (int i = 0; i < n; i++)
            {

                var tokens = Console.ReadLine().Split('-').ToArray();

                var item = tokens[0];

                var price = decimal.Parse(tokens[1]);

                if (!products.ContainsKey(item))
                {
                    products.Add(item, price);
                }
                else
                {
                    products[item] = price;
                }
            }

            var orders = string.Empty;
            while (true)
            {
                orders = Console.ReadLine();

                if (orders == "end of clients")
                    break;

                var tokens = orders.Split('-', ',').ToArray();
                string name = tokens[0];
                string order = tokens[1];
                int orderQuantity = int.Parse(tokens[2]);


                if (!products.ContainsKey(order))
                {
                    continue;
                }

                Customer customer = new Customer()
                {
                    Name = name,
                    ShopingList = new Dictionary<string, int>
                    {
                        [order] = orderQuantity
                    },
                    Bill = orderQuantity * products[order]

                };

                if (!customerList.Exists(c => c.Name == customer.Name))
                {
                    customerList.Add(customer);
                }
                else
                {
                    Customer existingCustomer = customerList.First(c => c.Name == name);
                    if (!(existingCustomer.ShopingList.ContainsKey(order)))
                    {
                        existingCustomer.ShopingList.Add(order, orderQuantity);
                        existingCustomer.Bill += customer.Bill;
                    }
                    else
                    {
                        existingCustomer.ShopingList[order] += orderQuantity;
                        existingCustomer.Bill += customer.Bill;
                    }
                }
            }

            decimal totalPrice = 0;
            foreach (var customer in customerList.OrderBy(a => a.Name).ThenBy(b => b.Bill))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.ShopingList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine("Bill: {0:F2}", customer.Bill);
                totalPrice += customer.Bill;
            }
            Console.WriteLine($"Total bill: {customerList.Sum(a => a.Bill):F2}");
        }
    }
}