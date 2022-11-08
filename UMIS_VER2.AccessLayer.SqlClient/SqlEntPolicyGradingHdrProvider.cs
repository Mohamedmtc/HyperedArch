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
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPolicyGradingHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntPolicyGradingHdrProvider: SqlEntPolicyGradingHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntPolicyGradingHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntPolicyGradingHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_GRADING_HDR_GetByEdCodeGradingTypeId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeGradingTypeId", DbType.Decimal, _edCodeGradingTypeId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            IDataReader reader = null;
            TList<EntPolicyGradingHdr> rows = new TList<EntPolicyGradingHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCodeGradingTypeId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCodeGradingTypeId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }	

        public override TList<EntPolicyGradingHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.POLICY_GRADING_HDR_GET_BYCOURSE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edcourseid);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, _entcoursepkghdrId);


            IDataReader reader = null;
            TList<EntPolicyGradingHdr> rows = new TList<EntPolicyGradingHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFORCOURSEId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetFORCOURSEId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.PolicyGrading_byStudSem_Course", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _edstudsemesterid);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edcourseid);



            IDataReader reader = null;
            TList<EntPolicyGradingHdr> rows = new TList<EntPolicyGradingHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Get_byStudeSemester_Course", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Get_byStudeSemester_Course", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntPolicyGradingHdr> GetStudPolicies(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.Decimal _edCodeGradingTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudPolicies", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EdCodeSemId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingTypeId", DbType.Decimal, _edCodeGradingTypeId);


            IDataReader reader = null;
            TList<EntPolicyGradingHdr> rows = new TList<EntPolicyGradingHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudPolicies", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudPolicies", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

    

        public override string CheckRatingLimits(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _EdBylawId, System.Decimal _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_RATING_LIMITS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, _entPolicyGradingHdrId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@ED_BYLAW_ID", DbType.Decimal, _EdBylawId);

            string msg = "";

            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                }
            }
            catch (Exception ex)
            {
                msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }

            return msg;
        }

        public override DataTable GetEntityMains(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEntityMainsFromPloicyGradingHdr", this.UseStoredProcedure);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_BYLAW_ID");
         

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        #endregion

	}
}