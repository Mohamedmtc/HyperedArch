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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdGuard"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdGuardProvider: SqlEdGuardProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdGuardProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdGuardProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable SearchGuard(TransactionManager transactionManager, System.String _FullNameAr,System.String _FullNameEn,
                System.String _JobTitle, System.String _Email, System.String _CPR, System.String _MobileNum,
                System.String _PhoneNum, System.Decimal _StaffFlg, System.Decimal _CountryNodeId,System.Decimal _PageIndex,System.Decimal _PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Search_Guard", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, _FullNameEn);
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, _FullNameAr);
            database.AddInParameter(commandWrapper, "@JobTitle", DbType.String, _JobTitle);
            database.AddInParameter(commandWrapper, "@PhoneNum", DbType.String, _PhoneNum);
            database.AddInParameter(commandWrapper, "@MobileNum", DbType.String, _MobileNum);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, _CPR);
            database.AddInParameter(commandWrapper, "@Email", DbType.String, _Email);
            database.AddInParameter(commandWrapper, "@StaffFlg", DbType.Decimal, _StaffFlg);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, _CountryNodeId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _PageSize);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("EdGuardId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("JobTitle");
            table.Columns.Add("CPR");
            table.Columns.Add("PassportNo");
            table.Columns.Add("RowsTotCount");
           
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),reader[7].ToString()};
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

        public override DataTable SearchExistingGuard(TransactionManager transactionManager, System.String _StudentCPR, System.String _StudentCode,
                     System.String _GuardCPR)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Search_Existing_Guard", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@GuardCPR", DbType.String, _GuardCPR);
            database.AddInParameter(commandWrapper, "@StudCPR", DbType.String, _StudentCPR);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, _StudentCode);
           
            IDataReader reader = null;
            DataTable table = new DataTable();
           
            table.Columns.Add("EdGuardId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("JobTitle");
            table.Columns.Add("CPR");
            table.Columns.Add("Passport");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString(), reader[5].ToString() };
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
      
    
    }
}