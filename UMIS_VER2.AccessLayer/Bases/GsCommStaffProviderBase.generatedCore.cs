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
	/// This class is the base class for any <see cref="GsCommStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCommStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCommStaff, UMIS_VER2.BusinessLyer.GsCommStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommStaffKey key)
		{
			return Delete(transactionManager, key.GsCommStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCommStaffId">أعضاء اللجنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCommStaffId)
		{
			return Delete(null, _gsCommStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCommStaffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		FK_GS_COMM_STAFF_GS_COMM Description: 
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetByGsCommId(System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(_gsCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		FK_GS_COMM_STAFF_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		/// <remarks></remarks>
		public TList<GsCommStaff> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		FK_GS_COMM_STAFF_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommId(transactionManager, _gsCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		fkGsCommStaffGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCommId(null, _gsCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		fkGsCommStaffGsComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCommId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetByGsCommId(System.Decimal _gsCommId, int start, int pageLength,out int count)
		{
			return GetByGsCommId(null, _gsCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_GS_COMM key.
		///		FK_GS_COMM_STAFF_GS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public abstract TList<GsCommStaff> GetByGsCommId(TransactionManager transactionManager, System.Decimal _gsCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		FK_GS_COMM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		FK_GS_COMM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		/// <remarks></remarks>
		public TList<GsCommStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		FK_GS_COMM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		fkGsCommStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		fkGsCommStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public TList<GsCommStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COMM_STAFF_SA_STF_MEMBER key.
		///		FK_GS_COMM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCommStaff objects.</returns>
		public abstract TList<GsCommStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCommStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommStaffKey key, int start, int pageLength)
		{
			return GetByGsCommStaffId(transactionManager, key.GsCommStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByGsCommStaffId(null,_gsCommStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommStaffId(null, _gsCommStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId)
		{
			int count = -1;
			return GetByGsCommStaffId(transactionManager, _gsCommStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommStaffId(transactionManager, _gsCommStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(System.Decimal _gsCommStaffId, int start, int pageLength, out int count)
		{
			return GetByGsCommStaffId(null, _gsCommStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommStaffId">أعضاء اللجنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCommStaff GetByGsCommStaffId(TransactionManager transactionManager, System.Decimal _gsCommStaffId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public TList<GsCommStaff> GetByGsCommIdSaStfMemberId(System.Decimal _gsCommId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByGsCommIdSaStfMemberId(null,_gsCommId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public TList<GsCommStaff> GetByGsCommIdSaStfMemberId(System.Decimal _gsCommId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommIdSaStfMemberId(null, _gsCommId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public TList<GsCommStaff> GetByGsCommIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _gsCommId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByGsCommIdSaStfMemberId(transactionManager, _gsCommId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public TList<GsCommStaff> GetByGsCommIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _gsCommId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCommIdSaStfMemberId(transactionManager, _gsCommId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public TList<GsCommStaff> GetByGsCommIdSaStfMemberId(System.Decimal _gsCommId, System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetByGsCommIdSaStfMemberId(null, _gsCommId, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COMM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCommId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCommStaff&gt;"/> class.</returns>
		public abstract TList<GsCommStaff> GetByGsCommIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _gsCommId, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCommStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCommStaff&gt;"/></returns>
		public static TList<GsCommStaff> Fill(IDataReader reader, TList<GsCommStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCommStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCommStaff")
					.Append("|").Append((System.Decimal)reader["GS_COMM_STAFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCommStaff>(
					key.ToString(), // EntityTrackingKey
					"GsCommStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCommStaff();
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
					c.GsCommStaffId = (System.Decimal)reader["GS_COMM_STAFF_ID"];
					c.OriginalGsCommStaffId = c.GsCommStaffId;
					c.GsCommId = (System.Decimal)reader["GS_COMM_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.StaffRoll = (System.Decimal)reader["STAFF_ROLL"];
					c.ActiveFlg = Convert.IsDBNull(reader["ACTIVE_FLG"]) ? null : (System.Boolean?)reader["ACTIVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCommStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCommStaffId = (System.Decimal)reader[((int)GsCommStaffColumn.GsCommStaffId - 1)];
			entity.OriginalGsCommStaffId = (System.Decimal)reader["GS_COMM_STAFF_ID"];
			entity.GsCommId = (System.Decimal)reader[((int)GsCommStaffColumn.GsCommId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)GsCommStaffColumn.SaStfMemberId - 1)];
			entity.StaffRoll = (System.Decimal)reader[((int)GsCommStaffColumn.StaffRoll - 1)];
			entity.ActiveFlg = (reader.IsDBNull(((int)GsCommStaffColumn.ActiveFlg - 1)))?null:(System.Boolean?)reader[((int)GsCommStaffColumn.ActiveFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)GsCommStaffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)GsCommStaffColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)GsCommStaffColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)GsCommStaffColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCommStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCommStaffId = (System.Decimal)dataRow["GS_COMM_STAFF_ID"];
			entity.OriginalGsCommStaffId = (System.Decimal)dataRow["GS_COMM_STAFF_ID"];
			entity.GsCommId = (System.Decimal)dataRow["GS_COMM_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.StaffRoll = (System.Decimal)dataRow["STAFF_ROLL"];
			entity.ActiveFlg = Convert.IsDBNull(dataRow["ACTIVE_FLG"]) ? null : (System.Boolean?)dataRow["ACTIVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCommStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCommIdSource	
			if (CanDeepLoad(entity, "GsComm|GsCommIdSource", deepLoadType, innerList) 
				&& entity.GsCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCommId;
				GsComm tmpEntity = EntityManager.LocateEntity<GsComm>(EntityLocator.ConstructKeyFromPkItems(typeof(GsComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCommIdSource = tmpEntity;
				else
					entity.GsCommIdSource = DataRepository.GsCommProvider.GetByGsCommId(transactionManager, entity.GsCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCommProvider.DeepLoad(transactionManager, entity.GsCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCommIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCommStaffId methods when available
			
			#region RsrchCommStaffRecomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchCommStaffRecom>|RsrchCommStaffRecomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchCommStaffRecomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchCommStaffRecomCollection = DataRepository.RsrchCommStaffRecomProvider.GetByGsCommStaffId(transactionManager, entity.GsCommStaffId);

				if (deep && entity.RsrchCommStaffRecomCollection.Count > 0)
				{
					deepHandles.Add("RsrchCommStaffRecomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchCommStaffRecom>) DataRepository.RsrchCommStaffRecomProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchCommStaffRecomCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCommStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCommStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCommStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCommStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCommIdSource
			if (CanDeepSave(entity, "GsComm|GsCommIdSource", deepSaveType, innerList) 
				&& entity.GsCommIdSource != null)
			{
				DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommIdSource);
				entity.GsCommId = entity.GsCommIdSource.GsCommId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<RsrchCommStaffRecom>
				if (CanDeepSave(entity.RsrchCommStaffRecomCollection, "List<RsrchCommStaffRecom>|RsrchCommStaffRecomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchCommStaffRecom child in entity.RsrchCommStaffRecomCollection)
					{
						if(child.GsCommStaffIdSource != null)
						{
							child.GsCommStaffId = child.GsCommStaffIdSource.GsCommStaffId;
						}
						else
						{
							child.GsCommStaffId = entity.GsCommStaffId;
						}

					}

					if (entity.RsrchCommStaffRecomCollection.Count > 0 || entity.RsrchCommStaffRecomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchCommStaffRecomProvider.Save(transactionManager, entity.RsrchCommStaffRecomCollection);
						
						deepHandles.Add("RsrchCommStaffRecomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchCommStaffRecom >) DataRepository.RsrchCommStaffRecomProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchCommStaffRecomCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCommStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCommStaff</c>
	///</summary>
	public enum GsCommStaffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsComm</c> at GsCommIdSource
		///</summary>
		[ChildEntityType(typeof(GsComm))]
		GsComm,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>GsCommStaff</c> as OneToMany for RsrchCommStaffRecomCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchCommStaffRecom>))]
		RsrchCommStaffRecomCollection,
	}
	
	#endregion GsCommStaffChildEntityTypes
	
	#region GsCommStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCommStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommStaffFilterBuilder : SqlFilterBuilder<GsCommStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommStaffFilterBuilder class.
		/// </summary>
		public GsCommStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommStaffFilterBuilder
	
	#region GsCommStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCommStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCommStaffParameterBuilder : ParameterizedSqlFilterBuilder<GsCommStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommStaffParameterBuilder class.
		/// </summary>
		public GsCommStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCommStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCommStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCommStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCommStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCommStaffParameterBuilder
	
	#region GsCommStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCommStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCommStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCommStaffSortBuilder : SqlSortBuilder<GsCommStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCommStaffSqlSortBuilder class.
		/// </summary>
		public GsCommStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCommStaffSortBuilder
	
} // end namespace
