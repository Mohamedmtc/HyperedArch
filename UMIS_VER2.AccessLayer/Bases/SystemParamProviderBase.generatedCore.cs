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
	/// This class is the base class for any <see cref="SystemParamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SystemParamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SystemParam, UMIS_VER2.BusinessLyer.SystemParamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SystemParamKey key)
		{
			return Delete(transactionManager, key.SystemParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _systemParamId)
		{
			return Delete(null, _systemParamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _systemParamId);		
		
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
		public override UMIS_VER2.BusinessLyer.SystemParam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SystemParamKey key, int start, int pageLength)
		{
			return GetBySystemParamId(transactionManager, key.SystemParamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(System.Decimal _systemParamId)
		{
			int count = -1;
			return GetBySystemParamId(null,_systemParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(System.Decimal _systemParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySystemParamId(null, _systemParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(TransactionManager transactionManager, System.Decimal _systemParamId)
		{
			int count = -1;
			return GetBySystemParamId(transactionManager, _systemParamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(TransactionManager transactionManager, System.Decimal _systemParamId, int start, int pageLength)
		{
			int count = -1;
			return GetBySystemParamId(transactionManager, _systemParamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(System.Decimal _systemParamId, int start, int pageLength, out int count)
		{
			return GetBySystemParamId(null, _systemParamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SYSTEM_PARAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_systemParamId">XXXXXXXXXXXXXXXXXXXXXXXXXx to be deleted</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SystemParam GetBySystemParamId(TransactionManager transactionManager, System.Decimal _systemParamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SystemParam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SystemParam&gt;"/></returns>
		public static TList<SystemParam> Fill(IDataReader reader, TList<SystemParam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SystemParam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SystemParam")
					.Append("|").Append((System.Decimal)reader["SYSTEM_PARAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SystemParam>(
					key.ToString(), // EntityTrackingKey
					"SystemParam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SystemParam();
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
					c.SystemParamId = (System.Decimal)reader["SYSTEM_PARAM_ID"];
					c.OriginalSystemParamId = c.SystemParamId;
					c.BuildStudCode = (System.Decimal)reader["BUILD_STUD_CODE"];
					c.AllowCourseInstance = (System.Decimal)reader["ALLOW_COURSE_INSTANCE"];
					c.AllowCourseWaiting = (System.Decimal)reader["ALLOW_COURSE_WAITING"];
					c.AcademicLoadFlg = Convert.IsDBNull(reader["ACADEMIC_LOAD_FLG"]) ? null : (System.Decimal?)reader["ACADEMIC_LOAD_FLG"];
					c.CourseGradingFlg = Convert.IsDBNull(reader["COURSE_GRADING_FLG"]) ? null : (System.Decimal?)reader["COURSE_GRADING_FLG"];
					c.UploadFolderPath = Convert.IsDBNull(reader["UPLOAD_FOLDER_PATH"]) ? null : (System.String)reader["UPLOAD_FOLDER_PATH"];
					c.BylawApproveFlg = Convert.IsDBNull(reader["BYLAW_APPROVE_FLG"]) ? null : (System.Decimal?)reader["BYLAW_APPROVE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SystemParam entity)
		{
			if (!reader.Read()) return;
			
			entity.SystemParamId = (System.Decimal)reader[((int)SystemParamColumn.SystemParamId - 1)];
			entity.OriginalSystemParamId = (System.Decimal)reader["SYSTEM_PARAM_ID"];
			entity.BuildStudCode = (System.Decimal)reader[((int)SystemParamColumn.BuildStudCode - 1)];
			entity.AllowCourseInstance = (System.Decimal)reader[((int)SystemParamColumn.AllowCourseInstance - 1)];
			entity.AllowCourseWaiting = (System.Decimal)reader[((int)SystemParamColumn.AllowCourseWaiting - 1)];
			entity.AcademicLoadFlg = (reader.IsDBNull(((int)SystemParamColumn.AcademicLoadFlg - 1)))?null:(System.Decimal?)reader[((int)SystemParamColumn.AcademicLoadFlg - 1)];
			entity.CourseGradingFlg = (reader.IsDBNull(((int)SystemParamColumn.CourseGradingFlg - 1)))?null:(System.Decimal?)reader[((int)SystemParamColumn.CourseGradingFlg - 1)];
			entity.UploadFolderPath = (reader.IsDBNull(((int)SystemParamColumn.UploadFolderPath - 1)))?null:(System.String)reader[((int)SystemParamColumn.UploadFolderPath - 1)];
			entity.BylawApproveFlg = (reader.IsDBNull(((int)SystemParamColumn.BylawApproveFlg - 1)))?null:(System.Decimal?)reader[((int)SystemParamColumn.BylawApproveFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SystemParam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SystemParamId = (System.Decimal)dataRow["SYSTEM_PARAM_ID"];
			entity.OriginalSystemParamId = (System.Decimal)dataRow["SYSTEM_PARAM_ID"];
			entity.BuildStudCode = (System.Decimal)dataRow["BUILD_STUD_CODE"];
			entity.AllowCourseInstance = (System.Decimal)dataRow["ALLOW_COURSE_INSTANCE"];
			entity.AllowCourseWaiting = (System.Decimal)dataRow["ALLOW_COURSE_WAITING"];
			entity.AcademicLoadFlg = Convert.IsDBNull(dataRow["ACADEMIC_LOAD_FLG"]) ? null : (System.Decimal?)dataRow["ACADEMIC_LOAD_FLG"];
			entity.CourseGradingFlg = Convert.IsDBNull(dataRow["COURSE_GRADING_FLG"]) ? null : (System.Decimal?)dataRow["COURSE_GRADING_FLG"];
			entity.UploadFolderPath = Convert.IsDBNull(dataRow["UPLOAD_FOLDER_PATH"]) ? null : (System.String)dataRow["UPLOAD_FOLDER_PATH"];
			entity.BylawApproveFlg = Convert.IsDBNull(dataRow["BYLAW_APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["BYLAW_APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SystemParam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SystemParam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SystemParam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SystemParam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SystemParam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SystemParam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SystemParam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SystemParamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SystemParam</c>
	///</summary>
	public enum SystemParamChildEntityTypes
	{
	}
	
	#endregion SystemParamChildEntityTypes
	
	#region SystemParamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SystemParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SystemParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SystemParamFilterBuilder : SqlFilterBuilder<SystemParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SystemParamFilterBuilder class.
		/// </summary>
		public SystemParamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SystemParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SystemParamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SystemParamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SystemParamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SystemParamFilterBuilder
	
	#region SystemParamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SystemParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SystemParam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SystemParamParameterBuilder : ParameterizedSqlFilterBuilder<SystemParamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SystemParamParameterBuilder class.
		/// </summary>
		public SystemParamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SystemParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SystemParamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SystemParamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SystemParamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SystemParamParameterBuilder
	
	#region SystemParamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SystemParamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SystemParam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SystemParamSortBuilder : SqlSortBuilder<SystemParamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SystemParamSqlSortBuilder class.
		/// </summary>
		public SystemParamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SystemParamSortBuilder
	
} // end namespace
