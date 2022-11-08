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
	/// This class is the base class for any <see cref="CtrCdeSrvcJobProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeSrvcJobProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeSrvcJob, UMIS_VER2.BusinessLyer.CtrCdeSrvcJobKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvcJobKey key)
		{
			return Delete(transactionManager, key.CtrCdeSrvcJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeSrvcJobId)
		{
			return Delete(null, _ctrCdeSrvcJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeSrvcJobId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeSrvcJob Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvcJobKey key, int start, int pageLength)
		{
			return GetByCtrCdeSrvcJobId(transactionManager, key.CtrCdeSrvcJobId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(System.Decimal _ctrCdeSrvcJobId)
		{
			int count = -1;
			return GetByCtrCdeSrvcJobId(null,_ctrCdeSrvcJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(System.Decimal _ctrCdeSrvcJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeSrvcJobId(null, _ctrCdeSrvcJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvcJobId)
		{
			int count = -1;
			return GetByCtrCdeSrvcJobId(transactionManager, _ctrCdeSrvcJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvcJobId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeSrvcJobId(transactionManager, _ctrCdeSrvcJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(System.Decimal _ctrCdeSrvcJobId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeSrvcJobId(null, _ctrCdeSrvcJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_SRVC_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvcJobId">الوظائف بخدمة النوبتجية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetByCtrCdeSrvcJobId(TransactionManager transactionManager, System.Decimal _ctrCdeSrvcJobId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="_srvcJobAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(System.String _srvcJobAr)
		{
			int count = -1;
			return GetBySrvcJobAr(null,_srvcJobAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="_srvcJobAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(System.String _srvcJobAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySrvcJobAr(null, _srvcJobAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_srvcJobAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(TransactionManager transactionManager, System.String _srvcJobAr)
		{
			int count = -1;
			return GetBySrvcJobAr(transactionManager, _srvcJobAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_srvcJobAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(TransactionManager transactionManager, System.String _srvcJobAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySrvcJobAr(transactionManager, _srvcJobAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="_srvcJobAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(System.String _srvcJobAr, int start, int pageLength, out int count)
		{
			return GetBySrvcJobAr(null, _srvcJobAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_SRVC_JOB_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_srvcJobAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeSrvcJob GetBySrvcJobAr(TransactionManager transactionManager, System.String _srvcJobAr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeSrvcJob&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeSrvcJob&gt;"/></returns>
		public static TList<CtrCdeSrvcJob> Fill(IDataReader reader, TList<CtrCdeSrvcJob> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeSrvcJob c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeSrvcJob")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_SRVC_JOB_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeSrvcJob>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeSrvcJob",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeSrvcJob();
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
					c.CtrCdeSrvcJobId = (System.Decimal)reader["CTR_CDE_SRVC_JOB_ID"];
					c.OriginalCtrCdeSrvcJobId = c.CtrCdeSrvcJobId;
					c.SrvcJobAr = (System.String)reader["SRVC_JOB_AR"];
					c.SrvcJobEn = (System.String)reader["SRVC_JOB_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeSrvcJob entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeSrvcJobId = (System.Decimal)reader[((int)CtrCdeSrvcJobColumn.CtrCdeSrvcJobId - 1)];
			entity.OriginalCtrCdeSrvcJobId = (System.Decimal)reader["CTR_CDE_SRVC_JOB_ID"];
			entity.SrvcJobAr = (System.String)reader[((int)CtrCdeSrvcJobColumn.SrvcJobAr - 1)];
			entity.SrvcJobEn = (System.String)reader[((int)CtrCdeSrvcJobColumn.SrvcJobEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeSrvcJob entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeSrvcJobId = (System.Decimal)dataRow["CTR_CDE_SRVC_JOB_ID"];
			entity.OriginalCtrCdeSrvcJobId = (System.Decimal)dataRow["CTR_CDE_SRVC_JOB_ID"];
			entity.SrvcJobAr = (System.String)dataRow["SRVC_JOB_AR"];
			entity.SrvcJobEn = (System.String)dataRow["SRVC_JOB_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeSrvcJob"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeSrvcJob Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvcJob entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeSrvcJob object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeSrvcJob instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeSrvcJob Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeSrvcJob entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CtrCdeSrvcJobChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeSrvcJob</c>
	///</summary>
	public enum CtrCdeSrvcJobChildEntityTypes
	{
	}
	
	#endregion CtrCdeSrvcJobChildEntityTypes
	
	#region CtrCdeSrvcJobFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeSrvcJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvcJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeSrvcJobFilterBuilder : SqlFilterBuilder<CtrCdeSrvcJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobFilterBuilder class.
		/// </summary>
		public CtrCdeSrvcJobFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeSrvcJobFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeSrvcJobFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeSrvcJobFilterBuilder
	
	#region CtrCdeSrvcJobParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeSrvcJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvcJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeSrvcJobParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeSrvcJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobParameterBuilder class.
		/// </summary>
		public CtrCdeSrvcJobParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeSrvcJobParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeSrvcJobParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeSrvcJobParameterBuilder
	
	#region CtrCdeSrvcJobSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeSrvcJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeSrvcJob"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeSrvcJobSortBuilder : SqlSortBuilder<CtrCdeSrvcJobColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeSrvcJobSqlSortBuilder class.
		/// </summary>
		public CtrCdeSrvcJobSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeSrvcJobSortBuilder
	
} // end namespace
