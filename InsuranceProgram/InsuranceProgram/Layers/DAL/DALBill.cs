using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Interfaces;
using InsuranceProgram.Layers.Persistence;
using System;
using System.Data;
using System.Data.SqlClient;

namespace InsuranceProgram.Layers.DAL
{
    public class DALBill : IDALBill
    {
        public DataTable Read()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_bill", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public DataTable Search(string Value)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("search_bill", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@text", SqlDbType.VarChar).Value = Value;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public string Insert(Bill Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("insert_bill", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.VarChar).Value = Obj.UserId;
                Command.Parameters.Add("@IdClient", SqlDbType.VarChar).Value = Obj.IdClient;
                Command.Parameters.Add("@TypeOfCard", SqlDbType.VarChar).Value = Obj.TypeOfCard;
                Command.Parameters.Add("@Details", SqlDbType.Structured).Value = Obj.Details;
                Command.Parameters.Add("@IdentificationPhoto", SqlDbType.VarBinary).Value = Obj.Photo;
                Command.Parameters.Add("@Total_Dollars", SqlDbType.Money).Value = Obj.Total_Dollars;
                Command.Parameters.Add("@Total_Colones", SqlDbType.Money).Value = Obj.Total_Colones;
                Command.Parameters.Add("@Signature", SqlDbType.VarBinary).Value = Obj.Signature;
                SqlCon.Open();
                Command.ExecuteNonQuery();
                Response = "OK";
            }
            catch (Exception ex)
            {
                Response = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Response;
        }
        public string Cancel(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("bill_deactivate", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue deactivating the Client";
            }
            catch (Exception ex)
            {
                Response = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Response;
        }
    }
}
