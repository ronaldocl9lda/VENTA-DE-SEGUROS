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
    public class DALPlanCoverage
    {
        public string Insert(int PlanId, int CoverageId)
        {
            string Response = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("usp_INSERT_PlanCoverage", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@PlanId", SqlDbType.Int).Value = PlanId;
                Command.Parameters.Add("@CoverageId", SqlDbType.Int).Value = CoverageId;
                SqlCon.Open();
                Response = Command.ExecuteNonQuery() == 1 ? "OK" : "There was an issue inserting the PlanCoverage";
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
        public DataTable Read(int PlanId)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_PlanCoverages", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@PlanId", SqlDbType.Int).Value = PlanId;
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
    }
}
