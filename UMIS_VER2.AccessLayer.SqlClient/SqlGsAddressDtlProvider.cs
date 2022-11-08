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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GsAddressDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlGsAddressDtlProvider: SqlGsAddressDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlGsAddressDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlGsAddressDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAddressDtl entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_GS_ADDRESS_DTL_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@GsAddressDtlId", DbType.Decimal, 10);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, entity.GsCountryNodeId);
            database.AddInParameter(commandWrapper, "@Child1Id", DbType.String, entity.Child1Id);
            database.AddInParameter(commandWrapper, "@Child2Id", DbType.String, entity.Child2Id);
            database.AddInParameter(commandWrapper, "@Child3Id", DbType.String, entity.Child3Id);
            database.AddInParameter(commandWrapper, "@DtlAddAr", DbType.String, entity.DtlAddAr);
            database.AddInParameter(commandWrapper, "@DtlAddEn", DbType.String, entity.DtlAddEn);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Child4Id", DbType.StringFixedLength, entity.Child4Id);

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

            entity.GsAddressDtlId = decimal.Parse(commandWrapper.Parameters["@GsAddressDtlId"].Value.ToString());
            entity.OriginalGsAddressDtlId = entity.GsAddressDtlId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
	}
}