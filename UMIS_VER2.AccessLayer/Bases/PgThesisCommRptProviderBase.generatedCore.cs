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
	/// This class is the base class for any <see cref="PgThesisCommRptProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisCommRptProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisCommRpt, UMIS_VER2.BusinessLyer.PgThesisCommRptKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRptKey key)
		{
			return Delete(transactionManager, key.PgThesisCommRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// . Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisCommRptId)
		{
			return Delete(null, _pgThesisCommRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// . Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisCommRptId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommRpt> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		fkPgThesisCommRptPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		fkPgThesisCommRptPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public abstract TList<PgThesisCommRpt> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER Description: 
		/// </summary>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommMemberId(System.Decimal? _pgThesisCommMemberId)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(_pgThesisCommMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommRpt> GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal? _pgThesisCommMemberId)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(transactionManager, _pgThesisCommMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal? _pgThesisCommMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(transactionManager, _pgThesisCommMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		fkPgThesisCommRptPgThesisCommMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommMemberId(System.Decimal? _pgThesisCommMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommMemberId(null, _pgThesisCommMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		fkPgThesisCommRptPgThesisCommMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public TList<PgThesisCommRpt> GetByPgThesisCommMemberId(System.Decimal? _pgThesisCommMemberId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommMemberId(null, _pgThesisCommMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER key.
		///		FK_PG_THESIS_COMM_RPT_PG_THESIS_COMM_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">عضو اللجنه في حالة نوع التقرير فردي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRpt objects.</returns>
		public abstract TList<PgThesisCommRpt> GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal? _pgThesisCommMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisCommRpt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRptKey key, int start, int pageLength)
		{
			return GetByPgThesisCommRptId(transactionManager, key.PgThesisCommRptId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(System.Decimal _pgThesisCommRptId)
		{
			int count = -1;
			return GetByPgThesisCommRptId(null,_pgThesisCommRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(System.Decimal _pgThesisCommRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRptId(null, _pgThesisCommRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal _pgThesisCommRptId)
		{
			int count = -1;
			return GetByPgThesisCommRptId(transactionManager, _pgThesisCommRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal _pgThesisCommRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRptId(transactionManager, _pgThesisCommRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(System.Decimal _pgThesisCommRptId, int start, int pageLength, out int count)
		{
			return GetByPgThesisCommRptId(null, _pgThesisCommRptId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisCommRpt GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal _pgThesisCommRptId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisCommRpt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisCommRpt&gt;"/></returns>
		public static TList<PgThesisCommRpt> Fill(IDataReader reader, TList<PgThesisCommRpt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisCommRpt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisCommRpt")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_COMM_RPT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisCommRpt>(
					key.ToString(), // EntityTrackingKey
					"PgThesisCommRpt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisCommRpt();
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
					c.PgThesisCommRptId = (System.Decimal)reader["PG_THESIS_COMM_RPT_ID"];
					c.OriginalPgThesisCommRptId = c.PgThesisCommRptId;
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.RptTypeFlg = (System.Int16)reader["RPT_TYPE_FLG"];
					c.PgThesisCommMemberId = Convert.IsDBNull(reader["PG_THESIS_COMM_MEMBER_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_COMM_MEMBER_ID"];
					c.DeliverDate = Convert.IsDBNull(reader["DELIVER_DATE"]) ? null : (System.DateTime?)reader["DELIVER_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisCommRpt entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisCommRptId = (System.Decimal)reader[((int)PgThesisCommRptColumn.PgThesisCommRptId - 1)];
			entity.OriginalPgThesisCommRptId = (System.Decimal)reader["PG_THESIS_COMM_RPT_ID"];
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisCommRptColumn.PgThesisCommId - 1)];
			entity.RptTypeFlg = (System.Int16)reader[((int)PgThesisCommRptColumn.RptTypeFlg - 1)];
			entity.PgThesisCommMemberId = (reader.IsDBNull(((int)PgThesisCommRptColumn.PgThesisCommMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommRptColumn.PgThesisCommMemberId - 1)];
			entity.DeliverDate = (reader.IsDBNull(((int)PgThesisCommRptColumn.DeliverDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRptColumn.DeliverDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisCommRpt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisCommRptId = (System.Decimal)dataRow["PG_THESIS_COMM_RPT_ID"];
			entity.OriginalPgThesisCommRptId = (System.Decimal)dataRow["PG_THESIS_COMM_RPT_ID"];
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.RptTypeFlg = (System.Int16)dataRow["RPT_TYPE_FLG"];
			entity.PgThesisCommMemberId = Convert.IsDBNull(dataRow["PG_THESIS_COMM_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_COMM_MEMBER_ID"];
			entity.DeliverDate = Convert.IsDBNull(dataRow["DELIVER_DATE"]) ? null : (System.DateTime?)dataRow["DELIVER_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRpt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommRpt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRpt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgThesisCommIdSource	
			if (CanDeepLoad(entity, "PgThesisComm|PgThesisCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisCommId;
				PgThesisComm tmpEntity = EntityManager.LocateEntity<PgThesisComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommIdSource = tmpEntity;
				else
					entity.PgThesisCommIdSource = DataRepository.PgThesisCommProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommProvider.DeepLoad(transactionManager, entity.PgThesisCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommIdSource

			#region PgThesisCommMemberIdSource	
			if (CanDeepLoad(entity, "PgThesisCommMember|PgThesisCommMemberIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisCommMemberId ?? 0.0m);
				PgThesisCommMember tmpEntity = EntityManager.LocateEntity<PgThesisCommMember>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisCommMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommMemberIdSource = tmpEntity;
				else
					entity.PgThesisCommMemberIdSource = DataRepository.PgThesisCommMemberProvider.GetByPgThesisCommMemberId(transactionManager, (entity.PgThesisCommMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommMemberProvider.DeepLoad(transactionManager, entity.PgThesisCommMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommMemberIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisCommRptId methods when available
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisCommRptId(transactionManager, entity.PgThesisCommRptId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisCommRpt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisCommRpt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommRpt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRpt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
			}
			#endregion 
			
			#region PgThesisCommMemberIdSource
			if (CanDeepSave(entity, "PgThesisCommMember|PgThesisCommMemberIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommMemberIdSource != null)
			{
				DataRepository.PgThesisCommMemberProvider.Save(transactionManager, entity.PgThesisCommMemberIdSource);
				entity.PgThesisCommMemberId = entity.PgThesisCommMemberIdSource.PgThesisCommMemberId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgThesisCommRptIdSource != null)
						{
							child.PgThesisCommRptId = child.PgThesisCommRptIdSource.PgThesisCommRptId;
						}
						else
						{
							child.PgThesisCommRptId = entity.PgThesisCommRptId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisCommRptChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisCommRpt</c>
	///</summary>
	public enum PgThesisCommRptChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
		
		///<summary>
		/// Composite Property for <c>PgThesisCommMember</c> at PgThesisCommMemberIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisCommMember))]
		PgThesisCommMember,
		///<summary>
		/// Collection of <c>PgThesisCommRpt</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisCommRptChildEntityTypes
	
	#region PgThesisCommRptFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisCommRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommRptFilterBuilder : SqlFilterBuilder<PgThesisCommRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptFilterBuilder class.
		/// </summary>
		public PgThesisCommRptFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommRptFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommRptFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommRptFilterBuilder
	
	#region PgThesisCommRptParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisCommRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommRptParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisCommRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptParameterBuilder class.
		/// </summary>
		public PgThesisCommRptParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommRptParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommRptParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommRptParameterBuilder
	
	#region PgThesisCommRptSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisCommRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRpt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisCommRptSortBuilder : SqlSortBuilder<PgThesisCommRptColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRptSqlSortBuilder class.
		/// </summary>
		public PgThesisCommRptSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisCommRptSortBuilder
	
} // end namespace
