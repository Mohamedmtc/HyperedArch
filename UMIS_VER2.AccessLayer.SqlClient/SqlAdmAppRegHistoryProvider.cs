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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppRegHistory"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppRegHistoryProvider: SqlAdmAppRegHistoryProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppRegHistoryProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppRegHistoryProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

       

        public override DataTable GetOrientaionLists(TransactionManager transactionManager,
          decimal OpenAcadSemesterId, decimal OrintationFlg,
          decimal OverAllAcceptanceFlg, decimal CurrentFlg,
          decimal AdmCdeAppTypeId, string ApplicantCode,
          decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetOrientaionLists", this.UseStoredProcedure);
         
            database.AddInParameter(commandWrapper, "@OpenAcadSemesterId", DbType.Decimal, OpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@OrintationFlg", DbType.Decimal, OrintationFlg);
            database.AddInParameter(commandWrapper, "@OverAllAcceptanceFlg", DbType.Decimal, OverAllAcceptanceFlg);
            database.AddInParameter(commandWrapper, "@CurrentFlg", DbType.Decimal, CurrentFlg);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, AdmCdeAppTypeId);
            database.AddInParameter(commandWrapper, "@ADM_APP_CODE", DbType.String, ApplicantCode);
           
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("ORINTATION_FLG");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("CPR");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString()};
                    table.Rows.Add(items);
                }
            }

            finally
            {
                commandWrapper = null;
            }

            return table;
        }

    
   
        #endregion
    
    }
}