using System;

namespace GameCompanyOdev.Entities
{
    class Customer:IEntity
    {
        public int IdentityNo { get; set; }      
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DataOfBirth { get; set; }

    }
}
