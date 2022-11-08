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
	/// This class is the base class for any <see cref="GsCodeGenderProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeGenderProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeGender, UMIS_VER2.BusinessLyer.GsCodeGenderKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeGenderKey key)
		{
			return Delete(transactionManager, key.GsCodeGenderId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeGenderId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeGenderId)
		{
			return Delete(null, _gsCodeGenderId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeGenderId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeGender Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeGenderKey key, int start, int pageLength)
		{
			return GetByGsCodeGenderId(transactionManager, key.GsCodeGenderId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(System.Decimal _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(null,_gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(System.Decimal _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(System.Decimal _gsCodeGenderId, int start, int pageLength, out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_GENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeGender GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal _gsCodeGenderId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeGender&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeGender&gt;"/></returns>
		public static TList<GsCodeGender> Fill(IDataReader reader, TList<GsCodeGender> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeGender c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeGender")
					.Append("|").Append((System.Decimal)reader["GS_CODE_GENDER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeGender>(
					key.ToString(), // EntityTrackingKey
					"GsCodeGender",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeGender();
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
					c.GsCodeGenderId = (System.Decimal)reader["GS_CODE_GENDER_ID"];
					c.OriginalGsCodeGenderId = c.GsCodeGenderId;
					c.GenderDescrAr = (System.String)reader["GENDER_DESCR_AR"];
					c.GenderDescrEn = Convert.IsDBNull(reader["GENDER_DESCR_EN"]) ? null : (System.String)reader["GENDER_DESCR_EN"];
					c.GenderCode = Convert.IsDBNull(reader["GENDER_CODE"]) ? null : (System.String)reader["GENDER_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeGender entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeGenderId = (System.Decimal)reader[((int)GsCodeGenderColumn.GsCodeGenderId - 1)];
			entity.OriginalGsCodeGenderId = (System.Decimal)reader["GS_CODE_GENDER_ID"];
			entity.GenderDescrAr = (System.String)reader[((int)GsCodeGenderColumn.GenderDescrAr - 1)];
			entity.GenderDescrEn = (reader.IsDBNull(((int)GsCodeGenderColumn.GenderDescrEn - 1)))?null:(System.String)reader[((int)GsCodeGenderColumn.GenderDescrEn - 1)];
			entity.GenderCode = (reader.IsDBNull(((int)GsCodeGenderColumn.GenderCode - 1)))?null:(System.String)reader[((int)GsCodeGenderColumn.GenderCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeGender entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeGenderId = (System.Decimal)dataRow["GS_CODE_GENDER_ID"];
			entity.OriginalGsCodeGenderId = (System.Decimal)dataRow["GS_CODE_GENDER_ID"];
			entity.GenderDescrAr = (System.String)dataRow["GENDER_DESCR_AR"];
			entity.GenderDescrEn = Convert.IsDBNull(dataRow["GENDER_DESCR_EN"]) ? null : (System.String)dataRow["GENDER_DESCR_EN"];
			entity.GenderCode = Convert.IsDBNull(dataRow["GENDER_CODE"]) ? null : (System.String)dataRow["GENDER_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeGender"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeGender Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeGender entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeGenderId methods when available
			
			#region PgExtMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgExtMember>|PgExtMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScScheduleDtlCollection = DataRepository.ScScheduleDtlProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.ScScheduleDtlCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtl>) DataRepository.ScScheduleDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomCdePermtTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomCdePermtType>|AccomCdePermtTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdePermtTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomCdePermtTypeCollection = DataRepository.AccomCdePermtTypeProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.AccomCdePermtTypeCollection.Count > 0)
				{
					deepHandles.Add("AccomCdePermtTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomCdePermtType>) DataRepository.AccomCdePermtTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomCdePermtTypeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccnt>|SeUserAccntCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntCollection = DataRepository.SeUserAccntProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.SeUserAccntCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccnt>) DataRepository.SeUserAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeDoc>|SaCodeDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeDocCollection = DataRepository.SaCodeDocProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.SaCodeDocCollection.Count > 0)
				{
					deepHandles.Add("SaCodeDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeDoc>) DataRepository.SaCodeDocProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRelativeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRelative>|SaRelativeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRelativeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRelativeCollection = DataRepository.SaRelativeProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.SaRelativeCollection.Count > 0)
				{
					deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRelative>) DataRepository.SaRelativeProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRelativeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAllowanceRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAllowanceRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeClrncItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeClrncItemCollection = DataRepository.GsCdeClrncItemProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.GsCdeClrncItemCollection.Count > 0)
				{
					deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeClrncItem>) DataRepository.GsCdeClrncItemProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeClrncItemCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmApplicantCollection = DataRepository.AdmApplicantProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.AdmApplicantCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamDatetimeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamDatetimeCollection = DataRepository.AdmPlaceExamDatetimeProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.AdmPlaceExamDatetimeCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamDatetime>) DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomBuildingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomBuilding>|AccomBuildingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBuildingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomBuildingCollection = DataRepository.AccomBuildingProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.AccomBuildingCollection.Count > 0)
				{
					deepHandles.Add("AccomBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomBuilding>) DataRepository.AccomBuildingProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomBuildingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByGsCodeGenderId(transactionManager, entity.GsCodeGenderId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeGender object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeGender instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeGender Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeGender entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgExtMember>
				if (CanDeepSave(entity.PgExtMemberCollection, "List<PgExtMember>|PgExtMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgExtMember child in entity.PgExtMemberCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.PgExtMemberCollection.Count > 0 || entity.PgExtMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberCollection);
						
						deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgExtMember >) DataRepository.PgExtMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgExtMemberCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
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
				
	
			#region List<AccomCdePermtType>
				if (CanDeepSave(entity.AccomCdePermtTypeCollection, "List<AccomCdePermtType>|AccomCdePermtTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomCdePermtType child in entity.AccomCdePermtTypeCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.AccomCdePermtTypeCollection.Count > 0 || entity.AccomCdePermtTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomCdePermtTypeProvider.Save(transactionManager, entity.AccomCdePermtTypeCollection);
						
						deepHandles.Add("AccomCdePermtTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomCdePermtType >) DataRepository.AccomCdePermtTypeProvider.DeepSave,
							new object[] { transactionManager, entity.AccomCdePermtTypeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccnt>
				if (CanDeepSave(entity.SeUserAccntCollection, "List<SeUserAccnt>|SeUserAccntCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccnt child in entity.SeUserAccntCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.SeUserAccntCollection.Count > 0 || entity.SeUserAccntCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntCollection);
						
						deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccnt >) DataRepository.SeUserAccntProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCodeDoc>
				if (CanDeepSave(entity.SaCodeDocCollection, "List<SaCodeDoc>|SaCodeDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeDoc child in entity.SaCodeDocCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.SaCodeDocCollection.Count > 0 || entity.SaCodeDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeDocProvider.Save(transactionManager, entity.SaCodeDocCollection);
						
						deepHandles.Add("SaCodeDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeDoc >) DataRepository.SaCodeDocProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaRelative>
				if (CanDeepSave(entity.SaRelativeCollection, "List<SaRelative>|SaRelativeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRelative child in entity.SaRelativeCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.SaRelativeCollection.Count > 0 || entity.SaRelativeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRelativeProvider.Save(transactionManager, entity.SaRelativeCollection);
						
						deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRelative >) DataRepository.SaRelativeProvider.DeepSave,
							new object[] { transactionManager, entity.SaRelativeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAllowanceRule>
				if (CanDeepSave(entity.FeeAllowanceRuleCollection, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAllowanceRule child in entity.FeeAllowanceRuleCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.FeeAllowanceRuleCollection.Count > 0 || entity.FeeAllowanceRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAllowanceRuleProvider.Save(transactionManager, entity.FeeAllowanceRuleCollection);
						
						deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAllowanceRule >) DataRepository.FeeAllowanceRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeClrncItem>
				if (CanDeepSave(entity.GsCdeClrncItemCollection, "List<GsCdeClrncItem>|GsCdeClrncItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeClrncItem child in entity.GsCdeClrncItemCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.GsCdeClrncItemCollection.Count > 0 || entity.GsCdeClrncItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeClrncItemProvider.Save(transactionManager, entity.GsCdeClrncItemCollection);
						
						deepHandles.Add("GsCdeClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeClrncItem >) DataRepository.GsCdeClrncItemProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeClrncItemCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
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
				
	
			#region List<AdmPlaceExamDatetime>
				if (CanDeepSave(entity.AdmPlaceExamDatetimeCollection, "List<AdmPlaceExamDatetime>|AdmPlaceExamDatetimeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamDatetime child in entity.AdmPlaceExamDatetimeCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.AdmPlaceExamDatetimeCollection.Count > 0 || entity.AdmPlaceExamDatetimeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeCollection);
						
						deepHandles.Add("AdmPlaceExamDatetimeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamDatetime >) DataRepository.AdmPlaceExamDatetimeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamDatetimeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomBuilding>
				if (CanDeepSave(entity.AccomBuildingCollection, "List<AccomBuilding>|AccomBuildingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomBuilding child in entity.AccomBuildingCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.AccomBuildingCollection.Count > 0 || entity.AccomBuildingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomBuildingProvider.Save(transactionManager, entity.AccomBuildingCollection);
						
						deepHandles.Add("AccomBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomBuilding >) DataRepository.AccomBuildingProvider.DeepSave,
							new object[] { transactionManager, entity.AccomBuildingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
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
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.GsCodeGenderIdSource != null)
						{
							child.GsCodeGenderId = child.GsCodeGenderIdSource.GsCodeGenderId;
						}
						else
						{
							child.GsCodeGenderId = entity.GsCodeGenderId;
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
	
	#region GsCodeGenderChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeGender</c>
	///</summary>
	public enum GsCodeGenderChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for ScScheduleDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtl>))]
		ScScheduleDtlCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for AccomCdePermtTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomCdePermtType>))]
		AccomCdePermtTypeCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for SeUserAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccnt>))]
		SeUserAccntCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for SaCodeDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeDoc>))]
		SaCodeDocCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for SaRelativeCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRelative>))]
		SaRelativeCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for GsCdeClrncItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeClrncItem>))]
		GsCdeClrncItemCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for AdmPlaceExamDatetimeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamDatetime>))]
		AdmPlaceExamDatetimeCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for AccomBuildingCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomBuilding>))]
		AccomBuildingCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
		///<summary>
		/// Collection of <c>GsCodeGender</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
	}
	
	#endregion GsCodeGenderChildEntityTypes
	
	#region GsCodeGenderFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeGenderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeGender"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeGenderFilterBuilder : SqlFilterBuilder<GsCodeGenderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderFilterBuilder class.
		/// </summary>
		public GsCodeGenderFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeGenderFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeGenderFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeGenderFilterBuilder
	
	#region GsCodeGenderParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeGenderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeGender"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeGenderParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeGenderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderParameterBuilder class.
		/// </summary>
		public GsCodeGenderParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeGenderParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeGenderParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeGenderParameterBuilder
	
	#region GsCodeGenderSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeGenderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeGender"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeGenderSortBuilder : SqlSortBuilder<GsCodeGenderColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeGenderSqlSortBuilder class.
		/// </summary>
		public GsCodeGenderSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeGenderSortBuilder
	
} // end namespace
