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
	/// This class is the base class for any <see cref="FeeFundRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFundRuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFundRule, UMIS_VER2.BusinessLyer.FeeFundRuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFundRuleKey key)
		{
			return Delete(transactionManager, key.FeeFundRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFundRuleId">Fund Degree Rules. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeFundRuleId)
		{
			return Delete(null, _feeFundRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFundRuleId">Fund Degree Rules. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeFundRuleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FUND_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FUND_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFundRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FUND_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		fkFeeFundRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		fkFeeFundRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FUND_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public abstract TList<FeeFundRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		FK_FEE_FUND_RULE_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByFeeCdeFundId(System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(_feeCdeFundId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		FK_FEE_FUND_RULE_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFundRule> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		FK_FEE_FUND_RULE_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		fkFeeFundRuleFeeCdeFund Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		fkFeeFundRuleFeeCdeFund Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public TList<FeeFundRule> GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FUND_RULE_FEE_CDE_FUND key.
		///		FK_FEE_FUND_RULE_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId">Fund Codes Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFundRule objects.</returns>
		public abstract TList<FeeFundRule> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeFundRule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFundRuleKey key, int start, int pageLength)
		{
			return GetByFeeFundRuleId(transactionManager, key.FeeFundRuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(System.Int32 _feeFundRuleId)
		{
			int count = -1;
			return GetByFeeFundRuleId(null,_feeFundRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(System.Int32 _feeFundRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFundRuleId(null, _feeFundRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(TransactionManager transactionManager, System.Int32 _feeFundRuleId)
		{
			int count = -1;
			return GetByFeeFundRuleId(transactionManager, _feeFundRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(TransactionManager transactionManager, System.Int32 _feeFundRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFundRuleId(transactionManager, _feeFundRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(System.Int32 _feeFundRuleId, int start, int pageLength, out int count)
		{
			return GetByFeeFundRuleId(null, _feeFundRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FUND_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFundRuleId">Fund Degree Rules</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFundRule GetByFeeFundRuleId(TransactionManager transactionManager, System.Int32 _feeFundRuleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFundRule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFundRule&gt;"/></returns>
		public static TList<FeeFundRule> Fill(IDataReader reader, TList<FeeFundRule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFundRule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFundRule")
					.Append("|").Append((System.Int32)reader["FEE_FUND_RULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFundRule>(
					key.ToString(), // EntityTrackingKey
					"FeeFundRule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFundRule();
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
					c.FeeFundRuleId = (System.Int32)reader["FEE_FUND_RULE_ID"];
					c.OriginalFeeFundRuleId = c.FeeFundRuleId;
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.FeeCdeFundId = (System.Int32)reader["FEE_CDE_FUND_ID"];
					c.RepeatNo = Convert.IsDBNull(reader["REPEAT_NO"]) ? null : (System.Int16?)reader["REPEAT_NO"];
					c.MaxFundAmount = Convert.IsDBNull(reader["MAX_FUND_AMOUNT"]) ? null : (System.Decimal?)reader["MAX_FUND_AMOUNT"];
					c.YearFlg = Convert.IsDBNull(reader["YEAR_FLG"]) ? null : (System.Boolean?)reader["YEAR_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFundRule entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFundRuleId = (System.Int32)reader[((int)FeeFundRuleColumn.FeeFundRuleId - 1)];
			entity.OriginalFeeFundRuleId = (System.Int32)reader["FEE_FUND_RULE_ID"];
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)FeeFundRuleColumn.AsCodeDegreeId - 1)];
			entity.FeeCdeFundId = (System.Int32)reader[((int)FeeFundRuleColumn.FeeCdeFundId - 1)];
			entity.RepeatNo = (reader.IsDBNull(((int)FeeFundRuleColumn.RepeatNo - 1)))?null:(System.Int16?)reader[((int)FeeFundRuleColumn.RepeatNo - 1)];
			entity.MaxFundAmount = (reader.IsDBNull(((int)FeeFundRuleColumn.MaxFundAmount - 1)))?null:(System.Decimal?)reader[((int)FeeFundRuleColumn.MaxFundAmount - 1)];
			entity.YearFlg = (reader.IsDBNull(((int)FeeFundRuleColumn.YearFlg - 1)))?null:(System.Boolean?)reader[((int)FeeFundRuleColumn.YearFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeFundRuleColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeFundRuleColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeFundRuleColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeFundRuleColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFundRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFundRuleId = (System.Int32)dataRow["FEE_FUND_RULE_ID"];
			entity.OriginalFeeFundRuleId = (System.Int32)dataRow["FEE_FUND_RULE_ID"];
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.FeeCdeFundId = (System.Int32)dataRow["FEE_CDE_FUND_ID"];
			entity.RepeatNo = Convert.IsDBNull(dataRow["REPEAT_NO"]) ? null : (System.Int16?)dataRow["REPEAT_NO"];
			entity.MaxFundAmount = Convert.IsDBNull(dataRow["MAX_FUND_AMOUNT"]) ? null : (System.Decimal?)dataRow["MAX_FUND_AMOUNT"];
			entity.YearFlg = Convert.IsDBNull(dataRow["YEAR_FLG"]) ? null : (System.Boolean?)dataRow["YEAR_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFundRule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFundRule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFundRule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeId;
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region FeeCdeFundIdSource	
			if (CanDeepLoad(entity, "FeeCdeFund|FeeCdeFundIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeFundIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeFundId;
				FeeCdeFund tmpEntity = EntityManager.LocateEntity<FeeCdeFund>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeFund), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeFundIdSource = tmpEntity;
				else
					entity.FeeCdeFundIdSource = DataRepository.FeeCdeFundProvider.GetByFeeCdeFundId(transactionManager, entity.FeeCdeFundId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeFundIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeFundIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeFundProvider.DeepLoad(transactionManager, entity.FeeCdeFundIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeFundIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFundRule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFundRule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFundRule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFundRule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region FeeCdeFundIdSource
			if (CanDeepSave(entity, "FeeCdeFund|FeeCdeFundIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeFundIdSource != null)
			{
				DataRepository.FeeCdeFundProvider.Save(transactionManager, entity.FeeCdeFundIdSource);
				entity.FeeCdeFundId = entity.FeeCdeFundIdSource.FeeCdeFundId;
			}
			#endregion 
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
	
	#region FeeFundRuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFundRule</c>
	///</summary>
	public enum FeeFundRuleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>FeeCdeFund</c> at FeeCdeFundIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeFund))]
		FeeCdeFund,
	}
	
	#endregion FeeFundRuleChildEntityTypes
	
	#region FeeFundRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFundRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFundRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFundRuleFilterBuilder : SqlFilterBuilder<FeeFundRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleFilterBuilder class.
		/// </summary>
		public FeeFundRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFundRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFundRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFundRuleFilterBuilder
	
	#region FeeFundRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFundRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFundRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFundRuleParameterBuilder : ParameterizedSqlFilterBuilder<FeeFundRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleParameterBuilder class.
		/// </summary>
		public FeeFundRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFundRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFundRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFundRuleParameterBuilder
	
	#region FeeFundRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFundRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFundRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFundRuleSortBuilder : SqlSortBuilder<FeeFundRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFundRuleSqlSortBuilder class.
		/// </summary>
		public FeeFundRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFundRuleSortBuilder
	
} // end namespace
