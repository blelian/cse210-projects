public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetStreetAddress() => _streetAddress;
    public void SetStreetAddress(string streetAddress) => _streetAddress = streetAddress;

    public string GetCity() => _city;
    public void SetCity(string city) => _city = city;

    public string GetStateOrProvince() => _stateOrProvince;
    public void SetStateOrProvince(string stateOrProvince) => _stateOrProvince = stateOrProvince;

    public string GetCountry() => _country;
    public void SetCountry(string country) => _country = country;

    public bool IsInUSA() => _country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    public string GetFullAddress() =>
        $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
}