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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntCoursePkgHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntCoursePkgHdrProvider: SqlEntCoursePkgHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntCoursePkgHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntCoursePkgHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_PKG_HDR_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
            database.AddInParameter(commandWrapper, "@IsOptional", DbType.Decimal, (entity.IsOptional.HasValue ? (object)entity.IsOptional : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, entity.EdBylawId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);

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


            entity.OriginalEntCoursePkgHdrId = entity.EntCoursePkgHdrId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_PKG_HDR_Insert", UseStoredProcedure);

           // database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
           // database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
           // database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
           //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId.HasValue ? (object)entity.EdAcadYearId.Value : DBNull.Value);
           // //database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, entity.EdBylawId);
           // database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
           // database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
           //database.AddInParameter(commandWrapper, "@EntMainRltdId", DbType.Decimal, (entity.EntMainRltdId.HasValue ? (object)entity.EntMainRltdId : System.DBNull.Value));
           // database.AddInParameter(commandWrapper, "@EntCdePkgTypeId", DbType.Decimal, (entity.EntCdePkgTypeId.HasValue ? (object)entity.EntCdePkgTypeId : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (entity.EdAcadYearId.HasValue ? (object)entity.EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@PkgOrdr", DbType.String, entity.PkgOrdr);
            database.AddInParameter(commandWrapper, "@EntCdePkgTypeId", DbType.Decimal, (entity.EntCdePkgTypeId.HasValue ? (object)entity.EntCdePkgTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainRltdId", DbType.Decimal, (entity.EntMainRltdId.HasValue ? (object)entity.EntMainRltdId : System.DBNull.Value));
            //Edit by nashassan 9/10/2016
            database.AddInParameter(commandWrapper, "@EntMainSpcRltdId", DbType.Decimal, (entity.EntMainSpcRltdId.HasValue ? (object)entity.EntMainSpcRltdId : System.DBNull.Value));

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


            entity.OriginalEntCoursePkgHdrId = entity.EntCoursePkgHdrId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        /*
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_PKG_HDR_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@OriginalEntCoursePkgHdrId", DbType.Decimal, entity.OriginalEntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
            database.AddInParameter(commandWrapper, "@IsOptional", DbType.Decimal, (entity.IsOptional.HasValue ? (object)entity.IsOptional : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, entity.EdBylawId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
                EntityManager.StopTracking(entity.EntityTrackingKey);

            entity.OriginalEntCoursePkgHdrId = entity.EntCoursePkgHdrId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_PKG_HDR_Update", UseStoredProcedure);

            //database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            //database.AddInParameter(commandWrapper, "@OriginalEntCoursePkgHdrId", DbType.Decimal, entity.OriginalEntCoursePkgHdrId);
            //database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            //database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
            //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId.HasValue ? (object)entity.EdAcadYearId.Value : DBNull.Value);
            ////database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, entity.EdBylawId);
            //database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            //database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            //database.AddInParameter(commandWrapper, "@EntMainRltdId", DbType.Decimal, (entity.EntMainRltdId.HasValue ? (object)entity.EntMainRltdId : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@EntCdePkgTypeId", DbType.Decimal, (entity.EntCdePkgTypeId.HasValue ? (object)entity.EntCdePkgTypeId : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@OriginalEntCoursePkgHdrId", DbType.Decimal, entity.OriginalEntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (entity.EdAcadYearId.HasValue ? (object)entity.EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MinTotCh", DbType.Decimal, entity.MinTotCh);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@EntCdePkgTypeId", DbType.Decimal, (entity.EntCdePkgTypeId.HasValue ? (object)entity.EntCdePkgTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainRltdId", DbType.Decimal, (entity.EntMainRltdId.HasValue ? (object)entity.EntMainRltdId : System.DBNull.Value));
            //Edit by nashassan 9/10/2016
            database.AddInParameter(commandWrapper, "@EntMainSpcRltdId", DbType.Decimal, (entity.EntMainSpcRltdId.HasValue ? (object)entity.EntMainSpcRltdId : System.DBNull.Value));

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
                EntityManager.StopTracking(entity.EntityTrackingKey);

            entity.OriginalEntCoursePkgHdrId = entity.EntCoursePkgHdrId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        #endregion

        #region Custom Methods

        public override DataTable GetEntityMains(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEntityMainsFromPkgHdr", this.UseStoredProcedure);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("NODE_PATH");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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

        public override TList<EntCoursePkgHdr> GetByParentEntityMain(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_COURSE_PKG_HDR_GetByParentEntMainId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);

            IDataReader reader = null;
            TList<EntCoursePkgHdr> tmp = new TList<EntCoursePkgHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByParentEntityMain", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByParentEntityMain", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }

        public override bool InsertImportedCoursePkg(TransactionManager transactionManager, System.Decimal EntMainFromID, System.Decimal EDACADPLANFromID, System.Decimal EntMainToID, System.Decimal EDACADPLANToID, System.Decimal EntCoursePkgHdrID)
        {
            int results = 0;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.BATCH_COPY_COURSE_PACKAGE", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@Ent_Main_From_ID", DbType.Decimal, EntMainFromID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_PLAN_From_ID", DbType.Decimal, EDACADPLANFromID);
            database.AddInParameter(commandWrapper, "@Ent_Main_To_ID", DbType.Decimal, EntMainToID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_PLAN_To_ID", DbType.Decimal, EDACADPLANToID);
            database.AddInParameter(commandWrapper, "@ENT_COURSE_PKG_HDR_ID", DbType.Decimal, EntCoursePkgHdrID);

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
            return Convert.ToBoolean(results);
        }	


        #endregion
	}
}