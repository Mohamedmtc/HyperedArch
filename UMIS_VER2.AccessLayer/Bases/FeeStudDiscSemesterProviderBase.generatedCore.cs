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
	/// This class is the base class for any <see cref="FeeStudDiscSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudDiscSemester, UMIS_VER2.BusinessLyer.FeeStudDiscSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscSemesterKey key)
		{
			return Delete(transactionManager, key.FeeStudDiscSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudDiscSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudDiscSemesterId)
		{
			return Delete(null, _feeStudDiscSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudDiscSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		public TList<FeeStudDiscSemester> GetByFeeStudDiscId(System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(_feeStudDiscId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscSemester> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		public TList<FeeStudDiscSemester> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		fkFeeStudDiscSemesterFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		public TList<FeeStudDiscSemester> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		fkFeeStudDiscSemesterFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		public TList<FeeStudDiscSemester> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength,out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_SEMESTER_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscSemester objects.</returns>
		public abstract TList<FeeStudDiscSemester> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudDiscSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscSemesterKey key, int start, int pageLength)
		{
			return GetByFeeStudDiscSemesterId(transactionManager, key.FeeStudDiscSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(System.Decimal _feeStudDiscSemesterId)
		{
			int count = -1;
			return GetByFeeStudDiscSemesterId(null,_feeStudDiscSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(System.Decimal _feeStudDiscSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscSemesterId(null, _feeStudDiscSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(TransactionManager transactionManager, System.Decimal _feeStudDiscSemesterId)
		{
			int count = -1;
			return GetByFeeStudDiscSemesterId(transactionManager, _feeStudDiscSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(TransactionManager transactionManager, System.Decimal _feeStudDiscSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscSemesterId(transactionManager, _feeStudDiscSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(System.Decimal _feeStudDiscSemesterId, int start, int pageLength, out int count)
		{
			return GetByFeeStudDiscSemesterId(null, _feeStudDiscSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudDiscSemester GetByFeeStudDiscSemesterId(TransactionManager transactionManager, System.Decimal _feeStudDiscSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudDiscSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudDiscSemester&gt;"/></returns>
		public static TList<FeeStudDiscSemester> Fill(IDataReader reader, TList<FeeStudDiscSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudDiscSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudDiscSemester")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_DISC_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudDiscSemester>(
					key.ToString(), // EntityTrackingKey
					"FeeStudDiscSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudDiscSemester();
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
					c.FeeStudDiscSemesterId = (System.Decimal)reader["FEE_STUD_DISC_SEMESTER_ID"];
					c.OriginalFeeStudDiscSemesterId = c.FeeStudDiscSemesterId;
					c.FeeStudDiscId = (System.Decimal)reader["FEE_STUD_DISC_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.DiscPercent = Convert.IsDBNull(reader["DISC_PERCENT"]) ? null : (System.Decimal?)reader["DISC_PERCENT"];
					c.DiscAmnt = Convert.IsDBNull(reader["DISC_AMNT"]) ? null : (System.Decimal?)reader["DISC_AMNT"];
					c.IsActive = (System.Boolean)reader["IS_ACTIVE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudDiscSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudDiscSemesterId = (System.Decimal)reader[((int)FeeStudDiscSemesterColumn.FeeStudDiscSemesterId - 1)];
			entity.OriginalFeeStudDiscSemesterId = (System.Decimal)reader["FEE_STUD_DISC_SEMESTER_ID"];
			entity.FeeStudDiscId = (System.Decimal)reader[((int)FeeStudDiscSemesterColumn.FeeStudDiscId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudDiscSemesterColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudDiscSemesterColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeStudDiscSemesterColumn.EdCodeSemesterId - 1)];
			entity.DiscPercent = (reader.IsDBNull(((int)FeeStudDiscSemesterColumn.DiscPercent - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscSemesterColumn.DiscPercent - 1)];
			entity.DiscAmnt = (reader.IsDBNull(((int)FeeStudDiscSemesterColumn.DiscAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscSemesterColumn.DiscAmnt - 1)];
			entity.IsActive = (System.Boolean)reader[((int)FeeStudDiscSemesterColumn.IsActive - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudDiscSemesterColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscSemesterColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudDiscSemesterColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudDiscSemesterColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudDiscSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudDiscSemesterId = (System.Decimal)dataRow["FEE_STUD_DISC_SEMESTER_ID"];
			entity.OriginalFeeStudDiscSemesterId = (System.Decimal)dataRow["FEE_STUD_DISC_SEMESTER_ID"];
			entity.FeeStudDiscId = (System.Decimal)dataRow["FEE_STUD_DISC_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.DiscPercent = Convert.IsDBNull(dataRow["DISC_PERCENT"]) ? null : (System.Decimal?)dataRow["DISC_PERCENT"];
			entity.DiscAmnt = Convert.IsDBNull(dataRow["DISC_AMNT"]) ? null : (System.Decimal?)dataRow["DISC_AMNT"];
			entity.IsActive = (System.Boolean)dataRow["IS_ACTIVE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeStudDiscIdSource	
			if (CanDeepLoad(entity, "FeeStudDisc|FeeStudDiscIdSource", deepLoadType, innerList) 
				&& entity.FeeStudDiscIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudDiscId;
				FeeStudDisc tmpEntity = EntityManager.LocateEntity<FeeStudDisc>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudDisc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudDiscIdSource = tmpEntity;
				else
					entity.FeeStudDiscIdSource = DataRepository.FeeStudDiscProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudDiscIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudDiscProvider.DeepLoad(transactionManager, entity.FeeStudDiscIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudDiscIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudDiscSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudDiscSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeStudDiscIdSource
			if (CanDeepSave(entity, "FeeStudDisc|FeeStudDiscIdSource", deepSaveType, innerList) 
				&& entity.FeeStudDiscIdSource != null)
			{
				DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscIdSource);
				entity.FeeStudDiscId = entity.FeeStudDiscIdSource.FeeStudDiscId;
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
	
	#region FeeStudDiscSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudDiscSemester</c>
	///</summary>
	public enum FeeStudDiscSemesterChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeStudDisc</c> at FeeStudDiscIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudDisc))]
		FeeStudDisc,
	}
	
	#endregion FeeStudDiscSemesterChildEntityTypes
	
	#region FeeStudDiscSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudDiscSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscSemesterFilterBuilder : SqlFilterBuilder<FeeStudDiscSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterFilterBuilder class.
		/// </summary>
		public FeeStudDiscSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscSemesterFilterBuilder
	
	#region FeeStudDiscSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudDiscSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscSemesterParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudDiscSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterParameterBuilder class.
		/// </summary>
		public FeeStudDiscSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscSemesterParameterBuilder
	
	#region FeeStudDiscSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudDiscSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudDiscSemesterSortBuilder : SqlSortBuilder<FeeStudDiscSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscSemesterSqlSortBuilder class.
		/// </summary>
		public FeeStudDiscSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudDiscSemesterSortBuilder
	
} // end namespace
