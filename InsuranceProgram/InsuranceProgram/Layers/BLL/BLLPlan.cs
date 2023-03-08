using InsuranceProgram.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLPlan
    {
        /// <summary>
        /// CRUD - Read
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Read()
        {
            DALPlan Data = new DALPlan();
            return Data.Read();
        }
    }
}
