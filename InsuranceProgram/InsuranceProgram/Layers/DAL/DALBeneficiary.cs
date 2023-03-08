using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.DAL
{
    public class DALBeneficiary
    {
        public string Delete(string Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("delete_beneficiary", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "It was impossible deleting the Beneficiary";
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
        public string DeleteAll(string Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("delete_all_beneficiaries", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@IDClient", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "It was impossible deleting the beneficiaries";
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

        public string Insert(Beneficiary Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("beneficiary_insert", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Obj.Identification;
                Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = Obj.FistName;
                Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = Obj.LastName;
                Command.Parameters.Add("@IDClient", SqlDbType.VarChar).Value = Obj.IDClient;
                Command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = Obj.DateOfBirth;
                Command.Parameters.Add("@Relationship", SqlDbType.VarChar).Value = Obj.Relationship;
                Command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = Obj.PhoneNumber;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the Beneficiary";
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

        public DataTable Read(string Id)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_beneficiaries", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@IDClient", SqlDbType.VarChar).Value = Id;
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

        public string Update(Beneficiary Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("update_beneficiary", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Obj.Identification;
                Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = Obj.FistName;
                Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = Obj.LastName;
                Command.Parameters.Add("@IDClient", SqlDbType.VarChar).Value = Obj.LastName;
                Command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Obj.DateOfBirth;
                Command.Parameters.Add("@Relationship", SqlDbType.VarChar).Value = Obj.Relationship;
                Command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = Obj.PhoneNumber;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue updating the Client";
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

        public string Exist(string Value)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Comando = new SqlCommand("exist_beneficiary", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Text_Id", SqlDbType.VarChar).Value = Value.ToString();
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@exist";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Response = Convert.ToString(ParExiste.Value);
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
