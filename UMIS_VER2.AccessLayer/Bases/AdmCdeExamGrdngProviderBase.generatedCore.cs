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
	/// This class is the base class for any <see cref="AdmCdeExamGrdngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeExamGrdngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeExamGrdng, UMIS_VER2.BusinessLyer.AdmCdeExamGrdngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeExamGrdngKey key)
		{
			return Delete(transactionManager, key.AdmCdeExamGrdngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeExamGrdngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeExamGrdngId)
		{
			return Delete(null, _admCdeExamGrdngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeExamGrdng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeExamGrdngKey key, int start, int pageLength)
		{
			return GetByAdmCdeExamGrdngId(transactionManager, key.AdmCdeExamGrdngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(null,_admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="_grdngAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(System.String _grdngAr)
		{
			int count = -1;
			return GetByGrdngAr(null,_grdngAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="_grdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(System.String _grdngAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGrdngAr(null, _grdngAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(TransactionManager transactionManager, System.String _grdngAr)
		{
			int count = -1;
			return GetByGrdngAr(transactionManager, _grdngAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(TransactionManager transactionManager, System.String _grdngAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGrdngAr(transactionManager, _grdngAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="_grdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(System.String _grdngAr, int start, int pageLength, out int count)
		{
			return GetByGrdngAr(null, _grdngAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngAr(TransactionManager transactionManager, System.String _grdngAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="_grdngEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(System.String _grdngEn)
		{
			int count = -1;
			return GetByGrdngEn(null,_grdngEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="_grdngEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(System.String _grdngEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGrdngEn(null, _grdngEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(TransactionManager transactionManager, System.String _grdngEn)
		{
			int count = -1;
			return GetByGrdngEn(transactionManager, _grdngEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(TransactionManager transactionManager, System.String _grdngEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGrdngEn(transactionManager, _grdngEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="_grdngEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(System.String _grdngEn, int start, int pageLength, out int count)
		{
			return GetByGrdngEn(null, _grdngEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_EXAM_GRDNG_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_grdngEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeExamGrdng GetByGrdngEn(TransactionManager transactionManager, System.String _grdngEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeExamGrdng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeExamGrdng&gt;"/></returns>
		public static TList<AdmCdeExamGrdng> Fill(IDataReader reader, TList<AdmCdeExamGrdng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeExamGrdng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeExamGrdng")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_EXAM_GRDNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeExamGrdng>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeExamGrdng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeExamGrdng();
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
					c.AdmCdeExamGrdngId = (System.Decimal)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.OriginalAdmCdeExamGrdngId = c.AdmCdeExamGrdngId;
					c.GrdngAr = (System.String)reader["GRDNG_AR"];
					c.GrdngEn = (System.String)reader["GRDNG_EN"];
					c.GradeWeight = Convert.IsDBNull(reader["GRADE_WEIGHT"]) ? null : (System.Decimal?)reader["GRADE_WEIGHT"];
					c.AdmQualFlg = Convert.IsDBNull(reader["ADM_QUAL_FLG"]) ? null : (System.Boolean?)reader["ADM_QUAL_FLG"];
					c.ActiveFlg = Convert.IsDBNull(reader["ACTIVE_FLG"]) ? null : (System.Boolean?)reader["ACTIVE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeExamGrdng entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeExamGrdngId = (System.Decimal)reader[((int)AdmCdeExamGrdngColumn.AdmCdeExamGrdngId - 1)];
			entity.OriginalAdmCdeExamGrdngId = (System.Decimal)reader["ADM_CDE_EXAM_GRDNG_ID"];
			entity.GrdngAr = (System.String)reader[((int)AdmCdeExamGrdngColumn.GrdngAr - 1)];
			entity.GrdngEn = (System.String)reader[((int)AdmCdeExamGrdngColumn.GrdngEn - 1)];
			entity.GradeWeight = (reader.IsDBNull(((int)AdmCdeExamGrdngColumn.GradeWeight - 1)))?null:(System.Decimal?)reader[((int)AdmCdeExamGrdngColumn.GradeWeight - 1)];
			entity.AdmQualFlg = (reader.IsDBNull(((int)AdmCdeExamGrdngColumn.AdmQualFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdeExamGrdngColumn.AdmQualFlg - 1)];
			entity.ActiveFlg = (reader.IsDBNull(((int)AdmCdeExamGrdngColumn.ActiveFlg - 1)))?null:(System.Boolean?)reader[((int)AdmCdeExamGrdngColumn.ActiveFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeExamGrdng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeExamGrdngId = (System.Decimal)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.OriginalAdmCdeExamGrdngId = (System.Decimal)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.GrdngAr = (System.String)dataRow["GRDNG_AR"];
			entity.GrdngEn = (System.String)dataRow["GRDNG_EN"];
			entity.GradeWeight = Convert.IsDBNull(dataRow["GRADE_WEIGHT"]) ? null : (System.Decimal?)dataRow["GRADE_WEIGHT"];
			entity.AdmQualFlg = Convert.IsDBNull(dataRow["ADM_QUAL_FLG"]) ? null : (System.Boolean?)dataRow["ADM_QUAL_FLG"];
			entity.ActiveFlg = Convert.IsDBNull(dataRow["ACTIVE_FLG"]) ? null : (System.Boolean?)dataRow["ACTIVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeExamGrdng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeExamGrdng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeExamGrdng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeExamGrdngId methods when available
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamCourseCollection = DataRepository.AdmPlaceExamCourseProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.AdmPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamCourse>) DataRepository.AdmPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeQualGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQualGroup>|EdCodeQualGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualGroupCollection = DataRepository.EdCodeQualGroupProvider.GetByAdmCdeExamMinGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.EdCodeQualGroupCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualGroup>) DataRepository.EdCodeQualGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmExamGrdngPkgDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmExamGrdngPkgDtlCollection = DataRepository.AdmExamGrdngPkgDtlProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.AdmExamGrdngPkgDtlCollection.Count > 0)
				{
					deepHandles.Add("AdmExamGrdngPkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmExamGrdngPkgDtl>) DataRepository.AdmExamGrdngPkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmExamGrdngPkgDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.AdmAppPlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlacementExam>) DataRepository.AdmAppPlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualSubjectCollection = DataRepository.EdStudQualSubjectProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.EdStudQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualSubject>) DataRepository.EdStudQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdePlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdePlacementExamCollection = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdeExamMinGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.AdmCdePlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeExamGrdng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeExamGrdng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeExamGrdng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeExamGrdng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamCourse>
				if (CanDeepSave(entity.AdmPlaceExamCourseCollection, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamCourse child in entity.AdmPlaceExamCourseCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.AdmPlaceExamCourseCollection.Count > 0 || entity.AdmPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamCourseProvider.Save(transactionManager, entity.AdmPlaceExamCourseCollection);
						
						deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamCourse >) DataRepository.AdmPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeQualGroup>
				if (CanDeepSave(entity.EdCodeQualGroupCollection, "List<EdCodeQualGroup>|EdCodeQualGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualGroup child in entity.EdCodeQualGroupCollection)
					{
						if(child.AdmCdeExamMinGrdngIdSource != null)
						{
							child.AdmCdeExamMinGrdngId = child.AdmCdeExamMinGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamMinGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.EdCodeQualGroupCollection.Count > 0 || entity.EdCodeQualGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualGroupProvider.Save(transactionManager, entity.EdCodeQualGroupCollection);
						
						deepHandles.Add("EdCodeQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQualGroup >) DataRepository.EdCodeQualGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmExamGrdngPkgDtl>
				if (CanDeepSave(entity.AdmExamGrdngPkgDtlCollection, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmExamGrdngPkgDtl child in entity.AdmExamGrdngPkgDtlCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.AdmExamGrdngPkgDtlCollection.Count > 0 || entity.AdmExamGrdngPkgDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmExamGrdngPkgDtlProvider.Save(transactionManager, entity.AdmExamGrdngPkgDtlCollection);
						
						deepHandles.Add("AdmExamGrdngPkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmExamGrdngPkgDtl >) DataRepository.AdmExamGrdngPkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AdmExamGrdngPkgDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPlacementExam>
				if (CanDeepSave(entity.AdmAppPlacementExamCollection, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlacementExam child in entity.AdmAppPlacementExamCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.AdmAppPlacementExamCollection.Count > 0 || entity.AdmAppPlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPlacementExamProvider.Save(transactionManager, entity.AdmAppPlacementExamCollection);
						
						deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPlacementExam >) DataRepository.AdmAppPlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualSubject>
				if (CanDeepSave(entity.EdStudQualSubjectCollection, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualSubject child in entity.EdStudQualSubjectCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.EdStudQualSubjectCollection.Count > 0 || entity.EdStudQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualSubjectProvider.Save(transactionManager, entity.EdStudQualSubjectCollection);
						
						deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualSubject >) DataRepository.EdStudQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualSubjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollection, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollection)
					{
						if(child.AdmCdeExamMinGrdngIdSource != null)
						{
							child.AdmCdeExamMinGrdngId = child.AdmCdeExamMinGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamMinGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.AdmCdePlacementExamCollection.Count > 0 || entity.AdmCdePlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamCollection);
						
						deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdePlacementExam >) DataRepository.AdmCdePlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.AdmCdeExamGrdngIdSource != null)
						{
							child.AdmCdeExamGrdngId = child.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
						}
						else
						{
							child.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeExamGrdngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeExamGrdng</c>
	///</summary>
	public enum AdmCdeExamGrdngChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for AdmPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamCourse>))]
		AdmPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for EdCodeQualGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualGroup>))]
		EdCodeQualGroupCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for AdmExamGrdngPkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmExamGrdngPkgDtl>))]
		AdmExamGrdngPkgDtlCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for EdStudQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualSubject>))]
		EdStudQualSubjectCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollection,
		///<summary>
		/// Collection of <c>AdmCdeExamGrdng</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion AdmCdeExamGrdngChildEntityTypes
	
	#region AdmCdeExamGrdngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeExamGrdngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeExamGrdng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeExamGrdngFilterBuilder : SqlFilterBuilder<AdmCdeExamGrdngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngFilterBuilder class.
		/// </summary>
		public AdmCdeExamGrdngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeExamGrdngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeExamGrdngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeExamGrdngFilterBuilder
	
	#region AdmCdeExamGrdngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeExamGrdngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeExamGrdng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeExamGrdngParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeExamGrdngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngParameterBuilder class.
		/// </summary>
		public AdmCdeExamGrdngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeExamGrdngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeExamGrdngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeExamGrdngParameterBuilder
	
	#region AdmCdeExamGrdngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeExamGrdngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeExamGrdng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeExamGrdngSortBuilder : SqlSortBuilder<AdmCdeExamGrdngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeExamGrdngSqlSortBuilder class.
		/// </summary>
		public AdmCdeExamGrdngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeExamGrdngSortBuilder
	
} // end namespace
