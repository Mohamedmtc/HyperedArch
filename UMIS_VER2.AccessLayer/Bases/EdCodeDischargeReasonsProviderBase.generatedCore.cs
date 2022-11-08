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
	/// This class is the base class for any <see cref="EdCodeDischargeReasonsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeDischargeReasonsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeDischargeReasons, UMIS_VER2.BusinessLyer.EdCodeDischargeReasonsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeReasonsKey key)
		{
			return Delete(transactionManager, key.EdCodeDischReasonsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeDischReasonsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeDischReasonsId)
		{
			return Delete(null, _edCodeDischReasonsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischReasonsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeDischReasonsId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeDischargeReasons Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeReasonsKey key, int start, int pageLength)
		{
			return GetByEdCodeDischReasonsId(transactionManager, key.EdCodeDischReasonsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(System.Decimal _edCodeDischReasonsId)
		{
			int count = -1;
			return GetByEdCodeDischReasonsId(null,_edCodeDischReasonsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(System.Decimal _edCodeDischReasonsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischReasonsId(null, _edCodeDischReasonsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(TransactionManager transactionManager, System.Decimal _edCodeDischReasonsId)
		{
			int count = -1;
			return GetByEdCodeDischReasonsId(transactionManager, _edCodeDischReasonsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(TransactionManager transactionManager, System.Decimal _edCodeDischReasonsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischReasonsId(transactionManager, _edCodeDischReasonsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(System.Decimal _edCodeDischReasonsId, int start, int pageLength, out int count)
		{
			return GetByEdCodeDischReasonsId(null, _edCodeDischReasonsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_REASONS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischReasonsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeDischargeReasons GetByEdCodeDischReasonsId(TransactionManager transactionManager, System.Decimal _edCodeDischReasonsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeDischargeReasons&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeDischargeReasons&gt;"/></returns>
		public static TList<EdCodeDischargeReasons> Fill(IDataReader reader, TList<EdCodeDischargeReasons> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeDischargeReasons c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeDischargeReasons")
					.Append("|").Append((System.Decimal)reader["ED_CODE_DISCH_REASONS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeDischargeReasons>(
					key.ToString(), // EntityTrackingKey
					"EdCodeDischargeReasons",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeDischargeReasons();
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
					c.EdCodeDischReasonsId = (System.Decimal)reader["ED_CODE_DISCH_REASONS_ID"];
					c.OriginalEdCodeDischReasonsId = c.EdCodeDischReasonsId;
					c.ReasonsDescAr = (System.String)reader["REASONS_DESC_AR"];
					c.ReasonsDescEn = Convert.IsDBNull(reader["REASONS_DESC_EN"]) ? null : (System.String)reader["REASONS_DESC_EN"];
					c.SignHeader = Convert.IsDBNull(reader["SIGN_HEADER"]) ? null : (System.String)reader["SIGN_HEADER"];
					c.SignFooter = Convert.IsDBNull(reader["SIGN_FOOTER"]) ? null : (System.String)reader["SIGN_FOOTER"];
					c.GsCodeSysId = Convert.IsDBNull(reader["GS_CODE_SYS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_SYS_ID"];
					c.ReasonsCode = Convert.IsDBNull(reader["REASONS_CODE"]) ? null : (System.String)reader["REASONS_CODE"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeDischargeReasons entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeDischReasonsId = (System.Decimal)reader[((int)EdCodeDischargeReasonsColumn.EdCodeDischReasonsId - 1)];
			entity.OriginalEdCodeDischReasonsId = (System.Decimal)reader["ED_CODE_DISCH_REASONS_ID"];
			entity.ReasonsDescAr = (System.String)reader[((int)EdCodeDischargeReasonsColumn.ReasonsDescAr - 1)];
			entity.ReasonsDescEn = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.ReasonsDescEn - 1)))?null:(System.String)reader[((int)EdCodeDischargeReasonsColumn.ReasonsDescEn - 1)];
			entity.SignHeader = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.SignHeader - 1)))?null:(System.String)reader[((int)EdCodeDischargeReasonsColumn.SignHeader - 1)];
			entity.SignFooter = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.SignFooter - 1)))?null:(System.String)reader[((int)EdCodeDischargeReasonsColumn.SignFooter - 1)];
			entity.GsCodeSysId = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.GsCodeSysId - 1)))?null:(System.Decimal?)reader[((int)EdCodeDischargeReasonsColumn.GsCodeSysId - 1)];
			entity.ReasonsCode = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.ReasonsCode - 1)))?null:(System.String)reader[((int)EdCodeDischargeReasonsColumn.ReasonsCode - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCodeDischargeReasonsColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCodeDischargeReasonsColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeDischargeReasons entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeDischReasonsId = (System.Decimal)dataRow["ED_CODE_DISCH_REASONS_ID"];
			entity.OriginalEdCodeDischReasonsId = (System.Decimal)dataRow["ED_CODE_DISCH_REASONS_ID"];
			entity.ReasonsDescAr = (System.String)dataRow["REASONS_DESC_AR"];
			entity.ReasonsDescEn = Convert.IsDBNull(dataRow["REASONS_DESC_EN"]) ? null : (System.String)dataRow["REASONS_DESC_EN"];
			entity.SignHeader = Convert.IsDBNull(dataRow["SIGN_HEADER"]) ? null : (System.String)dataRow["SIGN_HEADER"];
			entity.SignFooter = Convert.IsDBNull(dataRow["SIGN_FOOTER"]) ? null : (System.String)dataRow["SIGN_FOOTER"];
			entity.GsCodeSysId = Convert.IsDBNull(dataRow["GS_CODE_SYS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_SYS_ID"];
			entity.ReasonsCode = Convert.IsDBNull(dataRow["REASONS_CODE"]) ? null : (System.String)dataRow["REASONS_CODE"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeReasons"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeDischargeReasons Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeReasons entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeDischargeReasons object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeDischargeReasons instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeDischargeReasons Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeReasons entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdCodeDischargeReasonsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeDischargeReasons</c>
	///</summary>
	public enum EdCodeDischargeReasonsChildEntityTypes
	{
	}
	
	#endregion EdCodeDischargeReasonsChildEntityTypes
	
	#region EdCodeDischargeReasonsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeDischargeReasonsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeReasons"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeDischargeReasonsFilterBuilder : SqlFilterBuilder<EdCodeDischargeReasonsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsFilterBuilder class.
		/// </summary>
		public EdCodeDischargeReasonsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeDischargeReasonsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeDischargeReasonsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeDischargeReasonsFilterBuilder
	
	#region EdCodeDischargeReasonsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeDischargeReasonsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeReasons"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeDischargeReasonsParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeDischargeReasonsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsParameterBuilder class.
		/// </summary>
		public EdCodeDischargeReasonsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeDischargeReasonsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeDischargeReasonsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeDischargeReasonsParameterBuilder
	
	#region EdCodeDischargeReasonsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeDischargeReasonsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeReasons"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeDischargeReasonsSortBuilder : SqlSortBuilder<EdCodeDischargeReasonsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsSqlSortBuilder class.
		/// </summary>
		public EdCodeDischargeReasonsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeDischargeReasonsSortBuilder
	
} // end namespace
