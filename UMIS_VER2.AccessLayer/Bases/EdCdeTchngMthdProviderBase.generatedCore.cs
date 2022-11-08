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
	/// This class is the base class for any <see cref="EdCdeTchngMthdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeTchngMthdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeTchngMthd, UMIS_VER2.BusinessLyer.EdCdeTchngMthdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeTchngMthdKey key)
		{
			return Delete(transactionManager, key.EdCdeTchngMthdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeTchngMthdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeTchngMthdId)
		{
			return Delete(null, _edCdeTchngMthdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeTchngMthdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeTchngMthd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeTchngMthdKey key, int start, int pageLength)
		{
			return GetByEdCdeTchngMthdId(transactionManager, key.EdCdeTchngMthdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(System.Decimal _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(null,_edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(System.Decimal _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(System.Decimal _edCdeTchngMthdId, int start, int pageLength, out int count)
		{
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal _edCdeTchngMthdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrArDescrEn(null,_descrAr, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrArDescrEn(null, _descrAr, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrArDescrEn(transactionManager, _descrAr, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrArDescrEn(transactionManager, _descrAr, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(System.String _descrAr, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrArDescrEn(null, _descrAr, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_CDE_TCHNG_MTHD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeTchngMthd GetByDescrArDescrEn(TransactionManager transactionManager, System.String _descrAr, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeTchngMthd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeTchngMthd&gt;"/></returns>
		public static TList<EdCdeTchngMthd> Fill(IDataReader reader, TList<EdCdeTchngMthd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeTchngMthd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeTchngMthd")
					.Append("|").Append((System.Decimal)reader["ED_CDE_TCHNG_MTHD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeTchngMthd>(
					key.ToString(), // EntityTrackingKey
					"EdCdeTchngMthd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeTchngMthd();
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
					c.EdCdeTchngMthdId = (System.Decimal)reader["ED_CDE_TCHNG_MTHD_ID"];
					c.OriginalEdCdeTchngMthdId = c.EdCdeTchngMthdId;
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.AbsChWeight = Convert.IsDBNull(reader["ABS_CH_WEIGHT"]) ? null : (System.Decimal?)reader["ABS_CH_WEIGHT"];
					c.FingerPrintDelayTime = Convert.IsDBNull(reader["FingerPrint_Delay_Time"]) ? null : (System.Decimal?)reader["FingerPrint_Delay_Time"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeTchngMthd entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeTchngMthdId = (System.Decimal)reader[((int)EdCdeTchngMthdColumn.EdCdeTchngMthdId - 1)];
			entity.OriginalEdCdeTchngMthdId = (System.Decimal)reader["ED_CDE_TCHNG_MTHD_ID"];
			entity.DescrEn = (System.String)reader[((int)EdCdeTchngMthdColumn.DescrEn - 1)];
			entity.DescrAr = (System.String)reader[((int)EdCdeTchngMthdColumn.DescrAr - 1)];
			entity.AbsChWeight = (reader.IsDBNull(((int)EdCdeTchngMthdColumn.AbsChWeight - 1)))?null:(System.Decimal?)reader[((int)EdCdeTchngMthdColumn.AbsChWeight - 1)];
			entity.FingerPrintDelayTime = (reader.IsDBNull(((int)EdCdeTchngMthdColumn.FingerPrintDelayTime - 1)))?null:(System.Decimal?)reader[((int)EdCdeTchngMthdColumn.FingerPrintDelayTime - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeTchngMthd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeTchngMthdId = (System.Decimal)dataRow["ED_CDE_TCHNG_MTHD_ID"];
			entity.OriginalEdCdeTchngMthdId = (System.Decimal)dataRow["ED_CDE_TCHNG_MTHD_ID"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.AbsChWeight = Convert.IsDBNull(dataRow["ABS_CH_WEIGHT"]) ? null : (System.Decimal?)dataRow["ABS_CH_WEIGHT"];
			entity.FingerPrintDelayTime = Convert.IsDBNull(dataRow["FingerPrint_Delay_Time"]) ? null : (System.Decimal?)dataRow["FingerPrint_Delay_Time"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeTchngMthd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeTchngMthd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeTchngMthd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeTchngMthdId methods when available
			
			#region ScGroupDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByEdCdeTchngMthdId(transactionManager, entity.EdCdeTchngMthdId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEdCdeTchngMthdId(transactionManager, entity.EdCdeTchngMthdId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeCourseTeachingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeCourseTeaching>|EdCodeCourseTeachingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeCourseTeachingCollection = DataRepository.EdCodeCourseTeachingProvider.GetByEdCdeTchngMthdId(transactionManager, entity.EdCdeTchngMthdId);

				if (deep && entity.EdCodeCourseTeachingCollection.Count > 0)
				{
					deepHandles.Add("EdCodeCourseTeachingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeCourseTeaching>) DataRepository.EdCodeCourseTeachingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeCourseTeachingCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeTchngMthd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeTchngMthd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeTchngMthd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeTchngMthd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollection, "List<ScGroupDay>|ScGroupDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollection)
					{
						if(child.EdCdeTchngMthdIdSource != null)
						{
							child.EdCdeTchngMthdId = child.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
						}
						else
						{
							child.EdCdeTchngMthdId = entity.EdCdeTchngMthdId;
						}

					}

					if (entity.ScGroupDayCollection.Count > 0 || entity.ScGroupDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollection);
						
						deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EdCdeTchngMthdIdSource != null)
						{
							child.EdCdeTchngMthdId = child.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
						}
						else
						{
							child.EdCdeTchngMthdId = entity.EdCdeTchngMthdId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeCourseTeaching>
				if (CanDeepSave(entity.EdCodeCourseTeachingCollection, "List<EdCodeCourseTeaching>|EdCodeCourseTeachingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeCourseTeaching child in entity.EdCodeCourseTeachingCollection)
					{
						if(child.EdCdeTchngMthdIdSource != null)
						{
							child.EdCdeTchngMthdId = child.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
						}
						else
						{
							child.EdCdeTchngMthdId = entity.EdCdeTchngMthdId;
						}

					}

					if (entity.EdCodeCourseTeachingCollection.Count > 0 || entity.EdCodeCourseTeachingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingCollection);
						
						deepHandles.Add("EdCodeCourseTeachingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeCourseTeaching >) DataRepository.EdCodeCourseTeachingProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeCourseTeachingCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeTchngMthdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeTchngMthd</c>
	///</summary>
	public enum EdCdeTchngMthdChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeTchngMthd</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>EdCdeTchngMthd</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EdCdeTchngMthd</c> as OneToMany for EdCodeCourseTeachingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeCourseTeaching>))]
		EdCodeCourseTeachingCollection,
	}
	
	#endregion EdCdeTchngMthdChildEntityTypes
	
	#region EdCdeTchngMthdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeTchngMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeTchngMthd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeTchngMthdFilterBuilder : SqlFilterBuilder<EdCdeTchngMthdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdFilterBuilder class.
		/// </summary>
		public EdCdeTchngMthdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeTchngMthdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeTchngMthdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeTchngMthdFilterBuilder
	
	#region EdCdeTchngMthdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeTchngMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeTchngMthd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeTchngMthdParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeTchngMthdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdParameterBuilder class.
		/// </summary>
		public EdCdeTchngMthdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeTchngMthdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeTchngMthdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeTchngMthdParameterBuilder
	
	#region EdCdeTchngMthdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeTchngMthdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeTchngMthd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeTchngMthdSortBuilder : SqlSortBuilder<EdCdeTchngMthdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeTchngMthdSqlSortBuilder class.
		/// </summary>
		public EdCdeTchngMthdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeTchngMthdSortBuilder
	
} // end namespace
