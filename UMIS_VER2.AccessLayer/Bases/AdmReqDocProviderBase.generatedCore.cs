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
	/// This class is the base class for any <see cref="AdmReqDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmReqDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmReqDoc, UMIS_VER2.BusinessLyer.AdmReqDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmReqDocKey key)
		{
			return Delete(transactionManager, key.AdmReqDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admReqDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admReqDocId)
		{
			return Delete(null, _admReqDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admReqDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		fkAdmReqDocAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		fkAdmReqDocAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE key.
		///		FK_ADM_REQ_DOC_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		fkAdmReqDocAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		fkAdmReqDocAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		fkAdmReqDocAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		fkAdmReqDocAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_REQ_DOC_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		FK_ADM_REQ_DOC_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByEdCodeQualId(System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(_edCodeQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		FK_ADM_REQ_DOC_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		FK_ADM_REQ_DOC_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		fkAdmReqDocEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		fkAdmReqDocEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_ED_CODE_QUAL key.
		///		FK_ADM_REQ_DOC_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		FK_ADM_REQ_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="_gsCdeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(_gsCdeDocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		FK_ADM_REQ_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		FK_ADM_REQ_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		fkAdmReqDocGsCdeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		fkAdmReqDocGsCdeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId, int start, int pageLength,out int count)
		{
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_DOC key.
		///		FK_ADM_REQ_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(_gsCdeMaritalStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		fkAdmReqDocGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		fkAdmReqDocGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_REQ_DOC_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		FK_ADM_REQ_DOC_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(_gsCdeSchoolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		FK_ADM_REQ_DOC_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		FK_ADM_REQ_DOC_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		fkAdmReqDocGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		fkAdmReqDocGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_GS_CDE_SCHOOL key.
		///		FK_ADM_REQ_DOC_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">اكواد المدارس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="_spoSponsorTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(_spoSponsorTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmReqDoc> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		fkAdmReqDocSpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		fkAdmReqDocSpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public TList<AdmReqDoc> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE key.
		///		FK_ADM_REQ_DOC_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmReqDoc objects.</returns>
		public abstract TList<AdmReqDoc> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmReqDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmReqDocKey key, int start, int pageLength)
		{
			return GetByAdmReqDocId(transactionManager, key.AdmReqDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public abstract TList<AdmReqDoc> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(null,_gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public TList<AdmReqDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmReqDoc&gt;"/> class.</returns>
		public abstract TList<AdmReqDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="_admReqDocId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(System.Decimal _admReqDocId)
		{
			int count = -1;
			return GetByAdmReqDocId(null,_admReqDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(System.Decimal _admReqDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmReqDocId(null, _admReqDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal _admReqDocId)
		{
			int count = -1;
			return GetByAdmReqDocId(transactionManager, _admReqDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal _admReqDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmReqDocId(transactionManager, _admReqDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(System.Decimal _admReqDocId, int start, int pageLength, out int count)
		{
			return GetByAdmReqDocId(null, _admReqDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_REQ_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmReqDoc GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal _admReqDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmReqDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmReqDoc&gt;"/></returns>
		public static TList<AdmReqDoc> Fill(IDataReader reader, TList<AdmReqDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmReqDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmReqDoc")
					.Append("|").Append((System.Decimal)reader["ADM_REQ_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmReqDoc>(
					key.ToString(), // EntityTrackingKey
					"AdmReqDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmReqDoc();
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
					c.AdmReqDocId = (System.Decimal)reader["ADM_REQ_DOC_ID"];
					c.OriginalAdmReqDocId = c.AdmReqDocId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DocTemplatePath = Convert.IsDBNull(reader["DOC_TEMPLATE_PATH"]) ? null : (System.String)reader["DOC_TEMPLATE_PATH"];
					c.DelFlg = (System.Decimal)reader["DEL_FLG"];
					c.OrigDocNo = (System.Decimal)reader["ORIG_DOC_NO"];
					c.CopyDocNo = (System.Decimal)reader["COPY_DOC_NO"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.DocTypeFlg = (System.Decimal)reader["DOC_TYPE_FLG"];
					c.AutoloadFlg = (System.Decimal)reader["AUTOLOAD_FLG"];
					c.TransAppFlg = (System.Decimal)reader["TRANS_APP_FLG"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EdCodeQualId = Convert.IsDBNull(reader["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_ID"];
					c.GsCdeSchoolId = Convert.IsDBNull(reader["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)reader["GS_CDE_SCHOOL_ID"];
					c.OptionalFlg = Convert.IsDBNull(reader["OPTIONAL_FLG"]) ? null : (System.Boolean?)reader["OPTIONAL_FLG"];
					c.DocHint = Convert.IsDBNull(reader["DOC_HINT"]) ? null : (System.String)reader["DOC_HINT"];
					c.GsCdeDocId = Convert.IsDBNull(reader["GS_CDE_DOC_ID"]) ? null : (System.Int32?)reader["GS_CDE_DOC_ID"];
					c.GsCdeMaritalStatusId = Convert.IsDBNull(reader["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_MARITAL_STATUS_ID"];
					c.ForeignFlg = Convert.IsDBNull(reader["FOREIGN_FLG"]) ? null : (System.Decimal?)reader["FOREIGN_FLG"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.SponsoredFlg = Convert.IsDBNull(reader["SPONSORED_FLG"]) ? null : (System.Boolean?)reader["SPONSORED_FLG"];
					c.SpoSponsorTypeId = Convert.IsDBNull(reader["SPO_SPONSOR_TYPE_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_TYPE_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.AppHideFlg = Convert.IsDBNull(reader["APP_HIDE_FLG"]) ? null : (System.Decimal?)reader["APP_HIDE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmReqDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmReqDocId = (System.Decimal)reader[((int)AdmReqDocColumn.AdmReqDocId - 1)];
			entity.OriginalAdmReqDocId = (System.Decimal)reader["ADM_REQ_DOC_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)AdmReqDocColumn.EntMainId - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)AdmReqDocColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmReqDocColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmReqDocColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmReqDocColumn.DescrEn - 1)];
			entity.DocTemplatePath = (reader.IsDBNull(((int)AdmReqDocColumn.DocTemplatePath - 1)))?null:(System.String)reader[((int)AdmReqDocColumn.DocTemplatePath - 1)];
			entity.DelFlg = (System.Decimal)reader[((int)AdmReqDocColumn.DelFlg - 1)];
			entity.OrigDocNo = (System.Decimal)reader[((int)AdmReqDocColumn.OrigDocNo - 1)];
			entity.CopyDocNo = (System.Decimal)reader[((int)AdmReqDocColumn.CopyDocNo - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)AdmReqDocColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.GsCodeGenderId - 1)];
			entity.DocTypeFlg = (System.Decimal)reader[((int)AdmReqDocColumn.DocTypeFlg - 1)];
			entity.AutoloadFlg = (System.Decimal)reader[((int)AdmReqDocColumn.AutoloadFlg - 1)];
			entity.TransAppFlg = (System.Decimal)reader[((int)AdmReqDocColumn.TransAppFlg - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmReqDocColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmReqDocColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.AsCodeDegreeId - 1)];
			entity.EdCodeQualId = (reader.IsDBNull(((int)AdmReqDocColumn.EdCodeQualId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.EdCodeQualId - 1)];
			entity.GsCdeSchoolId = (reader.IsDBNull(((int)AdmReqDocColumn.GsCdeSchoolId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.GsCdeSchoolId - 1)];
			entity.OptionalFlg = (reader.IsDBNull(((int)AdmReqDocColumn.OptionalFlg - 1)))?null:(System.Boolean?)reader[((int)AdmReqDocColumn.OptionalFlg - 1)];
			entity.DocHint = (reader.IsDBNull(((int)AdmReqDocColumn.DocHint - 1)))?null:(System.String)reader[((int)AdmReqDocColumn.DocHint - 1)];
			entity.GsCdeDocId = (reader.IsDBNull(((int)AdmReqDocColumn.GsCdeDocId - 1)))?null:(System.Int32?)reader[((int)AdmReqDocColumn.GsCdeDocId - 1)];
			entity.GsCdeMaritalStatusId = (reader.IsDBNull(((int)AdmReqDocColumn.GsCdeMaritalStatusId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.GsCdeMaritalStatusId - 1)];
			entity.ForeignFlg = (reader.IsDBNull(((int)AdmReqDocColumn.ForeignFlg - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.ForeignFlg - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)AdmReqDocColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.AdmCdeAppTypeId - 1)];
			entity.SponsoredFlg = (reader.IsDBNull(((int)AdmReqDocColumn.SponsoredFlg - 1)))?null:(System.Boolean?)reader[((int)AdmReqDocColumn.SponsoredFlg - 1)];
			entity.SpoSponsorTypeId = (reader.IsDBNull(((int)AdmReqDocColumn.SpoSponsorTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.SpoSponsorTypeId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmReqDocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmReqDocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmReqDocColumn.LastDate - 1)];
			entity.AppHideFlg = (reader.IsDBNull(((int)AdmReqDocColumn.AppHideFlg - 1)))?null:(System.Decimal?)reader[((int)AdmReqDocColumn.AppHideFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmReqDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmReqDocId = (System.Decimal)dataRow["ADM_REQ_DOC_ID"];
			entity.OriginalAdmReqDocId = (System.Decimal)dataRow["ADM_REQ_DOC_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DocTemplatePath = Convert.IsDBNull(dataRow["DOC_TEMPLATE_PATH"]) ? null : (System.String)dataRow["DOC_TEMPLATE_PATH"];
			entity.DelFlg = (System.Decimal)dataRow["DEL_FLG"];
			entity.OrigDocNo = (System.Decimal)dataRow["ORIG_DOC_NO"];
			entity.CopyDocNo = (System.Decimal)dataRow["COPY_DOC_NO"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.DocTypeFlg = (System.Decimal)dataRow["DOC_TYPE_FLG"];
			entity.AutoloadFlg = (System.Decimal)dataRow["AUTOLOAD_FLG"];
			entity.TransAppFlg = (System.Decimal)dataRow["TRANS_APP_FLG"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.EdCodeQualId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_ID"];
			entity.GsCdeSchoolId = Convert.IsDBNull(dataRow["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_SCHOOL_ID"];
			entity.OptionalFlg = Convert.IsDBNull(dataRow["OPTIONAL_FLG"]) ? null : (System.Boolean?)dataRow["OPTIONAL_FLG"];
			entity.DocHint = Convert.IsDBNull(dataRow["DOC_HINT"]) ? null : (System.String)dataRow["DOC_HINT"];
			entity.GsCdeDocId = Convert.IsDBNull(dataRow["GS_CDE_DOC_ID"]) ? null : (System.Int32?)dataRow["GS_CDE_DOC_ID"];
			entity.GsCdeMaritalStatusId = Convert.IsDBNull(dataRow["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_MARITAL_STATUS_ID"];
			entity.ForeignFlg = Convert.IsDBNull(dataRow["FOREIGN_FLG"]) ? null : (System.Decimal?)dataRow["FOREIGN_FLG"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.SponsoredFlg = Convert.IsDBNull(dataRow["SPONSORED_FLG"]) ? null : (System.Boolean?)dataRow["SPONSORED_FLG"];
			entity.SpoSponsorTypeId = Convert.IsDBNull(dataRow["SPO_SPONSOR_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_TYPE_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.AppHideFlg = Convert.IsDBNull(dataRow["APP_HIDE_FLG"]) ? null : (System.Decimal?)dataRow["APP_HIDE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmReqDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmReqDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmReqDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppTypeId ?? 0.0m);
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, (entity.AdmCdeAppTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

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

			#region EdCodeQualIdSource	
			if (CanDeepLoad(entity, "EdCodeQual|EdCodeQualIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualId ?? 0.0m);
				EdCodeQual tmpEntity = EntityManager.LocateEntity<EdCodeQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualIdSource = tmpEntity;
				else
					entity.EdCodeQualIdSource = DataRepository.EdCodeQualProvider.GetByEdCodeQualId(transactionManager, (entity.EdCodeQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualProvider.DeepLoad(transactionManager, entity.EdCodeQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualIdSource

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

			#region GsCdeDocIdSource	
			if (CanDeepLoad(entity, "GsCdeDoc|GsCdeDocIdSource", deepLoadType, innerList) 
				&& entity.GsCdeDocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeDocId ?? (int)0);
				GsCdeDoc tmpEntity = EntityManager.LocateEntity<GsCdeDoc>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeDoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeDocIdSource = tmpEntity;
				else
					entity.GsCdeDocIdSource = DataRepository.GsCdeDocProvider.GetByGsCdeDocId(transactionManager, (entity.GsCdeDocId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeDocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeDocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeDocProvider.DeepLoad(transactionManager, entity.GsCdeDocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeDocIdSource

			#region GsCdeMaritalStatusIdSource	
			if (CanDeepLoad(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeMaritalStatusId ?? 0.0m);
				GsCdeMaritalStatus tmpEntity = EntityManager.LocateEntity<GsCdeMaritalStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeMaritalStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeMaritalStatusIdSource = tmpEntity;
				else
					entity.GsCdeMaritalStatusIdSource = DataRepository.GsCdeMaritalStatusProvider.GetByGsCdeMaritalStatusId(transactionManager, (entity.GsCdeMaritalStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeMaritalStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeMaritalStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeMaritalStatusProvider.DeepLoad(transactionManager, entity.GsCdeMaritalStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeMaritalStatusIdSource

			#region GsCdeSchoolIdSource	
			if (CanDeepLoad(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSchoolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeSchoolId ?? 0.0m);
				GsCdeSchool tmpEntity = EntityManager.LocateEntity<GsCdeSchool>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSchool), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSchoolIdSource = tmpEntity;
				else
					entity.GsCdeSchoolIdSource = DataRepository.GsCdeSchoolProvider.GetByGsCdeSchoolId(transactionManager, (entity.GsCdeSchoolId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSchoolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSchoolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSchoolProvider.DeepLoad(transactionManager, entity.GsCdeSchoolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSchoolIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region SpoSponsorTypeIdSource	
			if (CanDeepLoad(entity, "SpoSponsorType|SpoSponsorTypeIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorTypeId ?? 0.0m);
				SpoSponsorType tmpEntity = EntityManager.LocateEntity<SpoSponsorType>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorTypeIdSource = tmpEntity;
				else
					entity.SpoSponsorTypeIdSource = DataRepository.SpoSponsorTypeProvider.GetBySpoSponsorTypeId(transactionManager, (entity.SpoSponsorTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorTypeProvider.DeepLoad(transactionManager, entity.SpoSponsorTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmReqDocId methods when available
			
			#region AdmAppDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDoc>|AdmAppDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDocCollection = DataRepository.AdmAppDocProvider.GetByAdmReqDocId(transactionManager, entity.AdmReqDocId);

				if (deep && entity.AdmAppDocCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDoc>) DataRepository.AdmAppDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmReqDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmReqDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmReqDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmReqDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
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
			
			#region EdCodeQualIdSource
			if (CanDeepSave(entity, "EdCodeQual|EdCodeQualIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualIdSource != null)
			{
				DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualIdSource);
				entity.EdCodeQualId = entity.EdCodeQualIdSource.EdCodeQualId;
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
			
			#region GsCdeDocIdSource
			if (CanDeepSave(entity, "GsCdeDoc|GsCdeDocIdSource", deepSaveType, innerList) 
				&& entity.GsCdeDocIdSource != null)
			{
				DataRepository.GsCdeDocProvider.Save(transactionManager, entity.GsCdeDocIdSource);
				entity.GsCdeDocId = entity.GsCdeDocIdSource.GsCdeDocId;
			}
			#endregion 
			
			#region GsCdeMaritalStatusIdSource
			if (CanDeepSave(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource != null)
			{
				DataRepository.GsCdeMaritalStatusProvider.Save(transactionManager, entity.GsCdeMaritalStatusIdSource);
				entity.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
			}
			#endregion 
			
			#region GsCdeSchoolIdSource
			if (CanDeepSave(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSchoolIdSource != null)
			{
				DataRepository.GsCdeSchoolProvider.Save(transactionManager, entity.GsCdeSchoolIdSource);
				entity.GsCdeSchoolId = entity.GsCdeSchoolIdSource.GsCdeSchoolId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region SpoSponsorTypeIdSource
			if (CanDeepSave(entity, "SpoSponsorType|SpoSponsorTypeIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorTypeIdSource != null)
			{
				DataRepository.SpoSponsorTypeProvider.Save(transactionManager, entity.SpoSponsorTypeIdSource);
				entity.SpoSponsorTypeId = entity.SpoSponsorTypeIdSource.SpoSponsorTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppDoc>
				if (CanDeepSave(entity.AdmAppDocCollection, "List<AdmAppDoc>|AdmAppDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDoc child in entity.AdmAppDocCollection)
					{
						if(child.AdmReqDocIdSource != null)
						{
							child.AdmReqDocId = child.AdmReqDocIdSource.AdmReqDocId;
						}
						else
						{
							child.AdmReqDocId = entity.AdmReqDocId;
						}

					}

					if (entity.AdmAppDocCollection.Count > 0 || entity.AdmAppDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDocProvider.Save(transactionManager, entity.AdmAppDocCollection);
						
						deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDoc >) DataRepository.AdmAppDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmReqDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmReqDoc</c>
	///</summary>
	public enum AdmReqDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
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
		/// Composite Property for <c>EdCodeQual</c> at EdCodeQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQual))]
		EdCodeQual,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCdeDoc</c> at GsCdeDocIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeDoc))]
		GsCdeDoc,
		
		///<summary>
		/// Composite Property for <c>GsCdeMaritalStatus</c> at GsCdeMaritalStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeMaritalStatus))]
		GsCdeMaritalStatus,
		
		///<summary>
		/// Composite Property for <c>GsCdeSchool</c> at GsCdeSchoolIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSchool))]
		GsCdeSchool,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorType</c> at SpoSponsorTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorType))]
		SpoSponsorType,
		///<summary>
		/// Collection of <c>AdmReqDoc</c> as OneToMany for AdmAppDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDoc>))]
		AdmAppDocCollection,
	}
	
	#endregion AdmReqDocChildEntityTypes
	
	#region AdmReqDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmReqDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmReqDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmReqDocFilterBuilder : SqlFilterBuilder<AdmReqDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmReqDocFilterBuilder class.
		/// </summary>
		public AdmReqDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmReqDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmReqDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmReqDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmReqDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmReqDocFilterBuilder
	
	#region AdmReqDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmReqDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmReqDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmReqDocParameterBuilder : ParameterizedSqlFilterBuilder<AdmReqDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmReqDocParameterBuilder class.
		/// </summary>
		public AdmReqDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmReqDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmReqDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmReqDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmReqDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmReqDocParameterBuilder
	
	#region AdmReqDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmReqDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmReqDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmReqDocSortBuilder : SqlSortBuilder<AdmReqDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmReqDocSqlSortBuilder class.
		/// </summary>
		public AdmReqDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmReqDocSortBuilder
	
} // end namespace
