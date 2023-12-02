// See https://aka.ms/new-console-template for more information



// {

//     Console.WriteLine("Menu Options:");
//     Console.WriteLine("1. Place an order");

//     Console.WriteLine("3. End");
//     Console.Write("One if you would like to place an order, 2 if you want to add an item to your cart:");
//     string userAction = Console.ReadLine();
    // if (userAction == "1")
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
        


    // }






// customer.CreateShippingLabel();
// List<Product> productList = new List<Product>();




// Product product2 = new Product("Milk", "616", 2.02, 2);
// order.AddProducttoList(product2);

// Product product3 = new Product("Herbal Tea", "1776", 3.05, 4);
// order.AddProducttoList(product3);

// double orderPrice = order.CalculateOrderPrice(address);
// Console.WriteLine(orderPrice);

// order.PackingLabels();





