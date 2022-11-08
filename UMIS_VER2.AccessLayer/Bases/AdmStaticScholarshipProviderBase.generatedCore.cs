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
	/// This class is the base class for any <see cref="AdmStaticScholarshipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmStaticScholarshipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmStaticScholarship, UMIS_VER2.BusinessLyer.AdmStaticScholarshipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmStaticScholarshipKey key)
		{
			return Delete(transactionManager, key.AdmStaticScholarshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admStaticScholarshipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admStaticScholarshipId)
		{
			return Delete(null, _admStaticScholarshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admStaticScholarshipId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admStaticScholarshipId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmStaticScholarship Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmStaticScholarshipKey key, int start, int pageLength)
		{
			return GetByAdmStaticScholarshipId(transactionManager, key.AdmStaticScholarshipId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_admStaticScholarshipId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(System.Decimal _admStaticScholarshipId)
		{
			int count = -1;
			return GetByAdmStaticScholarshipId(null,_admStaticScholarshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_admStaticScholarshipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(System.Decimal _admStaticScholarshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmStaticScholarshipId(null, _admStaticScholarshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admStaticScholarshipId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(TransactionManager transactionManager, System.Decimal _admStaticScholarshipId)
		{
			int count = -1;
			return GetByAdmStaticScholarshipId(transactionManager, _admStaticScholarshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admStaticScholarshipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(TransactionManager transactionManager, System.Decimal _admStaticScholarshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmStaticScholarshipId(transactionManager, _admStaticScholarshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_admStaticScholarshipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(System.Decimal _admStaticScholarshipId, int start, int pageLength, out int count)
		{
			return GetByAdmStaticScholarshipId(null, _admStaticScholarshipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_STATIC_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admStaticScholarshipId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmStaticScholarship GetByAdmStaticScholarshipId(TransactionManager transactionManager, System.Decimal _admStaticScholarshipId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmStaticScholarship&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmStaticScholarship&gt;"/></returns>
		public static TList<AdmStaticScholarship> Fill(IDataReader reader, TList<AdmStaticScholarship> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmStaticScholarship c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmStaticScholarship")
					.Append("|").Append((System.Decimal)reader["ADM_STATIC_SCHOLARSHIP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmStaticScholarship>(
					key.ToString(), // EntityTrackingKey
					"AdmStaticScholarship",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmStaticScholarship();
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
					c.AdmStaticScholarshipId = (System.Decimal)reader["ADM_STATIC_SCHOLARSHIP_ID"];
					c.OriginalAdmStaticScholarshipId = c.AdmStaticScholarshipId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DeductionAr = Convert.IsDBNull(reader["DEDUCTION_AR"]) ? null : (System.String)reader["DEDUCTION_AR"];
					c.DeductionEn = Convert.IsDBNull(reader["DEDUCTION_EN"]) ? null : (System.String)reader["DEDUCTION_EN"];
					c.DelFlg = Convert.IsDBNull(reader["DEL_FLG"]) ? null : (System.Decimal?)reader["DEL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmStaticScholarship entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmStaticScholarshipId = (System.Decimal)reader[((int)AdmStaticScholarshipColumn.AdmStaticScholarshipId - 1)];
			entity.OriginalAdmStaticScholarshipId = (System.Decimal)reader["ADM_STATIC_SCHOLARSHIP_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)AdmStaticScholarshipColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmStaticScholarshipColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmStaticScholarshipColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmStaticScholarshipColumn.DescrEn - 1)];
			entity.DeductionAr = (reader.IsDBNull(((int)AdmStaticScholarshipColumn.DeductionAr - 1)))?null:(System.String)reader[((int)AdmStaticScholarshipColumn.DeductionAr - 1)];
			entity.DeductionEn = (reader.IsDBNull(((int)AdmStaticScholarshipColumn.DeductionEn - 1)))?null:(System.String)reader[((int)AdmStaticScholarshipColumn.DeductionEn - 1)];
			entity.DelFlg = (reader.IsDBNull(((int)AdmStaticScholarshipColumn.DelFlg - 1)))?null:(System.Decimal?)reader[((int)AdmStaticScholarshipColumn.DelFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmStaticScholarship entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmStaticScholarshipId = (System.Decimal)dataRow["ADM_STATIC_SCHOLARSHIP_ID"];
			entity.OriginalAdmStaticScholarshipId = (System.Decimal)dataRow["ADM_STATIC_SCHOLARSHIP_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DeductionAr = Convert.IsDBNull(dataRow["DEDUCTION_AR"]) ? null : (System.String)dataRow["DEDUCTION_AR"];
			entity.DeductionEn = Convert.IsDBNull(dataRow["DEDUCTION_EN"]) ? null : (System.String)dataRow["DEDUCTION_EN"];
			entity.DelFlg = Convert.IsDBNull(dataRow["DEL_FLG"]) ? null : (System.Decimal?)dataRow["DEL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmStaticScholarship"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmStaticScholarship Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmStaticScholarship entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmStaticScholarship object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmStaticScholarship instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmStaticScholarship Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmStaticScholarship entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region AdmStaticScholarshipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmStaticScholarship</c>
	///</summary>
	public enum AdmStaticScholarshipChildEntityTypes
	{
	}
	
	#endregion AdmStaticScholarshipChildEntityTypes
	
	#region AdmStaticScholarshipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmStaticScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmStaticScholarship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmStaticScholarshipFilterBuilder : SqlFilterBuilder<AdmStaticScholarshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipFilterBuilder class.
		/// </summary>
		public AdmStaticScholarshipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmStaticScholarshipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmStaticScholarshipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmStaticScholarshipFilterBuilder
	
	#region AdmStaticScholarshipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmStaticScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmStaticScholarship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmStaticScholarshipParameterBuilder : ParameterizedSqlFilterBuilder<AdmStaticScholarshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipParameterBuilder class.
		/// </summary>
		public AdmStaticScholarshipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmStaticScholarshipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmStaticScholarshipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmStaticScholarshipParameterBuilder
	
	#region AdmStaticScholarshipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmStaticScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmStaticScholarship"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmStaticScholarshipSortBuilder : SqlSortBuilder<AdmStaticScholarshipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmStaticScholarshipSqlSortBuilder class.
		/// </summary>
		public AdmStaticScholarshipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmStaticScholarshipSortBuilder
	
} // end namespace
