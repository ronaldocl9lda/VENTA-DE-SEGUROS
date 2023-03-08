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
    public class DALPolicy : IDALPolicy
    {
        public string Activate(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("activate_policy", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Code", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "We can't activate the Policy";
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
                SqlCommand Command = new SqlCommand("desactivate_policy", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Code", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue deactivating the Policy";
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
                SqlCommand Command = new SqlCommand("delete_policy", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Code", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "It was impossible deleting the Policy";
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

        public string Exist(int Value)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Comando = new SqlCommand("exist_policy", SqlCon);
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

        public string Insert(Policy Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("insert_policy", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Code", SqlDbType.Int).Value = Obj.Code;
                Command.Parameters.Add("@Description", SqlDbType.VarChar).Value = Obj.Description;
                Command.Parameters.Add("@PlanId", SqlDbType.Int).Value = Obj.PlanId;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the Policy";
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
                SqlCommand Command = new SqlCommand("list_policy", SqlCon);
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
        public DataTable Read(int Code)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_policy_coverage_to_sell", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@PolicyCode", SqlDbType.Int).Value = Code;
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
        public string Update(Policy Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("update_policy", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Code", SqlDbType.Int).Value = Obj.Code;
                Command.Parameters.Add("@Description", SqlDbType.VarChar).Value = Obj.Description;
                Command.Parameters.Add("@PlanId", SqlDbType.Int).Value = Obj.PlanId;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue updating the Policy";
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
