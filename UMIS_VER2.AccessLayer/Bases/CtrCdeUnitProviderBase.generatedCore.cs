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
	/// This class is the base class for any <see cref="CtrCdeUnitProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeUnitProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeUnit, UMIS_VER2.BusinessLyer.CtrCdeUnitKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeUnitKey key)
		{
			return Delete(transactionManager, key.CtrCdeUnitId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeUnitId)
		{
			return Delete(null, _ctrCdeUnitId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeUnitId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeUnit Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeUnitKey key, int start, int pageLength)
		{
			return GetByCtrCdeUnitId(transactionManager, key.CtrCdeUnitId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(System.Decimal _ctrCdeUnitId)
		{
			int count = -1;
			return GetByCtrCdeUnitId(null,_ctrCdeUnitId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(System.Decimal _ctrCdeUnitId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeUnitId(null, _ctrCdeUnitId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal _ctrCdeUnitId)
		{
			int count = -1;
			return GetByCtrCdeUnitId(transactionManager, _ctrCdeUnitId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal _ctrCdeUnitId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeUnitId(transactionManager, _ctrCdeUnitId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(System.Decimal _ctrCdeUnitId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeUnitId(null, _ctrCdeUnitId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_UNIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeUnit GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal _ctrCdeUnitId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(System.String _unitAr)
		{
			int count = -1;
			return GetByUnitAr(null,_unitAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(System.String _unitAr, int start, int pageLength)
		{
			int count = -1;
			return GetByUnitAr(null, _unitAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(TransactionManager transactionManager, System.String _unitAr)
		{
			int count = -1;
			return GetByUnitAr(transactionManager, _unitAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(TransactionManager transactionManager, System.String _unitAr, int start, int pageLength)
		{
			int count = -1;
			return GetByUnitAr(transactionManager, _unitAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(System.String _unitAr, int start, int pageLength, out int count)
		{
			return GetByUnitAr(null, _unitAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitAr">بالجرام-بالوحدة-</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitAr(TransactionManager transactionManager, System.String _unitAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="_unitEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(System.String _unitEn)
		{
			int count = -1;
			return GetByUnitEn(null,_unitEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="_unitEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(System.String _unitEn, int start, int pageLength)
		{
			int count = -1;
			return GetByUnitEn(null, _unitEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(TransactionManager transactionManager, System.String _unitEn)
		{
			int count = -1;
			return GetByUnitEn(transactionManager, _unitEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(TransactionManager transactionManager, System.String _unitEn, int start, int pageLength)
		{
			int count = -1;
			return GetByUnitEn(transactionManager, _unitEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="_unitEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(System.String _unitEn, int start, int pageLength, out int count)
		{
			return GetByUnitEn(null, _unitEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_UNIT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_unitEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeUnit GetByUnitEn(TransactionManager transactionManager, System.String _unitEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeUnit&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeUnit&gt;"/></returns>
		public static TList<CtrCdeUnit> Fill(IDataReader reader, TList<CtrCdeUnit> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeUnit c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeUnit")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_UNIT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeUnit>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeUnit",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeUnit();
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
					c.CtrCdeUnitId = (System.Decimal)reader["CTR_CDE_UNIT_ID"];
					c.OriginalCtrCdeUnitId = c.CtrCdeUnitId;
					c.UnitCode = Convert.IsDBNull(reader["UNIT_CODE"]) ? null : (System.String)reader["UNIT_CODE"];
					c.UnitAr = (System.String)reader["UNIT_AR"];
					c.UnitEn = (System.String)reader["UNIT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeUnit entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeUnitId = (System.Decimal)reader[((int)CtrCdeUnitColumn.CtrCdeUnitId - 1)];
			entity.OriginalCtrCdeUnitId = (System.Decimal)reader["CTR_CDE_UNIT_ID"];
			entity.UnitCode = (reader.IsDBNull(((int)CtrCdeUnitColumn.UnitCode - 1)))?null:(System.String)reader[((int)CtrCdeUnitColumn.UnitCode - 1)];
			entity.UnitAr = (System.String)reader[((int)CtrCdeUnitColumn.UnitAr - 1)];
			entity.UnitEn = (System.String)reader[((int)CtrCdeUnitColumn.UnitEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeUnit entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeUnitId = (System.Decimal)dataRow["CTR_CDE_UNIT_ID"];
			entity.OriginalCtrCdeUnitId = (System.Decimal)dataRow["CTR_CDE_UNIT_ID"];
			entity.UnitCode = Convert.IsDBNull(dataRow["UNIT_CODE"]) ? null : (System.String)dataRow["UNIT_CODE"];
			entity.UnitAr = (System.String)dataRow["UNIT_AR"];
			entity.UnitEn = (System.String)dataRow["UNIT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeUnit"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeUnit Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeUnit entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeUnitId methods when available
			
			#region CtrCdeMealItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrCdeMealItemCollection = DataRepository.CtrCdeMealItemProvider.GetByCtrCdeUnitId(transactionManager, entity.CtrCdeUnitId);

				if (deep && entity.CtrCdeMealItemCollection.Count > 0)
				{
					deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrCdeMealItem>) DataRepository.CtrCdeMealItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrCdeMealItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeUnit object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeUnit instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeUnit Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeUnit entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrCdeMealItem>
				if (CanDeepSave(entity.CtrCdeMealItemCollection, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrCdeMealItem child in entity.CtrCdeMealItemCollection)
					{
						if(child.CtrCdeUnitIdSource != null)
						{
							child.CtrCdeUnitId = child.CtrCdeUnitIdSource.CtrCdeUnitId;
						}
						else
						{
							child.CtrCdeUnitId = entity.CtrCdeUnitId;
						}

					}

					if (entity.CtrCdeMealItemCollection.Count > 0 || entity.CtrCdeMealItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrCdeMealItemProvider.Save(transactionManager, entity.CtrCdeMealItemCollection);
						
						deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrCdeMealItem >) DataRepository.CtrCdeMealItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrCdeMealItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeUnitChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeUnit</c>
	///</summary>
	public enum CtrCdeUnitChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeUnit</c> as OneToMany for CtrCdeMealItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrCdeMealItem>))]
		CtrCdeMealItemCollection,
	}
	
	#endregion CtrCdeUnitChildEntityTypes
	
	#region CtrCdeUnitFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeUnitColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeUnit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeUnitFilterBuilder : SqlFilterBuilder<CtrCdeUnitColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitFilterBuilder class.
		/// </summary>
		public CtrCdeUnitFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeUnitFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeUnitFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeUnitFilterBuilder
	
	#region CtrCdeUnitParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeUnitColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeUnit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeUnitParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeUnitColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitParameterBuilder class.
		/// </summary>
		public CtrCdeUnitParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeUnitParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeUnitParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeUnitParameterBuilder
	
	#region CtrCdeUnitSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeUnitColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeUnit"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeUnitSortBuilder : SqlSortBuilder<CtrCdeUnitColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeUnitSqlSortBuilder class.
		/// </summary>
		public CtrCdeUnitSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeUnitSortBuilder
	
} // end namespace
