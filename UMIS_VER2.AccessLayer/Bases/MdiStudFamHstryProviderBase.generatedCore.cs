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
	/// This class is the base class for any <see cref="MdiStudFamHstryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudFamHstryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudFamHstry, UMIS_VER2.BusinessLyer.MdiStudFamHstryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudFamHstryKey key)
		{
			return Delete(transactionManager, key.MdiStudFamHstryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudFamHstryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudFamHstryId)
		{
			return Delete(null, _mdiStudFamHstryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudFamHstryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudFamHstryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="_gsCodeRelationId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(_gsCodeRelationId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudFamHstry> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		fkMdiStudFamHstryGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		fkMdiStudFamHstryGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength,out int count)
		{
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP key.
		///		FK_MDI_STUD_FAM_HSTRY_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public abstract TList<MdiStudFamHstry> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 Description: 
		/// </summary>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(_mdiCdeDiseaseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(transactionManager, _mdiCdeDiseaseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeDiseaseId(transactionManager, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		fkMdiStudFamHstryMdiCdeDisease1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeDiseaseId(null, _mdiCdeDiseaseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		fkMdiStudFamHstryMdiCdeDisease1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(System.Decimal _mdiCdeDiseaseId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeDiseaseId(null, _mdiCdeDiseaseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_CDE_DISEASE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public abstract TList<MdiStudFamHstry> GetByMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiCdeDiseaseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(_mdiStudRecordId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudFamHstry> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		fkMdiStudFamHstryMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		fkMdiStudFamHstryMdiStudRecord Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public TList<MdiStudFamHstry> GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength,out int count)
		{
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD key.
		///		FK_MDI_STUD_FAM_HSTRY_MDI_STUD_RECORD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudFamHstry objects.</returns>
		public abstract TList<MdiStudFamHstry> GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudFamHstry Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudFamHstryKey key, int start, int pageLength)
		{
			return GetByMdiStudFamHstryId(transactionManager, key.MdiStudFamHstryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(System.Decimal _mdiStudFamHstryId)
		{
			int count = -1;
			return GetByMdiStudFamHstryId(null,_mdiStudFamHstryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(System.Decimal _mdiStudFamHstryId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudFamHstryId(null, _mdiStudFamHstryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(TransactionManager transactionManager, System.Decimal _mdiStudFamHstryId)
		{
			int count = -1;
			return GetByMdiStudFamHstryId(transactionManager, _mdiStudFamHstryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(TransactionManager transactionManager, System.Decimal _mdiStudFamHstryId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudFamHstryId(transactionManager, _mdiStudFamHstryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(System.Decimal _mdiStudFamHstryId, int start, int pageLength, out int count)
		{
			return GetByMdiStudFamHstryId(null, _mdiStudFamHstryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudFamHstryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudFamHstryId(TransactionManager transactionManager, System.Decimal _mdiStudFamHstryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(null,_mdiStudRecordId, _gsCodeRelationId, _mdiCdeDiseaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(null, _mdiStudRecordId, _gsCodeRelationId, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId)
		{
			int count = -1;
			return GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(transactionManager, _mdiStudRecordId, _gsCodeRelationId, _mdiCdeDiseaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(transactionManager, _mdiStudRecordId, _gsCodeRelationId, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId, int start, int pageLength, out int count)
		{
			return GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(null, _mdiStudRecordId, _gsCodeRelationId, _mdiCdeDiseaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_FAM_HSTRY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId"></param>
		/// <param name="_gsCodeRelationId"></param>
		/// <param name="_mdiCdeDiseaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudFamHstry GetByMdiStudRecordIdGsCodeRelationIdMdiCdeDiseaseId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, System.Decimal _gsCodeRelationId, System.Decimal _mdiCdeDiseaseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudFamHstry&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudFamHstry&gt;"/></returns>
		public static TList<MdiStudFamHstry> Fill(IDataReader reader, TList<MdiStudFamHstry> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudFamHstry c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudFamHstry")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_FAM_HSTRY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudFamHstry>(
					key.ToString(), // EntityTrackingKey
					"MdiStudFamHstry",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudFamHstry();
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
					c.MdiStudFamHstryId = (System.Decimal)reader["MDI_STUD_FAM_HSTRY_ID"];
					c.OriginalMdiStudFamHstryId = c.MdiStudFamHstryId;
					c.MdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
					c.GsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
					c.MdiCdeDiseaseId = (System.Decimal)reader["MDI_CDE_DISEASE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudFamHstry entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudFamHstryId = (System.Decimal)reader[((int)MdiStudFamHstryColumn.MdiStudFamHstryId - 1)];
			entity.OriginalMdiStudFamHstryId = (System.Decimal)reader["MDI_STUD_FAM_HSTRY_ID"];
			entity.MdiStudRecordId = (System.Decimal)reader[((int)MdiStudFamHstryColumn.MdiStudRecordId - 1)];
			entity.GsCodeRelationId = (System.Decimal)reader[((int)MdiStudFamHstryColumn.GsCodeRelationId - 1)];
			entity.MdiCdeDiseaseId = (System.Decimal)reader[((int)MdiStudFamHstryColumn.MdiCdeDiseaseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudFamHstry entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudFamHstryId = (System.Decimal)dataRow["MDI_STUD_FAM_HSTRY_ID"];
			entity.OriginalMdiStudFamHstryId = (System.Decimal)dataRow["MDI_STUD_FAM_HSTRY_ID"];
			entity.MdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.GsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.MdiCdeDiseaseId = (System.Decimal)dataRow["MDI_CDE_DISEASE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudFamHstry"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudFamHstry Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudFamHstry entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeRelationIdSource	
			if (CanDeepLoad(entity, "GsCodeKinship|GsCodeRelationIdSource", deepLoadType, innerList) 
				&& entity.GsCodeRelationIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeRelationId;
				GsCodeKinship tmpEntity = EntityManager.LocateEntity<GsCodeKinship>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeKinship), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeRelationIdSource = tmpEntity;
				else
					entity.GsCodeRelationIdSource = DataRepository.GsCodeKinshipProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeRelationIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeRelationIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeKinshipProvider.DeepLoad(transactionManager, entity.GsCodeRelationIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeRelationIdSource

			#region MdiCdeDiseaseIdSource	
			if (CanDeepLoad(entity, "MdiCdeDisease|MdiCdeDiseaseIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeDiseaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeDiseaseId;
				MdiCdeDisease tmpEntity = EntityManager.LocateEntity<MdiCdeDisease>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeDisease), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeDiseaseIdSource = tmpEntity;
				else
					entity.MdiCdeDiseaseIdSource = DataRepository.MdiCdeDiseaseProvider.GetByMdiCdeDiseaseId(transactionManager, entity.MdiCdeDiseaseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeDiseaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeDiseaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeDiseaseProvider.DeepLoad(transactionManager, entity.MdiCdeDiseaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeDiseaseIdSource

			#region MdiStudRecordIdSource	
			if (CanDeepLoad(entity, "MdiStudRecord|MdiStudRecordIdSource", deepLoadType, innerList) 
				&& entity.MdiStudRecordIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiStudRecordId;
				MdiStudRecord tmpEntity = EntityManager.LocateEntity<MdiStudRecord>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiStudRecord), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiStudRecordIdSource = tmpEntity;
				else
					entity.MdiStudRecordIdSource = DataRepository.MdiStudRecordProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiStudRecordIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiStudRecordProvider.DeepLoad(transactionManager, entity.MdiStudRecordIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiStudRecordIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudFamHstry object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudFamHstry instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudFamHstry Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudFamHstry entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeRelationIdSource
			if (CanDeepSave(entity, "GsCodeKinship|GsCodeRelationIdSource", deepSaveType, innerList) 
				&& entity.GsCodeRelationIdSource != null)
			{
				DataRepository.GsCodeKinshipProvider.Save(transactionManager, entity.GsCodeRelationIdSource);
				entity.GsCodeRelationId = entity.GsCodeRelationIdSource.GsCodeRelationId;
			}
			#endregion 
			
			#region MdiCdeDiseaseIdSource
			if (CanDeepSave(entity, "MdiCdeDisease|MdiCdeDiseaseIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeDiseaseIdSource != null)
			{
				DataRepository.MdiCdeDiseaseProvider.Save(transactionManager, entity.MdiCdeDiseaseIdSource);
				entity.MdiCdeDiseaseId = entity.MdiCdeDiseaseIdSource.MdiCdeDiseaseId;
			}
			#endregion 
			
			#region MdiStudRecordIdSource
			if (CanDeepSave(entity, "MdiStudRecord|MdiStudRecordIdSource", deepSaveType, innerList) 
				&& entity.MdiStudRecordIdSource != null)
			{
				DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordIdSource);
				entity.MdiStudRecordId = entity.MdiStudRecordIdSource.MdiStudRecordId;
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
	
	#region MdiStudFamHstryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudFamHstry</c>
	///</summary>
	public enum MdiStudFamHstryChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeKinship</c> at GsCodeRelationIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeKinship))]
		GsCodeKinship,
		
		///<summary>
		/// Composite Property for <c>MdiCdeDisease</c> at MdiCdeDiseaseIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeDisease))]
		MdiCdeDisease,
		
		///<summary>
		/// Composite Property for <c>MdiStudRecord</c> at MdiStudRecordIdSource
		///</summary>
		[ChildEntityType(typeof(MdiStudRecord))]
		MdiStudRecord,
	}
	
	#endregion MdiStudFamHstryChildEntityTypes
	
	#region MdiStudFamHstryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudFamHstryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudFamHstry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudFamHstryFilterBuilder : SqlFilterBuilder<MdiStudFamHstryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryFilterBuilder class.
		/// </summary>
		public MdiStudFamHstryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudFamHstryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudFamHstryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudFamHstryFilterBuilder
	
	#region MdiStudFamHstryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudFamHstryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudFamHstry"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudFamHstryParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudFamHstryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryParameterBuilder class.
		/// </summary>
		public MdiStudFamHstryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudFamHstryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudFamHstryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudFamHstryParameterBuilder
	
	#region MdiStudFamHstrySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudFamHstryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudFamHstry"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudFamHstrySortBuilder : SqlSortBuilder<MdiStudFamHstryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudFamHstrySqlSortBuilder class.
		/// </summary>
		public MdiStudFamHstrySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudFamHstrySortBuilder
	
} // end namespace
