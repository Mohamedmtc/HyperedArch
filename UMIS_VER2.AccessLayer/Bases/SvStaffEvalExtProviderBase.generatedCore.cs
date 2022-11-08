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
	/// This class is the base class for any <see cref="SvStaffEvalExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStaffEvalExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStaffEvalExt, UMIS_VER2.BusinessLyer.SvStaffEvalExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalExtKey key)
		{
			return Delete(transactionManager, key.SvStaffEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStaffEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStaffEvalExtId)
		{
			return Delete(null, _svStaffEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="_svCdeEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(_svCdeEvalExtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		fkSvStaffEvalExtSvCdeEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		fkSvStaffEvalExtSvCdeEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength,out int count)
		{
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_STAFF_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public abstract TList<SvStaffEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL Description: 
		/// </summary>
		/// <param name="_svStaffEvlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvStaffEvlId(System.Decimal _svStaffEvlId)
		{
			int count = -1;
			return GetBySvStaffEvlId(_svStaffEvlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffEvalExt> GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId)
		{
			int count = -1;
			return GetBySvStaffEvlId(transactionManager, _svStaffEvlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvlId(transactionManager, _svStaffEvlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		fkSvStaffEvalExtSvStaffEvl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvStaffEvlId(System.Decimal _svStaffEvlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvStaffEvlId(null, _svStaffEvlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		fkSvStaffEvalExtSvStaffEvl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public TList<SvStaffEvalExt> GetBySvStaffEvlId(System.Decimal _svStaffEvlId, int start, int pageLength,out int count)
		{
			return GetBySvStaffEvlId(null, _svStaffEvlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL key.
		///		FK_SV_STAFF_EVAL_EXT_SV_STAFF_EVL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffEvalExt objects.</returns>
		public abstract TList<SvStaffEvalExt> GetBySvStaffEvlId(TransactionManager transactionManager, System.Decimal _svStaffEvlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStaffEvalExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalExtKey key, int start, int pageLength)
		{
			return GetBySvStaffEvalExtId(transactionManager, key.SvStaffEvalExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStaffEvalExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(null,_svStaffEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(null, _svStaffEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(transactionManager, _svStaffEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(transactionManager, _svStaffEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId, int start, int pageLength, out int count)
		{
			return GetBySvStaffEvalExtId(null, _svStaffEvalExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStaffEvalExt GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStaffEvalExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStaffEvalExt&gt;"/></returns>
		public static TList<SvStaffEvalExt> Fill(IDataReader reader, TList<SvStaffEvalExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStaffEvalExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStaffEvalExt")
					.Append("|").Append((System.Decimal)reader["SV_STAFF_EVAL_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStaffEvalExt>(
					key.ToString(), // EntityTrackingKey
					"SvStaffEvalExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStaffEvalExt();
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
					c.SvStaffEvalExtId = (System.Decimal)reader["SV_STAFF_EVAL_EXT_ID"];
					c.OriginalSvStaffEvalExtId = c.SvStaffEvalExtId;
					c.SvStaffEvlId = (System.Decimal)reader["SV_STAFF_EVL_ID"];
					c.SvCdeEvalExtId = (System.Int32)reader["SV_CDE_EVAL_EXT_ID"];
					c.Ordr = Convert.IsDBNull(reader["ORDR"]) ? null : (System.Decimal?)reader["ORDR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStaffEvalExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStaffEvalExtId = (System.Decimal)reader[((int)SvStaffEvalExtColumn.SvStaffEvalExtId - 1)];
			entity.OriginalSvStaffEvalExtId = (System.Decimal)reader["SV_STAFF_EVAL_EXT_ID"];
			entity.SvStaffEvlId = (System.Decimal)reader[((int)SvStaffEvalExtColumn.SvStaffEvlId - 1)];
			entity.SvCdeEvalExtId = (System.Int32)reader[((int)SvStaffEvalExtColumn.SvCdeEvalExtId - 1)];
			entity.Ordr = (reader.IsDBNull(((int)SvStaffEvalExtColumn.Ordr - 1)))?null:(System.Decimal?)reader[((int)SvStaffEvalExtColumn.Ordr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStaffEvalExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStaffEvalExtId = (System.Decimal)dataRow["SV_STAFF_EVAL_EXT_ID"];
			entity.OriginalSvStaffEvalExtId = (System.Decimal)dataRow["SV_STAFF_EVAL_EXT_ID"];
			entity.SvStaffEvlId = (System.Decimal)dataRow["SV_STAFF_EVL_ID"];
			entity.SvCdeEvalExtId = (System.Int32)dataRow["SV_CDE_EVAL_EXT_ID"];
			entity.Ordr = Convert.IsDBNull(dataRow["ORDR"]) ? null : (System.Decimal?)dataRow["ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffEvalExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvalExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeEvalExtIdSource	
			if (CanDeepLoad(entity, "SvCdeEvalExt|SvCdeEvalExtIdSource", deepLoadType, innerList) 
				&& entity.SvCdeEvalExtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeEvalExtId;
				SvCdeEvalExt tmpEntity = EntityManager.LocateEntity<SvCdeEvalExt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeEvalExt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeEvalExtIdSource = tmpEntity;
				else
					entity.SvCdeEvalExtIdSource = DataRepository.SvCdeEvalExtProvider.GetBySvCdeEvalExtId(transactionManager, entity.SvCdeEvalExtId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeEvalExtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeEvalExtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeEvalExtProvider.DeepLoad(transactionManager, entity.SvCdeEvalExtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeEvalExtIdSource

			#region SvStaffEvlIdSource	
			if (CanDeepLoad(entity, "SvStaffEvl|SvStaffEvlIdSource", deepLoadType, innerList) 
				&& entity.SvStaffEvlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvStaffEvlId;
				SvStaffEvl tmpEntity = EntityManager.LocateEntity<SvStaffEvl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvStaffEvl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvStaffEvlIdSource = tmpEntity;
				else
					entity.SvStaffEvlIdSource = DataRepository.SvStaffEvlProvider.GetBySvStaffEvlId(transactionManager, entity.SvStaffEvlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvStaffEvlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvStaffEvlProvider.DeepLoad(transactionManager, entity.SvStaffEvlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvStaffEvlIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvStaffEvalExtId methods when available
			
			#region SvStudStaffEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudStaffEvalExt>|SvStudStaffEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudStaffEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudStaffEvalExtCollection = DataRepository.SvStudStaffEvalExtProvider.GetBySvStaffEvalExtId(transactionManager, entity.SvStaffEvalExtId);

				if (deep && entity.SvStudStaffEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStudStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudStaffEvalExt>) DataRepository.SvStudStaffEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudStaffEvalExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStaffEvalExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStaffEvalExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffEvalExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffEvalExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeEvalExtIdSource
			if (CanDeepSave(entity, "SvCdeEvalExt|SvCdeEvalExtIdSource", deepSaveType, innerList) 
				&& entity.SvCdeEvalExtIdSource != null)
			{
				DataRepository.SvCdeEvalExtProvider.Save(transactionManager, entity.SvCdeEvalExtIdSource);
				entity.SvCdeEvalExtId = entity.SvCdeEvalExtIdSource.SvCdeEvalExtId;
			}
			#endregion 
			
			#region SvStaffEvlIdSource
			if (CanDeepSave(entity, "SvStaffEvl|SvStaffEvlIdSource", deepSaveType, innerList) 
				&& entity.SvStaffEvlIdSource != null)
			{
				DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlIdSource);
				entity.SvStaffEvlId = entity.SvStaffEvlIdSource.SvStaffEvlId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudStaffEvalExt>
				if (CanDeepSave(entity.SvStudStaffEvalExtCollection, "List<SvStudStaffEvalExt>|SvStudStaffEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudStaffEvalExt child in entity.SvStudStaffEvalExtCollection)
					{
						if(child.SvStaffEvalExtIdSource != null)
						{
							child.SvStaffEvalExtId = child.SvStaffEvalExtIdSource.SvStaffEvalExtId;
						}
						else
						{
							child.SvStaffEvalExtId = entity.SvStaffEvalExtId;
						}

					}

					if (entity.SvStudStaffEvalExtCollection.Count > 0 || entity.SvStudStaffEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudStaffEvalExtProvider.Save(transactionManager, entity.SvStudStaffEvalExtCollection);
						
						deepHandles.Add("SvStudStaffEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudStaffEvalExt >) DataRepository.SvStudStaffEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudStaffEvalExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvStaffEvalExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStaffEvalExt</c>
	///</summary>
	public enum SvStaffEvalExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeEvalExt</c> at SvCdeEvalExtIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeEvalExt))]
		SvCdeEvalExt,
		
		///<summary>
		/// Composite Property for <c>SvStaffEvl</c> at SvStaffEvlIdSource
		///</summary>
		[ChildEntityType(typeof(SvStaffEvl))]
		SvStaffEvl,
		///<summary>
		/// Collection of <c>SvStaffEvalExt</c> as OneToMany for SvStudStaffEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudStaffEvalExt>))]
		SvStudStaffEvalExtCollection,
	}
	
	#endregion SvStaffEvalExtChildEntityTypes
	
	#region SvStaffEvalExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvalExtFilterBuilder : SqlFilterBuilder<SvStaffEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtFilterBuilder class.
		/// </summary>
		public SvStaffEvalExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvalExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvalExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvalExtFilterBuilder
	
	#region SvStaffEvalExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffEvalExtParameterBuilder : ParameterizedSqlFilterBuilder<SvStaffEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtParameterBuilder class.
		/// </summary>
		public SvStaffEvalExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffEvalExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffEvalExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffEvalExtParameterBuilder
	
	#region SvStaffEvalExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffEvalExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStaffEvalExtSortBuilder : SqlSortBuilder<SvStaffEvalExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffEvalExtSqlSortBuilder class.
		/// </summary>
		public SvStaffEvalExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStaffEvalExtSortBuilder
	
} // end namespace
