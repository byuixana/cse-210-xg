public class Order{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer, List<Product> productList)
    {
        _customer = customer;
        _productList = productList;
    }

    public void AddProducttoList(Product product)
    {
        _productList.Add(product);
    }

    public void PackingLabels()
    {
        foreach (Product product in _productList)
        {
            string ID = product.GetID();
            string name = product.GetName();
            string packingLabel = $"Name: {name} ID: {ID}";
            Console.WriteLine(packingLabel);
        }
    }

    public double CalculateOrderPrice(Address address)
    {
        double totalOrderPrice = 0;
        foreach(Product product in _productList)
        {
            double productPrice = product.CalculateProductPrice();
            totalOrderPrice = totalOrderPrice + productPrice;
        }
        if (address.inUSA() == true)
        {
            totalOrderPrice = totalOrderPrice + 5;
        } else
        {
            totalOrderPrice = totalOrderPrice + 35;
        }
        double roundedOrderPrice = Math.Round(totalOrderPrice, 2);
        return roundedOrderPrice;
    }
}