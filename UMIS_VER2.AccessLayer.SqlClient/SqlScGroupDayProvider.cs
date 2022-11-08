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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScGroupDay"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScGroupDayProvider: SqlScGroupDayProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScGroupDayProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScGroupDayProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupDay entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_GROUP_DAY_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@ScGroupDayId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@ScGroupInfoId", DbType.Decimal, entity.ScGroupInfoId);
            database.AddInParameter(commandWrapper, "@ScTchngDayId", DbType.Decimal, entity.ScTchngDayId);
            database.AddInParameter(commandWrapper, "@ScTchngSlotFrmId", DbType.Decimal, (entity.ScTchngSlotFrmId.HasValue ? (object)entity.ScTchngSlotFrmId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScTchngSlotToId", DbType.Decimal, (entity.ScTchngSlotToId.HasValue ? (object)entity.ScTchngSlotToId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, (entity.EdCourseId.HasValue ? (object)entity.EdCourseId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeTchngMthdId", DbType.Decimal, (entity.EdCdeTchngMthdId.HasValue ? (object)entity.EdCdeTchngMthdId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, (entity.ScBuildingId.HasValue ? (object)entity.ScBuildingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, (entity.ScHallId.HasValue ? (object)entity.ScHallId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@CourseTopic", DbType.String, entity.CourseTopic);
            database.AddInParameter(commandWrapper, "@GroupId", DbType.Decimal, (entity.GroupId.HasValue ? (object)entity.GroupId : System.DBNull.Value));

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

            entity.ScGroupDayId = decimal.Parse(commandWrapper.Parameters["@ScGroupDayId"].Value.ToString());
            entity.OriginalScGroupDayId = entity.ScGroupDayId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
	}
}