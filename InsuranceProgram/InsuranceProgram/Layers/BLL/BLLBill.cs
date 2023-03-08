using InsuranceProgram.Layers.DAL;
using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.BLL
{
    public class BLLBill
    {
        public static DataTable Read()
        {
            DALBill Data = new DALBill();
            return Data.Read();
        }
        public static DataTable Search(string Value)
        {
            DALBill Data = new DALBill();
            return Data.Search(Value);
        }
        public static string Insert (string UserId, string IdClient, string TypeOfCard, decimal Total_Dollars, decimal Total_Colones, DataTable Details, byte[] Photo, byte[] Signature)
        {
            DALBill Data = new DALBill();
            Bill Obj = new Bill();

            Obj.UserId = UserId;
            Obj.TypeOfCard = TypeOfCard;
            Obj.IdClient = IdClient;
            Obj.Total_Dollars = Total_Dollars;
            Obj.Total_Colones = Total_Colones;
            Obj.Details = Details;
            Obj.Photo = Photo;
            Obj.Signature = Signature;
            return Data.Insert(Obj);
        }


        public static string Cancel (int Id)
        {
            DALBill Data = new DALBill();
            return Data.Cancel(Id);
        }
    }
}
