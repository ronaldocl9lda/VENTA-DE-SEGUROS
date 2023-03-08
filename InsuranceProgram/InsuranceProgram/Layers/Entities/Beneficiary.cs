using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class Beneficiary to connect with the Table Beneficiary of the DataBase
    /// </summary>
    public class Beneficiary
    {
        public string Identification { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public string IDClient { get; set; }
        public string PhoneNumber { get; set; }
    }
}
