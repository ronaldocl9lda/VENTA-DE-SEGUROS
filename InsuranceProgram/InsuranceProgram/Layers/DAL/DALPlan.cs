﻿using InsuranceProgram.Layers.Interfaces;
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
    public class DALPlan : IDALPlan
    {
        public DataTable Read()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstancia().CreateConnection();
                SqlCommand Command = new SqlCommand("list_plan", SqlCon);
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
    }
}
