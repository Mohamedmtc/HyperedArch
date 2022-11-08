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
	/// This class is the base class for any <see cref="SaCodeParDelNatureProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeParDelNatureProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeParDelNature, UMIS_VER2.BusinessLyer.SaCodeParDelNatureKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeParDelNatureKey key)
		{
			return Delete(transactionManager, key.SaCodeParDelNatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeParDelNatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeParDelNatureId)
		{
			return Delete(null, _saCodeParDelNatureId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeParDelNatureId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeParDelNatureId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeParDelNature Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeParDelNatureKey key, int start, int pageLength)
		{
			return GetBySaCodeParDelNatureId(transactionManager, key.SaCodeParDelNatureId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="_parDelNatureAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(System.String _parDelNatureAr)
		{
			int count = -1;
			return GetByParDelNatureAr(null,_parDelNatureAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="_parDelNatureAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(System.String _parDelNatureAr, int start, int pageLength)
		{
			int count = -1;
			return GetByParDelNatureAr(null, _parDelNatureAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parDelNatureAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(TransactionManager transactionManager, System.String _parDelNatureAr)
		{
			int count = -1;
			return GetByParDelNatureAr(transactionManager, _parDelNatureAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parDelNatureAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(TransactionManager transactionManager, System.String _parDelNatureAr, int start, int pageLength)
		{
			int count = -1;
			return GetByParDelNatureAr(transactionManager, _parDelNatureAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="_parDelNatureAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(System.String _parDelNatureAr, int start, int pageLength, out int count)
		{
			return GetByParDelNatureAr(null, _parDelNatureAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_PAR_DEL_NATURE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parDelNatureAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeParDelNature GetByParDelNatureAr(TransactionManager transactionManager, System.String _parDelNatureAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(System.Decimal _saCodeParDelNatureId)
		{
			int count = -1;
			return GetBySaCodeParDelNatureId(null,_saCodeParDelNatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(System.Decimal _saCodeParDelNatureId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeParDelNatureId(null, _saCodeParDelNatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(TransactionManager transactionManager, System.Decimal _saCodeParDelNatureId)
		{
			int count = -1;
			return GetBySaCodeParDelNatureId(transactionManager, _saCodeParDelNatureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(TransactionManager transactionManager, System.Decimal _saCodeParDelNatureId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeParDelNatureId(transactionManager, _saCodeParDelNatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(System.Decimal _saCodeParDelNatureId, int start, int pageLength, out int count)
		{
			return GetBySaCodeParDelNatureId(null, _saCodeParDelNatureId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_PAR_DEL_NATURE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeParDelNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeParDelNature GetBySaCodeParDelNatureId(TransactionManager transactionManager, System.Decimal _saCodeParDelNatureId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeParDelNature&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeParDelNature&gt;"/></returns>
		public static TList<SaCodeParDelNature> Fill(IDataReader reader, TList<SaCodeParDelNature> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeParDelNature c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeParDelNature")
					.Append("|").Append((System.Decimal)reader["SA_CODE_PAR_DEL_NATURE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeParDelNature>(
					key.ToString(), // EntityTrackingKey
					"SaCodeParDelNature",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeParDelNature();
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
					c.SaCodeParDelNatureId = (System.Decimal)reader["SA_CODE_PAR_DEL_NATURE_ID"];
					c.OriginalSaCodeParDelNatureId = c.SaCodeParDelNatureId;
					c.ParDelCode = Convert.IsDBNull(reader["PAR_DEL_CODE"]) ? null : (System.String)reader["PAR_DEL_CODE"];
					c.ParDelNatureAr = (System.String)reader["PAR_DEL_NATURE_AR"];
					c.ParDelNatureEn = Convert.IsDBNull(reader["PAR_DEL_NATURE_EN"]) ? null : (System.String)reader["PAR_DEL_NATURE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeParDelNature entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeParDelNatureId = (System.Decimal)reader[((int)SaCodeParDelNatureColumn.SaCodeParDelNatureId - 1)];
			entity.OriginalSaCodeParDelNatureId = (System.Decimal)reader["SA_CODE_PAR_DEL_NATURE_ID"];
			entity.ParDelCode = (reader.IsDBNull(((int)SaCodeParDelNatureColumn.ParDelCode - 1)))?null:(System.String)reader[((int)SaCodeParDelNatureColumn.ParDelCode - 1)];
			entity.ParDelNatureAr = (System.String)reader[((int)SaCodeParDelNatureColumn.ParDelNatureAr - 1)];
			entity.ParDelNatureEn = (reader.IsDBNull(((int)SaCodeParDelNatureColumn.ParDelNatureEn - 1)))?null:(System.String)reader[((int)SaCodeParDelNatureColumn.ParDelNatureEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeParDelNature entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeParDelNatureId = (System.Decimal)dataRow["SA_CODE_PAR_DEL_NATURE_ID"];
			entity.OriginalSaCodeParDelNatureId = (System.Decimal)dataRow["SA_CODE_PAR_DEL_NATURE_ID"];
			entity.ParDelCode = Convert.IsDBNull(dataRow["PAR_DEL_CODE"]) ? null : (System.String)dataRow["PAR_DEL_CODE"];
			entity.ParDelNatureAr = (System.String)dataRow["PAR_DEL_NATURE_AR"];
			entity.ParDelNatureEn = Convert.IsDBNull(dataRow["PAR_DEL_NATURE_EN"]) ? null : (System.String)dataRow["PAR_DEL_NATURE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeParDelNature"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeParDelNature Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeParDelNature entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeParDelNature object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeParDelNature instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeParDelNature Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeParDelNature entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SaCodeParDelNatureChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeParDelNature</c>
	///</summary>
	public enum SaCodeParDelNatureChildEntityTypes
	{
	}
	
	#endregion SaCodeParDelNatureChildEntityTypes
	
	#region SaCodeParDelNatureFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeParDelNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeParDelNature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeParDelNatureFilterBuilder : SqlFilterBuilder<SaCodeParDelNatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureFilterBuilder class.
		/// </summary>
		public SaCodeParDelNatureFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeParDelNatureFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeParDelNatureFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeParDelNatureFilterBuilder
	
	#region SaCodeParDelNatureParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeParDelNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeParDelNature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeParDelNatureParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeParDelNatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureParameterBuilder class.
		/// </summary>
		public SaCodeParDelNatureParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeParDelNatureParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeParDelNatureParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeParDelNatureParameterBuilder
	
	#region SaCodeParDelNatureSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeParDelNatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeParDelNature"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeParDelNatureSortBuilder : SqlSortBuilder<SaCodeParDelNatureColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeParDelNatureSqlSortBuilder class.
		/// </summary>
		public SaCodeParDelNatureSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeParDelNatureSortBuilder
	
} // end namespace
