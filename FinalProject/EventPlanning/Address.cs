public class Address{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    public Address(string street, string city, string stateOrProvince)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
    }

      public string FormatAddress()
    {
        string addressFormat = $"{_street}\n{_city}\n{_stateOrProvince}";
        return addressFormat;
    }
}