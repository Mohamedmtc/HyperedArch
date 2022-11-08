#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvStaffEvl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvStaffEvlProvider: SqlSvStaffEvlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvStaffEvlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvStaffEvlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
       
        
        public override bool GetStaff_Delete(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal ScStaffEvlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_SV_Staff_EVAL_GetStfEval_Delete", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SvStaffEvalId", DbType.Decimal, ScStaffEvlId);

            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }
        //Marwa 9/1/2022 17644
        public override DataTable GetGeneralEvalution(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGeneralEvalution", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, AcadYearId);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@FacultyID", DbType.Decimal, FacultyID);
            database.AddInParameter(commandWrapper, "@LevelID", DbType.String, LevelID);


            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("SV_STAFF_EVL_ID");
            table.Columns.Add("EVAL_TITLE");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }
        //Marwa 18/1/2022 
        public override DataSet GetGeneralEvalutionDataForPdf(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelId, string SVGeneralEVALID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.RPT_GeneralEvalDyn_New", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, AcadYearId);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@FacultyID", DbType.Decimal, FacultyID);
            database.AddInParameter(commandWrapper, "@LevelId", DbType.String, LevelId);
            database.AddInParameter(commandWrapper, "@SVGeneralEVALID", DbType.String, SVGeneralEVALID);


            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds;

        }
     
        public override DataTable GetSVStaffTemplt(TransactionManager transactionManager, decimal EdEntityID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSvStaffEvlTempltList", this.UseStoredProcedure);
            commandWrapper.CommandType = CommandType.StoredProcedure;
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EdEntityID);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_STAFF_EVL_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("SV_CODE_RATING_SCHM_ID");
            table.Columns.Add("SE_USER_ID");
            table.Columns.Add("EVAL_TITLE");
            table.Columns.Add("ENT_CODE_ENTITY_TYPE_ID");
            table.Columns.Add("ENT_PARENT_ID");
            table.Columns.Add("FacultyAr");
            table.Columns.Add("FacultyEn");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), 
                                           reader[1].ToString(), 
                                           reader[2].ToString(), 
                                           reader[3].ToString(), 
                                           reader[4].ToString(), 
                                           reader[5].ToString(), 
                                           reader[6].ToString(), 
                                           reader[7].ToString(),
                                           reader[8].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), 
                                           reader[1].ToString(), 
                                           reader[2].ToString(), 
                                           reader[3].ToString(), 
                                           reader[4].ToString(), 
                                           reader[5].ToString(), 
                                           reader[6].ToString(), 
                                           reader[7].ToString(),
                                           reader[8].ToString()};
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }

        public override bool StaffEvlTemplt_Delete(TransactionManager transactionManager, decimal ScStaffEvlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_Staff_EVAL_Templt_Delete", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SvStaffEvalId", DbType.Decimal, ScStaffEvlId);

            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }

        public override bool CopyTemplateToStaff(TransactionManager transactionManager, decimal? EntityMainID, decimal SeUserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_STAFF_EVL_COPY_FROM_TEMPLATE", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EntityMainID", DbType.Decimal, EntityMainID);
            database.AddInParameter(commandWrapper, "@SeUserID", DbType.Decimal, SeUserID);

            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
                throw;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }
    }
}