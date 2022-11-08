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
	/// This class is the base class for any <see cref="EdCodeStudCaseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeStudCaseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeStudCase, UMIS_VER2.BusinessLyer.EdCodeStudCaseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudCaseKey key)
		{
			return Delete(transactionManager, key.EdCodeStudCaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeStudCaseId)
		{
			return Delete(null, _edCodeStudCaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeStudCaseId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeStudCase Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudCaseKey key, int start, int pageLength)
		{
			return GetByEdCodeStudCaseId(transactionManager, key.EdCodeStudCaseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_CASE_AR index.
		/// </summary>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(System.String _caseAr)
		{
			int count = -1;
			return GetByCaseAr(null,_caseAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CASE_AR index.
		/// </summary>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(System.String _caseAr, int start, int pageLength)
		{
			int count = -1;
			return GetByCaseAr(null, _caseAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(TransactionManager transactionManager, System.String _caseAr)
		{
			int count = -1;
			return GetByCaseAr(transactionManager, _caseAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(TransactionManager transactionManager, System.String _caseAr, int start, int pageLength)
		{
			int count = -1;
			return GetByCaseAr(transactionManager, _caseAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CASE_AR index.
		/// </summary>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(System.String _caseAr, int start, int pageLength, out int count)
		{
			return GetByCaseAr(null, _caseAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_CASE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_caseAr">وصف الحالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeStudCase GetByCaseAr(TransactionManager transactionManager, System.String _caseAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(System.Decimal _edCodeStudCaseId)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(null,_edCodeStudCaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(System.Decimal _edCodeStudCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(null, _edCodeStudCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal _edCodeStudCaseId)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(transactionManager, _edCodeStudCaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal _edCodeStudCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(transactionManager, _edCodeStudCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(System.Decimal _edCodeStudCaseId, int start, int pageLength, out int count)
		{
			return GetByEdCodeStudCaseId(null, _edCodeStudCaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUD_CASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مسلسل حالة الطالب داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeStudCase GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal _edCodeStudCaseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeStudCase&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeStudCase&gt;"/></returns>
		public static TList<EdCodeStudCase> Fill(IDataReader reader, TList<EdCodeStudCase> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeStudCase c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeStudCase")
					.Append("|").Append((System.Decimal)reader["ED_CODE_STUD_CASE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeStudCase>(
					key.ToString(), // EntityTrackingKey
					"EdCodeStudCase",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeStudCase();
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
					c.EdCodeStudCaseId = (System.Decimal)reader["ED_CODE_STUD_CASE_ID"];
					c.OriginalEdCodeStudCaseId = c.EdCodeStudCaseId;
					c.CaseAr = (System.String)reader["CASE_AR"];
					c.CaseEn = Convert.IsDBNull(reader["CASE_EN"]) ? null : (System.String)reader["CASE_EN"];
					c.CaseCode = Convert.IsDBNull(reader["CASE_CODE"]) ? null : (System.String)reader["CASE_CODE"];
					c.CaseOrdr = (System.Decimal)reader["CASE_ORDR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeStudCase entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeStudCaseId = (System.Decimal)reader[((int)EdCodeStudCaseColumn.EdCodeStudCaseId - 1)];
			entity.OriginalEdCodeStudCaseId = (System.Decimal)reader["ED_CODE_STUD_CASE_ID"];
			entity.CaseAr = (System.String)reader[((int)EdCodeStudCaseColumn.CaseAr - 1)];
			entity.CaseEn = (reader.IsDBNull(((int)EdCodeStudCaseColumn.CaseEn - 1)))?null:(System.String)reader[((int)EdCodeStudCaseColumn.CaseEn - 1)];
			entity.CaseCode = (reader.IsDBNull(((int)EdCodeStudCaseColumn.CaseCode - 1)))?null:(System.String)reader[((int)EdCodeStudCaseColumn.CaseCode - 1)];
			entity.CaseOrdr = (System.Decimal)reader[((int)EdCodeStudCaseColumn.CaseOrdr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeStudCase entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeStudCaseId = (System.Decimal)dataRow["ED_CODE_STUD_CASE_ID"];
			entity.OriginalEdCodeStudCaseId = (System.Decimal)dataRow["ED_CODE_STUD_CASE_ID"];
			entity.CaseAr = (System.String)dataRow["CASE_AR"];
			entity.CaseEn = Convert.IsDBNull(dataRow["CASE_EN"]) ? null : (System.String)dataRow["CASE_EN"];
			entity.CaseCode = Convert.IsDBNull(dataRow["CASE_CODE"]) ? null : (System.String)dataRow["CASE_CODE"];
			entity.CaseOrdr = (System.Decimal)dataRow["CASE_ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudCase"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStudCase Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudCase entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeStudCaseId methods when available
			
			#region EdStudSemesterExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterExtCollection = DataRepository.EdStudSemesterExtProvider.GetByEdCodeStudCaseId(transactionManager, entity.EdCodeStudCaseId);

				if (deep && entity.EdStudSemesterExtCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterExt>) DataRepository.EdStudSemesterExtProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeStudCase object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeStudCase instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStudCase Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudCase entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudSemesterExt>
				if (CanDeepSave(entity.EdStudSemesterExtCollection, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterExt child in entity.EdStudSemesterExtCollection)
					{
						if(child.EdCodeStudCaseIdSource != null)
						{
							child.EdCodeStudCaseId = child.EdCodeStudCaseIdSource.EdCodeStudCaseId;
						}
						else
						{
							child.EdCodeStudCaseId = entity.EdCodeStudCaseId;
						}

					}

					if (entity.EdStudSemesterExtCollection.Count > 0 || entity.EdStudSemesterExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterExtProvider.Save(transactionManager, entity.EdStudSemesterExtCollection);
						
						deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterExt >) DataRepository.EdStudSemesterExtProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeStudCaseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeStudCase</c>
	///</summary>
	public enum EdCodeStudCaseChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeStudCase</c> as OneToMany for EdStudSemesterExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterExt>))]
		EdStudSemesterExtCollection,
	}
	
	#endregion EdCodeStudCaseChildEntityTypes
	
	#region EdCodeStudCaseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeStudCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudCase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStudCaseFilterBuilder : SqlFilterBuilder<EdCodeStudCaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseFilterBuilder class.
		/// </summary>
		public EdCodeStudCaseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStudCaseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStudCaseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStudCaseFilterBuilder
	
	#region EdCodeStudCaseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeStudCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudCase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStudCaseParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeStudCaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseParameterBuilder class.
		/// </summary>
		public EdCodeStudCaseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStudCaseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStudCaseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStudCaseParameterBuilder
	
	#region EdCodeStudCaseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeStudCaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudCase"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeStudCaseSortBuilder : SqlSortBuilder<EdCodeStudCaseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudCaseSqlSortBuilder class.
		/// </summary>
		public EdCodeStudCaseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeStudCaseSortBuilder
	
} // end namespace
