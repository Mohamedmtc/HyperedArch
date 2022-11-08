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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntityMain"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntityMainProvider: SqlEntityMainProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntityMainProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntityMainProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, entity.EntDescrAr);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, entity.StateNotation);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, (entity.EntParentId.HasValue ? (object)entity.EntParentId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, entity.EntDescrEn);
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, (entity.EdBylawId.HasValue ? (object)entity.EdBylawId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, (entity.IsStateFlg.HasValue ? (object)entity.IsStateFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeChildCount", DbType.Decimal, (entity.NodeChildCount.HasValue ? (object)entity.NodeChildCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, entity.NodePath);
            database.AddInParameter(commandWrapper, "@NodeOrder", DbType.Decimal, (entity.NodeOrder.HasValue ? (object)entity.NodeOrder : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeLevel", DbType.Decimal, (entity.NodeLevel.HasValue ? (object)entity.NodeLevel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudyMethodId", DbType.Decimal, (entity.EdStudyMethodId.HasValue ? (object)entity.EdStudyMethodId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, (entity.IsInfoFlg.HasValue ? (object)entity.IsInfoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, (entity.IsHomeFlg.HasValue ? (object)entity.IsHomeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StateDescrAr", DbType.String, entity.StateDescrAr);
            database.AddInParameter(commandWrapper, "@StateDescrEn", DbType.String, entity.StateDescrEn);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, (entity.EdCodeLevelId.HasValue ? (object)entity.EdCodeLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, (entity.AsCodeDegreeClassId.HasValue ? (object)entity.AsCodeDegreeClassId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsVisible", DbType.Decimal, entity.IsVisible);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);

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


            entity.OriginalEntMainId = entity.EntMainId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, entity.EntDescrAr);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, entity.StateNotation);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, (entity.EntParentId.HasValue ? (object)entity.EntParentId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, entity.EntDescrEn);
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, (entity.IsStateFlg.HasValue ? (object)entity.IsStateFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeChildCount", DbType.Decimal, (entity.NodeChildCount.HasValue ? (object)entity.NodeChildCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, entity.NodePath);
            database.AddInParameter(commandWrapper, "@NodeOrder", DbType.Decimal, (entity.NodeOrder.HasValue ? (object)entity.NodeOrder : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeLevel", DbType.Decimal, (entity.NodeLevel.HasValue ? (object)entity.NodeLevel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudyMethodId", DbType.Decimal, (entity.EdStudyMethodId.HasValue ? (object)entity.EdStudyMethodId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, (entity.IsInfoFlg.HasValue ? (object)entity.IsInfoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, (entity.IsHomeFlg.HasValue ? (object)entity.IsHomeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StateDescrAr", DbType.String, entity.StateDescrAr);
            database.AddInParameter(commandWrapper, "@StateDescrEn", DbType.String, entity.StateDescrEn);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, (entity.EdCodeLevelId.HasValue ? (object)entity.EdCodeLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsVisible", DbType.Decimal, entity.IsVisible);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, (entity.AsCodeDegreeId.HasValue ? (object)entity.AsCodeDegreeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, (entity.ApproveFlg.HasValue ? (object)entity.ApproveFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoadWithTrain", DbType.Decimal, (entity.LoadWithTrain.HasValue ? (object)entity.LoadWithTrain : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeSpecAreaId", DbType.Decimal, (entity.GsCdeSpecAreaId.HasValue ? (object)entity.GsCdeSpecAreaId : System.DBNull.Value));

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


            entity.OriginalEntMainId = entity.EntMainId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
        /*
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@OriginalEntMainId", DbType.Decimal, entity.OriginalEntMainId);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, entity.EntDescrAr);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, entity.StateNotation);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, (entity.EntParentId.HasValue ? (object)entity.EntParentId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, entity.EntDescrEn);
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, (entity.EdBylawId.HasValue ? (object)entity.EdBylawId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, (entity.IsStateFlg.HasValue ? (object)entity.IsStateFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeChildCount", DbType.Decimal, (entity.NodeChildCount.HasValue ? (object)entity.NodeChildCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, entity.NodePath);
            database.AddInParameter(commandWrapper, "@NodeOrder", DbType.Decimal, (entity.NodeOrder.HasValue ? (object)entity.NodeOrder : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeLevel", DbType.Decimal, (entity.NodeLevel.HasValue ? (object)entity.NodeLevel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudyMethodId", DbType.Decimal, (entity.EdStudyMethodId.HasValue ? (object)entity.EdStudyMethodId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, (entity.IsInfoFlg.HasValue ? (object)entity.IsInfoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, (entity.IsHomeFlg.HasValue ? (object)entity.IsHomeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StateDescrAr", DbType.String, entity.StateDescrAr);
            database.AddInParameter(commandWrapper, "@StateDescrEn", DbType.String, entity.StateDescrEn);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, (entity.EdCodeLevelId.HasValue ? (object)entity.EdCodeLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, (entity.AsCodeDegreeClassId.HasValue ? (object)entity.AsCodeDegreeClassId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsVisible", DbType.Decimal, entity.IsVisible);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);

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

            entity.OriginalEntMainId = entity.EntMainId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@OriginalEntMainId", DbType.Decimal, entity.OriginalEntMainId);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, entity.EntDescrAr);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, entity.StateNotation);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, (entity.EntParentId.HasValue ? (object)entity.EntParentId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, entity.EntDescrEn);
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, (entity.IsStateFlg.HasValue ? (object)entity.IsStateFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeChildCount", DbType.Decimal, (entity.NodeChildCount.HasValue ? (object)entity.NodeChildCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, entity.NodePath);
            database.AddInParameter(commandWrapper, "@NodeOrder", DbType.Decimal, (entity.NodeOrder.HasValue ? (object)entity.NodeOrder : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NodeLevel", DbType.Decimal, (entity.NodeLevel.HasValue ? (object)entity.NodeLevel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudyMethodId", DbType.Decimal, (entity.EdStudyMethodId.HasValue ? (object)entity.EdStudyMethodId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, (entity.IsInfoFlg.HasValue ? (object)entity.IsInfoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, (entity.IsHomeFlg.HasValue ? (object)entity.IsHomeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StateDescrAr", DbType.String, entity.StateDescrAr);
            database.AddInParameter(commandWrapper, "@StateDescrEn", DbType.String, entity.StateDescrEn);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, (entity.EdCodeLevelId.HasValue ? (object)entity.EdCodeLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsVisible", DbType.Decimal, entity.IsVisible);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, (entity.AsCodeDegreeId.HasValue ? (object)entity.AsCodeDegreeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, (entity.ApproveFlg.HasValue ? (object)entity.ApproveFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoadWithTrain", DbType.Decimal, (entity.LoadWithTrain.HasValue ? (object)entity.LoadWithTrain : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeSpecAreaId", DbType.Decimal, (entity.GsCdeSpecAreaId.HasValue ? (object)entity.GsCdeSpecAreaId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GSCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmShowFlg", DbType.Boolean, (entity.AdmShowFlg.HasValue ? (object)entity.AdmShowFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MaxTrnsCh", DbType.Int32, (entity.MaxTrnsCh.HasValue ? (object)entity.MaxTrnsCh : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DegEquvText", DbType.String, entity.DegEquvText);
            database.AddInParameter(commandWrapper, "@DegEquvTextEng", DbType.String, entity.DegEquvTextEng);
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.String, entity.GsCodeLanguageId);
            database.AddInParameter(commandWrapper, "@ScheduleTypeFlg", DbType.Decimal, (entity.ScheduleTypeFlg.HasValue ? (object)entity.ScheduleTypeFlg : System.DBNull.Value));
            

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

            entity.OriginalEntMainId = entity.EntMainId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        public override bool Delete(TransactionManager transactionManager, System.Decimal _entMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;

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
            {
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain)
                    , _entMainId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }
        
        public override TList<EntityMain> GetByEntParentId(TransactionManager transactionManager, System.Decimal? _entParentId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENTITY_MAIN_GetByEntParentId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, _entParentId);

            IDataReader reader = null;
            TList<EntityMain> tmp = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntParentId", tmp));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntParentId", tmp));
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
        

        #endregion


        #region Custom Methods

        public override TList<EntityMain> AdvancedFind(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
        {
            count = -1;
            if (whereClause.IndexOf(";") > -1)
                return new TList<EntityMain>();

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENTITY_MAIN_Advanced_Find", this.UseStoredProcedure);

            bool searchUsingOR = false;
            if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
                searchUsingOR = true;

            database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@NodeChildCount", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@NodeOrder", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@NodeLevel", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdStudyMethodId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, DBNull.Value);
          //  database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@ascodedegreeid", DbType.Decimal, DBNull.Value);

            // replace all instances of 'AND' and 'OR' because we already set searchUsingOR
            whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|");
            string[] clauses = whereClause.ToLower().Split('|');

            // Here's what's going on below: Find a field, then to get the value we
            // drop the field name from the front, trim spaces, drop the '=' sign,
            // trim more spaces, and drop any outer single quotes.
            // Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"

            char[] equalSign = { '=' };
            char[] singleQuote = { '\'' };
            foreach (string clause in clauses)
            {
                if (clause.Trim().StartsWith("ent_main_id ") || clause.Trim().StartsWith("ent_main_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EntMainId",
                        clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ent_descr_ar ") || clause.Trim().StartsWith("ent_descr_ar="))
                {
                    database.SetParameterValue(commandWrapper, "@EntDescrAr",
                        clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ent_code_entity_type_id ") || clause.Trim().StartsWith("ent_code_entity_type_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EntCodeEntityTypeId",
                        clause.Trim().Remove(0, 23).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("state_notation ") || clause.Trim().StartsWith("state_notation="))
                {
                    database.SetParameterValue(commandWrapper, "@StateNotation",
                        clause.Trim().Remove(0, 14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ent_parent_id ") || clause.Trim().StartsWith("ent_parent_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EntParentId",
                        clause.Trim().Remove(0, 13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("as_code_degree_id ") || clause.Trim().StartsWith("as_code_degree_id="))
                {
                    database.SetParameterValue(commandWrapper, "@ascodedegreeid",
                        clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ent_descr_en ") || clause.Trim().StartsWith("ent_descr_en="))
                {
                    database.SetParameterValue(commandWrapper, "@EntDescrEn",
                        clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ed_bylaw_id ") || clause.Trim().StartsWith("ed_bylaw_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EdBylawId",
                        clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("is_state_flg ") || clause.Trim().StartsWith("is_state_flg="))
                {
                    database.SetParameterValue(commandWrapper, "@IsStateFlg",
                        clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("node_child_count ") || clause.Trim().StartsWith("node_child_count="))
                {
                    database.SetParameterValue(commandWrapper, "@NodeChildCount",
                        clause.Trim().Remove(0, 16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("node_path ") || clause.Trim().StartsWith("node_path="))
                {
                    database.SetParameterValue(commandWrapper, "@NodePath",
                        clause.Trim().Remove(0, 9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("node_order ") || clause.Trim().StartsWith("node_order="))
                {
                    database.SetParameterValue(commandWrapper, "@NodeOrder",
                        clause.Trim().Remove(0, 10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("node_level ") || clause.Trim().StartsWith("node_level="))
                {
                    database.SetParameterValue(commandWrapper, "@NodeLevel",
                        clause.Trim().Remove(0, 10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ed_study_method_id ") || clause.Trim().StartsWith("ed_study_method_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EdStudyMethodId",
                        clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("as_faculty_info_id ") || clause.Trim().StartsWith("as_faculty_info_id="))
                {
                    database.SetParameterValue(commandWrapper, "@AsFacultyInfoId",
                        clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }

                //if (clause.Trim().StartsWith("is_info_flg ") || clause.Trim().StartsWith("is_info_flg="))
                //{
                //    database.SetParameterValue(commandWrapper, "@IsInfoFlg",
                //        clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                //    continue;
                //}

               
                if (clause.Trim().StartsWith("is_home_flg ") || clause.Trim().StartsWith("is_home_flg="))
                {
                    database.SetParameterValue(commandWrapper, "@IsHomeFlg",
                        clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
            }

            IDataReader reader = null;
            //Create Collection
            TList<EntityMain> rows = new TList<EntityMain>();


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, start, pageLength);

                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetEntityChilds(TransactionManager transactionManager, System.Decimal EntCodeTypeID, System.Decimal AsFacultyInfoID, System.Decimal EntMainID, System.Decimal AsCodeDegClassID, System.Decimal AsCodeDegreeID, System.Decimal DrctChldFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetEntityChilds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCodeTypeID", DbType.Decimal, EntCodeTypeID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@AsCodeDegClassID", DbType.Decimal, AsCodeDegClassID);
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, EntMainID);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, AsCodeDegreeID);
            database.AddInParameter(commandWrapper, "@DrctChldFlg", DbType.Decimal, DrctChldFlg);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetEntityChilds", rows));
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetEntityChilds", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetMinors(TransactionManager transactionManager, System.Decimal _EntMainID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetMinorsRltdMajor", this.UseStoredProcedure);
           
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, _EntMainID);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMinors", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
               
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetMinors", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetByNodePathAndEntityType(TransactionManager transactionManager, System.String _NodePath, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENTITY_MAIN_GetByNodePathAndEntType", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, _NodePath);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, _entCodeEntityTypeId);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByNodePathAndEntityType", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByNodePathAndEntityType", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override TList<EntityMain> GetByChildrenNodePathAndEntityType(TransactionManager transactionManager, System.String _NodePath, System.Decimal _entCodeEntityTypeId, System.Decimal AsCodeDegreeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetChildByNodePathAndEntType", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, _NodePath);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, _entCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, AsCodeDegreeId);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByChildrenNodePathAndEntityType", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                //count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByChildrenNodePathAndEntityType", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetFacultiesAndHomePrograms", this.UseStoredProcedure);


            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, decimal ShowAllFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetFacultiesAndHomePrograms", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ShowAllFlg", DbType.Decimal, ShowAllFlg);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntityMain> GetFacultiesAndHomePrograms(TransactionManager transactionManager, decimal ShowAllFlg , string studyMethod_)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetFacultiesAndHomePrograms", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ShowAllFlg", DbType.Decimal, ShowAllFlg);
            database.AddInParameter(commandWrapper, "@StudyMethod", DbType.AnsiString, studyMethod_);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetFacultiesAndHomePrograms", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
         public override bool UpdateMIGDegree(TransactionManager transactionManager, System.Decimal ID, System.Decimal MjrMainId, System.Decimal MjrPlanId,
         System.Decimal? MinorMainId, System.Decimal? MinorPlanId, System.String DescAr, System.String DescEn, System.Decimal StudJoinYearFrom, System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_MIG_DEGREE_MAJOR_Update", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@ID", DbType.Decimal, 5);
            //database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, FacId);
            //database.AddInParameter(commandWrapper, "@DGRCDE", DbType.String, DGRCDE);
            database.AddInParameter(commandWrapper, "@MJR_ENT_MAIN_ID", DbType.Decimal, MjrMainId);
            database.AddInParameter(commandWrapper, "@MJR_ACAD_PLAN_ID", DbType.Decimal, MjrPlanId);
            database.AddInParameter(commandWrapper, "@MNR_ENT_MAIN_ID", DbType.Decimal, MinorMainId);
            database.AddInParameter(commandWrapper, "@MNR_ACAD_PLAN_ID", DbType.Decimal, MinorPlanId);
            database.AddInParameter(commandWrapper, "@STUD_JOIN_YEAR_FROM", DbType.Decimal, StudJoinYearFrom);
            //database.AddInParameter(commandWrapper, "@STUD_JOIN_YEAR_TO", DbType.Decimal, StudJoinYearTo);
            database.AddInParameter(commandWrapper, "@DSCR_AR", DbType.String, DescAr);
            database.AddInParameter(commandWrapper, "@DSCR_EN", DbType.String, DescEn);
            //database.AddInParameter(commandWrapper, "@NOTES", DbType.String,Notes);
            database.AddInParameter(commandWrapper, "@SPC_ENT_MAIN_ID", DbType.Decimal, SPC_ENT_MAIN_ID);
            database.AddInParameter(commandWrapper, "@SPC_ACAD_PLAN_ID", DbType.Decimal, SPC_ACAD_PLAN_ID);
            int results = 0;

            //Provider Data Requesting Command Event
           // OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertMIGDegree", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //object _admAppPrefId = database.GetParameterValue(commandWrapper, "@ID");
          //  entity.AdmAppPrefId = (System.Decimal)_admAppPrefId;

           // entity.OriginalAdmAppPrefId = entity.AdmAppPrefId;

         //   entity.AcceptChanges();

            //Provider Data Requested Command Event
           // OnDataRequested(new CommandEventArgs(commandWrapper, "InsertMIGDegree", entity));

            return Convert.ToBoolean(results);
        }	

        public override bool InsertMIGDegree(TransactionManager transactionManager, System.Decimal ID,System.Decimal? FacId,System.String DGRCDE,System.Decimal MjrMainId,System.Decimal MjrPlanId,
            System.Decimal? MinorMainId, System.Decimal? MinorPlanId, System.Decimal? StudJoinYearFrom, System.Decimal? StudJoinYearTo, System.String DescAr, System.String DescEn, System.String Notes
            , System.Decimal? AddFlag, System.Decimal? OffFlag,System.Decimal? SPC_ENT_MAIN_ID, System.Decimal? SPC_ACAD_PLAN_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_MIG_DEGREE_MAJOR_Insert", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@ID", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, FacId);
            database.AddInParameter(commandWrapper, "@DGRCDE", DbType.String, DGRCDE);
            database.AddInParameter(commandWrapper, "@MJR_ENT_MAIN_ID", DbType.Decimal, MjrMainId);
            database.AddInParameter(commandWrapper, "@MJR_ACAD_PLAN_ID", DbType.Decimal, MjrPlanId);
            database.AddInParameter(commandWrapper, "@MNR_ENT_MAIN_ID", DbType.Decimal, MinorMainId);
            database.AddInParameter(commandWrapper, "@MNR_ACAD_PLAN_ID", DbType.Decimal, MinorPlanId);
            database.AddInParameter(commandWrapper, "@STUD_JOIN_YEAR_FROM", DbType.Decimal, StudJoinYearFrom);
            database.AddInParameter(commandWrapper, "@STUD_JOIN_YEAR_TO", DbType.Decimal, StudJoinYearTo);
            database.AddInParameter(commandWrapper, "@DSCR_AR", DbType.String, DescAr);
            database.AddInParameter(commandWrapper, "@DSCR_EN", DbType.String, DescEn);
            database.AddInParameter(commandWrapper, "@NOTES", DbType.String,Notes);
            database.AddInParameter(commandWrapper, "@ADD_FLG", DbType.Decimal, AddFlag);
            database.AddInParameter(commandWrapper, "@OFF_FLG", DbType.Decimal, OffFlag);
            database.AddInParameter(commandWrapper, "@SPC_ENT_MAIN_ID", DbType.Decimal, OffFlag);
            database.AddInParameter(commandWrapper, "@SPC_ACAD_PLAN_ID", DbType.Decimal, OffFlag);
            int results = 0;

            //Provider Data Requesting Command Event
           // OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertMIGDegree", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            object _admAppPrefId = database.GetParameterValue(commandWrapper, "@ID");
          //  entity.AdmAppPrefId = (System.Decimal)_admAppPrefId;

           // entity.OriginalAdmAppPrefId = entity.AdmAppPrefId;

         //   entity.AcceptChanges();

            //Provider Data Requested Command Event
           // OnDataRequested(new CommandEventArgs(commandWrapper, "InsertMIGDegree", entity));

            return Convert.ToBoolean(results);
        }	
        public override decimal InsertWithOutEntMainId(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntityMain entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENTITY_MAIN_InsertWithOutEntMainId", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EntMainId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EntDescrAr", DbType.String, entity.EntDescrAr);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@StateNotation", DbType.String, entity.StateNotation);
            database.AddInParameter(commandWrapper, "@EntParentId", DbType.Decimal, (entity.EntParentId != 0 ? (object)entity.EntParentId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDescrEn", DbType.String, entity.EntDescrEn);
           // database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, (entity.EdBylawId.HasValue ? (object)entity.EdBylawId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsStateFlg", DbType.Decimal, (entity.IsStateFlg.HasValue ? (object)entity.IsStateFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsInfoFlg", DbType.Decimal, (entity.IsInfoFlg.HasValue ? (object)entity.IsInfoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, (entity.IsHomeFlg.HasValue ? (object)entity.IsHomeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StateDescrAr", DbType.String, entity.StateDescrAr);
            database.AddInParameter(commandWrapper, "@StateDescrEn", DbType.String, entity.StateDescrEn);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, entity.EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@IsVisible", DbType.Decimal, entity.IsVisible);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, (entity.AsCodeDegreeId.HasValue ? (object)entity.AsCodeDegreeId : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@ED_STUDY_METHOD_ID", DbType.Decimal, (entity.EdStudyMethodId.HasValue ? (object)entity.EdStudyMethodId : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@GsCdeSpecAreaId", DbType.Decimal, (entity.GsCdeSpecAreaId.HasValue ? (object)entity.GsCdeSpecAreaId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmShowFlg", DbType.Boolean, (entity.AdmShowFlg.HasValue ? (object)entity.AdmShowFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DegEquvText", DbType.String, entity.DegEquvText);
            database.AddInParameter(commandWrapper, "@DegEquvTextEng", DbType.String, entity.DegEquvTextEng);
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.String, entity.GsCodeLanguageId);
            database.AddInParameter(commandWrapper, "@ScheduleTypeFlg", DbType.Decimal, (entity.ScheduleTypeFlg.HasValue ? (object)entity.ScheduleTypeFlg : System.DBNull.Value));

            
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


            entity.OriginalEntMainId = entity.EntMainId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));
            return Convert.ToDecimal(commandWrapper.Parameters["@EntMainId"].Value);
        }
        public override TList<EntityMain> GetByHomeFlgAndFacultyInfo(TransactionManager transactionManager, System.Decimal _HomeFlg, System.String _FacultyInfoId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByHomeFlgAndFacultyInfo", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@HomeFlg", DbType.Decimal, _HomeFlg);
            database.AddInParameter(commandWrapper, "@FacultyInfoId", DbType.String, _FacultyInfoId);

            IDataReader reader = null;
            TList<EntityMain> rows = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByHomeFlgAndFacultyInfo", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByHomeFlgAndFacultyInfo", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override string GetEntityMainFullPath(TransactionManager transactionManager, System.Decimal _EntityMinID, System.Decimal _Lang, int _DisplayText)
        {
            string FullPath = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENTITY_MAIN_FULL_PATH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntityMinID", DbType.Decimal, _EntityMinID);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@DisplayText", DbType.Decimal, _DisplayText);
            IDataReader reader = null;
            TList<EntityMain> tmp = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetEntityMainFullPath", tmp));

                if (transactionManager != null)
                {
                    FullPath = (string)Utility.ExecuteScalar(transactionManager, commandWrapper);
                }
                else
                {
                    FullPath = (string)Utility.ExecuteScalar(database, commandWrapper);
                }

                //Create collection and fill
                //  Fill(reader, tmp, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event

                OnDataRequested(new CommandEventArgs(commandWrapper, "GetEntityMainFullPath", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return FullPath;
        }

        public override string GetEntityFullPathStartWithFaculty(TransactionManager transactionManager, System.Decimal _EntityMinID, System.Decimal _Lang)
        {
            string FullPath = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEntityFullPathStartWithFaculty", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@entMainId", DbType.Decimal, _EntityMinID);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
                    table.Rows.Add(items);
                }

                if (table.Rows.Count > 0)
                {
                    if (_Lang == 1)
                        FullPath = table.Rows[0][0].ToString();
                    else
                        FullPath = table.Rows[0][1].ToString();
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return FullPath;
        }

        public override DataTable GetNodeSipling(TransactionManager transactionManager, System.String _NodePath)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENTITY_MAIN_GetNextSipling", this.UseStoredProcedure);
            //Remove last char of _NodePath
            _NodePath = _NodePath.Substring(0, _NodePath.Length - 1);
            database.AddInParameter(commandWrapper, "@NodePath", DbType.String, _NodePath);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        public override DataTable MajMinMatrix_GetByBranch(TransactionManager transactionManager, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MajMinMatrix_GetByBranch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_MATRIX_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_MAIN_MAJOR_ID");
            table.Columns.Add("ENT_MAIN_MINOR_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override bool MajMinMatrix_Insert(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _MajorId, System.Decimal _MinorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MajMinMatrix_Insert", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@MajId", DbType.Decimal, _MajorId);
            database.AddInParameter(commandWrapper, "@MinId", DbType.Decimal, _MinorId);

            int results = 0;

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

        public override bool MajMinMatrix_DeleteByBranch(TransactionManager transactionManager, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MajMinMatrix_DeleteByBranch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            int results = 0;

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

        public override DataTable GetGrantDegreesForFacultiesPrograms(TransactionManager transactionManager, int _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGrantDegreesForFacultiesPrograms", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.String, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetHomeStates(TransactionManager transactionManager, System.Decimal? _FacProgEntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetHomeStates", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacProgEntMainId", DbType.Decimal, _FacProgEntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("NodeEntMainId");
            table.Columns.Add("ParentEntMainId");
            table.Columns.Add("NodePathAr");
            table.Columns.Add("NodePathEn");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override DataTable GetFullfilmentEntities(TransactionManager transactionManager, decimal _AsFacultyInfoId, decimal _EntMainId, decimal _AsCodeDegreeId, decimal _EdAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFullfilmentEntities", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, _AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("YEAR_DESCR_AR");
            table.Columns.Add("YEAR_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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

        public override DataTable FILTER_ENTITIES(TransactionManager transactionManager, System.Decimal AsCodeDegreeId, System.Decimal AsFacultyInfoId, System.Decimal EntityTypeId, System.String EntityName, System.Decimal AcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FILTER_ENTITIES", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE", DbType.Decimal, AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ENTITY_TYPE_ID", DbType.Decimal, EntityTypeId);
            database.AddInParameter(commandWrapper, "@ENTITY_NAME", DbType.String, EntityName);
            database.AddInParameter(commandWrapper, "@ED_ACAD_PLAN_YEAR_ID", DbType.Decimal, AcadYearId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESC_AR");
            table.Columns.Add("ENT_DESC_EN");
            table.Columns.Add("STATE_NOTATION");
            table.Columns.Add("ENT_CODE_ENTITY_TYPE_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ACAD_YEAR_AR");
            table.Columns.Add("ACAD_YEAR_EN");
            table.Columns.Add("IS_VISIBLE");
            table.Columns.Add("IS_STATE_FLG");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_PARENT_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                     reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                     reader[12].ToString(), reader[13].ToString()};
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

        public override DataTable GetStudAcademicPlan(TransactionManager transactionManager, System.Decimal @EdStudSemester)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAcademicPlan", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemester", DbType.Decimal, @EdStudSemester);
           
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESC_AR");
            table.Columns.Add("ENT_DESC_EN");
            table.Columns.Add("STATE_NOTATION");
            table.Columns.Add("ENT_CODE_ENTITY_TYPE_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ACAD_YEAR_AR");
            table.Columns.Add("ACAD_YEAR_EN");
            table.Columns.Add("IS_VISIBLE");
            table.Columns.Add("IS_STATE_FLG");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_PARENT_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                     reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                     reader[12].ToString(), reader[13].ToString()};
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

        public override DataTable GetProgramFees(TransactionManager transactionManager, System.Decimal @MajorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetProgramsFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, @MajorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Major_ID");
            table.Columns.Add("Major_Description_AR");
            table.Columns.Add("Major_Description_EN");
            table.Columns.Add("Band_Description_AR");
            table.Columns.Add("Band_Description_EN");
            table.Columns.Add("Sponsor");
            table.Columns.Add("Currency");
            table.Columns.Add("Amount");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                     reader[8].ToString()};
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