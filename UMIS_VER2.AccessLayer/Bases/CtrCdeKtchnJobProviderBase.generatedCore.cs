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
	/// This class is the base class for any <see cref="CtrCdeKtchnJobProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeKtchnJobProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeKtchnJob, UMIS_VER2.BusinessLyer.CtrCdeKtchnJobKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeKtchnJobKey key)
		{
			return Delete(transactionManager, key.CtrCdeKtchnJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeKtchnJobId)
		{
			return Delete(null, _ctrCdeKtchnJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeKtchnJobId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeKtchnJob Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeKtchnJobKey key, int start, int pageLength)
		{
			return GetByCtrCdeKtchnJobId(transactionManager, key.CtrCdeKtchnJobId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(System.Decimal _ctrCdeKtchnJobId)
		{
			int count = -1;
			return GetByCtrCdeKtchnJobId(null,_ctrCdeKtchnJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(System.Decimal _ctrCdeKtchnJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeKtchnJobId(null, _ctrCdeKtchnJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(TransactionManager transactionManager, System.Decimal _ctrCdeKtchnJobId)
		{
			int count = -1;
			return GetByCtrCdeKtchnJobId(transactionManager, _ctrCdeKtchnJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(TransactionManager transactionManager, System.Decimal _ctrCdeKtchnJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeKtchnJobId(transactionManager, _ctrCdeKtchnJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(System.Decimal _ctrCdeKtchnJobId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeKtchnJobId(null, _ctrCdeKtchnJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_KTCHN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeKtchnJobId">الوظائف بالمطبخ</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByCtrCdeKtchnJobId(TransactionManager transactionManager, System.Decimal _ctrCdeKtchnJobId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(System.String _ktchnJobAr)
		{
			int count = -1;
			return GetByKtchnJobAr(null,_ktchnJobAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(System.String _ktchnJobAr, int start, int pageLength)
		{
			int count = -1;
			return GetByKtchnJobAr(null, _ktchnJobAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(TransactionManager transactionManager, System.String _ktchnJobAr)
		{
			int count = -1;
			return GetByKtchnJobAr(transactionManager, _ktchnJobAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(TransactionManager transactionManager, System.String _ktchnJobAr, int start, int pageLength)
		{
			int count = -1;
			return GetByKtchnJobAr(transactionManager, _ktchnJobAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(System.String _ktchnJobAr, int start, int pageLength, out int count)
		{
			return GetByKtchnJobAr(null, _ktchnJobAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobAr">[ERP]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobAr(TransactionManager transactionManager, System.String _ktchnJobAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="_ktchnJobEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(System.String _ktchnJobEn)
		{
			int count = -1;
			return GetByKtchnJobEn(null,_ktchnJobEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="_ktchnJobEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(System.String _ktchnJobEn, int start, int pageLength)
		{
			int count = -1;
			return GetByKtchnJobEn(null, _ktchnJobEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(TransactionManager transactionManager, System.String _ktchnJobEn)
		{
			int count = -1;
			return GetByKtchnJobEn(transactionManager, _ktchnJobEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(TransactionManager transactionManager, System.String _ktchnJobEn, int start, int pageLength)
		{
			int count = -1;
			return GetByKtchnJobEn(transactionManager, _ktchnJobEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="_ktchnJobEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(System.String _ktchnJobEn, int start, int pageLength, out int count)
		{
			return GetByKtchnJobEn(null, _ktchnJobEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_KTCHN_JOB_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ktchnJobEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeKtchnJob GetByKtchnJobEn(TransactionManager transactionManager, System.String _ktchnJobEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeKtchnJob&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeKtchnJob&gt;"/></returns>
		public static TList<CtrCdeKtchnJob> Fill(IDataReader reader, TList<CtrCdeKtchnJob> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeKtchnJob c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeKtchnJob")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_KTCHN_JOB_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeKtchnJob>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeKtchnJob",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeKtchnJob();
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
					c.CtrCdeKtchnJobId = (System.Decimal)reader["CTR_CDE_KTCHN_JOB_ID"];
					c.OriginalCtrCdeKtchnJobId = c.CtrCdeKtchnJobId;
					c.KtchnJobAr = (System.String)reader["KTCHN_JOB_AR"];
					c.KtchnJobEn = (System.String)reader["KTCHN_JOB_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeKtchnJob entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeKtchnJobId = (System.Decimal)reader[((int)CtrCdeKtchnJobColumn.CtrCdeKtchnJobId - 1)];
			entity.OriginalCtrCdeKtchnJobId = (System.Decimal)reader["CTR_CDE_KTCHN_JOB_ID"];
			entity.KtchnJobAr = (System.String)reader[((int)CtrCdeKtchnJobColumn.KtchnJobAr - 1)];
			entity.KtchnJobEn = (System.String)reader[((int)CtrCdeKtchnJobColumn.KtchnJobEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeKtchnJob entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeKtchnJobId = (System.Decimal)dataRow["CTR_CDE_KTCHN_JOB_ID"];
			entity.OriginalCtrCdeKtchnJobId = (System.Decimal)dataRow["CTR_CDE_KTCHN_JOB_ID"];
			entity.KtchnJobAr = (System.String)dataRow["KTCHN_JOB_AR"];
			entity.KtchnJobEn = (System.String)dataRow["KTCHN_JOB_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeKtchnJob"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeKtchnJob Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeKtchnJob entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeKtchnJob object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeKtchnJob instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeKtchnJob Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeKtchnJob entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
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
	
	#region CtrCdeKtchnJobChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeKtchnJob</c>
	///</summary>
	public enum CtrCdeKtchnJobChildEntityTypes
	{
	}
	
	#endregion CtrCdeKtchnJobChildEntityTypes
	
	#region CtrCdeKtchnJobFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeKtchnJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeKtchnJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeKtchnJobFilterBuilder : SqlFilterBuilder<CtrCdeKtchnJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobFilterBuilder class.
		/// </summary>
		public CtrCdeKtchnJobFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeKtchnJobFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeKtchnJobFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeKtchnJobFilterBuilder
	
	#region CtrCdeKtchnJobParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeKtchnJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeKtchnJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeKtchnJobParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeKtchnJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobParameterBuilder class.
		/// </summary>
		public CtrCdeKtchnJobParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeKtchnJobParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeKtchnJobParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeKtchnJobParameterBuilder
	
	#region CtrCdeKtchnJobSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeKtchnJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeKtchnJob"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeKtchnJobSortBuilder : SqlSortBuilder<CtrCdeKtchnJobColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeKtchnJobSqlSortBuilder class.
		/// </summary>
		public CtrCdeKtchnJobSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeKtchnJobSortBuilder
	
} // end namespace
