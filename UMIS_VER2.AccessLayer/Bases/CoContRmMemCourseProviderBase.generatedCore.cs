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
	/// This class is the base class for any <see cref="CoContRmMemCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoContRmMemCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoContRmMemCourse, UMIS_VER2.BusinessLyer.CoContRmMemCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRmMemCourseKey key)
		{
			return Delete(transactionManager, key.CoContRmMemCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coContRmMemCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coContRmMemCourseId)
		{
			return Delete(null, _coContRmMemCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRmMemCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coContRmMemCourseId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoContRmMemCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRmMemCourseKey key, int start, int pageLength)
		{
			return GetByCoContRmMemCourseId(transactionManager, key.CoContRmMemCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId)
		{
			int count = -1;
			return GetByCoContRoomMemberId(null,_coContRoomMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberId(null, _coContRoomMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId)
		{
			int count = -1;
			return GetByCoContRoomMemberId(transactionManager, _coContRoomMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberId(transactionManager, _coContRoomMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId, int start, int pageLength, out int count)
		{
			return GetByCoContRoomMemberId(null, _coContRoomMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONT_ROOM_MEMBER__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public abstract TList<CoContRmMemCourse> GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByEdCourseId(System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public TList<CoContRmMemCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRmMemCourse&gt;"/> class.</returns>
		public abstract TList<CoContRmMemCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="_coContRmMemCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(System.Decimal _coContRmMemCourseId)
		{
			int count = -1;
			return GetByCoContRmMemCourseId(null,_coContRmMemCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="_coContRmMemCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(System.Decimal _coContRmMemCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRmMemCourseId(null, _coContRmMemCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRmMemCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(TransactionManager transactionManager, System.Decimal _coContRmMemCourseId)
		{
			int count = -1;
			return GetByCoContRmMemCourseId(transactionManager, _coContRmMemCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRmMemCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(TransactionManager transactionManager, System.Decimal _coContRmMemCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRmMemCourseId(transactionManager, _coContRmMemCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="_coContRmMemCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(System.Decimal _coContRmMemCourseId, int start, int pageLength, out int count)
		{
			return GetByCoContRmMemCourseId(null, _coContRmMemCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_RM_MEM_SCR_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRmMemCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRmMemCourseId(TransactionManager transactionManager, System.Decimal _coContRmMemCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(System.Decimal _coContRoomMemberId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByCoContRoomMemberIdEdCourseId(null,_coContRoomMemberId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(System.Decimal _coContRoomMemberId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberIdEdCourseId(null, _coContRoomMemberId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByCoContRoomMemberIdEdCourseId(transactionManager, _coContRoomMemberId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberIdEdCourseId(transactionManager, _coContRoomMemberId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(System.Decimal _coContRoomMemberId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByCoContRoomMemberIdEdCourseId(null, _coContRoomMemberId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_RM_MEM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoContRmMemCourse GetByCoContRoomMemberIdEdCourseId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoContRmMemCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoContRmMemCourse&gt;"/></returns>
		public static TList<CoContRmMemCourse> Fill(IDataReader reader, TList<CoContRmMemCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoContRmMemCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoContRmMemCourse")
					.Append("|").Append((System.Decimal)reader["CO_CONT_RM_MEM_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoContRmMemCourse>(
					key.ToString(), // EntityTrackingKey
					"CoContRmMemCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoContRmMemCourse();
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
					c.CoContRmMemCourseId = (System.Decimal)reader["CO_CONT_RM_MEM_COURSE_ID"];
					c.OriginalCoContRmMemCourseId = c.CoContRmMemCourseId;
					c.CoContRoomMemberId = (System.Decimal)reader["CO_CONT_ROOM_MEMBER_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoContRmMemCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.CoContRmMemCourseId = (System.Decimal)reader[((int)CoContRmMemCourseColumn.CoContRmMemCourseId - 1)];
			entity.OriginalCoContRmMemCourseId = (System.Decimal)reader["CO_CONT_RM_MEM_COURSE_ID"];
			entity.CoContRoomMemberId = (System.Decimal)reader[((int)CoContRmMemCourseColumn.CoContRoomMemberId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)CoContRmMemCourseColumn.EdCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoContRmMemCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoContRmMemCourseId = (System.Decimal)dataRow["CO_CONT_RM_MEM_COURSE_ID"];
			entity.OriginalCoContRmMemCourseId = (System.Decimal)dataRow["CO_CONT_RM_MEM_COURSE_ID"];
			entity.CoContRoomMemberId = (System.Decimal)dataRow["CO_CONT_ROOM_MEMBER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRmMemCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoContRmMemCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRmMemCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoContRoomMemberIdSource	
			if (CanDeepLoad(entity, "CoContRoomMember|CoContRoomMemberIdSource", deepLoadType, innerList) 
				&& entity.CoContRoomMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoContRoomMemberId;
				CoContRoomMember tmpEntity = EntityManager.LocateEntity<CoContRoomMember>(EntityLocator.ConstructKeyFromPkItems(typeof(CoContRoomMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoContRoomMemberIdSource = tmpEntity;
				else
					entity.CoContRoomMemberIdSource = DataRepository.CoContRoomMemberProvider.GetByCoContRoomMemberId(transactionManager, entity.CoContRoomMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRoomMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoContRoomMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoContRoomMemberProvider.DeepLoad(transactionManager, entity.CoContRoomMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoContRoomMemberIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoContRmMemCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoContRmMemCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoContRmMemCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRmMemCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoContRoomMemberIdSource
			if (CanDeepSave(entity, "CoContRoomMember|CoContRoomMemberIdSource", deepSaveType, innerList) 
				&& entity.CoContRoomMemberIdSource != null)
			{
				DataRepository.CoContRoomMemberProvider.Save(transactionManager, entity.CoContRoomMemberIdSource);
				entity.CoContRoomMemberId = entity.CoContRoomMemberIdSource.CoContRoomMemberId;
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
	
	#region CoContRmMemCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoContRmMemCourse</c>
	///</summary>
	public enum CoContRmMemCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoContRoomMember</c> at CoContRoomMemberIdSource
		///</summary>
		[ChildEntityType(typeof(CoContRoomMember))]
		CoContRoomMember,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion CoContRmMemCourseChildEntityTypes
	
	#region CoContRmMemCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoContRmMemCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRmMemCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoContRmMemCourseFilterBuilder : SqlFilterBuilder<CoContRmMemCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseFilterBuilder class.
		/// </summary>
		public CoContRmMemCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoContRmMemCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoContRmMemCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoContRmMemCourseFilterBuilder
	
	#region CoContRmMemCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoContRmMemCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRmMemCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoContRmMemCourseParameterBuilder : ParameterizedSqlFilterBuilder<CoContRmMemCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseParameterBuilder class.
		/// </summary>
		public CoContRmMemCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoContRmMemCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoContRmMemCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoContRmMemCourseParameterBuilder
	
	#region CoContRmMemCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoContRmMemCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRmMemCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoContRmMemCourseSortBuilder : SqlSortBuilder<CoContRmMemCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRmMemCourseSqlSortBuilder class.
		/// </summary>
		public CoContRmMemCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoContRmMemCourseSortBuilder
	
} // end namespace
