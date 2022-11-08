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
	/// This class is the base class for any <see cref="GsCodeIdentKindProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeIdentKindProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeIdentKind, UMIS_VER2.BusinessLyer.GsCodeIdentKindKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentKindKey key)
		{
			return Delete(transactionManager, key.GsCodeIdentKindId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeIdentKindId">XXXX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeIdentKindId)
		{
			return Delete(null, _gsCodeIdentKindId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId">XXXX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeIdentKind Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentKindKey key, int start, int pageLength)
		{
			return GetByGsCodeIdentKindId(transactionManager, key.GsCodeIdentKindId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="_kindDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(System.String _kindDescrAr)
		{
			int count = -1;
			return GetByKindDescrAr(null,_kindDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="_kindDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(System.String _kindDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByKindDescrAr(null, _kindDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_kindDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(TransactionManager transactionManager, System.String _kindDescrAr)
		{
			int count = -1;
			return GetByKindDescrAr(transactionManager, _kindDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_kindDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(TransactionManager transactionManager, System.String _kindDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByKindDescrAr(transactionManager, _kindDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="_kindDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(System.String _kindDescrAr, int start, int pageLength, out int count)
		{
			return GetByKindDescrAr(null, _kindDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_IDENT_KIND_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_kindDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByKindDescrAr(TransactionManager transactionManager, System.String _kindDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(null,_gsCodeIdentKindId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(null, _gsCodeIdentKindId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(transactionManager, _gsCodeIdentKindId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(transactionManager, _gsCodeIdentKindId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId, int start, int pageLength, out int count)
		{
			return GetByGsCodeIdentKindId(null, _gsCodeIdentKindId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_IDENT_KIND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId">XXXX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeIdentKind GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeIdentKind&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeIdentKind&gt;"/></returns>
		public static TList<GsCodeIdentKind> Fill(IDataReader reader, TList<GsCodeIdentKind> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeIdentKind c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeIdentKind")
					.Append("|").Append((System.Decimal)reader["GS_CODE_IDENT_KIND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeIdentKind>(
					key.ToString(), // EntityTrackingKey
					"GsCodeIdentKind",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeIdentKind();
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
					c.GsCodeIdentKindId = (System.Decimal)reader["GS_CODE_IDENT_KIND_ID"];
					c.OriginalGsCodeIdentKindId = c.GsCodeIdentKindId;
					c.KindDescrAr = (System.String)reader["KIND_DESCR_AR"];
					c.KindDescrEn = Convert.IsDBNull(reader["KIND_DESCR_EN"]) ? null : (System.String)reader["KIND_DESCR_EN"];
					c.KindCode = Convert.IsDBNull(reader["KIND_CODE"]) ? null : (System.String)reader["KIND_CODE"];
					c.Constant = (System.Decimal)reader["Constant"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeIdentKind entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeIdentKindId = (System.Decimal)reader[((int)GsCodeIdentKindColumn.GsCodeIdentKindId - 1)];
			entity.OriginalGsCodeIdentKindId = (System.Decimal)reader["GS_CODE_IDENT_KIND_ID"];
			entity.KindDescrAr = (System.String)reader[((int)GsCodeIdentKindColumn.KindDescrAr - 1)];
			entity.KindDescrEn = (reader.IsDBNull(((int)GsCodeIdentKindColumn.KindDescrEn - 1)))?null:(System.String)reader[((int)GsCodeIdentKindColumn.KindDescrEn - 1)];
			entity.KindCode = (reader.IsDBNull(((int)GsCodeIdentKindColumn.KindCode - 1)))?null:(System.String)reader[((int)GsCodeIdentKindColumn.KindCode - 1)];
			entity.Constant = (System.Decimal)reader[((int)GsCodeIdentKindColumn.Constant - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeIdentKind entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeIdentKindId = (System.Decimal)dataRow["GS_CODE_IDENT_KIND_ID"];
			entity.OriginalGsCodeIdentKindId = (System.Decimal)dataRow["GS_CODE_IDENT_KIND_ID"];
			entity.KindDescrAr = (System.String)dataRow["KIND_DESCR_AR"];
			entity.KindDescrEn = Convert.IsDBNull(dataRow["KIND_DESCR_EN"]) ? null : (System.String)dataRow["KIND_DESCR_EN"];
			entity.KindCode = Convert.IsDBNull(dataRow["KIND_CODE"]) ? null : (System.String)dataRow["KIND_CODE"];
			entity.Constant = (System.Decimal)dataRow["Constant"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeIdentKind"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeIdentKind Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentKind entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeIdentKindId methods when available
			
			#region SaPersonIdCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPersonId>|SaPersonIdCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPersonIdCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPersonIdCollection = DataRepository.SaPersonIdProvider.GetByGsCodeIdentKindId(transactionManager, entity.GsCodeIdentKindId);

				if (deep && entity.SaPersonIdCollection.Count > 0)
				{
					deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPersonId>) DataRepository.SaPersonIdProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPersonIdCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeIdentKind object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeIdentKind instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeIdentKind Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeIdentKind entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaPersonId>
				if (CanDeepSave(entity.SaPersonIdCollection, "List<SaPersonId>|SaPersonIdCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPersonId child in entity.SaPersonIdCollection)
					{
						if(child.GsCodeIdentKindIdSource != null)
						{
							child.GsCodeIdentKindId = child.GsCodeIdentKindIdSource.GsCodeIdentKindId;
						}
						else
						{
							child.GsCodeIdentKindId = entity.GsCodeIdentKindId;
						}

					}

					if (entity.SaPersonIdCollection.Count > 0 || entity.SaPersonIdCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPersonIdProvider.Save(transactionManager, entity.SaPersonIdCollection);
						
						deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPersonId >) DataRepository.SaPersonIdProvider.DeepSave,
							new object[] { transactionManager, entity.SaPersonIdCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeIdentKindChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeIdentKind</c>
	///</summary>
	public enum GsCodeIdentKindChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeIdentKind</c> as OneToMany for SaPersonIdCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPersonId>))]
		SaPersonIdCollection,
	}
	
	#endregion GsCodeIdentKindChildEntityTypes
	
	#region GsCodeIdentKindFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeIdentKindColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentKind"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeIdentKindFilterBuilder : SqlFilterBuilder<GsCodeIdentKindColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindFilterBuilder class.
		/// </summary>
		public GsCodeIdentKindFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeIdentKindFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeIdentKindFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeIdentKindFilterBuilder
	
	#region GsCodeIdentKindParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeIdentKindColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentKind"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeIdentKindParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeIdentKindColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindParameterBuilder class.
		/// </summary>
		public GsCodeIdentKindParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeIdentKindParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeIdentKindParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeIdentKindParameterBuilder
	
	#region GsCodeIdentKindSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeIdentKindColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeIdentKind"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeIdentKindSortBuilder : SqlSortBuilder<GsCodeIdentKindColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeIdentKindSqlSortBuilder class.
		/// </summary>
		public GsCodeIdentKindSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeIdentKindSortBuilder
	
} // end namespace
