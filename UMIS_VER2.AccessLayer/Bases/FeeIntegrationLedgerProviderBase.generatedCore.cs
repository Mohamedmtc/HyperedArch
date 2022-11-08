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
	/// This class is the base class for any <see cref="FeeIntegrationLedgerProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeIntegrationLedgerProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeIntegrationLedger, UMIS_VER2.BusinessLyer.FeeIntegrationLedgerKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeIntegrationLedgerKey key)
		{
			return Delete(transactionManager, key.BatchNo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_batchNo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _batchNo)
		{
			return Delete(null, _batchNo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_batchNo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _batchNo);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeIntegrationLedger Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeIntegrationLedgerKey key, int start, int pageLength)
		{
			return GetByBatchNo(transactionManager, key.BatchNo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="_batchNo"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(System.Decimal _batchNo)
		{
			int count = -1;
			return GetByBatchNo(null,_batchNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="_batchNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(System.Decimal _batchNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBatchNo(null, _batchNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_batchNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(TransactionManager transactionManager, System.Decimal _batchNo)
		{
			int count = -1;
			return GetByBatchNo(transactionManager, _batchNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_batchNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(TransactionManager transactionManager, System.Decimal _batchNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBatchNo(transactionManager, _batchNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="_batchNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(System.Decimal _batchNo, int start, int pageLength, out int count)
		{
			return GetByBatchNo(null, _batchNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Fee_Integration_Ledger index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_batchNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeIntegrationLedger GetByBatchNo(TransactionManager transactionManager, System.Decimal _batchNo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeIntegrationLedger&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeIntegrationLedger&gt;"/></returns>
		public static TList<FeeIntegrationLedger> Fill(IDataReader reader, TList<FeeIntegrationLedger> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeIntegrationLedger c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeIntegrationLedger")
					.Append("|").Append((System.Decimal)reader["BatchNo"]).ToString();
					c = EntityManager.LocateOrCreate<FeeIntegrationLedger>(
					key.ToString(), // EntityTrackingKey
					"FeeIntegrationLedger",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeIntegrationLedger();
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
					c.BatchNo = (System.Decimal)reader["BatchNo"];
					c.OriginalBatchNo = c.BatchNo;
					c.Source = Convert.IsDBNull(reader["Source"]) ? null : (System.String)reader["Source"];
					c.Reference = Convert.IsDBNull(reader["Reference"]) ? null : (System.String)reader["Reference"];
					c.LineNumber = Convert.IsDBNull(reader["LineNumber"]) ? null : (System.Decimal?)reader["LineNumber"];
					c.AccountType = Convert.IsDBNull(reader["AccountType"]) ? null : (System.String)reader["AccountType"];
					c.AccountNumber = Convert.IsDBNull(reader["AccountNumber"]) ? null : (System.String)reader["AccountNumber"];
					c.CostCenter = Convert.IsDBNull(reader["CostCenter"]) ? null : (System.String)reader["CostCenter"];
					c.Division = Convert.IsDBNull(reader["Division"]) ? null : (System.String)reader["Division"];
					c.Currency = Convert.IsDBNull(reader["Currency"]) ? null : (System.String)reader["Currency"];
					c.AmountCurDebit = Convert.IsDBNull(reader["AmountCurDebit"]) ? null : (System.Decimal?)reader["AmountCurDebit"];
					c.AmountCurCredit = Convert.IsDBNull(reader["AmountCurCredit"]) ? null : (System.Decimal?)reader["AmountCurCredit"];
					c.AccountingDate = Convert.IsDBNull(reader["AccountingDate"]) ? null : (System.DateTime?)reader["AccountingDate"];
					c.PaymentType = Convert.IsDBNull(reader["PaymentType"]) ? null : (System.String)reader["PaymentType"];
					c.CheckNum = Convert.IsDBNull(reader["CheckNum"]) ? null : (System.String)reader["CheckNum"];
					c.CheckDueDate = Convert.IsDBNull(reader["CheckDueDate"]) ? null : (System.DateTime?)reader["CheckDueDate"];
					c.IsIntegrated = Convert.IsDBNull(reader["Is_Integrated"]) ? null : (System.Boolean?)reader["Is_Integrated"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeIntegrationLedger entity)
		{
			if (!reader.Read()) return;
			
			entity.BatchNo = (System.Decimal)reader[((int)FeeIntegrationLedgerColumn.BatchNo - 1)];
			entity.OriginalBatchNo = (System.Decimal)reader["BatchNo"];
			entity.Source = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.Source - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.Source - 1)];
			entity.Reference = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.Reference - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.Reference - 1)];
			entity.LineNumber = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.LineNumber - 1)))?null:(System.Decimal?)reader[((int)FeeIntegrationLedgerColumn.LineNumber - 1)];
			entity.AccountType = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.AccountType - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.AccountType - 1)];
			entity.AccountNumber = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.AccountNumber - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.AccountNumber - 1)];
			entity.CostCenter = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.CostCenter - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.CostCenter - 1)];
			entity.Division = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.Division - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.Division - 1)];
			entity.Currency = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.Currency - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.Currency - 1)];
			entity.AmountCurDebit = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.AmountCurDebit - 1)))?null:(System.Decimal?)reader[((int)FeeIntegrationLedgerColumn.AmountCurDebit - 1)];
			entity.AmountCurCredit = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.AmountCurCredit - 1)))?null:(System.Decimal?)reader[((int)FeeIntegrationLedgerColumn.AmountCurCredit - 1)];
			entity.AccountingDate = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.AccountingDate - 1)))?null:(System.DateTime?)reader[((int)FeeIntegrationLedgerColumn.AccountingDate - 1)];
			entity.PaymentType = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.PaymentType - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.PaymentType - 1)];
			entity.CheckNum = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.CheckNum - 1)))?null:(System.String)reader[((int)FeeIntegrationLedgerColumn.CheckNum - 1)];
			entity.CheckDueDate = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.CheckDueDate - 1)))?null:(System.DateTime?)reader[((int)FeeIntegrationLedgerColumn.CheckDueDate - 1)];
			entity.IsIntegrated = (reader.IsDBNull(((int)FeeIntegrationLedgerColumn.IsIntegrated - 1)))?null:(System.Boolean?)reader[((int)FeeIntegrationLedgerColumn.IsIntegrated - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeIntegrationLedger entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.BatchNo = (System.Decimal)dataRow["BatchNo"];
			entity.OriginalBatchNo = (System.Decimal)dataRow["BatchNo"];
			entity.Source = Convert.IsDBNull(dataRow["Source"]) ? null : (System.String)dataRow["Source"];
			entity.Reference = Convert.IsDBNull(dataRow["Reference"]) ? null : (System.String)dataRow["Reference"];
			entity.LineNumber = Convert.IsDBNull(dataRow["LineNumber"]) ? null : (System.Decimal?)dataRow["LineNumber"];
			entity.AccountType = Convert.IsDBNull(dataRow["AccountType"]) ? null : (System.String)dataRow["AccountType"];
			entity.AccountNumber = Convert.IsDBNull(dataRow["AccountNumber"]) ? null : (System.String)dataRow["AccountNumber"];
			entity.CostCenter = Convert.IsDBNull(dataRow["CostCenter"]) ? null : (System.String)dataRow["CostCenter"];
			entity.Division = Convert.IsDBNull(dataRow["Division"]) ? null : (System.String)dataRow["Division"];
			entity.Currency = Convert.IsDBNull(dataRow["Currency"]) ? null : (System.String)dataRow["Currency"];
			entity.AmountCurDebit = Convert.IsDBNull(dataRow["AmountCurDebit"]) ? null : (System.Decimal?)dataRow["AmountCurDebit"];
			entity.AmountCurCredit = Convert.IsDBNull(dataRow["AmountCurCredit"]) ? null : (System.Decimal?)dataRow["AmountCurCredit"];
			entity.AccountingDate = Convert.IsDBNull(dataRow["AccountingDate"]) ? null : (System.DateTime?)dataRow["AccountingDate"];
			entity.PaymentType = Convert.IsDBNull(dataRow["PaymentType"]) ? null : (System.String)dataRow["PaymentType"];
			entity.CheckNum = Convert.IsDBNull(dataRow["CheckNum"]) ? null : (System.String)dataRow["CheckNum"];
			entity.CheckDueDate = Convert.IsDBNull(dataRow["CheckDueDate"]) ? null : (System.DateTime?)dataRow["CheckDueDate"];
			entity.IsIntegrated = Convert.IsDBNull(dataRow["Is_Integrated"]) ? null : (System.Boolean?)dataRow["Is_Integrated"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeIntegrationLedger"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeIntegrationLedger Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeIntegrationLedger entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeIntegrationLedger object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeIntegrationLedger instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeIntegrationLedger Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeIntegrationLedger entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region FeeIntegrationLedgerChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeIntegrationLedger</c>
	///</summary>
	public enum FeeIntegrationLedgerChildEntityTypes
	{
	}
	
	#endregion FeeIntegrationLedgerChildEntityTypes
	
	#region FeeIntegrationLedgerFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeIntegrationLedgerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeIntegrationLedger"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeIntegrationLedgerFilterBuilder : SqlFilterBuilder<FeeIntegrationLedgerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerFilterBuilder class.
		/// </summary>
		public FeeIntegrationLedgerFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeIntegrationLedgerFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeIntegrationLedgerFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeIntegrationLedgerFilterBuilder
	
	#region FeeIntegrationLedgerParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeIntegrationLedgerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeIntegrationLedger"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeIntegrationLedgerParameterBuilder : ParameterizedSqlFilterBuilder<FeeIntegrationLedgerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerParameterBuilder class.
		/// </summary>
		public FeeIntegrationLedgerParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeIntegrationLedgerParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeIntegrationLedgerParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeIntegrationLedgerParameterBuilder
	
	#region FeeIntegrationLedgerSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeIntegrationLedgerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeIntegrationLedger"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeIntegrationLedgerSortBuilder : SqlSortBuilder<FeeIntegrationLedgerColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeIntegrationLedgerSqlSortBuilder class.
		/// </summary>
		public FeeIntegrationLedgerSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeIntegrationLedgerSortBuilder
	
} // end namespace
