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
	/// This class is the base class for any <see cref="ErpEmpProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ErpEmpProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ErpEmp, UMIS_VER2.BusinessLyer.ErpEmpKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpEmpKey key)
		{
			return Delete(transactionManager, key.ErpEmpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_erpEmpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _erpEmpId)
		{
			return Delete(null, _erpEmpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _erpEmpId);		
		
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
		public override UMIS_VER2.BusinessLyer.ErpEmp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpEmpKey key, int start, int pageLength)
		{
			return GetByErpEmpId(transactionManager, key.ErpEmpId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ERP_EMP index.
		/// </summary>
		/// <param name="_erpEmpId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(System.Decimal _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(null,_erpEmpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_EMP index.
		/// </summary>
		/// <param name="_erpEmpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(System.Decimal _erpEmpId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpEmpId(null, _erpEmpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_EMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_EMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_EMP index.
		/// </summary>
		/// <param name="_erpEmpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(System.Decimal _erpEmpId, int start, int pageLength, out int count)
		{
			return GetByErpEmpId(null, _erpEmpId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_EMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ErpEmp GetByErpEmpId(TransactionManager transactionManager, System.Decimal _erpEmpId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ErpEmp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ErpEmp&gt;"/></returns>
		public static TList<ErpEmp> Fill(IDataReader reader, TList<ErpEmp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ErpEmp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ErpEmp")
					.Append("|").Append((System.Decimal)reader["ERP_EMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ErpEmp>(
					key.ToString(), // EntityTrackingKey
					"ErpEmp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ErpEmp();
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
					c.ErpEmpId = (System.Decimal)reader["ERP_EMP_ID"];
					c.OriginalErpEmpId = c.ErpEmpId;
					c.EmpNameAr = (System.String)reader["EMP_NAME_AR"];
					c.EmpNameEn = (System.String)reader["EMP_NAME_EN"];
					c.EmpRank = Convert.IsDBNull(reader["EMP_RANK"]) ? null : (System.String)reader["EMP_RANK"];
					c.RankAr = Convert.IsDBNull(reader["RANK_AR"]) ? null : (System.String)reader["RANK_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ErpEmp entity)
		{
			if (!reader.Read()) return;
			
			entity.ErpEmpId = (System.Decimal)reader[((int)ErpEmpColumn.ErpEmpId - 1)];
			entity.OriginalErpEmpId = (System.Decimal)reader["ERP_EMP_ID"];
			entity.EmpNameAr = (System.String)reader[((int)ErpEmpColumn.EmpNameAr - 1)];
			entity.EmpNameEn = (System.String)reader[((int)ErpEmpColumn.EmpNameEn - 1)];
			entity.EmpRank = (reader.IsDBNull(((int)ErpEmpColumn.EmpRank - 1)))?null:(System.String)reader[((int)ErpEmpColumn.EmpRank - 1)];
			entity.RankAr = (reader.IsDBNull(((int)ErpEmpColumn.RankAr - 1)))?null:(System.String)reader[((int)ErpEmpColumn.RankAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ErpEmp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ErpEmpId = (System.Decimal)dataRow["ERP_EMP_ID"];
			entity.OriginalErpEmpId = (System.Decimal)dataRow["ERP_EMP_ID"];
			entity.EmpNameAr = (System.String)dataRow["EMP_NAME_AR"];
			entity.EmpNameEn = (System.String)dataRow["EMP_NAME_EN"];
			entity.EmpRank = Convert.IsDBNull(dataRow["EMP_RANK"]) ? null : (System.String)dataRow["EMP_RANK"];
			entity.RankAr = Convert.IsDBNull(dataRow["RANK_AR"]) ? null : (System.String)dataRow["RANK_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpEmp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ErpEmp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpEmp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByErpEmpId methods when available
			
			#region CtrKtchnStfCrtfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrKtchnStfCrtf>|CtrKtchnStfCrtfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrKtchnStfCrtfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrKtchnStfCrtfCollection = DataRepository.CtrKtchnStfCrtfProvider.GetByErpEmpId(transactionManager, entity.ErpEmpId);

				if (deep && entity.CtrKtchnStfCrtfCollection.Count > 0)
				{
					deepHandles.Add("CtrKtchnStfCrtfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrKtchnStfCrtf>) DataRepository.CtrKtchnStfCrtfProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrKtchnStfCrtfCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrSrvcCrewCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrSrvcCrew>|CtrSrvcCrewCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrSrvcCrewCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrSrvcCrewCollection = DataRepository.CtrSrvcCrewProvider.GetByErpEmpId(transactionManager, entity.ErpEmpId);

				if (deep && entity.CtrSrvcCrewCollection.Count > 0)
				{
					deepHandles.Add("CtrSrvcCrewCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrSrvcCrew>) DataRepository.CtrSrvcCrewProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrSrvcCrewCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ErpEmp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ErpEmp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ErpEmp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpEmp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrKtchnStfCrtf>
				if (CanDeepSave(entity.CtrKtchnStfCrtfCollection, "List<CtrKtchnStfCrtf>|CtrKtchnStfCrtfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrKtchnStfCrtf child in entity.CtrKtchnStfCrtfCollection)
					{
						if(child.ErpEmpIdSource != null)
						{
							child.ErpEmpId = child.ErpEmpIdSource.ErpEmpId;
						}
						else
						{
							child.ErpEmpId = entity.ErpEmpId;
						}

					}

					if (entity.CtrKtchnStfCrtfCollection.Count > 0 || entity.CtrKtchnStfCrtfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrKtchnStfCrtfProvider.Save(transactionManager, entity.CtrKtchnStfCrtfCollection);
						
						deepHandles.Add("CtrKtchnStfCrtfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrKtchnStfCrtf >) DataRepository.CtrKtchnStfCrtfProvider.DeepSave,
							new object[] { transactionManager, entity.CtrKtchnStfCrtfCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrSrvcCrew>
				if (CanDeepSave(entity.CtrSrvcCrewCollection, "List<CtrSrvcCrew>|CtrSrvcCrewCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrSrvcCrew child in entity.CtrSrvcCrewCollection)
					{
						if(child.ErpEmpIdSource != null)
						{
							child.ErpEmpId = child.ErpEmpIdSource.ErpEmpId;
						}
						else
						{
							child.ErpEmpId = entity.ErpEmpId;
						}

					}

					if (entity.CtrSrvcCrewCollection.Count > 0 || entity.CtrSrvcCrewCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrSrvcCrewProvider.Save(transactionManager, entity.CtrSrvcCrewCollection);
						
						deepHandles.Add("CtrSrvcCrewCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrSrvcCrew >) DataRepository.CtrSrvcCrewProvider.DeepSave,
							new object[] { transactionManager, entity.CtrSrvcCrewCollection, deepSaveType, childTypes, innerList }
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
	
	#region ErpEmpChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ErpEmp</c>
	///</summary>
	public enum ErpEmpChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ErpEmp</c> as OneToMany for CtrKtchnStfCrtfCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrKtchnStfCrtf>))]
		CtrKtchnStfCrtfCollection,
		///<summary>
		/// Collection of <c>ErpEmp</c> as OneToMany for CtrSrvcCrewCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrSrvcCrew>))]
		CtrSrvcCrewCollection,
	}
	
	#endregion ErpEmpChildEntityTypes
	
	#region ErpEmpFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ErpEmpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpEmp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ErpEmpFilterBuilder : SqlFilterBuilder<ErpEmpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpEmpFilterBuilder class.
		/// </summary>
		public ErpEmpFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ErpEmpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ErpEmpFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ErpEmpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ErpEmpFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ErpEmpFilterBuilder
	
	#region ErpEmpParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ErpEmpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpEmp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ErpEmpParameterBuilder : ParameterizedSqlFilterBuilder<ErpEmpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpEmpParameterBuilder class.
		/// </summary>
		public ErpEmpParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ErpEmpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ErpEmpParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ErpEmpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ErpEmpParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ErpEmpParameterBuilder
	
	#region ErpEmpSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ErpEmpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpEmp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ErpEmpSortBuilder : SqlSortBuilder<ErpEmpColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpEmpSqlSortBuilder class.
		/// </summary>
		public ErpEmpSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ErpEmpSortBuilder
	
} // end namespace
