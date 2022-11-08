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
	/// This class is the base class for any <see cref="IntegFpStaffAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegFpStaffAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegFpStaffAbsence, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceKey key)
		{
			return Delete(transactionManager, key.IntegFpStaffAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integFpStaffAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integFpStaffAbsenceId)
		{
			return Delete(null, _integFpStaffAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegFpStaffAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsenceKey key, int start, int pageLength)
		{
			return GetByIntegFpStaffAbsenceId(transactionManager, key.IntegFpStaffAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(null,_integFpStaffAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(null, _integFpStaffAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(transactionManager, _integFpStaffAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegFpStaffAbsenceId(transactionManager, _integFpStaffAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(System.Decimal _integFpStaffAbsenceId, int start, int pageLength, out int count)
		{
			return GetByIntegFpStaffAbsenceId(null, _integFpStaffAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__INTEG_FP__8F182469B35F436A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integFpStaffAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegFpStaffAbsence GetByIntegFpStaffAbsenceId(TransactionManager transactionManager, System.Decimal _integFpStaffAbsenceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegFpStaffAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegFpStaffAbsence&gt;"/></returns>
		public static TList<IntegFpStaffAbsence> Fill(IDataReader reader, TList<IntegFpStaffAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegFpStaffAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegFpStaffAbsence")
					.Append("|").Append((System.Decimal)reader["INTEG_FP_STAFF_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegFpStaffAbsence>(
					key.ToString(), // EntityTrackingKey
					"IntegFpStaffAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegFpStaffAbsence();
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
					c.DayDate = Convert.IsDBNull(reader["DAY_DATE"]) ? null : (System.DateTime?)reader["DAY_DATE"];
					c.StartFrom = Convert.IsDBNull(reader["start_from"]) ? null : (System.DateTime?)reader["start_from"];
					c.EndTo = Convert.IsDBNull(reader["end_to"]) ? null : (System.DateTime?)reader["end_to"];
					c.CourseCode = Convert.IsDBNull(reader["course_code"]) ? null : (System.String)reader["course_code"];
					c.LecturerId = Convert.IsDBNull(reader["lecturer_id"]) ? null : (System.String)reader["lecturer_id"];
					c.LecturerName = Convert.IsDBNull(reader["lecturer_name"]) ? null : (System.String)reader["lecturer_name"];
					c.CheckIn = Convert.IsDBNull(reader["check_in"]) ? null : (System.DateTime?)reader["check_in"];
					c.Checkout = Convert.IsDBNull(reader["checkout"]) ? null : (System.DateTime?)reader["checkout"];
					c.Absence = Convert.IsDBNull(reader["absence"]) ? null : (System.DateTime?)reader["absence"];
					c.IntegFpStaffAbsenceId = (System.Decimal)reader["INTEG_FP_STAFF_ABSENCE_ID"];
					c.Hallcode = Convert.IsDBNull(reader["hallcode"]) ? null : (System.String)reader["hallcode"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegFpStaffAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.DayDate = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.DayDate - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.DayDate - 1)];
			entity.StartFrom = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.StartFrom - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.StartFrom - 1)];
			entity.EndTo = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.EndTo - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.EndTo - 1)];
			entity.CourseCode = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.CourseCode - 1)))?null:(System.String)reader[((int)IntegFpStaffAbsenceColumn.CourseCode - 1)];
			entity.LecturerId = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.LecturerId - 1)))?null:(System.String)reader[((int)IntegFpStaffAbsenceColumn.LecturerId - 1)];
			entity.LecturerName = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.LecturerName - 1)))?null:(System.String)reader[((int)IntegFpStaffAbsenceColumn.LecturerName - 1)];
			entity.CheckIn = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.CheckIn - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.CheckIn - 1)];
			entity.Checkout = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.Checkout - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.Checkout - 1)];
			entity.Absence = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.Absence - 1)))?null:(System.DateTime?)reader[((int)IntegFpStaffAbsenceColumn.Absence - 1)];
			entity.IntegFpStaffAbsenceId = (System.Decimal)reader[((int)IntegFpStaffAbsenceColumn.IntegFpStaffAbsenceId - 1)];
			entity.Hallcode = (reader.IsDBNull(((int)IntegFpStaffAbsenceColumn.Hallcode - 1)))?null:(System.String)reader[((int)IntegFpStaffAbsenceColumn.Hallcode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegFpStaffAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.DayDate = Convert.IsDBNull(dataRow["DAY_DATE"]) ? null : (System.DateTime?)dataRow["DAY_DATE"];
			entity.StartFrom = Convert.IsDBNull(dataRow["start_from"]) ? null : (System.DateTime?)dataRow["start_from"];
			entity.EndTo = Convert.IsDBNull(dataRow["end_to"]) ? null : (System.DateTime?)dataRow["end_to"];
			entity.CourseCode = Convert.IsDBNull(dataRow["course_code"]) ? null : (System.String)dataRow["course_code"];
			entity.LecturerId = Convert.IsDBNull(dataRow["lecturer_id"]) ? null : (System.String)dataRow["lecturer_id"];
			entity.LecturerName = Convert.IsDBNull(dataRow["lecturer_name"]) ? null : (System.String)dataRow["lecturer_name"];
			entity.CheckIn = Convert.IsDBNull(dataRow["check_in"]) ? null : (System.DateTime?)dataRow["check_in"];
			entity.Checkout = Convert.IsDBNull(dataRow["checkout"]) ? null : (System.DateTime?)dataRow["checkout"];
			entity.Absence = Convert.IsDBNull(dataRow["absence"]) ? null : (System.DateTime?)dataRow["absence"];
			entity.IntegFpStaffAbsenceId = (System.Decimal)dataRow["INTEG_FP_STAFF_ABSENCE_ID"];
			entity.Hallcode = Convert.IsDBNull(dataRow["hallcode"]) ? null : (System.String)dataRow["hallcode"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegFpStaffAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegFpStaffAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByIntegFpStaffAbsenceId methods when available
			
			#region IntegFpStaffAbsenceDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<IntegFpStaffAbsenceDtl>|IntegFpStaffAbsenceDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegFpStaffAbsenceDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.IntegFpStaffAbsenceDtlCollection = DataRepository.IntegFpStaffAbsenceDtlProvider.GetByIntegFpStaffAbsenceId(transactionManager, entity.IntegFpStaffAbsenceId);

				if (deep && entity.IntegFpStaffAbsenceDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegFpStaffAbsenceDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegFpStaffAbsenceDtl>) DataRepository.IntegFpStaffAbsenceDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegFpStaffAbsenceDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegFpStaffAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegFpStaffAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegFpStaffAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegFpStaffAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<IntegFpStaffAbsenceDtl>
				if (CanDeepSave(entity.IntegFpStaffAbsenceDtlCollection, "List<IntegFpStaffAbsenceDtl>|IntegFpStaffAbsenceDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(IntegFpStaffAbsenceDtl child in entity.IntegFpStaffAbsenceDtlCollection)
					{
						if(child.IntegFpStaffAbsenceIdSource != null)
						{
							child.IntegFpStaffAbsenceId = child.IntegFpStaffAbsenceIdSource.IntegFpStaffAbsenceId;
						}
						else
						{
							child.IntegFpStaffAbsenceId = entity.IntegFpStaffAbsenceId;
						}

					}

					if (entity.IntegFpStaffAbsenceDtlCollection.Count > 0 || entity.IntegFpStaffAbsenceDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.IntegFpStaffAbsenceDtlProvider.Save(transactionManager, entity.IntegFpStaffAbsenceDtlCollection);
						
						deepHandles.Add("IntegFpStaffAbsenceDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< IntegFpStaffAbsenceDtl >) DataRepository.IntegFpStaffAbsenceDtlProvider.DeepSave,
							new object[] { transactionManager, entity.IntegFpStaffAbsenceDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region IntegFpStaffAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegFpStaffAbsence</c>
	///</summary>
	public enum IntegFpStaffAbsenceChildEntityTypes
	{
		///<summary>
		/// Collection of <c>IntegFpStaffAbsence</c> as OneToMany for IntegFpStaffAbsenceDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegFpStaffAbsenceDtl>))]
		IntegFpStaffAbsenceDtlCollection,
	}
	
	#endregion IntegFpStaffAbsenceChildEntityTypes
	
	#region IntegFpStaffAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegFpStaffAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegFpStaffAbsenceFilterBuilder : SqlFilterBuilder<IntegFpStaffAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceFilterBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegFpStaffAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegFpStaffAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegFpStaffAbsenceFilterBuilder
	
	#region IntegFpStaffAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegFpStaffAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegFpStaffAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<IntegFpStaffAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceParameterBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegFpStaffAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegFpStaffAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegFpStaffAbsenceParameterBuilder
	
	#region IntegFpStaffAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegFpStaffAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegFpStaffAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegFpStaffAbsenceSortBuilder : SqlSortBuilder<IntegFpStaffAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegFpStaffAbsenceSqlSortBuilder class.
		/// </summary>
		public IntegFpStaffAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegFpStaffAbsenceSortBuilder
	
} // end namespace
