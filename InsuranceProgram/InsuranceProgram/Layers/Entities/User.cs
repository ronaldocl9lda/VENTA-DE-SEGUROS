using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class User to connect with the Table User of the DataBase
    /// </summary>
    public class User
    {
        public string ID { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public Byte[] Photo { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
