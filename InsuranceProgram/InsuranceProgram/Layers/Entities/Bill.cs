using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class Bill to connect with the Table Bill of the DataBase
    /// </summary>
    public class Bill
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string IdClient { get; set; }
        public string TypeOfCard { get; set; }
        public DateTime Date { get; set; }
        public float IVA { get; set; }
        public bool Status { get; set; }
        public byte[] Photo { get; set; }
        public DataTable Details { get; set; }
        public decimal Total_Dollars { get; set; }
        public decimal Total_Colones { get; set; }
        public byte[] Signature { get; set; }
    }
}
