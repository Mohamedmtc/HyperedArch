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
	/// This class is the base class for any <see cref="EdStudExcuseCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExcuseCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExcuseCourse, UMIS_VER2.BusinessLyer.EdStudExcuseCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExcuseCourseKey key)
		{
			return Delete(transactionManager, key.EdStudExcuseCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExcuseCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExcuseCourseId)
		{
			return Delete(null, _edStudExcuseCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExcuseCourseId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExcuseCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExcuseCourseKey key, int start, int pageLength)
		{
			return GetByEdStudExcuseCourseId(transactionManager, key.EdStudExcuseCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public abstract TList<EdStudExcuseCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdStudExcuseId(System.Decimal _edStudExcuseId)
		{
			int count = -1;
			return GetByEdStudExcuseId(null,_edStudExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdStudExcuseId(System.Decimal _edStudExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseId(null, _edStudExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdStudExcuseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId)
		{
			int count = -1;
			return GetByEdStudExcuseId(transactionManager, _edStudExcuseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdStudExcuseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseId(transactionManager, _edStudExcuseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public TList<EdStudExcuseCourse> GetByEdStudExcuseId(System.Decimal _edStudExcuseId, int start, int pageLength, out int count)
		{
			return GetByEdStudExcuseId(null, _edStudExcuseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_EXCUSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudExcuseCourse&gt;"/> class.</returns>
		public abstract TList<EdStudExcuseCourse> GetByEdStudExcuseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(System.Decimal _edStudExcuseCourseId)
		{
			int count = -1;
			return GetByEdStudExcuseCourseId(null,_edStudExcuseCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(System.Decimal _edStudExcuseCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseCourseId(null, _edStudExcuseCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseCourseId)
		{
			int count = -1;
			return GetByEdStudExcuseCourseId(transactionManager, _edStudExcuseCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseCourseId(transactionManager, _edStudExcuseCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(System.Decimal _edStudExcuseCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudExcuseCourseId(null, _edStudExcuseCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXC_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(System.Decimal _edStudExcuseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudExcuseIdEdCourseId(null,_edStudExcuseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(System.Decimal _edStudExcuseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseIdEdCourseId(null, _edStudExcuseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudExcuseIdEdCourseId(transactionManager, _edStudExcuseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExcuseIdEdCourseId(transactionManager, _edStudExcuseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(System.Decimal _edStudExcuseId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudExcuseIdEdCourseId(null, _edStudExcuseId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_EXC_SUBJECT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExcuseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExcuseCourse GetByEdStudExcuseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudExcuseId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExcuseCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExcuseCourse&gt;"/></returns>
		public static TList<EdStudExcuseCourse> Fill(IDataReader reader, TList<EdStudExcuseCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExcuseCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExcuseCourse")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXCUSE_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExcuseCourse>(
					key.ToString(), // EntityTrackingKey
					"EdStudExcuseCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExcuseCourse();
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
					c.EdStudExcuseCourseId = (System.Decimal)reader["ED_STUD_EXCUSE_COURSE_ID"];
					c.OriginalEdStudExcuseCourseId = c.EdStudExcuseCourseId;
					c.EdStudExcuseId = (System.Decimal)reader["ED_STUD_EXCUSE_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.ReExamFlag = Convert.IsDBNull(reader["RE_EXAM_FLAG"]) ? null : (System.Decimal?)reader["RE_EXAM_FLAG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExcuseCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExcuseCourseId = (System.Decimal)reader[((int)EdStudExcuseCourseColumn.EdStudExcuseCourseId - 1)];
			entity.OriginalEdStudExcuseCourseId = (System.Decimal)reader["ED_STUD_EXCUSE_COURSE_ID"];
			entity.EdStudExcuseId = (System.Decimal)reader[((int)EdStudExcuseCourseColumn.EdStudExcuseId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudExcuseCourseColumn.EdCourseId - 1)];
			entity.ReExamFlag = (reader.IsDBNull(((int)EdStudExcuseCourseColumn.ReExamFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudExcuseCourseColumn.ReExamFlag - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudExcuseCourseColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudExcuseCourseColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudExcuseCourseColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudExcuseCourseColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExcuseCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExcuseCourseId = (System.Decimal)dataRow["ED_STUD_EXCUSE_COURSE_ID"];
			entity.OriginalEdStudExcuseCourseId = (System.Decimal)dataRow["ED_STUD_EXCUSE_COURSE_ID"];
			entity.EdStudExcuseId = (System.Decimal)dataRow["ED_STUD_EXCUSE_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.ReExamFlag = Convert.IsDBNull(dataRow["RE_EXAM_FLAG"]) ? null : (System.Decimal?)dataRow["RE_EXAM_FLAG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExcuseCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExcuseCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExcuseCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudExcuseIdSource	
			if (CanDeepLoad(entity, "EdStudExcuse|EdStudExcuseIdSource", deepLoadType, innerList) 
				&& entity.EdStudExcuseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudExcuseId;
				EdStudExcuse tmpEntity = EntityManager.LocateEntity<EdStudExcuse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudExcuse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudExcuseIdSource = tmpEntity;
				else
					entity.EdStudExcuseIdSource = DataRepository.EdStudExcuseProvider.GetByEdStudExcuseId(transactionManager, entity.EdStudExcuseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudExcuseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudExcuseProvider.DeepLoad(transactionManager, entity.EdStudExcuseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudExcuseIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExcuseCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExcuseCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExcuseCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExcuseCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudExcuseIdSource
			if (CanDeepSave(entity, "EdStudExcuse|EdStudExcuseIdSource", deepSaveType, innerList) 
				&& entity.EdStudExcuseIdSource != null)
			{
				DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseIdSource);
				entity.EdStudExcuseId = entity.EdStudExcuseIdSource.EdStudExcuseId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
	
	#region EdStudExcuseCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExcuseCourse</c>
	///</summary>
	public enum EdStudExcuseCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudExcuse</c> at EdStudExcuseIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudExcuse))]
		EdStudExcuse,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdStudExcuseCourseChildEntityTypes
	
	#region EdStudExcuseCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExcuseCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExcuseCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExcuseCourseFilterBuilder : SqlFilterBuilder<EdStudExcuseCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseFilterBuilder class.
		/// </summary>
		public EdStudExcuseCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExcuseCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExcuseCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExcuseCourseFilterBuilder
	
	#region EdStudExcuseCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExcuseCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExcuseCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExcuseCourseParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExcuseCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseParameterBuilder class.
		/// </summary>
		public EdStudExcuseCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExcuseCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExcuseCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExcuseCourseParameterBuilder
	
	#region EdStudExcuseCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExcuseCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExcuseCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExcuseCourseSortBuilder : SqlSortBuilder<EdStudExcuseCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExcuseCourseSqlSortBuilder class.
		/// </summary>
		public EdStudExcuseCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExcuseCourseSortBuilder
	
} // end namespace
