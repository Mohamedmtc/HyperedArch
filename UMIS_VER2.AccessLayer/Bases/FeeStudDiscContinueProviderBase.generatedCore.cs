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
	/// This class is the base class for any <see cref="FeeStudDiscContinueProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscContinueProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudDiscContinue, UMIS_VER2.BusinessLyer.FeeStudDiscContinueKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscContinueKey key)
		{
			return Delete(transactionManager, key.FeeStudDiscContinueId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudDiscContinueId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudDiscContinueId)
		{
			return Delete(null, _feeStudDiscContinueId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscContinueId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudDiscContinueId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		public TList<FeeStudDiscContinue> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscContinue> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		public TList<FeeStudDiscContinue> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		fkFeeStudDiscContinueAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		public TList<FeeStudDiscContinue> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		fkFeeStudDiscContinueAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		public TList<FeeStudDiscContinue> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO key.
		///		FK_FEE_STUD_DISC_CONTINUE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscContinue objects.</returns>
		public abstract TList<FeeStudDiscContinue> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudDiscContinue Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscContinueKey key, int start, int pageLength)
		{
			return GetByFeeStudDiscContinueId(transactionManager, key.FeeStudDiscContinueId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(System.Decimal _feeStudDiscContinueId)
		{
			int count = -1;
			return GetByFeeStudDiscContinueId(null,_feeStudDiscContinueId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(System.Decimal _feeStudDiscContinueId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscContinueId(null, _feeStudDiscContinueId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(TransactionManager transactionManager, System.Decimal _feeStudDiscContinueId)
		{
			int count = -1;
			return GetByFeeStudDiscContinueId(transactionManager, _feeStudDiscContinueId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(TransactionManager transactionManager, System.Decimal _feeStudDiscContinueId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscContinueId(transactionManager, _feeStudDiscContinueId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(System.Decimal _feeStudDiscContinueId, int start, int pageLength, out int count)
		{
			return GetByFeeStudDiscContinueId(null, _feeStudDiscContinueId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CONTINUE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscContinueId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudDiscContinue GetByFeeStudDiscContinueId(TransactionManager transactionManager, System.Decimal _feeStudDiscContinueId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudDiscContinue&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudDiscContinue&gt;"/></returns>
		public static TList<FeeStudDiscContinue> Fill(IDataReader reader, TList<FeeStudDiscContinue> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudDiscContinue c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudDiscContinue")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_DISC_CONTINUE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudDiscContinue>(
					key.ToString(), // EntityTrackingKey
					"FeeStudDiscContinue",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudDiscContinue();
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
					c.FeeStudDiscContinueId = (System.Decimal)reader["FEE_STUD_DISC_CONTINUE_ID"];
					c.OriginalFeeStudDiscContinueId = c.FeeStudDiscContinueId;
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.AccumGpaFrom = Convert.IsDBNull(reader["ACCUM_GPA_FROM"]) ? null : (System.Decimal?)reader["ACCUM_GPA_FROM"];
					c.AccumGpaTo = Convert.IsDBNull(reader["ACCUM_GPA_TO"]) ? null : (System.Decimal?)reader["ACCUM_GPA_TO"];
					c.AccumChFrom = Convert.IsDBNull(reader["ACCUM_CH_FROM"]) ? null : (System.Decimal?)reader["ACCUM_CH_FROM"];
					c.AccumChTo = Convert.IsDBNull(reader["ACCUM_CH_TO"]) ? null : (System.Decimal?)reader["ACCUM_CH_TO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudDiscContinue entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudDiscContinueId = (System.Decimal)reader[((int)FeeStudDiscContinueColumn.FeeStudDiscContinueId - 1)];
			entity.OriginalFeeStudDiscContinueId = (System.Decimal)reader["FEE_STUD_DISC_CONTINUE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)FeeStudDiscContinueColumn.AsFacultyInfoId - 1)];
			entity.AccumGpaFrom = (reader.IsDBNull(((int)FeeStudDiscContinueColumn.AccumGpaFrom - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscContinueColumn.AccumGpaFrom - 1)];
			entity.AccumGpaTo = (reader.IsDBNull(((int)FeeStudDiscContinueColumn.AccumGpaTo - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscContinueColumn.AccumGpaTo - 1)];
			entity.AccumChFrom = (reader.IsDBNull(((int)FeeStudDiscContinueColumn.AccumChFrom - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscContinueColumn.AccumChFrom - 1)];
			entity.AccumChTo = (reader.IsDBNull(((int)FeeStudDiscContinueColumn.AccumChTo - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscContinueColumn.AccumChTo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudDiscContinue entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudDiscContinueId = (System.Decimal)dataRow["FEE_STUD_DISC_CONTINUE_ID"];
			entity.OriginalFeeStudDiscContinueId = (System.Decimal)dataRow["FEE_STUD_DISC_CONTINUE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.AccumGpaFrom = Convert.IsDBNull(dataRow["ACCUM_GPA_FROM"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA_FROM"];
			entity.AccumGpaTo = Convert.IsDBNull(dataRow["ACCUM_GPA_TO"]) ? null : (System.Decimal?)dataRow["ACCUM_GPA_TO"];
			entity.AccumChFrom = Convert.IsDBNull(dataRow["ACCUM_CH_FROM"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_FROM"];
			entity.AccumChTo = Convert.IsDBNull(dataRow["ACCUM_CH_TO"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_TO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscContinue"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscContinue Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscContinue entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudDiscContinue object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudDiscContinue instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscContinue Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscContinue entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
	
	#region FeeStudDiscContinueChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudDiscContinue</c>
	///</summary>
	public enum FeeStudDiscContinueChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion FeeStudDiscContinueChildEntityTypes
	
	#region FeeStudDiscContinueFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudDiscContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscContinue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscContinueFilterBuilder : SqlFilterBuilder<FeeStudDiscContinueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueFilterBuilder class.
		/// </summary>
		public FeeStudDiscContinueFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscContinueFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscContinueFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscContinueFilterBuilder
	
	#region FeeStudDiscContinueParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudDiscContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscContinue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscContinueParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudDiscContinueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueParameterBuilder class.
		/// </summary>
		public FeeStudDiscContinueParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscContinueParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscContinueParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscContinueParameterBuilder
	
	#region FeeStudDiscContinueSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudDiscContinueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscContinue"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudDiscContinueSortBuilder : SqlSortBuilder<FeeStudDiscContinueColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscContinueSqlSortBuilder class.
		/// </summary>
		public FeeStudDiscContinueSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudDiscContinueSortBuilder
	
} // end namespace
