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
	/// This class is the base class for any <see cref="EdSemesterAgendaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemesterAgendaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdSemesterAgenda, UMIS_VER2.BusinessLyer.EdSemesterAgendaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterAgendaKey key)
		{
			return Delete(transactionManager, key.EdSemesterAgendaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edSemesterAgendaId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edSemesterAgendaId)
		{
			return Delete(null, _edSemesterAgendaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		fkEdSemesterAgendaAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		fkEdSemesterAgendaAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ED_SEMESTER_AGENDA_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public abstract TList<EdSemesterAgenda> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		fkEdSemesterAgendaAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		fkEdSemesterAgendaAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public abstract TList<EdSemesterAgenda> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		fkEdSemesterAgendaAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		fkEdSemesterAgendaAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_SEMESTER_AGENDA_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemesterAgenda objects.</returns>
		public abstract TList<EdSemesterAgenda> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdSemesterAgenda Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterAgendaKey key, int start, int pageLength)
		{
			return GetByEdSemesterAgendaId(transactionManager, key.EdSemesterAgendaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null,_edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemActvityId(transactionManager, _edCodeSemActvityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdCodeSemActvityId(System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemActvityId(null, _edCodeSemActvityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEM_ACTVITY__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public abstract TList<EdSemesterAgenda> GetByEdCodeSemActvityId(TransactionManager transactionManager, System.Decimal _edCodeSemActvityId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdSemesterOpenId(System.Decimal? _edSemesterOpenId)
		{
			int count = -1;
			return GetByEdSemesterOpenId(null,_edSemesterOpenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdSemesterOpenId(System.Decimal? _edSemesterOpenId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenId(null, _edSemesterOpenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId)
		{
			int count = -1;
			return GetByEdSemesterOpenId(transactionManager, _edSemesterOpenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenId(transactionManager, _edSemesterOpenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public TList<EdSemesterAgenda> GetByEdSemesterOpenId(System.Decimal? _edSemesterOpenId, int start, int pageLength, out int count)
		{
			return GetByEdSemesterOpenId(null, _edSemesterOpenId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_SEMESTER_OPEN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdSemesterAgenda&gt;"/> class.</returns>
		public abstract TList<EdSemesterAgenda> GetByEdSemesterOpenId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterAgendaId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(null,_edSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength, out int count)
		{
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(null,_edSemesterOpenId, _edCodeSemActvityId, _asCodeDegreeClassId, _asCodeDegreeId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(null, _edSemesterOpenId, _edCodeSemActvityId, _asCodeDegreeClassId, _asCodeDegreeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(transactionManager, _edSemesterOpenId, _edCodeSemActvityId, _asCodeDegreeClassId, _asCodeDegreeId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(transactionManager, _edSemesterOpenId, _edCodeSemActvityId, _asCodeDegreeClassId, _asCodeDegreeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(null, _edSemesterOpenId, _edCodeSemActvityId, _asCodeDegreeClassId, _asCodeDegreeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_SEMESTER_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterOpenId"></param>
		/// <param name="_edCodeSemActvityId"></param>
		/// <param name="_asCodeDegreeClassId">UG/PG</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_admOpenAcadSemesterId">Ejust</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemesterAgenda GetByEdSemesterOpenIdEdCodeSemActvityIdAsCodeDegreeClassIdAsCodeDegreeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _edSemesterOpenId, System.Decimal _edCodeSemActvityId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _asCodeDegreeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdSemesterAgenda&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdSemesterAgenda&gt;"/></returns>
		public static TList<EdSemesterAgenda> Fill(IDataReader reader, TList<EdSemesterAgenda> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdSemesterAgenda c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdSemesterAgenda")
					.Append("|").Append((System.Decimal)reader["ED_SEMESTER_AGENDA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdSemesterAgenda>(
					key.ToString(), // EntityTrackingKey
					"EdSemesterAgenda",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdSemesterAgenda();
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
					c.EdSemesterAgendaId = (System.Decimal)reader["ED_SEMESTER_AGENDA_ID"];
					c.OriginalEdSemesterAgendaId = c.EdSemesterAgendaId;
					c.EdSemesterOpenId = Convert.IsDBNull(reader["ED_SEMESTER_OPEN_ID"]) ? null : (System.Decimal?)reader["ED_SEMESTER_OPEN_ID"];
					c.AdmOpenAcadSemesterId = Convert.IsDBNull(reader["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.EdCodeSemActvityId = (System.Decimal)reader["ED_CODE_SEM_ACTVITY_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EmailFlg = Convert.IsDBNull(reader["EMAIL_FLG"]) ? null : (System.Decimal?)reader["EMAIL_FLG"];
					c.EmpFlg = Convert.IsDBNull(reader["EMP_FLG"]) ? null : (System.Decimal?)reader["EMP_FLG"];
					c.StfFlg = Convert.IsDBNull(reader["STF_FLG"]) ? null : (System.Decimal?)reader["STF_FLG"];
					c.StudFlg = Convert.IsDBNull(reader["STUD_FLG"]) ? null : (System.Decimal?)reader["STUD_FLG"];
					c.OnlineFlg = (System.Decimal)reader["ONLINE_FLG"];
					c.ToDateAct = Convert.IsDBNull(reader["TO_DATE_ACT"]) ? null : (System.DateTime?)reader["TO_DATE_ACT"];
					c.ShowFlg = Convert.IsDBNull(reader["SHOW_FLG"]) ? null : (System.Decimal?)reader["SHOW_FLG"];
					c.NewComrFlg = Convert.IsDBNull(reader["NEW_COMR_FLG"]) ? null : (System.Boolean?)reader["NEW_COMR_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.AudtNote = Convert.IsDBNull(reader["AUDT_NOTE"]) ? null : (System.String)reader["AUDT_NOTE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.FeeRefundPrcnt = Convert.IsDBNull(reader["FEE_REFUND_PRCNT"]) ? null : (System.Decimal?)reader["FEE_REFUND_PRCNT"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdSemesterAgenda entity)
		{
			if (!reader.Read()) return;
			
			entity.EdSemesterAgendaId = (System.Decimal)reader[((int)EdSemesterAgendaColumn.EdSemesterAgendaId - 1)];
			entity.OriginalEdSemesterAgendaId = (System.Decimal)reader["ED_SEMESTER_AGENDA_ID"];
			entity.EdSemesterOpenId = (reader.IsDBNull(((int)EdSemesterAgendaColumn.EdSemesterOpenId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.EdSemesterOpenId - 1)];
			entity.AdmOpenAcadSemesterId = (reader.IsDBNull(((int)EdSemesterAgendaColumn.AdmOpenAcadSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.AdmOpenAcadSemesterId - 1)];
			entity.EdCodeSemActvityId = (System.Decimal)reader[((int)EdSemesterAgendaColumn.EdCodeSemActvityId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)EdSemesterAgendaColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)EdSemesterAgendaColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)EdSemesterAgendaColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)EdSemesterAgendaColumn.ToDate - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdSemesterAgendaColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdSemesterAgendaColumn.DescrEn - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EdSemesterAgendaColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.AsCodeDegreeClassId - 1)];
			entity.EmailFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.EmailFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.EmailFlg - 1)];
			entity.EmpFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.EmpFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.EmpFlg - 1)];
			entity.StfFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.StfFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.StfFlg - 1)];
			entity.StudFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.StudFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.StudFlg - 1)];
			entity.OnlineFlg = (System.Decimal)reader[((int)EdSemesterAgendaColumn.OnlineFlg - 1)];
			entity.ToDateAct = (reader.IsDBNull(((int)EdSemesterAgendaColumn.ToDateAct - 1)))?null:(System.DateTime?)reader[((int)EdSemesterAgendaColumn.ToDateAct - 1)];
			entity.ShowFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.ShowFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.ShowFlg - 1)];
			entity.NewComrFlg = (reader.IsDBNull(((int)EdSemesterAgendaColumn.NewComrFlg - 1)))?null:(System.Boolean?)reader[((int)EdSemesterAgendaColumn.NewComrFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdSemesterAgendaColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdSemesterAgendaColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdSemesterAgendaColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.SeUserId - 1)];
			entity.AudtNote = (reader.IsDBNull(((int)EdSemesterAgendaColumn.AudtNote - 1)))?null:(System.String)reader[((int)EdSemesterAgendaColumn.AudtNote - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdSemesterAgendaColumn.Notes - 1)))?null:(System.String)reader[((int)EdSemesterAgendaColumn.Notes - 1)];
			entity.FeeRefundPrcnt = (reader.IsDBNull(((int)EdSemesterAgendaColumn.FeeRefundPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.FeeRefundPrcnt - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdSemesterAgendaColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdSemesterAgendaColumn.AsCodeDegreeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdSemesterAgenda entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdSemesterAgendaId = (System.Decimal)dataRow["ED_SEMESTER_AGENDA_ID"];
			entity.OriginalEdSemesterAgendaId = (System.Decimal)dataRow["ED_SEMESTER_AGENDA_ID"];
			entity.EdSemesterOpenId = Convert.IsDBNull(dataRow["ED_SEMESTER_OPEN_ID"]) ? null : (System.Decimal?)dataRow["ED_SEMESTER_OPEN_ID"];
			entity.AdmOpenAcadSemesterId = Convert.IsDBNull(dataRow["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.EdCodeSemActvityId = (System.Decimal)dataRow["ED_CODE_SEM_ACTVITY_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.EmailFlg = Convert.IsDBNull(dataRow["EMAIL_FLG"]) ? null : (System.Decimal?)dataRow["EMAIL_FLG"];
			entity.EmpFlg = Convert.IsDBNull(dataRow["EMP_FLG"]) ? null : (System.Decimal?)dataRow["EMP_FLG"];
			entity.StfFlg = Convert.IsDBNull(dataRow["STF_FLG"]) ? null : (System.Decimal?)dataRow["STF_FLG"];
			entity.StudFlg = Convert.IsDBNull(dataRow["STUD_FLG"]) ? null : (System.Decimal?)dataRow["STUD_FLG"];
			entity.OnlineFlg = (System.Decimal)dataRow["ONLINE_FLG"];
			entity.ToDateAct = Convert.IsDBNull(dataRow["TO_DATE_ACT"]) ? null : (System.DateTime?)dataRow["TO_DATE_ACT"];
			entity.ShowFlg = Convert.IsDBNull(dataRow["SHOW_FLG"]) ? null : (System.Decimal?)dataRow["SHOW_FLG"];
			entity.NewComrFlg = Convert.IsDBNull(dataRow["NEW_COMR_FLG"]) ? null : (System.Boolean?)dataRow["NEW_COMR_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.AudtNote = Convert.IsDBNull(dataRow["AUDT_NOTE"]) ? null : (System.String)dataRow["AUDT_NOTE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.FeeRefundPrcnt = Convert.IsDBNull(dataRow["FEE_REFUND_PRCNT"]) ? null : (System.Decimal?)dataRow["FEE_REFUND_PRCNT"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemesterAgenda"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemesterAgenda Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterAgenda entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmOpenAcadSemesterId ?? 0.0m);
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, (entity.AdmOpenAcadSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

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

			#region EdCodeSemActvityIdSource	
			if (CanDeepLoad(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemActvityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemActvityId;
				EdCodeSemActvity tmpEntity = EntityManager.LocateEntity<EdCodeSemActvity>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemActvity), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemActvityIdSource = tmpEntity;
				else
					entity.EdCodeSemActvityIdSource = DataRepository.EdCodeSemActvityProvider.GetByEdCodeSemActvityId(transactionManager, entity.EdCodeSemActvityId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemActvityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemActvityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemActvityProvider.DeepLoad(transactionManager, entity.EdCodeSemActvityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemActvityIdSource

			#region EdSemesterOpenIdSource	
			if (CanDeepLoad(entity, "EdSemesterOpen|EdSemesterOpenIdSource", deepLoadType, innerList) 
				&& entity.EdSemesterOpenIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdSemesterOpenId ?? 0.0m);
				EdSemesterOpen tmpEntity = EntityManager.LocateEntity<EdSemesterOpen>(EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterOpen), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdSemesterOpenIdSource = tmpEntity;
				else
					entity.EdSemesterOpenIdSource = DataRepository.EdSemesterOpenProvider.GetByEdSemesterOpenId(transactionManager, (entity.EdSemesterOpenId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdSemesterOpenIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdSemesterOpenProvider.DeepLoad(transactionManager, entity.EdSemesterOpenIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdSemesterOpenIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdSemesterAgendaId methods when available
			
			#region EdSemAgendaFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaForm>|EdSemAgendaFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaFormCollection = DataRepository.EdSemAgendaFormProvider.GetByEdSemesterAgendaId(transactionManager, entity.EdSemesterAgendaId);

				if (deep && entity.EdSemAgendaFormCollection.Count > 0)
				{
					deepHandles.Add("EdSemAgendaFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaForm>) DataRepository.EdSemAgendaFormProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaFormCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaDtlCollection = DataRepository.EdSemAgendaDtlProvider.GetByEdSemesterAgendaId(transactionManager, entity.EdSemesterAgendaId);

				if (deep && entity.EdSemAgendaDtlCollection.Count > 0)
				{
					deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaDtl>) DataRepository.EdSemAgendaDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdSemesterAgenda object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdSemesterAgenda instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemesterAgenda Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterAgenda entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
			#region EdCodeSemActvityIdSource
			if (CanDeepSave(entity, "EdCodeSemActvity|EdCodeSemActvityIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemActvityIdSource != null)
			{
				DataRepository.EdCodeSemActvityProvider.Save(transactionManager, entity.EdCodeSemActvityIdSource);
				entity.EdCodeSemActvityId = entity.EdCodeSemActvityIdSource.EdCodeSemActvityId;
			}
			#endregion 
			
			#region EdSemesterOpenIdSource
			if (CanDeepSave(entity, "EdSemesterOpen|EdSemesterOpenIdSource", deepSaveType, innerList) 
				&& entity.EdSemesterOpenIdSource != null)
			{
				DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenIdSource);
				entity.EdSemesterOpenId = entity.EdSemesterOpenIdSource.EdSemesterOpenId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdSemAgendaForm>
				if (CanDeepSave(entity.EdSemAgendaFormCollection, "List<EdSemAgendaForm>|EdSemAgendaFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaForm child in entity.EdSemAgendaFormCollection)
					{
						if(child.EdSemesterAgendaIdSource != null)
						{
							child.EdSemesterAgendaId = child.EdSemesterAgendaIdSource.EdSemesterAgendaId;
						}
						else
						{
							child.EdSemesterAgendaId = entity.EdSemesterAgendaId;
						}

					}

					if (entity.EdSemAgendaFormCollection.Count > 0 || entity.EdSemAgendaFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaFormProvider.Save(transactionManager, entity.EdSemAgendaFormCollection);
						
						deepHandles.Add("EdSemAgendaFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaForm >) DataRepository.EdSemAgendaFormProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaFormCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemAgendaDtl>
				if (CanDeepSave(entity.EdSemAgendaDtlCollection, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaDtl child in entity.EdSemAgendaDtlCollection)
					{
						if(child.EdSemesterAgendaIdSource != null)
						{
							child.EdSemesterAgendaId = child.EdSemesterAgendaIdSource.EdSemesterAgendaId;
						}
						else
						{
							child.EdSemesterAgendaId = entity.EdSemesterAgendaId;
						}

					}

					if (entity.EdSemAgendaDtlCollection.Count > 0 || entity.EdSemAgendaDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaDtlProvider.Save(transactionManager, entity.EdSemAgendaDtlCollection);
						
						deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaDtl >) DataRepository.EdSemAgendaDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdSemesterAgendaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdSemesterAgenda</c>
	///</summary>
	public enum EdSemesterAgendaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemActvity</c> at EdCodeSemActvityIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemActvity))]
		EdCodeSemActvity,
		
		///<summary>
		/// Composite Property for <c>EdSemesterOpen</c> at EdSemesterOpenIdSource
		///</summary>
		[ChildEntityType(typeof(EdSemesterOpen))]
		EdSemesterOpen,
		///<summary>
		/// Collection of <c>EdSemesterAgenda</c> as OneToMany for EdSemAgendaFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaForm>))]
		EdSemAgendaFormCollection,
		///<summary>
		/// Collection of <c>EdSemesterAgenda</c> as OneToMany for EdSemAgendaDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaDtl>))]
		EdSemAgendaDtlCollection,
	}
	
	#endregion EdSemesterAgendaChildEntityTypes
	
	#region EdSemesterAgendaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemesterAgendaFilterBuilder : SqlFilterBuilder<EdSemesterAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaFilterBuilder class.
		/// </summary>
		public EdSemesterAgendaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemesterAgendaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemesterAgendaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemesterAgendaFilterBuilder
	
	#region EdSemesterAgendaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemesterAgendaParameterBuilder : ParameterizedSqlFilterBuilder<EdSemesterAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaParameterBuilder class.
		/// </summary>
		public EdSemesterAgendaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemesterAgendaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemesterAgendaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemesterAgendaParameterBuilder
	
	#region EdSemesterAgendaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdSemesterAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemesterAgenda"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdSemesterAgendaSortBuilder : SqlSortBuilder<EdSemesterAgendaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemesterAgendaSqlSortBuilder class.
		/// </summary>
		public EdSemesterAgendaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdSemesterAgendaSortBuilder
	
} // end namespace
