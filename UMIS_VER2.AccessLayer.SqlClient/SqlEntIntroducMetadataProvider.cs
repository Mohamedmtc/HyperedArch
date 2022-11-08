#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntIntroducMetadata"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntIntroducMetadataProvider: SqlEntIntroducMetadataProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntIntroducMetadataProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntIntroducMetadataProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMetadata entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_INTRODUC_METADATA_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCodeIntroMdId", DbType.Decimal, entity.EntCodeIntroMdId);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@EntIntroducMdId", DbType.Decimal, entity.EntIntroducMdId);
            database.AddInParameter(commandWrapper, "@ObligFlg", DbType.Decimal, (entity.ObligFlg.HasValue ? (object)entity.ObligFlg : System.DBNull.Value));

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


            entity.OriginalEntIntroducMdId = entity.EntIntroducMdId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion
    }
}