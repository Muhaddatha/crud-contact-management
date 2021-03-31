using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contactManagement.Data
{
    public class ContactService
    {
        private readonly ApplicationDbContext _db;

        public ContactService(ApplicationDbContext db)
        {
            _db = db;
        }

        //get all employees 
        public List<ContactInfo> GetContacts()
        {
            var contactList = _db.Contacts.ToList();
            return contactList;
        }

        public string Create(ContactInfo contactInfo)
        {
            _db.Contacts.Add(contactInfo);
            _db.SaveChanges();
            return "Saved sucessfully";
        }

        public ContactInfo GetContactById(Guid Id)
        {
            ContactInfo contact = _db.Contacts.FirstOrDefault(s => s.Id == Id);
            return contact;
        }

        public string UpdateContact(ContactInfo contact)
        {
            ContactInfo theContact = _db.Contacts.FirstOrDefault(s => s.Id == contact.Id);
            Guid guid = contact.Id;
            string LastName = contact.LastName;
            string FirstName = contact.FirstName;
            string PhoneNumber = contact.PhoneNumber;
            DateTime birthdate = contact.BirthDate;

            _db.Remove(theContact);
            _db.SaveChanges();
            _db.Add(contact);
            _db.SaveChanges();
            return "Updated successfully";
        }

        public string DeleteContactInfo(ContactInfo contact)
        {
            _db.Remove(contact);
            _db.SaveChanges();
            return "Deleted successfully";
        }

    }
}
