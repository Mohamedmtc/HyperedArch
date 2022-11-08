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
	/// This class is the base class for any <see cref="MltCdeBhvrAttndcRltdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltCdeBhvrAttndcRltdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltdKey key)
		{
			return Delete(transactionManager, key.MltCdeBhvrAttndcRltdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltCdeBhvrAttndcRltdId)
		{
			return Delete(null, _mltCdeBhvrAttndcRltdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltCdeBhvrAttndcRltdId);		
		
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
		public override UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltdKey key, int start, int pageLength)
		{
			return GetByMltCdeBhvrAttndcRltdId(transactionManager, key.MltCdeBhvrAttndcRltdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(System.Decimal _mltCdeBhvrAttndcRltdId)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(null,_mltCdeBhvrAttndcRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(System.Decimal _mltCdeBhvrAttndcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(null, _mltCdeBhvrAttndcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal _mltCdeBhvrAttndcRltdId)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(transactionManager, _mltCdeBhvrAttndcRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal _mltCdeBhvrAttndcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeBhvrAttndcRltdId(transactionManager, _mltCdeBhvrAttndcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(System.Decimal _mltCdeBhvrAttndcRltdId, int start, int pageLength, out int count)
		{
			return GetByMltCdeBhvrAttndcRltdId(null, _mltCdeBhvrAttndcRltdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_CDE_BHV_ATTND_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeBhvrAttndcRltdId">سبب  الخصم من السلوك والمواظبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd GetByMltCdeBhvrAttndcRltdId(TransactionManager transactionManager, System.Decimal _mltCdeBhvrAttndcRltdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltCdeBhvrAttndcRltd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltCdeBhvrAttndcRltd&gt;"/></returns>
		public static TList<MltCdeBhvrAttndcRltd> Fill(IDataReader reader, TList<MltCdeBhvrAttndcRltd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltCdeBhvrAttndcRltd")
					.Append("|").Append((System.Decimal)reader["MLT_CDE_BHVR_ATTNDC_RLTD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltCdeBhvrAttndcRltd>(
					key.ToString(), // EntityTrackingKey
					"MltCdeBhvrAttndcRltd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd();
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
					c.MltCdeBhvrAttndcRltdId = (System.Decimal)reader["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
					c.OriginalMltCdeBhvrAttndcRltdId = c.MltCdeBhvrAttndcRltdId;
					c.BhvrAttndcRltdAr = (System.String)reader["BHVR_ATTNDC_RLTD_AR"];
					c.BhvrAttndcRltdEn = (System.String)reader["BHVR_ATTNDC_RLTD_EN"];
					c.TrnTblRltd = Convert.IsDBNull(reader["TRN_TBL_RLTD"]) ? null : (System.String)reader["TRN_TBL_RLTD"];
					c.BhvrAttndcFlg = Convert.IsDBNull(reader["BHVR_ATTNDC_FLG"]) ? null : (System.Decimal?)reader["BHVR_ATTNDC_FLG"];
					c.DayFlg = Convert.IsDBNull(reader["DAY_FLG"]) ? null : (System.Decimal?)reader["DAY_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd entity)
		{
			if (!reader.Read()) return;
			
			entity.MltCdeBhvrAttndcRltdId = (System.Decimal)reader[((int)MltCdeBhvrAttndcRltdColumn.MltCdeBhvrAttndcRltdId - 1)];
			entity.OriginalMltCdeBhvrAttndcRltdId = (System.Decimal)reader["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
			entity.BhvrAttndcRltdAr = (System.String)reader[((int)MltCdeBhvrAttndcRltdColumn.BhvrAttndcRltdAr - 1)];
			entity.BhvrAttndcRltdEn = (System.String)reader[((int)MltCdeBhvrAttndcRltdColumn.BhvrAttndcRltdEn - 1)];
			entity.TrnTblRltd = (reader.IsDBNull(((int)MltCdeBhvrAttndcRltdColumn.TrnTblRltd - 1)))?null:(System.String)reader[((int)MltCdeBhvrAttndcRltdColumn.TrnTblRltd - 1)];
			entity.BhvrAttndcFlg = (reader.IsDBNull(((int)MltCdeBhvrAttndcRltdColumn.BhvrAttndcFlg - 1)))?null:(System.Decimal?)reader[((int)MltCdeBhvrAttndcRltdColumn.BhvrAttndcFlg - 1)];
			entity.DayFlg = (reader.IsDBNull(((int)MltCdeBhvrAttndcRltdColumn.DayFlg - 1)))?null:(System.Decimal?)reader[((int)MltCdeBhvrAttndcRltdColumn.DayFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltCdeBhvrAttndcRltdId = (System.Decimal)dataRow["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
			entity.OriginalMltCdeBhvrAttndcRltdId = (System.Decimal)dataRow["MLT_CDE_BHVR_ATTNDC_RLTD_ID"];
			entity.BhvrAttndcRltdAr = (System.String)dataRow["BHVR_ATTNDC_RLTD_AR"];
			entity.BhvrAttndcRltdEn = (System.String)dataRow["BHVR_ATTNDC_RLTD_EN"];
			entity.TrnTblRltd = Convert.IsDBNull(dataRow["TRN_TBL_RLTD"]) ? null : (System.String)dataRow["TRN_TBL_RLTD"];
			entity.BhvrAttndcFlg = Convert.IsDBNull(dataRow["BHVR_ATTNDC_FLG"]) ? null : (System.Decimal?)dataRow["BHVR_ATTNDC_FLG"];
			entity.DayFlg = Convert.IsDBNull(dataRow["DAY_FLG"]) ? null : (System.Decimal?)dataRow["DAY_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltCdeBhvrAttndcRltdId methods when available
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByMltCdeBhvrAttndcRltdId(transactionManager, entity.MltCdeBhvrAttndcRltdId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.MltCdeBhvrAttndcRltdIdSource != null)
						{
							child.MltCdeBhvrAttndcRltdId = child.MltCdeBhvrAttndcRltdIdSource.MltCdeBhvrAttndcRltdId;
						}
						else
						{
							child.MltCdeBhvrAttndcRltdId = entity.MltCdeBhvrAttndcRltdId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltCdeBhvrAttndcRltdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltCdeBhvrAttndcRltd</c>
	///</summary>
	public enum MltCdeBhvrAttndcRltdChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MltCdeBhvrAttndcRltd</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
	}
	
	#endregion MltCdeBhvrAttndcRltdChildEntityTypes
	
	#region MltCdeBhvrAttndcRltdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltCdeBhvrAttndcRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeBhvrAttndcRltd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeBhvrAttndcRltdFilterBuilder : SqlFilterBuilder<MltCdeBhvrAttndcRltdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdFilterBuilder class.
		/// </summary>
		public MltCdeBhvrAttndcRltdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeBhvrAttndcRltdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeBhvrAttndcRltdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeBhvrAttndcRltdFilterBuilder
	
	#region MltCdeBhvrAttndcRltdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltCdeBhvrAttndcRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeBhvrAttndcRltd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltCdeBhvrAttndcRltdParameterBuilder : ParameterizedSqlFilterBuilder<MltCdeBhvrAttndcRltdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdParameterBuilder class.
		/// </summary>
		public MltCdeBhvrAttndcRltdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltCdeBhvrAttndcRltdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltCdeBhvrAttndcRltdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltCdeBhvrAttndcRltdParameterBuilder
	
	#region MltCdeBhvrAttndcRltdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltCdeBhvrAttndcRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltCdeBhvrAttndcRltd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltCdeBhvrAttndcRltdSortBuilder : SqlSortBuilder<MltCdeBhvrAttndcRltdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltCdeBhvrAttndcRltdSqlSortBuilder class.
		/// </summary>
		public MltCdeBhvrAttndcRltdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltCdeBhvrAttndcRltdSortBuilder
	
} // end namespace
