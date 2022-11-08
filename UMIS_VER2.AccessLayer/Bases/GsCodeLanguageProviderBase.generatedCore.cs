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
	/// This class is the base class for any <see cref="GsCodeLanguageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeLanguageProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeLanguage, UMIS_VER2.BusinessLyer.GsCodeLanguageKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeLanguageKey key)
		{
			return Delete(transactionManager, key.GsCodeLanguageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeLanguageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeLanguageId)
		{
			return Delete(null, _gsCodeLanguageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeLanguage Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeLanguageKey key, int start, int pageLength)
		{
			return GetByGsCodeLanguageId(transactionManager, key.GsCodeLanguageId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_LANGUAGE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeLanguage GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(null,_gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength, out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_LANGUAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeLanguage GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeLanguage&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeLanguage&gt;"/></returns>
		public static TList<GsCodeLanguage> Fill(IDataReader reader, TList<GsCodeLanguage> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeLanguage c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeLanguage")
					.Append("|").Append((System.Decimal)reader["GS_CODE_LANGUAGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeLanguage>(
					key.ToString(), // EntityTrackingKey
					"GsCodeLanguage",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeLanguage();
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
					c.GsCodeLanguageId = (System.Decimal)reader["GS_CODE_LANGUAGE_ID"];
					c.OriginalGsCodeLanguageId = c.GsCodeLanguageId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.LangCode = Convert.IsDBNull(reader["LANG_CODE"]) ? null : (System.String)reader["LANG_CODE"];
					c.IsLangLocal = (System.Decimal)reader["IS_LANG_LOCAL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeLanguage entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeLanguageId = (System.Decimal)reader[((int)GsCodeLanguageColumn.GsCodeLanguageId - 1)];
			entity.OriginalGsCodeLanguageId = (System.Decimal)reader["GS_CODE_LANGUAGE_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)GsCodeLanguageColumn.DescrAr - 1)))?null:(System.String)reader[((int)GsCodeLanguageColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCodeLanguageColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCodeLanguageColumn.DescrEn - 1)];
			entity.LangCode = (reader.IsDBNull(((int)GsCodeLanguageColumn.LangCode - 1)))?null:(System.String)reader[((int)GsCodeLanguageColumn.LangCode - 1)];
			entity.IsLangLocal = (System.Decimal)reader[((int)GsCodeLanguageColumn.IsLangLocal - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeLanguage entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeLanguageId = (System.Decimal)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.OriginalGsCodeLanguageId = (System.Decimal)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.LangCode = Convert.IsDBNull(dataRow["LANG_CODE"]) ? null : (System.String)dataRow["LANG_CODE"];
			entity.IsLangLocal = (System.Decimal)dataRow["IS_LANG_LOCAL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeLanguage"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeLanguage Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeLanguage entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeLanguageId methods when available
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserMobTokenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMobToken>|SvUserMobTokenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMobTokenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMobTokenCollection = DataRepository.SvUserMobTokenProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.SvUserMobTokenCollection.Count > 0)
				{
					deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMobToken>) DataRepository.SvUserMobTokenProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMobTokenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlCollection = DataRepository.ScScheduleDtlProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.ScScheduleDtlCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtl>) DataRepository.ScScheduleDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollection = DataRepository.AdmApplicantProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.AdmApplicantCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppLanguagesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesCollection = DataRepository.AdmAppLanguagesProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

				if (deep && entity.AdmAppLanguagesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguages>) DataRepository.AdmAppLanguagesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeLanguage object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeLanguage instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeLanguage Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeLanguage entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.EdStudCollection.Count > 0 || entity.EdStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollection);
						
						deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserMobToken>
				if (CanDeepSave(entity.SvUserMobTokenCollection, "List<SvUserMobToken>|SvUserMobTokenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMobToken child in entity.SvUserMobTokenCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.SvUserMobTokenCollection.Count > 0 || entity.SvUserMobTokenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMobTokenProvider.Save(transactionManager, entity.SvUserMobTokenCollection);
						
						deepHandles.Add("SvUserMobTokenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMobToken >) DataRepository.SvUserMobTokenProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMobTokenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtl>
				if (CanDeepSave(entity.ScScheduleDtlCollection, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtl child in entity.ScScheduleDtlCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.ScScheduleDtlCollection.Count > 0 || entity.ScScheduleDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlCollection);
						
						deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtl >) DataRepository.ScScheduleDtlProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.EntityMainCollection.Count > 0 || entity.EntityMainCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntityMainProvider.Save(transactionManager, entity.EntityMainCollection);
						
						deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntityMain >) DataRepository.EntityMainProvider.DeepSave,
							new object[] { transactionManager, entity.EntityMainCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollection, "List<AdmApplicant>|AdmApplicantCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.AdmApplicantCollection.Count > 0 || entity.AdmApplicantCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollection);
						
						deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppLanguages>
				if (CanDeepSave(entity.AdmAppLanguagesCollection, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLanguages child in entity.AdmAppLanguagesCollection)
					{
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
						}

					}

					if (entity.AdmAppLanguagesCollection.Count > 0 || entity.AdmAppLanguagesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLanguagesProvider.Save(transactionManager, entity.AdmAppLanguagesCollection);
						
						deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLanguages >) DataRepository.AdmAppLanguagesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLanguagesCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodeLanguageIdSource != null)
						{
							child.GsCodeLanguageId = child.GsCodeLanguageIdSource.GsCodeLanguageId;
						}
						else
						{
							child.GsCodeLanguageId = entity.GsCodeLanguageId;
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
	
	#region GsCodeLanguageChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeLanguage</c>
	///</summary>
	public enum GsCodeLanguageChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for SvUserMobTokenCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMobToken>))]
		SvUserMobTokenCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for ScScheduleDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtl>))]
		ScScheduleDtlCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for AdmAppLanguagesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguages>))]
		AdmAppLanguagesCollection,
		///<summary>
		/// Collection of <c>GsCodeLanguage</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion GsCodeLanguageChildEntityTypes
	
	#region GsCodeLanguageFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeLanguageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeLanguage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeLanguageFilterBuilder : SqlFilterBuilder<GsCodeLanguageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageFilterBuilder class.
		/// </summary>
		public GsCodeLanguageFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeLanguageFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeLanguageFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeLanguageFilterBuilder
	
	#region GsCodeLanguageParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeLanguageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeLanguage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeLanguageParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeLanguageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageParameterBuilder class.
		/// </summary>
		public GsCodeLanguageParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeLanguageParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeLanguageParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeLanguageParameterBuilder
	
	#region GsCodeLanguageSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeLanguageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeLanguage"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeLanguageSortBuilder : SqlSortBuilder<GsCodeLanguageColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeLanguageSqlSortBuilder class.
		/// </summary>
		public GsCodeLanguageSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeLanguageSortBuilder
	
} // end namespace
