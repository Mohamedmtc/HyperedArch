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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudAllowance"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeStudAllowanceProvider: SqlFeeStudAllowanceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeStudAllowanceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeStudAllowanceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        // kamela 
        public override DataTable GetStudentsAllowanceData(TransactionManager transactionManager, string StudCode, decimal DeptId, decimal typeId,
                                                    decimal degrreClassId, decimal acadYearId, decimal MonthId,
                                                    decimal schoolId, decimal sponsorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsAllowanceData", this.UseStoredProcedure);
           

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@DeptId", DbType.Decimal, DeptId);
            database.AddInParameter(commandWrapper, "@typeId", DbType.Decimal, typeId);
            database.AddInParameter(commandWrapper, "@degrreClassId", DbType.Decimal, degrreClassId);

            database.AddInParameter(commandWrapper, "@acadYearId", DbType.Decimal, acadYearId);
            database.AddInParameter(commandWrapper, "@MonthId", DbType.Decimal, MonthId);
            database.AddInParameter(commandWrapper, "@schoolId", DbType.Decimal, schoolId);
            database.AddInParameter(commandWrapper, "@sponsorId", DbType.Decimal, sponsorId);
            IDataReader reader = null;

            //Create Collection

            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("Year_EN");
            table.Columns.Add("Year_AR");
            table.Columns.Add("FEE_STUD_ALLOWANCE_ID");
            table.Columns.Add("MONTH_ID");
            table.Columns.Add("AMOUNT");
            table.Columns.Add("NOTES");
            table.Columns.Add("MonthNameEn");

            table.Columns.Add("ENT_PARENT_ID");
            table.Columns.Add("DeptID");
            table.Columns.Add("Dept_EN");
            table.Columns.Add("Dept_AR");
            table.Columns.Add("PAY_FLG");

            

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), 
                                         reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                         reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),
                                          reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                         reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                         reader[15].ToString(),reader[16].ToString()};
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