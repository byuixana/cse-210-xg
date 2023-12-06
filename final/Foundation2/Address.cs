public class Address{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _inUSA;
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string FormatAddress()
    {
        string addressFormat = $"{_street}\n{_city}\n{_stateOrProvince}\n{_country}";
        return addressFormat;
    }

    public bool inUSA()
    {
        if(_country == "United States" || _country == "USA" || _country == "United States of America")
        {
            _inUSA = true;
        } else{
            _inUSA = false;
        }
        return _inUSA;
    }
}