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
	/// This class is the base class for any <see cref="MdiStudHosptlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudHosptlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudHosptl, UMIS_VER2.BusinessLyer.MdiStudHosptlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudHosptlKey key)
		{
			return Delete(transactionManager, key.MdiStudHosptlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudHosptlId)
		{
			return Delete(null, _mdiStudHosptlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudHosptlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudHosptl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		fkMdiStudHosptlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		fkMdiStudHosptlEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_HOSPTL_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public abstract TList<MdiStudHosptl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudHosptl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		fkMdiStudHosptlEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		fkMdiStudHosptlEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_HOSPTL_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public abstract TList<MdiStudHosptl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL Description: 
		/// </summary>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByMdiCdeHosptlId(System.Decimal? _mdiCdeHosptlId)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(_mdiCdeHosptlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudHosptl> GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal? _mdiCdeHosptlId)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(transactionManager, _mdiCdeHosptlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal? _mdiCdeHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(transactionManager, _mdiCdeHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		fkMdiStudHosptlMdiCdeHosptl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByMdiCdeHosptlId(System.Decimal? _mdiCdeHosptlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeHosptlId(null, _mdiCdeHosptlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		fkMdiStudHosptlMdiCdeHosptl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByMdiCdeHosptlId(System.Decimal? _mdiCdeHosptlId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeHosptlId(null, _mdiCdeHosptlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL key.
		///		FK_MDI_STUD_HOSPTL_MDI_CDE_HOSPTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public abstract TList<MdiStudHosptl> GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal? _mdiCdeHosptlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		FK_MDI_STUD_HSPTL_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		FK_MDI_STUD_HSPTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudHosptl> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		FK_MDI_STUD_HSPTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		fkMdiStudHsptlEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		fkMdiStudHsptlEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public TList<MdiStudHosptl> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_HSPTL_ED_STUD key.
		///		FK_MDI_STUD_HSPTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudHosptl objects.</returns>
		public abstract TList<MdiStudHosptl> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudHosptl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudHosptlKey key, int start, int pageLength)
		{
			return GetByMdiStudHosptlId(transactionManager, key.MdiStudHosptlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(System.Decimal _mdiStudHosptlId)
		{
			int count = -1;
			return GetByMdiStudHosptlId(null,_mdiStudHosptlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(System.Decimal _mdiStudHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudHosptlId(null, _mdiStudHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal _mdiStudHosptlId)
		{
			int count = -1;
			return GetByMdiStudHosptlId(transactionManager, _mdiStudHosptlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal _mdiStudHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudHosptlId(transactionManager, _mdiStudHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(System.Decimal _mdiStudHosptlId, int start, int pageLength, out int count)
		{
			return GetByMdiStudHosptlId(null, _mdiStudHosptlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_HSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudHosptlId">بيانات دخول مستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudHosptl GetByMdiStudHosptlId(TransactionManager transactionManager, System.Decimal _mdiStudHosptlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(null,_edAcadYearId, _edCodeSemesterId, _rqustNum, _entrncDatetime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(null, _edAcadYearId, _edCodeSemesterId, _rqustNum, _entrncDatetime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(transactionManager, _edAcadYearId, _edCodeSemesterId, _rqustNum, _entrncDatetime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(transactionManager, _edAcadYearId, _edCodeSemesterId, _rqustNum, _entrncDatetime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(null, _edAcadYearId, _edCodeSemesterId, _rqustNum, _entrncDatetime, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rqustNum"></param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdRqustNumEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.String _rqustNum, System.DateTime _entrncDatetime, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(null,_edAcadYearId, _edCodeSemesterId, _edStudId, _entrncDatetime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _entrncDatetime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _entrncDatetime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(transactionManager, _edAcadYearId, _edCodeSemesterId, _edStudId, _entrncDatetime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(null, _edAcadYearId, _edCodeSemesterId, _edStudId, _entrncDatetime, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_HOSPTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_entrncDatetime">تاريخ الدخول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudHosptl GetByEdAcadYearIdEdCodeSemesterIdEdStudIdEntrncDatetime(TransactionManager transactionManager, System.Decimal? _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal _edStudId, System.DateTime _entrncDatetime, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudHosptl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudHosptl&gt;"/></returns>
		public static TList<MdiStudHosptl> Fill(IDataReader reader, TList<MdiStudHosptl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudHosptl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudHosptl")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_HOSPTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudHosptl>(
					key.ToString(), // EntityTrackingKey
					"MdiStudHosptl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudHosptl();
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
					c.MdiStudHosptlId = (System.Decimal)reader["MDI_STUD_HOSPTL_ID"];
					c.OriginalMdiStudHosptlId = c.MdiStudHosptlId;
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.RqustNum = Convert.IsDBNull(reader["RQUST_NUM"]) ? null : (System.String)reader["RQUST_NUM"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.MdiCdeHosptlId = Convert.IsDBNull(reader["MDI_CDE_HOSPTL_ID"]) ? null : (System.Decimal?)reader["MDI_CDE_HOSPTL_ID"];
					c.EntrncDatetime = (System.DateTime)reader["ENTRNC_DATETIME"];
					c.ExitDatetime = Convert.IsDBNull(reader["EXIT_DATETIME"]) ? null : (System.DateTime?)reader["EXIT_DATETIME"];
					c.Complaint = Convert.IsDBNull(reader["COMPLAINT"]) ? null : (System.String)reader["COMPLAINT"];
					c.Treatment = Convert.IsDBNull(reader["TREATMENT"]) ? null : (System.String)reader["TREATMENT"];
					c.Recommend = Convert.IsDBNull(reader["RECOMMEND"]) ? null : (System.String)reader["RECOMMEND"];
					c.HosptlFlg = Convert.IsDBNull(reader["HOSPTL_FLG"]) ? null : (System.Decimal?)reader["HOSPTL_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudHosptl entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudHosptlId = (System.Decimal)reader[((int)MdiStudHosptlColumn.MdiStudHosptlId - 1)];
			entity.OriginalMdiStudHosptlId = (System.Decimal)reader["MDI_STUD_HOSPTL_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)MdiStudHosptlColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)MdiStudHosptlColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)MdiStudHosptlColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)MdiStudHosptlColumn.EdCodeSemesterId - 1)];
			entity.RqustNum = (reader.IsDBNull(((int)MdiStudHosptlColumn.RqustNum - 1)))?null:(System.String)reader[((int)MdiStudHosptlColumn.RqustNum - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)MdiStudHosptlColumn.EdStudId - 1)];
			entity.MdiCdeHosptlId = (reader.IsDBNull(((int)MdiStudHosptlColumn.MdiCdeHosptlId - 1)))?null:(System.Decimal?)reader[((int)MdiStudHosptlColumn.MdiCdeHosptlId - 1)];
			entity.EntrncDatetime = (System.DateTime)reader[((int)MdiStudHosptlColumn.EntrncDatetime - 1)];
			entity.ExitDatetime = (reader.IsDBNull(((int)MdiStudHosptlColumn.ExitDatetime - 1)))?null:(System.DateTime?)reader[((int)MdiStudHosptlColumn.ExitDatetime - 1)];
			entity.Complaint = (reader.IsDBNull(((int)MdiStudHosptlColumn.Complaint - 1)))?null:(System.String)reader[((int)MdiStudHosptlColumn.Complaint - 1)];
			entity.Treatment = (reader.IsDBNull(((int)MdiStudHosptlColumn.Treatment - 1)))?null:(System.String)reader[((int)MdiStudHosptlColumn.Treatment - 1)];
			entity.Recommend = (reader.IsDBNull(((int)MdiStudHosptlColumn.Recommend - 1)))?null:(System.String)reader[((int)MdiStudHosptlColumn.Recommend - 1)];
			entity.HosptlFlg = (reader.IsDBNull(((int)MdiStudHosptlColumn.HosptlFlg - 1)))?null:(System.Decimal?)reader[((int)MdiStudHosptlColumn.HosptlFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudHosptlColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudHosptlColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudHosptl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudHosptlId = (System.Decimal)dataRow["MDI_STUD_HOSPTL_ID"];
			entity.OriginalMdiStudHosptlId = (System.Decimal)dataRow["MDI_STUD_HOSPTL_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.RqustNum = Convert.IsDBNull(dataRow["RQUST_NUM"]) ? null : (System.String)dataRow["RQUST_NUM"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.MdiCdeHosptlId = Convert.IsDBNull(dataRow["MDI_CDE_HOSPTL_ID"]) ? null : (System.Decimal?)dataRow["MDI_CDE_HOSPTL_ID"];
			entity.EntrncDatetime = (System.DateTime)dataRow["ENTRNC_DATETIME"];
			entity.ExitDatetime = Convert.IsDBNull(dataRow["EXIT_DATETIME"]) ? null : (System.DateTime?)dataRow["EXIT_DATETIME"];
			entity.Complaint = Convert.IsDBNull(dataRow["COMPLAINT"]) ? null : (System.String)dataRow["COMPLAINT"];
			entity.Treatment = Convert.IsDBNull(dataRow["TREATMENT"]) ? null : (System.String)dataRow["TREATMENT"];
			entity.Recommend = Convert.IsDBNull(dataRow["RECOMMEND"]) ? null : (System.String)dataRow["RECOMMEND"];
			entity.HosptlFlg = Convert.IsDBNull(dataRow["HOSPTL_FLG"]) ? null : (System.Decimal?)dataRow["HOSPTL_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudHosptl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudHosptl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudHosptl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

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

			#region MdiCdeHosptlIdSource	
			if (CanDeepLoad(entity, "MdiCdeHosptl|MdiCdeHosptlIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeHosptlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MdiCdeHosptlId ?? 0.0m);
				MdiCdeHosptl tmpEntity = EntityManager.LocateEntity<MdiCdeHosptl>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeHosptl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeHosptlIdSource = tmpEntity;
				else
					entity.MdiCdeHosptlIdSource = DataRepository.MdiCdeHosptlProvider.GetByMdiCdeHosptlId(transactionManager, (entity.MdiCdeHosptlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeHosptlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeHosptlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeHosptlProvider.DeepLoad(transactionManager, entity.MdiCdeHosptlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeHosptlIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiStudHosptlId methods when available
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByMdiStudHosptlId(transactionManager, entity.MdiStudHosptlId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudHosptl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudHosptl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudHosptl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudHosptl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
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
			
			#region MdiCdeHosptlIdSource
			if (CanDeepSave(entity, "MdiCdeHosptl|MdiCdeHosptlIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeHosptlIdSource != null)
			{
				DataRepository.MdiCdeHosptlProvider.Save(transactionManager, entity.MdiCdeHosptlIdSource);
				entity.MdiCdeHosptlId = entity.MdiCdeHosptlIdSource.MdiCdeHosptlId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.MdiStudHosptlIdSource != null)
						{
							child.MdiStudHosptlId = child.MdiStudHosptlIdSource.MdiStudHosptlId;
						}
						else
						{
							child.MdiStudHosptlId = entity.MdiStudHosptlId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiStudHosptlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudHosptl</c>
	///</summary>
	public enum MdiStudHosptlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>MdiCdeHosptl</c> at MdiCdeHosptlIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeHosptl))]
		MdiCdeHosptl,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		///<summary>
		/// Collection of <c>MdiStudHosptl</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
	}
	
	#endregion MdiStudHosptlChildEntityTypes
	
	#region MdiStudHosptlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudHosptl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudHosptlFilterBuilder : SqlFilterBuilder<MdiStudHosptlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlFilterBuilder class.
		/// </summary>
		public MdiStudHosptlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudHosptlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudHosptlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudHosptlFilterBuilder
	
	#region MdiStudHosptlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudHosptl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudHosptlParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudHosptlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlParameterBuilder class.
		/// </summary>
		public MdiStudHosptlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudHosptlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudHosptlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudHosptlParameterBuilder
	
	#region MdiStudHosptlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudHosptl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudHosptlSortBuilder : SqlSortBuilder<MdiStudHosptlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudHosptlSqlSortBuilder class.
		/// </summary>
		public MdiStudHosptlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudHosptlSortBuilder
	
} // end namespace
