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
	/// This class is the base class for any <see cref="EdStdExamSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStdExamSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStdExamSemester, UMIS_VER2.BusinessLyer.EdStdExamSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdExamSemesterKey key)
		{
			return Delete(transactionManager, key.EdStdExamSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStdExamSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStdExamSemesterId)
		{
			return Delete(null, _edStdExamSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdExamSemesterId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStdExamSemesterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdExamSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		fkEdStdExamSemesterEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		fkEdStdExamSemesterEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public abstract TList<EdStdExamSemester> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdExamSemester> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		fkEdStdExamSemesterEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		fkEdStdExamSemesterEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفرقة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public abstract TList<EdStdExamSemester> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdExamSemester> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		fkEdStdExamSemesterEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		fkEdStdExamSemesterEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public TList<EdStdExamSemester> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER key.
		///		FK_ED_STD_EXAM_SEMESTER_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdExamSemester objects.</returns>
		public abstract TList<EdStdExamSemester> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStdExamSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdExamSemesterKey key, int start, int pageLength)
		{
			return GetByEdStdExamSemesterId(transactionManager, key.EdStdExamSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="_edStdExamSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(System.Decimal _edStdExamSemesterId)
		{
			int count = -1;
			return GetByEdStdExamSemesterId(null,_edStdExamSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="_edStdExamSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(System.Decimal _edStdExamSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdExamSemesterId(null, _edStdExamSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdExamSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(TransactionManager transactionManager, System.Decimal _edStdExamSemesterId)
		{
			int count = -1;
			return GetByEdStdExamSemesterId(transactionManager, _edStdExamSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdExamSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(TransactionManager transactionManager, System.Decimal _edStdExamSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdExamSemesterId(transactionManager, _edStdExamSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="_edStdExamSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(System.Decimal _edStdExamSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStdExamSemesterId(null, _edStdExamSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_EXAM_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdExamSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStdExamSemester GetByEdStdExamSemesterId(TransactionManager transactionManager, System.Decimal _edStdExamSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStdExamSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStdExamSemester&gt;"/></returns>
		public static TList<EdStdExamSemester> Fill(IDataReader reader, TList<EdStdExamSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStdExamSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStdExamSemester")
					.Append("|").Append((System.Decimal)reader["ED_STD_EXAM_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStdExamSemester>(
					key.ToString(), // EntityTrackingKey
					"EdStdExamSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStdExamSemester();
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
					c.EdStdExamSemesterId = (System.Decimal)reader["ED_STD_EXAM_SEMESTER_ID"];
					c.OriginalEdStdExamSemesterId = c.EdStdExamSemesterId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdCdeExamTypeId = (System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"];
					c.SemMarkOld = Convert.IsDBNull(reader["SEM_MARK_OLD"]) ? null : (System.Decimal?)reader["SEM_MARK_OLD"];
					c.SemMarkNew = Convert.IsDBNull(reader["SEM_MARK_NEW"]) ? null : (System.Decimal?)reader["SEM_MARK_NEW"];
					c.AccumMarkOld = Convert.IsDBNull(reader["ACCUM_MARK_OLD"]) ? null : (System.Decimal?)reader["ACCUM_MARK_OLD"];
					c.AccumMarkNew = Convert.IsDBNull(reader["ACCUM_MARK_NEW"]) ? null : (System.Decimal?)reader["ACCUM_MARK_NEW"];
					c.OrgClemencyMark = Convert.IsDBNull(reader["ORG_CLEMENCY_MARK"]) ? null : (System.Decimal?)reader["ORG_CLEMENCY_MARK"];
					c.TotClemencyMark = Convert.IsDBNull(reader["TOT_CLEMENCY_MARK"]) ? null : (System.Decimal?)reader["TOT_CLEMENCY_MARK"];
					c.AccumClemencyMark = Convert.IsDBNull(reader["ACCUM_CLEMENCY_MARK"]) ? null : (System.Decimal?)reader["ACCUM_CLEMENCY_MARK"];
					c.AccumRaiseMark = Convert.IsDBNull(reader["ACCUM_RAISE_MARK"]) ? null : (System.Decimal?)reader["ACCUM_RAISE_MARK"];
					c.CrsFailCount = Convert.IsDBNull(reader["CRS_FAIL_COUNT"]) ? null : (System.Decimal?)reader["CRS_FAIL_COUNT"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.CelemApplyFlg = Convert.IsDBNull(reader["CELEM_APPLY_FLG"]) ? null : (System.Decimal?)reader["CELEM_APPLY_FLG"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStdExamSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStdExamSemesterId = (System.Decimal)reader[((int)EdStdExamSemesterColumn.EdStdExamSemesterId - 1)];
			entity.OriginalEdStdExamSemesterId = (System.Decimal)reader["ED_STD_EXAM_SEMESTER_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStdExamSemesterColumn.EdStudSemesterId - 1)];
			entity.EdCdeExamTypeId = (System.Decimal)reader[((int)EdStdExamSemesterColumn.EdCdeExamTypeId - 1)];
			entity.SemMarkOld = (reader.IsDBNull(((int)EdStdExamSemesterColumn.SemMarkOld - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.SemMarkOld - 1)];
			entity.SemMarkNew = (reader.IsDBNull(((int)EdStdExamSemesterColumn.SemMarkNew - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.SemMarkNew - 1)];
			entity.AccumMarkOld = (reader.IsDBNull(((int)EdStdExamSemesterColumn.AccumMarkOld - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.AccumMarkOld - 1)];
			entity.AccumMarkNew = (reader.IsDBNull(((int)EdStdExamSemesterColumn.AccumMarkNew - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.AccumMarkNew - 1)];
			entity.OrgClemencyMark = (reader.IsDBNull(((int)EdStdExamSemesterColumn.OrgClemencyMark - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.OrgClemencyMark - 1)];
			entity.TotClemencyMark = (reader.IsDBNull(((int)EdStdExamSemesterColumn.TotClemencyMark - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.TotClemencyMark - 1)];
			entity.AccumClemencyMark = (reader.IsDBNull(((int)EdStdExamSemesterColumn.AccumClemencyMark - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.AccumClemencyMark - 1)];
			entity.AccumRaiseMark = (reader.IsDBNull(((int)EdStdExamSemesterColumn.AccumRaiseMark - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.AccumRaiseMark - 1)];
			entity.CrsFailCount = (reader.IsDBNull(((int)EdStdExamSemesterColumn.CrsFailCount - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.CrsFailCount - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStdExamSemesterColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.ApproveFlg - 1)];
			entity.CelemApplyFlg = (reader.IsDBNull(((int)EdStdExamSemesterColumn.CelemApplyFlg - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.CelemApplyFlg - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStdExamSemesterColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStdExamSemesterColumn.EdCodeGradingId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStdExamSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStdExamSemesterId = (System.Decimal)dataRow["ED_STD_EXAM_SEMESTER_ID"];
			entity.OriginalEdStdExamSemesterId = (System.Decimal)dataRow["ED_STD_EXAM_SEMESTER_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCdeExamTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.SemMarkOld = Convert.IsDBNull(dataRow["SEM_MARK_OLD"]) ? null : (System.Decimal?)dataRow["SEM_MARK_OLD"];
			entity.SemMarkNew = Convert.IsDBNull(dataRow["SEM_MARK_NEW"]) ? null : (System.Decimal?)dataRow["SEM_MARK_NEW"];
			entity.AccumMarkOld = Convert.IsDBNull(dataRow["ACCUM_MARK_OLD"]) ? null : (System.Decimal?)dataRow["ACCUM_MARK_OLD"];
			entity.AccumMarkNew = Convert.IsDBNull(dataRow["ACCUM_MARK_NEW"]) ? null : (System.Decimal?)dataRow["ACCUM_MARK_NEW"];
			entity.OrgClemencyMark = Convert.IsDBNull(dataRow["ORG_CLEMENCY_MARK"]) ? null : (System.Decimal?)dataRow["ORG_CLEMENCY_MARK"];
			entity.TotClemencyMark = Convert.IsDBNull(dataRow["TOT_CLEMENCY_MARK"]) ? null : (System.Decimal?)dataRow["TOT_CLEMENCY_MARK"];
			entity.AccumClemencyMark = Convert.IsDBNull(dataRow["ACCUM_CLEMENCY_MARK"]) ? null : (System.Decimal?)dataRow["ACCUM_CLEMENCY_MARK"];
			entity.AccumRaiseMark = Convert.IsDBNull(dataRow["ACCUM_RAISE_MARK"]) ? null : (System.Decimal?)dataRow["ACCUM_RAISE_MARK"];
			entity.CrsFailCount = Convert.IsDBNull(dataRow["CRS_FAIL_COUNT"]) ? null : (System.Decimal?)dataRow["CRS_FAIL_COUNT"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.CelemApplyFlg = Convert.IsDBNull(dataRow["CELEM_APPLY_FLG"]) ? null : (System.Decimal?)dataRow["CELEM_APPLY_FLG"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdExamSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdExamSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdExamSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeExamTypeId;
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStdExamSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStdExamSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdExamSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdExamSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
			}
			#endregion 
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
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
	
	#region EdStdExamSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStdExamSemester</c>
	///</summary>
	public enum EdStdExamSemesterChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
	}
	
	#endregion EdStdExamSemesterChildEntityTypes
	
	#region EdStdExamSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStdExamSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdExamSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdExamSemesterFilterBuilder : SqlFilterBuilder<EdStdExamSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterFilterBuilder class.
		/// </summary>
		public EdStdExamSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdExamSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdExamSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdExamSemesterFilterBuilder
	
	#region EdStdExamSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStdExamSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdExamSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdExamSemesterParameterBuilder : ParameterizedSqlFilterBuilder<EdStdExamSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterParameterBuilder class.
		/// </summary>
		public EdStdExamSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdExamSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdExamSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdExamSemesterParameterBuilder
	
	#region EdStdExamSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStdExamSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdExamSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStdExamSemesterSortBuilder : SqlSortBuilder<EdStdExamSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdExamSemesterSqlSortBuilder class.
		/// </summary>
		public EdStdExamSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStdExamSemesterSortBuilder
	
} // end namespace
