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
	/// This class is the base class for any <see cref="MdiCdeDiseaseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeDiseaseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeDisease, UMIS_VER2.BusinessLyer.MdiCdeDiseaseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeDiseaseKey key)
		{
			return Delete(transactionManager, key.MdiCdeDiseaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeDiseaseId)
		{
			return Delete(null, _mdiCdeDiseaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId);		
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeDisease Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeDiseaseKey key, int start, int pageLength)
		{
			return GetByMdiCdeDiseaseId(transactionManager, key.MdiCdeDiseaseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(null,_mdiCdeDiseaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(null, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(transactionManager, _mdiCdeDiseaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(transactionManager, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeDiseaseId(null, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_DISEASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId">بيانات الامراض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeDisease GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(System.String _diseaseAr)
		{
			int count = -1;
			return GetByDiseaseAr(null,_diseaseAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(System.String _diseaseAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDiseaseAr(null, _diseaseAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(TransactionManager transactionManager, System.String _diseaseAr)
		{
			int count = -1;
			return GetByDiseaseAr(transactionManager, _diseaseAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(TransactionManager transactionManager, System.String _diseaseAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDiseaseAr(transactionManager, _diseaseAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(System.String _diseaseAr, int start, int pageLength, out int count)
		{
			return GetByDiseaseAr(null, _diseaseAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseAr">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseAr(TransactionManager transactionManager, System.String _diseaseAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(System.String _diseaseEn)
		{
			int count = -1;
			return GetByDiseaseEn(null,_diseaseEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(System.String _diseaseEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDiseaseEn(null, _diseaseEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(TransactionManager transactionManager, System.String _diseaseEn)
		{
			int count = -1;
			return GetByDiseaseEn(transactionManager, _diseaseEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(TransactionManager transactionManager, System.String _diseaseEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDiseaseEn(transactionManager, _diseaseEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(System.String _diseaseEn, int start, int pageLength, out int count)
		{
			return GetByDiseaseEn(null, _diseaseEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_DISEASE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_diseaseEn">اسم المرض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeDisease GetByDiseaseEn(TransactionManager transactionManager, System.String _diseaseEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeDisease&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeDisease&gt;"/></returns>
		public static TList<MdiCdeDisease> Fill(IDataReader reader, TList<MdiCdeDisease> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeDisease c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeDisease")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_DISEASE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeDisease>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeDisease",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeDisease();
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
					c.MdiCdeDiseaseId = (System.Decimal)reader["MDI_CDE_DISEASE_ID"];
					c.OriginalMdiCdeDiseaseId = c.MdiCdeDiseaseId;
					c.DiseaseCode = (System.String)reader["DISEASE_CODE"];
					c.DiseaseAr = (System.String)reader["DISEASE_AR"];
					c.DiseaseEn = (System.String)reader["DISEASE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeDisease entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeDiseaseId = (System.Decimal)reader[((int)MdiCdeDiseaseColumn.MdiCdeDiseaseId - 1)];
			entity.OriginalMdiCdeDiseaseId = (System.Decimal)reader["MDI_CDE_DISEASE_ID"];
			entity.DiseaseCode = (System.String)reader[((int)MdiCdeDiseaseColumn.DiseaseCode - 1)];
			entity.DiseaseAr = (System.String)reader[((int)MdiCdeDiseaseColumn.DiseaseAr - 1)];
			entity.DiseaseEn = (System.String)reader[((int)MdiCdeDiseaseColumn.DiseaseEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeDisease entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeDiseaseId = (System.Decimal)dataRow["MDI_CDE_DISEASE_ID"];
			entity.OriginalMdiCdeDiseaseId = (System.Decimal)dataRow["MDI_CDE_DISEASE_ID"];
			entity.DiseaseCode = (System.String)dataRow["DISEASE_CODE"];
			entity.DiseaseAr = (System.String)dataRow["DISEASE_AR"];
			entity.DiseaseEn = (System.String)dataRow["DISEASE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeDisease"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeDisease Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeDisease entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeDiseaseId methods when available
			
			#region MdiStudFamHstryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudFamHstryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudFamHstryCollection = DataRepository.MdiStudFamHstryProvider.GetByMdiCdeDiseaseId(transactionManager, entity.MdiCdeDiseaseId);

				if (deep && entity.MdiStudFamHstryCollection.Count > 0)
				{
					deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudFamHstry>) DataRepository.MdiStudFamHstryProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudFamHstryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeDisease object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeDisease instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeDisease Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeDisease entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MdiStudFamHstry>
				if (CanDeepSave(entity.MdiStudFamHstryCollection, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudFamHstry child in entity.MdiStudFamHstryCollection)
					{
						if(child.MdiCdeDiseaseIdSource != null)
						{
							child.MdiCdeDiseaseId = child.MdiCdeDiseaseIdSource.MdiCdeDiseaseId;
						}
						else
						{
							child.MdiCdeDiseaseId = entity.MdiCdeDiseaseId;
						}

					}

					if (entity.MdiStudFamHstryCollection.Count > 0 || entity.MdiStudFamHstryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudFamHstryProvider.Save(transactionManager, entity.MdiStudFamHstryCollection);
						
						deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudFamHstry >) DataRepository.MdiStudFamHstryProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudFamHstryCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeDiseaseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeDisease</c>
	///</summary>
	public enum MdiCdeDiseaseChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeDisease</c> as OneToMany for MdiStudFamHstryCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudFamHstry>))]
		MdiStudFamHstryCollection,
	}
	
	#endregion MdiCdeDiseaseChildEntityTypes
	
	#region MdiCdeDiseaseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeDiseaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeDisease"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeDiseaseFilterBuilder : SqlFilterBuilder<MdiCdeDiseaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseFilterBuilder class.
		/// </summary>
		public MdiCdeDiseaseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeDiseaseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeDiseaseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeDiseaseFilterBuilder
	
	#region MdiCdeDiseaseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeDiseaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeDisease"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeDiseaseParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeDiseaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseParameterBuilder class.
		/// </summary>
		public MdiCdeDiseaseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeDiseaseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeDiseaseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeDiseaseParameterBuilder
	
	#region MdiCdeDiseaseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeDiseaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeDisease"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeDiseaseSortBuilder : SqlSortBuilder<MdiCdeDiseaseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeDiseaseSqlSortBuilder class.
		/// </summary>
		public MdiCdeDiseaseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeDiseaseSortBuilder
	
} // end namespace
