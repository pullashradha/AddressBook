using Nancy;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _fullName;
    private string _phoneNumber;
    private string _emailAddress;
    private string _streetAddress;
    private string _stateAddress;
    private string _fullAddress;
    public Contact (string firstName, string lastName, string fullName, string phoneNumber, string emailAddress, string streetAddress, string stateAddress, string fullAddress)
    {
      _firstName = firstName;
      _lastName = lastName;
      _fullName = fullName;
      _phoneNumber = phoneNumber;
      _emailAddress = emailAddress;
      _streetAddress = streetAddress;
      _stateAddress = stateAddress;
      _fullAddress = fullAddress;
    }
    public string GetFullName()
    {
      _fullName = (_firstName + " " + _lastName);
      return _fullName;
    }
    public void SetFullName(string newFullName)
    {
      _fullName = newFullName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetEmailAddress()
    {
      return _emailAddress;
    }
    public void SetEmailAddress(string newEmailAddress)
    {
      _emailAddress = newEmailAddress;
    }
    public string GetFullAddress()
    {
      _fullAddress = (_streetAddress + ", " + _stateAddress);
      return _fullAddress;
    }
    public void SetFullAddress(string newFullAddress)
    {
      _fullAddress = newFullAddress;
    }
  }
}
