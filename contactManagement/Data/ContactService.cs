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
            _db.Contacts.Update(contact);
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
