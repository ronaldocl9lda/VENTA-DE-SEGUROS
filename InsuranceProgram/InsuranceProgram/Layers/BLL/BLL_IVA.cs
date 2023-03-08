using InsuranceProgram.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLL_IVA
    {
        /// <summary>
        /// Method to read the table IVA of the DataBase
        /// </summary>
        /// <returns>Returns an object Database</returns>
        public static DataTable Read()
        {
            DAL_IVA Data = new DAL_IVA();
            return Data.Read();
        }
        /// <summary>
        /// Method to get the IVA Value
        /// </summary>
        /// <returns></returns>
        public static float GetIVA()
        {
            float IVA = 0;
            foreach(DataRow row in BLL_IVA.Read().Rows)
            {
                IVA += float.Parse(row["IVA"].ToString());
            }
            return IVA;
        } 
        /// <summary>
        /// Method to update the Value of the VIA
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string Update(float Value)
        {
            DAL_IVA Data = new DAL_IVA();

            if (Value < 0)
                throw new ApplicationException("The IVA cannot be less than 0");

            if (Value > 100)
                throw new ApplicationException("The IVA cannot be more than 100");

            return Data.Update(Value);

        }
    }
}