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
	/// This class is the base class for any <see cref="EdStdCrsExamAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStdCrsExamAssessProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStdCrsExamAssess, UMIS_VER2.BusinessLyer.EdStdCrsExamAssessKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamAssessKey key)
		{
			return Delete(transactionManager, key.EdStdCrsExamAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStdCrsExamAssessId)
		{
			return Delete(null, _edStdCrsExamAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStdCrsExamAssessId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		fkEdStdCrsExamAssessEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		fkEdStdCrsExamAssessEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">مسلسل طريقة التقييم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public abstract TList<EdStdCrsExamAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM Description: 
		/// </summary>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId)
		{
			int count = -1;
			return GetByEdStdCrsExamId(_edStdCrsExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId)
		{
			int count = -1;
			return GetByEdStdCrsExamId(transactionManager, _edStdCrsExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdCrsExamId(transactionManager, _edStdCrsExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		fkEdStdCrsExamAssessEdStdCrsExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStdCrsExamId(null, _edStdCrsExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		fkEdStdCrsExamAssessEdStdCrsExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId, int start, int pageLength,out int count)
		{
			return GetByEdStdCrsExamId(null, _edStdCrsExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM key.
		///		FK_ED_STD_CRS_EXAM_ASSESS_ED_STD_CRS_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExamAssess objects.</returns>
		public abstract TList<EdStdCrsExamAssess> GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStdCrsExamAssess Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamAssessKey key, int start, int pageLength)
		{
			return GetByEdStdCrsExamAssessId(transactionManager, key.EdStdCrsExamAssessId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(System.Decimal _edStdCrsExamAssessId)
		{
			int count = -1;
			return GetByEdStdCrsExamAssessId(null,_edStdCrsExamAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(System.Decimal _edStdCrsExamAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdCrsExamAssessId(null, _edStdCrsExamAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(TransactionManager transactionManager, System.Decimal _edStdCrsExamAssessId)
		{
			int count = -1;
			return GetByEdStdCrsExamAssessId(transactionManager, _edStdCrsExamAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(TransactionManager transactionManager, System.Decimal _edStdCrsExamAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdCrsExamAssessId(transactionManager, _edStdCrsExamAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(System.Decimal _edStdCrsExamAssessId, int start, int pageLength, out int count)
		{
			return GetByEdStdCrsExamAssessId(null, _edStdCrsExamAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_EXAM_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamAssessId">مسلسل  نتيجة امتحان تكميلى اعا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStdCrsExamAssess GetByEdStdCrsExamAssessId(TransactionManager transactionManager, System.Decimal _edStdCrsExamAssessId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStdCrsExamAssess&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStdCrsExamAssess&gt;"/></returns>
		public static TList<EdStdCrsExamAssess> Fill(IDataReader reader, TList<EdStdCrsExamAssess> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStdCrsExamAssess c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStdCrsExamAssess")
					.Append("|").Append((System.Decimal)reader["ED_STD_CRS_EXAM_ASSESS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStdCrsExamAssess>(
					key.ToString(), // EntityTrackingKey
					"EdStdCrsExamAssess",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStdCrsExamAssess();
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
					c.EdStdCrsExamAssessId = (System.Decimal)reader["ED_STD_CRS_EXAM_ASSESS_ID"];
					c.OriginalEdStdCrsExamAssessId = c.EdStdCrsExamAssessId;
					c.EdStdCrsExamId = (System.Decimal)reader["ED_STD_CRS_EXAM_ID"];
					c.EdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.AssessMarkOld = Convert.IsDBNull(reader["ASSESS_MARK_OLD"]) ? null : (System.Decimal?)reader["ASSESS_MARK_OLD"];
					c.AssessMarkNew = Convert.IsDBNull(reader["ASSESS_MARK_NEW"]) ? null : (System.Decimal?)reader["ASSESS_MARK_NEW"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStdCrsExamAssess entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStdCrsExamAssessId = (System.Decimal)reader[((int)EdStdCrsExamAssessColumn.EdStdCrsExamAssessId - 1)];
			entity.OriginalEdStdCrsExamAssessId = (System.Decimal)reader["ED_STD_CRS_EXAM_ASSESS_ID"];
			entity.EdStdCrsExamId = (System.Decimal)reader[((int)EdStdCrsExamAssessColumn.EdStdCrsExamId - 1)];
			entity.EdCodeCourseAssessId = (System.Decimal)reader[((int)EdStdCrsExamAssessColumn.EdCodeCourseAssessId - 1)];
			entity.AssessMarkOld = (reader.IsDBNull(((int)EdStdCrsExamAssessColumn.AssessMarkOld - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamAssessColumn.AssessMarkOld - 1)];
			entity.AssessMarkNew = (reader.IsDBNull(((int)EdStdCrsExamAssessColumn.AssessMarkNew - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamAssessColumn.AssessMarkNew - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStdCrsExamAssessColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStdCrsExamAssessColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStdCrsExamAssessColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamAssessColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStdCrsExamAssessColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamAssessColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStdCrsExamAssess entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStdCrsExamAssessId = (System.Decimal)dataRow["ED_STD_CRS_EXAM_ASSESS_ID"];
			entity.OriginalEdStdCrsExamAssessId = (System.Decimal)dataRow["ED_STD_CRS_EXAM_ASSESS_ID"];
			entity.EdStdCrsExamId = (System.Decimal)dataRow["ED_STD_CRS_EXAM_ID"];
			entity.EdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.AssessMarkOld = Convert.IsDBNull(dataRow["ASSESS_MARK_OLD"]) ? null : (System.Decimal?)dataRow["ASSESS_MARK_OLD"];
			entity.AssessMarkNew = Convert.IsDBNull(dataRow["ASSESS_MARK_NEW"]) ? null : (System.Decimal?)dataRow["ASSESS_MARK_NEW"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExamAssess"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdCrsExamAssess Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamAssess entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseAssessId;
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

			#region EdStdCrsExamIdSource	
			if (CanDeepLoad(entity, "EdStdCrsExam|EdStdCrsExamIdSource", deepLoadType, innerList) 
				&& entity.EdStdCrsExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStdCrsExamId;
				EdStdCrsExam tmpEntity = EntityManager.LocateEntity<EdStdCrsExam>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStdCrsExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStdCrsExamIdSource = tmpEntity;
				else
					entity.EdStdCrsExamIdSource = DataRepository.EdStdCrsExamProvider.GetByEdStdCrsExamId(transactionManager, entity.EdStdCrsExamId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStdCrsExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStdCrsExamProvider.DeepLoad(transactionManager, entity.EdStdCrsExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStdCrsExamIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStdCrsExamAssess object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStdCrsExamAssess instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdCrsExamAssess Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamAssess entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
			}
			#endregion 
			
			#region EdStdCrsExamIdSource
			if (CanDeepSave(entity, "EdStdCrsExam|EdStdCrsExamIdSource", deepSaveType, innerList) 
				&& entity.EdStdCrsExamIdSource != null)
			{
				DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamIdSource);
				entity.EdStdCrsExamId = entity.EdStdCrsExamIdSource.EdStdCrsExamId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region EdStdCrsExamAssessChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStdCrsExamAssess</c>
	///</summary>
	public enum EdStdCrsExamAssessChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdStdCrsExam</c> at EdStdCrsExamIdSource
		///</summary>
		[ChildEntityType(typeof(EdStdCrsExam))]
		EdStdCrsExam,
	}
	
	#endregion EdStdCrsExamAssessChildEntityTypes
	
	#region EdStdCrsExamAssessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStdCrsExamAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExamAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdCrsExamAssessFilterBuilder : SqlFilterBuilder<EdStdCrsExamAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessFilterBuilder class.
		/// </summary>
		public EdStdCrsExamAssessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdCrsExamAssessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdCrsExamAssessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdCrsExamAssessFilterBuilder
	
	#region EdStdCrsExamAssessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStdCrsExamAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExamAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdCrsExamAssessParameterBuilder : ParameterizedSqlFilterBuilder<EdStdCrsExamAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessParameterBuilder class.
		/// </summary>
		public EdStdCrsExamAssessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdCrsExamAssessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdCrsExamAssessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdCrsExamAssessParameterBuilder
	
	#region EdStdCrsExamAssessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStdCrsExamAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExamAssess"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStdCrsExamAssessSortBuilder : SqlSortBuilder<EdStdCrsExamAssessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamAssessSqlSortBuilder class.
		/// </summary>
		public EdStdCrsExamAssessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStdCrsExamAssessSortBuilder
	
} // end namespace
