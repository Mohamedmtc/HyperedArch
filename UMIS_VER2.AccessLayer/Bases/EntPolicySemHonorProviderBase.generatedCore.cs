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
	/// This class is the base class for any <see cref="EntPolicySemHonorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicySemHonorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicySemHonor, UMIS_VER2.BusinessLyer.EntPolicySemHonorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicySemHonorKey key)
		{
			return Delete(transactionManager, key.EntPolicySemHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicySemHonorId)
		{
			return Delete(null, _entPolicySemHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicySemHonorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_SEM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_SEM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicySemHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_SEM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		fkEntPolicySemHonorEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		fkEntPolicySemHonorEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_ED_BYLAW key.
		///		FK_ENT_POLICY_SEM_HONOR_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public abstract TList<EntPolicySemHonor> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicySemHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		fkEntPolicySemHonorGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		fkEntPolicySemHonorGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public TList<EntPolicySemHonor> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR key.
		///		FK_ENT_POLICY_SEM_HONOR_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicySemHonor objects.</returns>
		public abstract TList<EntPolicySemHonor> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicySemHonor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicySemHonorKey key, int start, int pageLength)
		{
			return GetByEntPolicySemHonorId(transactionManager, key.EntPolicySemHonorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(System.Decimal _entPolicySemHonorId)
		{
			int count = -1;
			return GetByEntPolicySemHonorId(null,_entPolicySemHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(System.Decimal _entPolicySemHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicySemHonorId(null, _entPolicySemHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(TransactionManager transactionManager, System.Decimal _entPolicySemHonorId)
		{
			int count = -1;
			return GetByEntPolicySemHonorId(transactionManager, _entPolicySemHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(TransactionManager transactionManager, System.Decimal _entPolicySemHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicySemHonorId(transactionManager, _entPolicySemHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(System.Decimal _entPolicySemHonorId, int start, int pageLength, out int count)
		{
			return GetByEntPolicySemHonorId(null, _entPolicySemHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicySemHonorId">مراتب الشرف  الفصلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEntPolicySemHonorId(TransactionManager transactionManager, System.Decimal _entPolicySemHonorId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(null,_edBylawId, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(null, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(transactionManager, _edBylawId, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdGsCdeHonorId(transactionManager, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdGsCdeHonorId(null, _edBylawId, _gsCdeHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_SEM_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicySemHonor GetByEdBylawIdGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _edBylawId, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicySemHonor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicySemHonor&gt;"/></returns>
		public static TList<EntPolicySemHonor> Fill(IDataReader reader, TList<EntPolicySemHonor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicySemHonor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicySemHonor")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_SEM_HONOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicySemHonor>(
					key.ToString(), // EntityTrackingKey
					"EntPolicySemHonor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicySemHonor();
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
					c.EntPolicySemHonorId = (System.Decimal)reader["ENT_POLICY_SEM_HONOR_ID"];
					c.OriginalEntPolicySemHonorId = c.EntPolicySemHonorId;
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.AllowSubjFailure = Convert.IsDBNull(reader["ALLOW_SUBJ_FAILURE"]) ? null : (System.Boolean?)reader["ALLOW_SUBJ_FAILURE"];
					c.GpaPointFrm = Convert.IsDBNull(reader["GPA_POINT_FRM"]) ? null : (System.Decimal?)reader["GPA_POINT_FRM"];
					c.GpaPointTo = Convert.IsDBNull(reader["GPA_POINT_TO"]) ? null : (System.Decimal?)reader["GPA_POINT_TO"];
					c.CourseRepeatFlg = Convert.IsDBNull(reader["COURSE_REPEAT_FLG"]) ? null : (System.Boolean?)reader["COURSE_REPEAT_FLG"];
					c.CourseIncompFlg = Convert.IsDBNull(reader["COURSE_INCOMP_FLG"]) ? null : (System.Boolean?)reader["COURSE_INCOMP_FLG"];
					c.PenltyFlg = Convert.IsDBNull(reader["PENLTY_FLG"]) ? null : (System.Boolean?)reader["PENLTY_FLG"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicySemHonor entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicySemHonorId = (System.Decimal)reader[((int)EntPolicySemHonorColumn.EntPolicySemHonorId - 1)];
			entity.OriginalEntPolicySemHonorId = (System.Decimal)reader["ENT_POLICY_SEM_HONOR_ID"];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)EntPolicySemHonorColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)EntPolicySemHonorColumn.GsCdeHonorId - 1)];
			entity.AllowSubjFailure = (reader.IsDBNull(((int)EntPolicySemHonorColumn.AllowSubjFailure - 1)))?null:(System.Boolean?)reader[((int)EntPolicySemHonorColumn.AllowSubjFailure - 1)];
			entity.GpaPointFrm = (reader.IsDBNull(((int)EntPolicySemHonorColumn.GpaPointFrm - 1)))?null:(System.Decimal?)reader[((int)EntPolicySemHonorColumn.GpaPointFrm - 1)];
			entity.GpaPointTo = (reader.IsDBNull(((int)EntPolicySemHonorColumn.GpaPointTo - 1)))?null:(System.Decimal?)reader[((int)EntPolicySemHonorColumn.GpaPointTo - 1)];
			entity.CourseRepeatFlg = (reader.IsDBNull(((int)EntPolicySemHonorColumn.CourseRepeatFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicySemHonorColumn.CourseRepeatFlg - 1)];
			entity.CourseIncompFlg = (reader.IsDBNull(((int)EntPolicySemHonorColumn.CourseIncompFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicySemHonorColumn.CourseIncompFlg - 1)];
			entity.PenltyFlg = (reader.IsDBNull(((int)EntPolicySemHonorColumn.PenltyFlg - 1)))?null:(System.Boolean?)reader[((int)EntPolicySemHonorColumn.PenltyFlg - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicySemHonorColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicySemHonorColumn.EdBylawId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicySemHonor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicySemHonorId = (System.Decimal)dataRow["ENT_POLICY_SEM_HONOR_ID"];
			entity.OriginalEntPolicySemHonorId = (System.Decimal)dataRow["ENT_POLICY_SEM_HONOR_ID"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.AllowSubjFailure = Convert.IsDBNull(dataRow["ALLOW_SUBJ_FAILURE"]) ? null : (System.Boolean?)dataRow["ALLOW_SUBJ_FAILURE"];
			entity.GpaPointFrm = Convert.IsDBNull(dataRow["GPA_POINT_FRM"]) ? null : (System.Decimal?)dataRow["GPA_POINT_FRM"];
			entity.GpaPointTo = Convert.IsDBNull(dataRow["GPA_POINT_TO"]) ? null : (System.Decimal?)dataRow["GPA_POINT_TO"];
			entity.CourseRepeatFlg = Convert.IsDBNull(dataRow["COURSE_REPEAT_FLG"]) ? null : (System.Boolean?)dataRow["COURSE_REPEAT_FLG"];
			entity.CourseIncompFlg = Convert.IsDBNull(dataRow["COURSE_INCOMP_FLG"]) ? null : (System.Boolean?)dataRow["COURSE_INCOMP_FLG"];
			entity.PenltyFlg = Convert.IsDBNull(dataRow["PENLTY_FLG"]) ? null : (System.Boolean?)dataRow["PENLTY_FLG"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicySemHonor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicySemHonor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicySemHonor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

			#region GsCdeHonorIdSource	
			if (CanDeepLoad(entity, "GsCdeHonor|GsCdeHonorIdSource", deepLoadType, innerList) 
				&& entity.GsCdeHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeHonorId ?? 0.0m);
				GsCdeHonor tmpEntity = EntityManager.LocateEntity<GsCdeHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeHonorIdSource = tmpEntity;
				else
					entity.GsCdeHonorIdSource = DataRepository.GsCdeHonorProvider.GetByGsCdeHonorId(transactionManager, (entity.GsCdeHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeHonorProvider.DeepLoad(transactionManager, entity.GsCdeHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeHonorIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicySemHonor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicySemHonor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicySemHonor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicySemHonor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region GsCdeHonorIdSource
			if (CanDeepSave(entity, "GsCdeHonor|GsCdeHonorIdSource", deepSaveType, innerList) 
				&& entity.GsCdeHonorIdSource != null)
			{
				DataRepository.GsCdeHonorProvider.Save(transactionManager, entity.GsCdeHonorIdSource);
				entity.GsCdeHonorId = entity.GsCdeHonorIdSource.GsCdeHonorId;
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
	
	#region EntPolicySemHonorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicySemHonor</c>
	///</summary>
	public enum EntPolicySemHonorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
	}
	
	#endregion EntPolicySemHonorChildEntityTypes
	
	#region EntPolicySemHonorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicySemHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicySemHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicySemHonorFilterBuilder : SqlFilterBuilder<EntPolicySemHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorFilterBuilder class.
		/// </summary>
		public EntPolicySemHonorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicySemHonorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicySemHonorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicySemHonorFilterBuilder
	
	#region EntPolicySemHonorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicySemHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicySemHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicySemHonorParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicySemHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorParameterBuilder class.
		/// </summary>
		public EntPolicySemHonorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicySemHonorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicySemHonorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicySemHonorParameterBuilder
	
	#region EntPolicySemHonorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicySemHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicySemHonor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicySemHonorSortBuilder : SqlSortBuilder<EntPolicySemHonorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicySemHonorSqlSortBuilder class.
		/// </summary>
		public EntPolicySemHonorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicySemHonorSortBuilder
	
} // end namespace
