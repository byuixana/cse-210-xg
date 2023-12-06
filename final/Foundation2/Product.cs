public class Product{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateProductPrice()
    {
        double totalProductPrice = _price * _quantity;
        double roundedProductPrice = Math.Round(totalProductPrice, 2);
        return roundedProductPrice;
    }

    public string GetID()
    {
        return _productID;
    }

    public string GetName()
    {
        return _productName;
    }

}