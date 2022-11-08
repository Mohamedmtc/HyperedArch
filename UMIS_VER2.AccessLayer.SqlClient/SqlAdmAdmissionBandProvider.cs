#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAdmissionBand"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAdmissionBandProvider: SqlAdmAdmissionBandProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAdmissionBandProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAdmissionBandProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable GetAdmissionBands(TransactionManager transactionManager, decimal admOpenAcadSemId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmissionBands", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemId", DbType.Decimal, admOpenAcadSemId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_ADMISSION_BAND_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ADM_OPEN_ACAD_SEMESTER_ID");
            table.Columns.Add("ADM_RATING_PARAMETERS_ID");
            table.Columns.Add("REQUIRED_NUMBERS");
            table.Columns.Add("CURRENT_NUMBERS");
            table.Columns.Add("ACCEPTED_NUMBERS");

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
                    object[] items = { 
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                         reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString()
                                     };
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

        #endregion
	}
}