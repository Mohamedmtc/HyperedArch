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
	/// This class is the base class for any <see cref="EdCodeTrainEvalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeTrainEvalProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeTrainEval, UMIS_VER2.BusinessLyer.EdCodeTrainEvalKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTrainEvalKey key)
		{
			return Delete(transactionManager, key.EdCodeTrainEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeTrainEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeTrainEvalId)
		{
			return Delete(null, _edCodeTrainEvalId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeTrainEvalId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeTrainEval Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTrainEvalKey key, int start, int pageLength)
		{
			return GetByEdCodeTrainEvalId(transactionManager, key.EdCodeTrainEvalId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(System.Decimal _edCodeTrainEvalId)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(null,_edCodeTrainEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(System.Decimal _edCodeTrainEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(null, _edCodeTrainEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal _edCodeTrainEvalId)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(transactionManager, _edCodeTrainEvalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal _edCodeTrainEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(transactionManager, _edCodeTrainEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(System.Decimal _edCodeTrainEvalId, int start, int pageLength, out int count)
		{
			return GetByEdCodeTrainEvalId(null, _edCodeTrainEvalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_TRAIN_EVAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeTrainEval GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal _edCodeTrainEvalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeTrainEval&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeTrainEval&gt;"/></returns>
		public static TList<EdCodeTrainEval> Fill(IDataReader reader, TList<EdCodeTrainEval> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeTrainEval c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeTrainEval")
					.Append("|").Append((System.Decimal)reader["ED_CODE_TRAIN_EVAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeTrainEval>(
					key.ToString(), // EntityTrackingKey
					"EdCodeTrainEval",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeTrainEval();
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
					c.EdCodeTrainEvalId = (System.Decimal)reader["ED_CODE_TRAIN_EVAL_ID"];
					c.OriginalEdCodeTrainEvalId = c.EdCodeTrainEvalId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeTrainEval entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeTrainEvalId = (System.Decimal)reader[((int)EdCodeTrainEvalColumn.EdCodeTrainEvalId - 1)];
			entity.OriginalEdCodeTrainEvalId = (System.Decimal)reader["ED_CODE_TRAIN_EVAL_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeTrainEvalColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCodeTrainEvalColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeTrainEval entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeTrainEvalId = (System.Decimal)dataRow["ED_CODE_TRAIN_EVAL_ID"];
			entity.OriginalEdCodeTrainEvalId = (System.Decimal)dataRow["ED_CODE_TRAIN_EVAL_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeTrainEval"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeTrainEval Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTrainEval entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeTrainEvalId methods when available
			
			#region EdTrainStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainStud>|EdTrainStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainStudCollection = DataRepository.EdTrainStudProvider.GetByEdCodeTrainEvalId(transactionManager, entity.EdCodeTrainEvalId);

				if (deep && entity.EdTrainStudCollection.Count > 0)
				{
					deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainStud>) DataRepository.EdTrainStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeTrainEval object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeTrainEval instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeTrainEval Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeTrainEval entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdTrainStud>
				if (CanDeepSave(entity.EdTrainStudCollection, "List<EdTrainStud>|EdTrainStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainStud child in entity.EdTrainStudCollection)
					{
						if(child.EdCodeTrainEvalIdSource != null)
						{
							child.EdCodeTrainEvalId = child.EdCodeTrainEvalIdSource.EdCodeTrainEvalId;
						}
						else
						{
							child.EdCodeTrainEvalId = entity.EdCodeTrainEvalId;
						}

					}

					if (entity.EdTrainStudCollection.Count > 0 || entity.EdTrainStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainStudProvider.Save(transactionManager, entity.EdTrainStudCollection);
						
						deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainStud >) DataRepository.EdTrainStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeTrainEvalChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeTrainEval</c>
	///</summary>
	public enum EdCodeTrainEvalChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeTrainEval</c> as OneToMany for EdTrainStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainStud>))]
		EdTrainStudCollection,
	}
	
	#endregion EdCodeTrainEvalChildEntityTypes
	
	#region EdCodeTrainEvalFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeTrainEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTrainEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeTrainEvalFilterBuilder : SqlFilterBuilder<EdCodeTrainEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalFilterBuilder class.
		/// </summary>
		public EdCodeTrainEvalFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeTrainEvalFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeTrainEvalFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeTrainEvalFilterBuilder
	
	#region EdCodeTrainEvalParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeTrainEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTrainEval"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeTrainEvalParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeTrainEvalColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalParameterBuilder class.
		/// </summary>
		public EdCodeTrainEvalParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeTrainEvalParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeTrainEvalParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeTrainEvalParameterBuilder
	
	#region EdCodeTrainEvalSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeTrainEvalColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeTrainEval"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeTrainEvalSortBuilder : SqlSortBuilder<EdCodeTrainEvalColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeTrainEvalSqlSortBuilder class.
		/// </summary>
		public EdCodeTrainEvalSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeTrainEvalSortBuilder
	
} // end namespace
