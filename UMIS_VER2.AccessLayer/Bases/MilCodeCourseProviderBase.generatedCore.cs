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
	/// This class is the base class for any <see cref="MilCodeCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MilCodeCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MilCodeCourse, UMIS_VER2.BusinessLyer.MilCodeCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MilCodeCourseKey key)
		{
			return Delete(transactionManager, key.MilCodeCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _milCodeCourseId)
		{
			return Delete(null, _milCodeCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _milCodeCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		FK_MIL_CODE_COURSE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		public TList<MilCodeCourse> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		FK_MIL_CODE_COURSE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		/// <remarks></remarks>
		public TList<MilCodeCourse> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		FK_MIL_CODE_COURSE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		public TList<MilCodeCourse> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		fkMilCodeCourseEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		public TList<MilCodeCourse> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		fkMilCodeCourseEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		public TList<MilCodeCourse> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MIL_CODE_COURSE_ED_ACAD_YEAR key.
		///		FK_MIL_CODE_COURSE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الدورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MilCodeCourse objects.</returns>
		public abstract TList<MilCodeCourse> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MilCodeCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MilCodeCourseKey key, int start, int pageLength)
		{
			return GetByMilCodeCourseId(transactionManager, key.MilCodeCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(System.Int32 _milCodeCourseId)
		{
			int count = -1;
			return GetByMilCodeCourseId(null,_milCodeCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(System.Int32 _milCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMilCodeCourseId(null, _milCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32 _milCodeCourseId)
		{
			int count = -1;
			return GetByMilCodeCourseId(transactionManager, _milCodeCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32 _milCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMilCodeCourseId(transactionManager, _milCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(System.Int32 _milCodeCourseId, int start, int pageLength, out int count)
		{
			return GetByMilCodeCourseId(null, _milCodeCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MIL_CODE_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MilCodeCourse GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32 _milCodeCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MilCodeCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MilCodeCourse&gt;"/></returns>
		public static TList<MilCodeCourse> Fill(IDataReader reader, TList<MilCodeCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MilCodeCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MilCodeCourse")
					.Append("|").Append((System.Int32)reader["MIL_CODE_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MilCodeCourse>(
					key.ToString(), // EntityTrackingKey
					"MilCodeCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MilCodeCourse();
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
					c.MilCodeCourseId = (System.Int32)reader["MIL_CODE_COURSE_ID"];
					c.OriginalMilCodeCourseId = c.MilCodeCourseId;
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.MilCrsCode = Convert.IsDBNull(reader["MIL_CRS_CODE"]) ? null : (System.String)reader["MIL_CRS_CODE"];
					c.MilCrsAr = (System.String)reader["MIL_CRS_AR"];
					c.MilCrsEn = (System.String)reader["MIL_CRS_EN"];
					c.MilCrsStartDate = Convert.IsDBNull(reader["MIL_CRS_START_DATE"]) ? null : (System.DateTime?)reader["MIL_CRS_START_DATE"];
					c.MilCrsEndDate = Convert.IsDBNull(reader["MIL_CRS_END_DATE"]) ? null : (System.DateTime?)reader["MIL_CRS_END_DATE"];
					c.MilCrsMonths = Convert.IsDBNull(reader["MIL_CRS_MONTHS"]) ? null : (System.Decimal?)reader["MIL_CRS_MONTHS"];
					c.MilCrsDays = Convert.IsDBNull(reader["MIL_CRS_DAYS"]) ? null : (System.Decimal?)reader["MIL_CRS_DAYS"];
					c.MilCrsNotes = Convert.IsDBNull(reader["MIL_CRS_NOTES"]) ? null : (System.String)reader["MIL_CRS_NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MilCodeCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.MilCodeCourseId = (System.Int32)reader[((int)MilCodeCourseColumn.MilCodeCourseId - 1)];
			entity.OriginalMilCodeCourseId = (System.Int32)reader["MIL_CODE_COURSE_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)MilCodeCourseColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)MilCodeCourseColumn.EdAcadYearId - 1)];
			entity.MilCrsCode = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsCode - 1)))?null:(System.String)reader[((int)MilCodeCourseColumn.MilCrsCode - 1)];
			entity.MilCrsAr = (System.String)reader[((int)MilCodeCourseColumn.MilCrsAr - 1)];
			entity.MilCrsEn = (System.String)reader[((int)MilCodeCourseColumn.MilCrsEn - 1)];
			entity.MilCrsStartDate = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsStartDate - 1)))?null:(System.DateTime?)reader[((int)MilCodeCourseColumn.MilCrsStartDate - 1)];
			entity.MilCrsEndDate = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsEndDate - 1)))?null:(System.DateTime?)reader[((int)MilCodeCourseColumn.MilCrsEndDate - 1)];
			entity.MilCrsMonths = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsMonths - 1)))?null:(System.Decimal?)reader[((int)MilCodeCourseColumn.MilCrsMonths - 1)];
			entity.MilCrsDays = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsDays - 1)))?null:(System.Decimal?)reader[((int)MilCodeCourseColumn.MilCrsDays - 1)];
			entity.MilCrsNotes = (reader.IsDBNull(((int)MilCodeCourseColumn.MilCrsNotes - 1)))?null:(System.String)reader[((int)MilCodeCourseColumn.MilCrsNotes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MilCodeCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MilCodeCourseId = (System.Int32)dataRow["MIL_CODE_COURSE_ID"];
			entity.OriginalMilCodeCourseId = (System.Int32)dataRow["MIL_CODE_COURSE_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.MilCrsCode = Convert.IsDBNull(dataRow["MIL_CRS_CODE"]) ? null : (System.String)dataRow["MIL_CRS_CODE"];
			entity.MilCrsAr = (System.String)dataRow["MIL_CRS_AR"];
			entity.MilCrsEn = (System.String)dataRow["MIL_CRS_EN"];
			entity.MilCrsStartDate = Convert.IsDBNull(dataRow["MIL_CRS_START_DATE"]) ? null : (System.DateTime?)dataRow["MIL_CRS_START_DATE"];
			entity.MilCrsEndDate = Convert.IsDBNull(dataRow["MIL_CRS_END_DATE"]) ? null : (System.DateTime?)dataRow["MIL_CRS_END_DATE"];
			entity.MilCrsMonths = Convert.IsDBNull(dataRow["MIL_CRS_MONTHS"]) ? null : (System.Decimal?)dataRow["MIL_CRS_MONTHS"];
			entity.MilCrsDays = Convert.IsDBNull(dataRow["MIL_CRS_DAYS"]) ? null : (System.Decimal?)dataRow["MIL_CRS_DAYS"];
			entity.MilCrsNotes = Convert.IsDBNull(dataRow["MIL_CRS_NOTES"]) ? null : (System.String)dataRow["MIL_CRS_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MilCodeCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MilCodeCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MilCodeCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMilCodeCourseId methods when available
			
			#region EdStudMltryCrsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMltryCrsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMltryCrsCollection = DataRepository.EdStudMltryCrsProvider.GetByMilCodeCourseId(transactionManager, entity.MilCodeCourseId);

				if (deep && entity.EdStudMltryCrsCollection.Count > 0)
				{
					deepHandles.Add("EdStudMltryCrsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMltryCrs>) DataRepository.EdStudMltryCrsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMltryCrsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MilCodeCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MilCodeCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MilCodeCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MilCodeCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudMltryCrs>
				if (CanDeepSave(entity.EdStudMltryCrsCollection, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMltryCrs child in entity.EdStudMltryCrsCollection)
					{
						if(child.MilCodeCourseIdSource != null)
						{
							child.MilCodeCourseId = child.MilCodeCourseIdSource.MilCodeCourseId;
						}
						else
						{
							child.MilCodeCourseId = entity.MilCodeCourseId;
						}

					}

					if (entity.EdStudMltryCrsCollection.Count > 0 || entity.EdStudMltryCrsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMltryCrsProvider.Save(transactionManager, entity.EdStudMltryCrsCollection);
						
						deepHandles.Add("EdStudMltryCrsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMltryCrs >) DataRepository.EdStudMltryCrsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMltryCrsCollection, deepSaveType, childTypes, innerList }
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
	
	#region MilCodeCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MilCodeCourse</c>
	///</summary>
	public enum MilCodeCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		///<summary>
		/// Collection of <c>MilCodeCourse</c> as OneToMany for EdStudMltryCrsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMltryCrs>))]
		EdStudMltryCrsCollection,
	}
	
	#endregion MilCodeCourseChildEntityTypes
	
	#region MilCodeCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MilCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MilCodeCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MilCodeCourseFilterBuilder : SqlFilterBuilder<MilCodeCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseFilterBuilder class.
		/// </summary>
		public MilCodeCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MilCodeCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MilCodeCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MilCodeCourseFilterBuilder
	
	#region MilCodeCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MilCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MilCodeCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MilCodeCourseParameterBuilder : ParameterizedSqlFilterBuilder<MilCodeCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseParameterBuilder class.
		/// </summary>
		public MilCodeCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MilCodeCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MilCodeCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MilCodeCourseParameterBuilder
	
	#region MilCodeCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MilCodeCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MilCodeCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MilCodeCourseSortBuilder : SqlSortBuilder<MilCodeCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MilCodeCourseSqlSortBuilder class.
		/// </summary>
		public MilCodeCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MilCodeCourseSortBuilder
	
} // end namespace
