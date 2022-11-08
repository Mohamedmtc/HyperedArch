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
	/// This class is the base class for any <see cref="AsCodeDegreeClassProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AsCodeDegreeClassProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AsCodeDegreeClass, UMIS_VER2.BusinessLyer.AsCodeDegreeClassKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeClassKey key)
		{
			return Delete(transactionManager, key.AsCodeDegreeClassId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_asCodeDegreeClassId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _asCodeDegreeClassId)
		{
			return Delete(null, _asCodeDegreeClassId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId);		
		
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
		public override UMIS_VER2.BusinessLyer.AsCodeDegreeClass Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeClassKey key, int start, int pageLength)
		{
			return GetByAsCodeDegreeClassId(transactionManager, key.AsCodeDegreeClassId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(null,_asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE_CLASS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AsCodeDegreeClass GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AsCodeDegreeClass&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AsCodeDegreeClass&gt;"/></returns>
		public static TList<AsCodeDegreeClass> Fill(IDataReader reader, TList<AsCodeDegreeClass> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AsCodeDegreeClass c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AsCodeDegreeClass")
					.Append("|").Append((System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AsCodeDegreeClass>(
					key.ToString(), // EntityTrackingKey
					"AsCodeDegreeClass",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AsCodeDegreeClass();
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
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.OriginalAsCodeDegreeClassId = c.AsCodeDegreeClassId;
					c.ClassDescrAr = (System.String)reader["CLASS_DESCR_AR"];
					c.ClassDescrEn = Convert.IsDBNull(reader["CLASS_DESCR_EN"]) ? null : (System.String)reader["CLASS_DESCR_EN"];
					c.ClassCode = Convert.IsDBNull(reader["CLASS_CODE"]) ? null : (System.String)reader["CLASS_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AsCodeDegreeClass entity)
		{
			if (!reader.Read()) return;
			
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AsCodeDegreeClassColumn.AsCodeDegreeClassId - 1)];
			entity.OriginalAsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
			entity.ClassDescrAr = (System.String)reader[((int)AsCodeDegreeClassColumn.ClassDescrAr - 1)];
			entity.ClassDescrEn = (reader.IsDBNull(((int)AsCodeDegreeClassColumn.ClassDescrEn - 1)))?null:(System.String)reader[((int)AsCodeDegreeClassColumn.ClassDescrEn - 1)];
			entity.ClassCode = (reader.IsDBNull(((int)AsCodeDegreeClassColumn.ClassCode - 1)))?null:(System.String)reader[((int)AsCodeDegreeClassColumn.ClassCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AsCodeDegreeClass entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.OriginalAsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.ClassDescrAr = (System.String)dataRow["CLASS_DESCR_AR"];
			entity.ClassDescrEn = Convert.IsDBNull(dataRow["CLASS_DESCR_EN"]) ? null : (System.String)dataRow["CLASS_DESCR_EN"];
			entity.ClassCode = Convert.IsDBNull(dataRow["CLASS_CODE"]) ? null : (System.String)dataRow["CLASS_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegreeClass"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsCodeDegreeClass Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeClass entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAsCodeDegreeClassId methods when available
			
			#region EdAcadYearFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadYearFacultyCollection = DataRepository.EdAcadYearFacultyProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdAcadYearFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadYearFaculty>) DataRepository.EdAcadYearFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterOpenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SeUserAccntCollection = DataRepository.SeUserAccntProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.SeUserAccntCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccnt>) DataRepository.SeUserAccntProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCodeEngTestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCodeEngTestCollection = DataRepository.AdmCodeEngTestProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmCodeEngTestCollection.Count > 0)
				{
					deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCodeEngTest>) DataRepository.AdmCodeEngTestProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCodeEngTestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AsCodeDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AsCodeDegree>|AsCodeDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AsCodeDegreeCollection = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AsCodeDegreeCollection.Count > 0)
				{
					deepHandles.Add("AsCodeDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AsCodeDegree>) DataRepository.AsCodeDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.AsCodeDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeForm>|SeFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormCollection = DataRepository.SeFormProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.SeFormCollection.Count > 0)
				{
					deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeForm>) DataRepository.SeFormProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollection = DataRepository.SpoSponsorOfferProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.SpoSponsorOfferCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantDegreeCollection = DataRepository.PgThesisGrantDegreeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.PgThesisGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantDegree>) DataRepository.PgThesisGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCode>|FeeRefundCodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeCollection = DataRepository.FeeRefundCodeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeRefundCodeCollection.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCode>) DataRepository.FeeRefundCodeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInstlmntRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInstlmntRuleCollection = DataRepository.FeeInstlmntRuleProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeInstlmntRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntRule>) DataRepository.FeeInstlmntRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCdeSchshipTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeSchshipType>|FeeCdeSchshipTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeSchshipTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeSchshipTypeCollection = DataRepository.FeeCdeSchshipTypeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeCdeSchshipTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeSchshipTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeSchshipType>) DataRepository.FeeCdeSchshipTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeSchshipTypeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCdeCrsRegTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCdeCrsRegType>|EdCdeCrsRegTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeCrsRegTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCdeCrsRegTypeCollection = DataRepository.EdCdeCrsRegTypeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdCdeCrsRegTypeCollection.Count > 0)
				{
					deepHandles.Add("EdCdeCrsRegTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCdeCrsRegType>) DataRepository.EdCdeCrsRegTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCdeCrsRegTypeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCdeQualCatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCdeQualCatCollection = DataRepository.EdCdeQualCatProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdCdeQualCatCollection.Count > 0)
				{
					deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCdeQualCat>) DataRepository.EdCdeQualCatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCdeQualCatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AppTypeRegStepsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AppTypeRegSteps>|AppTypeRegStepsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AppTypeRegStepsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AppTypeRegStepsCollection = DataRepository.AppTypeRegStepsProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AppTypeRegStepsCollection.Count > 0)
				{
					deepHandles.Add("AppTypeRegStepsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AppTypeRegSteps>) DataRepository.AppTypeRegStepsProvider.DeepLoad,
						new object[] { transactionManager, entity.AppTypeRegStepsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCdeDiscTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeDiscTypeCollection = DataRepository.FeeCdeDiscTypeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeCdeDiscTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeDiscType>) DataRepository.FeeCdeDiscTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppCountCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppCount>|AdmAppCountCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppCountCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppCountCollection = DataRepository.AdmAppCountProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmAppCountCollection.Count > 0)
				{
					deepHandles.Add("AdmAppCountCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppCount>) DataRepository.AdmAppCountProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppCountCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollection = DataRepository.EdOfferingProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdOfferingCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgOffering>|PgOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgOfferingCollection = DataRepository.PgOfferingProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.PgOfferingCollection.Count > 0)
				{
					deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgOffering>) DataRepository.PgOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.PgOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAcceptanceCategoryCollection = DataRepository.AdmAcceptanceCategoryProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAcceptanceCategory>) DataRepository.AdmAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTransAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTransAcceptanceCategoryCollection = DataRepository.AdmTransAcceptanceCategoryProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmTransAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTransAcceptanceCategory>) DataRepository.AdmTransAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResultApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResultApprove>|EdResultApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResultApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResultApproveCollection = DataRepository.EdResultApproveProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdResultApproveCollection.Count > 0)
				{
					deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResultApprove>) DataRepository.EdResultApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResultApproveCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmCdePlacementExamCollection = DataRepository.AdmCdePlacementExamProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmCdePlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeLimitRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeLimitRule>|FeeLimitRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeLimitRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterAgendaCollection = DataRepository.EdSemesterAgendaProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterAgenda>) DataRepository.EdSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCodeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCodeItem>|FeeCodeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCodeItemCollection = DataRepository.FeeCodeItemProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCodeItem>) DataRepository.FeeCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCodeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodeFullfillMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeFullfillMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodeFullfillMetadataCollection = DataRepository.EntCodeFullfillMetadataProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EntCodeFullfillMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeFullfillMetadata>) DataRepository.EntCodeFullfillMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeFullfillMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCompetitiveAvgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCompetitiveAvgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCompetitiveAvgCollection = DataRepository.AdmCompetitiveAvgProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmCompetitiveAvgCollection.Count > 0)
				{
					deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCompetitiveAvg>) DataRepository.AdmCompetitiveAvgProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikCodesCollection = DataRepository.AdmTansikCodesProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmTansikCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikCodes>) DataRepository.AdmTansikCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGraduationAward>|EdGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGraduationAwardCollection = DataRepository.EdGraduationAwardProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.EdGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGraduationAward>) DataRepository.EdGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControl>|CoControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlCollection = DataRepository.CoControlProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AsCodeDegreeClass object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AsCodeDegreeClass instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsCodeDegreeClass Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeClass entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdAcadYearFaculty>
				if (CanDeepSave(entity.EdAcadYearFacultyCollection, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadYearFaculty child in entity.EdAcadYearFacultyCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdAcadYearFacultyCollection.Count > 0 || entity.EdAcadYearFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadYearFacultyProvider.Save(transactionManager, entity.EdAcadYearFacultyCollection);
						
						deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadYearFaculty >) DataRepository.EdAcadYearFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterOpen>
				if (CanDeepSave(entity.EdSemesterOpenCollection, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterOpen child in entity.EdSemesterOpenCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdSemesterOpenCollection.Count > 0 || entity.EdSemesterOpenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenCollection);
						
						deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterOpen >) DataRepository.EdSemesterOpenProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterOpenCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<AdmCodeEngTest>
				if (CanDeepSave(entity.AdmCodeEngTestCollection, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCodeEngTest child in entity.AdmCodeEngTestCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmCodeEngTestCollection.Count > 0 || entity.AdmCodeEngTestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestCollection);
						
						deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCodeEngTest >) DataRepository.AdmCodeEngTestProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCodeEngTestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AsCodeDegree>
				if (CanDeepSave(entity.AsCodeDegreeCollection, "List<AsCodeDegree>|AsCodeDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AsCodeDegree child in entity.AsCodeDegreeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AsCodeDegreeCollection.Count > 0 || entity.AsCodeDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeCollection);
						
						deepHandles.Add("AsCodeDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AsCodeDegree >) DataRepository.AsCodeDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.AsCodeDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeForm>
				if (CanDeepSave(entity.SeFormCollection, "List<SeForm>|SeFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeForm child in entity.SeFormCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.SeFormCollection.Count > 0 || entity.SeFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormCollection);
						
						deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeForm >) DataRepository.SeFormProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollection, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.SpoSponsorOfferCollection.Count > 0 || entity.SpoSponsorOfferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollection);
						
						deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantDegree>
				if (CanDeepSave(entity.PgThesisGrantDegreeCollection, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantDegree child in entity.PgThesisGrantDegreeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.PgThesisGrantDegreeCollection.Count > 0 || entity.PgThesisGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeCollection);
						
						deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantDegree >) DataRepository.PgThesisGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefundCode>
				if (CanDeepSave(entity.FeeRefundCodeCollection, "List<FeeRefundCode>|FeeRefundCodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCode child in entity.FeeRefundCodeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeRefundCodeCollection.Count > 0 || entity.FeeRefundCodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeProvider.Save(transactionManager, entity.FeeRefundCodeCollection);
						
						deepHandles.Add("FeeRefundCodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCode >) DataRepository.FeeRefundCodeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInstlmntRule>
				if (CanDeepSave(entity.FeeInstlmntRuleCollection, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInstlmntRule child in entity.FeeInstlmntRuleCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeInstlmntRuleCollection.Count > 0 || entity.FeeInstlmntRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInstlmntRuleProvider.Save(transactionManager, entity.FeeInstlmntRuleCollection);
						
						deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInstlmntRule >) DataRepository.FeeInstlmntRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCdeSchshipType>
				if (CanDeepSave(entity.FeeCdeSchshipTypeCollection, "List<FeeCdeSchshipType>|FeeCdeSchshipTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeSchshipType child in entity.FeeCdeSchshipTypeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeCdeSchshipTypeCollection.Count > 0 || entity.FeeCdeSchshipTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeSchshipTypeProvider.Save(transactionManager, entity.FeeCdeSchshipTypeCollection);
						
						deepHandles.Add("FeeCdeSchshipTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeSchshipType >) DataRepository.FeeCdeSchshipTypeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeSchshipTypeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCdeCrsRegType>
				if (CanDeepSave(entity.EdCdeCrsRegTypeCollection, "List<EdCdeCrsRegType>|EdCdeCrsRegTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCdeCrsRegType child in entity.EdCdeCrsRegTypeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdCdeCrsRegTypeCollection.Count > 0 || entity.EdCdeCrsRegTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCdeCrsRegTypeProvider.Save(transactionManager, entity.EdCdeCrsRegTypeCollection);
						
						deepHandles.Add("EdCdeCrsRegTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCdeCrsRegType >) DataRepository.EdCdeCrsRegTypeProvider.DeepSave,
							new object[] { transactionManager, entity.EdCdeCrsRegTypeCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<EdCdeQualCat>
				if (CanDeepSave(entity.EdCdeQualCatCollection, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCdeQualCat child in entity.EdCdeQualCatCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdCdeQualCatCollection.Count > 0 || entity.EdCdeQualCatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatCollection);
						
						deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCdeQualCat >) DataRepository.EdCdeQualCatProvider.DeepSave,
							new object[] { transactionManager, entity.EdCdeQualCatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AppTypeRegSteps>
				if (CanDeepSave(entity.AppTypeRegStepsCollection, "List<AppTypeRegSteps>|AppTypeRegStepsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AppTypeRegSteps child in entity.AppTypeRegStepsCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AppTypeRegStepsCollection.Count > 0 || entity.AppTypeRegStepsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AppTypeRegStepsProvider.Save(transactionManager, entity.AppTypeRegStepsCollection);
						
						deepHandles.Add("AppTypeRegStepsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AppTypeRegSteps >) DataRepository.AppTypeRegStepsProvider.DeepSave,
							new object[] { transactionManager, entity.AppTypeRegStepsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCdeDiscType>
				if (CanDeepSave(entity.FeeCdeDiscTypeCollection, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeDiscType child in entity.FeeCdeDiscTypeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeCdeDiscTypeCollection.Count > 0 || entity.FeeCdeDiscTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeCollection);
						
						deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeDiscType >) DataRepository.FeeCdeDiscTypeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<AdmAppCount>
				if (CanDeepSave(entity.AdmAppCountCollection, "List<AdmAppCount>|AdmAppCountCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppCount child in entity.AdmAppCountCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmAppCountCollection.Count > 0 || entity.AdmAppCountCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppCountProvider.Save(transactionManager, entity.AdmAppCountCollection);
						
						deepHandles.Add("AdmAppCountCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppCount >) DataRepository.AdmAppCountProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppCountCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollection, "List<EdOffering>|EdOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdOfferingCollection.Count > 0 || entity.EdOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollection);
						
						deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgOffering>
				if (CanDeepSave(entity.PgOfferingCollection, "List<PgOffering>|PgOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgOffering child in entity.PgOfferingCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.PgOfferingCollection.Count > 0 || entity.PgOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingCollection);
						
						deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgOffering >) DataRepository.PgOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.PgOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAcceptanceCategory>
				if (CanDeepSave(entity.AdmAcceptanceCategoryCollection, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAcceptanceCategory child in entity.AdmAcceptanceCategoryCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmAcceptanceCategoryCollection.Count > 0 || entity.AdmAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAcceptanceCategoryProvider.Save(transactionManager, entity.AdmAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAcceptanceCategory >) DataRepository.AdmAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTransAcceptanceCategory>
				if (CanDeepSave(entity.AdmTransAcceptanceCategoryCollection, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTransAcceptanceCategory child in entity.AdmTransAcceptanceCategoryCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmTransAcceptanceCategoryCollection.Count > 0 || entity.AdmTransAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTransAcceptanceCategoryProvider.Save(transactionManager, entity.AdmTransAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTransAcceptanceCategory >) DataRepository.AdmTransAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResultApprove>
				if (CanDeepSave(entity.EdResultApproveCollection, "List<EdResultApprove>|EdResultApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResultApprove child in entity.EdResultApproveCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdResultApproveCollection.Count > 0 || entity.EdResultApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResultApproveProvider.Save(transactionManager, entity.EdResultApproveCollection);
						
						deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResultApprove >) DataRepository.EdResultApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdResultApproveCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
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
				
	
			#region List<FeeLimitRule>
				if (CanDeepSave(entity.FeeLimitRuleCollection, "List<FeeLimitRule>|FeeLimitRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeLimitRule child in entity.FeeLimitRuleCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeLimitRuleCollection.Count > 0 || entity.FeeLimitRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeLimitRuleProvider.Save(transactionManager, entity.FeeLimitRuleCollection);
						
						deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeLimitRule >) DataRepository.FeeLimitRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeLimitRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterAgenda>
				if (CanDeepSave(entity.EdSemesterAgendaCollection, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterAgenda child in entity.EdSemesterAgendaCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdSemesterAgendaCollection.Count > 0 || entity.EdSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaCollection);
						
						deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterAgenda >) DataRepository.EdSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterAgendaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCodeItem>
				if (CanDeepSave(entity.FeeCodeItemCollection, "List<FeeCodeItem>|FeeCodeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCodeItem child in entity.FeeCodeItemCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeCodeItemCollection.Count > 0 || entity.FeeCodeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemCollection);
						
						deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCodeItem >) DataRepository.FeeCodeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCodeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodeFullfillMetadata>
				if (CanDeepSave(entity.EntCodeFullfillMetadataCollection, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodeFullfillMetadata child in entity.EntCodeFullfillMetadataCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EntCodeFullfillMetadataCollection.Count > 0 || entity.EntCodeFullfillMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodeFullfillMetadataProvider.Save(transactionManager, entity.EntCodeFullfillMetadataCollection);
						
						deepHandles.Add("EntCodeFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodeFullfillMetadata >) DataRepository.EntCodeFullfillMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodeFullfillMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCompetitiveAvg>
				if (CanDeepSave(entity.AdmCompetitiveAvgCollection, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCompetitiveAvg child in entity.AdmCompetitiveAvgCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmCompetitiveAvgCollection.Count > 0 || entity.AdmCompetitiveAvgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCompetitiveAvgProvider.Save(transactionManager, entity.AdmCompetitiveAvgCollection);
						
						deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCompetitiveAvg >) DataRepository.AdmCompetitiveAvgProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikCodes>
				if (CanDeepSave(entity.AdmTansikCodesCollection, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikCodes child in entity.AdmTansikCodesCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmTansikCodesCollection.Count > 0 || entity.AdmTansikCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikCodesProvider.Save(transactionManager, entity.AdmTansikCodesCollection);
						
						deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikCodes >) DataRepository.AdmTansikCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGraduationAward>
				if (CanDeepSave(entity.EdGraduationAwardCollection, "List<EdGraduationAward>|EdGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGraduationAward child in entity.EdGraduationAwardCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.EdGraduationAwardCollection.Count > 0 || entity.EdGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardCollection);
						
						deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGraduationAward >) DataRepository.EdGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGraduationAwardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControl>
				if (CanDeepSave(entity.CoControlCollection, "List<CoControl>|CoControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControl child in entity.CoControlCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.CoControlCollection.Count > 0 || entity.CoControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlCollection);
						
						deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControl >) DataRepository.CoControlProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.AsCodeDegreeClassIdSource != null)
						{
							child.AsCodeDegreeClassId = child.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
						}
						else
						{
							child.AsCodeDegreeClassId = entity.AsCodeDegreeClassId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AsCodeDegreeClassChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AsCodeDegreeClass</c>
	///</summary>
	public enum AsCodeDegreeClassChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdAcadYearFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadYearFaculty>))]
		EdAcadYearFacultyCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for SeUserAccntCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccnt>))]
		SeUserAccntCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmCodeEngTestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCodeEngTest>))]
		AdmCodeEngTestCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AsCodeDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AsCodeDegree>))]
		AsCodeDegreeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for SeFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeForm>))]
		SeFormCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for PgThesisGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantDegree>))]
		PgThesisGrantDegreeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeRefundCodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCode>))]
		FeeRefundCodeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeInstlmntRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntRule>))]
		FeeInstlmntRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeCdeSchshipTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeSchshipType>))]
		FeeCdeSchshipTypeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdCdeCrsRegTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCdeCrsRegType>))]
		EdCdeCrsRegTypeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdCdeQualCatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCdeQualCat>))]
		EdCdeQualCatCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AppTypeRegStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AppTypeRegSteps>))]
		AppTypeRegStepsCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeCdeDiscTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeDiscType>))]
		FeeCdeDiscTypeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmAppCountCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppCount>))]
		AdmAppCountCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for PgOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgOffering>))]
		PgOfferingCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAcceptanceCategory>))]
		AdmAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmTransAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTransAcceptanceCategory>))]
		AdmTransAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdResultApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResultApprove>))]
		EdResultApproveCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterAgenda>))]
		EdSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCodeItem>))]
		FeeCodeItemCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EntCodeFullfillMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeFullfillMetadata>))]
		EntCodeFullfillMetadataCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmCompetitiveAvgCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCompetitiveAvg>))]
		AdmCompetitiveAvgCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmTansikCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikCodes>))]
		AdmTansikCodesCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for EdGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGraduationAward>))]
		EdGraduationAwardCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
		///<summary>
		/// Collection of <c>AsCodeDegreeClass</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
	}
	
	#endregion AsCodeDegreeClassChildEntityTypes
	
	#region AsCodeDegreeClassFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AsCodeDegreeClassColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegreeClass"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsCodeDegreeClassFilterBuilder : SqlFilterBuilder<AsCodeDegreeClassColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassFilterBuilder class.
		/// </summary>
		public AsCodeDegreeClassFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsCodeDegreeClassFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsCodeDegreeClassFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsCodeDegreeClassFilterBuilder
	
	#region AsCodeDegreeClassParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AsCodeDegreeClassColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegreeClass"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsCodeDegreeClassParameterBuilder : ParameterizedSqlFilterBuilder<AsCodeDegreeClassColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassParameterBuilder class.
		/// </summary>
		public AsCodeDegreeClassParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsCodeDegreeClassParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsCodeDegreeClassParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsCodeDegreeClassParameterBuilder
	
	#region AsCodeDegreeClassSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AsCodeDegreeClassColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegreeClass"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AsCodeDegreeClassSortBuilder : SqlSortBuilder<AsCodeDegreeClassColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeClassSqlSortBuilder class.
		/// </summary>
		public AsCodeDegreeClassSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AsCodeDegreeClassSortBuilder
	
} // end namespace
