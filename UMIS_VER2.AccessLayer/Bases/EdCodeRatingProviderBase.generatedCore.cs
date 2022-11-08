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
	/// This class is the base class for any <see cref="EdCodeRatingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeRatingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeRating, UMIS_VER2.BusinessLyer.EdCodeRatingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRatingKey key)
		{
			return Delete(transactionManager, key.EdCodeRatingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeRatingId">XX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeRatingId)
		{
			return Delete(null, _edCodeRatingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRatingId">XX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeRatingId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeRating Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRatingKey key, int start, int pageLength)
		{
			return GetByEdCodeRatingId(transactionManager, key.EdCodeRatingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public TList<EdCodeRating> GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(null,_edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public TList<EdCodeRating> GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public TList<EdCodeRating> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public TList<EdCodeRating> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public TList<EdCodeRating> GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId, int start, int pageLength, out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STUDY_METHOD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeRating&gt;"/> class.</returns>
		public abstract TList<EdCodeRating> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="_edCodeRatingId">XX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(System.Decimal _edCodeRatingId)
		{
			int count = -1;
			return GetByEdCodeRatingId(null,_edCodeRatingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="_edCodeRatingId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(System.Decimal _edCodeRatingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRatingId(null, _edCodeRatingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRatingId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(TransactionManager transactionManager, System.Decimal _edCodeRatingId)
		{
			int count = -1;
			return GetByEdCodeRatingId(transactionManager, _edCodeRatingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRatingId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(TransactionManager transactionManager, System.Decimal _edCodeRatingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRatingId(transactionManager, _edCodeRatingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="_edCodeRatingId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(System.Decimal _edCodeRatingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeRatingId(null, _edCodeRatingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRatingId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeRating GetByEdCodeRatingId(TransactionManager transactionManager, System.Decimal _edCodeRatingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeRating&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeRating&gt;"/></returns>
		public static TList<EdCodeRating> Fill(IDataReader reader, TList<EdCodeRating> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeRating c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeRating")
					.Append("|").Append((System.Decimal)reader["ED_CODE_RATING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeRating>(
					key.ToString(), // EntityTrackingKey
					"EdCodeRating",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeRating();
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
					c.EdCodeRatingId = (System.Decimal)reader["ED_CODE_RATING_ID"];
					c.OriginalEdCodeRatingId = c.EdCodeRatingId;
					c.RatingDescrAr = (System.String)reader["RATING_DESCR_AR"];
					c.RatingDescrEn = Convert.IsDBNull(reader["RATING_DESCR_EN"]) ? null : (System.String)reader["RATING_DESCR_EN"];
					c.RatingSymbolAr = Convert.IsDBNull(reader["RATING_SYMBOL_AR"]) ? null : (System.String)reader["RATING_SYMBOL_AR"];
					c.RatingSymbolEn = Convert.IsDBNull(reader["RATING_SYMBOL_EN"]) ? null : (System.String)reader["RATING_SYMBOL_EN"];
					c.RatingOrder = (System.String)reader["RATING_ORDER"];
					c.RatingCode = Convert.IsDBNull(reader["RATING_CODE"]) ? null : (System.String)reader["RATING_CODE"];
					c.EdCodeStudyMethodId = (System.Decimal)reader["ED_CODE_STUDY_METHOD_ID"];
					c.IsLeastSuccess = Convert.IsDBNull(reader["IS_LEAST_SUCCESS"]) ? null : (System.Decimal?)reader["IS_LEAST_SUCCESS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeRating entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeRatingId = (System.Decimal)reader[((int)EdCodeRatingColumn.EdCodeRatingId - 1)];
			entity.OriginalEdCodeRatingId = (System.Decimal)reader["ED_CODE_RATING_ID"];
			entity.RatingDescrAr = (System.String)reader[((int)EdCodeRatingColumn.RatingDescrAr - 1)];
			entity.RatingDescrEn = (reader.IsDBNull(((int)EdCodeRatingColumn.RatingDescrEn - 1)))?null:(System.String)reader[((int)EdCodeRatingColumn.RatingDescrEn - 1)];
			entity.RatingSymbolAr = (reader.IsDBNull(((int)EdCodeRatingColumn.RatingSymbolAr - 1)))?null:(System.String)reader[((int)EdCodeRatingColumn.RatingSymbolAr - 1)];
			entity.RatingSymbolEn = (reader.IsDBNull(((int)EdCodeRatingColumn.RatingSymbolEn - 1)))?null:(System.String)reader[((int)EdCodeRatingColumn.RatingSymbolEn - 1)];
			entity.RatingOrder = (System.String)reader[((int)EdCodeRatingColumn.RatingOrder - 1)];
			entity.RatingCode = (reader.IsDBNull(((int)EdCodeRatingColumn.RatingCode - 1)))?null:(System.String)reader[((int)EdCodeRatingColumn.RatingCode - 1)];
			entity.EdCodeStudyMethodId = (System.Decimal)reader[((int)EdCodeRatingColumn.EdCodeStudyMethodId - 1)];
			entity.IsLeastSuccess = (reader.IsDBNull(((int)EdCodeRatingColumn.IsLeastSuccess - 1)))?null:(System.Decimal?)reader[((int)EdCodeRatingColumn.IsLeastSuccess - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeRating entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeRatingId = (System.Decimal)dataRow["ED_CODE_RATING_ID"];
			entity.OriginalEdCodeRatingId = (System.Decimal)dataRow["ED_CODE_RATING_ID"];
			entity.RatingDescrAr = (System.String)dataRow["RATING_DESCR_AR"];
			entity.RatingDescrEn = Convert.IsDBNull(dataRow["RATING_DESCR_EN"]) ? null : (System.String)dataRow["RATING_DESCR_EN"];
			entity.RatingSymbolAr = Convert.IsDBNull(dataRow["RATING_SYMBOL_AR"]) ? null : (System.String)dataRow["RATING_SYMBOL_AR"];
			entity.RatingSymbolEn = Convert.IsDBNull(dataRow["RATING_SYMBOL_EN"]) ? null : (System.String)dataRow["RATING_SYMBOL_EN"];
			entity.RatingOrder = (System.String)dataRow["RATING_ORDER"];
			entity.RatingCode = Convert.IsDBNull(dataRow["RATING_CODE"]) ? null : (System.String)dataRow["RATING_CODE"];
			entity.EdCodeStudyMethodId = (System.Decimal)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.IsLeastSuccess = Convert.IsDBNull(dataRow["IS_LEAST_SUCCESS"]) ? null : (System.Decimal?)dataRow["IS_LEAST_SUCCESS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeRating"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeRating Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRating entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeStudyMethodId;
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudyMethodIdSource = tmpEntity;
				else
					entity.EdCodeStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdCodeStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudyMethodIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeRating object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeRating instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeRating Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeRating entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdCodeStudyMethodIdSource);
				entity.EdCodeStudyMethodId = entity.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
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
	
	#region EdCodeRatingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeRating</c>
	///</summary>
	public enum EdCodeRatingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdCodeStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
	}
	
	#endregion EdCodeRatingChildEntityTypes
	
	#region EdCodeRatingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRating"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeRatingFilterBuilder : SqlFilterBuilder<EdCodeRatingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingFilterBuilder class.
		/// </summary>
		public EdCodeRatingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeRatingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeRatingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeRatingFilterBuilder
	
	#region EdCodeRatingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRating"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeRatingParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeRatingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingParameterBuilder class.
		/// </summary>
		public EdCodeRatingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeRatingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeRatingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeRatingParameterBuilder
	
	#region EdCodeRatingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeRatingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeRating"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeRatingSortBuilder : SqlSortBuilder<EdCodeRatingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeRatingSqlSortBuilder class.
		/// </summary>
		public EdCodeRatingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeRatingSortBuilder
	
} // end namespace
