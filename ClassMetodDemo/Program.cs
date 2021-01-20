using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri nesnesi oluşturup özelliklerine  değer atama
            Customer customer1 = new Customer();
            customer1.IdentityNo = "12345678909";
            customer1.Name = "Necdet";
            customer1.Surname = "Aygün";
            customer1.Age = 30;
            customer1.Gender = "Male";

            //nesneleri oluşturup aşağıdaki gibi de değer verebiliriz
            Customer customer2 = new Customer { IdentityNo = "09876543210", Name = "Yasemin", Surname = "Ünsal", Age = 28, Gender = "Female" };

            //ekle sil metodlarının sınıfından nesne oluşturup fonksiyonları kullanabildik
            CustomerManager manager = new CustomerManager();
            manager.AddCustomer(customer1);
            manager.AddCustomer(customer2);
            manager.DeleteCustomer(customer1);
            manager.DeleteCustomer(customer2);

            //müşterileri listeleme
            Customer[] customers = new Customer[]{
                customer1, customer2
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name: " + customer.Name + "\nSurname: " + customer.Surname + "\nAge: " + customer.Age);
                Console.ReadKey();
            }

            //case sensitive
            // PascalCase class ve değişken adları vs  //camelCase oluşturulan nesnenin adı
        }
    }
}
