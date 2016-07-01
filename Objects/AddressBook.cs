using Nancy;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _emailAddress;
    private string _streetAddress;
    private string _stateAddress;
    private int _id;
    private static List<Contact> _contactsList = new List<Contact> {};
    public Contact (string firstName, string lastName, string phoneNumber, string emailAddress, string streetAddress, string stateAddress)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _emailAddress = emailAddress;
      _streetAddress = streetAddress;
      _stateAddress = stateAddress;
      _contactsList.Add(this);
      _id = _contactsList.Count;
    }
    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
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
    public string GetStreetAddress()
    {
      return _streetAddress;
    }
    public void SetStreetAddress(string newStreetAddress)
    {
      _streetAddress = newStreetAddress;
    }
    public string GetStateAddress()
    {
      return _stateAddress;
    }
    public void SetStateAddress(string newStateAddress)
    {
      _stateAddress = newStateAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contactsList;
    }
    public static Contact Find(int searchId)
    {
      return _contactsList[searchId - 1];
    }
    public static void DeleteAll()
    {
      _contactsList.Clear();
    }
  }
}
