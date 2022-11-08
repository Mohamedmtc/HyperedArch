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
	/// This class is the base class for any <see cref="SaCodeExperienceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeExperienceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeExperience, UMIS_VER2.BusinessLyer.SaCodeExperienceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeExperienceKey key)
		{
			return Delete(transactionManager, key.SaCodeExperienceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeExperienceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeExperienceId)
		{
			return Delete(null, _saCodeExperienceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeExperienceId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeExperience Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeExperienceKey key, int start, int pageLength)
		{
			return GetBySaCodeExperienceId(transactionManager, key.SaCodeExperienceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="_experienceDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(System.String _experienceDescrAr)
		{
			int count = -1;
			return GetByExperienceDescrAr(null,_experienceDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="_experienceDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(System.String _experienceDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByExperienceDescrAr(null, _experienceDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_experienceDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(TransactionManager transactionManager, System.String _experienceDescrAr)
		{
			int count = -1;
			return GetByExperienceDescrAr(transactionManager, _experienceDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_experienceDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(TransactionManager transactionManager, System.String _experienceDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByExperienceDescrAr(transactionManager, _experienceDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="_experienceDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(System.String _experienceDescrAr, int start, int pageLength, out int count)
		{
			return GetByExperienceDescrAr(null, _experienceDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_EXPERIENCE2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_experienceDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeExperience GetByExperienceDescrAr(TransactionManager transactionManager, System.String _experienceDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId)
		{
			int count = -1;
			return GetBySaCodeExperienceId(null,_saCodeExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeExperienceId(null, _saCodeExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId)
		{
			int count = -1;
			return GetBySaCodeExperienceId(transactionManager, _saCodeExperienceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeExperienceId(transactionManager, _saCodeExperienceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(System.Decimal _saCodeExperienceId, int start, int pageLength, out int count)
		{
			return GetBySaCodeExperienceId(null, _saCodeExperienceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_EXPERIENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeExperienceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeExperience GetBySaCodeExperienceId(TransactionManager transactionManager, System.Decimal _saCodeExperienceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeExperience&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeExperience&gt;"/></returns>
		public static TList<SaCodeExperience> Fill(IDataReader reader, TList<SaCodeExperience> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeExperience c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeExperience")
					.Append("|").Append((System.Decimal)reader["SA_CODE_EXPERIENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeExperience>(
					key.ToString(), // EntityTrackingKey
					"SaCodeExperience",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeExperience();
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
					c.SaCodeExperienceId = (System.Decimal)reader["SA_CODE_EXPERIENCE_ID"];
					c.OriginalSaCodeExperienceId = c.SaCodeExperienceId;
					c.ExperienceCode = Convert.IsDBNull(reader["EXPERIENCE_CODE"]) ? null : (System.String)reader["EXPERIENCE_CODE"];
					c.ExperienceDescrAr = (System.String)reader["EXPERIENCE_DESCR_AR"];
					c.ExperienceDescrEn = Convert.IsDBNull(reader["EXPERIENCE_DESCR_EN"]) ? null : (System.String)reader["EXPERIENCE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeExperience entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeExperienceId = (System.Decimal)reader[((int)SaCodeExperienceColumn.SaCodeExperienceId - 1)];
			entity.OriginalSaCodeExperienceId = (System.Decimal)reader["SA_CODE_EXPERIENCE_ID"];
			entity.ExperienceCode = (reader.IsDBNull(((int)SaCodeExperienceColumn.ExperienceCode - 1)))?null:(System.String)reader[((int)SaCodeExperienceColumn.ExperienceCode - 1)];
			entity.ExperienceDescrAr = (System.String)reader[((int)SaCodeExperienceColumn.ExperienceDescrAr - 1)];
			entity.ExperienceDescrEn = (reader.IsDBNull(((int)SaCodeExperienceColumn.ExperienceDescrEn - 1)))?null:(System.String)reader[((int)SaCodeExperienceColumn.ExperienceDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeExperience entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeExperienceId = (System.Decimal)dataRow["SA_CODE_EXPERIENCE_ID"];
			entity.OriginalSaCodeExperienceId = (System.Decimal)dataRow["SA_CODE_EXPERIENCE_ID"];
			entity.ExperienceCode = Convert.IsDBNull(dataRow["EXPERIENCE_CODE"]) ? null : (System.String)dataRow["EXPERIENCE_CODE"];
			entity.ExperienceDescrAr = (System.String)dataRow["EXPERIENCE_DESCR_AR"];
			entity.ExperienceDescrEn = Convert.IsDBNull(dataRow["EXPERIENCE_DESCR_EN"]) ? null : (System.String)dataRow["EXPERIENCE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeExperience"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeExperience Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeExperience entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeExperienceId methods when available
			
			#region SaExperienceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaExperience>|SaExperienceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaExperienceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaExperienceCollection = DataRepository.SaExperienceProvider.GetBySaCodeExperienceId(transactionManager, entity.SaCodeExperienceId);

				if (deep && entity.SaExperienceCollection.Count > 0)
				{
					deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExperience>) DataRepository.SaExperienceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExperienceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeExperience object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeExperience instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeExperience Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeExperience entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaExperience>
				if (CanDeepSave(entity.SaExperienceCollection, "List<SaExperience>|SaExperienceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaExperience child in entity.SaExperienceCollection)
					{
						if(child.SaCodeExperienceIdSource != null)
						{
							child.SaCodeExperienceId = child.SaCodeExperienceIdSource.SaCodeExperienceId;
						}
						else
						{
							child.SaCodeExperienceId = entity.SaCodeExperienceId;
						}

					}

					if (entity.SaExperienceCollection.Count > 0 || entity.SaExperienceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaExperienceProvider.Save(transactionManager, entity.SaExperienceCollection);
						
						deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaExperience >) DataRepository.SaExperienceProvider.DeepSave,
							new object[] { transactionManager, entity.SaExperienceCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeExperienceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeExperience</c>
	///</summary>
	public enum SaCodeExperienceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeExperience</c> as OneToMany for SaExperienceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExperience>))]
		SaExperienceCollection,
	}
	
	#endregion SaCodeExperienceChildEntityTypes
	
	#region SaCodeExperienceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeExperience"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeExperienceFilterBuilder : SqlFilterBuilder<SaCodeExperienceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceFilterBuilder class.
		/// </summary>
		public SaCodeExperienceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeExperienceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeExperienceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeExperienceFilterBuilder
	
	#region SaCodeExperienceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeExperience"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeExperienceParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeExperienceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceParameterBuilder class.
		/// </summary>
		public SaCodeExperienceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeExperienceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeExperienceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeExperienceParameterBuilder
	
	#region SaCodeExperienceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeExperienceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeExperience"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeExperienceSortBuilder : SqlSortBuilder<SaCodeExperienceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeExperienceSqlSortBuilder class.
		/// </summary>
		public SaCodeExperienceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeExperienceSortBuilder
	
} // end namespace
