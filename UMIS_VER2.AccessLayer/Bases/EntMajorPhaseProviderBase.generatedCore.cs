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
	/// This class is the base class for any <see cref="EntMajorPhaseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntMajorPhaseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntMajorPhase, UMIS_VER2.BusinessLyer.EntMajorPhaseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseKey key)
		{
			return Delete(transactionManager, key.EntMajorPhaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entMajorPhaseId)
		{
			return Delete(null, _entMajorPhaseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entMajorPhaseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(_edCodeLevelFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhase> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(transactionManager, _edCodeLevelFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(transactionManager, _edCodeLevelFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		fkEntMajorPhaseEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelFromId(null, _edCodeLevelFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		fkEntMajorPhaseEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelFromId(null, _edCodeLevelFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public abstract TList<EntMajorPhase> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="_edCodeLevelToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelToId(System.Decimal _edCodeLevelToId)
		{
			int count = -1;
			return GetByEdCodeLevelToId(_edCodeLevelToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhase> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal _edCodeLevelToId)
		{
			int count = -1;
			return GetByEdCodeLevelToId(transactionManager, _edCodeLevelToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal _edCodeLevelToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelToId(transactionManager, _edCodeLevelToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		fkEntMajorPhaseEdCodeLevel1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelToId(System.Decimal _edCodeLevelToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelToId(null, _edCodeLevelToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		fkEntMajorPhaseEdCodeLevel1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeLevelToId(System.Decimal _edCodeLevelToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelToId(null, _edCodeLevelToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public abstract TList<EntMajorPhase> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal _edCodeLevelToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterFromId(System.Decimal _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(_edCodeSemesterFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhase> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal _edCodeSemesterFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		fkEntMajorPhaseEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterFromId(System.Decimal _edCodeSemesterFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		fkEntMajorPhaseEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterFromId(System.Decimal _edCodeSemesterFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public abstract TList<EntMajorPhase> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal _edCodeSemesterFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterToId(System.Decimal _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(_edCodeSemesterToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhase> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal _edCodeSemesterToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		fkEntMajorPhaseEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterToId(System.Decimal _edCodeSemesterToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		fkEntMajorPhaseEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEdCodeSemesterToId(System.Decimal _edCodeSemesterToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 key.
		///		FK_ENT_MAJOR_PHASE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public abstract TList<EntMajorPhase> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal _edCodeSemesterToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		FK_ENT_MAJOR_PHASE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		FK_ENT_MAJOR_PHASE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhase> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		FK_ENT_MAJOR_PHASE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		fkEntMajorPhaseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		fkEntMajorPhaseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public TList<EntMajorPhase> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_ENTITY_MAIN key.
		///		FK_ENT_MAJOR_PHASE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">تخصص رئيسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhase objects.</returns>
		public abstract TList<EntMajorPhase> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntMajorPhase Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseKey key, int start, int pageLength)
		{
			return GetByEntMajorPhaseId(transactionManager, key.EntMajorPhaseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(null,_entMajorPhaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId, int start, int pageLength, out int count)
		{
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntMajorPhase GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntMajorPhase&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntMajorPhase&gt;"/></returns>
		public static TList<EntMajorPhase> Fill(IDataReader reader, TList<EntMajorPhase> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntMajorPhase c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntMajorPhase")
					.Append("|").Append((System.Decimal)reader["ENT_MAJOR_PHASE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntMajorPhase>(
					key.ToString(), // EntityTrackingKey
					"EntMajorPhase",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntMajorPhase();
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
					c.EntMajorPhaseId = (System.Decimal)reader["ENT_MAJOR_PHASE_ID"];
					c.OriginalEntMajorPhaseId = c.EntMajorPhaseId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.PhaseAr = Convert.IsDBNull(reader["PHASE_AR"]) ? null : (System.String)reader["PHASE_AR"];
					c.PhaseEn = Convert.IsDBNull(reader["PHASE_EN"]) ? null : (System.String)reader["PHASE_EN"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.EdCodeLevelFromId = Convert.IsDBNull(reader["ED_CODE_LEVEL_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_FROM_ID"];
					c.EdCodeSemesterFromId = (System.Decimal)reader["ED_CODE_SEMESTER_FROM_ID"];
					c.EdCodeLevelToId = (System.Decimal)reader["ED_CODE_LEVEL_TO_ID"];
					c.EdCodeSemesterToId = (System.Decimal)reader["ED_CODE_SEMESTER_TO_ID"];
					c.PhasePeriod = Convert.IsDBNull(reader["PHASE_PERIOD"]) ? null : (System.Decimal?)reader["PHASE_PERIOD"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.PassCrsFlg = Convert.IsDBNull(reader["PASS_CRS_FLG"]) ? null : (System.Boolean?)reader["PASS_CRS_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntMajorPhase entity)
		{
			if (!reader.Read()) return;
			
			entity.EntMajorPhaseId = (System.Decimal)reader[((int)EntMajorPhaseColumn.EntMajorPhaseId - 1)];
			entity.OriginalEntMajorPhaseId = (System.Decimal)reader["ENT_MAJOR_PHASE_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EntMajorPhaseColumn.EntMainId - 1)];
			entity.PhaseAr = (reader.IsDBNull(((int)EntMajorPhaseColumn.PhaseAr - 1)))?null:(System.String)reader[((int)EntMajorPhaseColumn.PhaseAr - 1)];
			entity.PhaseEn = (reader.IsDBNull(((int)EntMajorPhaseColumn.PhaseEn - 1)))?null:(System.String)reader[((int)EntMajorPhaseColumn.PhaseEn - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)EntMajorPhaseColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)EntMajorPhaseColumn.CoursePoint - 1)];
			entity.EdCodeLevelFromId = (reader.IsDBNull(((int)EntMajorPhaseColumn.EdCodeLevelFromId - 1)))?null:(System.Decimal?)reader[((int)EntMajorPhaseColumn.EdCodeLevelFromId - 1)];
			entity.EdCodeSemesterFromId = (System.Decimal)reader[((int)EntMajorPhaseColumn.EdCodeSemesterFromId - 1)];
			entity.EdCodeLevelToId = (System.Decimal)reader[((int)EntMajorPhaseColumn.EdCodeLevelToId - 1)];
			entity.EdCodeSemesterToId = (System.Decimal)reader[((int)EntMajorPhaseColumn.EdCodeSemesterToId - 1)];
			entity.PhasePeriod = (reader.IsDBNull(((int)EntMajorPhaseColumn.PhasePeriod - 1)))?null:(System.Decimal?)reader[((int)EntMajorPhaseColumn.PhasePeriod - 1)];
			entity.Notes = (reader.IsDBNull(((int)EntMajorPhaseColumn.Notes - 1)))?null:(System.String)reader[((int)EntMajorPhaseColumn.Notes - 1)];
			entity.PassCrsFlg = (reader.IsDBNull(((int)EntMajorPhaseColumn.PassCrsFlg - 1)))?null:(System.Boolean?)reader[((int)EntMajorPhaseColumn.PassCrsFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntMajorPhaseColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntMajorPhaseColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntMajorPhaseColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntMajorPhaseColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntMajorPhase entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMajorPhaseId = (System.Decimal)dataRow["ENT_MAJOR_PHASE_ID"];
			entity.OriginalEntMajorPhaseId = (System.Decimal)dataRow["ENT_MAJOR_PHASE_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.PhaseAr = Convert.IsDBNull(dataRow["PHASE_AR"]) ? null : (System.String)dataRow["PHASE_AR"];
			entity.PhaseEn = Convert.IsDBNull(dataRow["PHASE_EN"]) ? null : (System.String)dataRow["PHASE_EN"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.EdCodeLevelFromId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_FROM_ID"];
			entity.EdCodeSemesterFromId = (System.Decimal)dataRow["ED_CODE_SEMESTER_FROM_ID"];
			entity.EdCodeLevelToId = (System.Decimal)dataRow["ED_CODE_LEVEL_TO_ID"];
			entity.EdCodeSemesterToId = (System.Decimal)dataRow["ED_CODE_SEMESTER_TO_ID"];
			entity.PhasePeriod = Convert.IsDBNull(dataRow["PHASE_PERIOD"]) ? null : (System.Decimal?)dataRow["PHASE_PERIOD"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.PassCrsFlg = Convert.IsDBNull(dataRow["PASS_CRS_FLG"]) ? null : (System.Boolean?)dataRow["PASS_CRS_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhase"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMajorPhase Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhase entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeLevelFromIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelFromIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelFromId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelFromIdSource = tmpEntity;
				else
					entity.EdCodeLevelFromIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelFromIdSource

			#region EdCodeLevelToIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelToIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeLevelToId;
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelToIdSource = tmpEntity;
				else
					entity.EdCodeLevelToIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelToId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelToIdSource

			#region EdCodeSemesterFromIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterFromIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterFromId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterFromIdSource = tmpEntity;
				else
					entity.EdCodeSemesterFromIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterFromId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterFromIdSource

			#region EdCodeSemesterToIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterToId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterToIdSource = tmpEntity;
				else
					entity.EdCodeSemesterToIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterToId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterToIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntMajorPhaseId methods when available
			
			#region EntMajorPhaseCrsExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhaseCrsExp>|EntMajorPhaseCrsExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCrsExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCrsExpCollection = DataRepository.EntMajorPhaseCrsExpProvider.GetByEntMajorPhaseId(transactionManager, entity.EntMajorPhaseId);

				if (deep && entity.EntMajorPhaseCrsExpCollection.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCrsExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhaseCrsExp>) DataRepository.EntMajorPhaseCrsExpProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCrsExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterExtCollection = DataRepository.EdStudSemesterExtProvider.GetByEntMajorPhaseId(transactionManager, entity.EntMajorPhaseId);

				if (deep && entity.EdStudSemesterExtCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterExt>) DataRepository.EdStudSemesterExtProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntMajorPhase object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntMajorPhase instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMajorPhase Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhase entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeLevelFromIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelFromIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelFromIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelFromIdSource);
				entity.EdCodeLevelFromId = entity.EdCodeLevelFromIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdCodeLevelToIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelToIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelToIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelToIdSource);
				entity.EdCodeLevelToId = entity.EdCodeLevelToIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdCodeSemesterFromIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterFromIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterFromIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterFromIdSource);
				entity.EdCodeSemesterFromId = entity.EdCodeSemesterFromIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EdCodeSemesterToIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterToIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterToIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterToIdSource);
				entity.EdCodeSemesterToId = entity.EdCodeSemesterToIdSource.EdCodeSemesterId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntMajorPhaseCrsExp>
				if (CanDeepSave(entity.EntMajorPhaseCrsExpCollection, "List<EntMajorPhaseCrsExp>|EntMajorPhaseCrsExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhaseCrsExp child in entity.EntMajorPhaseCrsExpCollection)
					{
						if(child.EntMajorPhaseIdSource != null)
						{
							child.EntMajorPhaseId = child.EntMajorPhaseIdSource.EntMajorPhaseId;
						}
						else
						{
							child.EntMajorPhaseId = entity.EntMajorPhaseId;
						}

					}

					if (entity.EntMajorPhaseCrsExpCollection.Count > 0 || entity.EntMajorPhaseCrsExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseCrsExpProvider.Save(transactionManager, entity.EntMajorPhaseCrsExpCollection);
						
						deepHandles.Add("EntMajorPhaseCrsExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhaseCrsExp >) DataRepository.EntMajorPhaseCrsExpProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCrsExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterExt>
				if (CanDeepSave(entity.EdStudSemesterExtCollection, "List<EdStudSemesterExt>|EdStudSemesterExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterExt child in entity.EdStudSemesterExtCollection)
					{
						if(child.EntMajorPhaseIdSource != null)
						{
							child.EntMajorPhaseId = child.EntMajorPhaseIdSource.EntMajorPhaseId;
						}
						else
						{
							child.EntMajorPhaseId = entity.EntMajorPhaseId;
						}

					}

					if (entity.EdStudSemesterExtCollection.Count > 0 || entity.EdStudSemesterExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterExtProvider.Save(transactionManager, entity.EdStudSemesterExtCollection);
						
						deepHandles.Add("EdStudSemesterExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterExt >) DataRepository.EdStudSemesterExtProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntMajorPhaseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntMajorPhase</c>
	///</summary>
	public enum EntMajorPhaseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelFromIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterFromIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EntMajorPhase</c> as OneToMany for EntMajorPhaseCrsExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhaseCrsExp>))]
		EntMajorPhaseCrsExpCollection,
		///<summary>
		/// Collection of <c>EntMajorPhase</c> as OneToMany for EdStudSemesterExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterExt>))]
		EdStudSemesterExtCollection,
	}
	
	#endregion EntMajorPhaseChildEntityTypes
	
	#region EntMajorPhaseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntMajorPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMajorPhaseFilterBuilder : SqlFilterBuilder<EntMajorPhaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseFilterBuilder class.
		/// </summary>
		public EntMajorPhaseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMajorPhaseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMajorPhaseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMajorPhaseFilterBuilder
	
	#region EntMajorPhaseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntMajorPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhase"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMajorPhaseParameterBuilder : ParameterizedSqlFilterBuilder<EntMajorPhaseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseParameterBuilder class.
		/// </summary>
		public EntMajorPhaseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMajorPhaseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMajorPhaseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMajorPhaseParameterBuilder
	
	#region EntMajorPhaseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntMajorPhaseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhase"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntMajorPhaseSortBuilder : SqlSortBuilder<EntMajorPhaseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseSqlSortBuilder class.
		/// </summary>
		public EntMajorPhaseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntMajorPhaseSortBuilder
	
} // end namespace
