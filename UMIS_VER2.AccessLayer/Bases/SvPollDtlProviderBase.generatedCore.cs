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
	/// This class is the base class for any <see cref="SvPollDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvPollDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvPollDtl, UMIS_VER2.BusinessLyer.SvPollDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvPollDtlKey key)
		{
			return Delete(transactionManager, key.SvPollDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svPollDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svPollDtlId)
		{
			return Delete(null, _svPollDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svPollDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.SvPollDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvPollDtlKey key, int start, int pageLength)
		{
			return GetBySvPollDtlId(transactionManager, key.SvPollDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public TList<SvPollDtl> GetBySvPollHdrId(System.Decimal _svPollHdrId)
		{
			int count = -1;
			return GetBySvPollHdrId(null,_svPollHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public TList<SvPollDtl> GetBySvPollHdrId(System.Decimal _svPollHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollHdrId(null, _svPollHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public TList<SvPollDtl> GetBySvPollHdrId(TransactionManager transactionManager, System.Decimal _svPollHdrId)
		{
			int count = -1;
			return GetBySvPollHdrId(transactionManager, _svPollHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public TList<SvPollDtl> GetBySvPollHdrId(TransactionManager transactionManager, System.Decimal _svPollHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollHdrId(transactionManager, _svPollHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public TList<SvPollDtl> GetBySvPollHdrId(System.Decimal _svPollHdrId, int start, int pageLength, out int count)
		{
			return GetBySvPollHdrId(null, _svPollHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_POLL_HDR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvPollDtl&gt;"/> class.</returns>
		public abstract TList<SvPollDtl> GetBySvPollHdrId(TransactionManager transactionManager, System.Decimal _svPollHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(null,_svPollDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength, out int count)
		{
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(System.Decimal _svPollHdrId, System.String _optionText)
		{
			int count = -1;
			return GetBySvPollHdrIdOptionText(null,_svPollHdrId, _optionText, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(System.Decimal _svPollHdrId, System.String _optionText, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollHdrIdOptionText(null, _svPollHdrId, _optionText, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(TransactionManager transactionManager, System.Decimal _svPollHdrId, System.String _optionText)
		{
			int count = -1;
			return GetBySvPollHdrIdOptionText(transactionManager, _svPollHdrId, _optionText, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(TransactionManager transactionManager, System.Decimal _svPollHdrId, System.String _optionText, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollHdrIdOptionText(transactionManager, _svPollHdrId, _optionText, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(System.Decimal _svPollHdrId, System.String _optionText, int start, int pageLength, out int count)
		{
			return GetBySvPollHdrIdOptionText(null, _svPollHdrId, _optionText, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_POLL_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollHdrId"></param>
		/// <param name="_optionText"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvPollDtl GetBySvPollHdrIdOptionText(TransactionManager transactionManager, System.Decimal _svPollHdrId, System.String _optionText, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvPollDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvPollDtl&gt;"/></returns>
		public static TList<SvPollDtl> Fill(IDataReader reader, TList<SvPollDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvPollDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvPollDtl")
					.Append("|").Append((System.Decimal)reader["SV_POLL_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvPollDtl>(
					key.ToString(), // EntityTrackingKey
					"SvPollDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvPollDtl();
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
					c.SvPollDtlId = (System.Decimal)reader["SV_POLL_DTL_ID"];
					c.OriginalSvPollDtlId = c.SvPollDtlId;
					c.SvPollHdrId = (System.Decimal)reader["SV_POLL_HDR_ID"];
					c.OptionText = (System.String)reader["OPTION_TEXT"];
					c.DispOrder = (System.Decimal)reader["DISP_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvPollDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.SvPollDtlId = (System.Decimal)reader[((int)SvPollDtlColumn.SvPollDtlId - 1)];
			entity.OriginalSvPollDtlId = (System.Decimal)reader["SV_POLL_DTL_ID"];
			entity.SvPollHdrId = (System.Decimal)reader[((int)SvPollDtlColumn.SvPollHdrId - 1)];
			entity.OptionText = (System.String)reader[((int)SvPollDtlColumn.OptionText - 1)];
			entity.DispOrder = (System.Decimal)reader[((int)SvPollDtlColumn.DispOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvPollDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvPollDtlId = (System.Decimal)dataRow["SV_POLL_DTL_ID"];
			entity.OriginalSvPollDtlId = (System.Decimal)dataRow["SV_POLL_DTL_ID"];
			entity.SvPollHdrId = (System.Decimal)dataRow["SV_POLL_HDR_ID"];
			entity.OptionText = (System.String)dataRow["OPTION_TEXT"];
			entity.DispOrder = (System.Decimal)dataRow["DISP_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvPollDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvPollDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvPollDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvPollDtlIdSource	
			if (CanDeepLoad(entity, "SvPollDtl|SvPollDtlIdSource", deepLoadType, innerList) 
				&& entity.SvPollDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvPollDtlId;
				SvPollDtl tmpEntity = EntityManager.LocateEntity<SvPollDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvPollDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvPollDtlIdSource = tmpEntity;
				else
					entity.SvPollDtlIdSource = DataRepository.SvPollDtlProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvPollDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvPollDtlProvider.DeepLoad(transactionManager, entity.SvPollDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvPollDtlIdSource

			#region SvPollHdrIdSource	
			if (CanDeepLoad(entity, "SvPollHdr|SvPollHdrIdSource", deepLoadType, innerList) 
				&& entity.SvPollHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvPollHdrId;
				SvPollHdr tmpEntity = EntityManager.LocateEntity<SvPollHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(SvPollHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvPollHdrIdSource = tmpEntity;
				else
					entity.SvPollHdrIdSource = DataRepository.SvPollHdrProvider.GetBySvPollHdrId(transactionManager, entity.SvPollHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvPollHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvPollHdrProvider.DeepLoad(transactionManager, entity.SvPollHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvPollHdrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvPollDtlId methods when available
			
			#region SvPollDtl
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "SvPollDtl|SvPollDtl", deepLoadType, innerList))
			{
				entity.SvPollDtl = DataRepository.SvPollDtlProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollDtl' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.SvPollDtl != null)
				{
					deepHandles.Add("SvPollDtl",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< SvPollDtl >) DataRepository.SvPollDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollDtl, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region SvStudPollCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudPoll>|SvStudPollCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudPollCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudPollCollection = DataRepository.SvStudPollProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);

				if (deep && entity.SvStudPollCollection.Count > 0)
				{
					deepHandles.Add("SvStudPollCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudPoll>) DataRepository.SvStudPollProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudPollCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffPollCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffPoll>|SvStaffPollCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffPollCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffPollCollection = DataRepository.SvStaffPollProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);

				if (deep && entity.SvStaffPollCollection.Count > 0)
				{
					deepHandles.Add("SvStaffPollCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffPoll>) DataRepository.SvStaffPollProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffPollCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvPollDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvPollDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvPollDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvPollDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvPollDtlIdSource
			if (CanDeepSave(entity, "SvPollDtl|SvPollDtlIdSource", deepSaveType, innerList) 
				&& entity.SvPollDtlIdSource != null)
			{
				DataRepository.SvPollDtlProvider.Save(transactionManager, entity.SvPollDtlIdSource);
				entity.SvPollDtlId = entity.SvPollDtlIdSource.SvPollDtlId;
			}
			#endregion 
			
			#region SvPollHdrIdSource
			if (CanDeepSave(entity, "SvPollHdr|SvPollHdrIdSource", deepSaveType, innerList) 
				&& entity.SvPollHdrIdSource != null)
			{
				DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrIdSource);
				entity.SvPollHdrId = entity.SvPollHdrIdSource.SvPollHdrId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region SvPollDtl
			if (CanDeepSave(entity.SvPollDtl, "SvPollDtl|SvPollDtl", deepSaveType, innerList))
			{

				if (entity.SvPollDtl != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.SvPollDtl.SvPollDtlId = entity.SvPollDtlId;
					//DataRepository.SvPollDtlProvider.Save(transactionManager, entity.SvPollDtl);
					deepHandles.Add("SvPollDtl",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< SvPollDtl >) DataRepository.SvPollDtlProvider.DeepSave,
						new object[] { transactionManager, entity.SvPollDtl, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<SvStudPoll>
				if (CanDeepSave(entity.SvStudPollCollection, "List<SvStudPoll>|SvStudPollCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudPoll child in entity.SvStudPollCollection)
					{
						if(child.SvPollDtlIdSource != null)
						{
							child.SvPollDtlId = child.SvPollDtlIdSource.SvPollDtlId;
						}
						else
						{
							child.SvPollDtlId = entity.SvPollDtlId;
						}

					}

					if (entity.SvStudPollCollection.Count > 0 || entity.SvStudPollCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudPollProvider.Save(transactionManager, entity.SvStudPollCollection);
						
						deepHandles.Add("SvStudPollCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudPoll >) DataRepository.SvStudPollProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudPollCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffPoll>
				if (CanDeepSave(entity.SvStaffPollCollection, "List<SvStaffPoll>|SvStaffPollCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffPoll child in entity.SvStaffPollCollection)
					{
						if(child.SvPollDtlIdSource != null)
						{
							child.SvPollDtlId = child.SvPollDtlIdSource.SvPollDtlId;
						}
						else
						{
							child.SvPollDtlId = entity.SvPollDtlId;
						}

					}

					if (entity.SvStaffPollCollection.Count > 0 || entity.SvStaffPollCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffPollProvider.Save(transactionManager, entity.SvStaffPollCollection);
						
						deepHandles.Add("SvStaffPollCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffPoll >) DataRepository.SvStaffPollProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffPollCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvPollDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvPollDtl</c>
	///</summary>
	public enum SvPollDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvPollDtl</c> at SvPollDtlIdSource
		///</summary>
		[ChildEntityType(typeof(SvPollDtl))]
		SvPollDtl,
		
		///<summary>
		/// Composite Property for <c>SvPollHdr</c> at SvPollHdrIdSource
		///</summary>
		[ChildEntityType(typeof(SvPollHdr))]
		SvPollHdr,
		///<summary>
		/// Collection of <c>SvPollDtl</c> as OneToMany for SvStudPollCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudPoll>))]
		SvStudPollCollection,
		///<summary>
		/// Collection of <c>SvPollDtl</c> as OneToMany for SvStaffPollCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffPoll>))]
		SvStaffPollCollection,
	}
	
	#endregion SvPollDtlChildEntityTypes
	
	#region SvPollDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvPollDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvPollDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvPollDtlFilterBuilder : SqlFilterBuilder<SvPollDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvPollDtlFilterBuilder class.
		/// </summary>
		public SvPollDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvPollDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvPollDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvPollDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvPollDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvPollDtlFilterBuilder
	
	#region SvPollDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvPollDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvPollDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvPollDtlParameterBuilder : ParameterizedSqlFilterBuilder<SvPollDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvPollDtlParameterBuilder class.
		/// </summary>
		public SvPollDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvPollDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvPollDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvPollDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvPollDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvPollDtlParameterBuilder
	
	#region SvPollDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvPollDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvPollDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvPollDtlSortBuilder : SqlSortBuilder<SvPollDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvPollDtlSqlSortBuilder class.
		/// </summary>
		public SvPollDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvPollDtlSortBuilder
	
} // end namespace
