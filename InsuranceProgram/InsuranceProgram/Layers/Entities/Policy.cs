using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Entities
{
    /// <summary>
    /// Class Policy to connect with the Table Policy of the DataBase
    /// </summary>
    public class Policy
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public int PlanId { get; set; }
        public bool Status { get; set; }
    }
}
