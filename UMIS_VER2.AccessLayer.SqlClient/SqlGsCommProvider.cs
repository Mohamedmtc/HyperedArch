#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GsComm"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlGsCommProvider: SqlGsCommProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlGsCommProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlGsCommProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsComm entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GS_COMM_Insert", UseStoredProcedure);


            database.AddOutParameter(commandWrapper, "@GsCommId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@CommDate", DbType.Date, (entity.CommDate.HasValue ? (object)entity.CommDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CommNum", DbType.String, entity.CommNum);
            database.AddInParameter(commandWrapper, "@CommName", DbType.String, entity.CommName);
            database.AddInParameter(commandWrapper, "@CommApprovedBy", DbType.Decimal, (entity.CommApprovedBy.HasValue ? (object)entity.CommApprovedBy : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdSemesterId", DbType.Decimal, (entity.EdSemesterId.HasValue ? (object)entity.EdSemesterId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LawNo", DbType.Decimal, (entity.LawNo.HasValue ? (object)entity.LawNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LawYear", DbType.Decimal, (entity.LawYear.HasValue ? (object)entity.LawYear : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainMajorId", DbType.Decimal, (entity.EntMainMajorId.HasValue ? (object)entity.EntMainMajorId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainMinorId", DbType.Decimal, (entity.EntMainMinorId.HasValue ? (object)entity.EntMainMinorId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCommPurposeId", DbType.Decimal, (entity.GsCommPurposeId.HasValue ? (object)entity.GsCommPurposeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CommOnlineStat", DbType.Decimal, (entity.CommOnlineStat.HasValue ? (object)entity.CommOnlineStat : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DecisionImage", DbType.String, entity.DecisionImage);
            database.AddInParameter(commandWrapper, "@CopyTo", DbType.String, entity.CopyTo);
            database.AddInParameter(commandWrapper, "@CommFolder", DbType.String, entity.CommFolder);
            database.AddInParameter(commandWrapper, "@CommCloseDate", DbType.Date, (entity.CommCloseDate.HasValue ? (object)entity.CommCloseDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CommCloseFlg", DbType.Decimal, entity.CommCloseFlg);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
			
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

            object _gsCommId = database.GetParameterValue(commandWrapper, "@GsCommId");
            entity.GsCommId = (System.Decimal)_gsCommId;

            entity.OriginalGsCommId = entity.GsCommId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
	}
}