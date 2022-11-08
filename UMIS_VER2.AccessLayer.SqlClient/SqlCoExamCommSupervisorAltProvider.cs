#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoExamCommSupervisorAlt"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCoExamCommSupervisorAltProvider: SqlCoExamCommSupervisorAltProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCoExamCommSupervisorAltProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCoExamCommSupervisorAltProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override DataTable SearchCoExamSupAltMembers(TransactionManager transactionManager, System.DateTime? _Date, System.DateTime? _FromTime
            , System.DateTime? _ToTime, System.Decimal? _MemberFlg, System.String _MemberName, System.Decimal _Lang, System.Decimal _coControlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchCoExamSupAltMembers", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Date", DbType.DateTime, _Date);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, _FromTime);
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, _ToTime);
            database.AddInParameter(commandWrapper, "@MemberFlg", DbType.Decimal, _MemberFlg);
            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@MemberName", DbType.String, _MemberName);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CoExamSupAltId");
            table.Columns.Add("CoControlMemberId");
            table.Columns.Add("MemberNameAr");
            table.Columns.Add("MemberNameEn");
            table.Columns.Add("MemberFlg");
            table.Columns.Add("AltDate");
            table.Columns.Add("AltTimeFrom");
            table.Columns.Add("AltTimeTo");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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