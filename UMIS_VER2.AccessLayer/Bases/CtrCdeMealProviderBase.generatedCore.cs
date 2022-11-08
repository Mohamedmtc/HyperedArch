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
	/// This class is the base class for any <see cref="CtrCdeMealProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeMealProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeMeal, UMIS_VER2.BusinessLyer.CtrCdeMealKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealKey key)
		{
			return Delete(transactionManager, key.CtrCdeMealId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeMealId)
		{
			return Delete(null, _ctrCdeMealId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeMealId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeMeal Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealKey key, int start, int pageLength)
		{
			return GetByCtrCdeMealId(transactionManager, key.CtrCdeMealId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(null,_ctrCdeMealId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeMeal GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(System.String _mealAr)
		{
			int count = -1;
			return GetByMealAr(null,_mealAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(System.String _mealAr, int start, int pageLength)
		{
			int count = -1;
			return GetByMealAr(null, _mealAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(TransactionManager transactionManager, System.String _mealAr)
		{
			int count = -1;
			return GetByMealAr(transactionManager, _mealAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(TransactionManager transactionManager, System.String _mealAr, int start, int pageLength)
		{
			int count = -1;
			return GetByMealAr(transactionManager, _mealAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(System.String _mealAr, int start, int pageLength, out int count)
		{
			return GetByMealAr(null, _mealAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealAr">وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealAr(TransactionManager transactionManager, System.String _mealAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="_mealEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(System.String _mealEn)
		{
			int count = -1;
			return GetByMealEn(null,_mealEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="_mealEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(System.String _mealEn, int start, int pageLength)
		{
			int count = -1;
			return GetByMealEn(null, _mealEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(TransactionManager transactionManager, System.String _mealEn)
		{
			int count = -1;
			return GetByMealEn(transactionManager, _mealEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(TransactionManager transactionManager, System.String _mealEn, int start, int pageLength)
		{
			int count = -1;
			return GetByMealEn(transactionManager, _mealEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="_mealEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(System.String _mealEn, int start, int pageLength, out int count)
		{
			return GetByMealEn(null, _mealEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_MEAL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mealEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeMeal GetByMealEn(TransactionManager transactionManager, System.String _mealEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeMeal&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeMeal&gt;"/></returns>
		public static TList<CtrCdeMeal> Fill(IDataReader reader, TList<CtrCdeMeal> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeMeal c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeMeal")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_MEAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeMeal>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeMeal",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeMeal();
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
					c.CtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
					c.OriginalCtrCdeMealId = c.CtrCdeMealId;
					c.MealAr = (System.String)reader["MEAL_AR"];
					c.MealEn = (System.String)reader["MEAL_EN"];
					c.MaxCal = Convert.IsDBNull(reader["MAX_CAL"]) ? null : (System.Decimal?)reader["MAX_CAL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeMeal entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeMealId = (System.Decimal)reader[((int)CtrCdeMealColumn.CtrCdeMealId - 1)];
			entity.OriginalCtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
			entity.MealAr = (System.String)reader[((int)CtrCdeMealColumn.MealAr - 1)];
			entity.MealEn = (System.String)reader[((int)CtrCdeMealColumn.MealEn - 1)];
			entity.MaxCal = (reader.IsDBNull(((int)CtrCdeMealColumn.MaxCal - 1)))?null:(System.Decimal?)reader[((int)CtrCdeMealColumn.MaxCal - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeMeal entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
			entity.OriginalCtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
			entity.MealAr = (System.String)dataRow["MEAL_AR"];
			entity.MealEn = (System.String)dataRow["MEAL_EN"];
			entity.MaxCal = Convert.IsDBNull(dataRow["MAX_CAL"]) ? null : (System.Decimal?)dataRow["MAX_CAL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMeal"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeMeal Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMeal entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeMealId methods when available
			
			#region CtrMenuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenu>|CtrMenuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuCollection = DataRepository.CtrMenuProvider.GetByCtrCdeMealId(transactionManager, entity.CtrCdeMealId);

				if (deep && entity.CtrMenuCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenu>) DataRepository.CtrMenuProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMealItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMealItem>|CtrMealItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMealItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMealItemCollection = DataRepository.CtrMealItemProvider.GetByCtrCdeMealId(transactionManager, entity.CtrCdeMealId);

				if (deep && entity.CtrMealItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMealItem>) DataRepository.CtrMealItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMealItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMenuActCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuAct>|CtrMenuActCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuActCollection = DataRepository.CtrMenuActProvider.GetByCtrCdeMealId(transactionManager, entity.CtrCdeMealId);

				if (deep && entity.CtrMenuActCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuAct>) DataRepository.CtrMenuActProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuActCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeMeal object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeMeal instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeMeal Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMeal entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrMenu>
				if (CanDeepSave(entity.CtrMenuCollection, "List<CtrMenu>|CtrMenuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenu child in entity.CtrMenuCollection)
					{
						if(child.CtrCdeMealIdSource != null)
						{
							child.CtrCdeMealId = child.CtrCdeMealIdSource.CtrCdeMealId;
						}
						else
						{
							child.CtrCdeMealId = entity.CtrCdeMealId;
						}

					}

					if (entity.CtrMenuCollection.Count > 0 || entity.CtrMenuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuProvider.Save(transactionManager, entity.CtrMenuCollection);
						
						deepHandles.Add("CtrMenuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenu >) DataRepository.CtrMenuProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMealItem>
				if (CanDeepSave(entity.CtrMealItemCollection, "List<CtrMealItem>|CtrMealItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMealItem child in entity.CtrMealItemCollection)
					{
						if(child.CtrCdeMealIdSource != null)
						{
							child.CtrCdeMealId = child.CtrCdeMealIdSource.CtrCdeMealId;
						}
						else
						{
							child.CtrCdeMealId = entity.CtrCdeMealId;
						}

					}

					if (entity.CtrMealItemCollection.Count > 0 || entity.CtrMealItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMealItemProvider.Save(transactionManager, entity.CtrMealItemCollection);
						
						deepHandles.Add("CtrMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMealItem >) DataRepository.CtrMealItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMealItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMenuAct>
				if (CanDeepSave(entity.CtrMenuActCollection, "List<CtrMenuAct>|CtrMenuActCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuAct child in entity.CtrMenuActCollection)
					{
						if(child.CtrCdeMealIdSource != null)
						{
							child.CtrCdeMealId = child.CtrCdeMealIdSource.CtrCdeMealId;
						}
						else
						{
							child.CtrCdeMealId = entity.CtrCdeMealId;
						}

					}

					if (entity.CtrMenuActCollection.Count > 0 || entity.CtrMenuActCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuActProvider.Save(transactionManager, entity.CtrMenuActCollection);
						
						deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuAct >) DataRepository.CtrMenuActProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuActCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeMealChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeMeal</c>
	///</summary>
	public enum CtrCdeMealChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeMeal</c> as OneToMany for CtrMenuCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenu>))]
		CtrMenuCollection,
		///<summary>
		/// Collection of <c>CtrCdeMeal</c> as OneToMany for CtrMealItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMealItem>))]
		CtrMealItemCollection,
		///<summary>
		/// Collection of <c>CtrCdeMeal</c> as OneToMany for CtrMenuActCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuAct>))]
		CtrMenuActCollection,
	}
	
	#endregion CtrCdeMealChildEntityTypes
	
	#region CtrCdeMealFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeMealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMeal"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeMealFilterBuilder : SqlFilterBuilder<CtrCdeMealColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealFilterBuilder class.
		/// </summary>
		public CtrCdeMealFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeMealFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeMealFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeMealFilterBuilder
	
	#region CtrCdeMealParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeMealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMeal"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeMealParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeMealColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealParameterBuilder class.
		/// </summary>
		public CtrCdeMealParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeMealParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeMealParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeMealParameterBuilder
	
	#region CtrCdeMealSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeMealColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMeal"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeMealSortBuilder : SqlSortBuilder<CtrCdeMealColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealSqlSortBuilder class.
		/// </summary>
		public CtrCdeMealSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeMealSortBuilder
	
} // end namespace
