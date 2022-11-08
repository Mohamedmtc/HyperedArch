﻿#region Using directives

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
	/// This class is the base class for any <see cref="SvCdeCompHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeCompHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeCompH, UMIS_VER2.BusinessLyer.SvCdeCompHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompHKey key)
		{
			return Delete(transactionManager, key.SvCdeCompHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeCompHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCdeCompHId)
		{
			return Delete(null, _svCdeCompHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCdeCompHId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeCompH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompHKey key, int start, int pageLength)
		{
			return GetBySvCdeCompHId(transactionManager, key.SvCdeCompHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(System.Decimal _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(null,_svCdeCompHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(System.Decimal _svCdeCompHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(System.Decimal _svCdeCompHId, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_COMP_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompH GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal _svCdeCompHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_COMP_H_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeCompH GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeCompH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeCompH&gt;"/></returns>
		public static TList<SvCdeCompH> Fill(IDataReader reader, TList<SvCdeCompH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeCompH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeCompH")
					.Append("|").Append((System.Decimal)reader["SV_CDE_COMP_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeCompH>(
					key.ToString(), // EntityTrackingKey
					"SvCdeCompH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeCompH();
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
					c.SvCdeCompHId = (System.Decimal)reader["SV_CDE_COMP_H_ID"];
					c.OriginalSvCdeCompHId = c.SvCdeCompHId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeCompH entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeCompHId = (System.Decimal)reader[((int)SvCdeCompHColumn.SvCdeCompHId - 1)];
			entity.OriginalSvCdeCompHId = (System.Decimal)reader["SV_CDE_COMP_H_ID"];
			entity.DescrAr = (System.String)reader[((int)SvCdeCompHColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)SvCdeCompHColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeCompH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeCompHId = (System.Decimal)dataRow["SV_CDE_COMP_H_ID"];
			entity.OriginalSvCdeCompHId = (System.Decimal)dataRow["SV_CDE_COMP_H_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeCompH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeCompHId methods when available
			
			#region SvCdeCompDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCdeCompD>|SvCdeCompDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCdeCompDCollection = DataRepository.SvCdeCompDProvider.GetBySvCdeCompHId(transactionManager, entity.SvCdeCompHId);

				if (deep && entity.SvCdeCompDCollection.Count > 0)
				{
					deepHandles.Add("SvCdeCompDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCdeCompD>) DataRepository.SvCdeCompDProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCdeCompDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetBySvCdeCompHId(transactionManager, entity.SvCdeCompHId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeCompH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeCompH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeCompH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeCompH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvCdeCompD>
				if (CanDeepSave(entity.SvCdeCompDCollection, "List<SvCdeCompD>|SvCdeCompDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCdeCompD child in entity.SvCdeCompDCollection)
					{
						if(child.SvCdeCompHIdSource != null)
						{
							child.SvCdeCompHId = child.SvCdeCompHIdSource.SvCdeCompHId;
						}
						else
						{
							child.SvCdeCompHId = entity.SvCdeCompHId;
						}

					}

					if (entity.SvCdeCompDCollection.Count > 0 || entity.SvCdeCompDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCdeCompDProvider.Save(transactionManager, entity.SvCdeCompDCollection);
						
						deepHandles.Add("SvCdeCompDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCdeCompD >) DataRepository.SvCdeCompDProvider.DeepSave,
							new object[] { transactionManager, entity.SvCdeCompDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.SvCdeCompHIdSource != null)
						{
							child.SvCdeCompHId = child.SvCdeCompHIdSource.SvCdeCompHId;
						}
						else
						{
							child.SvCdeCompHId = entity.SvCdeCompHId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeCompHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeCompH</c>
	///</summary>
	public enum SvCdeCompHChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeCompH</c> as OneToMany for SvCdeCompDCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCdeCompD>))]
		SvCdeCompDCollection,
		///<summary>
		/// Collection of <c>SvCdeCompH</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
	}
	
	#endregion SvCdeCompHChildEntityTypes
	
	#region SvCdeCompHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeCompHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompHFilterBuilder : SqlFilterBuilder<SvCdeCompHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHFilterBuilder class.
		/// </summary>
		public SvCdeCompHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompHFilterBuilder
	
	#region SvCdeCompHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeCompHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeCompHParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeCompHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHParameterBuilder class.
		/// </summary>
		public SvCdeCompHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeCompHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeCompHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeCompHParameterBuilder
	
	#region SvCdeCompHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeCompHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeCompH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeCompHSortBuilder : SqlSortBuilder<SvCdeCompHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeCompHSqlSortBuilder class.
		/// </summary>
		public SvCdeCompHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeCompHSortBuilder
	
} // end namespace