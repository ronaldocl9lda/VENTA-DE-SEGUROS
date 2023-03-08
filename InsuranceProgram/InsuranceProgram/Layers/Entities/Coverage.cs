using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class Coverage to connect with the Table Coverage of the DataBase
    /// </summary>
    public class Coverage
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal MaxAmount { get; set; }
        public int EventsPerYear { get; set; }
        public int GracePeriod { get; set; }
        public decimal SumAssured { get; set; }
        public decimal Prima { get; set; }
        public decimal Total { get; set; }
    }
}
