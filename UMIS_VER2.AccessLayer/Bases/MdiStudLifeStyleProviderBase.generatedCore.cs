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
	/// This class is the base class for any <see cref="MdiStudLifeStyleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudLifeStyleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudLifeStyle, UMIS_VER2.BusinessLyer.MdiStudLifeStyleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudLifeStyleKey key)
		{
			return Delete(transactionManager, key.MdiStudLifeStyleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudLifeStyleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudLifeStyleId)
		{
			return Delete(null, _mdiStudLifeStyleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudLifeStyleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudLifeStyleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE Description: 
		/// </summary>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(_mdiCdeLifeStyleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(transactionManager, _mdiCdeLifeStyleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeLifeStyleId(transactionManager, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		fkMdiStudLifeStyleMdiCdeLifeStyle Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeLifeStyleId(null, _mdiCdeLifeStyleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		fkMdiStudLifeStyleMdiCdeLifeStyle Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(System.Decimal _mdiCdeLifeStyleId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeLifeStyleId(null, _mdiCdeLifeStyleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_CDE_LIFE_STYLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public abstract TList<MdiStudLifeStyle> GetByMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(_mdiStudRecordId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudLifeStyle> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		fkMdiStudLifeStyleMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		fkMdiStudLifeStyleMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public TList<MdiStudLifeStyle> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength,out int count)
		{
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_LIFE_STYLE_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudLifeStyle objects.</returns>
		public abstract TList<MdiStudLifeStyle> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudLifeStyle Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudLifeStyleKey key, int start, int pageLength)
		{
			return GetByMdiStudLifeStyleId(transactionManager, key.MdiStudLifeStyleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(System.Decimal _mdiStudLifeStyleId)
		{
			int count = -1;
			return GetByMdiStudLifeStyleId(null,_mdiStudLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(System.Decimal _mdiStudLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudLifeStyleId(null, _mdiStudLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudLifeStyleId)
		{
			int count = -1;
			return GetByMdiStudLifeStyleId(transactionManager, _mdiStudLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudLifeStyleId(transactionManager, _mdiStudLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(System.Decimal _mdiStudLifeStyleId, int start, int pageLength, out int count)
		{
			return GetByMdiStudLifeStyleId(null, _mdiStudLifeStyleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudLifeStyleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeLifeStyleId(null,_mdiStudRecordId, _mdiCdeLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeLifeStyleId(null, _mdiStudRecordId, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeLifeStyleId(transactionManager, _mdiStudRecordId, _mdiCdeLifeStyleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeLifeStyleId(transactionManager, _mdiStudRecordId, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength, out int count)
		{
			return GetByMdiStudRecordIdMdiCdeLifeStyleId(null, _mdiStudRecordId, _mdiCdeLifeStyleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_LIFE_STYLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeLifeStyleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudLifeStyle GetByMdiStudRecordIdMdiCdeLifeStyleId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeLifeStyleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudLifeStyle&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudLifeStyle&gt;"/></returns>
		public static TList<MdiStudLifeStyle> Fill(IDataReader reader, TList<MdiStudLifeStyle> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudLifeStyle c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudLifeStyle")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_LIFE_STYLE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudLifeStyle>(
					key.ToString(), // EntityTrackingKey
					"MdiStudLifeStyle",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudLifeStyle();
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
					c.MdiStudLifeStyleId = (System.Decimal)reader["MDI_STUD_LIFE_STYLE_ID"];
					c.OriginalMdiStudLifeStyleId = c.MdiStudLifeStyleId;
					c.MdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
					c.MdiCdeLifeStyleId = (System.Decimal)reader["MDI_CDE_LIFE_STYLE_ID"];
					c.DegreeId = (System.Decimal)reader["DEGREE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudLifeStyle entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudLifeStyleId = (System.Decimal)reader[((int)MdiStudLifeStyleColumn.MdiStudLifeStyleId - 1)];
			entity.OriginalMdiStudLifeStyleId = (System.Decimal)reader["MDI_STUD_LIFE_STYLE_ID"];
			entity.MdiStudRecordId = (System.Decimal)reader[((int)MdiStudLifeStyleColumn.MdiStudRecordId - 1)];
			entity.MdiCdeLifeStyleId = (System.Decimal)reader[((int)MdiStudLifeStyleColumn.MdiCdeLifeStyleId - 1)];
			entity.DegreeId = (System.Decimal)reader[((int)MdiStudLifeStyleColumn.DegreeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudLifeStyle entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudLifeStyleId = (System.Decimal)dataRow["MDI_STUD_LIFE_STYLE_ID"];
			entity.OriginalMdiStudLifeStyleId = (System.Decimal)dataRow["MDI_STUD_LIFE_STYLE_ID"];
			entity.MdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.MdiCdeLifeStyleId = (System.Decimal)dataRow["MDI_CDE_LIFE_STYLE_ID"];
			entity.DegreeId = (System.Decimal)dataRow["DEGREE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudLifeStyle"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudLifeStyle Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudLifeStyle entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MdiCdeLifeStyleIdSource	
			if (CanDeepLoad(entity, "MdiCdeLifeStyle|MdiCdeLifeStyleIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeLifeStyleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeLifeStyleId;
				MdiCdeLifeStyle tmpEntity = EntityManager.LocateEntity<MdiCdeLifeStyle>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeLifeStyle), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeLifeStyleIdSource = tmpEntity;
				else
					entity.MdiCdeLifeStyleIdSource = DataRepository.MdiCdeLifeStyleProvider.GetByMdiCdeLifeStyleId(transactionManager, entity.MdiCdeLifeStyleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeLifeStyleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeLifeStyleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeLifeStyleProvider.DeepLoad(transactionManager, entity.MdiCdeLifeStyleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeLifeStyleIdSource

			#region MdiStudRecordIdSource	
			if (CanDeepLoad(entity, "MdiStudRecord|MdiStudRecordIdSource", deepLoadType, innerList) 
				&& entity.MdiStudRecordIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiStudRecordId;
				MdiStudRecord tmpEntity = EntityManager.LocateEntity<MdiStudRecord>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiStudRecord), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiStudRecordIdSource = tmpEntity;
				else
					entity.MdiStudRecordIdSource = DataRepository.MdiStudRecordProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiStudRecordIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiStudRecordProvider.DeepLoad(transactionManager, entity.MdiStudRecordIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiStudRecordIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudLifeStyle object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudLifeStyle instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudLifeStyle Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudLifeStyle entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MdiCdeLifeStyleIdSource
			if (CanDeepSave(entity, "MdiCdeLifeStyle|MdiCdeLifeStyleIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeLifeStyleIdSource != null)
			{
				DataRepository.MdiCdeLifeStyleProvider.Save(transactionManager, entity.MdiCdeLifeStyleIdSource);
				entity.MdiCdeLifeStyleId = entity.MdiCdeLifeStyleIdSource.MdiCdeLifeStyleId;
			}
			#endregion 
			
			#region MdiStudRecordIdSource
			if (CanDeepSave(entity, "MdiStudRecord|MdiStudRecordIdSource", deepSaveType, innerList) 
				&& entity.MdiStudRecordIdSource != null)
			{
				DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordIdSource);
				entity.MdiStudRecordId = entity.MdiStudRecordIdSource.MdiStudRecordId;
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
	
	#region MdiStudLifeStyleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudLifeStyle</c>
	///</summary>
	public enum MdiStudLifeStyleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MdiCdeLifeStyle</c> at MdiCdeLifeStyleIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeLifeStyle))]
		MdiCdeLifeStyle,
		
		///<summary>
		/// Composite Property for <c>MdiStudRecord</c> at MdiStudRecordIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudRecord))]
		MdiStudRecord,
	}
	
	#endregion MdiStudLifeStyleChildEntityTypes
	
	#region MdiStudLifeStyleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudLifeStyle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudLifeStyleFilterBuilder : SqlFilterBuilder<MdiStudLifeStyleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleFilterBuilder class.
		/// </summary>
		public MdiStudLifeStyleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudLifeStyleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudLifeStyleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudLifeStyleFilterBuilder
	
	#region MdiStudLifeStyleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudLifeStyle"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudLifeStyleParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudLifeStyleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleParameterBuilder class.
		/// </summary>
		public MdiStudLifeStyleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudLifeStyleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudLifeStyleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudLifeStyleParameterBuilder
	
	#region MdiStudLifeStyleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudLifeStyleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudLifeStyle"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudLifeStyleSortBuilder : SqlSortBuilder<MdiStudLifeStyleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudLifeStyleSqlSortBuilder class.
		/// </summary>
		public MdiStudLifeStyleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudLifeStyleSortBuilder
	
} // end namespace
