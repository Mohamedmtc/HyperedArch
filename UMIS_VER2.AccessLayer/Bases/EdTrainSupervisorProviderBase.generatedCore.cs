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
	/// This class is the base class for any <see cref="EdTrainSupervisorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdTrainSupervisorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdTrainSupervisor, UMIS_VER2.BusinessLyer.EdTrainSupervisorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainSupervisorKey key)
		{
			return Delete(transactionManager, key.EdTrainSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edTrainSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edTrainSupervisorId)
		{
			return Delete(null, _edTrainSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edTrainSupervisorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		FK_ED_TRAIN_SUPERVISOR_ED_TRAINING Description: 
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetByEdTrainingId(System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(_edTrainingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		FK_ED_TRAIN_SUPERVISOR_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainSupervisor> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		FK_ED_TRAIN_SUPERVISOR_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		fkEdTrainSupervisorEdTraining Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edTrainingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		fkEdTrainSupervisorEdTraining Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength,out int count)
		{
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_ED_TRAINING key.
		///		FK_ED_TRAIN_SUPERVISOR_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public abstract TList<EdTrainSupervisor> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		fkEdTrainSupervisorSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		fkEdTrainSupervisorSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public TList<EdTrainSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_SUPERVISOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainSupervisor objects.</returns>
		public abstract TList<EdTrainSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdTrainSupervisor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainSupervisorKey key, int start, int pageLength)
		{
			return GetByEdTrainSupervisorId(transactionManager, key.EdTrainSupervisorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainSupervisorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(System.Decimal _edTrainSupervisorId)
		{
			int count = -1;
			return GetByEdTrainSupervisorId(null,_edTrainSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(System.Decimal _edTrainSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainSupervisorId(null, _edTrainSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainSupervisorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(TransactionManager transactionManager, System.Decimal _edTrainSupervisorId)
		{
			int count = -1;
			return GetByEdTrainSupervisorId(transactionManager, _edTrainSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(TransactionManager transactionManager, System.Decimal _edTrainSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainSupervisorId(transactionManager, _edTrainSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(System.Decimal _edTrainSupervisorId, int start, int pageLength, out int count)
		{
			return GetByEdTrainSupervisorId(null, _edTrainSupervisorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainSupervisorId(TransactionManager transactionManager, System.Decimal _edTrainSupervisorId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(System.Decimal _edTrainingId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByEdTrainingIdSaStfMemberId(null,_edTrainingId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(System.Decimal _edTrainingId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingIdSaStfMemberId(null, _edTrainingId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edTrainingId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByEdTrainingIdSaStfMemberId(transactionManager, _edTrainingId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edTrainingId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingIdSaStfMemberId(transactionManager, _edTrainingId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(System.Decimal _edTrainingId, System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetByEdTrainingIdSaStfMemberId(null, _edTrainingId, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdTrainSupervisor GetByEdTrainingIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edTrainingId, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdTrainSupervisor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdTrainSupervisor&gt;"/></returns>
		public static TList<EdTrainSupervisor> Fill(IDataReader reader, TList<EdTrainSupervisor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdTrainSupervisor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdTrainSupervisor")
					.Append("|").Append((System.Decimal)reader["ED_TRAIN_SUPERVISOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdTrainSupervisor>(
					key.ToString(), // EntityTrackingKey
					"EdTrainSupervisor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdTrainSupervisor();
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
					c.EdTrainSupervisorId = (System.Decimal)reader["ED_TRAIN_SUPERVISOR_ID"];
					c.OriginalEdTrainSupervisorId = c.EdTrainSupervisorId;
					c.EdTrainingId = (System.Decimal)reader["ED_TRAINING_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdTrainSupervisor entity)
		{
			if (!reader.Read()) return;
			
			entity.EdTrainSupervisorId = (System.Decimal)reader[((int)EdTrainSupervisorColumn.EdTrainSupervisorId - 1)];
			entity.OriginalEdTrainSupervisorId = (System.Decimal)reader["ED_TRAIN_SUPERVISOR_ID"];
			entity.EdTrainingId = (System.Decimal)reader[((int)EdTrainSupervisorColumn.EdTrainingId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)EdTrainSupervisorColumn.SaStfMemberId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdTrainSupervisor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdTrainSupervisorId = (System.Decimal)dataRow["ED_TRAIN_SUPERVISOR_ID"];
			entity.OriginalEdTrainSupervisorId = (System.Decimal)dataRow["ED_TRAIN_SUPERVISOR_ID"];
			entity.EdTrainingId = (System.Decimal)dataRow["ED_TRAINING_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainSupervisor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTrainSupervisor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainSupervisor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdTrainingIdSource	
			if (CanDeepLoad(entity, "EdTraining|EdTrainingIdSource", deepLoadType, innerList) 
				&& entity.EdTrainingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdTrainingId;
				EdTraining tmpEntity = EntityManager.LocateEntity<EdTraining>(EntityLocator.ConstructKeyFromPkItems(typeof(EdTraining), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdTrainingIdSource = tmpEntity;
				else
					entity.EdTrainingIdSource = DataRepository.EdTrainingProvider.GetByEdTrainingId(transactionManager, entity.EdTrainingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdTrainingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdTrainingProvider.DeepLoad(transactionManager, entity.EdTrainingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdTrainingIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdTrainSupervisor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdTrainSupervisor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTrainSupervisor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainSupervisor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdTrainingIdSource
			if (CanDeepSave(entity, "EdTraining|EdTrainingIdSource", deepSaveType, innerList) 
				&& entity.EdTrainingIdSource != null)
			{
				DataRepository.EdTrainingProvider.Save(transactionManager, entity.EdTrainingIdSource);
				entity.EdTrainingId = entity.EdTrainingIdSource.EdTrainingId;
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
	
	#region EdTrainSupervisorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdTrainSupervisor</c>
	///</summary>
	public enum EdTrainSupervisorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdTraining</c> at EdTrainingIdSource
		///</summary>
		[ChildEntityType(typeof(EdTraining))]
		EdTraining,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdTrainSupervisorChildEntityTypes
	
	#region EdTrainSupervisorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdTrainSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainSupervisorFilterBuilder : SqlFilterBuilder<EdTrainSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorFilterBuilder class.
		/// </summary>
		public EdTrainSupervisorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainSupervisorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainSupervisorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainSupervisorFilterBuilder
	
	#region EdTrainSupervisorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdTrainSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainSupervisorParameterBuilder : ParameterizedSqlFilterBuilder<EdTrainSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorParameterBuilder class.
		/// </summary>
		public EdTrainSupervisorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainSupervisorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainSupervisorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainSupervisorParameterBuilder
	
	#region EdTrainSupervisorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdTrainSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainSupervisor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdTrainSupervisorSortBuilder : SqlSortBuilder<EdTrainSupervisorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainSupervisorSqlSortBuilder class.
		/// </summary>
		public EdTrainSupervisorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdTrainSupervisorSortBuilder
	
} // end namespace
