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
	/// This class is the base class for any <see cref="FeeCdeDiscTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeDiscTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeDiscType, UMIS_VER2.BusinessLyer.FeeCdeDiscTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeDiscTypeKey key)
		{
			return Delete(transactionManager, key.FeeCdeDiscTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCdeDiscTypeId)
		{
			return Delete(null, _feeCdeDiscTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeCdeDiscTypeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeCdeDiscTypeAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_CDE_DISC_TYPE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">IF MLT_DEGREE=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		fkFeeCdeDiscTypeAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		fkFeeCdeDiscTypeAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO key.
		///		FK_FEE_CDE_DISC_TYPE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		fkFeeCdeDiscTypeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		fkFeeCdeDiscTypeEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR key.
		///		FK_FEE_CDE_DISC_TYPE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(_edCdeQualCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		fkFeeCdeDiscTypeEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		fkFeeCdeDiscTypeEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(_feeCdeDiscCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(transactionManager, _feeCdeDiscCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(transactionManager, _feeCdeDiscCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		fkFeeCdeDiscTypeFeeCdeDiscCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeDiscCatId(null, _feeCdeDiscCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		fkFeeCdeDiscTypeFeeCdeDiscCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeDiscCatId(null, _feeCdeDiscCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId">Category</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(System.Int32? _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(_feeCdeSchshipCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		fkFeeCdeDiscTypeFeeCdeSchshipCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(System.Int32? _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		fkFeeCdeDiscTypeFeeCdeSchshipCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(System.Int32? _feeCdeSchshipCatId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_CDE_DISC_TYPE_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeDiscType objects.</returns>
		public abstract TList<FeeCdeDiscType> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeDiscType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeDiscTypeKey key, int start, int pageLength)
		{
			return GetByFeeCdeDiscTypeId(transactionManager, key.FeeCdeDiscTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(null,_feeCdeDiscTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(System.Decimal _feeCdeDiscTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_DESCOUNT_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">انواع المنح والتخفيضات والمساعدات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeDiscType GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal _feeCdeDiscTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeDiscType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeDiscType&gt;"/></returns>
		public static TList<FeeCdeDiscType> Fill(IDataReader reader, TList<FeeCdeDiscType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeDiscType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeDiscType")
					.Append("|").Append((System.Decimal)reader["FEE_CDE_DISC_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeDiscType>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeDiscType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeDiscType();
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
					c.FeeCdeDiscTypeId = (System.Decimal)reader["FEE_CDE_DISC_TYPE_ID"];
					c.OriginalFeeCdeDiscTypeId = c.FeeCdeDiscTypeId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DiscPrcnt = Convert.IsDBNull(reader["DISC_PRCNT"]) ? null : (System.Decimal?)reader["DISC_PRCNT"];
					c.StopFlg = (System.Decimal)reader["STOP_FLG"];
					c.DiscAmnt = Convert.IsDBNull(reader["DISC_AMNT"]) ? null : (System.Decimal?)reader["DISC_AMNT"];
					c.DiscTypeFlg = Convert.IsDBNull(reader["DISC_TYPE_FLG"]) ? null : (System.Int32?)reader["DISC_TYPE_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.FeeCdeDiscCatId = Convert.IsDBNull(reader["FEE_CDE_DISC_CAT_ID"]) ? null : (System.Int32?)reader["FEE_CDE_DISC_CAT_ID"];
					c.FeeCdeSchshipCatId = Convert.IsDBNull(reader["FEE_CDE_SCHSHIP_CAT_ID"]) ? null : (System.Int32?)reader["FEE_CDE_SCHSHIP_CAT_ID"];
					c.ParamFrom = Convert.IsDBNull(reader["PARAM_FROM"]) ? null : (System.Decimal?)reader["PARAM_FROM"];
					c.ParamTo = Convert.IsDBNull(reader["PARAM_TO"]) ? null : (System.Decimal?)reader["PARAM_TO"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.ConstFlg = Convert.IsDBNull(reader["CONST_FLG"]) ? null : (System.Boolean?)reader["CONST_FLG"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EdCdeQualCatId = Convert.IsDBNull(reader["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_CAT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeDiscType entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeDiscTypeId = (System.Decimal)reader[((int)FeeCdeDiscTypeColumn.FeeCdeDiscTypeId - 1)];
			entity.OriginalFeeCdeDiscTypeId = (System.Decimal)reader["FEE_CDE_DISC_TYPE_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.DescrAr - 1)))?null:(System.String)reader[((int)FeeCdeDiscTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)FeeCdeDiscTypeColumn.DescrEn - 1)];
			entity.DiscPrcnt = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.DiscPrcnt - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.DiscPrcnt - 1)];
			entity.StopFlg = (System.Decimal)reader[((int)FeeCdeDiscTypeColumn.StopFlg - 1)];
			entity.DiscAmnt = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.DiscAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.DiscAmnt - 1)];
			entity.DiscTypeFlg = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.DiscTypeFlg - 1)))?null:(System.Int32?)reader[((int)FeeCdeDiscTypeColumn.DiscTypeFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.AsFacultyInfoId - 1)];
			entity.FeeCdeDiscCatId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.FeeCdeDiscCatId - 1)))?null:(System.Int32?)reader[((int)FeeCdeDiscTypeColumn.FeeCdeDiscCatId - 1)];
			entity.FeeCdeSchshipCatId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.FeeCdeSchshipCatId - 1)))?null:(System.Int32?)reader[((int)FeeCdeDiscTypeColumn.FeeCdeSchshipCatId - 1)];
			entity.ParamFrom = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.ParamFrom - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.ParamFrom - 1)];
			entity.ParamTo = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.ParamTo - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.ParamTo - 1)];
			entity.IsActive = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)FeeCdeDiscTypeColumn.IsActive - 1)];
			entity.ConstFlg = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.ConstFlg - 1)))?null:(System.Boolean?)reader[((int)FeeCdeDiscTypeColumn.ConstFlg - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.EdAcadYearId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.AsCodeDegreeClassId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeCdeDiscTypeColumn.LastDate - 1)];
			entity.EdCdeQualCatId = (reader.IsDBNull(((int)FeeCdeDiscTypeColumn.EdCdeQualCatId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeDiscTypeColumn.EdCdeQualCatId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeDiscType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeDiscTypeId = (System.Decimal)dataRow["FEE_CDE_DISC_TYPE_ID"];
			entity.OriginalFeeCdeDiscTypeId = (System.Decimal)dataRow["FEE_CDE_DISC_TYPE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DiscPrcnt = Convert.IsDBNull(dataRow["DISC_PRCNT"]) ? null : (System.Decimal?)dataRow["DISC_PRCNT"];
			entity.StopFlg = (System.Decimal)dataRow["STOP_FLG"];
			entity.DiscAmnt = Convert.IsDBNull(dataRow["DISC_AMNT"]) ? null : (System.Decimal?)dataRow["DISC_AMNT"];
			entity.DiscTypeFlg = Convert.IsDBNull(dataRow["DISC_TYPE_FLG"]) ? null : (System.Int32?)dataRow["DISC_TYPE_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.FeeCdeDiscCatId = Convert.IsDBNull(dataRow["FEE_CDE_DISC_CAT_ID"]) ? null : (System.Int32?)dataRow["FEE_CDE_DISC_CAT_ID"];
			entity.FeeCdeSchshipCatId = Convert.IsDBNull(dataRow["FEE_CDE_SCHSHIP_CAT_ID"]) ? null : (System.Int32?)dataRow["FEE_CDE_SCHSHIP_CAT_ID"];
			entity.ParamFrom = Convert.IsDBNull(dataRow["PARAM_FROM"]) ? null : (System.Decimal?)dataRow["PARAM_FROM"];
			entity.ParamTo = Convert.IsDBNull(dataRow["PARAM_TO"]) ? null : (System.Decimal?)dataRow["PARAM_TO"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.ConstFlg = Convert.IsDBNull(dataRow["CONST_FLG"]) ? null : (System.Boolean?)dataRow["CONST_FLG"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.EdCdeQualCatId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_CAT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeDiscType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeDiscType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeDiscType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

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

			#region EdCdeQualCatIdSource	
			if (CanDeepLoad(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualCatId ?? 0.0m);
				EdCdeQualCat tmpEntity = EntityManager.LocateEntity<EdCdeQualCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualCatIdSource = tmpEntity;
				else
					entity.EdCdeQualCatIdSource = DataRepository.EdCdeQualCatProvider.GetByEdCdeQualCatId(transactionManager, (entity.EdCdeQualCatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualCatProvider.DeepLoad(transactionManager, entity.EdCdeQualCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualCatIdSource

			#region FeeCdeDiscCatIdSource	
			if (CanDeepLoad(entity, "FeeCdeDiscCat|FeeCdeDiscCatIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeDiscCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeDiscCatId ?? (int)0);
				FeeCdeDiscCat tmpEntity = EntityManager.LocateEntity<FeeCdeDiscCat>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeDiscCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeDiscCatIdSource = tmpEntity;
				else
					entity.FeeCdeDiscCatIdSource = DataRepository.FeeCdeDiscCatProvider.GetByFeeCdeDiscCatId(transactionManager, (entity.FeeCdeDiscCatId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeDiscCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeDiscCatProvider.DeepLoad(transactionManager, entity.FeeCdeDiscCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeDiscCatIdSource

			#region FeeCdeSchshipCatIdSource	
			if (CanDeepLoad(entity, "FeeCdeSchshipCat|FeeCdeSchshipCatIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeSchshipCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeSchshipCatId ?? (int)0);
				FeeCdeSchshipCat tmpEntity = EntityManager.LocateEntity<FeeCdeSchshipCat>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeSchshipCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeSchshipCatIdSource = tmpEntity;
				else
					entity.FeeCdeSchshipCatIdSource = DataRepository.FeeCdeSchshipCatProvider.GetByFeeCdeSchshipCatId(transactionManager, (entity.FeeCdeSchshipCatId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeSchshipCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeSchshipCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeSchshipCatProvider.DeepLoad(transactionManager, entity.FeeCdeSchshipCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeSchshipCatIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeDiscTypeId methods when available
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByFeeCdeDiscTypeId(transactionManager, entity.FeeCdeDiscTypeId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByFeeCdeDiscTypeId(transactionManager, entity.FeeCdeDiscTypeId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeDiscType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeDiscType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeDiscType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeDiscType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			
			#region EdCdeQualCatIdSource
			if (CanDeepSave(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualCatIdSource != null)
			{
				DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatIdSource);
				entity.EdCdeQualCatId = entity.EdCdeQualCatIdSource.EdCdeQualCatId;
			}
			#endregion 
			
			#region FeeCdeDiscCatIdSource
			if (CanDeepSave(entity, "FeeCdeDiscCat|FeeCdeDiscCatIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeDiscCatIdSource != null)
			{
				DataRepository.FeeCdeDiscCatProvider.Save(transactionManager, entity.FeeCdeDiscCatIdSource);
				entity.FeeCdeDiscCatId = entity.FeeCdeDiscCatIdSource.FeeCdeDiscCatId;
			}
			#endregion 
			
			#region FeeCdeSchshipCatIdSource
			if (CanDeepSave(entity, "FeeCdeSchshipCat|FeeCdeSchshipCatIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeSchshipCatIdSource != null)
			{
				DataRepository.FeeCdeSchshipCatProvider.Save(transactionManager, entity.FeeCdeSchshipCatIdSource);
				entity.FeeCdeSchshipCatId = entity.FeeCdeSchshipCatIdSource.FeeCdeSchshipCatId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.FeeCdeDiscTypeIdSource != null)
						{
							child.FeeCdeDiscTypeId = child.FeeCdeDiscTypeIdSource.FeeCdeDiscTypeId;
						}
						else
						{
							child.FeeCdeDiscTypeId = entity.FeeCdeDiscTypeId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.FeeCdeDiscTypeIdSource != null)
						{
							child.FeeCdeDiscTypeId = child.FeeCdeDiscTypeIdSource.FeeCdeDiscTypeId;
						}
						else
						{
							child.FeeCdeDiscTypeId = entity.FeeCdeDiscTypeId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeDiscTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeDiscType</c>
	///</summary>
	public enum FeeCdeDiscTypeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualCat</c> at EdCdeQualCatIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualCat))]
		EdCdeQualCat,
		
		///<summary>
		/// Composite Property for <c>FeeCdeDiscCat</c> at FeeCdeDiscCatIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeDiscCat))]
		FeeCdeDiscCat,
		
		///<summary>
		/// Composite Property for <c>FeeCdeSchshipCat</c> at FeeCdeSchshipCatIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeSchshipCat))]
		FeeCdeSchshipCat,
		///<summary>
		/// Collection of <c>FeeCdeDiscType</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>FeeCdeDiscType</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
	}
	
	#endregion FeeCdeDiscTypeChildEntityTypes
	
	#region FeeCdeDiscTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeDiscTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeDiscType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeDiscTypeFilterBuilder : SqlFilterBuilder<FeeCdeDiscTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeFilterBuilder class.
		/// </summary>
		public FeeCdeDiscTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeDiscTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeDiscTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeDiscTypeFilterBuilder
	
	#region FeeCdeDiscTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeDiscTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeDiscType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeDiscTypeParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeDiscTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeParameterBuilder class.
		/// </summary>
		public FeeCdeDiscTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeDiscTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeDiscTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeDiscTypeParameterBuilder
	
	#region FeeCdeDiscTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeDiscTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeDiscType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeDiscTypeSortBuilder : SqlSortBuilder<FeeCdeDiscTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeDiscTypeSqlSortBuilder class.
		/// </summary>
		public FeeCdeDiscTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeDiscTypeSortBuilder
	
} // end namespace
