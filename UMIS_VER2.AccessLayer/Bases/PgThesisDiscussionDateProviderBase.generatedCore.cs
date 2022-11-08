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
	/// This class is the base class for any <see cref="PgThesisDiscussionDateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisDiscussionDateProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisDiscussionDate, UMIS_VER2.BusinessLyer.PgThesisDiscussionDateKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDiscussionDateKey key)
		{
			return Delete(transactionManager, key.PgThesisDiscussionDateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisDiscussionDateId)
		{
			return Delete(null, _pgThesisDiscussionDateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisDiscussionDateId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisDiscussionDate> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		fkPgThesisDiscussionDatePgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		fkPgThesisDiscussionDatePgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_DISCUSSION_DATE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public abstract TList<PgThesisDiscussionDate> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisDiscussionDate> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		fkPgThesisDiscussionDateScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		fkPgThesisDiscussionDateScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">مبنى المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public abstract TList<PgThesisDiscussionDate> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisDiscussionDate> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		fkPgThesisDiscussionDateScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		fkPgThesisDiscussionDateScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public TList<PgThesisDiscussionDate> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_DISCUSSION_DATE_SC_HALL key.
		///		FK_PG_THESIS_DISCUSSION_DATE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">قاعة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisDiscussionDate objects.</returns>
		public abstract TList<PgThesisDiscussionDate> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisDiscussionDate Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDiscussionDateKey key, int start, int pageLength)
		{
			return GetByPgThesisDiscussionDateId(transactionManager, key.PgThesisDiscussionDateId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(System.Decimal _pgThesisDiscussionDateId)
		{
			int count = -1;
			return GetByPgThesisDiscussionDateId(null,_pgThesisDiscussionDateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(System.Decimal _pgThesisDiscussionDateId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDiscussionDateId(null, _pgThesisDiscussionDateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(TransactionManager transactionManager, System.Decimal _pgThesisDiscussionDateId)
		{
			int count = -1;
			return GetByPgThesisDiscussionDateId(transactionManager, _pgThesisDiscussionDateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(TransactionManager transactionManager, System.Decimal _pgThesisDiscussionDateId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisDiscussionDateId(transactionManager, _pgThesisDiscussionDateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(System.Decimal _pgThesisDiscussionDateId, int start, int pageLength, out int count)
		{
			return GetByPgThesisDiscussionDateId(null, _pgThesisDiscussionDateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_DISCUSSION_DATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisDiscussionDateId">تحديد  ميعاد المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisDiscussionDate GetByPgThesisDiscussionDateId(TransactionManager transactionManager, System.Decimal _pgThesisDiscussionDateId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisDiscussionDate&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisDiscussionDate&gt;"/></returns>
		public static TList<PgThesisDiscussionDate> Fill(IDataReader reader, TList<PgThesisDiscussionDate> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisDiscussionDate c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisDiscussionDate")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_DISCUSSION_DATE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisDiscussionDate>(
					key.ToString(), // EntityTrackingKey
					"PgThesisDiscussionDate",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisDiscussionDate();
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
					c.PgThesisDiscussionDateId = (System.Decimal)reader["PG_THESIS_DISCUSSION_DATE_ID"];
					c.OriginalPgThesisDiscussionDateId = c.PgThesisDiscussionDateId;
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.DiscussionDate = Convert.IsDBNull(reader["DISCUSSION_DATE"]) ? null : (System.DateTime?)reader["DISCUSSION_DATE"];
					c.TimeFrom = Convert.IsDBNull(reader["TIME_FROM"]) ? null : (System.DateTime?)reader["TIME_FROM"];
					c.TimeTo = Convert.IsDBNull(reader["TIME_TO"]) ? null : (System.DateTime?)reader["TIME_TO"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisDiscussionDate entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisDiscussionDateId = (System.Decimal)reader[((int)PgThesisDiscussionDateColumn.PgThesisDiscussionDateId - 1)];
			entity.OriginalPgThesisDiscussionDateId = (System.Decimal)reader["PG_THESIS_DISCUSSION_DATE_ID"];
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisDiscussionDateColumn.PgThesisCommId - 1)];
			entity.DiscussionDate = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.DiscussionDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisDiscussionDateColumn.DiscussionDate - 1)];
			entity.TimeFrom = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.TimeFrom - 1)))?null:(System.DateTime?)reader[((int)PgThesisDiscussionDateColumn.TimeFrom - 1)];
			entity.TimeTo = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.TimeTo - 1)))?null:(System.DateTime?)reader[((int)PgThesisDiscussionDateColumn.TimeTo - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)PgThesisDiscussionDateColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)PgThesisDiscussionDateColumn.ScHallId - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisDiscussionDateColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisDiscussionDateColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisDiscussionDateColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisDiscussionDateColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisDiscussionDate entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisDiscussionDateId = (System.Decimal)dataRow["PG_THESIS_DISCUSSION_DATE_ID"];
			entity.OriginalPgThesisDiscussionDateId = (System.Decimal)dataRow["PG_THESIS_DISCUSSION_DATE_ID"];
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.DiscussionDate = Convert.IsDBNull(dataRow["DISCUSSION_DATE"]) ? null : (System.DateTime?)dataRow["DISCUSSION_DATE"];
			entity.TimeFrom = Convert.IsDBNull(dataRow["TIME_FROM"]) ? null : (System.DateTime?)dataRow["TIME_FROM"];
			entity.TimeTo = Convert.IsDBNull(dataRow["TIME_TO"]) ? null : (System.DateTime?)dataRow["TIME_TO"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisDiscussionDate"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisDiscussionDate Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDiscussionDate entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgThesisCommIdSource	
			if (CanDeepLoad(entity, "PgThesisComm|PgThesisCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisCommId;
				PgThesisComm tmpEntity = EntityManager.LocateEntity<PgThesisComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommIdSource = tmpEntity;
				else
					entity.PgThesisCommIdSource = DataRepository.PgThesisCommProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommProvider.DeepLoad(transactionManager, entity.PgThesisCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisDiscussionDate object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisDiscussionDate instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisDiscussionDate Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisDiscussionDate entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
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
	
	#region PgThesisDiscussionDateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisDiscussionDate</c>
	///</summary>
	public enum PgThesisDiscussionDateChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
		
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
	}
	
	#endregion PgThesisDiscussionDateChildEntityTypes
	
	#region PgThesisDiscussionDateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisDiscussionDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDiscussionDate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisDiscussionDateFilterBuilder : SqlFilterBuilder<PgThesisDiscussionDateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateFilterBuilder class.
		/// </summary>
		public PgThesisDiscussionDateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisDiscussionDateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisDiscussionDateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisDiscussionDateFilterBuilder
	
	#region PgThesisDiscussionDateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisDiscussionDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDiscussionDate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisDiscussionDateParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisDiscussionDateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateParameterBuilder class.
		/// </summary>
		public PgThesisDiscussionDateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisDiscussionDateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisDiscussionDateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisDiscussionDateParameterBuilder
	
	#region PgThesisDiscussionDateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisDiscussionDateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisDiscussionDate"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisDiscussionDateSortBuilder : SqlSortBuilder<PgThesisDiscussionDateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisDiscussionDateSqlSortBuilder class.
		/// </summary>
		public PgThesisDiscussionDateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisDiscussionDateSortBuilder
	
} // end namespace
