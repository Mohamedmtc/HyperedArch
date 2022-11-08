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
	/// This class is the base class for any <see cref="PgThesisSupervisorRptProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisSupervisorRptProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt, UMIS_VER2.BusinessLyer.PgThesisSupervisorRptKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorRptKey key)
		{
			return Delete(transactionManager, key.PgThesisSupervisorRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisSupervisorRptId)
		{
			return Delete(null, _pgThesisSupervisorRptId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorRptId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND Description: 
		/// </summary>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(System.Decimal? _pgCdeRptRecommendId)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(_pgCdeRptRecommendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal? _pgCdeRptRecommendId)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(transactionManager, _pgCdeRptRecommendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal? _pgCdeRptRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeRptRecommendId(transactionManager, _pgCdeRptRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		fkPgThesisSupervisorRptPgCdeRptRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(System.Decimal? _pgCdeRptRecommendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeRptRecommendId(null, _pgCdeRptRecommendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		fkPgThesisSupervisorRptPgCdeRptRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(System.Decimal? _pgCdeRptRecommendId, int start, int pageLength,out int count)
		{
			return GetByPgCdeRptRecommendId(null, _pgCdeRptRecommendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_CDE_RPT_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeRptRecommendId">مسلسل توصيات التقرير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public abstract TList<PgThesisSupervisorRpt> GetByPgCdeRptRecommendId(TransactionManager transactionManager, System.Decimal? _pgCdeRptRecommendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSupervisorRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		fkPgThesisSupervisorRptPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		fkPgThesisSupervisorRptPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public abstract TList<PgThesisSupervisorRpt> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(_pgThesisSupervisorCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		fkPgThesisSupervisorRptPgThesisSupervisorComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		fkPgThesisSupervisorRptPgThesisSupervisorComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_SUPERVISOR_RPT_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt objects.</returns>
		public abstract TList<PgThesisSupervisorRpt> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorRptKey key, int start, int pageLength)
		{
			return GetByPgThesisSupervisorRptId(transactionManager, key.PgThesisSupervisorRptId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(System.Decimal _pgThesisSupervisorRptId)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(null,_pgThesisSupervisorRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(System.Decimal _pgThesisSupervisorRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(null, _pgThesisSupervisorRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorRptId)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(transactionManager, _pgThesisSupervisorRptId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(transactionManager, _pgThesisSupervisorRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(System.Decimal _pgThesisSupervisorRptId, int start, int pageLength, out int count)
		{
			return GetByPgThesisSupervisorRptId(null, _pgThesisSupervisorRptId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_RPT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorRptId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisSupervisorRpt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisSupervisorRpt&gt;"/></returns>
		public static TList<PgThesisSupervisorRpt> Fill(IDataReader reader, TList<PgThesisSupervisorRpt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisSupervisorRpt")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_SUPERVISOR_RPT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisSupervisorRpt>(
					key.ToString(), // EntityTrackingKey
					"PgThesisSupervisorRpt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt();
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
					c.PgThesisSupervisorRptId = (System.Decimal)reader["PG_THESIS_SUPERVISOR_RPT_ID"];
					c.OriginalPgThesisSupervisorRptId = c.PgThesisSupervisorRptId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.PgThesisSupervisorCommId = (System.Decimal)reader["PG_THESIS_SUPERVISOR_COMM_ID"];
					c.ReportSerial = (System.Int32)reader["REPORT_SERIAL"];
					c.ReportDate = (System.DateTime)reader["REPORT_DATE"];
					c.CompletionPercent = Convert.IsDBNull(reader["COMPLETION_PERCENT"]) ? null : (System.Decimal?)reader["COMPLETION_PERCENT"];
					c.ProgressPercent = Convert.IsDBNull(reader["PROGRESS_PERCENT"]) ? null : (System.Decimal?)reader["PROGRESS_PERCENT"];
					c.ExpectedFinishPeriod = Convert.IsDBNull(reader["EXPECTED_FINISH_PERIOD"]) ? null : (System.String)reader["EXPECTED_FINISH_PERIOD"];
					c.FinalFlg = Convert.IsDBNull(reader["FINAL_FLG"]) ? null : (System.Boolean?)reader["FINAL_FLG"];
					c.PgCdeRptRecommendId = Convert.IsDBNull(reader["PG_CDE_RPT_RECOMMEND_ID"]) ? null : (System.Decimal?)reader["PG_CDE_RPT_RECOMMEND_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisSupervisorRptId = (System.Decimal)reader[((int)PgThesisSupervisorRptColumn.PgThesisSupervisorRptId - 1)];
			entity.OriginalPgThesisSupervisorRptId = (System.Decimal)reader["PG_THESIS_SUPERVISOR_RPT_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisSupervisorRptColumn.PgThesisStudId - 1)];
			entity.PgThesisSupervisorCommId = (System.Decimal)reader[((int)PgThesisSupervisorRptColumn.PgThesisSupervisorCommId - 1)];
			entity.ReportSerial = (System.Int32)reader[((int)PgThesisSupervisorRptColumn.ReportSerial - 1)];
			entity.ReportDate = (System.DateTime)reader[((int)PgThesisSupervisorRptColumn.ReportDate - 1)];
			entity.CompletionPercent = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.CompletionPercent - 1)))?null:(System.Decimal?)reader[((int)PgThesisSupervisorRptColumn.CompletionPercent - 1)];
			entity.ProgressPercent = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.ProgressPercent - 1)))?null:(System.Decimal?)reader[((int)PgThesisSupervisorRptColumn.ProgressPercent - 1)];
			entity.ExpectedFinishPeriod = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.ExpectedFinishPeriod - 1)))?null:(System.String)reader[((int)PgThesisSupervisorRptColumn.ExpectedFinishPeriod - 1)];
			entity.FinalFlg = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.FinalFlg - 1)))?null:(System.Boolean?)reader[((int)PgThesisSupervisorRptColumn.FinalFlg - 1)];
			entity.PgCdeRptRecommendId = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.PgCdeRptRecommendId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSupervisorRptColumn.PgCdeRptRecommendId - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisSupervisorRptColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisSupervisorRptColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisSupervisorRptColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSupervisorRptColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisSupervisorRptId = (System.Decimal)dataRow["PG_THESIS_SUPERVISOR_RPT_ID"];
			entity.OriginalPgThesisSupervisorRptId = (System.Decimal)dataRow["PG_THESIS_SUPERVISOR_RPT_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.PgThesisSupervisorCommId = (System.Decimal)dataRow["PG_THESIS_SUPERVISOR_COMM_ID"];
			entity.ReportSerial = (System.Int32)dataRow["REPORT_SERIAL"];
			entity.ReportDate = (System.DateTime)dataRow["REPORT_DATE"];
			entity.CompletionPercent = Convert.IsDBNull(dataRow["COMPLETION_PERCENT"]) ? null : (System.Decimal?)dataRow["COMPLETION_PERCENT"];
			entity.ProgressPercent = Convert.IsDBNull(dataRow["PROGRESS_PERCENT"]) ? null : (System.Decimal?)dataRow["PROGRESS_PERCENT"];
			entity.ExpectedFinishPeriod = Convert.IsDBNull(dataRow["EXPECTED_FINISH_PERIOD"]) ? null : (System.String)dataRow["EXPECTED_FINISH_PERIOD"];
			entity.FinalFlg = Convert.IsDBNull(dataRow["FINAL_FLG"]) ? null : (System.Boolean?)dataRow["FINAL_FLG"];
			entity.PgCdeRptRecommendId = Convert.IsDBNull(dataRow["PG_CDE_RPT_RECOMMEND_ID"]) ? null : (System.Decimal?)dataRow["PG_CDE_RPT_RECOMMEND_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCdeRptRecommendIdSource	
			if (CanDeepLoad(entity, "PgCdeRptRecommend|PgCdeRptRecommendIdSource", deepLoadType, innerList) 
				&& entity.PgCdeRptRecommendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgCdeRptRecommendId ?? 0.0m);
				PgCdeRptRecommend tmpEntity = EntityManager.LocateEntity<PgCdeRptRecommend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeRptRecommend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeRptRecommendIdSource = tmpEntity;
				else
					entity.PgCdeRptRecommendIdSource = DataRepository.PgCdeRptRecommendProvider.GetByPgCdeRptRecommendId(transactionManager, (entity.PgCdeRptRecommendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeRptRecommendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeRptRecommendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeRptRecommendProvider.DeepLoad(transactionManager, entity.PgCdeRptRecommendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeRptRecommendIdSource

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

			#region PgThesisSupervisorCommIdSource	
			if (CanDeepLoad(entity, "PgThesisSupervisorComm|PgThesisSupervisorCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisSupervisorCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisSupervisorCommId;
				PgThesisSupervisorComm tmpEntity = EntityManager.LocateEntity<PgThesisSupervisorComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisSupervisorComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisSupervisorCommIdSource = tmpEntity;
				else
					entity.PgThesisSupervisorCommIdSource = DataRepository.PgThesisSupervisorCommProvider.GetByPgThesisSupervisorCommId(transactionManager, entity.PgThesisSupervisorCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisSupervisorCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisSupervisorCommProvider.DeepLoad(transactionManager, entity.PgThesisSupervisorCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisSupervisorCommIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisSupervisorRptId methods when available
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisSupervisorRptId(transactionManager, entity.PgThesisSupervisorRptId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCdeRptRecommendIdSource
			if (CanDeepSave(entity, "PgCdeRptRecommend|PgCdeRptRecommendIdSource", deepSaveType, innerList) 
				&& entity.PgCdeRptRecommendIdSource != null)
			{
				DataRepository.PgCdeRptRecommendProvider.Save(transactionManager, entity.PgCdeRptRecommendIdSource);
				entity.PgCdeRptRecommendId = entity.PgCdeRptRecommendIdSource.PgCdeRptRecommendId;
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
			
			#region PgThesisSupervisorCommIdSource
			if (CanDeepSave(entity, "PgThesisSupervisorComm|PgThesisSupervisorCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisSupervisorCommIdSource != null)
			{
				DataRepository.PgThesisSupervisorCommProvider.Save(transactionManager, entity.PgThesisSupervisorCommIdSource);
				entity.PgThesisSupervisorCommId = entity.PgThesisSupervisorCommIdSource.PgThesisSupervisorCommId;
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
						if(child.PgThesisSupervisorRptIdSource != null)
						{
							child.PgThesisSupervisorRptId = child.PgThesisSupervisorRptIdSource.PgThesisSupervisorRptId;
						}
						else
						{
							child.PgThesisSupervisorRptId = entity.PgThesisSupervisorRptId;
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
	
	#region PgThesisSupervisorRptChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisSupervisorRpt</c>
	///</summary>
	public enum PgThesisSupervisorRptChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCdeRptRecommend</c> at PgCdeRptRecommendIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeRptRecommend))]
		PgCdeRptRecommend,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>PgThesisSupervisorComm</c> at PgThesisSupervisorCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisSupervisorComm))]
		PgThesisSupervisorComm,
		///<summary>
		/// Collection of <c>PgThesisSupervisorRpt</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisSupervisorRptChildEntityTypes
	
	#region PgThesisSupervisorRptFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisSupervisorRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSupervisorRptFilterBuilder : SqlFilterBuilder<PgThesisSupervisorRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptFilterBuilder class.
		/// </summary>
		public PgThesisSupervisorRptFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSupervisorRptFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSupervisorRptFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSupervisorRptFilterBuilder
	
	#region PgThesisSupervisorRptParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisSupervisorRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorRpt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSupervisorRptParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisSupervisorRptColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptParameterBuilder class.
		/// </summary>
		public PgThesisSupervisorRptParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSupervisorRptParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSupervisorRptParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSupervisorRptParameterBuilder
	
	#region PgThesisSupervisorRptSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisSupervisorRptColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorRpt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisSupervisorRptSortBuilder : SqlSortBuilder<PgThesisSupervisorRptColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorRptSqlSortBuilder class.
		/// </summary>
		public PgThesisSupervisorRptSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisSupervisorRptSortBuilder
	
} // end namespace
