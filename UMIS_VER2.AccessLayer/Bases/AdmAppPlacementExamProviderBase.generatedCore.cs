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
	/// This class is the base class for any <see cref="AdmAppPlacementExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppPlacementExamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppPlacementExam, UMIS_VER2.BusinessLyer.AdmAppPlacementExamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppPlacementExamKey key)
		{
			return Delete(transactionManager, key.AdmAppPlacementExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppPlacementExamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppPlacementExamId)
		{
			return Delete(null, _admAppPlacementExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppPlacementExamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		fkAdmAppPlacementExamAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		fkAdmAppPlacementExamAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmAppPlacementExamAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmAppPlacementExamAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmAppPlacementExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmAppPlacementExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(System.Decimal? _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(System.Decimal? _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(_admPlaceExamDatetimeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal? _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal? _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmAppPlacementExamAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(System.Decimal? _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmAppPlacementExamAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(System.Decimal? _admPlaceExamDatetimeId, int start, int pageLength,out int count)
		{
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal? _admPlaceExamDatetimeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC Description: 
		/// </summary>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(System.Decimal? _admPlaceExamLocId)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(_admPlaceExamLocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal? _admPlaceExamLocId)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(transactionManager, _admPlaceExamLocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal? _admPlaceExamLocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(transactionManager, _admPlaceExamLocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		fkAdmAppPlacementExamAdmPlaceExamLoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(System.Decimal? _admPlaceExamLocId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmPlaceExamLocId(null, _admPlaceExamLocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		fkAdmAppPlacementExamAdmPlaceExamLoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(System.Decimal? _admPlaceExamLocId, int start, int pageLength,out int count)
		{
			return GetByAdmPlaceExamLocId(null, _admPlaceExamLocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC key.
		///		FK_ADM_APP_PLACEMENT_EXAM_ADM_PLACE_EXAM_LOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlacementExam objects.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal? _admPlaceExamLocId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppPlacementExam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppPlacementExamKey key, int start, int pageLength)
		{
			return GetByAdmAppPlacementExamId(transactionManager, key.AdmAppPlacementExamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public TList<AdmAppPlacementExam> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public TList<AdmAppPlacementExam> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public TList<AdmAppPlacementExam> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public TList<AdmAppPlacementExam> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public TList<AdmAppPlacementExam> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppPlacementExam&gt;"/> class.</returns>
		public abstract TList<AdmAppPlacementExam> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admAppPlacementExamId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(System.Decimal _admAppPlacementExamId)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(null,_admAppPlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admAppPlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(System.Decimal _admAppPlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(null, _admAppPlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal _admAppPlacementExamId)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(transactionManager, _admAppPlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal _admAppPlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(transactionManager, _admAppPlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admAppPlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(System.Decimal _admAppPlacementExamId, int start, int pageLength, out int count)
		{
			return GetByAdmAppPlacementExamId(null, _admAppPlacementExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal _admAppPlacementExamId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(null,_admApplicantId, _admPlaceExamDatetimeId, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(null, _admApplicantId, _admPlaceExamDatetimeId, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(transactionManager, _admApplicantId, _admPlaceExamDatetimeId, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(transactionManager, _admApplicantId, _admPlaceExamDatetimeId, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(null, _admApplicantId, _admPlaceExamDatetimeId, _admCdePlacementExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_PLACEMENT_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="_admCdePlacementExamId">if out_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppPlacementExam GetByAdmApplicantIdAdmPlaceExamDatetimeIdAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal? _admPlaceExamDatetimeId, System.Decimal? _admCdePlacementExamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppPlacementExam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppPlacementExam&gt;"/></returns>
		public static TList<AdmAppPlacementExam> Fill(IDataReader reader, TList<AdmAppPlacementExam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppPlacementExam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppPlacementExam")
					.Append("|").Append((System.Decimal)reader["ADM_APP_PLACEMENT_EXAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppPlacementExam>(
					key.ToString(), // EntityTrackingKey
					"AdmAppPlacementExam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppPlacementExam();
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
					c.AdmAppPlacementExamId = (System.Decimal)reader["ADM_APP_PLACEMENT_EXAM_ID"];
					c.OriginalAdmAppPlacementExamId = c.AdmAppPlacementExamId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.Mark = Convert.IsDBNull(reader["MARK"]) ? null : (System.Decimal?)reader["MARK"];
					c.PassFlg = Convert.IsDBNull(reader["PASS_FLG"]) ? null : (System.Decimal?)reader["PASS_FLG"];
					c.AbsentFlg = Convert.IsDBNull(reader["ABSENT_FLG"]) ? null : (System.Decimal?)reader["ABSENT_FLG"];
					c.AdmPlaceExamDatetimeId = Convert.IsDBNull(reader["ADM_PLACE_EXAM_DATETIME_ID"]) ? null : (System.Decimal?)reader["ADM_PLACE_EXAM_DATETIME_ID"];
					c.AdmCdePlacementExamId = Convert.IsDBNull(reader["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.AttchCertPath = Convert.IsDBNull(reader["ATTCH_CERT_PATH"]) ? null : (System.String)reader["ATTCH_CERT_PATH"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.ExemptFlg = Convert.IsDBNull(reader["EXEMPT_FLG"]) ? null : (System.Boolean?)reader["EXEMPT_FLG"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.AdmPlaceExamLocId = Convert.IsDBNull(reader["ADM_PLACE_EXAM_LOC_ID"]) ? null : (System.Decimal?)reader["ADM_PLACE_EXAM_LOC_ID"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.ReExamFlg = Convert.IsDBNull(reader["RE_EXAM_FLG"]) ? null : (System.Boolean?)reader["RE_EXAM_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppPlacementExam entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppPlacementExamId = (System.Decimal)reader[((int)AdmAppPlacementExamColumn.AdmAppPlacementExamId - 1)];
			entity.OriginalAdmAppPlacementExamId = (System.Decimal)reader["ADM_APP_PLACEMENT_EXAM_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppPlacementExamColumn.AdmApplicantId - 1)];
			entity.Mark = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.Mark - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.Mark - 1)];
			entity.PassFlg = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.PassFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.PassFlg - 1)];
			entity.AbsentFlg = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AbsentFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AbsentFlg - 1)];
			entity.AdmPlaceExamDatetimeId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AdmPlaceExamDatetimeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AdmPlaceExamDatetimeId - 1)];
			entity.AdmCdePlacementExamId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AdmCdePlacementExamId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AdmCdePlacementExamId - 1)];
			entity.AttchCertPath = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AttchCertPath - 1)))?null:(System.String)reader[((int)AdmAppPlacementExamColumn.AttchCertPath - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AdmCdeExamGrdngId - 1)];
			entity.ExemptFlg = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.ExemptFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppPlacementExamColumn.ExemptFlg - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppPlacementExamColumn.ApproveFlg - 1)];
			entity.AdmPlaceExamLocId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AdmPlaceExamLocId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AdmPlaceExamLocId - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.AdmAppRegHistoryId - 1)];
			entity.ReExamFlg = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.ReExamFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppPlacementExamColumn.ReExamFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppPlacementExamColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppPlacementExamColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppPlacementExamColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppPlacementExam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppPlacementExamId = (System.Decimal)dataRow["ADM_APP_PLACEMENT_EXAM_ID"];
			entity.OriginalAdmAppPlacementExamId = (System.Decimal)dataRow["ADM_APP_PLACEMENT_EXAM_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.Mark = Convert.IsDBNull(dataRow["MARK"]) ? null : (System.Decimal?)dataRow["MARK"];
			entity.PassFlg = Convert.IsDBNull(dataRow["PASS_FLG"]) ? null : (System.Decimal?)dataRow["PASS_FLG"];
			entity.AbsentFlg = Convert.IsDBNull(dataRow["ABSENT_FLG"]) ? null : (System.Decimal?)dataRow["ABSENT_FLG"];
			entity.AdmPlaceExamDatetimeId = Convert.IsDBNull(dataRow["ADM_PLACE_EXAM_DATETIME_ID"]) ? null : (System.Decimal?)dataRow["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.AdmCdePlacementExamId = Convert.IsDBNull(dataRow["ADM_CDE_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.AttchCertPath = Convert.IsDBNull(dataRow["ATTCH_CERT_PATH"]) ? null : (System.String)dataRow["ATTCH_CERT_PATH"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.ExemptFlg = Convert.IsDBNull(dataRow["EXEMPT_FLG"]) ? null : (System.Boolean?)dataRow["EXEMPT_FLG"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.AdmPlaceExamLocId = Convert.IsDBNull(dataRow["ADM_PLACE_EXAM_LOC_ID"]) ? null : (System.Decimal?)dataRow["ADM_PLACE_EXAM_LOC_ID"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.ReExamFlg = Convert.IsDBNull(dataRow["RE_EXAM_FLG"]) ? null : (System.Boolean?)dataRow["RE_EXAM_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppPlacementExam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppPlacementExam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppPlacementExam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdePlacementExamId ?? 0.0m);
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, (entity.AdmCdePlacementExamId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacementExamIdSource

			#region AdmPlaceExamDatetimeIdSource	
			if (CanDeepLoad(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepLoadType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmPlaceExamDatetimeId ?? 0.0m);
				AdmPlaceExamDatetime tmpEntity = EntityManager.LocateEntity<AdmPlaceExamDatetime>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmPlaceExamDatetime), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmPlaceExamDatetimeIdSource = tmpEntity;
				else
					entity.AdmPlaceExamDatetimeIdSource = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmPlaceExamDatetimeId(transactionManager, (entity.AdmPlaceExamDatetimeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmPlaceExamDatetimeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad(transactionManager, entity.AdmPlaceExamDatetimeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmPlaceExamDatetimeIdSource

			#region AdmPlaceExamLocIdSource	
			if (CanDeepLoad(entity, "AdmPlaceExamLoc|AdmPlaceExamLocIdSource", deepLoadType, innerList) 
				&& entity.AdmPlaceExamLocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmPlaceExamLocId ?? 0.0m);
				AdmPlaceExamLoc tmpEntity = EntityManager.LocateEntity<AdmPlaceExamLoc>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmPlaceExamLoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmPlaceExamLocIdSource = tmpEntity;
				else
					entity.AdmPlaceExamLocIdSource = DataRepository.AdmPlaceExamLocProvider.GetByAdmPlaceExamLocId(transactionManager, (entity.AdmPlaceExamLocId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamLocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmPlaceExamLocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmPlaceExamLocProvider.DeepLoad(transactionManager, entity.AdmPlaceExamLocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmPlaceExamLocIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppPlacementExamId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByAdmAppPlacementExamId(transactionManager, entity.AdmAppPlacementExamId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppPlacementExam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppPlacementExam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppPlacementExam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppPlacementExam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
			}
			#endregion 
			
			#region AdmPlaceExamDatetimeIdSource
			if (CanDeepSave(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepSaveType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource != null)
			{
				DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeIdSource);
				entity.AdmPlaceExamDatetimeId = entity.AdmPlaceExamDatetimeIdSource.AdmPlaceExamDatetimeId;
			}
			#endregion 
			
			#region AdmPlaceExamLocIdSource
			if (CanDeepSave(entity, "AdmPlaceExamLoc|AdmPlaceExamLocIdSource", deepSaveType, innerList) 
				&& entity.AdmPlaceExamLocIdSource != null)
			{
				DataRepository.AdmPlaceExamLocProvider.Save(transactionManager, entity.AdmPlaceExamLocIdSource);
				entity.AdmPlaceExamLocId = entity.AdmPlaceExamLocIdSource.AdmPlaceExamLocId;
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
						if(child.AdmAppPlacementExamIdSource != null)
						{
							child.AdmAppPlacementExamId = child.AdmAppPlacementExamIdSource.AdmAppPlacementExamId;
						}
						else
						{
							child.AdmAppPlacementExamId = entity.AdmAppPlacementExamId;
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
	
	#region AdmAppPlacementExamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppPlacementExam</c>
	///</summary>
	public enum AdmAppPlacementExamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>AdmPlaceExamDatetime</c> at AdmPlaceExamDatetimeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmPlaceExamDatetime))]
		AdmPlaceExamDatetime,
		
		///<summary>
		/// Composite Property for <c>AdmPlaceExamLoc</c> at AdmPlaceExamLocIdSource
		///</summary>
		[ChildEntityType(typeof(AdmPlaceExamLoc))]
		AdmPlaceExamLoc,
		///<summary>
		/// Collection of <c>AdmAppPlacementExam</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion AdmAppPlacementExamChildEntityTypes
	
	#region AdmAppPlacementExamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppPlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppPlacementExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppPlacementExamFilterBuilder : SqlFilterBuilder<AdmAppPlacementExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamFilterBuilder class.
		/// </summary>
		public AdmAppPlacementExamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppPlacementExamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppPlacementExamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppPlacementExamFilterBuilder
	
	#region AdmAppPlacementExamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppPlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppPlacementExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppPlacementExamParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppPlacementExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamParameterBuilder class.
		/// </summary>
		public AdmAppPlacementExamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppPlacementExamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppPlacementExamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppPlacementExamParameterBuilder
	
	#region AdmAppPlacementExamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppPlacementExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppPlacementExam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppPlacementExamSortBuilder : SqlSortBuilder<AdmAppPlacementExamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppPlacementExamSqlSortBuilder class.
		/// </summary>
		public AdmAppPlacementExamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppPlacementExamSortBuilder
	
} // end namespace
