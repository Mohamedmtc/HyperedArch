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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoExamSchdlPlace"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCoExamSchdlPlaceProvider: SqlCoExamSchdlPlaceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCoExamSchdlPlaceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCoExamSchdlPlaceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetAllStudExamPlaces(TransactionManager transactionManager, decimal CoExamSchdlPlaceId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudExamPlace", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@CoExamSchdlPlaceId", DbType.Decimal, CoExamSchdlPlaceId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("StudCode");
            table.Columns.Add("IsCourseApproved");
            table.Columns.Add("EdStudSemesterId");
            table.Columns.Add("CoExamPlaceStudId");
            table.Columns.Add("STUD_SEAT_NUM");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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