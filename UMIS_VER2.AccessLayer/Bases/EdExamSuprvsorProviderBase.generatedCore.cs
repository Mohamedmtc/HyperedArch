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
	/// This class is the base class for any <see cref="EdExamSuprvsorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdExamSuprvsorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdExamSuprvsor, UMIS_VER2.BusinessLyer.EdExamSuprvsorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSuprvsorKey key)
		{
			return Delete(transactionManager, key.EdExamSuprvsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edExamSuprvsorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edExamSuprvsorId)
		{
			return Delete(null, _edExamSuprvsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSuprvsorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edExamSuprvsorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamSuprvsor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		fkEdExamSuprvsorSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		fkEdExamSuprvsorSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER key.
		///		FK_ED_EXAM_SUPRVSOR_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public abstract TList<EdExamSuprvsor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamSuprvsor> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		fkEdExamSuprvsorScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		fkEdExamSuprvsorScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public TList<EdExamSuprvsor> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL key.
		///		FK_ED_EXAM_SUPRVSOR_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSuprvsor objects.</returns>
		public abstract TList<EdExamSuprvsor> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdExamSuprvsor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSuprvsorKey key, int start, int pageLength)
		{
			return GetByEdExamSuprvsorId(transactionManager, key.EdExamSuprvsorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_edExamSuprvsorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(System.Decimal _edExamSuprvsorId)
		{
			int count = -1;
			return GetByEdExamSuprvsorId(null,_edExamSuprvsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_edExamSuprvsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(System.Decimal _edExamSuprvsorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSuprvsorId(null, _edExamSuprvsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSuprvsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(TransactionManager transactionManager, System.Decimal _edExamSuprvsorId)
		{
			int count = -1;
			return GetByEdExamSuprvsorId(transactionManager, _edExamSuprvsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSuprvsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(TransactionManager transactionManager, System.Decimal _edExamSuprvsorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSuprvsorId(transactionManager, _edExamSuprvsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_edExamSuprvsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(System.Decimal _edExamSuprvsorId, int start, int pageLength, out int count)
		{
			return GetByEdExamSuprvsorId(null, _edExamSuprvsorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSuprvsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByEdExamSuprvsorId(TransactionManager transactionManager, System.Decimal _edExamSuprvsorId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMemberId(null,_scScheduleDtlId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMemberId(null, _scScheduleDtlId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMemberId(transactionManager, _scScheduleDtlId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMemberId(transactionManager, _scScheduleDtlId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlIdSaStfMemberId(null, _scScheduleDtlId, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SUPRVSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamSuprvsor GetByScScheduleDtlIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdExamSuprvsor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdExamSuprvsor&gt;"/></returns>
		public static TList<EdExamSuprvsor> Fill(IDataReader reader, TList<EdExamSuprvsor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdExamSuprvsor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdExamSuprvsor")
					.Append("|").Append((System.Decimal)reader["ED_EXAM_SUPRVSOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdExamSuprvsor>(
					key.ToString(), // EntityTrackingKey
					"EdExamSuprvsor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdExamSuprvsor();
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
					c.EdExamSuprvsorId = (System.Decimal)reader["ED_EXAM_SUPRVSOR_ID"];
					c.OriginalEdExamSuprvsorId = c.EdExamSuprvsorId;
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Decimal?)reader["TYPE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdExamSuprvsor entity)
		{
			if (!reader.Read()) return;
			
			entity.EdExamSuprvsorId = (System.Decimal)reader[((int)EdExamSuprvsorColumn.EdExamSuprvsorId - 1)];
			entity.OriginalEdExamSuprvsorId = (System.Decimal)reader["ED_EXAM_SUPRVSOR_ID"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)EdExamSuprvsorColumn.ScScheduleDtlId - 1)];
			entity.TypeFlg = (reader.IsDBNull(((int)EdExamSuprvsorColumn.TypeFlg - 1)))?null:(System.Decimal?)reader[((int)EdExamSuprvsorColumn.TypeFlg - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)EdExamSuprvsorColumn.SaStfMemberId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdExamSuprvsor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdExamSuprvsorId = (System.Decimal)dataRow["ED_EXAM_SUPRVSOR_ID"];
			entity.OriginalEdExamSuprvsorId = (System.Decimal)dataRow["ED_EXAM_SUPRVSOR_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Decimal?)dataRow["TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSuprvsor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamSuprvsor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSuprvsor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region ScScheduleDtlIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleDtlId;
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlProvider.DeepLoad(transactionManager, entity.ScScheduleDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdExamSuprvsor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdExamSuprvsor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamSuprvsor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSuprvsor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region ScScheduleDtlIdSource
			if (CanDeepSave(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlIdSource != null)
			{
				DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlIdSource);
				entity.ScScheduleDtlId = entity.ScScheduleDtlIdSource.ScScheduleDtlId;
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
	
	#region EdExamSuprvsorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdExamSuprvsor</c>
	///</summary>
	public enum EdExamSuprvsorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion EdExamSuprvsorChildEntityTypes
	
	#region EdExamSuprvsorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdExamSuprvsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSuprvsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamSuprvsorFilterBuilder : SqlFilterBuilder<EdExamSuprvsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorFilterBuilder class.
		/// </summary>
		public EdExamSuprvsorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamSuprvsorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamSuprvsorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamSuprvsorFilterBuilder
	
	#region EdExamSuprvsorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdExamSuprvsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSuprvsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamSuprvsorParameterBuilder : ParameterizedSqlFilterBuilder<EdExamSuprvsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorParameterBuilder class.
		/// </summary>
		public EdExamSuprvsorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamSuprvsorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamSuprvsorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamSuprvsorParameterBuilder
	
	#region EdExamSuprvsorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdExamSuprvsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSuprvsor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdExamSuprvsorSortBuilder : SqlSortBuilder<EdExamSuprvsorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSuprvsorSqlSortBuilder class.
		/// </summary>
		public EdExamSuprvsorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdExamSuprvsorSortBuilder
	
} // end namespace
