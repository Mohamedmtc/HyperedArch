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
	/// This class is the base class for any <see cref="CoControlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoControlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoControl, UMIS_VER2.BusinessLyer.CoControlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlKey key)
		{
			return Delete(transactionManager, key.CoControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coControlId">فتح الكنترول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coControlId)
		{
			return Delete(null, _coControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">فتح الكنترول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coControlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		FK_CO_CONTROL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		FK_CO_CONTROL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		/// <remarks></remarks>
		public TList<CoControl> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		FK_CO_CONTROL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		fkCoControlAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		fkCoControlAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_AS_CODE_DEGREE_CLASS key.
		///		FK_CO_CONTROL_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public abstract TList<CoControl> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		FK_CO_CONTROL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		FK_CO_CONTROL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		/// <remarks></remarks>
		public TList<CoControl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		FK_CO_CONTROL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		fkCoControlEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		fkCoControlEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public TList<CoControl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONTROL_ED_CDE_EXAM_TYPE key.
		///		FK_CO_CONTROL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoControl objects.</returns>
		public abstract TList<CoControl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoControl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlKey key, int start, int pageLength)
		{
			return GetByCoControlId(transactionManager, key.CoControlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public abstract TList<CoControl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public abstract TList<CoControl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public abstract TList<CoControl> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public TList<CoControl> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControl&gt;"/> class.</returns>
		public abstract TList<CoControl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CONTROL index.
		/// </summary>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(null,_coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL index.
		/// </summary>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL index.
		/// </summary>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(System.Decimal _coControlId, int start, int pageLength, out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId">فتح الكنترول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControl GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_CONTROL index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(null,_edAcadYearId, _edCodeSemesterId, _entMainId, _edCdeExamTypeId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(null, _edAcadYearId, _edCodeSemesterId, _entMainId, _edCdeExamTypeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(transactionManager, _edAcadYearId, _edCodeSemesterId, _entMainId, _edCdeExamTypeId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(transactionManager, _edAcadYearId, _edCodeSemesterId, _entMainId, _edCdeExamTypeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL index.
		/// </summary>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(null, _edAcadYearId, _edCodeSemesterId, _entMainId, _edCdeExamTypeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام</param>
		/// <param name="_edCodeSemesterId">فصل</param>
		/// <param name="_entMainId">الكلية- الجامعة</param>
		/// <param name="_edCdeExamTypeId">دور اول - دور تانى</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControl GetByEdAcadYearIdEdCodeSemesterIdEntMainIdEdCdeExamTypeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId, System.Decimal? _edCdeExamTypeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoControl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoControl&gt;"/></returns>
		public static TList<CoControl> Fill(IDataReader reader, TList<CoControl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoControl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoControl")
					.Append("|").Append((System.Decimal)reader["CO_CONTROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoControl>(
					key.ToString(), // EntityTrackingKey
					"CoControl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoControl();
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
					c.CoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
					c.OriginalCoControlId = c.CoControlId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.ControlName = (System.String)reader["CONTROL_NAME"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.IsClosed = (System.Decimal)reader["IS_CLOSED"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproxDecNumFlg = (System.Decimal)reader["APPROX_DEC_NUM_FLG"];
					c.CreationDate = Convert.IsDBNull(reader["CREATION_DATE"]) ? null : (System.DateTime?)reader["CREATION_DATE"];
					c.ScrtNumCount = Convert.IsDBNull(reader["SCRT_NUM_COUNT"]) ? null : (System.Decimal?)reader["SCRT_NUM_COUNT"];
					c.ScrtNumAutoFlg = (System.Decimal)reader["SCRT_NUM_AUTO_FLG"];
					c.ScrtNumTypeFlg = (System.Decimal)reader["SCRT_NUM_TYPE_FLG"];
					c.ScrtNumApprvFlg = (System.Decimal)reader["SCRT_NUM_APPRV_FLG"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoControl entity)
		{
			if (!reader.Read()) return;
			
			entity.CoControlId = (System.Decimal)reader[((int)CoControlColumn.CoControlId - 1)];
			entity.OriginalCoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)CoControlColumn.EntMainId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)CoControlColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)CoControlColumn.EdCodeSemesterId - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)CoControlColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)CoControlColumn.EdCdeExamTypeId - 1)];
			entity.ControlName = (System.String)reader[((int)CoControlColumn.ControlName - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)CoControlColumn.SeUserId - 1)];
			entity.IsClosed = (System.Decimal)reader[((int)CoControlColumn.IsClosed - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoControlColumn.Notes - 1)))?null:(System.String)reader[((int)CoControlColumn.Notes - 1)];
			entity.ApproxDecNumFlg = (System.Decimal)reader[((int)CoControlColumn.ApproxDecNumFlg - 1)];
			entity.CreationDate = (reader.IsDBNull(((int)CoControlColumn.CreationDate - 1)))?null:(System.DateTime?)reader[((int)CoControlColumn.CreationDate - 1)];
			entity.ScrtNumCount = (reader.IsDBNull(((int)CoControlColumn.ScrtNumCount - 1)))?null:(System.Decimal?)reader[((int)CoControlColumn.ScrtNumCount - 1)];
			entity.ScrtNumAutoFlg = (System.Decimal)reader[((int)CoControlColumn.ScrtNumAutoFlg - 1)];
			entity.ScrtNumTypeFlg = (System.Decimal)reader[((int)CoControlColumn.ScrtNumTypeFlg - 1)];
			entity.ScrtNumApprvFlg = (System.Decimal)reader[((int)CoControlColumn.ScrtNumApprvFlg - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)CoControlColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)CoControlColumn.AsCodeDegreeClassId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoControl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.OriginalCoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.ControlName = (System.String)dataRow["CONTROL_NAME"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.IsClosed = (System.Decimal)dataRow["IS_CLOSED"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproxDecNumFlg = (System.Decimal)dataRow["APPROX_DEC_NUM_FLG"];
			entity.CreationDate = Convert.IsDBNull(dataRow["CREATION_DATE"]) ? null : (System.DateTime?)dataRow["CREATION_DATE"];
			entity.ScrtNumCount = Convert.IsDBNull(dataRow["SCRT_NUM_COUNT"]) ? null : (System.Decimal?)dataRow["SCRT_NUM_COUNT"];
			entity.ScrtNumAutoFlg = (System.Decimal)dataRow["SCRT_NUM_AUTO_FLG"];
			entity.ScrtNumTypeFlg = (System.Decimal)dataRow["SCRT_NUM_TYPE_FLG"];
			entity.ScrtNumApprvFlg = (System.Decimal)dataRow["SCRT_NUM_APPRV_FLG"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
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

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExamTypeId ?? 0.0m);
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, (entity.EdCdeExamTypeId ?? 0.0m));		
				
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

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoControlId methods when available
			
			#region CoControlRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlRoom>|CoControlRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlRoomCollection = DataRepository.CoControlRoomProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoControlRoomCollection.Count > 0)
				{
					deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlRoom>) DataRepository.CoControlRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlRoomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamCommitteeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommittee>|CoExamCommitteeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommitteeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommitteeCollection = DataRepository.CoExamCommitteeProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoExamCommitteeCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommitteeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommittee>) DataRepository.CoExamCommitteeProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommitteeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamCommSupervisorAltCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommSupervisorAlt>|CoExamCommSupervisorAltCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommSupervisorAltCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommSupervisorAltCollection = DataRepository.CoExamCommSupervisorAltProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoExamCommSupervisorAltCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommSupervisorAltCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommSupervisorAlt>) DataRepository.CoExamCommSupervisorAltProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommSupervisorAltCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudCheat>|CoStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudCheatCollection = DataRepository.CoStudCheatProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoStudCheatCollection.Count > 0)
				{
					deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudCheat>) DataRepository.CoStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlMember>|CoControlMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlMemberCollection = DataRepository.CoControlMemberProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoControlMemberCollection.Count > 0)
				{
					deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlMember>) DataRepository.CoControlMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoSupervisorStudCountCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoSupervisorStudCount>|CoSupervisorStudCountCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoSupervisorStudCountCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoSupervisorStudCountCollection = DataRepository.CoSupervisorStudCountProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoSupervisorStudCountCollection.Count > 0)
				{
					deepHandles.Add("CoSupervisorStudCountCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoSupervisorStudCount>) DataRepository.CoSupervisorStudCountProvider.DeepLoad,
						new object[] { transactionManager, entity.CoSupervisorStudCountCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudSecretNumCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudSecretNumCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudSecretNumCollection = DataRepository.CoStudSecretNumProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoStudSecretNumCollection.Count > 0)
				{
					deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudSecretNum>) DataRepository.CoStudSecretNumProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudSecretNumCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamPaperCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamPaper>|CoExamPaperCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamPaperCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamPaperCollection = DataRepository.CoExamPaperProvider.GetByCoControlId(transactionManager, entity.CoControlId);

				if (deep && entity.CoExamPaperCollection.Count > 0)
				{
					deepHandles.Add("CoExamPaperCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamPaper>) DataRepository.CoExamPaperProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamPaperCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoControl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoControl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoControlRoom>
				if (CanDeepSave(entity.CoControlRoomCollection, "List<CoControlRoom>|CoControlRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlRoom child in entity.CoControlRoomCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoControlRoomCollection.Count > 0 || entity.CoControlRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomCollection);
						
						deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlRoom >) DataRepository.CoControlRoomProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlRoomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamCommittee>
				if (CanDeepSave(entity.CoExamCommitteeCollection, "List<CoExamCommittee>|CoExamCommitteeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommittee child in entity.CoExamCommitteeCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoExamCommitteeCollection.Count > 0 || entity.CoExamCommitteeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommitteeProvider.Save(transactionManager, entity.CoExamCommitteeCollection);
						
						deepHandles.Add("CoExamCommitteeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommittee >) DataRepository.CoExamCommitteeProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommitteeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamCommSupervisorAlt>
				if (CanDeepSave(entity.CoExamCommSupervisorAltCollection, "List<CoExamCommSupervisorAlt>|CoExamCommSupervisorAltCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommSupervisorAlt child in entity.CoExamCommSupervisorAltCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoExamCommSupervisorAltCollection.Count > 0 || entity.CoExamCommSupervisorAltCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommSupervisorAltProvider.Save(transactionManager, entity.CoExamCommSupervisorAltCollection);
						
						deepHandles.Add("CoExamCommSupervisorAltCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommSupervisorAlt >) DataRepository.CoExamCommSupervisorAltProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommSupervisorAltCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudCheat>
				if (CanDeepSave(entity.CoStudCheatCollection, "List<CoStudCheat>|CoStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudCheat child in entity.CoStudCheatCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoStudCheatCollection.Count > 0 || entity.CoStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudCheatProvider.Save(transactionManager, entity.CoStudCheatCollection);
						
						deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudCheat >) DataRepository.CoStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControlMember>
				if (CanDeepSave(entity.CoControlMemberCollection, "List<CoControlMember>|CoControlMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlMember child in entity.CoControlMemberCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoControlMemberCollection.Count > 0 || entity.CoControlMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMemberCollection);
						
						deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlMember >) DataRepository.CoControlMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoSupervisorStudCount>
				if (CanDeepSave(entity.CoSupervisorStudCountCollection, "List<CoSupervisorStudCount>|CoSupervisorStudCountCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoSupervisorStudCount child in entity.CoSupervisorStudCountCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoSupervisorStudCountCollection.Count > 0 || entity.CoSupervisorStudCountCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoSupervisorStudCountProvider.Save(transactionManager, entity.CoSupervisorStudCountCollection);
						
						deepHandles.Add("CoSupervisorStudCountCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoSupervisorStudCount >) DataRepository.CoSupervisorStudCountProvider.DeepSave,
							new object[] { transactionManager, entity.CoSupervisorStudCountCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudSecretNum>
				if (CanDeepSave(entity.CoStudSecretNumCollection, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudSecretNum child in entity.CoStudSecretNumCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoStudSecretNumCollection.Count > 0 || entity.CoStudSecretNumCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudSecretNumProvider.Save(transactionManager, entity.CoStudSecretNumCollection);
						
						deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudSecretNum >) DataRepository.CoStudSecretNumProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudSecretNumCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamPaper>
				if (CanDeepSave(entity.CoExamPaperCollection, "List<CoExamPaper>|CoExamPaperCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamPaper child in entity.CoExamPaperCollection)
					{
						if(child.CoControlIdSource != null)
						{
							child.CoControlId = child.CoControlIdSource.CoControlId;
						}
						else
						{
							child.CoControlId = entity.CoControlId;
						}

					}

					if (entity.CoExamPaperCollection.Count > 0 || entity.CoExamPaperCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamPaperProvider.Save(transactionManager, entity.CoExamPaperCollection);
						
						deepHandles.Add("CoExamPaperCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamPaper >) DataRepository.CoExamPaperProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamPaperCollection, deepSaveType, childTypes, innerList }
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
	
	#region CoControlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoControl</c>
	///</summary>
	public enum CoControlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoControlRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlRoom>))]
		CoControlRoomCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoExamCommitteeCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommittee>))]
		CoExamCommitteeCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoExamCommSupervisorAltCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommSupervisorAlt>))]
		CoExamCommSupervisorAltCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudCheat>))]
		CoStudCheatCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoControlMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlMember>))]
		CoControlMemberCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoSupervisorStudCountCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoSupervisorStudCount>))]
		CoSupervisorStudCountCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoStudSecretNumCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudSecretNum>))]
		CoStudSecretNumCollection,
		///<summary>
		/// Collection of <c>CoControl</c> as OneToMany for CoExamPaperCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamPaper>))]
		CoExamPaperCollection,
	}
	
	#endregion CoControlChildEntityTypes
	
	#region CoControlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlFilterBuilder : SqlFilterBuilder<CoControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlFilterBuilder class.
		/// </summary>
		public CoControlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlFilterBuilder
	
	#region CoControlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlParameterBuilder : ParameterizedSqlFilterBuilder<CoControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlParameterBuilder class.
		/// </summary>
		public CoControlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlParameterBuilder
	
	#region CoControlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoControlSortBuilder : SqlSortBuilder<CoControlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlSqlSortBuilder class.
		/// </summary>
		public CoControlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoControlSortBuilder
	
} // end namespace
