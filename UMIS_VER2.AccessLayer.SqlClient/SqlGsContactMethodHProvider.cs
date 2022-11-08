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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GsContactMethodH"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlGsContactMethodHProvider: SqlGsContactMethodHProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlGsContactMethodHProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlGsContactMethodHProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override decimal InsertWithIdOut(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsContactMethodH entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GsContactMethodHInsertIdOut", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@GsContactMethodHId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@HeaderDescrAr", DbType.String, entity.HeaderDescrAr);
            database.AddInParameter(commandWrapper, "@HeaderDescrEn", DbType.String, entity.HeaderDescrEn);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalGsContactMethodHId = entity.GsContactMethodHId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@GsContactMethodHId"].Value);
        }
        #endregion
    }
}