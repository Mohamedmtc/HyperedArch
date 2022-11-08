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
	/// This class is the base class for any <see cref="AccomPolcyAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomPolcyAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomPolcyAbsence, UMIS_VER2.BusinessLyer.AccomPolcyAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomPolcyAbsenceKey key)
		{
			return Delete(transactionManager, key.AccomPolcyAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomPolcyAbsenceId)
		{
			return Delete(null, _accomPolcyAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomPolcyAbsenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		public TList<AccomPolcyAbsence> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(_accomCdeWarnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<AccomPolcyAbsence> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		public TList<AccomPolcyAbsence> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		fkAccomPolcyAbsenceAccomCdeWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		public TList<AccomPolcyAbsence> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		fkAccomPolcyAbsenceAccomCdeWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		public TList<AccomPolcyAbsence> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN key.
		///		FK_ACCOM_POLCY_ABSENCE_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomPolcyAbsence objects.</returns>
		public abstract TList<AccomPolcyAbsence> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomPolcyAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomPolcyAbsenceKey key, int start, int pageLength)
		{
			return GetByAccomPolcyAbsenceId(transactionManager, key.AccomPolcyAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(System.Decimal _accomPolcyAbsenceId)
		{
			int count = -1;
			return GetByAccomPolcyAbsenceId(null,_accomPolcyAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(System.Decimal _accomPolcyAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomPolcyAbsenceId(null, _accomPolcyAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(TransactionManager transactionManager, System.Decimal _accomPolcyAbsenceId)
		{
			int count = -1;
			return GetByAccomPolcyAbsenceId(transactionManager, _accomPolcyAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(TransactionManager transactionManager, System.Decimal _accomPolcyAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomPolcyAbsenceId(transactionManager, _accomPolcyAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(System.Decimal _accomPolcyAbsenceId, int start, int pageLength, out int count)
		{
			return GetByAccomPolcyAbsenceId(null, _accomPolcyAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomPolcyAbsenceId">لايحة غياب السكن  ثابت مؤقتا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomPolcyAbsenceId(TransactionManager transactionManager, System.Decimal _accomPolcyAbsenceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg)
		{
			int count = -1;
			return GetByAccomCdeWarnIdFajrFlg(null,_accomCdeWarnId, _fajrFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnIdFajrFlg(null, _accomCdeWarnId, _fajrFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg)
		{
			int count = -1;
			return GetByAccomCdeWarnIdFajrFlg(transactionManager, _accomCdeWarnId, _fajrFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnIdFajrFlg(transactionManager, _accomCdeWarnId, _fajrFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg, int start, int pageLength, out int count)
		{
			return GetByAccomCdeWarnIdFajrFlg(null, _accomCdeWarnId, _fajrFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_POLCY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomPolcyAbsence GetByAccomCdeWarnIdFajrFlg(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, System.Boolean _fajrFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomPolcyAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomPolcyAbsence&gt;"/></returns>
		public static TList<AccomPolcyAbsence> Fill(IDataReader reader, TList<AccomPolcyAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomPolcyAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomPolcyAbsence")
					.Append("|").Append((System.Decimal)reader["ACCOM_POLCY_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomPolcyAbsence>(
					key.ToString(), // EntityTrackingKey
					"AccomPolcyAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomPolcyAbsence();
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
					c.AccomPolcyAbsenceId = (System.Decimal)reader["ACCOM_POLCY_ABSENCE_ID"];
					c.OriginalAccomPolcyAbsenceId = c.AccomPolcyAbsenceId;
					c.FajrFlg = (System.Boolean)reader["FAJR_FLG"];
					c.AbsDayCount = (System.Int32)reader["ABS_DAY_COUNT"];
					c.AccomCdeWarnId = (System.Int32)reader["ACCOM_CDE_WARN_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomPolcyAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomPolcyAbsenceId = (System.Decimal)reader[((int)AccomPolcyAbsenceColumn.AccomPolcyAbsenceId - 1)];
			entity.OriginalAccomPolcyAbsenceId = (System.Decimal)reader["ACCOM_POLCY_ABSENCE_ID"];
			entity.FajrFlg = (System.Boolean)reader[((int)AccomPolcyAbsenceColumn.FajrFlg - 1)];
			entity.AbsDayCount = (System.Int32)reader[((int)AccomPolcyAbsenceColumn.AbsDayCount - 1)];
			entity.AccomCdeWarnId = (System.Int32)reader[((int)AccomPolcyAbsenceColumn.AccomCdeWarnId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomPolcyAbsenceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomPolcyAbsenceColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomPolcyAbsenceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomPolcyAbsenceColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomPolcyAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomPolcyAbsenceId = (System.Decimal)dataRow["ACCOM_POLCY_ABSENCE_ID"];
			entity.OriginalAccomPolcyAbsenceId = (System.Decimal)dataRow["ACCOM_POLCY_ABSENCE_ID"];
			entity.FajrFlg = (System.Boolean)dataRow["FAJR_FLG"];
			entity.AbsDayCount = (System.Int32)dataRow["ABS_DAY_COUNT"];
			entity.AccomCdeWarnId = (System.Int32)dataRow["ACCOM_CDE_WARN_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomPolcyAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomPolcyAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomPolcyAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomCdeWarnIdSource	
			if (CanDeepLoad(entity, "AccomCdeWarn|AccomCdeWarnIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeWarnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomCdeWarnId;
				AccomCdeWarn tmpEntity = EntityManager.LocateEntity<AccomCdeWarn>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeWarn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeWarnIdSource = tmpEntity;
				else
					entity.AccomCdeWarnIdSource = DataRepository.AccomCdeWarnProvider.GetByAccomCdeWarnId(transactionManager, entity.AccomCdeWarnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeWarnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeWarnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeWarnProvider.DeepLoad(transactionManager, entity.AccomCdeWarnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeWarnIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomPolcyAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomPolcyAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomPolcyAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomPolcyAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomCdeWarnIdSource
			if (CanDeepSave(entity, "AccomCdeWarn|AccomCdeWarnIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeWarnIdSource != null)
			{
				DataRepository.AccomCdeWarnProvider.Save(transactionManager, entity.AccomCdeWarnIdSource);
				entity.AccomCdeWarnId = entity.AccomCdeWarnIdSource.AccomCdeWarnId;
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
	
	#region AccomPolcyAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomPolcyAbsence</c>
	///</summary>
	public enum AccomPolcyAbsenceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomCdeWarn</c> at AccomCdeWarnIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeWarn))]
		AccomCdeWarn,
	}
	
	#endregion AccomPolcyAbsenceChildEntityTypes
	
	#region AccomPolcyAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomPolcyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomPolcyAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomPolcyAbsenceFilterBuilder : SqlFilterBuilder<AccomPolcyAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceFilterBuilder class.
		/// </summary>
		public AccomPolcyAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomPolcyAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomPolcyAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomPolcyAbsenceFilterBuilder
	
	#region AccomPolcyAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomPolcyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomPolcyAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomPolcyAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<AccomPolcyAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceParameterBuilder class.
		/// </summary>
		public AccomPolcyAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomPolcyAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomPolcyAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomPolcyAbsenceParameterBuilder
	
	#region AccomPolcyAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomPolcyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomPolcyAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomPolcyAbsenceSortBuilder : SqlSortBuilder<AccomPolcyAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomPolcyAbsenceSqlSortBuilder class.
		/// </summary>
		public AccomPolcyAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomPolcyAbsenceSortBuilder
	
} // end namespace
