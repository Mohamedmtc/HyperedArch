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
	/// This class is the base class for any <see cref="FeeFineDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFineDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFineDtl, UMIS_VER2.BusinessLyer.FeeFineDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineDtlKey key)
		{
			return Delete(transactionManager, key.FeeFineDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeFineDtlId)
		{
			return Delete(null, _feeFineDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeFineDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		FK_FEE_FINE_DTL_FEE_FINE Description: 
		/// </summary>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetByFeeFineId(System.Int32 _feeFineId)
		{
			int count = -1;
			return GetByFeeFineId(_feeFineId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		FK_FEE_FINE_DTL_FEE_FINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFineDtl> GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId)
		{
			int count = -1;
			return GetByFeeFineId(transactionManager, _feeFineId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		FK_FEE_FINE_DTL_FEE_FINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFineId(transactionManager, _feeFineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		fkFeeFineDtlFeeFine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetByFeeFineId(System.Int32 _feeFineId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeFineId(null, _feeFineId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		fkFeeFineDtlFeeFine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetByFeeFineId(System.Int32 _feeFineId, int start, int pageLength,out int count)
		{
			return GetByFeeFineId(null, _feeFineId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_FEE_FINE key.
		///		FK_FEE_FINE_DTL_FEE_FINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public abstract TList<FeeFineDtl> GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		FK_FEE_FINE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		FK_FEE_FINE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFineDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		FK_FEE_FINE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		fkFeeFineDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		fkFeeFineDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public TList<FeeFineDtl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_DTL_SE_USER key.
		///		FK_FEE_FINE_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFineDtl objects.</returns>
		public abstract TList<FeeFineDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeFineDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineDtlKey key, int start, int pageLength)
		{
			return GetByFeeFineDtlId(transactionManager, key.FeeFineDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(System.Int32 _feeFineDtlId)
		{
			int count = -1;
			return GetByFeeFineDtlId(null,_feeFineDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(System.Int32 _feeFineDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFineDtlId(null, _feeFineDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(TransactionManager transactionManager, System.Int32 _feeFineDtlId)
		{
			int count = -1;
			return GetByFeeFineDtlId(transactionManager, _feeFineDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(TransactionManager transactionManager, System.Int32 _feeFineDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFineDtlId(transactionManager, _feeFineDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(System.Int32 _feeFineDtlId, int start, int pageLength, out int count)
		{
			return GetByFeeFineDtlId(null, _feeFineDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineDtlId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFineDtl GetByFeeFineDtlId(TransactionManager transactionManager, System.Int32 _feeFineDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFineDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFineDtl&gt;"/></returns>
		public static TList<FeeFineDtl> Fill(IDataReader reader, TList<FeeFineDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFineDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFineDtl")
					.Append("|").Append((System.Int32)reader["FEE_FINE_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFineDtl>(
					key.ToString(), // EntityTrackingKey
					"FeeFineDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFineDtl();
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
					c.FeeFineDtlId = (System.Int32)reader["FEE_FINE_DTL_ID"];
					c.OriginalFeeFineDtlId = c.FeeFineDtlId;
					c.FeeFineId = (System.Int32)reader["FEE_FINE_ID"];
					c.DelaySeq = (System.Int32)reader["DELAY_SEQ"];
					c.FinePrcnt = (System.Decimal)reader["FINE_PRCNT"];
					c.FineValue = (System.Decimal)reader["FINE_VALUE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFineDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFineDtlId = (System.Int32)reader[((int)FeeFineDtlColumn.FeeFineDtlId - 1)];
			entity.OriginalFeeFineDtlId = (System.Int32)reader["FEE_FINE_DTL_ID"];
			entity.FeeFineId = (System.Int32)reader[((int)FeeFineDtlColumn.FeeFineId - 1)];
			entity.DelaySeq = (System.Int32)reader[((int)FeeFineDtlColumn.DelaySeq - 1)];
			entity.FinePrcnt = (System.Decimal)reader[((int)FeeFineDtlColumn.FinePrcnt - 1)];
			entity.FineValue = (System.Decimal)reader[((int)FeeFineDtlColumn.FineValue - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeFineDtlColumn.Notes - 1)))?null:(System.String)reader[((int)FeeFineDtlColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeFineDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeFineDtlColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeFineDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeFineDtlColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFineDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFineDtlId = (System.Int32)dataRow["FEE_FINE_DTL_ID"];
			entity.OriginalFeeFineDtlId = (System.Int32)dataRow["FEE_FINE_DTL_ID"];
			entity.FeeFineId = (System.Int32)dataRow["FEE_FINE_ID"];
			entity.DelaySeq = (System.Int32)dataRow["DELAY_SEQ"];
			entity.FinePrcnt = (System.Decimal)dataRow["FINE_PRCNT"];
			entity.FineValue = (System.Decimal)dataRow["FINE_VALUE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFineDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFineDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeFineIdSource	
			if (CanDeepLoad(entity, "FeeFine|FeeFineIdSource", deepLoadType, innerList) 
				&& entity.FeeFineIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFineId;
				FeeFine tmpEntity = EntityManager.LocateEntity<FeeFine>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFine), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFineIdSource = tmpEntity;
				else
					entity.FeeFineIdSource = DataRepository.FeeFineProvider.GetByFeeFineId(transactionManager, entity.FeeFineId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFineIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFineIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFineProvider.DeepLoad(transactionManager, entity.FeeFineIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFineIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFineDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFineDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFineDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeFineIdSource
			if (CanDeepSave(entity, "FeeFine|FeeFineIdSource", deepSaveType, innerList) 
				&& entity.FeeFineIdSource != null)
			{
				DataRepository.FeeFineProvider.Save(transactionManager, entity.FeeFineIdSource);
				entity.FeeFineId = entity.FeeFineIdSource.FeeFineId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region FeeFineDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFineDtl</c>
	///</summary>
	public enum FeeFineDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeFine</c> at FeeFineIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFine))]
		FeeFine,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion FeeFineDtlChildEntityTypes
	
	#region FeeFineDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFineDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFineDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFineDtlFilterBuilder : SqlFilterBuilder<FeeFineDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlFilterBuilder class.
		/// </summary>
		public FeeFineDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFineDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFineDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFineDtlFilterBuilder
	
	#region FeeFineDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFineDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFineDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFineDtlParameterBuilder : ParameterizedSqlFilterBuilder<FeeFineDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlParameterBuilder class.
		/// </summary>
		public FeeFineDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFineDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFineDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFineDtlParameterBuilder
	
	#region FeeFineDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFineDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFineDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFineDtlSortBuilder : SqlSortBuilder<FeeFineDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineDtlSqlSortBuilder class.
		/// </summary>
		public FeeFineDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFineDtlSortBuilder
	
} // end namespace
