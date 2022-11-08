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
	/// This class is the base class for any <see cref="PgThesisSeminarProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisSeminarProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisSeminar, UMIS_VER2.BusinessLyer.PgThesisSeminarKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSeminarKey key)
		{
			return Delete(transactionManager, key.PgThesisSeminarId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار). Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisSeminarId)
		{
			return Delete(null, _pgThesisSeminarId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار). Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisSeminarId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		FK_PG_STUD_SEMINAR_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId">المبانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		FK_PG_STUD_SEMINAR_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSeminar> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		FK_PG_STUD_SEMINAR_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		fkPgStudSeminarScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		fkPgStudSeminarScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_BUILDING key.
		///		FK_PG_STUD_SEMINAR_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public abstract TList<PgThesisSeminar> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		FK_PG_STUD_SEMINAR_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">القاعات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		FK_PG_STUD_SEMINAR_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSeminar> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		FK_PG_STUD_SEMINAR_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		fkPgStudSeminarScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">القاعات</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		fkPgStudSeminarScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_SEMINAR_SC_HALL key.
		///		FK_PG_STUD_SEMINAR_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public abstract TList<PgThesisSeminar> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSeminar> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		fkPgThesisSeminarPgThesisStud1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		fkPgThesisSeminarPgThesisStud1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public TList<PgThesisSeminar> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 key.
		///		FK_PG_THESIS_SEMINAR_PG_THESIS_STUD1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSeminar objects.</returns>
		public abstract TList<PgThesisSeminar> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisSeminar Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSeminarKey key, int start, int pageLength)
		{
			return GetByPgThesisSeminarId(transactionManager, key.PgThesisSeminarId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(System.Decimal _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(null,_pgThesisSeminarId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(System.Decimal _pgThesisSeminarId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal _pgThesisSeminarId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(System.Decimal _pgThesisSeminarId, int start, int pageLength, out int count)
		{
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SEMINAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisSeminar GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal _pgThesisSeminarId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisSeminar&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisSeminar&gt;"/></returns>
		public static TList<PgThesisSeminar> Fill(IDataReader reader, TList<PgThesisSeminar> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisSeminar c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisSeminar")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_SEMINAR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisSeminar>(
					key.ToString(), // EntityTrackingKey
					"PgThesisSeminar",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisSeminar();
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
					c.PgThesisSeminarId = (System.Decimal)reader["PG_THESIS_SEMINAR_ID"];
					c.OriginalPgThesisSeminarId = c.PgThesisSeminarId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.SeminarDate = Convert.IsDBNull(reader["SEMINAR_DATE"]) ? null : (System.DateTime?)reader["SEMINAR_DATE"];
					c.TimeFrom = Convert.IsDBNull(reader["TIME_FROM"]) ? null : (System.DateTime?)reader["TIME_FROM"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.PlagiarismPrcnt = Convert.IsDBNull(reader["PLAGIARISM_PRCNT"]) ? null : (System.Decimal?)reader["PLAGIARISM_PRCNT"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.RejectReason = Convert.IsDBNull(reader["REJECT_REASON"]) ? null : (System.String)reader["REJECT_REASON"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisSeminar entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisSeminarId = (System.Decimal)reader[((int)PgThesisSeminarColumn.PgThesisSeminarId - 1)];
			entity.OriginalPgThesisSeminarId = (System.Decimal)reader["PG_THESIS_SEMINAR_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisSeminarColumn.PgThesisStudId - 1)];
			entity.SeminarDate = (reader.IsDBNull(((int)PgThesisSeminarColumn.SeminarDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisSeminarColumn.SeminarDate - 1)];
			entity.TimeFrom = (reader.IsDBNull(((int)PgThesisSeminarColumn.TimeFrom - 1)))?null:(System.DateTime?)reader[((int)PgThesisSeminarColumn.TimeFrom - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)PgThesisSeminarColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSeminarColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)PgThesisSeminarColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSeminarColumn.ScHallId - 1)];
			entity.PlagiarismPrcnt = (reader.IsDBNull(((int)PgThesisSeminarColumn.PlagiarismPrcnt - 1)))?null:(System.Decimal?)reader[((int)PgThesisSeminarColumn.PlagiarismPrcnt - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)PgThesisSeminarColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisSeminarColumn.ApproveFlg - 1)];
			entity.RejectReason = (reader.IsDBNull(((int)PgThesisSeminarColumn.RejectReason - 1)))?null:(System.String)reader[((int)PgThesisSeminarColumn.RejectReason - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisSeminarColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisSeminarColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisSeminarColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisSeminarColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisSeminarColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSeminarColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisSeminar entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisSeminarId = (System.Decimal)dataRow["PG_THESIS_SEMINAR_ID"];
			entity.OriginalPgThesisSeminarId = (System.Decimal)dataRow["PG_THESIS_SEMINAR_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.SeminarDate = Convert.IsDBNull(dataRow["SEMINAR_DATE"]) ? null : (System.DateTime?)dataRow["SEMINAR_DATE"];
			entity.TimeFrom = Convert.IsDBNull(dataRow["TIME_FROM"]) ? null : (System.DateTime?)dataRow["TIME_FROM"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.PlagiarismPrcnt = Convert.IsDBNull(dataRow["PLAGIARISM_PRCNT"]) ? null : (System.Decimal?)dataRow["PLAGIARISM_PRCNT"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.RejectReason = Convert.IsDBNull(dataRow["REJECT_REASON"]) ? null : (System.String)dataRow["REJECT_REASON"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSeminar"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSeminar Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSeminar entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisStudId;
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisSeminarId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisSeminarId(transactionManager, entity.PgThesisSeminarId);

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

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisSeminarId(transactionManager, entity.PgThesisSeminarId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisSeminar object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisSeminar instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSeminar Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSeminar entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
			}
			#endregion 
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisSeminarIdSource != null)
						{
							child.PgThesisSeminarId = child.PgThesisSeminarIdSource.PgThesisSeminarId;
						}
						else
						{
							child.PgThesisSeminarId = entity.PgThesisSeminarId;
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
						if(child.PgThesisSeminarIdSource != null)
						{
							child.PgThesisSeminarId = child.PgThesisSeminarIdSource.PgThesisSeminarId;
						}
						else
						{
							child.PgThesisSeminarId = entity.PgThesisSeminarId;
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
	
	#region PgThesisSeminarChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisSeminar</c>
	///</summary>
	public enum PgThesisSeminarChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisSeminar</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisSeminar</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisSeminarChildEntityTypes
	
	#region PgThesisSeminarFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisSeminarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSeminar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSeminarFilterBuilder : SqlFilterBuilder<PgThesisSeminarColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarFilterBuilder class.
		/// </summary>
		public PgThesisSeminarFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSeminarFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSeminarFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSeminarFilterBuilder
	
	#region PgThesisSeminarParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisSeminarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSeminar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSeminarParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisSeminarColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarParameterBuilder class.
		/// </summary>
		public PgThesisSeminarParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSeminarParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSeminarParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSeminarParameterBuilder
	
	#region PgThesisSeminarSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisSeminarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSeminar"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisSeminarSortBuilder : SqlSortBuilder<PgThesisSeminarColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSeminarSqlSortBuilder class.
		/// </summary>
		public PgThesisSeminarSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisSeminarSortBuilder
	
} // end namespace
