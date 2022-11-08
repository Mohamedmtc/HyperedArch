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
	/// This class is the base class for any <see cref="AdmAppTransFromCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTransFromCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppTransFromCourse, UMIS_VER2.BusinessLyer.AdmAppTransFromCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransFromCourseKey key)
		{
			return Delete(transactionManager, key.AdmAppTransFromCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppTransFromCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppTransFromCourseId)
		{
			return Delete(null, _admAppTransFromCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.AdmAppTransFromCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransFromCourseKey key, int start, int pageLength)
		{
			return GetByAdmAppTransFromCourseId(transactionManager, key.AdmAppTransFromCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null,_admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransFromCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(null,_gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public TList<AdmAppTransFromCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransFromCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransFromCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(null,_admAppTransFromCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(null, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(transactionManager, _admAppTransFromCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(transactionManager, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransFromCourseId(null, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTransFromCourse GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppTransFromCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppTransFromCourse&gt;"/></returns>
		public static TList<AdmAppTransFromCourse> Fill(IDataReader reader, TList<AdmAppTransFromCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppTransFromCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppTransFromCourse")
					.Append("|").Append((System.Decimal)reader["ADM_APP_TRANS_FROM_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppTransFromCourse>(
					key.ToString(), // EntityTrackingKey
					"AdmAppTransFromCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppTransFromCourse();
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
					c.AdmAppTransFromCourseId = (System.Decimal)reader["ADM_APP_TRANS_FROM_COURSE_ID"];
					c.OriginalAdmAppTransFromCourseId = c.AdmAppTransFromCourseId;
					c.AdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
					c.CourseCode = (System.String)reader["COURSE_CODE"];
					c.CourseCh = (System.String)reader["COURSE_CH"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.CourseGrade = Convert.IsDBNull(reader["COURSE_GRADE"]) ? null : (System.String)reader["COURSE_GRADE"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.CourseBrief = Convert.IsDBNull(reader["COURSE_BRIEF"]) ? null : (System.String)reader["COURSE_BRIEF"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppTransFromCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppTransFromCourseId = (System.Decimal)reader[((int)AdmAppTransFromCourseColumn.AdmAppTransFromCourseId - 1)];
			entity.OriginalAdmAppTransFromCourseId = (System.Decimal)reader["ADM_APP_TRANS_FROM_COURSE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)reader[((int)AdmAppTransFromCourseColumn.AdmAppTransReqId - 1)];
			entity.CourseCode = (System.String)reader[((int)AdmAppTransFromCourseColumn.CourseCode - 1)];
			entity.CourseCh = (System.String)reader[((int)AdmAppTransFromCourseColumn.CourseCh - 1)];
			entity.DescrAr = (System.String)reader[((int)AdmAppTransFromCourseColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)AdmAppTransFromCourseColumn.DescrEn - 1)];
			entity.CourseGrade = (reader.IsDBNull(((int)AdmAppTransFromCourseColumn.CourseGrade - 1)))?null:(System.String)reader[((int)AdmAppTransFromCourseColumn.CourseGrade - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)AdmAppTransFromCourseColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransFromCourseColumn.CoursePoint - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)AdmAppTransFromCourseColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransFromCourseColumn.GsCodePassFailId - 1)];
			entity.CourseBrief = (reader.IsDBNull(((int)AdmAppTransFromCourseColumn.CourseBrief - 1)))?null:(System.String)reader[((int)AdmAppTransFromCourseColumn.CourseBrief - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppTransFromCourseColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppTransFromCourseColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppTransFromCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppTransFromCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_FROM_COURSE_ID"];
			entity.OriginalAdmAppTransFromCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_FROM_COURSE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.CourseCode = (System.String)dataRow["COURSE_CODE"];
			entity.CourseCh = (System.String)dataRow["COURSE_CH"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.CourseGrade = Convert.IsDBNull(dataRow["COURSE_GRADE"]) ? null : (System.String)dataRow["COURSE_GRADE"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.CourseBrief = Convert.IsDBNull(dataRow["COURSE_BRIEF"]) ? null : (System.String)dataRow["COURSE_BRIEF"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransFromCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransFromCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransFromCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppTransReqIdSource	
			if (CanDeepLoad(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransReqId;
				AdmAppTransReq tmpEntity = EntityManager.LocateEntity<AdmAppTransReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransReqIdSource = tmpEntity;
				else
					entity.AdmAppTransReqIdSource = DataRepository.AdmAppTransReqProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransReqProvider.DeepLoad(transactionManager, entity.AdmAppTransReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransReqIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppTransFromCourseId methods when available
			
			#region AdmAppTransBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransBalanceCollection = DataRepository.AdmAppTransBalanceProvider.GetByAdmAppTransFromCourseId(transactionManager, entity.AdmAppTransFromCourseId);

				if (deep && entity.AdmAppTransBalanceCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransBalance>) DataRepository.AdmAppTransBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppTransFromCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransFromCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransFromCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransFromCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppTransReqIdSource
			if (CanDeepSave(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransReqIdSource != null)
			{
				DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqIdSource);
				entity.AdmAppTransReqId = entity.AdmAppTransReqIdSource.AdmAppTransReqId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppTransBalance>
				if (CanDeepSave(entity.AdmAppTransBalanceCollection, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransBalance child in entity.AdmAppTransBalanceCollection)
					{
						if(child.AdmAppTransFromCourseIdSource != null)
						{
							child.AdmAppTransFromCourseId = child.AdmAppTransFromCourseIdSource.AdmAppTransFromCourseId;
						}
						else
						{
							child.AdmAppTransFromCourseId = entity.AdmAppTransFromCourseId;
						}

					}

					if (entity.AdmAppTransBalanceCollection.Count > 0 || entity.AdmAppTransBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransBalanceProvider.Save(transactionManager, entity.AdmAppTransBalanceCollection);
						
						deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransBalance >) DataRepository.AdmAppTransBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppTransFromCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppTransFromCourse</c>
	///</summary>
	public enum AdmAppTransFromCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppTransReq</c> at AdmAppTransReqIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransReq))]
		AdmAppTransReq,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
		///<summary>
		/// Collection of <c>AdmAppTransFromCourse</c> as OneToMany for AdmAppTransBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransBalance>))]
		AdmAppTransBalanceCollection,
	}
	
	#endregion AdmAppTransFromCourseChildEntityTypes
	
	#region AdmAppTransFromCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppTransFromCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransFromCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransFromCourseFilterBuilder : SqlFilterBuilder<AdmAppTransFromCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseFilterBuilder class.
		/// </summary>
		public AdmAppTransFromCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransFromCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransFromCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransFromCourseFilterBuilder
	
	#region AdmAppTransFromCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppTransFromCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransFromCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransFromCourseParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppTransFromCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseParameterBuilder class.
		/// </summary>
		public AdmAppTransFromCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransFromCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransFromCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransFromCourseParameterBuilder
	
	#region AdmAppTransFromCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppTransFromCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransFromCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppTransFromCourseSortBuilder : SqlSortBuilder<AdmAppTransFromCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransFromCourseSqlSortBuilder class.
		/// </summary>
		public AdmAppTransFromCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppTransFromCourseSortBuilder
	
} // end namespace
