using InsuranceProgram.Layers.DAL;
using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLCoverages 
    {
        /// <summary>
        /// CRUD - Create
        /// Insert to the database a row to the Table Coverage
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Description"></param>
        /// <param name="MaxAmount"></param>
        /// <param name="EventsPerYear"></param>
        /// <param name="GracePeriod"></param>
        /// <param name="SumAssured"></param>
        /// <param name="Prima"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public static string Insert(int ID, string Description, decimal MaxAmount, int EventsPerYear,
                int GracePeriod, decimal SumAssured, decimal Prima, decimal Total)
        {
            DALCoverages Data = new DALCoverages();

            string Exist = Data.Exist(ID);

            if (Exist.Equals("1"))
            {
                return "The Coverage already exists";
            }
            else
            {
                Coverage Obj = new Coverage();
                Obj.ID = ID;
                Obj.Description = Description;
                Obj.MaxAmount = MaxAmount;
                Obj.EventsPerYear = EventsPerYear;
                Obj.GracePeriod = GracePeriod;
                Obj.SumAssured = SumAssured;
                Obj.Prima = Prima;
                Obj.Total = Total;
                return Data.Insert(Obj);
            }
        }

        /// <summary>
        /// CRUD - Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>string with the confirmation</returns>
        public static string Delete(int Id)
        {
            DALCoverages Data = new DALCoverages();
            return Data.Delete(Id);
        }

        public static string Activate(int Id)
        {
            DALCoverages Data = new DALCoverages();
            return Data.Activate(Id);
        }

        public static string Deactivate(int Id)
        {
            DALCoverages Data = new DALCoverages();
            return Data.Deactivate(Id);
        }
    }
}
