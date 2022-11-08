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
	/// This class is the base class for any <see cref="EntPolcyGpaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolcyGpaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolcyGpa, UMIS_VER2.BusinessLyer.EntPolcyGpaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGpaKey key)
		{
			return Delete(transactionManager, key.EntPolcyGpaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _entPolcyGpaId)
		{
			return Delete(null, _entPolcyGpaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _entPolcyGpaId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		FK_ENT_POLCY_GPA_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		public TList<EntPolcyGpa> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		FK_ENT_POLCY_GPA_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolcyGpa> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		FK_ENT_POLCY_GPA_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		public TList<EntPolcyGpa> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		fkEntPolcyGpaEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		public TList<EntPolcyGpa> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		fkEntPolcyGpaEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		public TList<EntPolcyGpa> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLCY_GPA_ED_BYLAW key.
		///		FK_ENT_POLCY_GPA_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolcyGpa objects.</returns>
		public abstract TList<EntPolcyGpa> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolcyGpa Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGpaKey key, int start, int pageLength)
		{
			return GetByEntPolcyGpaId(transactionManager, key.EntPolcyGpaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(System.Int32 _entPolcyGpaId)
		{
			int count = -1;
			return GetByEntPolcyGpaId(null,_entPolcyGpaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(System.Int32 _entPolcyGpaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyGpaId(null, _entPolcyGpaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(TransactionManager transactionManager, System.Int32 _entPolcyGpaId)
		{
			int count = -1;
			return GetByEntPolcyGpaId(transactionManager, _entPolcyGpaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(TransactionManager transactionManager, System.Int32 _entPolcyGpaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyGpaId(transactionManager, _entPolcyGpaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(System.Int32 _entPolcyGpaId, int start, int pageLength, out int count)
		{
			return GetByEntPolcyGpaId(null, _entPolcyGpaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLCY_GPA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGpaId">محددات حساب المعدلات الفصلية و التراكمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolcyGpa GetByEntPolcyGpaId(TransactionManager transactionManager, System.Int32 _entPolcyGpaId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolcyGpa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolcyGpa&gt;"/></returns>
		public static TList<EntPolcyGpa> Fill(IDataReader reader, TList<EntPolcyGpa> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolcyGpa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolcyGpa")
					.Append("|").Append((System.Int32)reader["ENT_POLCY_GPA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolcyGpa>(
					key.ToString(), // EntityTrackingKey
					"EntPolcyGpa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolcyGpa();
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
					c.EntPolcyGpaId = (System.Int32)reader["ENT_POLCY_GPA_ID"];
					c.OriginalEntPolcyGpaId = c.EntPolcyGpaId;
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.CgpaFailCourseCount = Convert.IsDBNull(reader["CGPA_FAIL_COURSE_COUNT"]) ? null : (System.Int32?)reader["CGPA_FAIL_COURSE_COUNT"];
					c.GpaDecimalPart = Convert.IsDBNull(reader["GPA_DECIMAL_PART"]) ? null : (System.Int32?)reader["GPA_DECIMAL_PART"];
					c.OnHoldFlag = Convert.IsDBNull(reader["OnHoldFlag"]) ? null : (System.Boolean?)reader["OnHoldFlag"];
					c.OnHoldCount = Convert.IsDBNull(reader["OnHoldCount"]) ? null : (System.Int32?)reader["OnHoldCount"];
					c.CgpaFailCountAfterHold = Convert.IsDBNull(reader["CGPA_FAIL_COUNT_AFTER_HOLD"]) ? null : (System.Int32?)reader["CGPA_FAIL_COUNT_AFTER_HOLD"];
					c.CgpaChFlg = Convert.IsDBNull(reader["CGPA_CH_FLG"]) ? null : (System.Decimal?)reader["CGPA_CH_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolcyGpa entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolcyGpaId = (System.Int32)reader[((int)EntPolcyGpaColumn.EntPolcyGpaId - 1)];
			entity.OriginalEntPolcyGpaId = (System.Int32)reader["ENT_POLCY_GPA_ID"];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolcyGpaColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGpaColumn.EdBylawId - 1)];
			entity.CgpaFailCourseCount = (reader.IsDBNull(((int)EntPolcyGpaColumn.CgpaFailCourseCount - 1)))?null:(System.Int32?)reader[((int)EntPolcyGpaColumn.CgpaFailCourseCount - 1)];
			entity.GpaDecimalPart = (reader.IsDBNull(((int)EntPolcyGpaColumn.GpaDecimalPart - 1)))?null:(System.Int32?)reader[((int)EntPolcyGpaColumn.GpaDecimalPart - 1)];
			entity.OnHoldFlag = (reader.IsDBNull(((int)EntPolcyGpaColumn.OnHoldFlag - 1)))?null:(System.Boolean?)reader[((int)EntPolcyGpaColumn.OnHoldFlag - 1)];
			entity.OnHoldCount = (reader.IsDBNull(((int)EntPolcyGpaColumn.OnHoldCount - 1)))?null:(System.Int32?)reader[((int)EntPolcyGpaColumn.OnHoldCount - 1)];
			entity.CgpaFailCountAfterHold = (reader.IsDBNull(((int)EntPolcyGpaColumn.CgpaFailCountAfterHold - 1)))?null:(System.Int32?)reader[((int)EntPolcyGpaColumn.CgpaFailCountAfterHold - 1)];
			entity.CgpaChFlg = (reader.IsDBNull(((int)EntPolcyGpaColumn.CgpaChFlg - 1)))?null:(System.Decimal?)reader[((int)EntPolcyGpaColumn.CgpaChFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolcyGpa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolcyGpaId = (System.Int32)dataRow["ENT_POLCY_GPA_ID"];
			entity.OriginalEntPolcyGpaId = (System.Int32)dataRow["ENT_POLCY_GPA_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.CgpaFailCourseCount = Convert.IsDBNull(dataRow["CGPA_FAIL_COURSE_COUNT"]) ? null : (System.Int32?)dataRow["CGPA_FAIL_COURSE_COUNT"];
			entity.GpaDecimalPart = Convert.IsDBNull(dataRow["GPA_DECIMAL_PART"]) ? null : (System.Int32?)dataRow["GPA_DECIMAL_PART"];
			entity.OnHoldFlag = Convert.IsDBNull(dataRow["OnHoldFlag"]) ? null : (System.Boolean?)dataRow["OnHoldFlag"];
			entity.OnHoldCount = Convert.IsDBNull(dataRow["OnHoldCount"]) ? null : (System.Int32?)dataRow["OnHoldCount"];
			entity.CgpaFailCountAfterHold = Convert.IsDBNull(dataRow["CGPA_FAIL_COUNT_AFTER_HOLD"]) ? null : (System.Int32?)dataRow["CGPA_FAIL_COUNT_AFTER_HOLD"];
			entity.CgpaChFlg = Convert.IsDBNull(dataRow["CGPA_CH_FLG"]) ? null : (System.Decimal?)dataRow["CGPA_CH_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolcyGpa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyGpa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGpa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolcyGpa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolcyGpa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolcyGpa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolcyGpa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EntPolcyGpaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolcyGpa</c>
	///</summary>
	public enum EntPolcyGpaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
	}
	
	#endregion EntPolcyGpaChildEntityTypes
	
	#region EntPolcyGpaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolcyGpaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGpa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyGpaFilterBuilder : SqlFilterBuilder<EntPolcyGpaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaFilterBuilder class.
		/// </summary>
		public EntPolcyGpaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyGpaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyGpaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyGpaFilterBuilder
	
	#region EntPolcyGpaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolcyGpaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGpa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolcyGpaParameterBuilder : ParameterizedSqlFilterBuilder<EntPolcyGpaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaParameterBuilder class.
		/// </summary>
		public EntPolcyGpaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolcyGpaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolcyGpaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolcyGpaParameterBuilder
	
	#region EntPolcyGpaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolcyGpaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolcyGpa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolcyGpaSortBuilder : SqlSortBuilder<EntPolcyGpaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolcyGpaSqlSortBuilder class.
		/// </summary>
		public EntPolcyGpaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolcyGpaSortBuilder
	
} // end namespace
