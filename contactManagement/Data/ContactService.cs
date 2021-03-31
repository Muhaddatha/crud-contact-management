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


    }
}
