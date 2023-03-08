using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class Client to connect with the Table Client of the DataBase
    /// </summary>
    public class Client
    {
        public string Identification { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Nationality { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
