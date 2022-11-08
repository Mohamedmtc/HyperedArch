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
	/// This class is the base class for any <see cref="EdCodeCourseAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseAssessProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseAssess, UMIS_VER2.BusinessLyer.EdCodeCourseAssessKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseAssessKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseAssessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeCourseAssessId)
		{
			return Delete(null, _edCodeCourseAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseAssess Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseAssessKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseAssessId(transactionManager, key.EdCodeCourseAssessId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(System.Decimal? _asFacultyInfoId, System.String _descrAr)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrAr(null,_asFacultyInfoId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(System.Decimal? _asFacultyInfoId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrAr(null, _asFacultyInfoId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrAr(transactionManager, _asFacultyInfoId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrAr(transactionManager, _asFacultyInfoId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(System.Decimal? _asFacultyInfoId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdDescrAr(null, _asFacultyInfoId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrAr(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(System.Decimal? _asFacultyInfoId, System.String _descrEn)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEn(null,_asFacultyInfoId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(System.Decimal? _asFacultyInfoId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEn(null, _asFacultyInfoId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEn(transactionManager, _asFacultyInfoId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdDescrEn(transactionManager, _asFacultyInfoId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(System.Decimal? _asFacultyInfoId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdDescrEn(null, _asFacultyInfoId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_METHOD_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByAsFacultyInfoIdDescrEn(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.String _descrEn, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public TList<EdCodeCourseAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public TList<EdCodeCourseAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public TList<EdCodeCourseAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public TList<EdCodeCourseAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public TList<EdCodeCourseAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeCourseAssess&gt;"/> class.</returns>
		public abstract TList<EdCodeCourseAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(null,_edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SUBJECT_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseAssess GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseAssess&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseAssess&gt;"/></returns>
		public static TList<EdCodeCourseAssess> Fill(IDataReader reader, TList<EdCodeCourseAssess> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseAssess c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseAssess")
					.Append("|").Append((System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseAssess>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseAssess",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseAssess();
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
					c.EdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.OriginalEdCodeCourseAssessId = c.EdCodeCourseAssessId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.ControlFlag = (System.Decimal)reader["CONTROL_FLAG"];
					c.SemWorkFlg = Convert.IsDBNull(reader["SEM_WORK_FLG"]) ? null : (System.Decimal?)reader["SEM_WORK_FLG"];
					c.AssessOrder = Convert.IsDBNull(reader["ASSESS_ORDER"]) ? null : (System.Decimal?)reader["ASSESS_ORDER"];
					c.ExamPayPercent = Convert.IsDBNull(reader["EXAM_PAY_PERCENT"]) ? null : (System.Decimal?)reader["EXAM_PAY_PERCENT"];
					c.MoodleFlg = Convert.IsDBNull(reader["MOODLE_FLG"]) ? null : (System.Boolean?)reader["MOODLE_FLG"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.PostponeFlg = Convert.IsDBNull(reader["POSTPONE_FLG"]) ? null : (System.Boolean?)reader["POSTPONE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseAssess entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseAssessId = (System.Decimal)reader[((int)EdCodeCourseAssessColumn.EdCodeCourseAssessId - 1)];
			entity.OriginalEdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeCourseAssessColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeCourseAssessColumn.DescrEn - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseAssessColumn.AsFacultyInfoId - 1)];
			entity.ControlFlag = (System.Decimal)reader[((int)EdCodeCourseAssessColumn.ControlFlag - 1)];
			entity.SemWorkFlg = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.SemWorkFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseAssessColumn.SemWorkFlg - 1)];
			entity.AssessOrder = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.AssessOrder - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseAssessColumn.AssessOrder - 1)];
			entity.ExamPayPercent = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.ExamPayPercent - 1)))?null:(System.Decimal?)reader[((int)EdCodeCourseAssessColumn.ExamPayPercent - 1)];
			entity.MoodleFlg = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.MoodleFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeCourseAssessColumn.MoodleFlg - 1)];
			entity.EnumId = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)EdCodeCourseAssessColumn.EnumId - 1)];
			entity.PostponeFlg = (reader.IsDBNull(((int)EdCodeCourseAssessColumn.PostponeFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeCourseAssessColumn.PostponeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseAssess entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.OriginalEdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.ControlFlag = (System.Decimal)dataRow["CONTROL_FLAG"];
			entity.SemWorkFlg = Convert.IsDBNull(dataRow["SEM_WORK_FLG"]) ? null : (System.Decimal?)dataRow["SEM_WORK_FLG"];
			entity.AssessOrder = Convert.IsDBNull(dataRow["ASSESS_ORDER"]) ? null : (System.Decimal?)dataRow["ASSESS_ORDER"];
			entity.ExamPayPercent = Convert.IsDBNull(dataRow["EXAM_PAY_PERCENT"]) ? null : (System.Decimal?)dataRow["EXAM_PAY_PERCENT"];
			entity.MoodleFlg = Convert.IsDBNull(dataRow["MOODLE_FLG"]) ? null : (System.Boolean?)dataRow["MOODLE_FLG"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.PostponeFlg = Convert.IsDBNull(dataRow["POSTPONE_FLG"]) ? null : (System.Boolean?)dataRow["POSTPONE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseAssess"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseAssess Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseAssess entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseAssessId methods when available
			
			#region EntPolicyAssessDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessDtl>|EntPolicyAssessDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessDtlCollection = DataRepository.EntPolicyAssessDtlProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EntPolicyAssessDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessDtl>) DataRepository.EntPolicyAssessDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExamAssess>|EdStdCrsExamAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamAssessCollection = DataRepository.EdStdCrsExamAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EdStdCrsExamAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExamAssess>) DataRepository.EdStdCrsExamAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessSubCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssessSub>|EdStudCourseRegAssessSubCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessSubCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessSubCollection = DataRepository.EdStudCourseRegAssessSubProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EdStudCourseRegAssessSubCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessSubCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssessSub>) DataRepository.EdStudCourseRegAssessSubProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessSubCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessGrpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessGrpDtl>|EntPolicyAssessGrpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessGrpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessGrpDtlCollection = DataRepository.EntPolicyAssessGrpDtlProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EntPolicyAssessGrpDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessGrpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessGrpDtl>) DataRepository.EntPolicyAssessGrpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessGrpDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseAssess object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseAssess instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseAssess Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseAssess entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyAssessDtl>
				if (CanDeepSave(entity.EntPolicyAssessDtlCollection, "List<EntPolicyAssessDtl>|EntPolicyAssessDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessDtl child in entity.EntPolicyAssessDtlCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EntPolicyAssessDtlCollection.Count > 0 || entity.EntPolicyAssessDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessDtlProvider.Save(transactionManager, entity.EntPolicyAssessDtlCollection);
						
						deepHandles.Add("EntPolicyAssessDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessDtl >) DataRepository.EntPolicyAssessDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExamAssess>
				if (CanDeepSave(entity.EdStdCrsExamAssessCollection, "List<EdStdCrsExamAssess>|EdStdCrsExamAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExamAssess child in entity.EdStdCrsExamAssessCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EdStdCrsExamAssessCollection.Count > 0 || entity.EdStdCrsExamAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamAssessProvider.Save(transactionManager, entity.EdStdCrsExamAssessCollection);
						
						deepHandles.Add("EdStdCrsExamAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExamAssess >) DataRepository.EdStdCrsExamAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssessSub>
				if (CanDeepSave(entity.EdStudCourseRegAssessSubCollection, "List<EdStudCourseRegAssessSub>|EdStudCourseRegAssessSubCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssessSub child in entity.EdStudCourseRegAssessSubCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EdStudCourseRegAssessSubCollection.Count > 0 || entity.EdStudCourseRegAssessSubCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessSubProvider.Save(transactionManager, entity.EdStudCourseRegAssessSubCollection);
						
						deepHandles.Add("EdStudCourseRegAssessSubCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssessSub >) DataRepository.EdStudCourseRegAssessSubProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessSubCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessGrpDtl>
				if (CanDeepSave(entity.EntPolicyAssessGrpDtlCollection, "List<EntPolicyAssessGrpDtl>|EntPolicyAssessGrpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessGrpDtl child in entity.EntPolicyAssessGrpDtlCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EntPolicyAssessGrpDtlCollection.Count > 0 || entity.EntPolicyAssessGrpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessGrpDtlProvider.Save(transactionManager, entity.EntPolicyAssessGrpDtlCollection);
						
						deepHandles.Add("EntPolicyAssessGrpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessGrpDtl >) DataRepository.EntPolicyAssessGrpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessGrpDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdCodeCourseAssessIdSource != null)
						{
							child.EdCodeCourseAssessId = child.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
						}
						else
						{
							child.EdCodeCourseAssessId = entity.EdCodeCourseAssessId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseAssessChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseAssess</c>
	///</summary>
	public enum EdCodeCourseAssessChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EntPolicyAssessDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessDtl>))]
		EntPolicyAssessDtlCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EdStdCrsExamAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExamAssess>))]
		EdStdCrsExamAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EdStudCourseRegAssessSubCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssessSub>))]
		EdStudCourseRegAssessSubCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EntPolicyAssessGrpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessGrpDtl>))]
		EntPolicyAssessGrpDtlCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseAssess</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
	}
	
	#endregion EdCodeCourseAssessChildEntityTypes
	
	#region EdCodeCourseAssessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseAssessFilterBuilder : SqlFilterBuilder<EdCodeCourseAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessFilterBuilder class.
		/// </summary>
		public EdCodeCourseAssessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseAssessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseAssessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseAssessFilterBuilder
	
	#region EdCodeCourseAssessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseAssessParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessParameterBuilder class.
		/// </summary>
		public EdCodeCourseAssessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseAssessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseAssessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseAssessParameterBuilder
	
	#region EdCodeCourseAssessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseAssess"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseAssessSortBuilder : SqlSortBuilder<EdCodeCourseAssessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseAssessSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseAssessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseAssessSortBuilder
	
} // end namespace
