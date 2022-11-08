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
	/// This class is the base class for any <see cref="CoExamCommitteeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamCommitteeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamCommittee, UMIS_VER2.BusinessLyer.CoExamCommitteeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommitteeKey key)
		{
			return Delete(transactionManager, key.CoExamCommitteeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamCommitteeId">لجان الامتحان. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamCommitteeId)
		{
			return Delete(null, _coExamCommitteeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamCommitteeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		FK_CO_EXAM_COMMITTEE_CO_CONTROL Description: 
		/// </summary>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByCoControlId(System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(_coControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		FK_CO_EXAM_COMMITTEE_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamCommittee> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		FK_CO_EXAM_COMMITTEE_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		fkCoExamCommitteeCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlId(null, _coControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		fkCoExamCommitteeCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength,out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_CO_CONTROL key.
		///		FK_CO_EXAM_COMMITTEE_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">XXcurrently NULL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public abstract TList<CoExamCommittee> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		FK_CO_EXAM_COMMITTEE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		FK_CO_EXAM_COMMITTEE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamCommittee> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		FK_CO_EXAM_COMMITTEE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		fkCoExamCommitteeScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		fkCoExamCommitteeScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_BUILDING key.
		///		FK_CO_EXAM_COMMITTEE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public abstract TList<CoExamCommittee> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		FK_CO_EXAM_COMMITTEE_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		FK_CO_EXAM_COMMITTEE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamCommittee> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		FK_CO_EXAM_COMMITTEE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		fkCoExamCommitteeScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		fkCoExamCommitteeScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public TList<CoExamCommittee> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMMITTEE_SC_HALL key.
		///		FK_CO_EXAM_COMMITTEE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamCommittee objects.</returns>
		public abstract TList<CoExamCommittee> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoExamCommittee Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommitteeKey key, int start, int pageLength)
		{
			return GetByCoExamCommitteeId(transactionManager, key.CoExamCommitteeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(System.Decimal _coExamCommitteeId)
		{
			int count = -1;
			return GetByCoExamCommitteeId(null,_coExamCommitteeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(System.Decimal _coExamCommitteeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommitteeId(null, _coExamCommitteeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal _coExamCommitteeId)
		{
			int count = -1;
			return GetByCoExamCommitteeId(transactionManager, _coExamCommitteeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal _coExamCommitteeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommitteeId(transactionManager, _coExamCommitteeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(System.Decimal _coExamCommitteeId, int start, int pageLength, out int count)
		{
			return GetByCoExamCommitteeId(null, _coExamCommitteeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMMITTEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamCommittee GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal _coExamCommitteeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamCommittee&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamCommittee&gt;"/></returns>
		public static TList<CoExamCommittee> Fill(IDataReader reader, TList<CoExamCommittee> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamCommittee c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamCommittee")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_COMMITTEE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamCommittee>(
					key.ToString(), // EntityTrackingKey
					"CoExamCommittee",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamCommittee();
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
					c.CoExamCommitteeId = (System.Decimal)reader["CO_EXAM_COMMITTEE_ID"];
					c.OriginalCoExamCommitteeId = c.CoExamCommitteeId;
					c.CoControlId = Convert.IsDBNull(reader["CO_CONTROL_ID"]) ? null : (System.Decimal?)reader["CO_CONTROL_ID"];
					c.CommNameAr = Convert.IsDBNull(reader["COMM_NAME_AR"]) ? null : (System.String)reader["COMM_NAME_AR"];
					c.CommNameEn = Convert.IsDBNull(reader["COMM_NAME_EN"]) ? null : (System.String)reader["COMM_NAME_EN"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.Capacity = Convert.IsDBNull(reader["CAPACITY"]) ? null : (System.Decimal?)reader["CAPACITY"];
					c.SeatNumFrom = Convert.IsDBNull(reader["SEAT_NUM_FROM"]) ? null : (System.String)reader["SEAT_NUM_FROM"];
					c.SeatNumTo = Convert.IsDBNull(reader["SEAT_NUM_TO"]) ? null : (System.String)reader["SEAT_NUM_TO"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamCommittee entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamCommitteeId = (System.Decimal)reader[((int)CoExamCommitteeColumn.CoExamCommitteeId - 1)];
			entity.OriginalCoExamCommitteeId = (System.Decimal)reader["CO_EXAM_COMMITTEE_ID"];
			entity.CoControlId = (reader.IsDBNull(((int)CoExamCommitteeColumn.CoControlId - 1)))?null:(System.Decimal?)reader[((int)CoExamCommitteeColumn.CoControlId - 1)];
			entity.CommNameAr = (reader.IsDBNull(((int)CoExamCommitteeColumn.CommNameAr - 1)))?null:(System.String)reader[((int)CoExamCommitteeColumn.CommNameAr - 1)];
			entity.CommNameEn = (reader.IsDBNull(((int)CoExamCommitteeColumn.CommNameEn - 1)))?null:(System.String)reader[((int)CoExamCommitteeColumn.CommNameEn - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoExamCommitteeColumn.Notes - 1)))?null:(System.String)reader[((int)CoExamCommitteeColumn.Notes - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)CoExamCommitteeColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)CoExamCommitteeColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)CoExamCommitteeColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)CoExamCommitteeColumn.ScHallId - 1)];
			entity.Capacity = (reader.IsDBNull(((int)CoExamCommitteeColumn.Capacity - 1)))?null:(System.Decimal?)reader[((int)CoExamCommitteeColumn.Capacity - 1)];
			entity.SeatNumFrom = (reader.IsDBNull(((int)CoExamCommitteeColumn.SeatNumFrom - 1)))?null:(System.String)reader[((int)CoExamCommitteeColumn.SeatNumFrom - 1)];
			entity.SeatNumTo = (reader.IsDBNull(((int)CoExamCommitteeColumn.SeatNumTo - 1)))?null:(System.String)reader[((int)CoExamCommitteeColumn.SeatNumTo - 1)];
			entity.IsActive = (System.Decimal)reader[((int)CoExamCommitteeColumn.IsActive - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)CoExamCommitteeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)CoExamCommitteeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)CoExamCommitteeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)CoExamCommitteeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamCommittee entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamCommitteeId = (System.Decimal)dataRow["CO_EXAM_COMMITTEE_ID"];
			entity.OriginalCoExamCommitteeId = (System.Decimal)dataRow["CO_EXAM_COMMITTEE_ID"];
			entity.CoControlId = Convert.IsDBNull(dataRow["CO_CONTROL_ID"]) ? null : (System.Decimal?)dataRow["CO_CONTROL_ID"];
			entity.CommNameAr = Convert.IsDBNull(dataRow["COMM_NAME_AR"]) ? null : (System.String)dataRow["COMM_NAME_AR"];
			entity.CommNameEn = Convert.IsDBNull(dataRow["COMM_NAME_EN"]) ? null : (System.String)dataRow["COMM_NAME_EN"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.Capacity = Convert.IsDBNull(dataRow["CAPACITY"]) ? null : (System.Decimal?)dataRow["CAPACITY"];
			entity.SeatNumFrom = Convert.IsDBNull(dataRow["SEAT_NUM_FROM"]) ? null : (System.String)dataRow["SEAT_NUM_FROM"];
			entity.SeatNumTo = Convert.IsDBNull(dataRow["SEAT_NUM_TO"]) ? null : (System.String)dataRow["SEAT_NUM_TO"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamCommittee"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommittee Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommittee entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CoControlId ?? 0.0m);
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, (entity.CoControlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlProvider.DeepLoad(transactionManager, entity.CoControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlIdSource

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoExamCommitteeId methods when available
			
			#region CoExamSchdlPlaceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamSchdlPlaceCollection = DataRepository.CoExamSchdlPlaceProvider.GetByCoExamCommitteeId(transactionManager, entity.CoExamCommitteeId);

				if (deep && entity.CoExamSchdlPlaceCollection.Count > 0)
				{
					deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamSchdlPlace>) DataRepository.CoExamSchdlPlaceProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamCommittee object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamCommittee instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamCommittee Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamCommittee entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlIdSource
			if (CanDeepSave(entity, "CoControl|CoControlIdSource", deepSaveType, innerList) 
				&& entity.CoControlIdSource != null)
			{
				DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlIdSource);
				entity.CoControlId = entity.CoControlIdSource.CoControlId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoExamSchdlPlace>
				if (CanDeepSave(entity.CoExamSchdlPlaceCollection, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamSchdlPlace child in entity.CoExamSchdlPlaceCollection)
					{
						if(child.CoExamCommitteeIdSource != null)
						{
							child.CoExamCommitteeId = child.CoExamCommitteeIdSource.CoExamCommitteeId;
						}
						else
						{
							child.CoExamCommitteeId = entity.CoExamCommitteeId;
						}

					}

					if (entity.CoExamSchdlPlaceCollection.Count > 0 || entity.CoExamSchdlPlaceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceCollection);
						
						deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamSchdlPlace >) DataRepository.CoExamSchdlPlaceProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deepSaveType, childTypes, innerList }
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
	
	#region CoExamCommitteeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamCommittee</c>
	///</summary>
	public enum CoExamCommitteeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		///<summary>
		/// Collection of <c>CoExamCommittee</c> as OneToMany for CoExamSchdlPlaceCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamSchdlPlace>))]
		CoExamSchdlPlaceCollection,
	}
	
	#endregion CoExamCommitteeChildEntityTypes
	
	#region CoExamCommitteeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamCommitteeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommittee"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommitteeFilterBuilder : SqlFilterBuilder<CoExamCommitteeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeFilterBuilder class.
		/// </summary>
		public CoExamCommitteeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommitteeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommitteeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommitteeFilterBuilder
	
	#region CoExamCommitteeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamCommitteeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommittee"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamCommitteeParameterBuilder : ParameterizedSqlFilterBuilder<CoExamCommitteeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeParameterBuilder class.
		/// </summary>
		public CoExamCommitteeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamCommitteeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamCommitteeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamCommitteeParameterBuilder
	
	#region CoExamCommitteeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamCommitteeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamCommittee"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamCommitteeSortBuilder : SqlSortBuilder<CoExamCommitteeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeSqlSortBuilder class.
		/// </summary>
		public CoExamCommitteeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamCommitteeSortBuilder
	
} // end namespace
