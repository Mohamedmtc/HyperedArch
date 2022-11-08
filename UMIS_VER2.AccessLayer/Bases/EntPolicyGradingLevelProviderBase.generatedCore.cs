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
	/// This class is the base class for any <see cref="EntPolicyGradingLevelProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingLevelProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyGradingLevel, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelKey key)
		{
			return Delete(transactionManager, key.EntPolicyGradingLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyGradingLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyGradingLevelId)
		{
			return Delete(null, _entPolicyGradingLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdBylawId(System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingLevel> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		fkEntPolicyGradingLevelEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		fkEntPolicyGradingLevelEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public abstract TList<EntPolicyGradingLevel> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingLevel> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		fkEntPolicyGradingLevelEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		fkEntPolicyGradingLevelEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public abstract TList<EntPolicyGradingLevel> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingLevel> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		fkEntPolicyGradingLevelEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		fkEntPolicyGradingLevelEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public TList<EntPolicyGradingLevel> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN key.
		///		FK_ENT_POLICY_GRADING_LEVEL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevel objects.</returns>
		public abstract TList<EntPolicyGradingLevel> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyGradingLevel Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelKey key, int start, int pageLength)
		{
			return GetByEntPolicyGradingLevelId(transactionManager, key.EntPolicyGradingLevelId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(null,_entPolicyGradingLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(null, _entPolicyGradingLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(transactionManager, _entPolicyGradingLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(transactionManager, _entPolicyGradingLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingLevelId(null, _entPolicyGradingLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingLevel GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyGradingLevel&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyGradingLevel&gt;"/></returns>
		public static TList<EntPolicyGradingLevel> Fill(IDataReader reader, TList<EntPolicyGradingLevel> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyGradingLevel c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyGradingLevel")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyGradingLevel>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyGradingLevel",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyGradingLevel();
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
					c.EntPolicyGradingLevelId = (System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_ID"];
					c.OriginalEntPolicyGradingLevelId = c.EntPolicyGradingLevelId;
					c.EdBylawId = (System.Decimal)reader["ED_BYLAW_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyGradingLevel entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyGradingLevelId = (System.Decimal)reader[((int)EntPolicyGradingLevelColumn.EntPolicyGradingLevelId - 1)];
			entity.OriginalEntPolicyGradingLevelId = (System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_ID"];
			entity.EdBylawId = (System.Decimal)reader[((int)EntPolicyGradingLevelColumn.EdBylawId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EntPolicyGradingLevelColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingLevelColumn.EntMainId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EntPolicyGradingLevelColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingLevelColumn.EdCodeLevelId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyGradingLevel entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyGradingLevelId = (System.Decimal)dataRow["ENT_POLICY_GRADING_LEVEL_ID"];
			entity.OriginalEntPolicyGradingLevelId = (System.Decimal)dataRow["ENT_POLICY_GRADING_LEVEL_ID"];
			entity.EdBylawId = (System.Decimal)dataRow["ED_BYLAW_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevel"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingLevel Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevel entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdBylawId;
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);		
				
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

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyGradingLevelId methods when available
			
			#region EntPolicyGradingLevelCoursesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingLevelCourses>|EntPolicyGradingLevelCoursesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelCoursesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingLevelCoursesCollection = DataRepository.EntPolicyGradingLevelCoursesProvider.GetByEntPolicyGradingLevelId(transactionManager, entity.EntPolicyGradingLevelId);

				if (deep && entity.EntPolicyGradingLevelCoursesCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingLevelCoursesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingLevelCourses>) DataRepository.EntPolicyGradingLevelCoursesProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingLevelCoursesCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyGradingLevel object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyGradingLevel instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingLevel Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevel entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyGradingLevelCourses>
				if (CanDeepSave(entity.EntPolicyGradingLevelCoursesCollection, "List<EntPolicyGradingLevelCourses>|EntPolicyGradingLevelCoursesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingLevelCourses child in entity.EntPolicyGradingLevelCoursesCollection)
					{
						if(child.EntPolicyGradingLevelIdSource != null)
						{
							child.EntPolicyGradingLevelId = child.EntPolicyGradingLevelIdSource.EntPolicyGradingLevelId;
						}
						else
						{
							child.EntPolicyGradingLevelId = entity.EntPolicyGradingLevelId;
						}

					}

					if (entity.EntPolicyGradingLevelCoursesCollection.Count > 0 || entity.EntPolicyGradingLevelCoursesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingLevelCoursesProvider.Save(transactionManager, entity.EntPolicyGradingLevelCoursesCollection);
						
						deepHandles.Add("EntPolicyGradingLevelCoursesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingLevelCourses >) DataRepository.EntPolicyGradingLevelCoursesProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingLevelCoursesCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyGradingLevelChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyGradingLevel</c>
	///</summary>
	public enum EntPolicyGradingLevelChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EntPolicyGradingLevel</c> as OneToMany for EntPolicyGradingLevelCoursesCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingLevelCourses>))]
		EntPolicyGradingLevelCoursesCollection,
	}
	
	#endregion EntPolicyGradingLevelChildEntityTypes
	
	#region EntPolicyGradingLevelFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyGradingLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingLevelFilterBuilder : SqlFilterBuilder<EntPolicyGradingLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelFilterBuilder class.
		/// </summary>
		public EntPolicyGradingLevelFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingLevelFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingLevelFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingLevelFilterBuilder
	
	#region EntPolicyGradingLevelParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyGradingLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingLevelParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyGradingLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelParameterBuilder class.
		/// </summary>
		public EntPolicyGradingLevelParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingLevelParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingLevelParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingLevelParameterBuilder
	
	#region EntPolicyGradingLevelSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyGradingLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevel"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyGradingLevelSortBuilder : SqlSortBuilder<EntPolicyGradingLevelColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelSqlSortBuilder class.
		/// </summary>
		public EntPolicyGradingLevelSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyGradingLevelSortBuilder
	
} // end namespace
