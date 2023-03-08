using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Interfaces;
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
    public class DALClient : IDALClient
    {
        public string Activate(string Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("activate_client", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "We can't activate the Client";
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

        public string Deactivate(string Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("desactivate_client", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
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

        public string Delete(string Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("delete_client", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "It was impossible deleting the Client";
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
                SqlCommand Comando = new SqlCommand("exist_client", SqlCon);
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

        public string Insert(Client Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("client_insert", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Obj.Identification;
                Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = Obj.FistName;
                Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = Obj.LastName;
                Command.Parameters.Add("@Nationality", SqlDbType.Int).Value = Obj.Nationality;
                Command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Obj.Gender;
                Command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Obj.DateOfBirth;
                Command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = Obj.PhoneNumber;
                Command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = Obj.Photo;
                Command.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Obj.Address;
                Command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Obj.Email;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the Client";
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

        public DataTable Read()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_clients", SqlCon);
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
                SqlCommand Command = new SqlCommand("search_client", SqlCon);
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

        public string Update(Client Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("update_client", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Identification", SqlDbType.VarChar).Value = Obj.Identification;
                Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = Obj.FistName;
                Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = Obj.LastName;
                Command.Parameters.Add("@Nationality", SqlDbType.Int).Value = Obj.Nationality;
                Command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Obj.Gender;
                Command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Obj.DateOfBirth;
                Command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = Obj.PhoneNumber;
                Command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = Obj.Photo;
                Command.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Obj.Address;
                Command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Obj.Email;
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
    }
}
