using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Person
    {
        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyleBit { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmailPromotion { get; set; }
        public Guid rowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
