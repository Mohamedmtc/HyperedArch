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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeAllowanceRule"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeAllowanceRuleProvider: SqlFeeAllowanceRuleProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeAllowanceRuleProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeAllowanceRuleProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region Custom Methods
        //added by manar abdelhafez task 13024 CSS
        public override DataTable GetFeeAllowance(int GenderID, int HosingFlg, int AdmCodType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SrchFee_AllowanceRule", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@GenderId", DbType.Int32, GenderID);
            database.AddInParameter(commandWrapper, "@HosingFlg", DbType.Int32, HosingFlg);
            database.AddInParameter(commandWrapper, "@admCdeType", DbType.Int32, AdmCodType);
            IDataReader reader = null;
            DataTable LstFee = new DataTable();
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                LstFee.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }

            return LstFee;
        }
        //end 
        #endregion  
    }
}