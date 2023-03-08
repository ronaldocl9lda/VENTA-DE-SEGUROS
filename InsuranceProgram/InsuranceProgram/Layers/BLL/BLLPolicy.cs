using InsuranceProgram.Layers.DAL;
using InsuranceProgram.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLPolicy
    {
        /// <summary>
        /// CRUD - Read of the Table Policy
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Read()
        {
            DALPolicy Data = new DALPolicy();
            return Data.Read();
        }
        /// <summary>
        /// CRUD - Read of the Table Policy but this method has a parameter
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Read(int Code)
        {
            DALPolicy Data = new DALPolicy();
            return Data.Read(Code);
        }
        /// <summary>
        /// CRUD - CREATE
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Description"></param>
        /// <param name="PlanId"></param>
        /// <returns>string with the confirmation</returns>
        public static string Insert(int Code, string Description, int PlanId)
        {
            DALPolicy Data = new DALPolicy();

            string Exist = Data.Exist(Code);

            if (Exist.Equals("1"))
            {
                return "The Policy already exists";
            }
            else
            {
                Policy Obj = new Policy();
                Obj.Code = Code;
                Obj.Description = Description;
                Obj.PlanId = PlanId;
                return Data.Insert(Obj);
            }
        }

        /// <summary>
        /// CRUD - Update
        /// </summary>
        /// <param name="PreviousCode"></param>
        /// <param name="Code"></param>
        /// <param name="Description"></param>
        /// <param name="PlanId"></param>
        /// <returns>string with the confirmation</returns>
        public static string Update(int PreviousCode, int Code, string Description, int PlanId)
        {
            DALPolicy Data = new DALPolicy();

            if (PreviousCode.Equals(Code))
            {
                Policy Obj = new Policy();
                Obj.Code = Code;
                Obj.Description = Description;
                Obj.PlanId = PlanId;
                return Data.Update(Obj);
            }
            else
            {
                string Exist = Data.Exist(Code);
                if (Exist.Equals("1"))
                {
                    return "The policy already exists";
                }
                else
                {
                    Policy Obj = new Policy();
                    Obj.Code = Code;
                    Obj.Description = Description;
                    Obj.PlanId = PlanId;
                    return Data.Update(Obj);
                }
            }
        }

        /// <summary>
        /// CRUD - Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Delete(int Id)
        {
            DALPolicy Data = new DALPolicy();
            return Data.Delete(Id);
        }

        /// <summary>
        /// To activate the Row
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Activate(int Id)
        {
            DALPolicy Data = new DALPolicy();
            return Data.Activate(Id);
        }
        /// <summary>
        /// To desactivate the row
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string Deactivate(int Id)
        {
            DALPolicy Data = new DALPolicy();
            return Data.Deactivate(Id);
        }
    }
}
