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
	/// This class is the base class for any <see cref="MdiStudInvstgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudInvstgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudInvstg, UMIS_VER2.BusinessLyer.MdiStudInvstgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudInvstgKey key)
		{
			return Delete(transactionManager, key.MdiStudInvstgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudInvstgId">بيانات الفحص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudInvstgId)
		{
			return Delete(null, _mdiStudInvstgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudInvstgId">بيانات الفحص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudInvstgId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG Description: 
		/// </summary>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(_mdiCdeInvstgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudInvstg> GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(transactionManager, _mdiCdeInvstgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeInvstgId(transactionManager, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		fkMdiStudInvstgMdiCdeInvstg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeInvstgId(null, _mdiCdeInvstgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		fkMdiStudInvstgMdiCdeInvstg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiCdeInvstgId(System.Decimal _mdiCdeInvstgId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeInvstgId(null, _mdiCdeInvstgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG key.
		///		FK_MDI_STUD_INVSTG_MDI_CDE_INVSTG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public abstract TList<MdiStudInvstg> GetByMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiCdeInvstgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_INVSTG_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(_mdiStudRecordId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_INVSTG_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudInvstg> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_INVSTG_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		fkMdiStudInvstgMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		fkMdiStudInvstgMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public TList<MdiStudInvstg> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength,out int count)
		{
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_INVSTG_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_INVSTG_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudInvstg objects.</returns>
		public abstract TList<MdiStudInvstg> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudInvstg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudInvstgKey key, int start, int pageLength)
		{
			return GetByMdiStudInvstgId(transactionManager, key.MdiStudInvstgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(System.Decimal _mdiStudInvstgId)
		{
			int count = -1;
			return GetByMdiStudInvstgId(null,_mdiStudInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(System.Decimal _mdiStudInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudInvstgId(null, _mdiStudInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudInvstgId)
		{
			int count = -1;
			return GetByMdiStudInvstgId(transactionManager, _mdiStudInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudInvstgId(transactionManager, _mdiStudInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(System.Decimal _mdiStudInvstgId, int start, int pageLength, out int count)
		{
			return GetByMdiStudInvstgId(null, _mdiStudInvstgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudInvstgId">بيانات الفحص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudInvstgId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeInvstgId(null,_mdiStudRecordId, _mdiCdeInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeInvstgId(null, _mdiStudRecordId, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeInvstgId(transactionManager, _mdiStudRecordId, _mdiCdeInvstgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdMdiCdeInvstgId(transactionManager, _mdiStudRecordId, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId, int start, int pageLength, out int count)
		{
			return GetByMdiStudRecordIdMdiCdeInvstgId(null, _mdiStudRecordId, _mdiCdeInvstgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_INVSTG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_mdiCdeInvstgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudInvstg GetByMdiStudRecordIdMdiCdeInvstgId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _mdiCdeInvstgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudInvstg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudInvstg&gt;"/></returns>
		public static TList<MdiStudInvstg> Fill(IDataReader reader, TList<MdiStudInvstg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudInvstg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudInvstg")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_INVSTG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudInvstg>(
					key.ToString(), // EntityTrackingKey
					"MdiStudInvstg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudInvstg();
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
					c.MdiStudInvstgId = (System.Decimal)reader["MDI_STUD_INVSTG_ID"];
					c.OriginalMdiStudInvstgId = c.MdiStudInvstgId;
					c.MdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
					c.MdiCdeInvstgId = (System.Decimal)reader["MDI_CDE_INVSTG_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudInvstg entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudInvstgId = (System.Decimal)reader[((int)MdiStudInvstgColumn.MdiStudInvstgId - 1)];
			entity.OriginalMdiStudInvstgId = (System.Decimal)reader["MDI_STUD_INVSTG_ID"];
			entity.MdiStudRecordId = (System.Decimal)reader[((int)MdiStudInvstgColumn.MdiStudRecordId - 1)];
			entity.MdiCdeInvstgId = (System.Decimal)reader[((int)MdiStudInvstgColumn.MdiCdeInvstgId - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudInvstgColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudInvstgColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudInvstg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudInvstgId = (System.Decimal)dataRow["MDI_STUD_INVSTG_ID"];
			entity.OriginalMdiStudInvstgId = (System.Decimal)dataRow["MDI_STUD_INVSTG_ID"];
			entity.MdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.MdiCdeInvstgId = (System.Decimal)dataRow["MDI_CDE_INVSTG_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudInvstg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudInvstg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudInvstg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MdiCdeInvstgIdSource	
			if (CanDeepLoad(entity, "MdiCdeInvstg|MdiCdeInvstgIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeInvstgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeInvstgId;
				MdiCdeInvstg tmpEntity = EntityManager.LocateEntity<MdiCdeInvstg>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeInvstg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeInvstgIdSource = tmpEntity;
				else
					entity.MdiCdeInvstgIdSource = DataRepository.MdiCdeInvstgProvider.GetByMdiCdeInvstgId(transactionManager, entity.MdiCdeInvstgId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeInvstgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeInvstgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeInvstgProvider.DeepLoad(transactionManager, entity.MdiCdeInvstgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeInvstgIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudInvstg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudInvstg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudInvstg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudInvstg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MdiCdeInvstgIdSource
			if (CanDeepSave(entity, "MdiCdeInvstg|MdiCdeInvstgIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeInvstgIdSource != null)
			{
				DataRepository.MdiCdeInvstgProvider.Save(transactionManager, entity.MdiCdeInvstgIdSource);
				entity.MdiCdeInvstgId = entity.MdiCdeInvstgIdSource.MdiCdeInvstgId;
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
	
	#region MdiStudInvstgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudInvstg</c>
	///</summary>
	public enum MdiStudInvstgChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MdiCdeInvstg</c> at MdiCdeInvstgIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeInvstg))]
		MdiCdeInvstg,
		
		///<summary>
		/// Composite Property for <c>MdiStudRecord</c> at MdiStudRecordIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudRecord))]
		MdiStudRecord,
	}
	
	#endregion MdiStudInvstgChildEntityTypes
	
	#region MdiStudInvstgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudInvstg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudInvstgFilterBuilder : SqlFilterBuilder<MdiStudInvstgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgFilterBuilder class.
		/// </summary>
		public MdiStudInvstgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudInvstgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudInvstgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudInvstgFilterBuilder
	
	#region MdiStudInvstgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudInvstg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudInvstgParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudInvstgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgParameterBuilder class.
		/// </summary>
		public MdiStudInvstgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudInvstgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudInvstgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudInvstgParameterBuilder
	
	#region MdiStudInvstgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudInvstgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudInvstg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudInvstgSortBuilder : SqlSortBuilder<MdiStudInvstgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudInvstgSqlSortBuilder class.
		/// </summary>
		public MdiStudInvstgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudInvstgSortBuilder
	
} // end namespace
