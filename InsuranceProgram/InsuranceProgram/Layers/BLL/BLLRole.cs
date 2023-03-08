using InsuranceProgram.Layers.DAL;
using System;
using System.Data;
using System.Linq;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLRole
    {
        /// <summary>
        /// CRUD - READ of the Role Table
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Read()
        {
            DALRole Data = new DALRole();
            return Data.Read();
        }
    }
}
