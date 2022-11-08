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
	/// This class is the base class for any <see cref="PgThesisCommRecommendProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisCommRecommendProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisCommRecommend, UMIS_VER2.BusinessLyer.PgThesisCommRecommendKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRecommendKey key)
		{
			return Delete(transactionManager, key.PgThesisCommRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisCommRecommendId)
		{
			return Delete(null, _pgThesisCommRecommendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(_pgCdeCommRecommendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(transactionManager, _pgCdeCommRecommendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeCommRecommendId(transactionManager, _pgCdeCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		fkPgThesisCommRecommendPgCdeCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeCommRecommendId(null, _pgCdeCommRecommendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		fkPgThesisCommRecommendPgCdeCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(System.Decimal _pgCdeCommRecommendId, int start, int pageLength,out int count)
		{
			return GetByPgCdeCommRecommendId(null, _pgCdeCommRecommendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_CDE_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeCommRecommendId">مسلسل توصيات لجنة الحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public abstract TList<PgThesisCommRecommend> GetByPgCdeCommRecommendId(TransactionManager transactionManager, System.Decimal _pgCdeCommRecommendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommRecommend> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		fkPgThesisCommRecommendPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		fkPgThesisCommRecommendPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public TList<PgThesisCommRecommend> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_RECOMMEND_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommRecommend objects.</returns>
		public abstract TList<PgThesisCommRecommend> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisCommRecommend Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRecommendKey key, int start, int pageLength)
		{
			return GetByPgThesisCommRecommendId(transactionManager, key.PgThesisCommRecommendId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(null,_pgThesisCommRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId, int start, int pageLength, out int count)
		{
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_RECOMMEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">نتيجة المناقشة للرسالة
		/// 		/// توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisCommRecommend GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisCommRecommend&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisCommRecommend&gt;"/></returns>
		public static TList<PgThesisCommRecommend> Fill(IDataReader reader, TList<PgThesisCommRecommend> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisCommRecommend c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisCommRecommend")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_COMM_RECOMMEND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisCommRecommend>(
					key.ToString(), // EntityTrackingKey
					"PgThesisCommRecommend",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisCommRecommend();
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
					c.PgThesisCommRecommendId = (System.Decimal)reader["PG_THESIS_COMM_RECOMMEND_ID"];
					c.OriginalPgThesisCommRecommendId = c.PgThesisCommRecommendId;
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.CommRecommendDate = Convert.IsDBNull(reader["COMM_RECOMMEND_DATE"]) ? null : (System.DateTime?)reader["COMM_RECOMMEND_DATE"];
					c.PgCdeCommRecommendId = (System.Decimal)reader["PG_CDE_COMM_RECOMMEND_ID"];
					c.RecommendReason = Convert.IsDBNull(reader["RECOMMEND_REASON"]) ? null : (System.String)reader["RECOMMEND_REASON"];
					c.ChangeDateFrom = Convert.IsDBNull(reader["CHANGE_DATE_FROM"]) ? null : (System.DateTime?)reader["CHANGE_DATE_FROM"];
					c.ChangeDateTo = Convert.IsDBNull(reader["CHANGE_DATE_TO"]) ? null : (System.DateTime?)reader["CHANGE_DATE_TO"];
					c.DeptDeliverFlg = Convert.IsDBNull(reader["DEPT_DELIVER_FLG"]) ? null : (System.Boolean?)reader["DEPT_DELIVER_FLG"];
					c.DeptDeliverDate = Convert.IsDBNull(reader["DEPT_DELIVER_DATE"]) ? null : (System.DateTime?)reader["DEPT_DELIVER_DATE"];
					c.CommRptDeliverFlg = Convert.IsDBNull(reader["COMM_RPT_DELIVER_FLG"]) ? null : (System.Boolean?)reader["COMM_RPT_DELIVER_FLG"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Boolean?)reader["IS_LAST"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisCommRecommend entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisCommRecommendId = (System.Decimal)reader[((int)PgThesisCommRecommendColumn.PgThesisCommRecommendId - 1)];
			entity.OriginalPgThesisCommRecommendId = (System.Decimal)reader["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisCommRecommendColumn.PgThesisCommId - 1)];
			entity.CommRecommendDate = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.CommRecommendDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRecommendColumn.CommRecommendDate - 1)];
			entity.PgCdeCommRecommendId = (System.Decimal)reader[((int)PgThesisCommRecommendColumn.PgCdeCommRecommendId - 1)];
			entity.RecommendReason = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.RecommendReason - 1)))?null:(System.String)reader[((int)PgThesisCommRecommendColumn.RecommendReason - 1)];
			entity.ChangeDateFrom = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.ChangeDateFrom - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRecommendColumn.ChangeDateFrom - 1)];
			entity.ChangeDateTo = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.ChangeDateTo - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRecommendColumn.ChangeDateTo - 1)];
			entity.DeptDeliverFlg = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.DeptDeliverFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisCommRecommendColumn.DeptDeliverFlg - 1)];
			entity.DeptDeliverDate = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.DeptDeliverDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRecommendColumn.DeptDeliverDate - 1)];
			entity.CommRptDeliverFlg = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.CommRptDeliverFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisCommRecommendColumn.CommRptDeliverFlg - 1)];
			entity.IsLast = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.IsLast - 1)))?null:(System.Boolean?)reader[((int)PgThesisCommRecommendColumn.IsLast - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisCommRecommendColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommRecommendColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisCommRecommendColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommRecommendColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisCommRecommend entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisCommRecommendId = (System.Decimal)dataRow["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.OriginalPgThesisCommRecommendId = (System.Decimal)dataRow["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.CommRecommendDate = Convert.IsDBNull(dataRow["COMM_RECOMMEND_DATE"]) ? null : (System.DateTime?)dataRow["COMM_RECOMMEND_DATE"];
			entity.PgCdeCommRecommendId = (System.Decimal)dataRow["PG_CDE_COMM_RECOMMEND_ID"];
			entity.RecommendReason = Convert.IsDBNull(dataRow["RECOMMEND_REASON"]) ? null : (System.String)dataRow["RECOMMEND_REASON"];
			entity.ChangeDateFrom = Convert.IsDBNull(dataRow["CHANGE_DATE_FROM"]) ? null : (System.DateTime?)dataRow["CHANGE_DATE_FROM"];
			entity.ChangeDateTo = Convert.IsDBNull(dataRow["CHANGE_DATE_TO"]) ? null : (System.DateTime?)dataRow["CHANGE_DATE_TO"];
			entity.DeptDeliverFlg = Convert.IsDBNull(dataRow["DEPT_DELIVER_FLG"]) ? null : (System.Boolean?)dataRow["DEPT_DELIVER_FLG"];
			entity.DeptDeliverDate = Convert.IsDBNull(dataRow["DEPT_DELIVER_DATE"]) ? null : (System.DateTime?)dataRow["DEPT_DELIVER_DATE"];
			entity.CommRptDeliverFlg = Convert.IsDBNull(dataRow["COMM_RPT_DELIVER_FLG"]) ? null : (System.Boolean?)dataRow["COMM_RPT_DELIVER_FLG"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Boolean?)dataRow["IS_LAST"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommRecommend"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommRecommend Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRecommend entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCdeCommRecommendIdSource	
			if (CanDeepLoad(entity, "PgCdeCommRecommend|PgCdeCommRecommendIdSource", deepLoadType, innerList) 
				&& entity.PgCdeCommRecommendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgCdeCommRecommendId;
				PgCdeCommRecommend tmpEntity = EntityManager.LocateEntity<PgCdeCommRecommend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeCommRecommend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeCommRecommendIdSource = tmpEntity;
				else
					entity.PgCdeCommRecommendIdSource = DataRepository.PgCdeCommRecommendProvider.GetByPgCdeCommRecommendId(transactionManager, entity.PgCdeCommRecommendId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeCommRecommendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeCommRecommendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeCommRecommendProvider.DeepLoad(transactionManager, entity.PgCdeCommRecommendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeCommRecommendIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisCommRecommendId methods when available
			
			#region PgThesisGrantStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantStudCollection = DataRepository.PgThesisGrantStudProvider.GetByPgThesisCommRecommendId(transactionManager, entity.PgThesisCommRecommendId);

				if (deep && entity.PgThesisGrantStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantStud>) DataRepository.PgThesisGrantStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisCommRecommendId(transactionManager, entity.PgThesisCommRecommendId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisCommRecommendId(transactionManager, entity.PgThesisCommRecommendId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisCommRecommend object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisCommRecommend instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommRecommend Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommRecommend entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCdeCommRecommendIdSource
			if (CanDeepSave(entity, "PgCdeCommRecommend|PgCdeCommRecommendIdSource", deepSaveType, innerList) 
				&& entity.PgCdeCommRecommendIdSource != null)
			{
				DataRepository.PgCdeCommRecommendProvider.Save(transactionManager, entity.PgCdeCommRecommendIdSource);
				entity.PgCdeCommRecommendId = entity.PgCdeCommRecommendIdSource.PgCdeCommRecommendId;
			}
			#endregion 
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisGrantStud>
				if (CanDeepSave(entity.PgThesisGrantStudCollection, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantStud child in entity.PgThesisGrantStudCollection)
					{
						if(child.PgThesisCommRecommendIdSource != null)
						{
							child.PgThesisCommRecommendId = child.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
						}
						else
						{
							child.PgThesisCommRecommendId = entity.PgThesisCommRecommendId;
						}

					}

					if (entity.PgThesisGrantStudCollection.Count > 0 || entity.PgThesisGrantStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantStudProvider.Save(transactionManager, entity.PgThesisGrantStudCollection);
						
						deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantStud >) DataRepository.PgThesisGrantStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisCommRecommendIdSource != null)
						{
							child.PgThesisCommRecommendId = child.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
						}
						else
						{
							child.PgThesisCommRecommendId = entity.PgThesisCommRecommendId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgThesisCommRecommendIdSource != null)
						{
							child.PgThesisCommRecommendId = child.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
						}
						else
						{
							child.PgThesisCommRecommendId = entity.PgThesisCommRecommendId;
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
	
	#region PgThesisCommRecommendChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisCommRecommend</c>
	///</summary>
	public enum PgThesisCommRecommendChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCdeCommRecommend</c> at PgCdeCommRecommendIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeCommRecommend))]
		PgCdeCommRecommend,
		
		///<summary>
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
		///<summary>
		/// Collection of <c>PgThesisCommRecommend</c> as OneToMany for PgThesisGrantStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantStud>))]
		PgThesisGrantStudCollection,
		///<summary>
		/// Collection of <c>PgThesisCommRecommend</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisCommRecommend</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisCommRecommendChildEntityTypes
	
	#region PgThesisCommRecommendFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommRecommendFilterBuilder : SqlFilterBuilder<PgThesisCommRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendFilterBuilder class.
		/// </summary>
		public PgThesisCommRecommendFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommRecommendFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommRecommendFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommRecommendFilterBuilder
	
	#region PgThesisCommRecommendParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRecommend"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommRecommendParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisCommRecommendColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendParameterBuilder class.
		/// </summary>
		public PgThesisCommRecommendParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommRecommendParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommRecommendParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommRecommendParameterBuilder
	
	#region PgThesisCommRecommendSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisCommRecommendColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommRecommend"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisCommRecommendSortBuilder : SqlSortBuilder<PgThesisCommRecommendColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommRecommendSqlSortBuilder class.
		/// </summary>
		public PgThesisCommRecommendSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisCommRecommendSortBuilder
	
} // end namespace
