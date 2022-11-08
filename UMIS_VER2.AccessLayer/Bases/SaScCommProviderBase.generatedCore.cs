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
	/// This class is the base class for any <see cref="SaScCommProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaScCommProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaScComm, UMIS_VER2.BusinessLyer.SaScCommKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommKey key)
		{
			return Delete(transactionManager, key.SaScCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saScCommId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saScCommId)
		{
			return Delete(null, _saScCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saScCommId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaScComm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommKey key, int start, int pageLength)
		{
			return GetBySaScCommId(transactionManager, key.SaScCommId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(null,_saScCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength, out int count)
		{
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaScComm GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaScComm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaScComm&gt;"/></returns>
		public static TList<SaScComm> Fill(IDataReader reader, TList<SaScComm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaScComm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaScComm")
					.Append("|").Append((System.Decimal)reader["SA_SC_COMM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaScComm>(
					key.ToString(), // EntityTrackingKey
					"SaScComm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaScComm();
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
					c.SaScCommId = (System.Decimal)reader["SA_SC_COMM_ID"];
					c.OriginalSaScCommId = c.SaScCommId;
					c.CommNum = (System.String)reader["COMM_NUM"];
					c.CommDate = (System.DateTime)reader["COMM_DATE"];
					c.MinisterApprovalDate = (System.DateTime)reader["MINISTER_APPROVAL_DATE"];
					c.Coments = Convert.IsDBNull(reader["COMENTS"]) ? null : (System.String)reader["COMENTS"];
					c.NoOfMems = (System.Decimal)reader["NO_OF_MEMS"];
					c.AsUniversityInfoId = (System.Decimal)reader["AS_UNIVERSITY_INFO_ID"];
					c.CommEndDate = Convert.IsDBNull(reader["COMM_END_DATE"]) ? null : (System.DateTime?)reader["COMM_END_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaScComm entity)
		{
			if (!reader.Read()) return;
			
			entity.SaScCommId = (System.Decimal)reader[((int)SaScCommColumn.SaScCommId - 1)];
			entity.OriginalSaScCommId = (System.Decimal)reader["SA_SC_COMM_ID"];
			entity.CommNum = (System.String)reader[((int)SaScCommColumn.CommNum - 1)];
			entity.CommDate = (System.DateTime)reader[((int)SaScCommColumn.CommDate - 1)];
			entity.MinisterApprovalDate = (System.DateTime)reader[((int)SaScCommColumn.MinisterApprovalDate - 1)];
			entity.Coments = (reader.IsDBNull(((int)SaScCommColumn.Coments - 1)))?null:(System.String)reader[((int)SaScCommColumn.Coments - 1)];
			entity.NoOfMems = (System.Decimal)reader[((int)SaScCommColumn.NoOfMems - 1)];
			entity.AsUniversityInfoId = (System.Decimal)reader[((int)SaScCommColumn.AsUniversityInfoId - 1)];
			entity.CommEndDate = (reader.IsDBNull(((int)SaScCommColumn.CommEndDate - 1)))?null:(System.DateTime?)reader[((int)SaScCommColumn.CommEndDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaScComm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaScCommId = (System.Decimal)dataRow["SA_SC_COMM_ID"];
			entity.OriginalSaScCommId = (System.Decimal)dataRow["SA_SC_COMM_ID"];
			entity.CommNum = (System.String)dataRow["COMM_NUM"];
			entity.CommDate = (System.DateTime)dataRow["COMM_DATE"];
			entity.MinisterApprovalDate = (System.DateTime)dataRow["MINISTER_APPROVAL_DATE"];
			entity.Coments = Convert.IsDBNull(dataRow["COMENTS"]) ? null : (System.String)dataRow["COMENTS"];
			entity.NoOfMems = (System.Decimal)dataRow["NO_OF_MEMS"];
			entity.AsUniversityInfoId = (System.Decimal)dataRow["AS_UNIVERSITY_INFO_ID"];
			entity.CommEndDate = Convert.IsDBNull(dataRow["COMM_END_DATE"]) ? null : (System.DateTime?)dataRow["COMM_END_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScComm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScComm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScComm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaScCommId methods when available
			
			#region SaScResearchCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScResearch>|SaScResearchCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScResearchCollection = DataRepository.SaScResearchProvider.GetBySaScCommId(transactionManager, entity.SaScCommId);

				if (deep && entity.SaScResearchCollection.Count > 0)
				{
					deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScResearch>) DataRepository.SaScResearchProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScResearchCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCommMember>|SaCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCommMemberCollection = DataRepository.SaCommMemberProvider.GetBySaScCommId(transactionManager, entity.SaScCommId);

				if (deep && entity.SaCommMemberCollection.Count > 0)
				{
					deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCommMember>) DataRepository.SaCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCommMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScCommDecisionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScCommDecision>|SaScCommDecisionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommDecisionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScCommDecisionCollection = DataRepository.SaScCommDecisionProvider.GetBySaScCommId(transactionManager, entity.SaScCommId);

				if (deep && entity.SaScCommDecisionCollection.Count > 0)
				{
					deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScCommDecision>) DataRepository.SaScCommDecisionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScCommDecisionCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaScComm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaScComm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScComm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScComm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaScResearch>
				if (CanDeepSave(entity.SaScResearchCollection, "List<SaScResearch>|SaScResearchCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScResearch child in entity.SaScResearchCollection)
					{
						if(child.SaScCommIdSource != null)
						{
							child.SaScCommId = child.SaScCommIdSource.SaScCommId;
						}
						else
						{
							child.SaScCommId = entity.SaScCommId;
						}

					}

					if (entity.SaScResearchCollection.Count > 0 || entity.SaScResearchCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchCollection);
						
						deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScResearch >) DataRepository.SaScResearchProvider.DeepSave,
							new object[] { transactionManager, entity.SaScResearchCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCommMember>
				if (CanDeepSave(entity.SaCommMemberCollection, "List<SaCommMember>|SaCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCommMember child in entity.SaCommMemberCollection)
					{
						if(child.SaScCommIdSource != null)
						{
							child.SaScCommId = child.SaScCommIdSource.SaScCommId;
						}
						else
						{
							child.SaScCommId = entity.SaScCommId;
						}

					}

					if (entity.SaCommMemberCollection.Count > 0 || entity.SaCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCommMemberProvider.Save(transactionManager, entity.SaCommMemberCollection);
						
						deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCommMember >) DataRepository.SaCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaCommMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScCommDecision>
				if (CanDeepSave(entity.SaScCommDecisionCollection, "List<SaScCommDecision>|SaScCommDecisionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScCommDecision child in entity.SaScCommDecisionCollection)
					{
						if(child.SaScCommIdSource != null)
						{
							child.SaScCommId = child.SaScCommIdSource.SaScCommId;
						}
						else
						{
							child.SaScCommId = entity.SaScCommId;
						}

					}

					if (entity.SaScCommDecisionCollection.Count > 0 || entity.SaScCommDecisionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScCommDecisionProvider.Save(transactionManager, entity.SaScCommDecisionCollection);
						
						deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScCommDecision >) DataRepository.SaScCommDecisionProvider.DeepSave,
							new object[] { transactionManager, entity.SaScCommDecisionCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaScCommChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaScComm</c>
	///</summary>
	public enum SaScCommChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaScComm</c> as OneToMany for SaScResearchCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScResearch>))]
		SaScResearchCollection,
		///<summary>
		/// Collection of <c>SaScComm</c> as OneToMany for SaCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCommMember>))]
		SaCommMemberCollection,
		///<summary>
		/// Collection of <c>SaScComm</c> as OneToMany for SaScCommDecisionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScCommDecision>))]
		SaScCommDecisionCollection,
	}
	
	#endregion SaScCommChildEntityTypes
	
	#region SaScCommFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaScCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScCommFilterBuilder : SqlFilterBuilder<SaScCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommFilterBuilder class.
		/// </summary>
		public SaScCommFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScCommFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScCommFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScCommFilterBuilder
	
	#region SaScCommParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaScCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScCommParameterBuilder : ParameterizedSqlFilterBuilder<SaScCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommParameterBuilder class.
		/// </summary>
		public SaScCommParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScCommParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScCommParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScCommParameterBuilder
	
	#region SaScCommSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaScCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScComm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaScCommSortBuilder : SqlSortBuilder<SaScCommColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommSqlSortBuilder class.
		/// </summary>
		public SaScCommSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaScCommSortBuilder
	
} // end namespace
