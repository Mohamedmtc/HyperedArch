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
	/// This class is the base class for any <see cref="IntegMoodleEnrolProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegMoodleEnrolProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegMoodleEnrol, UMIS_VER2.BusinessLyer.IntegMoodleEnrolKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleEnrolKey key)
		{
			return Delete(transactionManager, key.IntegMoodleEnrolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integMoodleEnrolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integMoodleEnrolId)
		{
			return Delete(null, _integMoodleEnrolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleEnrolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integMoodleEnrolId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegMoodleEnrol Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleEnrolKey key, int start, int pageLength)
		{
			return GetByIntegMoodleEnrolId(transactionManager, key.IntegMoodleEnrolId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key CodeIndx index.
		/// </summary>
		/// <param name="_code"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCode(System.String _code)
		{
			int count = -1;
			return GetByCode(null,_code, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CodeIndx index.
		/// </summary>
		/// <param name="_code"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCode(System.String _code, int start, int pageLength)
		{
			int count = -1;
			return GetByCode(null, _code, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CodeIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_code"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCode(TransactionManager transactionManager, System.String _code)
		{
			int count = -1;
			return GetByCode(transactionManager, _code, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CodeIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_code"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCode(TransactionManager transactionManager, System.String _code, int start, int pageLength)
		{
			int count = -1;
			return GetByCode(transactionManager, _code, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CodeIndx index.
		/// </summary>
		/// <param name="_code"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCode(System.String _code, int start, int pageLength, out int count)
		{
			return GetByCode(null, _code, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the CodeIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_code"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public abstract TList<IntegMoodleEnrol> GetByCode(TransactionManager transactionManager, System.String _code, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key CrsIndx index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCourseCode(System.String _courseCode)
		{
			int count = -1;
			return GetByCourseCode(null,_courseCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CrsIndx index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCourseCode(System.String _courseCode, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseCode(null, _courseCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CrsIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCourseCode(TransactionManager transactionManager, System.String _courseCode)
		{
			int count = -1;
			return GetByCourseCode(transactionManager, _courseCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CrsIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCourseCode(TransactionManager transactionManager, System.String _courseCode, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseCode(transactionManager, _courseCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CrsIndx index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public TList<IntegMoodleEnrol> GetByCourseCode(System.String _courseCode, int start, int pageLength, out int count)
		{
			return GetByCourseCode(null, _courseCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the CrsIndx index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;IntegMoodleEnrol&gt;"/> class.</returns>
		public abstract TList<IntegMoodleEnrol> GetByCourseCode(TransactionManager transactionManager, System.String _courseCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="_integMoodleEnrolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(System.Decimal _integMoodleEnrolId)
		{
			int count = -1;
			return GetByIntegMoodleEnrolId(null,_integMoodleEnrolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="_integMoodleEnrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(System.Decimal _integMoodleEnrolId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleEnrolId(null, _integMoodleEnrolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleEnrolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(TransactionManager transactionManager, System.Decimal _integMoodleEnrolId)
		{
			int count = -1;
			return GetByIntegMoodleEnrolId(transactionManager, _integMoodleEnrolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleEnrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(TransactionManager transactionManager, System.Decimal _integMoodleEnrolId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleEnrolId(transactionManager, _integMoodleEnrolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="_integMoodleEnrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(System.Decimal _integMoodleEnrolId, int start, int pageLength, out int count)
		{
			return GetByIntegMoodleEnrolId(null, _integMoodleEnrolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_ENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleEnrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegMoodleEnrol GetByIntegMoodleEnrolId(TransactionManager transactionManager, System.Decimal _integMoodleEnrolId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegMoodleEnrol&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegMoodleEnrol&gt;"/></returns>
		public static TList<IntegMoodleEnrol> Fill(IDataReader reader, TList<IntegMoodleEnrol> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegMoodleEnrol c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegMoodleEnrol")
					.Append("|").Append((System.Decimal)reader["INTEG_MOODLE_ENROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegMoodleEnrol>(
					key.ToString(), // EntityTrackingKey
					"IntegMoodleEnrol",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegMoodleEnrol();
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
					c.IntegMoodleEnrolId = (System.Decimal)reader["INTEG_MOODLE_ENROL_ID"];
					c.CourseCode = (System.String)reader["COURSE_CODE"];
					c.Code = (System.String)reader["CODE"];
					c.UserType = (System.Int32)reader["USER_TYPE"];
					c.IsEnrol = (System.Int32)reader["IS_ENROL"];
					c.SemId = (System.Int32)reader["SEM_ID"];
					c.YearId = (System.Int32)reader["YEAR_ID"];
					c.DeptId = Convert.IsDBNull(reader["DeptId"]) ? null : (System.Int32?)reader["DeptId"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegMoodleEnrol entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegMoodleEnrolId = (System.Decimal)reader[((int)IntegMoodleEnrolColumn.IntegMoodleEnrolId - 1)];
			entity.CourseCode = (System.String)reader[((int)IntegMoodleEnrolColumn.CourseCode - 1)];
			entity.Code = (System.String)reader[((int)IntegMoodleEnrolColumn.Code - 1)];
			entity.UserType = (System.Int32)reader[((int)IntegMoodleEnrolColumn.UserType - 1)];
			entity.IsEnrol = (System.Int32)reader[((int)IntegMoodleEnrolColumn.IsEnrol - 1)];
			entity.SemId = (System.Int32)reader[((int)IntegMoodleEnrolColumn.SemId - 1)];
			entity.YearId = (System.Int32)reader[((int)IntegMoodleEnrolColumn.YearId - 1)];
			entity.DeptId = (reader.IsDBNull(((int)IntegMoodleEnrolColumn.DeptId - 1)))?null:(System.Int32?)reader[((int)IntegMoodleEnrolColumn.DeptId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegMoodleEnrol entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegMoodleEnrolId = (System.Decimal)dataRow["INTEG_MOODLE_ENROL_ID"];
			entity.CourseCode = (System.String)dataRow["COURSE_CODE"];
			entity.Code = (System.String)dataRow["CODE"];
			entity.UserType = (System.Int32)dataRow["USER_TYPE"];
			entity.IsEnrol = (System.Int32)dataRow["IS_ENROL"];
			entity.SemId = (System.Int32)dataRow["SEM_ID"];
			entity.YearId = (System.Int32)dataRow["YEAR_ID"];
			entity.DeptId = Convert.IsDBNull(dataRow["DeptId"]) ? null : (System.Int32?)dataRow["DeptId"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleEnrol"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleEnrol Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleEnrol entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegMoodleEnrol object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegMoodleEnrol instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleEnrol Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleEnrol entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region IntegMoodleEnrolChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegMoodleEnrol</c>
	///</summary>
	public enum IntegMoodleEnrolChildEntityTypes
	{
	}
	
	#endregion IntegMoodleEnrolChildEntityTypes
	
	#region IntegMoodleEnrolFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegMoodleEnrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleEnrol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleEnrolFilterBuilder : SqlFilterBuilder<IntegMoodleEnrolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolFilterBuilder class.
		/// </summary>
		public IntegMoodleEnrolFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleEnrolFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleEnrolFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleEnrolFilterBuilder
	
	#region IntegMoodleEnrolParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegMoodleEnrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleEnrol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleEnrolParameterBuilder : ParameterizedSqlFilterBuilder<IntegMoodleEnrolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolParameterBuilder class.
		/// </summary>
		public IntegMoodleEnrolParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleEnrolParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleEnrolParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleEnrolParameterBuilder
	
	#region IntegMoodleEnrolSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegMoodleEnrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleEnrol"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegMoodleEnrolSortBuilder : SqlSortBuilder<IntegMoodleEnrolColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleEnrolSqlSortBuilder class.
		/// </summary>
		public IntegMoodleEnrolSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegMoodleEnrolSortBuilder
	
} // end namespace
