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
	/// This class is the base class for any <see cref="SvMsgTmpltParamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvMsgTmpltParamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvMsgTmpltParam, UMIS_VER2.BusinessLyer.SvMsgTmpltParamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMsgTmpltParamKey key)
		{
			return Delete(transactionManager, key.SvMsgTmpltParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svMsgTmpltParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svMsgTmpltParamId)
		{
			return Delete(null, _svMsgTmpltParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMsgTmpltParamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svMsgTmpltParamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(_svAutoMsgTmpltId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		/// <remarks></remarks>
		public TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		fkSvMsgTmpltParamSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		fkSvMsgTmpltParamSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId, int start, int pageLength,out int count)
		{
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public abstract TList<SvMsgTmpltParam> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM Description: 
		/// </summary>
		/// <param name="_svCdeMsgParamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(_svCdeMsgParamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		/// <remarks></remarks>
		public TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(transactionManager, _svCdeMsgParamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeMsgParamId(transactionManager, _svCdeMsgParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		fkSvMsgTmpltParamSvCdeMsgParam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeMsgParamId(null, _svCdeMsgParamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		fkSvMsgTmpltParamSvCdeMsgParam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(System.Int32 _svCdeMsgParamId, int start, int pageLength,out int count)
		{
			return GetBySvCdeMsgParamId(null, _svCdeMsgParamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM key.
		///		FK_SV_MSG_TMPLT_PARAM_SV_CDE_MSG_PARAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeMsgParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMsgTmpltParam objects.</returns>
		public abstract TList<SvMsgTmpltParam> GetBySvCdeMsgParamId(TransactionManager transactionManager, System.Int32 _svCdeMsgParamId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvMsgTmpltParam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMsgTmpltParamKey key, int start, int pageLength)
		{
			return GetBySvMsgTmpltParamId(transactionManager, key.SvMsgTmpltParamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(System.Int32 _svMsgTmpltParamId)
		{
			int count = -1;
			return GetBySvMsgTmpltParamId(null,_svMsgTmpltParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(System.Int32 _svMsgTmpltParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMsgTmpltParamId(null, _svMsgTmpltParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(TransactionManager transactionManager, System.Int32 _svMsgTmpltParamId)
		{
			int count = -1;
			return GetBySvMsgTmpltParamId(transactionManager, _svMsgTmpltParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(TransactionManager transactionManager, System.Int32 _svMsgTmpltParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMsgTmpltParamId(transactionManager, _svMsgTmpltParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(System.Int32 _svMsgTmpltParamId, int start, int pageLength, out int count)
		{
			return GetBySvMsgTmpltParamId(null, _svMsgTmpltParamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MSG_TMPLT_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMsgTmpltParamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvMsgTmpltParam GetBySvMsgTmpltParamId(TransactionManager transactionManager, System.Int32 _svMsgTmpltParamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvMsgTmpltParam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvMsgTmpltParam&gt;"/></returns>
		public static TList<SvMsgTmpltParam> Fill(IDataReader reader, TList<SvMsgTmpltParam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvMsgTmpltParam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvMsgTmpltParam")
					.Append("|").Append((System.Int32)reader["SV_MSG_TMPLT_PARAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvMsgTmpltParam>(
					key.ToString(), // EntityTrackingKey
					"SvMsgTmpltParam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvMsgTmpltParam();
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
					c.SvMsgTmpltParamId = (System.Int32)reader["SV_MSG_TMPLT_PARAM_ID"];
					c.OriginalSvMsgTmpltParamId = c.SvMsgTmpltParamId;
					c.SvAutoMsgTmpltId = (System.Decimal)reader["SV_AUTO_MSG_TMPLT_ID"];
					c.SvCdeMsgParamId = (System.Int32)reader["SV_CDE_MSG_PARAM_ID"];
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Int32?)reader["TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvMsgTmpltParam entity)
		{
			if (!reader.Read()) return;
			
			entity.SvMsgTmpltParamId = (System.Int32)reader[((int)SvMsgTmpltParamColumn.SvMsgTmpltParamId - 1)];
			entity.OriginalSvMsgTmpltParamId = (System.Int32)reader["SV_MSG_TMPLT_PARAM_ID"];
			entity.SvAutoMsgTmpltId = (System.Decimal)reader[((int)SvMsgTmpltParamColumn.SvAutoMsgTmpltId - 1)];
			entity.SvCdeMsgParamId = (System.Int32)reader[((int)SvMsgTmpltParamColumn.SvCdeMsgParamId - 1)];
			entity.TypeFlg = (reader.IsDBNull(((int)SvMsgTmpltParamColumn.TypeFlg - 1)))?null:(System.Int32?)reader[((int)SvMsgTmpltParamColumn.TypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvMsgTmpltParam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvMsgTmpltParamId = (System.Int32)dataRow["SV_MSG_TMPLT_PARAM_ID"];
			entity.OriginalSvMsgTmpltParamId = (System.Int32)dataRow["SV_MSG_TMPLT_PARAM_ID"];
			entity.SvAutoMsgTmpltId = (System.Decimal)dataRow["SV_AUTO_MSG_TMPLT_ID"];
			entity.SvCdeMsgParamId = (System.Int32)dataRow["SV_CDE_MSG_PARAM_ID"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Int32?)dataRow["TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMsgTmpltParam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMsgTmpltParam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMsgTmpltParam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvAutoMsgTmpltIdSource	
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepLoadType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvAutoMsgTmpltId;
				SvAutoMsgTmplt tmpEntity = EntityManager.LocateEntity<SvAutoMsgTmplt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvAutoMsgTmplt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvAutoMsgTmpltIdSource = tmpEntity;
				else
					entity.SvAutoMsgTmpltIdSource = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvAutoMsgTmpltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvAutoMsgTmpltProvider.DeepLoad(transactionManager, entity.SvAutoMsgTmpltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvAutoMsgTmpltIdSource

			#region SvCdeMsgParamIdSource	
			if (CanDeepLoad(entity, "SvCdeMsgParam|SvCdeMsgParamIdSource", deepLoadType, innerList) 
				&& entity.SvCdeMsgParamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeMsgParamId;
				SvCdeMsgParam tmpEntity = EntityManager.LocateEntity<SvCdeMsgParam>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeMsgParam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeMsgParamIdSource = tmpEntity;
				else
					entity.SvCdeMsgParamIdSource = DataRepository.SvCdeMsgParamProvider.GetBySvCdeMsgParamId(transactionManager, entity.SvCdeMsgParamId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeMsgParamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeMsgParamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeMsgParamProvider.DeepLoad(transactionManager, entity.SvCdeMsgParamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeMsgParamIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvMsgTmpltParam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvMsgTmpltParam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMsgTmpltParam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMsgTmpltParam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvAutoMsgTmpltIdSource
			if (CanDeepSave(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepSaveType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource != null)
			{
				DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltIdSource);
				entity.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
			}
			#endregion 
			
			#region SvCdeMsgParamIdSource
			if (CanDeepSave(entity, "SvCdeMsgParam|SvCdeMsgParamIdSource", deepSaveType, innerList) 
				&& entity.SvCdeMsgParamIdSource != null)
			{
				DataRepository.SvCdeMsgParamProvider.Save(transactionManager, entity.SvCdeMsgParamIdSource);
				entity.SvCdeMsgParamId = entity.SvCdeMsgParamIdSource.SvCdeMsgParamId;
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
	
	#region SvMsgTmpltParamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvMsgTmpltParam</c>
	///</summary>
	public enum SvMsgTmpltParamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvAutoMsgTmplt</c> at SvAutoMsgTmpltIdSource
		///</summary>
		[ChildEntityType(typeof(SvAutoMsgTmplt))]
		SvAutoMsgTmplt,
		
		///<summary>
		/// Composite Property for <c>SvCdeMsgParam</c> at SvCdeMsgParamIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeMsgParam))]
		SvCdeMsgParam,
	}
	
	#endregion SvMsgTmpltParamChildEntityTypes
	
	#region SvMsgTmpltParamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvMsgTmpltParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMsgTmpltParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMsgTmpltParamFilterBuilder : SqlFilterBuilder<SvMsgTmpltParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamFilterBuilder class.
		/// </summary>
		public SvMsgTmpltParamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMsgTmpltParamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMsgTmpltParamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMsgTmpltParamFilterBuilder
	
	#region SvMsgTmpltParamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvMsgTmpltParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMsgTmpltParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMsgTmpltParamParameterBuilder : ParameterizedSqlFilterBuilder<SvMsgTmpltParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamParameterBuilder class.
		/// </summary>
		public SvMsgTmpltParamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMsgTmpltParamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMsgTmpltParamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMsgTmpltParamParameterBuilder
	
	#region SvMsgTmpltParamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvMsgTmpltParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMsgTmpltParam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvMsgTmpltParamSortBuilder : SqlSortBuilder<SvMsgTmpltParamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMsgTmpltParamSqlSortBuilder class.
		/// </summary>
		public SvMsgTmpltParamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvMsgTmpltParamSortBuilder
	
} // end namespace
