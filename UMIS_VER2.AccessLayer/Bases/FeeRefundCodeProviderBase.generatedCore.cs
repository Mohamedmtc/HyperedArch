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
	/// This class is the base class for any <see cref="FeeRefundCodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefundCodeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeRefundCode, UMIS_VER2.BusinessLyer.FeeRefundCodeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeKey key)
		{
			return Delete(transactionManager, key.FeeRefundCodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeRefundCodeId">RFND_ID. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeRefundCodeId)
		{
			return Delete(null, _feeRefundCodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeRefundCodeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCode> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeRefundCodeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeRefundCodeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_REFUND_CODE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public abstract TList<FeeRefundCode> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		FK_FEE_REFUND_CODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		FK_FEE_REFUND_CODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefundCode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		FK_FEE_REFUND_CODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		fkFeeRefundCodeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		fkFeeRefundCodeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public TList<FeeRefundCode> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFUND_CODE_ED_CODE_SEMESTER key.
		///		FK_FEE_REFUND_CODE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefundCode objects.</returns>
		public abstract TList<FeeRefundCode> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeRefundCode Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCodeKey key, int start, int pageLength)
		{
			return GetByFeeRefundCodeId(transactionManager, key.FeeRefundCodeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_REFUND_CODE index.
		/// </summary>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(null,_feeRefundCodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_CODE index.
		/// </summary>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefundCodeId(transactionManager, _feeRefundCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_CODE index.
		/// </summary>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(System.Decimal _feeRefundCodeId, int start, int pageLength, out int count)
		{
			return GetByFeeRefundCodeId(null, _feeRefundCodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefundCodeId">RFND_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefundCode GetByFeeRefundCodeId(TransactionManager transactionManager, System.Decimal _feeRefundCodeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeRefundCode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeRefundCode&gt;"/></returns>
		public static TList<FeeRefundCode> Fill(IDataReader reader, TList<FeeRefundCode> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeRefundCode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeRefundCode")
					.Append("|").Append((System.Decimal)reader["FEE_REFUND_CODE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeRefundCode>(
					key.ToString(), // EntityTrackingKey
					"FeeRefundCode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeRefundCode();
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
					c.FeeRefundCodeId = (System.Decimal)reader["FEE_REFUND_CODE_ID"];
					c.OriginalFeeRefundCodeId = c.FeeRefundCodeId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.RfndDateFrom = Convert.IsDBNull(reader["RFND_DATE_FROM"]) ? null : (System.DateTime?)reader["RFND_DATE_FROM"];
					c.RfndDateTo = Convert.IsDBNull(reader["RFND_DATE_TO"]) ? null : (System.DateTime?)reader["RFND_DATE_TO"];
					c.RfndValue = (System.Decimal)reader["RFND_VALUE"];
					c.RfndPrcnt = (System.Decimal)reader["RFND_PRCNT"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.StudFreshFlg = Convert.IsDBNull(reader["STUD_FRESH_FLG"]) ? null : (System.Boolean?)reader["STUD_FRESH_FLG"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AdmFlg = Convert.IsDBNull(reader["ADM_FLG"]) ? null : (System.Boolean?)reader["ADM_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeRefundCode entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeRefundCodeId = (System.Decimal)reader[((int)FeeRefundCodeColumn.FeeRefundCodeId - 1)];
			entity.OriginalFeeRefundCodeId = (System.Decimal)reader["FEE_REFUND_CODE_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)FeeRefundCodeColumn.DescrAr - 1)))?null:(System.String)reader[((int)FeeRefundCodeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)FeeRefundCodeColumn.DescrEn - 1)))?null:(System.String)reader[((int)FeeRefundCodeColumn.DescrEn - 1)];
			entity.RfndDateFrom = (reader.IsDBNull(((int)FeeRefundCodeColumn.RfndDateFrom - 1)))?null:(System.DateTime?)reader[((int)FeeRefundCodeColumn.RfndDateFrom - 1)];
			entity.RfndDateTo = (reader.IsDBNull(((int)FeeRefundCodeColumn.RfndDateTo - 1)))?null:(System.DateTime?)reader[((int)FeeRefundCodeColumn.RfndDateTo - 1)];
			entity.RfndValue = (System.Decimal)reader[((int)FeeRefundCodeColumn.RfndValue - 1)];
			entity.RfndPrcnt = (System.Decimal)reader[((int)FeeRefundCodeColumn.RfndPrcnt - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeRefundCodeColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeColumn.EdCodeSemesterId - 1)];
			entity.StudFreshFlg = (reader.IsDBNull(((int)FeeRefundCodeColumn.StudFreshFlg - 1)))?null:(System.Boolean?)reader[((int)FeeRefundCodeColumn.StudFreshFlg - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)FeeRefundCodeColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeColumn.AsCodeDegreeClassId - 1)];
			entity.AdmFlg = (reader.IsDBNull(((int)FeeRefundCodeColumn.AdmFlg - 1)))?null:(System.Boolean?)reader[((int)FeeRefundCodeColumn.AdmFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeRefundCodeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeRefundCodeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeRefundCodeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefundCodeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeRefundCode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeRefundCodeId = (System.Decimal)dataRow["FEE_REFUND_CODE_ID"];
			entity.OriginalFeeRefundCodeId = (System.Decimal)dataRow["FEE_REFUND_CODE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.RfndDateFrom = Convert.IsDBNull(dataRow["RFND_DATE_FROM"]) ? null : (System.DateTime?)dataRow["RFND_DATE_FROM"];
			entity.RfndDateTo = Convert.IsDBNull(dataRow["RFND_DATE_TO"]) ? null : (System.DateTime?)dataRow["RFND_DATE_TO"];
			entity.RfndValue = (System.Decimal)dataRow["RFND_VALUE"];
			entity.RfndPrcnt = (System.Decimal)dataRow["RFND_PRCNT"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.StudFreshFlg = Convert.IsDBNull(dataRow["STUD_FRESH_FLG"]) ? null : (System.Boolean?)dataRow["STUD_FRESH_FLG"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AdmFlg = Convert.IsDBNull(dataRow["ADM_FLG"]) ? null : (System.Boolean?)dataRow["ADM_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefundCode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefundCode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeRefundCodeId methods when available
			
			#region FeeRefundCodeDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeDtlCollection = DataRepository.FeeRefundCodeDtlProvider.GetByFeeRefundCodeId(transactionManager, entity.FeeRefundCodeId);

				if (deep && entity.FeeRefundCodeDtlCollection.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCodeDtl>) DataRepository.FeeRefundCodeDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdDetCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdDetCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdDetCollection = DataRepository.FeeRefndStdDetProvider.GetByFeeRefundCodeId(transactionManager, entity.FeeRefundCodeId);

				if (deep && entity.FeeRefndStdDetCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdDet>) DataRepository.FeeRefndStdDetProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdDetCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeRefundCode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeRefundCode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefundCode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefundCode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeRefundCodeDtl>
				if (CanDeepSave(entity.FeeRefundCodeDtlCollection, "List<FeeRefundCodeDtl>|FeeRefundCodeDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCodeDtl child in entity.FeeRefundCodeDtlCollection)
					{
						if(child.FeeRefundCodeIdSource != null)
						{
							child.FeeRefundCodeId = child.FeeRefundCodeIdSource.FeeRefundCodeId;
						}
						else
						{
							child.FeeRefundCodeId = entity.FeeRefundCodeId;
						}

					}

					if (entity.FeeRefundCodeDtlCollection.Count > 0 || entity.FeeRefundCodeDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeDtlProvider.Save(transactionManager, entity.FeeRefundCodeDtlCollection);
						
						deepHandles.Add("FeeRefundCodeDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCodeDtl >) DataRepository.FeeRefundCodeDtlProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdDet>
				if (CanDeepSave(entity.FeeRefndStdDetCollection, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdDet child in entity.FeeRefndStdDetCollection)
					{
						if(child.FeeRefundCodeIdSource != null)
						{
							child.FeeRefundCodeId = child.FeeRefundCodeIdSource.FeeRefundCodeId;
						}
						else
						{
							child.FeeRefundCodeId = entity.FeeRefundCodeId;
						}

					}

					if (entity.FeeRefndStdDetCollection.Count > 0 || entity.FeeRefndStdDetCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdDetProvider.Save(transactionManager, entity.FeeRefndStdDetCollection);
						
						deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdDet >) DataRepository.FeeRefndStdDetProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdDetCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeRefundCodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeRefundCode</c>
	///</summary>
	public enum FeeRefundCodeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		///<summary>
		/// Collection of <c>FeeRefundCode</c> as OneToMany for FeeRefundCodeDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCodeDtl>))]
		FeeRefundCodeDtlCollection,
		///<summary>
		/// Collection of <c>FeeRefundCode</c> as OneToMany for FeeRefndStdDetCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdDet>))]
		FeeRefndStdDetCollection,
	}
	
	#endregion FeeRefundCodeChildEntityTypes
	
	#region FeeRefundCodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeRefundCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefundCodeFilterBuilder : SqlFilterBuilder<FeeRefundCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeFilterBuilder class.
		/// </summary>
		public FeeRefundCodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefundCodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefundCodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefundCodeFilterBuilder
	
	#region FeeRefundCodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeRefundCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefundCodeParameterBuilder : ParameterizedSqlFilterBuilder<FeeRefundCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeParameterBuilder class.
		/// </summary>
		public FeeRefundCodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefundCodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefundCodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefundCodeParameterBuilder
	
	#region FeeRefundCodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeRefundCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefundCode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeRefundCodeSortBuilder : SqlSortBuilder<FeeRefundCodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeSqlSortBuilder class.
		/// </summary>
		public FeeRefundCodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeRefundCodeSortBuilder
	
} // end namespace
