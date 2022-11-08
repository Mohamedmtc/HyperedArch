#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmOpenAcadSemester"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmOpenAcadSemesterProvider: SqlAdmOpenAcadSemesterProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmOpenAcadSemesterProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmOpenAcadSemesterProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
       #region Custom Methods

        public override List<EdAcadYear> GetNextAcadYears_Lookup(TransactionManager transactionManager, System.Decimal _edAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_OPEN_ACAD_SEMESTER_GetNextAcadYears_ForDrp", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);

            IDataReader reader = null;

            var list = new List<EdAcadYear>();

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
                    var entity=new EdAcadYear
                        {
                            EdAcadYearId =(decimal) reader[0],
                            DescrAr = reader[1].ToString(),
                            DescrEn=reader[2].ToString()
                        };

                   // object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                    list.Add(entity);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return list;
        }

	    public override List<EdCodeSemester> GetNextSemesters_Lookup(TransactionManager transactionManager, decimal _edCodeSemesterId)
	    {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_OPEN_ACAD_SEMESTER_GetNextSemesters_ForDrp", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
	        var list = new List<EdCodeSemester>();
           

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
                    var entity = new EdCodeSemester
                        {
                            EdCodeSemesterId=(decimal)reader[0],
                            DescrAr=reader[1].ToString(),
                            DescrEn = reader[2].ToString()
                        };
                    list.Add(entity);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return list;
	    }


	    public override DataTable GetNextAcadYears_ForDrp(TransactionManager transactionManager, System.Decimal _edAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_OPEN_ACAD_SEMESTER_GetNextAcadYears_ForDrp", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);

            IDataReader reader = null;

            DataTable table = new DataTable();
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetNextSemesters_ForDrp(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_OPEN_ACAD_SEMESTER_GetNextSemesters_ForDrp", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;

            DataTable table = new DataTable();
            table.Columns.Add("EdCodeSemesterId");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetAdmStatistics(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, decimal CompFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmStatistics", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@admOpenAcadSemesterId", DbType.Decimal, _admOpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@CompFlg", DbType.Decimal, CompFlg);


            IDataReader reader = null;

            DataTable table = new DataTable();
            table.Columns.Add("AllApps");
            table.Columns.Add("AppliedAcceptanceCriteriaApps");
            table.Columns.Add("NewApps");
            table.Columns.Add("CompletedApps");            
            table.Columns.Add("UnderReviewApps");
            table.Columns.Add("RejectedApps");
            table.Columns.Add("AcceptedApps");
            table.Columns.Add("CompatativeRateApps");
            table.Columns.Add("DistributedApps");
            table.Columns.Add("EnrolledApps");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        /// <summary>
        /// Get All Academic Years For Adm
        /// </summary>
        public override TList<EdAcadYear> GetAdmAcadYears(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmAcadYears", UseStoredProcedure);

            IDataReader reader = null;

            //Create Collection
            TList<EdAcadYear> rows = new TList<EdAcadYear>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAdmAcadYears", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                EdAcadYearProviderBaseCore.Fill(reader, rows, 0, int.MaxValue);
                
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAdmAcadYears", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        /// <summary>
        /// Get All Semesters opened for Academic Years In Adm
        /// </summary>
        public override TList<EdCodeSemester> GetAdmCodeSemestersForAcadYear(TransactionManager transactionManager, decimal _edAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmCodeSemestersForAcadYear", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);

            IDataReader reader = null;

            //Create Collection
            TList<EdCodeSemester> rows = new TList<EdCodeSemester>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAdmCodeSemestersForAcadYear", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                EdCodeSemesterProviderBaseCore.Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAdmCodeSemestersForAcadYear", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

		#endregion
	}
}