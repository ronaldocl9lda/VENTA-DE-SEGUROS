using InsuranceProgram.Layers.Entities;
using InsuranceProgram.Layers.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram.Layers.Interfaces
{
    public class DALUser : IDALUser
    {
        public DataTable Read()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_users", SqlCon);
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
                SqlCommand Command = new SqlCommand("search_user", SqlCon);
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
        public DataTable Login(string UserId, string Password)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("login_user", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.VarChar).Value = UserId;
                Command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public string Exist(string Value)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Comando = new SqlCommand("exist_user", SqlCon);
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
        public string Insert(User Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("user_insert", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.Int).Value = Obj.ID;
                Command.Parameters.Add("@RoleId", SqlDbType.Int).Value = Obj.RoleId;
                Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Obj.Name;
                Command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Obj.Password;
                Command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = Obj.Photo;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the user";
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

        public string Update(User Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("update_user", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.Int).Value = Obj.ID;
                Command.Parameters.Add("@RoleId", SqlDbType.Int).Value = Obj.RoleId;
                Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Obj.Name;
                Command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Obj.Password;
                Command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = Obj.Photo;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue updating the user";
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

        public string Delete(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("delete_user", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "It was impossible deleting the User";
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

        public string Activate(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("activate_user", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
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

        public string Deactivate(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("desactivate_user", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@UserId", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue deactivating the user";
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
