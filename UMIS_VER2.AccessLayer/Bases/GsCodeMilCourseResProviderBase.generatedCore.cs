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
	/// This class is the base class for any <see cref="GsCodeMilCourseResProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeMilCourseResProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeMilCourseRes, UMIS_VER2.BusinessLyer.GsCodeMilCourseResKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilCourseResKey key)
		{
			return Delete(transactionManager, key.GsCodeMilCourseResId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeMilCourseResId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeMilCourseResId)
		{
			return Delete(null, _gsCodeMilCourseResId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeMilCourseResId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeMilCourseRes Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilCourseResKey key, int start, int pageLength)
		{
			return GetByGsCodeMilCourseResId(transactionManager, key.GsCodeMilCourseResId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="_resDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(System.String _resDescrAr)
		{
			int count = -1;
			return GetByResDescrAr(null,_resDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="_resDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(System.String _resDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByResDescrAr(null, _resDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_resDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(TransactionManager transactionManager, System.String _resDescrAr)
		{
			int count = -1;
			return GetByResDescrAr(transactionManager, _resDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_resDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(TransactionManager transactionManager, System.String _resDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByResDescrAr(transactionManager, _resDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="_resDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(System.String _resDescrAr, int start, int pageLength, out int count)
		{
			return GetByResDescrAr(null, _resDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_RES_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_resDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByResDescrAr(TransactionManager transactionManager, System.String _resDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(System.Decimal _gsCodeMilCourseResId)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(null,_gsCodeMilCourseResId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(System.Decimal _gsCodeMilCourseResId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(null, _gsCodeMilCourseResId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal _gsCodeMilCourseResId)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(transactionManager, _gsCodeMilCourseResId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal _gsCodeMilCourseResId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(transactionManager, _gsCodeMilCourseResId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(System.Decimal _gsCodeMilCourseResId, int start, int pageLength, out int count)
		{
			return GetByGsCodeMilCourseResId(null, _gsCodeMilCourseResId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MIL_COURSE_RES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeMilCourseRes GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal _gsCodeMilCourseResId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeMilCourseRes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeMilCourseRes&gt;"/></returns>
		public static TList<GsCodeMilCourseRes> Fill(IDataReader reader, TList<GsCodeMilCourseRes> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeMilCourseRes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeMilCourseRes")
					.Append("|").Append((System.Decimal)reader["GS_CODE_MIL_COURSE_RES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeMilCourseRes>(
					key.ToString(), // EntityTrackingKey
					"GsCodeMilCourseRes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeMilCourseRes();
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
					c.GsCodeMilCourseResId = (System.Decimal)reader["GS_CODE_MIL_COURSE_RES_ID"];
					c.OriginalGsCodeMilCourseResId = c.GsCodeMilCourseResId;
					c.ResDescrAr = (System.String)reader["RES_DESCR_AR"];
					c.ResDescrEn = Convert.IsDBNull(reader["RES_DESCR_EN"]) ? null : (System.String)reader["RES_DESCR_EN"];
					c.ResCode = (System.String)reader["RES_CODE"];
					c.PassFlg = Convert.IsDBNull(reader["PASS_FLG"]) ? null : (System.Int16?)reader["PASS_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeMilCourseRes entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeMilCourseResId = (System.Decimal)reader[((int)GsCodeMilCourseResColumn.GsCodeMilCourseResId - 1)];
			entity.OriginalGsCodeMilCourseResId = (System.Decimal)reader["GS_CODE_MIL_COURSE_RES_ID"];
			entity.ResDescrAr = (System.String)reader[((int)GsCodeMilCourseResColumn.ResDescrAr - 1)];
			entity.ResDescrEn = (reader.IsDBNull(((int)GsCodeMilCourseResColumn.ResDescrEn - 1)))?null:(System.String)reader[((int)GsCodeMilCourseResColumn.ResDescrEn - 1)];
			entity.ResCode = (System.String)reader[((int)GsCodeMilCourseResColumn.ResCode - 1)];
			entity.PassFlg = (reader.IsDBNull(((int)GsCodeMilCourseResColumn.PassFlg - 1)))?null:(System.Int16?)reader[((int)GsCodeMilCourseResColumn.PassFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeMilCourseRes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeMilCourseResId = (System.Decimal)dataRow["GS_CODE_MIL_COURSE_RES_ID"];
			entity.OriginalGsCodeMilCourseResId = (System.Decimal)dataRow["GS_CODE_MIL_COURSE_RES_ID"];
			entity.ResDescrAr = (System.String)dataRow["RES_DESCR_AR"];
			entity.ResDescrEn = Convert.IsDBNull(dataRow["RES_DESCR_EN"]) ? null : (System.String)dataRow["RES_DESCR_EN"];
			entity.ResCode = (System.String)dataRow["RES_CODE"];
			entity.PassFlg = Convert.IsDBNull(dataRow["PASS_FLG"]) ? null : (System.Int16?)dataRow["PASS_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilCourseRes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeMilCourseRes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilCourseRes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeMilCourseResId methods when available
			
			#region EdStudMltryCrsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMltryCrsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMltryCrsCollection = DataRepository.EdStudMltryCrsProvider.GetByGsCodeMilCourseResId(transactionManager, entity.GsCodeMilCourseResId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeMilCourseRes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeMilCourseRes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeMilCourseRes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilCourseRes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudMltryCrs>
				if (CanDeepSave(entity.EdStudMltryCrsCollection, "List<EdStudMltryCrs>|EdStudMltryCrsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMltryCrs child in entity.EdStudMltryCrsCollection)
					{
						if(child.GsCodeMilCourseResIdSource != null)
						{
							child.GsCodeMilCourseResId = child.GsCodeMilCourseResIdSource.GsCodeMilCourseResId;
						}
						else
						{
							child.GsCodeMilCourseResId = entity.GsCodeMilCourseResId;
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
	
	#region GsCodeMilCourseResChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeMilCourseRes</c>
	///</summary>
	public enum GsCodeMilCourseResChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeMilCourseRes</c> as OneToMany for EdStudMltryCrsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMltryCrs>))]
		EdStudMltryCrsCollection,
	}
	
	#endregion GsCodeMilCourseResChildEntityTypes
	
	#region GsCodeMilCourseResFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeMilCourseResColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilCourseRes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeMilCourseResFilterBuilder : SqlFilterBuilder<GsCodeMilCourseResColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResFilterBuilder class.
		/// </summary>
		public GsCodeMilCourseResFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeMilCourseResFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeMilCourseResFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeMilCourseResFilterBuilder
	
	#region GsCodeMilCourseResParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeMilCourseResColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilCourseRes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeMilCourseResParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeMilCourseResColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResParameterBuilder class.
		/// </summary>
		public GsCodeMilCourseResParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeMilCourseResParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeMilCourseResParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeMilCourseResParameterBuilder
	
	#region GsCodeMilCourseResSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeMilCourseResColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilCourseRes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeMilCourseResSortBuilder : SqlSortBuilder<GsCodeMilCourseResColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilCourseResSqlSortBuilder class.
		/// </summary>
		public GsCodeMilCourseResSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeMilCourseResSortBuilder
	
} // end namespace
