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
	/// This class is the base class for any <see cref="AccomRoomProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomRoomProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomRoom, UMIS_VER2.BusinessLyer.AccomRoomKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomRoomKey key)
		{
			return Delete(transactionManager, key.AccomRoomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomRoomId">الغرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomRoomId)
		{
			return Delete(null, _accomRoomId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomRoomId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		FK_ACCOM_ROOM_ACCOM_APARTMENT Description: 
		/// </summary>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomApartmentId(System.Decimal? _accomApartmentId)
		{
			int count = -1;
			return GetByAccomApartmentId(_accomApartmentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		FK_ACCOM_ROOM_ACCOM_APARTMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		/// <remarks></remarks>
		public TList<AccomRoom> GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal? _accomApartmentId)
		{
			int count = -1;
			return GetByAccomApartmentId(transactionManager, _accomApartmentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		FK_ACCOM_ROOM_ACCOM_APARTMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal? _accomApartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomApartmentId(transactionManager, _accomApartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		fkAccomRoomAccomApartment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomApartmentId(System.Decimal? _accomApartmentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomApartmentId(null, _accomApartmentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		fkAccomRoomAccomApartment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomApartmentId(System.Decimal? _accomApartmentId, int start, int pageLength,out int count)
		{
			return GetByAccomApartmentId(null, _accomApartmentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_APARTMENT key.
		///		FK_ACCOM_ROOM_ACCOM_APARTMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomApartmentId">الشقق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public abstract TList<AccomRoom> GetByAccomApartmentId(TransactionManager transactionManager, System.Decimal? _accomApartmentId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		FK_ACCOM_ROOM_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="_accomBuildingId">المباني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomBuildingId(System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(_accomBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		FK_ACCOM_ROOM_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		/// <remarks></remarks>
		public TList<AccomRoom> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		FK_ACCOM_ROOM_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBuildingId(transactionManager, _accomBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		fkAccomRoomAccomBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		fkAccomRoomAccomBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomBuildingId(System.Decimal _accomBuildingId, int start, int pageLength,out int count)
		{
			return GetByAccomBuildingId(null, _accomBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_BUILDING key.
		///		FK_ACCOM_ROOM_ACCOM_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBuildingId">المباني</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public abstract TList<AccomRoom> GetByAccomBuildingId(TransactionManager transactionManager, System.Decimal _accomBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(_accomCdeRoomTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		/// <remarks></remarks>
		public TList<AccomRoom> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		fkAccomRoomAccomCdeRoomType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		fkAccomRoomAccomCdeRoomType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public TList<AccomRoom> GetByAccomCdeRoomTypeId(System.Int32 _accomCdeRoomTypeId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_ROOM_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomRoom objects.</returns>
		public abstract TList<AccomRoom> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32 _accomCdeRoomTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomRoom Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomRoomKey key, int start, int pageLength)
		{
			return GetByAccomRoomId(transactionManager, key.AccomRoomId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="_accomRoomId">الغرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(null,_accomRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength, out int count)
		{
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_ROOM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomRoom GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomRoom&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomRoom&gt;"/></returns>
		public static TList<AccomRoom> Fill(IDataReader reader, TList<AccomRoom> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomRoom c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomRoom")
					.Append("|").Append((System.Decimal)reader["ACCOM_ROOM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomRoom>(
					key.ToString(), // EntityTrackingKey
					"AccomRoom",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomRoom();
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
					c.AccomRoomId = (System.Decimal)reader["ACCOM_ROOM_ID"];
					c.OriginalAccomRoomId = c.AccomRoomId;
					c.AccomBuildingId = (System.Decimal)reader["ACCOM_BUILDING_ID"];
					c.AccomApartmentId = Convert.IsDBNull(reader["ACCOM_APARTMENT_ID"]) ? null : (System.Decimal?)reader["ACCOM_APARTMENT_ID"];
					c.FloorNo = Convert.IsDBNull(reader["FLOOR_NO"]) ? null : (System.Int16?)reader["FLOOR_NO"];
					c.RoomCode = (System.String)reader["ROOM_CODE"];
					c.RoomAr = (System.String)reader["ROOM_AR"];
					c.RoomEn = Convert.IsDBNull(reader["ROOM_EN"]) ? null : (System.String)reader["ROOM_EN"];
					c.HostFlg = (System.Boolean)reader["HOST_FLG"];
					c.IsActive = (System.Boolean)reader["IS_ACTIVE"];
					c.AccomCdeRoomTypeId = (System.Int32)reader["ACCOM_CDE_ROOM_TYPE_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomRoom entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomRoomId = (System.Decimal)reader[((int)AccomRoomColumn.AccomRoomId - 1)];
			entity.OriginalAccomRoomId = (System.Decimal)reader["ACCOM_ROOM_ID"];
			entity.AccomBuildingId = (System.Decimal)reader[((int)AccomRoomColumn.AccomBuildingId - 1)];
			entity.AccomApartmentId = (reader.IsDBNull(((int)AccomRoomColumn.AccomApartmentId - 1)))?null:(System.Decimal?)reader[((int)AccomRoomColumn.AccomApartmentId - 1)];
			entity.FloorNo = (reader.IsDBNull(((int)AccomRoomColumn.FloorNo - 1)))?null:(System.Int16?)reader[((int)AccomRoomColumn.FloorNo - 1)];
			entity.RoomCode = (System.String)reader[((int)AccomRoomColumn.RoomCode - 1)];
			entity.RoomAr = (System.String)reader[((int)AccomRoomColumn.RoomAr - 1)];
			entity.RoomEn = (reader.IsDBNull(((int)AccomRoomColumn.RoomEn - 1)))?null:(System.String)reader[((int)AccomRoomColumn.RoomEn - 1)];
			entity.HostFlg = (System.Boolean)reader[((int)AccomRoomColumn.HostFlg - 1)];
			entity.IsActive = (System.Boolean)reader[((int)AccomRoomColumn.IsActive - 1)];
			entity.AccomCdeRoomTypeId = (System.Int32)reader[((int)AccomRoomColumn.AccomCdeRoomTypeId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomRoomColumn.Notes - 1)))?null:(System.String)reader[((int)AccomRoomColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomRoomColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomRoomColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomRoomColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomRoomColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomRoom entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomRoomId = (System.Decimal)dataRow["ACCOM_ROOM_ID"];
			entity.OriginalAccomRoomId = (System.Decimal)dataRow["ACCOM_ROOM_ID"];
			entity.AccomBuildingId = (System.Decimal)dataRow["ACCOM_BUILDING_ID"];
			entity.AccomApartmentId = Convert.IsDBNull(dataRow["ACCOM_APARTMENT_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_APARTMENT_ID"];
			entity.FloorNo = Convert.IsDBNull(dataRow["FLOOR_NO"]) ? null : (System.Int16?)dataRow["FLOOR_NO"];
			entity.RoomCode = (System.String)dataRow["ROOM_CODE"];
			entity.RoomAr = (System.String)dataRow["ROOM_AR"];
			entity.RoomEn = Convert.IsDBNull(dataRow["ROOM_EN"]) ? null : (System.String)dataRow["ROOM_EN"];
			entity.HostFlg = (System.Boolean)dataRow["HOST_FLG"];
			entity.IsActive = (System.Boolean)dataRow["IS_ACTIVE"];
			entity.AccomCdeRoomTypeId = (System.Int32)dataRow["ACCOM_CDE_ROOM_TYPE_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomRoom"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomRoom Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomRoom entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomApartmentIdSource	
			if (CanDeepLoad(entity, "AccomApartment|AccomApartmentIdSource", deepLoadType, innerList) 
				&& entity.AccomApartmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomApartmentId ?? 0.0m);
				AccomApartment tmpEntity = EntityManager.LocateEntity<AccomApartment>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomApartment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomApartmentIdSource = tmpEntity;
				else
					entity.AccomApartmentIdSource = DataRepository.AccomApartmentProvider.GetByAccomApartmentId(transactionManager, (entity.AccomApartmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomApartmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomApartmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomApartmentProvider.DeepLoad(transactionManager, entity.AccomApartmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomApartmentIdSource

			#region AccomBuildingIdSource	
			if (CanDeepLoad(entity, "AccomBuilding|AccomBuildingIdSource", deepLoadType, innerList) 
				&& entity.AccomBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomBuildingId;
				AccomBuilding tmpEntity = EntityManager.LocateEntity<AccomBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomBuildingIdSource = tmpEntity;
				else
					entity.AccomBuildingIdSource = DataRepository.AccomBuildingProvider.GetByAccomBuildingId(transactionManager, entity.AccomBuildingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomBuildingProvider.DeepLoad(transactionManager, entity.AccomBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomBuildingIdSource

			#region AccomCdeRoomTypeIdSource	
			if (CanDeepLoad(entity, "AccomCdeRoomType|AccomCdeRoomTypeIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeRoomTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomCdeRoomTypeId;
				AccomCdeRoomType tmpEntity = EntityManager.LocateEntity<AccomCdeRoomType>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeRoomType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeRoomTypeIdSource = tmpEntity;
				else
					entity.AccomCdeRoomTypeIdSource = DataRepository.AccomCdeRoomTypeProvider.GetByAccomCdeRoomTypeId(transactionManager, entity.AccomCdeRoomTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeRoomTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeRoomTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeRoomTypeProvider.DeepLoad(transactionManager, entity.AccomCdeRoomTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeRoomTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomRoomId methods when available
			
			#region AccomBedCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomBed>|AccomBedCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBedCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomBedCollection = DataRepository.AccomBedProvider.GetByAccomRoomId(transactionManager, entity.AccomRoomId);

				if (deep && entity.AccomBedCollection.Count > 0)
				{
					deepHandles.Add("AccomBedCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomBed>) DataRepository.AccomBedProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomBedCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByAccomRoomId(transactionManager, entity.AccomRoomId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudGuestReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqDtlCollection = DataRepository.AccomStudGuestReqDtlProvider.GetByAccomRoomId(transactionManager, entity.AccomRoomId);

				if (deep && entity.AccomStudGuestReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReqDtl>) DataRepository.AccomStudGuestReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomRoom object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomRoom instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomRoom Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomRoom entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomApartmentIdSource
			if (CanDeepSave(entity, "AccomApartment|AccomApartmentIdSource", deepSaveType, innerList) 
				&& entity.AccomApartmentIdSource != null)
			{
				DataRepository.AccomApartmentProvider.Save(transactionManager, entity.AccomApartmentIdSource);
				entity.AccomApartmentId = entity.AccomApartmentIdSource.AccomApartmentId;
			}
			#endregion 
			
			#region AccomBuildingIdSource
			if (CanDeepSave(entity, "AccomBuilding|AccomBuildingIdSource", deepSaveType, innerList) 
				&& entity.AccomBuildingIdSource != null)
			{
				DataRepository.AccomBuildingProvider.Save(transactionManager, entity.AccomBuildingIdSource);
				entity.AccomBuildingId = entity.AccomBuildingIdSource.AccomBuildingId;
			}
			#endregion 
			
			#region AccomCdeRoomTypeIdSource
			if (CanDeepSave(entity, "AccomCdeRoomType|AccomCdeRoomTypeIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeRoomTypeIdSource != null)
			{
				DataRepository.AccomCdeRoomTypeProvider.Save(transactionManager, entity.AccomCdeRoomTypeIdSource);
				entity.AccomCdeRoomTypeId = entity.AccomCdeRoomTypeIdSource.AccomCdeRoomTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomBed>
				if (CanDeepSave(entity.AccomBedCollection, "List<AccomBed>|AccomBedCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomBed child in entity.AccomBedCollection)
					{
						if(child.AccomRoomIdSource != null)
						{
							child.AccomRoomId = child.AccomRoomIdSource.AccomRoomId;
						}
						else
						{
							child.AccomRoomId = entity.AccomRoomId;
						}

					}

					if (entity.AccomBedCollection.Count > 0 || entity.AccomBedCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomBedProvider.Save(transactionManager, entity.AccomBedCollection);
						
						deepHandles.Add("AccomBedCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomBed >) DataRepository.AccomBedProvider.DeepSave,
							new object[] { transactionManager, entity.AccomBedCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.AccomRoomIdSource != null)
						{
							child.AccomRoomId = child.AccomRoomIdSource.AccomRoomId;
						}
						else
						{
							child.AccomRoomId = entity.AccomRoomId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudGuestReqDtl>
				if (CanDeepSave(entity.AccomStudGuestReqDtlCollection, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReqDtl child in entity.AccomStudGuestReqDtlCollection)
					{
						if(child.AccomRoomIdSource != null)
						{
							child.AccomRoomId = child.AccomRoomIdSource.AccomRoomId;
						}
						else
						{
							child.AccomRoomId = entity.AccomRoomId;
						}

					}

					if (entity.AccomStudGuestReqDtlCollection.Count > 0 || entity.AccomStudGuestReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqDtlProvider.Save(transactionManager, entity.AccomStudGuestReqDtlCollection);
						
						deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReqDtl >) DataRepository.AccomStudGuestReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomRoomChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomRoom</c>
	///</summary>
	public enum AccomRoomChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomApartment</c> at AccomApartmentIdSource
		///</summary>
		[ChildEntityType(typeof(AccomApartment))]
		AccomApartment,
		
		///<summary>
		/// Composite Property for <c>AccomBuilding</c> at AccomBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(AccomBuilding))]
		AccomBuilding,
		
		///<summary>
		/// Composite Property for <c>AccomCdeRoomType</c> at AccomCdeRoomTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeRoomType))]
		AccomCdeRoomType,
		///<summary>
		/// Collection of <c>AccomRoom</c> as OneToMany for AccomBedCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomBed>))]
		AccomBedCollection,
		///<summary>
		/// Collection of <c>AccomRoom</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
		///<summary>
		/// Collection of <c>AccomRoom</c> as OneToMany for AccomStudGuestReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReqDtl>))]
		AccomStudGuestReqDtlCollection,
	}
	
	#endregion AccomRoomChildEntityTypes
	
	#region AccomRoomFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomRoom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomRoomFilterBuilder : SqlFilterBuilder<AccomRoomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomRoomFilterBuilder class.
		/// </summary>
		public AccomRoomFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomRoomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomRoomFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomRoomFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomRoomFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomRoomFilterBuilder
	
	#region AccomRoomParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomRoom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomRoomParameterBuilder : ParameterizedSqlFilterBuilder<AccomRoomColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomRoomParameterBuilder class.
		/// </summary>
		public AccomRoomParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomRoomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomRoomParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomRoomParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomRoomParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomRoomParameterBuilder
	
	#region AccomRoomSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomRoomColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomRoom"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomRoomSortBuilder : SqlSortBuilder<AccomRoomColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomRoomSqlSortBuilder class.
		/// </summary>
		public AccomRoomSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomRoomSortBuilder
	
} // end namespace
