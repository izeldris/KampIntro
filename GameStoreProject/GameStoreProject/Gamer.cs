using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class Gamer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalIdentity { get; set; }
        public bool IsStudent { get; set; }
    }
}
