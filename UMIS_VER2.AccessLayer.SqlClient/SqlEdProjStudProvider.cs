﻿#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdProjStud"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdProjStudProvider: SqlEdProjStudProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdProjStudProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdProjStudProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.EdProjStud object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdProjStud object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EdProjStud object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProjStud entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_PROJ_STUD_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdProjStudId", DbType.Decimal, entity.EdProjStudId);
            database.AddInParameter(commandWrapper, "@EdProjectId", DbType.Decimal, entity.EdProjectId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);

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


            entity.OriginalEdProjStudId = entity.EdProjStudId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
	}
}