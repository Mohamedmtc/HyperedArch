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
	/// This class is the base class for any <see cref="EdCdeExamTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeExamTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeExamType, UMIS_VER2.BusinessLyer.EdCdeExamTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamTypeKey key)
		{
			return Delete(transactionManager, key.EdCdeExamTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeExamTypeId)
		{
			return Delete(null, _edCdeExamTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeExamType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamTypeKey key, int start, int pageLength)
		{
			return GetByEdCdeExamTypeId(transactionManager, key.EdCdeExamTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(null,_edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_REEXAM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeExamType GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeExamType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeExamType&gt;"/></returns>
		public static TList<EdCdeExamType> Fill(IDataReader reader, TList<EdCdeExamType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeExamType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeExamType")
					.Append("|").Append((System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeExamType>(
					key.ToString(), // EntityTrackingKey
					"EdCdeExamType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeExamType();
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
					c.EdCdeExamTypeId = (System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"];
					c.OriginalEdCdeExamTypeId = c.EdCdeExamTypeId;
					c.ExamTypeAr = (System.String)reader["EXAM_TYPE_AR"];
					c.ExmTypeEn = (System.String)reader["EXM_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeExamType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeExamTypeId = (System.Decimal)reader[((int)EdCdeExamTypeColumn.EdCdeExamTypeId - 1)];
			entity.OriginalEdCdeExamTypeId = (System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"];
			entity.ExamTypeAr = (System.String)reader[((int)EdCdeExamTypeColumn.ExamTypeAr - 1)];
			entity.ExmTypeEn = (System.String)reader[((int)EdCdeExamTypeColumn.ExmTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeExamType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeExamTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.OriginalEdCdeExamTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.ExamTypeAr = (System.String)dataRow["EXAM_TYPE_AR"];
			entity.ExmTypeEn = (System.String)dataRow["EXM_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeExamType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExamType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeExamTypeId methods when available
			
			#region EdExamStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamStudAbsenceCollection = DataRepository.EdExamStudAbsenceProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdExamStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamStudAbsence>) DataRepository.EdExamStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdExamSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdExamSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdExamSemesterCollection = DataRepository.EdStdExamSemesterProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStdExamSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdExamSemester>) DataRepository.EdStdExamSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdExamSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheat>|EdStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatCollection = DataRepository.EdStudCheatProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStudCheatCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheat>) DataRepository.EdStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollection = DataRepository.EdStdCrsExamProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStdCrsExamCollection.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudSecretNumCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudSecretNumCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudSecretNumCollection = DataRepository.CoStudSecretNumProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.CoStudSecretNumCollection.Count > 0)
				{
					deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudSecretNum>) DataRepository.CoStudSecretNumProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudSecretNumCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.CoControlCollection = DataRepository.CoControlProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeExamType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeExamType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeExamType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeExamType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdExamStudAbsence>
				if (CanDeepSave(entity.EdExamStudAbsenceCollection, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamStudAbsence child in entity.EdExamStudAbsenceCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdExamStudAbsenceCollection.Count > 0 || entity.EdExamStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamStudAbsenceProvider.Save(transactionManager, entity.EdExamStudAbsenceCollection);
						
						deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamStudAbsence >) DataRepository.EdExamStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdExamSemester>
				if (CanDeepSave(entity.EdStdExamSemesterCollection, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdExamSemester child in entity.EdStdExamSemesterCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStdExamSemesterCollection.Count > 0 || entity.EdStdExamSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdExamSemesterProvider.Save(transactionManager, entity.EdStdExamSemesterCollection);
						
						deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdExamSemester >) DataRepository.EdStdExamSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdExamSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCheat>
				if (CanDeepSave(entity.EdStudCheatCollection, "List<EdStudCheat>|EdStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheat child in entity.EdStudCheatCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStudCheatCollection.Count > 0 || entity.EdStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatCollection);
						
						deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheat >) DataRepository.EdStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollection, "List<EdStdCrsExam>|EdStdCrsExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStdCrsExamCollection.Count > 0 || entity.EdStdCrsExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollection);
						
						deepHandles.Add("EdStdCrsExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudSecretNum>
				if (CanDeepSave(entity.CoStudSecretNumCollection, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudSecretNum child in entity.CoStudSecretNumCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.CoStudSecretNumCollection.Count > 0 || entity.CoStudSecretNumCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudSecretNumProvider.Save(transactionManager, entity.CoStudSecretNumCollection);
						
						deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudSecretNum >) DataRepository.CoStudSecretNumProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudSecretNumCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
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
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCdeExamTypeIdSource != null)
						{
							child.EdCdeExamTypeId = child.EdCdeExamTypeIdSource.EdCdeExamTypeId;
						}
						else
						{
							child.EdCdeExamTypeId = entity.EdCdeExamTypeId;
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
	
	#region EdCdeExamTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeExamType</c>
	///</summary>
	public enum EdCdeExamTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdExamStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamStudAbsence>))]
		EdExamStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStdExamSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdExamSemester>))]
		EdStdExamSemesterCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheat>))]
		EdStudCheatCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for CoStudSecretNumCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudSecretNum>))]
		CoStudSecretNumCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdCdeExamType</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
	}
	
	#endregion EdCdeExamTypeChildEntityTypes
	
	#region EdCdeExamTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeExamTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExamTypeFilterBuilder : SqlFilterBuilder<EdCdeExamTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeFilterBuilder class.
		/// </summary>
		public EdCdeExamTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExamTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExamTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExamTypeFilterBuilder
	
	#region EdCdeExamTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeExamTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeExamTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeExamTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeParameterBuilder class.
		/// </summary>
		public EdCdeExamTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeExamTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeExamTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeExamTypeParameterBuilder
	
	#region EdCdeExamTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeExamTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeExamType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeExamTypeSortBuilder : SqlSortBuilder<EdCdeExamTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeExamTypeSqlSortBuilder class.
		/// </summary>
		public EdCdeExamTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeExamTypeSortBuilder
	
} // end namespace
