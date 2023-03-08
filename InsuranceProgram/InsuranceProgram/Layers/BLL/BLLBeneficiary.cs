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
    public class BLLBeneficiary
    {
        public static DataTable Read(string Id)
        {
            DALBeneficiary Data = new DALBeneficiary();
            return Data.Read(Id);
        }

        public static string Insert(string Id, string FirstName, string LastName, string IdClient, DateTime date, string Relationship, string PhoneNumber)
        {
            DALBeneficiary Data = new DALBeneficiary();

            string Exist = Data.Exist(Id);

            if (Exist.Equals("1"))
            {
                return "The Beneficiary already exists";
            }
            else
            {
                Beneficiary Obj = new Beneficiary();
                Obj.Identification = Id;
                Obj.FistName = FirstName;
                Obj.LastName = LastName;
                Obj.IDClient = IdClient;
                Obj.DateOfBirth = date;
                Obj.Relationship = Relationship;
                Obj.PhoneNumber = PhoneNumber;
                return Data.Insert(Obj);
            }
        }

        public static string Update(string Id, string FirstName, string LastName, string IdClient, DateTime date, string Relationship, string PhoneNumber)
        {
            DALBeneficiary Data = new DALBeneficiary();
            Beneficiary Obj = new Beneficiary();

            string Exist = Data.Exist(Id);
            if (Exist.Equals("1"))
            {
                return "The beneficiary already exists";
            }
            else
            {
                Obj.Identification = Id;
                Obj.FistName = FirstName;
                Obj.LastName = LastName;
                Obj.IDClient = IdClient;
                Obj.DateOfBirth = date;
                Obj.Relationship = Relationship;
                Obj.PhoneNumber = PhoneNumber;
                return Data.Update(Obj);
            }
        }

        public static string Delete(string Id)
        {
            DALBeneficiary Data = new DALBeneficiary();
            return Data.Delete(Id);
        }

        public static string DeleteAll(string Id)
        {
            DALBeneficiary Data = new DALBeneficiary();
            return Data.DeleteAll(Id);
        }
    }
}
