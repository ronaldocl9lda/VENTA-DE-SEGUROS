using InsuranceProgram.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLPlanCoverage
    {
        /// <summary>
        /// CRUD - Read
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Datatable</returns>
        public static DataTable Read(int Id)
        {
            DALPlanCoverage Data = new DALPlanCoverage();
            return Data.Read(Id);
        }
        /// <summary>
        /// CRUD - Create
        /// Insert a data to the PlanCoverage Table
        /// </summary>
        /// <param name="PlanId"></param>
        /// <param name="CoverageId"></param>
        /// <returns></returns>
        public static string Insert(int PlanId, int CoverageId)
        {
            DALPlanCoverage Data = new DALPlanCoverage();

            return Data.Insert(PlanId, CoverageId);
        }
    }
}
