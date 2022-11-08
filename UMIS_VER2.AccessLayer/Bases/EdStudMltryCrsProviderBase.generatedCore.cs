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
	/// This class is the base class for any <see cref="EdStudMltryCrsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudMltryCrsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudMltryCrs, UMIS_VER2.BusinessLyer.EdStudMltryCrsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMltryCrsKey key)
		{
			return Delete(transactionManager, key.EdStudMltryCrsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudMltryCrsId)
		{
			return Delete(null, _edStudMltryCrsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudMltryCrsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		FK_ED_STUD_MLTRY_CRS_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		FK_ED_STUD_MLTRY_CRS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMltryCrs> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		FK_ED_STUD_MLTRY_CRS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		fkEdStudMltryCrsEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		fkEdStudMltryCrsEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_ED_STUD key.
		///		FK_ED_STUD_MLTRY_CRS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public abstract TList<EdStudMltryCrs> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES Description: 
		/// </summary>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(System.Decimal? _gsCodeMilCourseResId)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(_gsCodeMilCourseResId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal? _gsCodeMilCourseResId)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(transactionManager, _gsCodeMilCourseResId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal? _gsCodeMilCourseResId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilCourseResId(transactionManager, _gsCodeMilCourseResId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		fkEdStudMltryCrsGsCodeMilCourseRes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(System.Decimal? _gsCodeMilCourseResId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeMilCourseResId(null, _gsCodeMilCourseResId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		fkEdStudMltryCrsGsCodeMilCourseRes Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(System.Decimal? _gsCodeMilCourseResId, int start, int pageLength,out int count)
		{
			return GetByGsCodeMilCourseResId(null, _gsCodeMilCourseResId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES key.
		///		FK_ED_STUD_MLTRY_CRS_GS_CODE_MIL_COURSE_RES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilCourseResId">نتيجة الدورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public abstract TList<EdStudMltryCrs> GetByGsCodeMilCourseResId(TransactionManager transactionManager, System.Decimal? _gsCodeMilCourseResId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE Description: 
		/// </summary>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByMilCodeCourseId(System.Int32? _milCodeCourseId)
		{
			int count = -1;
			return GetByMilCodeCourseId(_milCodeCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMltryCrs> GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32? _milCodeCourseId)
		{
			int count = -1;
			return GetByMilCodeCourseId(transactionManager, _milCodeCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32? _milCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMilCodeCourseId(transactionManager, _milCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		fkEdStudMltryCrsMilCodeCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByMilCodeCourseId(System.Int32? _milCodeCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMilCodeCourseId(null, _milCodeCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		fkEdStudMltryCrsMilCodeCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public TList<EdStudMltryCrs> GetByMilCodeCourseId(System.Int32? _milCodeCourseId, int start, int pageLength,out int count)
		{
			return GetByMilCodeCourseId(null, _milCodeCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE key.
		///		FK_ED_STUD_MLTRY_CRS_MIL_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_milCodeCourseId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMltryCrs objects.</returns>
		public abstract TList<EdStudMltryCrs> GetByMilCodeCourseId(TransactionManager transactionManager, System.Int32? _milCodeCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudMltryCrs Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMltryCrsKey key, int start, int pageLength)
		{
			return GetByEdStudMltryCrsId(transactionManager, key.EdStudMltryCrsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(System.Decimal _edStudMltryCrsId)
		{
			int count = -1;
			return GetByEdStudMltryCrsId(null,_edStudMltryCrsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(System.Decimal _edStudMltryCrsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMltryCrsId(null, _edStudMltryCrsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(TransactionManager transactionManager, System.Decimal _edStudMltryCrsId)
		{
			int count = -1;
			return GetByEdStudMltryCrsId(transactionManager, _edStudMltryCrsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(TransactionManager transactionManager, System.Decimal _edStudMltryCrsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMltryCrsId(transactionManager, _edStudMltryCrsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(System.Decimal _edStudMltryCrsId, int start, int pageLength, out int count)
		{
			return GetByEdStudMltryCrsId(null, _edStudMltryCrsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MLTRY_CRS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMltryCrsId">مقررات الدورة العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudMltryCrs GetByEdStudMltryCrsId(TransactionManager transactionManager, System.Decimal _edStudMltryCrsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudMltryCrs&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudMltryCrs&gt;"/></returns>
		public static TList<EdStudMltryCrs> Fill(IDataReader reader, TList<EdStudMltryCrs> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudMltryCrs c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudMltryCrs")
					.Append("|").Append((System.Decimal)reader["ED_STUD_MLTRY_CRS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudMltryCrs>(
					key.ToString(), // EntityTrackingKey
					"EdStudMltryCrs",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudMltryCrs();
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
					c.EdStudMltryCrsId = (System.Decimal)reader["ED_STUD_MLTRY_CRS_ID"];
					c.OriginalEdStudMltryCrsId = c.EdStudMltryCrsId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.MilCodeCourseId = Convert.IsDBNull(reader["MIL_CODE_COURSE_ID"]) ? null : (System.Int32?)reader["MIL_CODE_COURSE_ID"];
					c.MilCourseNotes = Convert.IsDBNull(reader["MIL_COURSE_NOTES"]) ? null : (System.String)reader["MIL_COURSE_NOTES"];
					c.AbsFlg = Convert.IsDBNull(reader["ABS_FLG"]) ? null : (System.Boolean?)reader["ABS_FLG"];
					c.GsCodeMilCourseResId = Convert.IsDBNull(reader["GS_CODE_MIL_COURSE_RES_ID"]) ? null : (System.Decimal?)reader["GS_CODE_MIL_COURSE_RES_ID"];
					c.IsLast = (System.Boolean)reader["IS_LAST"];
					c.MilPgNo = Convert.IsDBNull(reader["MIL_PG_NO"]) ? null : (System.Decimal?)reader["MIL_PG_NO"];
					c.MilSerial = Convert.IsDBNull(reader["MIL_SERIAL"]) ? null : (System.Decimal?)reader["MIL_SERIAL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudMltryCrs entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudMltryCrsId = (System.Decimal)reader[((int)EdStudMltryCrsColumn.EdStudMltryCrsId - 1)];
			entity.OriginalEdStudMltryCrsId = (System.Decimal)reader["ED_STUD_MLTRY_CRS_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudMltryCrsColumn.EdStudId - 1)];
			entity.MilCodeCourseId = (reader.IsDBNull(((int)EdStudMltryCrsColumn.MilCodeCourseId - 1)))?null:(System.Int32?)reader[((int)EdStudMltryCrsColumn.MilCodeCourseId - 1)];
			entity.MilCourseNotes = (reader.IsDBNull(((int)EdStudMltryCrsColumn.MilCourseNotes - 1)))?null:(System.String)reader[((int)EdStudMltryCrsColumn.MilCourseNotes - 1)];
			entity.AbsFlg = (reader.IsDBNull(((int)EdStudMltryCrsColumn.AbsFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudMltryCrsColumn.AbsFlg - 1)];
			entity.GsCodeMilCourseResId = (reader.IsDBNull(((int)EdStudMltryCrsColumn.GsCodeMilCourseResId - 1)))?null:(System.Decimal?)reader[((int)EdStudMltryCrsColumn.GsCodeMilCourseResId - 1)];
			entity.IsLast = (System.Boolean)reader[((int)EdStudMltryCrsColumn.IsLast - 1)];
			entity.MilPgNo = (reader.IsDBNull(((int)EdStudMltryCrsColumn.MilPgNo - 1)))?null:(System.Decimal?)reader[((int)EdStudMltryCrsColumn.MilPgNo - 1)];
			entity.MilSerial = (reader.IsDBNull(((int)EdStudMltryCrsColumn.MilSerial - 1)))?null:(System.Decimal?)reader[((int)EdStudMltryCrsColumn.MilSerial - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudMltryCrs entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudMltryCrsId = (System.Decimal)dataRow["ED_STUD_MLTRY_CRS_ID"];
			entity.OriginalEdStudMltryCrsId = (System.Decimal)dataRow["ED_STUD_MLTRY_CRS_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.MilCodeCourseId = Convert.IsDBNull(dataRow["MIL_CODE_COURSE_ID"]) ? null : (System.Int32?)dataRow["MIL_CODE_COURSE_ID"];
			entity.MilCourseNotes = Convert.IsDBNull(dataRow["MIL_COURSE_NOTES"]) ? null : (System.String)dataRow["MIL_COURSE_NOTES"];
			entity.AbsFlg = Convert.IsDBNull(dataRow["ABS_FLG"]) ? null : (System.Boolean?)dataRow["ABS_FLG"];
			entity.GsCodeMilCourseResId = Convert.IsDBNull(dataRow["GS_CODE_MIL_COURSE_RES_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_MIL_COURSE_RES_ID"];
			entity.IsLast = (System.Boolean)dataRow["IS_LAST"];
			entity.MilPgNo = Convert.IsDBNull(dataRow["MIL_PG_NO"]) ? null : (System.Decimal?)dataRow["MIL_PG_NO"];
			entity.MilSerial = Convert.IsDBNull(dataRow["MIL_SERIAL"]) ? null : (System.Decimal?)dataRow["MIL_SERIAL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMltryCrs"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMltryCrs Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMltryCrs entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region GsCodeMilCourseResIdSource	
			if (CanDeepLoad(entity, "GsCodeMilCourseRes|GsCodeMilCourseResIdSource", deepLoadType, innerList) 
				&& entity.GsCodeMilCourseResIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeMilCourseResId ?? 0.0m);
				GsCodeMilCourseRes tmpEntity = EntityManager.LocateEntity<GsCodeMilCourseRes>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeMilCourseRes), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeMilCourseResIdSource = tmpEntity;
				else
					entity.GsCodeMilCourseResIdSource = DataRepository.GsCodeMilCourseResProvider.GetByGsCodeMilCourseResId(transactionManager, (entity.GsCodeMilCourseResId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeMilCourseResIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeMilCourseResIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeMilCourseResProvider.DeepLoad(transactionManager, entity.GsCodeMilCourseResIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeMilCourseResIdSource

			#region MilCodeCourseIdSource	
			if (CanDeepLoad(entity, "MilCodeCourse|MilCodeCourseIdSource", deepLoadType, innerList) 
				&& entity.MilCodeCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MilCodeCourseId ?? (int)0);
				MilCodeCourse tmpEntity = EntityManager.LocateEntity<MilCodeCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(MilCodeCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MilCodeCourseIdSource = tmpEntity;
				else
					entity.MilCodeCourseIdSource = DataRepository.MilCodeCourseProvider.GetByMilCodeCourseId(transactionManager, (entity.MilCodeCourseId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MilCodeCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MilCodeCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MilCodeCourseProvider.DeepLoad(transactionManager, entity.MilCodeCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MilCodeCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudMltryCrs object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudMltryCrs instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMltryCrs Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMltryCrs entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region GsCodeMilCourseResIdSource
			if (CanDeepSave(entity, "GsCodeMilCourseRes|GsCodeMilCourseResIdSource", deepSaveType, innerList) 
				&& entity.GsCodeMilCourseResIdSource != null)
			{
				DataRepository.GsCodeMilCourseResProvider.Save(transactionManager, entity.GsCodeMilCourseResIdSource);
				entity.GsCodeMilCourseResId = entity.GsCodeMilCourseResIdSource.GsCodeMilCourseResId;
			}
			#endregion 
			
			#region MilCodeCourseIdSource
			if (CanDeepSave(entity, "MilCodeCourse|MilCodeCourseIdSource", deepSaveType, innerList) 
				&& entity.MilCodeCourseIdSource != null)
			{
				DataRepository.MilCodeCourseProvider.Save(transactionManager, entity.MilCodeCourseIdSource);
				entity.MilCodeCourseId = entity.MilCodeCourseIdSource.MilCodeCourseId;
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
	
	#region EdStudMltryCrsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudMltryCrs</c>
	///</summary>
	public enum EdStudMltryCrsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeMilCourseRes</c> at GsCodeMilCourseResIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeMilCourseRes))]
		GsCodeMilCourseRes,
		
		///<summary>
		/// Composite Property for <c>MilCodeCourse</c> at MilCodeCourseIdSource
		///</summary>
		[ChildEntityType(typeof(MilCodeCourse))]
		MilCodeCourse,
	}
	
	#endregion EdStudMltryCrsChildEntityTypes
	
	#region EdStudMltryCrsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudMltryCrsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMltryCrs"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMltryCrsFilterBuilder : SqlFilterBuilder<EdStudMltryCrsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsFilterBuilder class.
		/// </summary>
		public EdStudMltryCrsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMltryCrsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMltryCrsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMltryCrsFilterBuilder
	
	#region EdStudMltryCrsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudMltryCrsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMltryCrs"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMltryCrsParameterBuilder : ParameterizedSqlFilterBuilder<EdStudMltryCrsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsParameterBuilder class.
		/// </summary>
		public EdStudMltryCrsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMltryCrsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMltryCrsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMltryCrsParameterBuilder
	
	#region EdStudMltryCrsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudMltryCrsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMltryCrs"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudMltryCrsSortBuilder : SqlSortBuilder<EdStudMltryCrsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMltryCrsSqlSortBuilder class.
		/// </summary>
		public EdStudMltryCrsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudMltryCrsSortBuilder
	
} // end namespace
