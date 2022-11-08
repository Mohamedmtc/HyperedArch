#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdAcadPlan"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdAcadPlanProvider: SqlEdAcadPlanProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdAcadPlanProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdAcadPlanProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override bool InsertImportedPlan(TransactionManager transactionManager, System.Decimal EDAcadOldPlanId,System.Decimal EdAcadNewPlanId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Batch_Copy_Academic_Plan", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_PLAN_OLD_ID", DbType.Decimal, EDAcadOldPlanId);
            database.AddInParameter(commandWrapper, "@ED_ACAD_PLAN_NEW_ID", DbType.Decimal, EdAcadNewPlanId);
           

            int results = 0;

            //Provider Data Requesting Command Event
          //  OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertImportedPlan", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //object _edAcadPlanId = database.GetParameterValue(commandWrapper, "@EdAcadPlanId");
            //entity.EdAcadPlanId = (System.Decimal)_edAcadPlanId;

            //entity.OriginalEdAcadPlanId = entity.EdAcadPlanId;

            //entity.AcceptChanges();

            //Provider Data Requested Command Event
           // OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        public override bool InsertImportedBylaw(TransactionManager transactionManager, System.Decimal EDAcadOldBylawId, System.Decimal EdAcadNewBylawId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_Batch_Copy_ByLaw", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ByLaw_OLD_ID", DbType.Decimal, EDAcadOldBylawId);
            database.AddInParameter(commandWrapper, "@Bylaw_NEW_ID", DbType.Decimal, EdAcadNewBylawId);


            int results = 0;

            //Provider Data Requesting Command Event
            //  OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertImportedPlan", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //object _edAcadPlanId = database.GetParameterValue(commandWrapper, "@EdAcadPlanId");
            //entity.EdAcadPlanId = (System.Decimal)_edAcadPlanId;

            //entity.OriginalEdAcadPlanId = entity.EdAcadPlanId;

            //entity.AcceptChanges();

            //Provider Data Requested Command Event
            // OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
        public override DataTable Search(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _codeDegreeClassId, System.Decimal _isClosed)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_ACAD_PLAN_Search", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@CodeDegreeClassId", DbType.Decimal, _codeDegreeClassId);
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, _isClosed);

            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("EdAcadPlanId");
            tmp.Columns.Add("AsFacultyInfoId");
            tmp.Columns.Add("EntMainId");
            tmp.Columns.Add("FacultyDescrAr");
            tmp.Columns.Add("FacultyDescrEn");
            tmp.Columns.Add("ClassCode");
            tmp.Columns.Add("MajorDescrAr");
            tmp.Columns.Add("MajorDescrEn");
            tmp.Columns.Add("AcadYearDescrAr");
            tmp.Columns.Add("AcadYearDescrEn");
            tmp.Columns.Add("CurrentFlg");
            tmp.Columns.Add("ClosedFlg");
            tmp.Columns.Add("SEUSERID");
            tmp.Columns.Add("NOTES");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                       reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString()
                                     , reader[12].ToString(), reader[13].ToString()};
                    tmp.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
        }

        public override TList<EdAcadYear> GetAcadYears(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _asCodeDeegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_ACAD_PLAN_GetAcadYears", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@asFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@entMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _asCodeDeegreeClassId);

            IDataReader reader = null;
            TList<EdAcadYear> rows = new TList<EdAcadYear>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAcadYears", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                SqlEdAcadYearProviderBase.Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAcadYears", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdAcadYear> GetAcadYears(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_ACAD_PLAN_GetAcadYears", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@asFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@entMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, DBNull.Value);

            IDataReader reader = null;
            TList<EdAcadYear> rows = new TList<EdAcadYear>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAcadYears", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                SqlEdAcadYearProviderBase.Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAcadYears", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }	
	}
}