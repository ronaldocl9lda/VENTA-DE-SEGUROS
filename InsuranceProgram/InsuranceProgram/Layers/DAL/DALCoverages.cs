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
    public class DALCoverages : IDALCoverage
    {
        public string Delete(int Id)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("delete_Coverage", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@CoverageId", SqlDbType.Int).Value = Id;
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

        public string Exist(int Value)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Comando = new SqlCommand("exist_coverage", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@PlanId", SqlDbType.VarChar).Value = Value.ToString();
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

        public string Insert(Coverage Obj)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("insert_coverage", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ID", SqlDbType.Int).Value = Obj.ID;
                Command.Parameters.Add("@MaxAmount", SqlDbType.Money).Value = Obj.MaxAmount;
                Command.Parameters.Add("@EventsPerYear", SqlDbType.Int).Value = Obj.EventsPerYear;
                Command.Parameters.Add("@GracePeriod", SqlDbType.Int).Value = Obj.GracePeriod;
                Command.Parameters.Add("@SumAssured", SqlDbType.Money).Value = Obj.SumAssured;
                Command.Parameters.Add("@Prima", SqlDbType.Money).Value = Obj.Prima;
                Command.Parameters.Add("@Description", SqlDbType.VarChar).Value = Obj.Description;
                Command.Parameters.Add("@Total", SqlDbType.Money).Value = Obj.Total;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the Coverage";
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
                SqlCommand Command = new SqlCommand("activate_coverage", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "We can't activate the Coverage";
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
                SqlCommand Command = new SqlCommand("desactivate_coverage", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue deactivating the Coverage";
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

        public string Update(Coverage Obj)
        {
            throw new NotImplementedException();
        }

        string IDALCoverage.Read(int PlanId)
        {
            throw new NotImplementedException();
        }
    }
}
