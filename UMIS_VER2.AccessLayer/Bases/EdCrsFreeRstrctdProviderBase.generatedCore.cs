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
	/// This class is the base class for any <see cref="EdCrsFreeRstrctdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCrsFreeRstrctdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctdKey key)
		{
			return Delete(transactionManager, key.EdCrsFreeRstrctdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCrsFreeRstrctdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCrsFreeRstrctdId)
		{
			return Delete(null, _edCrsFreeRstrctdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCrsFreeRstrctdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCrsFreeRstrctdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		/// <remarks></remarks>
		public TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		fkEdCrsFreeRstrctdAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		fkEdCrsFreeRstrctdAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO key.
		///		FK_ED_CRS_FREE_RSTRCTD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public abstract TList<EdCrsFreeRstrctd> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		FK_ED_CRS_FREE_RSTRCTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		FK_ED_CRS_FREE_RSTRCTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		/// <remarks></remarks>
		public TList<EdCrsFreeRstrctd> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		FK_ED_CRS_FREE_RSTRCTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		fkEdCrsFreeRstrctdEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		fkEdCrsFreeRstrctdEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public TList<EdCrsFreeRstrctd> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CRS_FREE_RSTRCTD_ED_COURSE key.
		///		FK_ED_CRS_FREE_RSTRCTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd objects.</returns>
		public abstract TList<EdCrsFreeRstrctd> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctdKey key, int start, int pageLength)
		{
			return GetByEdCrsFreeRstrctdId(transactionManager, key.EdCrsFreeRstrctdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(System.Decimal _edCrsFreeRstrctdId)
		{
			int count = -1;
			return GetByEdCrsFreeRstrctdId(null,_edCrsFreeRstrctdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(System.Decimal _edCrsFreeRstrctdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCrsFreeRstrctdId(null, _edCrsFreeRstrctdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(TransactionManager transactionManager, System.Decimal _edCrsFreeRstrctdId)
		{
			int count = -1;
			return GetByEdCrsFreeRstrctdId(transactionManager, _edCrsFreeRstrctdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(TransactionManager transactionManager, System.Decimal _edCrsFreeRstrctdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCrsFreeRstrctdId(transactionManager, _edCrsFreeRstrctdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(System.Decimal _edCrsFreeRstrctdId, int start, int pageLength, out int count)
		{
			return GetByEdCrsFreeRstrctdId(null, _edCrsFreeRstrctdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCrsFreeRstrctdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByEdCrsFreeRstrctdId(TransactionManager transactionManager, System.Decimal _edCrsFreeRstrctdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(System.Decimal _asFacultyInfoId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCourseId(null,_asFacultyInfoId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(System.Decimal _asFacultyInfoId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCourseId(null, _asFacultyInfoId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCourseId(transactionManager, _asFacultyInfoId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdEdCourseId(transactionManager, _asFacultyInfoId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(System.Decimal _asFacultyInfoId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdEdCourseId(null, _asFacultyInfoId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CRS_FREE_RSTRCTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd GetByAsFacultyInfoIdEdCourseId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCrsFreeRstrctd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCrsFreeRstrctd&gt;"/></returns>
		public static TList<EdCrsFreeRstrctd> Fill(IDataReader reader, TList<EdCrsFreeRstrctd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCrsFreeRstrctd")
					.Append("|").Append((System.Decimal)reader["ED_CRS_FREE_RSTRCTD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCrsFreeRstrctd>(
					key.ToString(), // EntityTrackingKey
					"EdCrsFreeRstrctd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd();
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
					c.EdCrsFreeRstrctdId = (System.Decimal)reader["ED_CRS_FREE_RSTRCTD_ID"];
					c.OriginalEdCrsFreeRstrctdId = c.EdCrsFreeRstrctdId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCrsFreeRstrctdId = (System.Decimal)reader[((int)EdCrsFreeRstrctdColumn.EdCrsFreeRstrctdId - 1)];
			entity.OriginalEdCrsFreeRstrctdId = (System.Decimal)reader["ED_CRS_FREE_RSTRCTD_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCrsFreeRstrctdColumn.EdCourseId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdCrsFreeRstrctdColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCrsFreeRstrctdId = (System.Decimal)dataRow["ED_CRS_FREE_RSTRCTD_ID"];
			entity.OriginalEdCrsFreeRstrctdId = (System.Decimal)dataRow["ED_CRS_FREE_RSTRCTD_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdCrsFreeRstrctdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCrsFreeRstrctd</c>
	///</summary>
	public enum EdCrsFreeRstrctdChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdCrsFreeRstrctdChildEntityTypes
	
	#region EdCrsFreeRstrctdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCrsFreeRstrctdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCrsFreeRstrctd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCrsFreeRstrctdFilterBuilder : SqlFilterBuilder<EdCrsFreeRstrctdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdFilterBuilder class.
		/// </summary>
		public EdCrsFreeRstrctdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCrsFreeRstrctdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCrsFreeRstrctdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCrsFreeRstrctdFilterBuilder
	
	#region EdCrsFreeRstrctdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCrsFreeRstrctdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCrsFreeRstrctd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCrsFreeRstrctdParameterBuilder : ParameterizedSqlFilterBuilder<EdCrsFreeRstrctdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdParameterBuilder class.
		/// </summary>
		public EdCrsFreeRstrctdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCrsFreeRstrctdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCrsFreeRstrctdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCrsFreeRstrctdParameterBuilder
	
	#region EdCrsFreeRstrctdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCrsFreeRstrctdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCrsFreeRstrctd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCrsFreeRstrctdSortBuilder : SqlSortBuilder<EdCrsFreeRstrctdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCrsFreeRstrctdSqlSortBuilder class.
		/// </summary>
		public EdCrsFreeRstrctdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCrsFreeRstrctdSortBuilder
	
} // end namespace
