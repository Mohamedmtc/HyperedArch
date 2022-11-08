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
	/// This class is the base class for any <see cref="IntegPaymentUpayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegPaymentUpayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegPaymentUpay, UMIS_VER2.BusinessLyer.IntegPaymentUpayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegPaymentUpayKey key)
		{
			return Delete(transactionManager, key.IntegPaymentUpayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integPaymentUpayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integPaymentUpayId)
		{
			return Delete(null, _integPaymentUpayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integPaymentUpayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integPaymentUpayId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegPaymentUpay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegPaymentUpayKey key, int start, int pageLength)
		{
			return GetByIntegPaymentUpayId(transactionManager, key.IntegPaymentUpayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="_integPaymentUpayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(System.Decimal _integPaymentUpayId)
		{
			int count = -1;
			return GetByIntegPaymentUpayId(null,_integPaymentUpayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="_integPaymentUpayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(System.Decimal _integPaymentUpayId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegPaymentUpayId(null, _integPaymentUpayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integPaymentUpayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(TransactionManager transactionManager, System.Decimal _integPaymentUpayId)
		{
			int count = -1;
			return GetByIntegPaymentUpayId(transactionManager, _integPaymentUpayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integPaymentUpayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(TransactionManager transactionManager, System.Decimal _integPaymentUpayId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegPaymentUpayId(transactionManager, _integPaymentUpayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="_integPaymentUpayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(System.Decimal _integPaymentUpayId, int start, int pageLength, out int count)
		{
			return GetByIntegPaymentUpayId(null, _integPaymentUpayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_Payment_UPay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integPaymentUpayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegPaymentUpay GetByIntegPaymentUpayId(TransactionManager transactionManager, System.Decimal _integPaymentUpayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegPaymentUpay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegPaymentUpay&gt;"/></returns>
		public static TList<IntegPaymentUpay> Fill(IDataReader reader, TList<IntegPaymentUpay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegPaymentUpay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegPaymentUpay")
					.Append("|").Append((System.Decimal)reader["INTEG_Payment_UPay_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegPaymentUpay>(
					key.ToString(), // EntityTrackingKey
					"IntegPaymentUpay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegPaymentUpay();
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
					c.IntegPaymentUpayId = (System.Decimal)reader["INTEG_Payment_UPay_ID"];
					c.StudFacultyCode = (System.String)reader["STUD_FACULTY_CODE"];
					c.FeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
					c.IsPaid = (System.Int32)reader["IS_Paid"];
					c.PaymentMethodId = Convert.IsDBNull(reader["Payment_Method_ID"]) ? null : (System.Decimal?)reader["Payment_Method_ID"];
					c.Amount = (System.Decimal)reader["Amount"];
					c.UpayOrderId = Convert.IsDBNull(reader["UPay_Order_Id"]) ? null : (System.String)reader["UPay_Order_Id"];
					c.UpayPaymentCode = Convert.IsDBNull(reader["UPay_Payment_Code"]) ? null : (System.String)reader["UPay_Payment_Code"];
					c.Auth = Convert.IsDBNull(reader["Auth"]) ? null : (System.String)reader["Auth"];
					c.PostDate = Convert.IsDBNull(reader["Post_Date"]) ? null : (System.String)reader["Post_Date"];
					c.SafeNameRef = Convert.IsDBNull(reader["Ref"]) ? null : (System.String)reader["Ref"];
					c.Result = Convert.IsDBNull(reader["Result"]) ? null : (System.String)reader["Result"];
					c.TrackId = Convert.IsDBNull(reader["Track_ID"]) ? null : (System.String)reader["Track_ID"];
					c.TranId = Convert.IsDBNull(reader["Tran_ID"]) ? null : (System.String)reader["Tran_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegPaymentUpay entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegPaymentUpayId = (System.Decimal)reader[((int)IntegPaymentUpayColumn.IntegPaymentUpayId - 1)];
			entity.StudFacultyCode = (System.String)reader[((int)IntegPaymentUpayColumn.StudFacultyCode - 1)];
			entity.FeeStudVoucherId = (System.Decimal)reader[((int)IntegPaymentUpayColumn.FeeStudVoucherId - 1)];
			entity.IsPaid = (System.Int32)reader[((int)IntegPaymentUpayColumn.IsPaid - 1)];
			entity.PaymentMethodId = (reader.IsDBNull(((int)IntegPaymentUpayColumn.PaymentMethodId - 1)))?null:(System.Decimal?)reader[((int)IntegPaymentUpayColumn.PaymentMethodId - 1)];
			entity.Amount = (System.Decimal)reader[((int)IntegPaymentUpayColumn.Amount - 1)];
			entity.UpayOrderId = (reader.IsDBNull(((int)IntegPaymentUpayColumn.UpayOrderId - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.UpayOrderId - 1)];
			entity.UpayPaymentCode = (reader.IsDBNull(((int)IntegPaymentUpayColumn.UpayPaymentCode - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.UpayPaymentCode - 1)];
			entity.Auth = (reader.IsDBNull(((int)IntegPaymentUpayColumn.Auth - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.Auth - 1)];
			entity.PostDate = (reader.IsDBNull(((int)IntegPaymentUpayColumn.PostDate - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.PostDate - 1)];
			entity.SafeNameRef = (reader.IsDBNull(((int)IntegPaymentUpayColumn.SafeNameRef - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.SafeNameRef - 1)];
			entity.Result = (reader.IsDBNull(((int)IntegPaymentUpayColumn.Result - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.Result - 1)];
			entity.TrackId = (reader.IsDBNull(((int)IntegPaymentUpayColumn.TrackId - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.TrackId - 1)];
			entity.TranId = (reader.IsDBNull(((int)IntegPaymentUpayColumn.TranId - 1)))?null:(System.String)reader[((int)IntegPaymentUpayColumn.TranId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegPaymentUpay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegPaymentUpayId = (System.Decimal)dataRow["INTEG_Payment_UPay_ID"];
			entity.StudFacultyCode = (System.String)dataRow["STUD_FACULTY_CODE"];
			entity.FeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.IsPaid = (System.Int32)dataRow["IS_Paid"];
			entity.PaymentMethodId = Convert.IsDBNull(dataRow["Payment_Method_ID"]) ? null : (System.Decimal?)dataRow["Payment_Method_ID"];
			entity.Amount = (System.Decimal)dataRow["Amount"];
			entity.UpayOrderId = Convert.IsDBNull(dataRow["UPay_Order_Id"]) ? null : (System.String)dataRow["UPay_Order_Id"];
			entity.UpayPaymentCode = Convert.IsDBNull(dataRow["UPay_Payment_Code"]) ? null : (System.String)dataRow["UPay_Payment_Code"];
			entity.Auth = Convert.IsDBNull(dataRow["Auth"]) ? null : (System.String)dataRow["Auth"];
			entity.PostDate = Convert.IsDBNull(dataRow["Post_Date"]) ? null : (System.String)dataRow["Post_Date"];
			entity.SafeNameRef = Convert.IsDBNull(dataRow["Ref"]) ? null : (System.String)dataRow["Ref"];
			entity.Result = Convert.IsDBNull(dataRow["Result"]) ? null : (System.String)dataRow["Result"];
			entity.TrackId = Convert.IsDBNull(dataRow["Track_ID"]) ? null : (System.String)dataRow["Track_ID"];
			entity.TranId = Convert.IsDBNull(dataRow["Tran_ID"]) ? null : (System.String)dataRow["Tran_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegPaymentUpay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegPaymentUpay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegPaymentUpay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegPaymentUpay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegPaymentUpay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegPaymentUpay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegPaymentUpay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region IntegPaymentUpayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegPaymentUpay</c>
	///</summary>
	public enum IntegPaymentUpayChildEntityTypes
	{
	}
	
	#endregion IntegPaymentUpayChildEntityTypes
	
	#region IntegPaymentUpayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegPaymentUpayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegPaymentUpay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegPaymentUpayFilterBuilder : SqlFilterBuilder<IntegPaymentUpayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayFilterBuilder class.
		/// </summary>
		public IntegPaymentUpayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegPaymentUpayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegPaymentUpayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegPaymentUpayFilterBuilder
	
	#region IntegPaymentUpayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegPaymentUpayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegPaymentUpay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegPaymentUpayParameterBuilder : ParameterizedSqlFilterBuilder<IntegPaymentUpayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayParameterBuilder class.
		/// </summary>
		public IntegPaymentUpayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegPaymentUpayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegPaymentUpayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegPaymentUpayParameterBuilder
	
	#region IntegPaymentUpaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegPaymentUpayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegPaymentUpay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegPaymentUpaySortBuilder : SqlSortBuilder<IntegPaymentUpayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegPaymentUpaySqlSortBuilder class.
		/// </summary>
		public IntegPaymentUpaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegPaymentUpaySortBuilder
	
} // end namespace
