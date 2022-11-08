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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntMainMatrix"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntMainMatrixProvider: SqlEntMainMatrixProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntMainMatrixProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntMainMatrixProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region Custom Methods
        public override DataTable SP_ENT_MAIN_MATRIX_S(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _lang, System.Decimal AsCodeDegreeId,decimal EntMainId,decimal EntMajiorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_ENT_MAIN_MATRIX_S", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@asFacultyInfo", DbType.Decimal,_asFacultyInfoId );
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, _lang);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EntMajiorId", DbType.Decimal, EntMajiorId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_MATRIX_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_MAIN_MAJOR_ID");
            table.Columns.Add("ENT_MAIN_MINOR_ID");
            table.Columns.Add("ENT_CODE_ENTITY_TYPE_ID");
            table.Columns.Add("DegreeType");
            table.Columns.Add("MajorName");
            table.Columns.Add("MinorName");
            table.Columns.Add("SpecName");
            table.Columns.Add("GRNTD_DEG_AR");
            table.Columns.Add("GRNTD_DEG_EN");
            table.Columns.Add("DEGREE_DESCR");
          
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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