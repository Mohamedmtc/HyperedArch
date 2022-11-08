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
	/// This class is the base class for any <see cref="FeeFineProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFineProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFine, UMIS_VER2.BusinessLyer.FeeFineKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineKey key)
		{
			return Delete(transactionManager, key.FeeFineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFineId">غرامات تأخير الدفع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeFineId)
		{
			return Delete(null, _feeFineId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeFineId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		FK_FEE_FINE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		FK_FEE_FINE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFine> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		FK_FEE_FINE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		fkFeeFineAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		fkFeeFineAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_AS_FACULTY_INFO key.
		///		FK_FEE_FINE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public abstract TList<FeeFine> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		FK_FEE_FINE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		FK_FEE_FINE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFine> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		FK_FEE_FINE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		fkFeeFineFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		fkFeeFineFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public TList<FeeFine> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FINE_FEE_CODE_ITEM key.
		///		FK_FEE_FINE_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند المصروف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFine objects.</returns>
		public abstract TList<FeeFine> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeFine Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFineKey key, int start, int pageLength)
		{
			return GetByFeeFineId(transactionManager, key.FeeFineId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FINE index.
		/// </summary>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(System.Int32 _feeFineId)
		{
			int count = -1;
			return GetByFeeFineId(null,_feeFineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE index.
		/// </summary>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(System.Int32 _feeFineId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFineId(null, _feeFineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId)
		{
			int count = -1;
			return GetByFeeFineId(transactionManager, _feeFineId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFineId(transactionManager, _feeFineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE index.
		/// </summary>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(System.Int32 _feeFineId, int start, int pageLength, out int count)
		{
			return GetByFeeFineId(null, _feeFineId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FINE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFineId">غرامات تأخير الدفع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFine GetByFeeFineId(TransactionManager transactionManager, System.Int32 _feeFineId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFine&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFine&gt;"/></returns>
		public static TList<FeeFine> Fill(IDataReader reader, TList<FeeFine> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFine c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFine")
					.Append("|").Append((System.Int32)reader["FEE_FINE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFine>(
					key.ToString(), // EntityTrackingKey
					"FeeFine",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFine();
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
					c.FeeFineId = (System.Int32)reader["FEE_FINE_ID"];
					c.OriginalFeeFineId = c.FeeFineId;
					c.StartDate = Convert.IsDBNull(reader["START_DATE"]) ? null : (System.DateTime?)reader["START_DATE"];
					c.DueDate = (System.DateTime)reader["DUE_DATE"];
					c.DelaySeq = (System.Int32)reader["DELAY_SEQ"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.FineValue = Convert.IsDBNull(reader["FINE_VALUE"]) ? null : (System.Decimal?)reader["FINE_VALUE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.FinePrcnt = Convert.IsDBNull(reader["FINE_PRCNT"]) ? null : (System.Decimal?)reader["FINE_PRCNT"];
					c.NewStudentFlg = Convert.IsDBNull(reader["New_Student_Flg"]) ? null : (System.Boolean?)reader["New_Student_Flg"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFine entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFineId = (System.Int32)reader[((int)FeeFineColumn.FeeFineId - 1)];
			entity.OriginalFeeFineId = (System.Int32)reader["FEE_FINE_ID"];
			entity.StartDate = (reader.IsDBNull(((int)FeeFineColumn.StartDate - 1)))?null:(System.DateTime?)reader[((int)FeeFineColumn.StartDate - 1)];
			entity.DueDate = (System.DateTime)reader[((int)FeeFineColumn.DueDate - 1)];
			entity.DelaySeq = (System.Int32)reader[((int)FeeFineColumn.DelaySeq - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeFineColumn.FeeCodeItemId - 1)];
			entity.FineValue = (reader.IsDBNull(((int)FeeFineColumn.FineValue - 1)))?null:(System.Decimal?)reader[((int)FeeFineColumn.FineValue - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeFineColumn.Notes - 1)))?null:(System.String)reader[((int)FeeFineColumn.Notes - 1)];
			entity.FinePrcnt = (reader.IsDBNull(((int)FeeFineColumn.FinePrcnt - 1)))?null:(System.Decimal?)reader[((int)FeeFineColumn.FinePrcnt - 1)];
			entity.NewStudentFlg = (reader.IsDBNull(((int)FeeFineColumn.NewStudentFlg - 1)))?null:(System.Boolean?)reader[((int)FeeFineColumn.NewStudentFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeFineColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeFineColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFine entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFineId = (System.Int32)dataRow["FEE_FINE_ID"];
			entity.OriginalFeeFineId = (System.Int32)dataRow["FEE_FINE_ID"];
			entity.StartDate = Convert.IsDBNull(dataRow["START_DATE"]) ? null : (System.DateTime?)dataRow["START_DATE"];
			entity.DueDate = (System.DateTime)dataRow["DUE_DATE"];
			entity.DelaySeq = (System.Int32)dataRow["DELAY_SEQ"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.FineValue = Convert.IsDBNull(dataRow["FINE_VALUE"]) ? null : (System.Decimal?)dataRow["FINE_VALUE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.FinePrcnt = Convert.IsDBNull(dataRow["FINE_PRCNT"]) ? null : (System.Decimal?)dataRow["FINE_PRCNT"];
			entity.NewStudentFlg = Convert.IsDBNull(dataRow["New_Student_Flg"]) ? null : (System.Boolean?)dataRow["New_Student_Flg"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFine"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFine Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFine entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeFineId methods when available
			
			#region FeeFineDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFineDtl>|FeeFineDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFineDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFineDtlCollection = DataRepository.FeeFineDtlProvider.GetByFeeFineId(transactionManager, entity.FeeFineId);

				if (deep && entity.FeeFineDtlCollection.Count > 0)
				{
					deepHandles.Add("FeeFineDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFineDtl>) DataRepository.FeeFineDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFineDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFine object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFine instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFine Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFine entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeFineDtl>
				if (CanDeepSave(entity.FeeFineDtlCollection, "List<FeeFineDtl>|FeeFineDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFineDtl child in entity.FeeFineDtlCollection)
					{
						if(child.FeeFineIdSource != null)
						{
							child.FeeFineId = child.FeeFineIdSource.FeeFineId;
						}
						else
						{
							child.FeeFineId = entity.FeeFineId;
						}

					}

					if (entity.FeeFineDtlCollection.Count > 0 || entity.FeeFineDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFineDtlProvider.Save(transactionManager, entity.FeeFineDtlCollection);
						
						deepHandles.Add("FeeFineDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFineDtl >) DataRepository.FeeFineDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFineDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeFineChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFine</c>
	///</summary>
	public enum FeeFineChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		///<summary>
		/// Collection of <c>FeeFine</c> as OneToMany for FeeFineDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFineDtl>))]
		FeeFineDtlCollection,
	}
	
	#endregion FeeFineChildEntityTypes
	
	#region FeeFineFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFineFilterBuilder : SqlFilterBuilder<FeeFineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineFilterBuilder class.
		/// </summary>
		public FeeFineFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFineFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFineFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFineFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFineFilterBuilder
	
	#region FeeFineParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFine"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFineParameterBuilder : ParameterizedSqlFilterBuilder<FeeFineColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineParameterBuilder class.
		/// </summary>
		public FeeFineParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFineParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFineParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFineParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFineParameterBuilder
	
	#region FeeFineSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFineColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFine"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFineSortBuilder : SqlSortBuilder<FeeFineColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFineSqlSortBuilder class.
		/// </summary>
		public FeeFineSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFineSortBuilder
	
} // end namespace
