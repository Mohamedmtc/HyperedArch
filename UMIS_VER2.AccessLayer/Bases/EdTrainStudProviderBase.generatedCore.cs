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
	/// This class is the base class for any <see cref="EdTrainStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdTrainStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdTrainStud, UMIS_VER2.BusinessLyer.EdTrainStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStudKey key)
		{
			return Delete(transactionManager, key.EdTrainStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edTrainStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edTrainStudId)
		{
			return Delete(null, _edTrainStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edTrainStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL Description: 
		/// </summary>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCodeTrainEvalId(System.Decimal? _edCodeTrainEvalId)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(_edCodeTrainEvalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainStud> GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal? _edCodeTrainEvalId)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(transactionManager, _edCodeTrainEvalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal? _edCodeTrainEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTrainEvalId(transactionManager, _edCodeTrainEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		fkEdTrainStudEdCodeTrainEval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCodeTrainEvalId(System.Decimal? _edCodeTrainEvalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeTrainEvalId(null, _edCodeTrainEvalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		fkEdTrainStudEdCodeTrainEval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCodeTrainEvalId(System.Decimal? _edCodeTrainEvalId, int start, int pageLength,out int count)
		{
			return GetByEdCodeTrainEvalId(null, _edCodeTrainEvalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL key.
		///		FK_ED_TRAIN_STUD_ED_CODE_TRAIN_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTrainEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public abstract TList<EdTrainStud> GetByEdCodeTrainEvalId(TransactionManager transactionManager, System.Decimal? _edCodeTrainEvalId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		FK_ED_TRAIN_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		FK_ED_TRAIN_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		FK_ED_TRAIN_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		fkEdTrainStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		fkEdTrainStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_COURSE key.
		///		FK_ED_TRAIN_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public abstract TList<EdTrainStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		FK_ED_TRAIN_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		FK_ED_TRAIN_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		FK_ED_TRAIN_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		fkEdTrainStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		fkEdTrainStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_STUD key.
		///		FK_ED_TRAIN_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public abstract TList<EdTrainStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		FK_ED_TRAIN_STUD_ED_TRAINING Description: 
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdTrainingId(System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(_edTrainingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		FK_ED_TRAIN_STUD_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainStud> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		FK_ED_TRAIN_STUD_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		fkEdTrainStudEdTraining Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edTrainingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		fkEdTrainStudEdTraining Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength,out int count)
		{
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_ED_TRAINING key.
		///		FK_ED_TRAIN_STUD_ED_TRAINING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public abstract TList<EdTrainStud> GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdTrainStud> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		fkEdTrainStudSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		fkEdTrainStudSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public TList<EdTrainStud> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAIN_STUD_SA_STF_MEMBER key.
		///		FK_ED_TRAIN_STUD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTrainStud objects.</returns>
		public abstract TList<EdTrainStud> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdTrainStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStudKey key, int start, int pageLength)
		{
			return GetByEdTrainStudId(transactionManager, key.EdTrainStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edTrainStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(System.Decimal _edTrainStudId)
		{
			int count = -1;
			return GetByEdTrainStudId(null,_edTrainStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edTrainStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(System.Decimal _edTrainStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainStudId(null, _edTrainStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(TransactionManager transactionManager, System.Decimal _edTrainStudId)
		{
			int count = -1;
			return GetByEdTrainStudId(transactionManager, _edTrainStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(TransactionManager transactionManager, System.Decimal _edTrainStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainStudId(transactionManager, _edTrainStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edTrainStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(System.Decimal _edTrainStudId, int start, int pageLength, out int count)
		{
			return GetByEdTrainStudId(null, _edTrainStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdTrainStud GetByEdTrainStudId(TransactionManager transactionManager, System.Decimal _edTrainStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdStudIdEdTrainingIdEdCourseId(null,_edStudId, _edTrainingId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdTrainingIdEdCourseId(null, _edStudId, _edTrainingId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdStudIdEdTrainingIdEdCourseId(transactionManager, _edStudId, _edTrainingId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdTrainingIdEdCourseId(transactionManager, _edStudId, _edTrainingId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdTrainingIdEdCourseId(null, _edStudId, _edTrainingId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_TRAIN_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edTrainingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdTrainStud GetByEdStudIdEdTrainingIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edTrainingId, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdTrainStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdTrainStud&gt;"/></returns>
		public static TList<EdTrainStud> Fill(IDataReader reader, TList<EdTrainStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdTrainStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdTrainStud")
					.Append("|").Append((System.Decimal)reader["ED_TRAIN_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdTrainStud>(
					key.ToString(), // EntityTrackingKey
					"EdTrainStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdTrainStud();
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
					c.EdTrainStudId = (System.Decimal)reader["ED_TRAIN_STUD_ID"];
					c.OriginalEdTrainStudId = c.EdTrainStudId;
					c.EdTrainingId = (System.Decimal)reader["ED_TRAINING_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.SupComment = Convert.IsDBNull(reader["SUP_COMMENT"]) ? null : (System.String)reader["SUP_COMMENT"];
					c.EdCodeTrainEvalId = Convert.IsDBNull(reader["ED_CODE_TRAIN_EVAL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_TRAIN_EVAL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdTrainStud entity)
		{
			if (!reader.Read()) return;
			
			entity.EdTrainStudId = (System.Decimal)reader[((int)EdTrainStudColumn.EdTrainStudId - 1)];
			entity.OriginalEdTrainStudId = (System.Decimal)reader["ED_TRAIN_STUD_ID"];
			entity.EdTrainingId = (System.Decimal)reader[((int)EdTrainStudColumn.EdTrainingId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdTrainStudColumn.EdStudId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)EdTrainStudColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)EdTrainStudColumn.SaStfMemberId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)EdTrainStudColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdTrainStudColumn.EdCourseId - 1)];
			entity.SupComment = (reader.IsDBNull(((int)EdTrainStudColumn.SupComment - 1)))?null:(System.String)reader[((int)EdTrainStudColumn.SupComment - 1)];
			entity.EdCodeTrainEvalId = (reader.IsDBNull(((int)EdTrainStudColumn.EdCodeTrainEvalId - 1)))?null:(System.Decimal?)reader[((int)EdTrainStudColumn.EdCodeTrainEvalId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdTrainStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdTrainStudId = (System.Decimal)dataRow["ED_TRAIN_STUD_ID"];
			entity.OriginalEdTrainStudId = (System.Decimal)dataRow["ED_TRAIN_STUD_ID"];
			entity.EdTrainingId = (System.Decimal)dataRow["ED_TRAINING_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.SupComment = Convert.IsDBNull(dataRow["SUP_COMMENT"]) ? null : (System.String)dataRow["SUP_COMMENT"];
			entity.EdCodeTrainEvalId = Convert.IsDBNull(dataRow["ED_CODE_TRAIN_EVAL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_TRAIN_EVAL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTrainStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTrainStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeTrainEvalIdSource	
			if (CanDeepLoad(entity, "EdCodeTrainEval|EdCodeTrainEvalIdSource", deepLoadType, innerList) 
				&& entity.EdCodeTrainEvalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeTrainEvalId ?? 0.0m);
				EdCodeTrainEval tmpEntity = EntityManager.LocateEntity<EdCodeTrainEval>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeTrainEval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeTrainEvalIdSource = tmpEntity;
				else
					entity.EdCodeTrainEvalIdSource = DataRepository.EdCodeTrainEvalProvider.GetByEdCodeTrainEvalId(transactionManager, (entity.EdCodeTrainEvalId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeTrainEvalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeTrainEvalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeTrainEvalProvider.DeepLoad(transactionManager, entity.EdCodeTrainEvalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeTrainEvalIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
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

			#region EdTrainingIdSource	
			if (CanDeepLoad(entity, "EdTraining|EdTrainingIdSource", deepLoadType, innerList) 
				&& entity.EdTrainingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdTrainingId;
				EdTraining tmpEntity = EntityManager.LocateEntity<EdTraining>(EntityLocator.ConstructKeyFromPkItems(typeof(EdTraining), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdTrainingIdSource = tmpEntity;
				else
					entity.EdTrainingIdSource = DataRepository.EdTrainingProvider.GetByEdTrainingId(transactionManager, entity.EdTrainingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdTrainingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdTrainingProvider.DeepLoad(transactionManager, entity.EdTrainingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdTrainingIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdTrainStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdTrainStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTrainStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeTrainEvalIdSource
			if (CanDeepSave(entity, "EdCodeTrainEval|EdCodeTrainEvalIdSource", deepSaveType, innerList) 
				&& entity.EdCodeTrainEvalIdSource != null)
			{
				DataRepository.EdCodeTrainEvalProvider.Save(transactionManager, entity.EdCodeTrainEvalIdSource);
				entity.EdCodeTrainEvalId = entity.EdCodeTrainEvalIdSource.EdCodeTrainEvalId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region EdTrainingIdSource
			if (CanDeepSave(entity, "EdTraining|EdTrainingIdSource", deepSaveType, innerList) 
				&& entity.EdTrainingIdSource != null)
			{
				DataRepository.EdTrainingProvider.Save(transactionManager, entity.EdTrainingIdSource);
				entity.EdTrainingId = entity.EdTrainingIdSource.EdTrainingId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region EdTrainStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdTrainStud</c>
	///</summary>
	public enum EdTrainStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeTrainEval</c> at EdCodeTrainEvalIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeTrainEval))]
		EdCodeTrainEval,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdTraining</c> at EdTrainingIdSource
		///</summary>
		[ChildEntityType(typeof(EdTraining))]
		EdTraining,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdTrainStudChildEntityTypes
	
	#region EdTrainStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdTrainStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainStudFilterBuilder : SqlFilterBuilder<EdTrainStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainStudFilterBuilder class.
		/// </summary>
		public EdTrainStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainStudFilterBuilder
	
	#region EdTrainStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdTrainStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainStudParameterBuilder : ParameterizedSqlFilterBuilder<EdTrainStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainStudParameterBuilder class.
		/// </summary>
		public EdTrainStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainStudParameterBuilder
	
	#region EdTrainStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdTrainStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTrainStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdTrainStudSortBuilder : SqlSortBuilder<EdTrainStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainStudSqlSortBuilder class.
		/// </summary>
		public EdTrainStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdTrainStudSortBuilder
	
} // end namespace
