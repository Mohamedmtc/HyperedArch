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
	/// This class is the base class for any <see cref="SaCdeAdminJobProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCdeAdminJobProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCdeAdminJob, UMIS_VER2.BusinessLyer.SaCdeAdminJobKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAdminJobKey key)
		{
			return Delete(transactionManager, key.SaCdeAdminJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _saCdeAdminJobId)
		{
			return Delete(null, _saCdeAdminJobId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _saCdeAdminJobId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCdeAdminJob Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAdminJobKey key, int start, int pageLength)
		{
			return GetBySaCdeAdminJobId(transactionManager, key.SaCdeAdminJobId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(System.Int32 _saCdeAdminJobId)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(null,_saCdeAdminJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(System.Int32 _saCdeAdminJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(null, _saCdeAdminJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32 _saCdeAdminJobId)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(transactionManager, _saCdeAdminJobId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32 _saCdeAdminJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCdeAdminJobId(transactionManager, _saCdeAdminJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(System.Int32 _saCdeAdminJobId, int start, int pageLength, out int count)
		{
			return GetBySaCdeAdminJobId(null, _saCdeAdminJobId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CDE_ADMIN_JOB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCdeAdminJobId">Mig Constant  from KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCdeAdminJob GetBySaCdeAdminJobId(TransactionManager transactionManager, System.Int32 _saCdeAdminJobId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCdeAdminJob&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCdeAdminJob&gt;"/></returns>
		public static TList<SaCdeAdminJob> Fill(IDataReader reader, TList<SaCdeAdminJob> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCdeAdminJob c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCdeAdminJob")
					.Append("|").Append((System.Int32)reader["SA_CDE_ADMIN_JOB_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCdeAdminJob>(
					key.ToString(), // EntityTrackingKey
					"SaCdeAdminJob",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCdeAdminJob();
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
					c.SaCdeAdminJobId = (System.Int32)reader["SA_CDE_ADMIN_JOB_ID"];
					c.OriginalSaCdeAdminJobId = c.SaCdeAdminJobId;
					c.AdminJobAr = (System.String)reader["ADMIN_JOB_AR"];
					c.AdminJobEn = (System.String)reader["ADMIN_JOB_EN"];
					c.AdminJobLoad = Convert.IsDBNull(reader["ADMIN_JOB_LOAD"]) ? null : (System.Decimal?)reader["ADMIN_JOB_LOAD"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCdeAdminJob entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCdeAdminJobId = (System.Int32)reader[((int)SaCdeAdminJobColumn.SaCdeAdminJobId - 1)];
			entity.OriginalSaCdeAdminJobId = (System.Int32)reader["SA_CDE_ADMIN_JOB_ID"];
			entity.AdminJobAr = (System.String)reader[((int)SaCdeAdminJobColumn.AdminJobAr - 1)];
			entity.AdminJobEn = (System.String)reader[((int)SaCdeAdminJobColumn.AdminJobEn - 1)];
			entity.AdminJobLoad = (reader.IsDBNull(((int)SaCdeAdminJobColumn.AdminJobLoad - 1)))?null:(System.Decimal?)reader[((int)SaCdeAdminJobColumn.AdminJobLoad - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCdeAdminJob entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCdeAdminJobId = (System.Int32)dataRow["SA_CDE_ADMIN_JOB_ID"];
			entity.OriginalSaCdeAdminJobId = (System.Int32)dataRow["SA_CDE_ADMIN_JOB_ID"];
			entity.AdminJobAr = (System.String)dataRow["ADMIN_JOB_AR"];
			entity.AdminJobEn = (System.String)dataRow["ADMIN_JOB_EN"];
			entity.AdminJobLoad = Convert.IsDBNull(dataRow["ADMIN_JOB_LOAD"]) ? null : (System.Decimal?)dataRow["ADMIN_JOB_LOAD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCdeAdminJob"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCdeAdminJob Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAdminJob entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCdeAdminJobId methods when available
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetBySaCdeAdminJobId(transactionManager, entity.SaCdeAdminJobId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCdeAdminJob object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCdeAdminJob instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCdeAdminJob Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCdeAdminJob entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.SaCdeAdminJobIdSource != null)
						{
							child.SaCdeAdminJobId = child.SaCdeAdminJobIdSource.SaCdeAdminJobId;
						}
						else
						{
							child.SaCdeAdminJobId = entity.SaCdeAdminJobId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCdeAdminJobChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCdeAdminJob</c>
	///</summary>
	public enum SaCdeAdminJobChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCdeAdminJob</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
	}
	
	#endregion SaCdeAdminJobChildEntityTypes
	
	#region SaCdeAdminJobFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCdeAdminJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAdminJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCdeAdminJobFilterBuilder : SqlFilterBuilder<SaCdeAdminJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobFilterBuilder class.
		/// </summary>
		public SaCdeAdminJobFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCdeAdminJobFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCdeAdminJobFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCdeAdminJobFilterBuilder
	
	#region SaCdeAdminJobParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCdeAdminJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAdminJob"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCdeAdminJobParameterBuilder : ParameterizedSqlFilterBuilder<SaCdeAdminJobColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobParameterBuilder class.
		/// </summary>
		public SaCdeAdminJobParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCdeAdminJobParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCdeAdminJobParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCdeAdminJobParameterBuilder
	
	#region SaCdeAdminJobSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCdeAdminJobColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCdeAdminJob"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCdeAdminJobSortBuilder : SqlSortBuilder<SaCdeAdminJobColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCdeAdminJobSqlSortBuilder class.
		/// </summary>
		public SaCdeAdminJobSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCdeAdminJobSortBuilder
	
} // end namespace
