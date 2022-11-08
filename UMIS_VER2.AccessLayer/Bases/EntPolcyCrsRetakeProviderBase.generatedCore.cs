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
	/// This class is the base class for any <see cref="EntPolcyCrsRetakeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolcyCrsRetakeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolcyCrsRetake, UMIS_VER2.BusinessLyer.EntPolcyCrsRetakeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyCrsRetakeKey key)
		{
			return Delete(transactionManager, key.EntPolcyCrsRetakeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _entPolcyCrsRetakeId)
		{
			return Delete(null, _entPolcyCrsRetakeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _entPolcyCrsRetakeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		public TList<EntPolcyCrsRetake> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyCrsRetake> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		public TList<EntPolcyCrsRetake> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		fkEntPolcyCrsRetakeEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		public TList<EntPolcyCrsRetake> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		fkEntPolcyCrsRetakeEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		public TList<EntPolcyCrsRetake> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW key.
		///		FK_ENT_POLCY_CRS_RETAKE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyCrsRetake objects.</returns>
		public abstract TList<EntPolcyCrsRetake> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolcyCrsRetake Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyCrsRetakeKey key, int start, int pageLength)
		{
			return GetByEntPolcyCrsRetakeId(transactionManager, key.EntPolcyCrsRetakeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(System.Int32 _entPolcyCrsRetakeId)
		{
			int count = -1;
			return GetByEntPolcyCrsRetakeId(null,_entPolcyCrsRetakeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(System.Int32 _entPolcyCrsRetakeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyCrsRetakeId(null, _entPolcyCrsRetakeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(TransactionManager transactionManager, System.Int32 _entPolcyCrsRetakeId)
		{
			int count = -1;
			return GetByEntPolcyCrsRetakeId(transactionManager, _entPolcyCrsRetakeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(TransactionManager transactionManager, System.Int32 _entPolcyCrsRetakeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyCrsRetakeId(transactionManager, _entPolcyCrsRetakeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(System.Int32 _entPolcyCrsRetakeId, int start, int pageLength, out int count)
		{
			return GetByEntPolcyCrsRetakeId(null, _entPolcyCrsRetakeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_CRS_RETAKE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyCrsRetakeId">NU Retake Course</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolcyCrsRetake GetByEntPolcyCrsRetakeId(TransactionManager transactionManager, System.Int32 _entPolcyCrsRetakeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolcyCrsRetake&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolcyCrsRetake&gt;"/></returns>
		public static TList<EntPolcyCrsRetake> Fill(IDataReader reader, TList<EntPolcyCrsRetake> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolcyCrsRetake c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolcyCrsRetake")
					.Append("|").Append((System.Int32)reader["ENT_POLCY_CRS_RETAKE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolcyCrsRetake>(
					key.ToString(), // EntityTrackingKey
					"EntPolcyCrsRetake",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolcyCrsRetake();
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
					c.EntPolcyCrsRetakeId = (System.Int32)reader["ENT_POLCY_CRS_RETAKE_ID"];
					c.OriginalEntPolcyCrsRetakeId = c.EntPolcyCrsRetakeId;
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.RetakeTotNum = Convert.IsDBNull(reader["RETAKE_TOT_NUM"]) ? null : (System.Int32?)reader["RETAKE_TOT_NUM"];
					c.RetakePassedNum = Convert.IsDBNull(reader["RETAKE_PASSED_NUM"]) ? null : (System.Int32?)reader["RETAKE_PASSED_NUM"];
					c.RetakeFailNum = Convert.IsDBNull(reader["RETAKE_FAIL_NUM"]) ? null : (System.Int32?)reader["RETAKE_FAIL_NUM"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolcyCrsRetake entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolcyCrsRetakeId = (System.Int32)reader[((int)EntPolcyCrsRetakeColumn.EntPolcyCrsRetakeId - 1)];
			entity.OriginalEntPolcyCrsRetakeId = (System.Int32)reader["ENT_POLCY_CRS_RETAKE_ID"];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolcyCrsRetakeColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyCrsRetakeColumn.EdBylawId - 1)];
			entity.RetakeTotNum = (reader.IsDBNull(((int)EntPolcyCrsRetakeColumn.RetakeTotNum - 1)))?null:(System.Int32?)reader[((int)EntPolcyCrsRetakeColumn.RetakeTotNum - 1)];
			entity.RetakePassedNum = (reader.IsDBNull(((int)EntPolcyCrsRetakeColumn.RetakePassedNum - 1)))?null:(System.Int32?)reader[((int)EntPolcyCrsRetakeColumn.RetakePassedNum - 1)];
			entity.RetakeFailNum = (reader.IsDBNull(((int)EntPolcyCrsRetakeColumn.RetakeFailNum - 1)))?null:(System.Int32?)reader[((int)EntPolcyCrsRetakeColumn.RetakeFailNum - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolcyCrsRetake entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolcyCrsRetakeId = (System.Int32)dataRow["ENT_POLCY_CRS_RETAKE_ID"];
			entity.OriginalEntPolcyCrsRetakeId = (System.Int32)dataRow["ENT_POLCY_CRS_RETAKE_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.RetakeTotNum = Convert.IsDBNull(dataRow["RETAKE_TOT_NUM"]) ? null : (System.Int32?)dataRow["RETAKE_TOT_NUM"];
			entity.RetakePassedNum = Convert.IsDBNull(dataRow["RETAKE_PASSED_NUM"]) ? null : (System.Int32?)dataRow["RETAKE_PASSED_NUM"];
			entity.RetakeFailNum = Convert.IsDBNull(dataRow["RETAKE_FAIL_NUM"]) ? null : (System.Int32?)dataRow["RETAKE_FAIL_NUM"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyCrsRetake"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyCrsRetake Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyCrsRetake entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolcyCrsRetake object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolcyCrsRetake instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyCrsRetake Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyCrsRetake entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
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
	
	#region EntPolcyCrsRetakeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolcyCrsRetake</c>
	///</summary>
	public enum EntPolcyCrsRetakeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
	}
	
	#endregion EntPolcyCrsRetakeChildEntityTypes
	
	#region EntPolcyCrsRetakeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolcyCrsRetakeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyCrsRetake"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyCrsRetakeFilterBuilder : SqlFilterBuilder<EntPolcyCrsRetakeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeFilterBuilder class.
		/// </summary>
		public EntPolcyCrsRetakeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyCrsRetakeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyCrsRetakeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyCrsRetakeFilterBuilder
	
	#region EntPolcyCrsRetakeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolcyCrsRetakeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyCrsRetake"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyCrsRetakeParameterBuilder : ParameterizedSqlFilterBuilder<EntPolcyCrsRetakeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeParameterBuilder class.
		/// </summary>
		public EntPolcyCrsRetakeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyCrsRetakeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyCrsRetakeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyCrsRetakeParameterBuilder
	
	#region EntPolcyCrsRetakeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolcyCrsRetakeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyCrsRetake"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolcyCrsRetakeSortBuilder : SqlSortBuilder<EntPolcyCrsRetakeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyCrsRetakeSqlSortBuilder class.
		/// </summary>
		public EntPolcyCrsRetakeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolcyCrsRetakeSortBuilder
	
} // end namespace
