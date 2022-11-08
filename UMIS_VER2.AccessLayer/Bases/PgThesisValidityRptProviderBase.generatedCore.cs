#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="PgThesisValidityRptProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisValidityRptProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisValidityRpt, UMIS_VER2.BusinessLyer.PgThesisValidityRptKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisValidityRptKey key)
		{
			return Delete(transactionManager, key.PgThesisValidityRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisValidityRptId)
		{
			return Delete(null, _pgThesisValidityRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisValidityRptId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		public TList<PgThesisValidityRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisValidityRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		public TList<PgThesisValidityRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		fkPgThesisValidityRptPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		public TList<PgThesisValidityRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		fkPgThesisValidityRptPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		public TList<PgThesisValidityRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_VALIDITY_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisValidityRpt objects.</returns>
		public abstract TList<PgThesisValidityRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override UMIS_VER2.BusinessLyer.PgThesisValidityRpt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisValidityRptKey key, int start, int pageLength)
		{
			return GetByPgThesisValidityRptId(transactionManager, key.PgThesisValidityRptId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(System.Decimal _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(null,_pgThesisValidityRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(System.Decimal _pgThesisValidityRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal _pgThesisValidityRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(System.Decimal _pgThesisValidityRptId, int start, int pageLength, out int count)
		{
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_VALIDITY_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisValidityRpt GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal _pgThesisValidityRptId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisValidityRpt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisValidityRpt&gt;"/></returns>
		public static TList<PgThesisValidityRpt> Fill(IDataReader reader, TList<PgThesisValidityRpt> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				UMIS_VER2.BusinessLyer.PgThesisValidityRpt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisValidityRpt")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_VALIDITY_RPT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisValidityRpt>(
					key.ToString(), // EntityTrackingKey
					"PgThesisValidityRpt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisValidityRpt();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.PgThesisValidityRptId = (System.Decimal)reader["PG_THESIS_VALIDITY_RPT_ID"];
					c.OriginalPgThesisValidityRptId = c.PgThesisValidityRptId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.ReportDate = Convert.IsDBNull(reader["REPORT_DATE"]) ? null : (System.DateTime?)reader["REPORT_DATE"];
					c.FeedBack = Convert.IsDBNull(reader["FEED_BACK"]) ? null : (System.String)reader["FEED_BACK"];
					c.DeliverDraftFlg = Convert.IsDBNull(reader["DELIVER_DRAFT_FLG"]) ? null : (System.Boolean?)reader["DELIVER_DRAFT_FLG"];
					c.DeliverDraftDate = Convert.IsDBNull(reader["DELIVER_DRAFT_DATE"]) ? null : (System.DateTime?)reader["DELIVER_DRAFT_DATE"];
					c.PlagiarismPrcnt = Convert.IsDBNull(reader["PLAGIARISM_PRCNT"]) ? null : (System.Decimal?)reader["PLAGIARISM_PRCNT"];
					c.DeliverRptFlg = Convert.IsDBNull(reader["DELIVER_RPT_FLG"]) ? null : (System.Boolean?)reader["DELIVER_RPT_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisValidityRpt entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisValidityRptId = (System.Decimal)reader[((int)PgThesisValidityRptColumn.PgThesisValidityRptId - 1)];
			entity.OriginalPgThesisValidityRptId = (System.Decimal)reader["PG_THESIS_VALIDITY_RPT_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisValidityRptColumn.PgThesisStudId - 1)];
			entity.ReportDate = (reader.IsDBNull(((int)PgThesisValidityRptColumn.ReportDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisValidityRptColumn.ReportDate - 1)];
			entity.FeedBack = (reader.IsDBNull(((int)PgThesisValidityRptColumn.FeedBack - 1)))?null:(System.String)reader[((int)PgThesisValidityRptColumn.FeedBack - 1)];
			entity.DeliverDraftFlg = (reader.IsDBNull(((int)PgThesisValidityRptColumn.DeliverDraftFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisValidityRptColumn.DeliverDraftFlg - 1)];
			entity.DeliverDraftDate = (reader.IsDBNull(((int)PgThesisValidityRptColumn.DeliverDraftDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisValidityRptColumn.DeliverDraftDate - 1)];
			entity.PlagiarismPrcnt = (reader.IsDBNull(((int)PgThesisValidityRptColumn.PlagiarismPrcnt - 1)))?null:(System.Decimal?)reader[((int)PgThesisValidityRptColumn.PlagiarismPrcnt - 1)];
			entity.DeliverRptFlg = (reader.IsDBNull(((int)PgThesisValidityRptColumn.DeliverRptFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisValidityRptColumn.DeliverRptFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisValidityRptColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisValidityRptColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisValidityRptColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisValidityRptColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisValidityRptColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisValidityRptColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisValidityRpt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisValidityRptId = (System.Decimal)dataRow["PG_THESIS_VALIDITY_RPT_ID"];
			entity.OriginalPgThesisValidityRptId = (System.Decimal)dataRow["PG_THESIS_VALIDITY_RPT_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.ReportDate = Convert.IsDBNull(dataRow["REPORT_DATE"]) ? null : (System.DateTime?)dataRow["REPORT_DATE"];
			entity.FeedBack = Convert.IsDBNull(dataRow["FEED_BACK"]) ? null : (System.String)dataRow["FEED_BACK"];
			entity.DeliverDraftFlg = Convert.IsDBNull(dataRow["DELIVER_DRAFT_FLG"]) ? null : (System.Boolean?)dataRow["DELIVER_DRAFT_FLG"];
			entity.DeliverDraftDate = Convert.IsDBNull(dataRow["DELIVER_DRAFT_DATE"]) ? null : (System.DateTime?)dataRow["DELIVER_DRAFT_DATE"];
			entity.PlagiarismPrcnt = Convert.IsDBNull(dataRow["PLAGIARISM_PRCNT"]) ? null : (System.Decimal?)dataRow["PLAGIARISM_PRCNT"];
			entity.DeliverRptFlg = Convert.IsDBNull(dataRow["DELIVER_RPT_FLG"]) ? null : (System.Boolean?)dataRow["DELIVER_RPT_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisValidityRpt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisValidityRpt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisValidityRpt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisStudId;
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisValidityRptId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisValidityRptId(transactionManager, entity.PgThesisValidityRptId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisValidityRptId(transactionManager, entity.PgThesisValidityRptId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisValidityRpt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisValidityRpt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisValidityRpt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisValidityRpt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisValidityRptIdSource != null)
						{
							child.PgThesisValidityRptId = child.PgThesisValidityRptIdSource.PgThesisValidityRptId;
						}
						else
						{
							child.PgThesisValidityRptId = entity.PgThesisValidityRptId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgThesisValidityRptIdSource != null)
						{
							child.PgThesisValidityRptId = child.PgThesisValidityRptIdSource.PgThesisValidityRptId;
						}
						else
						{
							child.PgThesisValidityRptId = entity.PgThesisValidityRptId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region PgThesisValidityRptChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisValidityRpt</c>
	///</summary>
	public enum PgThesisValidityRptChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisValidityRpt</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisValidityRpt</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisValidityRptChildEntityTypes
	
	#region PgThesisValidityRptFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisValidityRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisValidityRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisValidityRptFilterBuilder : SqlFilterBuilder<PgThesisValidityRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptFilterBuilder class.
		/// </summary>
		public PgThesisValidityRptFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisValidityRptFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisValidityRptFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisValidityRptFilterBuilder
	
	#region PgThesisValidityRptParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisValidityRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisValidityRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisValidityRptParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisValidityRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptParameterBuilder class.
		/// </summary>
		public PgThesisValidityRptParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisValidityRptParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisValidityRptParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisValidityRptParameterBuilder
	
	#region PgThesisValidityRptSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisValidityRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisValidityRpt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisValidityRptSortBuilder : SqlSortBuilder<PgThesisValidityRptColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisValidityRptSqlSortBuilder class.
		/// </summary>
		public PgThesisValidityRptSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisValidityRptSortBuilder
	
} // end namespace
