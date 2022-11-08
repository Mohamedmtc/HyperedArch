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
	/// This class is the base class for any <see cref="EdCourseInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseInfo, UMIS_VER2.BusinessLyer.EdCourseInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInfoKey key)
		{
			return Delete(transactionManager, key.EdCourseInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseInfoId">extra info  for modular  type. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseInfoId)
		{
			return Delete(null, _edCourseInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInfoId">extra info  for modular  type. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseInfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELfrom Description: 
		/// </summary>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(_edCodeLevelFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseInfo> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(transactionManager, _edCodeLevelFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelFromId(transactionManager, _edCodeLevelFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		fkEdCourseInfoEdCodeLeveLfrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelFromId(null, _edCodeLevelFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		fkEdCourseInfoEdCodeLeveLfrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelFromId(System.Decimal? _edCodeLevelFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelFromId(null, _edCodeLevelFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelFromId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public abstract TList<EdCourseInfo> GetByEdCodeLevelFromId(TransactionManager transactionManager, System.Decimal? _edCodeLevelFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELto Description: 
		/// </summary>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelToId(System.Decimal? _edCodeLevelToId)
		{
			int count = -1;
			return GetByEdCodeLevelToId(_edCodeLevelToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseInfo> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal? _edCodeLevelToId)
		{
			int count = -1;
			return GetByEdCodeLevelToId(transactionManager, _edCodeLevelToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal? _edCodeLevelToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelToId(transactionManager, _edCodeLevelToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		fkEdCourseInfoEdCodeLeveLto Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelToId(System.Decimal? _edCodeLevelToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelToId(null, _edCodeLevelToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		fkEdCourseInfoEdCodeLeveLto Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeLevelToId(System.Decimal? _edCodeLevelToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelToId(null, _edCodeLevelToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_LEVELto key.
		///		FK_ED_COURSE_INFO_ED_CODE_LEVELto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelToId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public abstract TList<EdCourseInfo> GetByEdCodeLevelToId(TransactionManager transactionManager, System.Decimal? _edCodeLevelToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom Description: 
		/// </summary>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(_edCodeSemesterFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseInfo> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		fkEdCourseInfoEdCodeSemesteRfrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		fkEdCourseInfoEdCodeSemesteRfrom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERfrom Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId">مسلسل الفصل الدراسيXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public abstract TList<EdCourseInfo> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERto Description: 
		/// </summary>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(_edCodeSemesterToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseInfo> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		fkEdCourseInfoEdCodeSemesteRto Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		fkEdCourseInfoEdCodeSemesteRto Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_CODE_SEMESTERto key.
		///		FK_ED_COURSE_INFO_ED_CODE_SEMESTERto Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId">مسلسل الفصل الدراسيXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public abstract TList<EdCourseInfo> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		FK_ED_COURSE_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		FK_ED_COURSE_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		FK_ED_COURSE_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		fkEdCourseInfoEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		fkEdCourseInfoEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public TList<EdCourseInfo> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_INFO_ED_COURSE key.
		///		FK_ED_COURSE_INFO_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseInfo objects.</returns>
		public abstract TList<EdCourseInfo> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInfoKey key, int start, int pageLength)
		{
			return GetByEdCourseInfoId(transactionManager, key.EdCourseInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(System.Decimal _edCourseInfoId)
		{
			int count = -1;
			return GetByEdCourseInfoId(null,_edCourseInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(System.Decimal _edCourseInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseInfoId(null, _edCourseInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(TransactionManager transactionManager, System.Decimal _edCourseInfoId)
		{
			int count = -1;
			return GetByEdCourseInfoId(transactionManager, _edCourseInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(TransactionManager transactionManager, System.Decimal _edCourseInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseInfoId(transactionManager, _edCourseInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(System.Decimal _edCourseInfoId, int start, int pageLength, out int count)
		{
			return GetByEdCourseInfoId(null, _edCourseInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInfoId">extra info  for modular  type</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseInfo GetByEdCourseInfoId(TransactionManager transactionManager, System.Decimal _edCourseInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseInfo&gt;"/></returns>
		public static TList<EdCourseInfo> Fill(IDataReader reader, TList<EdCourseInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseInfo")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseInfo>(
					key.ToString(), // EntityTrackingKey
					"EdCourseInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseInfo();
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
					c.EdCourseInfoId = (System.Decimal)reader["ED_COURSE_INFO_ID"];
					c.OriginalEdCourseInfoId = c.EdCourseInfoId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.StudyTypeFlg = (System.Int32)reader["STUDY_TYPE_FLG"];
					c.EdCodeLevelFromId = Convert.IsDBNull(reader["ED_CODE_LEVEL_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_FROM_ID"];
					c.EdCodeSemesterFromId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_FROM_ID"];
					c.EdCodeLevelToId = Convert.IsDBNull(reader["ED_CODE_LEVEL_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_TO_ID"];
					c.EdCodeSemesterToId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TO_ID"];
					c.PeriodTypeFlg = Convert.IsDBNull(reader["PERIOD_TYPE_FLG"]) ? null : (System.Int32?)reader["PERIOD_TYPE_FLG"];
					c.CrsPeriod = Convert.IsDBNull(reader["CRS_PERIOD"]) ? null : (System.Decimal?)reader["CRS_PERIOD"];
					c.ContHour = Convert.IsDBNull(reader["CONT_HOUR"]) ? null : (System.Int32?)reader["CONT_HOUR"];
					c.NonContHour = Convert.IsDBNull(reader["NON_CONT_HOUR"]) ? null : (System.Int32?)reader["NON_CONT_HOUR"];
					c.SemesterExamFlg = Convert.IsDBNull(reader["SEMESTER_EXAM_FLG"]) ? null : (System.Boolean?)reader["SEMESTER_EXAM_FLG"];
					c.YearExamFlg = Convert.IsDBNull(reader["YEAR_EXAM_FLG"]) ? null : (System.Boolean?)reader["YEAR_EXAM_FLG"];
					c.PhaseExamFlg = Convert.IsDBNull(reader["PHASE_EXAM_FLG"]) ? null : (System.Boolean?)reader["PHASE_EXAM_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseInfoId = (System.Decimal)reader[((int)EdCourseInfoColumn.EdCourseInfoId - 1)];
			entity.OriginalEdCourseInfoId = (System.Decimal)reader["ED_COURSE_INFO_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseInfoColumn.EdCourseId - 1)];
			entity.StudyTypeFlg = (System.Int32)reader[((int)EdCourseInfoColumn.StudyTypeFlg - 1)];
			entity.EdCodeLevelFromId = (reader.IsDBNull(((int)EdCourseInfoColumn.EdCodeLevelFromId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.EdCodeLevelFromId - 1)];
			entity.EdCodeSemesterFromId = (reader.IsDBNull(((int)EdCourseInfoColumn.EdCodeSemesterFromId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.EdCodeSemesterFromId - 1)];
			entity.EdCodeLevelToId = (reader.IsDBNull(((int)EdCourseInfoColumn.EdCodeLevelToId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.EdCodeLevelToId - 1)];
			entity.EdCodeSemesterToId = (reader.IsDBNull(((int)EdCourseInfoColumn.EdCodeSemesterToId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.EdCodeSemesterToId - 1)];
			entity.PeriodTypeFlg = (reader.IsDBNull(((int)EdCourseInfoColumn.PeriodTypeFlg - 1)))?null:(System.Int32?)reader[((int)EdCourseInfoColumn.PeriodTypeFlg - 1)];
			entity.CrsPeriod = (reader.IsDBNull(((int)EdCourseInfoColumn.CrsPeriod - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.CrsPeriod - 1)];
			entity.ContHour = (reader.IsDBNull(((int)EdCourseInfoColumn.ContHour - 1)))?null:(System.Int32?)reader[((int)EdCourseInfoColumn.ContHour - 1)];
			entity.NonContHour = (reader.IsDBNull(((int)EdCourseInfoColumn.NonContHour - 1)))?null:(System.Int32?)reader[((int)EdCourseInfoColumn.NonContHour - 1)];
			entity.SemesterExamFlg = (reader.IsDBNull(((int)EdCourseInfoColumn.SemesterExamFlg - 1)))?null:(System.Boolean?)reader[((int)EdCourseInfoColumn.SemesterExamFlg - 1)];
			entity.YearExamFlg = (reader.IsDBNull(((int)EdCourseInfoColumn.YearExamFlg - 1)))?null:(System.Boolean?)reader[((int)EdCourseInfoColumn.YearExamFlg - 1)];
			entity.PhaseExamFlg = (reader.IsDBNull(((int)EdCourseInfoColumn.PhaseExamFlg - 1)))?null:(System.Boolean?)reader[((int)EdCourseInfoColumn.PhaseExamFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdCourseInfoColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInfoColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdCourseInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdCourseInfoColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseInfoId = (System.Decimal)dataRow["ED_COURSE_INFO_ID"];
			entity.OriginalEdCourseInfoId = (System.Decimal)dataRow["ED_COURSE_INFO_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.StudyTypeFlg = (System.Int32)dataRow["STUDY_TYPE_FLG"];
			entity.EdCodeLevelFromId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_FROM_ID"];
			entity.EdCodeSemesterFromId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_FROM_ID"];
			entity.EdCodeLevelToId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_TO_ID"];
			entity.EdCodeSemesterToId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TO_ID"];
			entity.PeriodTypeFlg = Convert.IsDBNull(dataRow["PERIOD_TYPE_FLG"]) ? null : (System.Int32?)dataRow["PERIOD_TYPE_FLG"];
			entity.CrsPeriod = Convert.IsDBNull(dataRow["CRS_PERIOD"]) ? null : (System.Decimal?)dataRow["CRS_PERIOD"];
			entity.ContHour = Convert.IsDBNull(dataRow["CONT_HOUR"]) ? null : (System.Int32?)dataRow["CONT_HOUR"];
			entity.NonContHour = Convert.IsDBNull(dataRow["NON_CONT_HOUR"]) ? null : (System.Int32?)dataRow["NON_CONT_HOUR"];
			entity.SemesterExamFlg = Convert.IsDBNull(dataRow["SEMESTER_EXAM_FLG"]) ? null : (System.Boolean?)dataRow["SEMESTER_EXAM_FLG"];
			entity.YearExamFlg = Convert.IsDBNull(dataRow["YEAR_EXAM_FLG"]) ? null : (System.Boolean?)dataRow["YEAR_EXAM_FLG"];
			entity.PhaseExamFlg = Convert.IsDBNull(dataRow["PHASE_EXAM_FLG"]) ? null : (System.Boolean?)dataRow["PHASE_EXAM_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
				pkItems[0] = (entity.EdCodeLevelToId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelToIdSource = tmpEntity;
				else
					entity.EdCodeLevelToIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelToId ?? 0.0m));		
				
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
				pkItems[0] = (entity.EdCodeSemesterFromId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterFromIdSource = tmpEntity;
				else
					entity.EdCodeSemesterFromIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterFromId ?? 0.0m));		
				
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
				pkItems[0] = (entity.EdCodeSemesterToId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterToIdSource = tmpEntity;
				else
					entity.EdCodeSemesterToIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterToId ?? 0.0m));		
				
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

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
	
	#region EdCourseInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseInfo</c>
	///</summary>
	public enum EdCourseInfoChildEntityTypes
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
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdCourseInfoChildEntityTypes
	
	#region EdCourseInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseInfoFilterBuilder : SqlFilterBuilder<EdCourseInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoFilterBuilder class.
		/// </summary>
		public EdCourseInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseInfoFilterBuilder
	
	#region EdCourseInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseInfoParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoParameterBuilder class.
		/// </summary>
		public EdCourseInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseInfoParameterBuilder
	
	#region EdCourseInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseInfoSortBuilder : SqlSortBuilder<EdCourseInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInfoSqlSortBuilder class.
		/// </summary>
		public EdCourseInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseInfoSortBuilder
	
} // end namespace
