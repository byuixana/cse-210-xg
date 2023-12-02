public class Customer{
    private string _name;
    private Address _address;
    private bool _statesResidence;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckCountry()
    {
        if (_address.inUSA() == true)
        {
            _statesResidence = true;
        }
        else
        {
            _statesResidence = false;
        }
        return _statesResidence;
    }

    public string GetName()
    {
        return _name;
    }

    public void CreateShippingLabel()
    {
        string shippingLabel = $"{_name} {_address.FormatAddress()}";
        Console.WriteLine(shippingLabel);
    }
}