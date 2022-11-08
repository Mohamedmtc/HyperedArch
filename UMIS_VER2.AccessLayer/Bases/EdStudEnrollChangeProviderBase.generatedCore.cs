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
	/// This class is the base class for any <see cref="EdStudEnrollChangeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudEnrollChangeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudEnrollChange, UMIS_VER2.BusinessLyer.EdStudEnrollChangeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudEnrollChangeKey key)
		{
			return Delete(transactionManager, key.EdStudEnrollChangeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudEnrollChangeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudEnrollChangeId)
		{
			return Delete(null, _edStudEnrollChangeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudEnrollChangeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(_edAcadYearToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearToId(transactionManager, _edAcadYearToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		fkEdStudEnrollChangeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		fkEdStudEnrollChangeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearToId(System.Decimal? _edAcadYearToId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearToId(null, _edAcadYearToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdAcadYearToId(TransactionManager transactionManager, System.Decimal? _edAcadYearToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId)
		{
			int count = -1;
			return GetByEdAcadYearFromId(_edAcadYearFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId)
		{
			int count = -1;
			return GetByEdAcadYearFromId(transactionManager, _edAcadYearFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearFromId(transactionManager, _edAcadYearFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		fkEdStudEnrollChangeEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearFromId(null, _edAcadYearFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		fkEdStudEnrollChangeEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdAcadYearFromId(System.Decimal? _edAcadYearFromId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearFromId(null, _edAcadYearFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdAcadYearFromId(TransactionManager transactionManager, System.Decimal? _edAcadYearFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN Description: 
		/// </summary>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(System.Decimal? _edCdeEnrollChngRsnId)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(_edCdeEnrollChngRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeEnrollChngRsnId)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(transactionManager, _edCdeEnrollChngRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeEnrollChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEnrollChngRsnId(transactionManager, _edCdeEnrollChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		fkEdStudEnrollChangeEdCdeEnrollChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(System.Decimal? _edCdeEnrollChngRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeEnrollChngRsnId(null, _edCdeEnrollChngRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		fkEdStudEnrollChangeEdCdeEnrollChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(System.Decimal? _edCdeEnrollChngRsnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeEnrollChngRsnId(null, _edCdeEnrollChngRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CDE_ENROLL_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEnrollChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdCdeEnrollChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeEnrollChngRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(System.Decimal _edCodeEnrollTypeOldId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeOldId(_edCodeEnrollTypeOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeOldId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeOldId(transactionManager, _edCodeEnrollTypeOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeOldId(transactionManager, _edCodeEnrollTypeOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		fkEdStudEnrollChangeEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(System.Decimal _edCodeEnrollTypeOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeEnrollTypeOldId(null, _edCodeEnrollTypeOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		fkEdStudEnrollChangeEdCodeEnrollType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(System.Decimal _edCodeEnrollTypeOldId, int start, int pageLength,out int count)
		{
			return GetByEdCodeEnrollTypeOldId(null, _edCodeEnrollTypeOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdCodeEnrollTypeOldId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 Description: 
		/// </summary>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(System.Decimal _edCodeEnrollTypeNewId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeNewId(_edCodeEnrollTypeNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeNewId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeNewId(transactionManager, _edCodeEnrollTypeNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeNewId(transactionManager, _edCodeEnrollTypeNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		fkEdStudEnrollChangeEdCodeEnrollType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeEnrollTypeNewId(null, _edCodeEnrollTypeNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		fkEdStudEnrollChangeEdCodeEnrollType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeEnrollTypeNewId(null, _edCodeEnrollTypeNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_ENROLL_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(_edCodeSemesterFromId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterFromId(transactionManager, _edCodeSemesterFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		fkEdStudEnrollChangeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		fkEdStudEnrollChangeEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(System.Decimal? _edCodeSemesterFromId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterFromId(null, _edCodeSemesterFromId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdCodeSemesterFromId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterFromId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(_edCodeSemesterToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterToId(transactionManager, _edCodeSemesterToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		fkEdStudEnrollChangeEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		fkEdStudEnrollChangeEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdCodeSemesterToId(System.Decimal? _edCodeSemesterToId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterToId(null, _edCodeSemesterToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdCodeSemesterToId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterToId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		fkEdStudEnrollChangeEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		fkEdStudEnrollChangeEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ENROLL_CHANGE_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemApprovedById"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(_saStfMemApprovedById, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(transactionManager, _saStfMemApprovedById, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(transactionManager, _saStfMemApprovedById, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		fkEdStudEnrollChangeSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemApprovedById(null, _saStfMemApprovedById, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		fkEdStudEnrollChangeSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById, int start, int pageLength,out int count)
		{
			return GetBySaStfMemApprovedById(null, _saStfMemApprovedById, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		fkEdStudEnrollChangeSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		fkEdStudEnrollChangeSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_FORM key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		fkEdStudEnrollChangeSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		fkEdStudEnrollChangeSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER1 Description: 
		/// </summary>
		/// <param name="_seUserInsrtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId)
		{
			int count = -1;
			return GetBySeUserInsrtId(_seUserInsrtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudEnrollChange> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId)
		{
			int count = -1;
			return GetBySeUserInsrtId(transactionManager, _seUserInsrtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserInsrtId(transactionManager, _seUserInsrtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		fkEdStudEnrollChangeSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserInsrtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserInsrtId(null, _seUserInsrtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		fkEdStudEnrollChangeSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public TList<EdStudEnrollChange> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId, int start, int pageLength,out int count)
		{
			return GetBySeUserInsrtId(null, _seUserInsrtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ENROLL_CHANGE_SE_USER1 key.
		///		FK_ED_STUD_ENROLL_CHANGE_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudEnrollChange objects.</returns>
		public abstract TList<EdStudEnrollChange> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudEnrollChange Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudEnrollChangeKey key, int start, int pageLength)
		{
			return GetByEdStudEnrollChangeId(transactionManager, key.EdStudEnrollChangeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(System.Decimal _edStudEnrollChangeId)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(null,_edStudEnrollChangeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(System.Decimal _edStudEnrollChangeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(null, _edStudEnrollChangeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal _edStudEnrollChangeId)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(transactionManager, _edStudEnrollChangeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal _edStudEnrollChangeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(transactionManager, _edStudEnrollChangeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(System.Decimal _edStudEnrollChangeId, int start, int pageLength, out int count)
		{
			return GetByEdStudEnrollChangeId(null, _edStudEnrollChangeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudEnrollChange GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal _edStudEnrollChangeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(null,_edStudSemesterId, _edCodeEnrollTypeOldId, _edCodeEnrollTypeNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(null, _edStudSemesterId, _edCodeEnrollTypeOldId, _edCodeEnrollTypeNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(transactionManager, _edStudSemesterId, _edCodeEnrollTypeOldId, _edCodeEnrollTypeNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(transactionManager, _edStudSemesterId, _edCodeEnrollTypeOldId, _edCodeEnrollTypeNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(null, _edStudSemesterId, _edCodeEnrollTypeOldId, _edCodeEnrollTypeNewId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_ENROLL_CHANGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCodeEnrollTypeOldId"></param>
		/// <param name="_edCodeEnrollTypeNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudEnrollChange&gt;"/> class.</returns>
		public abstract TList<EdStudEnrollChange> GetByEdStudSemesterIdEdCodeEnrollTypeOldIdEdCodeEnrollTypeNewId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, System.Decimal _edCodeEnrollTypeOldId, System.Decimal _edCodeEnrollTypeNewId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudEnrollChange&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudEnrollChange&gt;"/></returns>
		public static TList<EdStudEnrollChange> Fill(IDataReader reader, TList<EdStudEnrollChange> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudEnrollChange c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudEnrollChange")
					.Append("|").Append((System.Decimal)reader["ED_STUD_ENROLL_CHANGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudEnrollChange>(
					key.ToString(), // EntityTrackingKey
					"EdStudEnrollChange",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudEnrollChange();
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
					c.EdStudEnrollChangeId = (System.Decimal)reader["ED_STUD_ENROLL_CHANGE_ID"];
					c.OriginalEdStudEnrollChangeId = c.EdStudEnrollChangeId;
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.EdCodeEnrollTypeOldId = (System.Decimal)reader["ED_CODE_ENROLL_TYPE_OLD_ID"];
					c.EdCodeEnrollTypeNewId = (System.Decimal)reader["ED_CODE_ENROLL_TYPE_NEW_ID"];
					c.EdAcadYearFromId = Convert.IsDBNull(reader["ED_ACAD_YEAR_FROM_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_FROM_ID"];
					c.EdCodeSemesterFromId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_FROM_ID"];
					c.EdAcadYearToId = Convert.IsDBNull(reader["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_TO_ID"];
					c.EdCodeSemesterToId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TO_ID"];
					c.SemCount = Convert.IsDBNull(reader["SEM_COUNT"]) ? null : (System.Decimal?)reader["SEM_COUNT"];
					c.EdCdeEnrollChngRsnId = Convert.IsDBNull(reader["ED_CDE_ENROLL_CHNG_RSN_ID"]) ? null : (System.Decimal?)reader["ED_CDE_ENROLL_CHNG_RSN_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.DecisionNo = Convert.IsDBNull(reader["DECISION_NO"]) ? null : (System.String)reader["DECISION_NO"];
					c.DecisionDate = Convert.IsDBNull(reader["DECISION_DATE"]) ? null : (System.DateTime?)reader["DECISION_DATE"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.SaStfMemApprovedById = Convert.IsDBNull(reader["SA_STF_MEM_APPROVED_BY_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEM_APPROVED_BY_ID"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserInsrtId = Convert.IsDBNull(reader["SE_USER_INSRT_ID"]) ? null : (System.Decimal?)reader["SE_USER_INSRT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudEnrollChange entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudEnrollChangeId = (System.Decimal)reader[((int)EdStudEnrollChangeColumn.EdStudEnrollChangeId - 1)];
			entity.OriginalEdStudEnrollChangeId = (System.Decimal)reader["ED_STUD_ENROLL_CHANGE_ID"];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdStudSemesterId - 1)];
			entity.EdCodeEnrollTypeOldId = (System.Decimal)reader[((int)EdStudEnrollChangeColumn.EdCodeEnrollTypeOldId - 1)];
			entity.EdCodeEnrollTypeNewId = (System.Decimal)reader[((int)EdStudEnrollChangeColumn.EdCodeEnrollTypeNewId - 1)];
			entity.EdAcadYearFromId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdAcadYearFromId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdAcadYearFromId - 1)];
			entity.EdCodeSemesterFromId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdCodeSemesterFromId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdCodeSemesterFromId - 1)];
			entity.EdAcadYearToId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdAcadYearToId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdAcadYearToId - 1)];
			entity.EdCodeSemesterToId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdCodeSemesterToId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdCodeSemesterToId - 1)];
			entity.SemCount = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.SemCount - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.SemCount - 1)];
			entity.EdCdeEnrollChngRsnId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.EdCdeEnrollChngRsnId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.EdCdeEnrollChngRsnId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)EdStudEnrollChangeColumn.ReqDate - 1)];
			entity.DecisionNo = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.DecisionNo - 1)))?null:(System.String)reader[((int)EdStudEnrollChangeColumn.DecisionNo - 1)];
			entity.DecisionDate = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.DecisionDate - 1)))?null:(System.DateTime?)reader[((int)EdStudEnrollChangeColumn.DecisionDate - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.ApproveFlg - 1)];
			entity.SaStfMemApprovedById = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.SaStfMemApprovedById - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.SaStfMemApprovedById - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudEnrollChangeColumn.IsLast - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudEnrollChangeColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudEnrollChangeColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.SeUserId - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.SeFormId - 1)];
			entity.SeUserInsrtId = (reader.IsDBNull(((int)EdStudEnrollChangeColumn.SeUserInsrtId - 1)))?null:(System.Decimal?)reader[((int)EdStudEnrollChangeColumn.SeUserInsrtId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudEnrollChange entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudEnrollChangeId = (System.Decimal)dataRow["ED_STUD_ENROLL_CHANGE_ID"];
			entity.OriginalEdStudEnrollChangeId = (System.Decimal)dataRow["ED_STUD_ENROLL_CHANGE_ID"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCodeEnrollTypeOldId = (System.Decimal)dataRow["ED_CODE_ENROLL_TYPE_OLD_ID"];
			entity.EdCodeEnrollTypeNewId = (System.Decimal)dataRow["ED_CODE_ENROLL_TYPE_NEW_ID"];
			entity.EdAcadYearFromId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_FROM_ID"];
			entity.EdCodeSemesterFromId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_FROM_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_FROM_ID"];
			entity.EdAcadYearToId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_TO_ID"];
			entity.EdCodeSemesterToId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TO_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TO_ID"];
			entity.SemCount = Convert.IsDBNull(dataRow["SEM_COUNT"]) ? null : (System.Decimal?)dataRow["SEM_COUNT"];
			entity.EdCdeEnrollChngRsnId = Convert.IsDBNull(dataRow["ED_CDE_ENROLL_CHNG_RSN_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_ENROLL_CHNG_RSN_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.DecisionNo = Convert.IsDBNull(dataRow["DECISION_NO"]) ? null : (System.String)dataRow["DECISION_NO"];
			entity.DecisionDate = Convert.IsDBNull(dataRow["DECISION_DATE"]) ? null : (System.DateTime?)dataRow["DECISION_DATE"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.SaStfMemApprovedById = Convert.IsDBNull(dataRow["SA_STF_MEM_APPROVED_BY_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEM_APPROVED_BY_ID"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserInsrtId = Convert.IsDBNull(dataRow["SE_USER_INSRT_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_INSRT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudEnrollChange"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudEnrollChange Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudEnrollChange entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearToIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearToIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearToId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearToIdSource = tmpEntity;
				else
					entity.EdAcadYearToIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearToIdSource

			#region EdAcadYearFromIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearFromIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearFromIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearFromId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearFromIdSource = tmpEntity;
				else
					entity.EdAcadYearFromIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearFromId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearFromIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearFromIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearFromIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearFromIdSource

			#region EdCdeEnrollChngRsnIdSource	
			if (CanDeepLoad(entity, "EdCdeEnrollChngRsn|EdCdeEnrollChngRsnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeEnrollChngRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeEnrollChngRsnId ?? 0.0m);
				EdCdeEnrollChngRsn tmpEntity = EntityManager.LocateEntity<EdCdeEnrollChngRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeEnrollChngRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeEnrollChngRsnIdSource = tmpEntity;
				else
					entity.EdCdeEnrollChngRsnIdSource = DataRepository.EdCdeEnrollChngRsnProvider.GetByEdCdeEnrollChngRsnId(transactionManager, (entity.EdCdeEnrollChngRsnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeEnrollChngRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeEnrollChngRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeEnrollChngRsnProvider.DeepLoad(transactionManager, entity.EdCdeEnrollChngRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeEnrollChngRsnIdSource

			#region EdCodeEnrollTypeOldIdSource	
			if (CanDeepLoad(entity, "EdCodeEnrollType|EdCodeEnrollTypeOldIdSource", deepLoadType, innerList) 
				&& entity.EdCodeEnrollTypeOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeEnrollTypeOldId;
				EdCodeEnrollType tmpEntity = EntityManager.LocateEntity<EdCodeEnrollType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeEnrollType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeEnrollTypeOldIdSource = tmpEntity;
				else
					entity.EdCodeEnrollTypeOldIdSource = DataRepository.EdCodeEnrollTypeProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeOldId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeEnrollTypeOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeEnrollTypeOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeEnrollTypeProvider.DeepLoad(transactionManager, entity.EdCodeEnrollTypeOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeEnrollTypeOldIdSource

			#region EdCodeEnrollTypeNewIdSource	
			if (CanDeepLoad(entity, "EdCodeEnrollType|EdCodeEnrollTypeNewIdSource", deepLoadType, innerList) 
				&& entity.EdCodeEnrollTypeNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeEnrollTypeNewId;
				EdCodeEnrollType tmpEntity = EntityManager.LocateEntity<EdCodeEnrollType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeEnrollType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeEnrollTypeNewIdSource = tmpEntity;
				else
					entity.EdCodeEnrollTypeNewIdSource = DataRepository.EdCodeEnrollTypeProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeNewId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeEnrollTypeNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeEnrollTypeNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeEnrollTypeProvider.DeepLoad(transactionManager, entity.EdCodeEnrollTypeNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeEnrollTypeNewIdSource

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

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
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

			#region SaStfMemApprovedByIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemApprovedByIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemApprovedByIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemApprovedById ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemApprovedByIdSource = tmpEntity;
				else
					entity.SaStfMemApprovedByIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemApprovedById ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemApprovedByIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemApprovedByIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemApprovedByIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemApprovedByIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
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

			#region SeUserInsrtIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserInsrtIdSource", deepLoadType, innerList) 
				&& entity.SeUserInsrtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserInsrtId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserInsrtIdSource = tmpEntity;
				else
					entity.SeUserInsrtIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserInsrtId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserInsrtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserInsrtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserInsrtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserInsrtIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudEnrollChangeId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudEnrollChangeId(transactionManager, entity.EdStudEnrollChangeId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudEnrollChange object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudEnrollChange instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudEnrollChange Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudEnrollChange entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearToIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearToIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearToIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearToIdSource);
				entity.EdAcadYearToId = entity.EdAcadYearToIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdAcadYearFromIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearFromIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearFromIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearFromIdSource);
				entity.EdAcadYearFromId = entity.EdAcadYearFromIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCdeEnrollChngRsnIdSource
			if (CanDeepSave(entity, "EdCdeEnrollChngRsn|EdCdeEnrollChngRsnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeEnrollChngRsnIdSource != null)
			{
				DataRepository.EdCdeEnrollChngRsnProvider.Save(transactionManager, entity.EdCdeEnrollChngRsnIdSource);
				entity.EdCdeEnrollChngRsnId = entity.EdCdeEnrollChngRsnIdSource.EdCdeEnrollChngRsnId;
			}
			#endregion 
			
			#region EdCodeEnrollTypeOldIdSource
			if (CanDeepSave(entity, "EdCodeEnrollType|EdCodeEnrollTypeOldIdSource", deepSaveType, innerList) 
				&& entity.EdCodeEnrollTypeOldIdSource != null)
			{
				DataRepository.EdCodeEnrollTypeProvider.Save(transactionManager, entity.EdCodeEnrollTypeOldIdSource);
				entity.EdCodeEnrollTypeOldId = entity.EdCodeEnrollTypeOldIdSource.EdCodeEnrollTypeId;
			}
			#endregion 
			
			#region EdCodeEnrollTypeNewIdSource
			if (CanDeepSave(entity, "EdCodeEnrollType|EdCodeEnrollTypeNewIdSource", deepSaveType, innerList) 
				&& entity.EdCodeEnrollTypeNewIdSource != null)
			{
				DataRepository.EdCodeEnrollTypeProvider.Save(transactionManager, entity.EdCodeEnrollTypeNewIdSource);
				entity.EdCodeEnrollTypeNewId = entity.EdCodeEnrollTypeNewIdSource.EdCodeEnrollTypeId;
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
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region SaStfMemApprovedByIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemApprovedByIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemApprovedByIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemApprovedByIdSource);
				entity.SaStfMemApprovedById = entity.SaStfMemApprovedByIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
			
			#region SeUserInsrtIdSource
			if (CanDeepSave(entity, "SeUser|SeUserInsrtIdSource", deepSaveType, innerList) 
				&& entity.SeUserInsrtIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserInsrtIdSource);
				entity.SeUserInsrtId = entity.SeUserInsrtIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudEnrollChangeIdSource != null)
						{
							child.EdStudEnrollChangeId = child.EdStudEnrollChangeIdSource.EdStudEnrollChangeId;
						}
						else
						{
							child.EdStudEnrollChangeId = entity.EdStudEnrollChangeId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudEnrollChangeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudEnrollChange</c>
	///</summary>
	public enum EdStudEnrollChangeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearToIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeEnrollChngRsn</c> at EdCdeEnrollChngRsnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeEnrollChngRsn))]
		EdCdeEnrollChngRsn,
		
		///<summary>
		/// Composite Property for <c>EdCodeEnrollType</c> at EdCodeEnrollTypeOldIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeEnrollType))]
		EdCodeEnrollType,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterFromIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemApprovedByIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdStudEnrollChange</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion EdStudEnrollChangeChildEntityTypes
	
	#region EdStudEnrollChangeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudEnrollChangeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudEnrollChange"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudEnrollChangeFilterBuilder : SqlFilterBuilder<EdStudEnrollChangeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeFilterBuilder class.
		/// </summary>
		public EdStudEnrollChangeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudEnrollChangeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudEnrollChangeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudEnrollChangeFilterBuilder
	
	#region EdStudEnrollChangeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudEnrollChangeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudEnrollChange"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudEnrollChangeParameterBuilder : ParameterizedSqlFilterBuilder<EdStudEnrollChangeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeParameterBuilder class.
		/// </summary>
		public EdStudEnrollChangeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudEnrollChangeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudEnrollChangeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudEnrollChangeParameterBuilder
	
	#region EdStudEnrollChangeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudEnrollChangeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudEnrollChange"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudEnrollChangeSortBuilder : SqlSortBuilder<EdStudEnrollChangeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudEnrollChangeSqlSortBuilder class.
		/// </summary>
		public EdStudEnrollChangeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudEnrollChangeSortBuilder
	
} // end namespace
