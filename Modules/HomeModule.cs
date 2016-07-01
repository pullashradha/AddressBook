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
      Get ["/contacts/new"] = _ => View ["contact_form.cshtml"];
      Post ["/contact"] = _ => {
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
      Get ["/contacts/{id}"] = parameters => {
        Contact newContact = Contact.Find(parameters.id);
        return View ["/contact_created.cshtml", newContact];
      };
      Get ["/contacts"] = _ => {
        List<Contact> newContactList = Contact.GetAll();
        return View ["contacts.cshtml", newContactList];
      };
      Post ["/contacts/deleted"] = _ => {
        Contact.DeleteAll();
        return View ["contacts_deleted.cshtml"];
      };
    }
  }
}
