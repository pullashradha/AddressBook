using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["index.cshtml"];
      Get ["/create_contact"] = _ => View ["create_contact.cshtml"];
      Post ["/contact_created"] = _ => {
        Contact newContact = new Contact
        (
          Request.Form ["first-name"],
          Request.Form ["last-name"],
          Request.Form ["phone-number"],
          Request.Form ["email-address"],
          Request.Form ["street-address"],
          Request.Form ["state-address"]
        );
        return View ["contact_created.cshtml", newContact];
      };
      Post ["/contacts"] = _ => {
        Contact newContactInList = new Contact ();
        newContactInList.Save();
        return View ["contacts.cshtml", newContactInList];
      };
      Post ["/contacts_deleted"] = _ => {
        Contact contactList = new Contact ();
        contactList.ClearAll();
        return View ["contacts_deleted.cshtml"];
      };
    }
  }
}
