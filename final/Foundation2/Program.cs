using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.Write("Name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Provide your address:");

        Console.Write("Street:");
        string street = Console.ReadLine();

        Console.Write("City:");
        string city = Console.ReadLine();

        Console.Write("State:");
        string state = Console.ReadLine();

        Console.Write("Country:");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        
        Customer customer = new Customer(customerName, address);

        bool orderPlaced = false;
        List<Product> productList = new List<Product>();
        Order order = new Order(customer, productList);
        while(orderPlaced == false)
        { 
            
            Console.WriteLine("Add products to your cart. Type none when finished.");
            Console.Write("Product Name:");
            string productName = Console.ReadLine();
            if (productName == "None" || productName == "none")
            {
                Console.WriteLine("Order placed.");
                orderPlaced = true;
            } else{
                Console.Write("Product ID:");
                string productID = Console.ReadLine();

                Console.Write("Price:");
                string productPriceString = Console.ReadLine();
                double productPrice = double.Parse(productPriceString);

                Console.Write("Quantity:");
                string productQuantityString = Console.ReadLine();
                int productQuantity = int.Parse(productQuantityString);
                Product product = new Product(productName, productID, productPrice, productQuantity);
                order.AddProducttoList(product);
            }   
        }
        customer.CreateShippingLabel();
        order.PackingLabels();
        double orderPrice = order.CalculateOrderPrice(address);
        Console.WriteLine(orderPrice);
    }
}