using InsuranceProgram.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLCountries
    {
        /// <summary>
        /// CRUD - Read
        /// This method read all the countries saved in the database
        /// </summary>
        /// <returns></returns>
        public static DataTable Read()
        {
            DALCountries Data = new DALCountries();
            return Data.Read();
        }
    }
}
