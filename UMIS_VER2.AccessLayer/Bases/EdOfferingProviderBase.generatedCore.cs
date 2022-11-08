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
	/// This class is the base class for any <see cref="EdOfferingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdOfferingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdOffering, UMIS_VER2.BusinessLyer.EdOfferingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingKey key)
		{
			return Delete(transactionManager, key.EdOfferingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edOfferingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edOfferingId)
		{
			return Delete(null, _edOfferingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edOfferingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_OFFERING_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_OFFERING_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		/// <remarks></remarks>
		public TList<EdOffering> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_OFFERING_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		fkEdOfferingAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		fkEdOfferingAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_OFFERING_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public abstract TList<EdOffering> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		FK_ED_OFFERING_SE_USER Description: 
		/// </summary>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdHodApprvUsrId(System.Decimal? _crsSchdHodApprvUsrId)
		{
			int count = -1;
			return GetByCrsSchdHodApprvUsrId(_crsSchdHodApprvUsrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		FK_ED_OFFERING_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		/// <remarks></remarks>
		public TList<EdOffering> GetByCrsSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdHodApprvUsrId)
		{
			int count = -1;
			return GetByCrsSchdHodApprvUsrId(transactionManager, _crsSchdHodApprvUsrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		FK_ED_OFFERING_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdHodApprvUsrId, int start, int pageLength)
		{
			int count = -1;
			return GetByCrsSchdHodApprvUsrId(transactionManager, _crsSchdHodApprvUsrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		fkEdOfferingSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdHodApprvUsrId(System.Decimal? _crsSchdHodApprvUsrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCrsSchdHodApprvUsrId(null, _crsSchdHodApprvUsrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		fkEdOfferingSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdHodApprvUsrId(System.Decimal? _crsSchdHodApprvUsrId, int start, int pageLength,out int count)
		{
			return GetByCrsSchdHodApprvUsrId(null, _crsSchdHodApprvUsrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER key.
		///		FK_ED_OFFERING_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdHodApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public abstract TList<EdOffering> GetByCrsSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdHodApprvUsrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		FK_ED_OFFERING_SE_USER1 Description: 
		/// </summary>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdHodApprvUsrId(System.Decimal? _exmSchdHodApprvUsrId)
		{
			int count = -1;
			return GetByExmSchdHodApprvUsrId(_exmSchdHodApprvUsrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		FK_ED_OFFERING_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		/// <remarks></remarks>
		public TList<EdOffering> GetByExmSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdHodApprvUsrId)
		{
			int count = -1;
			return GetByExmSchdHodApprvUsrId(transactionManager, _exmSchdHodApprvUsrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		FK_ED_OFFERING_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdHodApprvUsrId, int start, int pageLength)
		{
			int count = -1;
			return GetByExmSchdHodApprvUsrId(transactionManager, _exmSchdHodApprvUsrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		fkEdOfferingSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdHodApprvUsrId(System.Decimal? _exmSchdHodApprvUsrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByExmSchdHodApprvUsrId(null, _exmSchdHodApprvUsrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		fkEdOfferingSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdHodApprvUsrId(System.Decimal? _exmSchdHodApprvUsrId, int start, int pageLength,out int count)
		{
			return GetByExmSchdHodApprvUsrId(null, _exmSchdHodApprvUsrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER1 key.
		///		FK_ED_OFFERING_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdHodApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public abstract TList<EdOffering> GetByExmSchdHodApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdHodApprvUsrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		FK_ED_OFFERING_SE_USER2 Description: 
		/// </summary>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdDeanApprvUsrId(System.Decimal? _crsSchdDeanApprvUsrId)
		{
			int count = -1;
			return GetByCrsSchdDeanApprvUsrId(_crsSchdDeanApprvUsrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		FK_ED_OFFERING_SE_USER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		/// <remarks></remarks>
		public TList<EdOffering> GetByCrsSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdDeanApprvUsrId)
		{
			int count = -1;
			return GetByCrsSchdDeanApprvUsrId(transactionManager, _crsSchdDeanApprvUsrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		FK_ED_OFFERING_SE_USER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdDeanApprvUsrId, int start, int pageLength)
		{
			int count = -1;
			return GetByCrsSchdDeanApprvUsrId(transactionManager, _crsSchdDeanApprvUsrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		fkEdOfferingSeUser2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdDeanApprvUsrId(System.Decimal? _crsSchdDeanApprvUsrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCrsSchdDeanApprvUsrId(null, _crsSchdDeanApprvUsrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		fkEdOfferingSeUser2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByCrsSchdDeanApprvUsrId(System.Decimal? _crsSchdDeanApprvUsrId, int start, int pageLength,out int count)
		{
			return GetByCrsSchdDeanApprvUsrId(null, _crsSchdDeanApprvUsrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER2 key.
		///		FK_ED_OFFERING_SE_USER2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_crsSchdDeanApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public abstract TList<EdOffering> GetByCrsSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _crsSchdDeanApprvUsrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		FK_ED_OFFERING_SE_USER3 Description: 
		/// </summary>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdDeanApprvUsrId(System.Decimal? _exmSchdDeanApprvUsrId)
		{
			int count = -1;
			return GetByExmSchdDeanApprvUsrId(_exmSchdDeanApprvUsrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		FK_ED_OFFERING_SE_USER3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		/// <remarks></remarks>
		public TList<EdOffering> GetByExmSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdDeanApprvUsrId)
		{
			int count = -1;
			return GetByExmSchdDeanApprvUsrId(transactionManager, _exmSchdDeanApprvUsrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		FK_ED_OFFERING_SE_USER3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdDeanApprvUsrId, int start, int pageLength)
		{
			int count = -1;
			return GetByExmSchdDeanApprvUsrId(transactionManager, _exmSchdDeanApprvUsrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		fkEdOfferingSeUser3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdDeanApprvUsrId(System.Decimal? _exmSchdDeanApprvUsrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByExmSchdDeanApprvUsrId(null, _exmSchdDeanApprvUsrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		fkEdOfferingSeUser3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public TList<EdOffering> GetByExmSchdDeanApprvUsrId(System.Decimal? _exmSchdDeanApprvUsrId, int start, int pageLength,out int count)
		{
			return GetByExmSchdDeanApprvUsrId(null, _exmSchdDeanApprvUsrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_SE_USER3 key.
		///		FK_ED_OFFERING_SE_USER3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_exmSchdDeanApprvUsrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOffering objects.</returns>
		public abstract TList<EdOffering> GetByExmSchdDeanApprvUsrId(TransactionManager transactionManager, System.Decimal? _exmSchdDeanApprvUsrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdOffering Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingKey key, int start, int pageLength)
		{
			return GetByEdOfferingId(transactionManager, key.EdOfferingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public abstract TList<EdOffering> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public abstract TList<EdOffering> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public abstract TList<EdOffering> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEntMainId(System.Decimal? _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public TList<EdOffering> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOffering&gt;"/> class.</returns>
		public abstract TList<EdOffering> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(System.Decimal _edOfferingId)
		{
			int count = -1;
			return GetByEdOfferingId(null,_edOfferingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(System.Decimal _edOfferingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingId(null, _edOfferingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(TransactionManager transactionManager, System.Decimal _edOfferingId)
		{
			int count = -1;
			return GetByEdOfferingId(transactionManager, _edOfferingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(TransactionManager transactionManager, System.Decimal _edOfferingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingId(transactionManager, _edOfferingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(System.Decimal _edOfferingId, int start, int pageLength, out int count)
		{
			return GetByEdOfferingId(null, _edOfferingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOffering GetByEdOfferingId(TransactionManager transactionManager, System.Decimal _edOfferingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(null,_edAcadYearId, _edCodeSemesterId, _entMainId, _asCodeDegreeClassId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(null, _edAcadYearId, _edCodeSemesterId, _entMainId, _asCodeDegreeClassId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(transactionManager, _edAcadYearId, _edCodeSemesterId, _entMainId, _asCodeDegreeClassId, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(transactionManager, _edAcadYearId, _edCodeSemesterId, _entMainId, _asCodeDegreeClassId, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(null, _edAcadYearId, _edCodeSemesterId, _entMainId, _asCodeDegreeClassId, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOffering GetByEdAcadYearIdEdCodeSemesterIdEntMainIdAsCodeDegreeClassIdAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Decimal? _entMainId, System.Decimal _asCodeDegreeClassId, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdOffering&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdOffering&gt;"/></returns>
		public static TList<EdOffering> Fill(IDataReader reader, TList<EdOffering> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdOffering c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdOffering")
					.Append("|").Append((System.Decimal)reader["ED_OFFERING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdOffering>(
					key.ToString(), // EntityTrackingKey
					"EdOffering",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdOffering();
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
					c.EdOfferingId = (System.Decimal)reader["ED_OFFERING_ID"];
					c.OriginalEdOfferingId = c.EdOfferingId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.IsApproved = (System.Decimal)reader["IS_APPROVED"];
					c.IsExamApproved = (System.Decimal)reader["IS_EXAM_APPROVED"];
					c.CrsSchdHodApprvDt = Convert.IsDBNull(reader["CRS_SCHD_HOD_APPRV_DT"]) ? null : (System.DateTime?)reader["CRS_SCHD_HOD_APPRV_DT"];
					c.CrsSchdHodApprvUsrId = Convert.IsDBNull(reader["CRS_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["CRS_SCHD_HOD_APPRV_USR_ID"];
					c.ExmSchdHodApproveDt = Convert.IsDBNull(reader["EXM_SCHD_HOD_APPROVE_DT"]) ? null : (System.DateTime?)reader["EXM_SCHD_HOD_APPROVE_DT"];
					c.ExmSchdHodApprvUsrId = Convert.IsDBNull(reader["EXM_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["EXM_SCHD_HOD_APPRV_USR_ID"];
					c.CrsSchdDeanApprvDt = Convert.IsDBNull(reader["CRS_SCHD_DEAN_APPRV_DT"]) ? null : (System.DateTime?)reader["CRS_SCHD_DEAN_APPRV_DT"];
					c.CrsSchdDeanApprvUsrId = Convert.IsDBNull(reader["CRS_SCHD_DEAN_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["CRS_SCHD_DEAN_APPRV_USR_ID"];
					c.ExmSchdDeanApprvDt = Convert.IsDBNull(reader["EXM_SCHD_DEAN_APPRV_DT"]) ? null : (System.DateTime?)reader["EXM_SCHD_DEAN_APPRV_DT"];
					c.ExmSchdDeanApprvUsrId = Convert.IsDBNull(reader["EXM_SCHD_DEAN_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["EXM_SCHD_DEAN_APPRV_USR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdOffering entity)
		{
			if (!reader.Read()) return;
			
			entity.EdOfferingId = (System.Decimal)reader[((int)EdOfferingColumn.EdOfferingId - 1)];
			entity.OriginalEdOfferingId = (System.Decimal)reader["ED_OFFERING_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdOfferingColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.AsFacultyInfoId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdOfferingColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.EdCodeSemesterId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdOfferingColumn.EdAcadYearId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EdOfferingColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.EntMainId - 1)];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)EdOfferingColumn.AsCodeDegreeClassId - 1)];
			entity.IsApproved = (System.Decimal)reader[((int)EdOfferingColumn.IsApproved - 1)];
			entity.IsExamApproved = (System.Decimal)reader[((int)EdOfferingColumn.IsExamApproved - 1)];
			entity.CrsSchdHodApprvDt = (reader.IsDBNull(((int)EdOfferingColumn.CrsSchdHodApprvDt - 1)))?null:(System.DateTime?)reader[((int)EdOfferingColumn.CrsSchdHodApprvDt - 1)];
			entity.CrsSchdHodApprvUsrId = (reader.IsDBNull(((int)EdOfferingColumn.CrsSchdHodApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.CrsSchdHodApprvUsrId - 1)];
			entity.ExmSchdHodApproveDt = (reader.IsDBNull(((int)EdOfferingColumn.ExmSchdHodApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdOfferingColumn.ExmSchdHodApproveDt - 1)];
			entity.ExmSchdHodApprvUsrId = (reader.IsDBNull(((int)EdOfferingColumn.ExmSchdHodApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.ExmSchdHodApprvUsrId - 1)];
			entity.CrsSchdDeanApprvDt = (reader.IsDBNull(((int)EdOfferingColumn.CrsSchdDeanApprvDt - 1)))?null:(System.DateTime?)reader[((int)EdOfferingColumn.CrsSchdDeanApprvDt - 1)];
			entity.CrsSchdDeanApprvUsrId = (reader.IsDBNull(((int)EdOfferingColumn.CrsSchdDeanApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.CrsSchdDeanApprvUsrId - 1)];
			entity.ExmSchdDeanApprvDt = (reader.IsDBNull(((int)EdOfferingColumn.ExmSchdDeanApprvDt - 1)))?null:(System.DateTime?)reader[((int)EdOfferingColumn.ExmSchdDeanApprvDt - 1)];
			entity.ExmSchdDeanApprvUsrId = (reader.IsDBNull(((int)EdOfferingColumn.ExmSchdDeanApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingColumn.ExmSchdDeanApprvUsrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdOffering entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdOfferingId = (System.Decimal)dataRow["ED_OFFERING_ID"];
			entity.OriginalEdOfferingId = (System.Decimal)dataRow["ED_OFFERING_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.IsApproved = (System.Decimal)dataRow["IS_APPROVED"];
			entity.IsExamApproved = (System.Decimal)dataRow["IS_EXAM_APPROVED"];
			entity.CrsSchdHodApprvDt = Convert.IsDBNull(dataRow["CRS_SCHD_HOD_APPRV_DT"]) ? null : (System.DateTime?)dataRow["CRS_SCHD_HOD_APPRV_DT"];
			entity.CrsSchdHodApprvUsrId = Convert.IsDBNull(dataRow["CRS_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["CRS_SCHD_HOD_APPRV_USR_ID"];
			entity.ExmSchdHodApproveDt = Convert.IsDBNull(dataRow["EXM_SCHD_HOD_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["EXM_SCHD_HOD_APPROVE_DT"];
			entity.ExmSchdHodApprvUsrId = Convert.IsDBNull(dataRow["EXM_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["EXM_SCHD_HOD_APPRV_USR_ID"];
			entity.CrsSchdDeanApprvDt = Convert.IsDBNull(dataRow["CRS_SCHD_DEAN_APPRV_DT"]) ? null : (System.DateTime?)dataRow["CRS_SCHD_DEAN_APPRV_DT"];
			entity.CrsSchdDeanApprvUsrId = Convert.IsDBNull(dataRow["CRS_SCHD_DEAN_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["CRS_SCHD_DEAN_APPRV_USR_ID"];
			entity.ExmSchdDeanApprvDt = Convert.IsDBNull(dataRow["EXM_SCHD_DEAN_APPRV_DT"]) ? null : (System.DateTime?)dataRow["EXM_SCHD_DEAN_APPRV_DT"];
			entity.ExmSchdDeanApprvUsrId = Convert.IsDBNull(dataRow["EXM_SCHD_DEAN_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["EXM_SCHD_DEAN_APPRV_USR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOffering"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOffering Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOffering entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeClassId;
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);		
				
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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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

			#region CrsSchdHodApprvUsrIdSource	
			if (CanDeepLoad(entity, "SeUser|CrsSchdHodApprvUsrIdSource", deepLoadType, innerList) 
				&& entity.CrsSchdHodApprvUsrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CrsSchdHodApprvUsrId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CrsSchdHodApprvUsrIdSource = tmpEntity;
				else
					entity.CrsSchdHodApprvUsrIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.CrsSchdHodApprvUsrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CrsSchdHodApprvUsrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CrsSchdHodApprvUsrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.CrsSchdHodApprvUsrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CrsSchdHodApprvUsrIdSource

			#region ExmSchdHodApprvUsrIdSource	
			if (CanDeepLoad(entity, "SeUser|ExmSchdHodApprvUsrIdSource", deepLoadType, innerList) 
				&& entity.ExmSchdHodApprvUsrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ExmSchdHodApprvUsrId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ExmSchdHodApprvUsrIdSource = tmpEntity;
				else
					entity.ExmSchdHodApprvUsrIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.ExmSchdHodApprvUsrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ExmSchdHodApprvUsrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ExmSchdHodApprvUsrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.ExmSchdHodApprvUsrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ExmSchdHodApprvUsrIdSource

			#region CrsSchdDeanApprvUsrIdSource	
			if (CanDeepLoad(entity, "SeUser|CrsSchdDeanApprvUsrIdSource", deepLoadType, innerList) 
				&& entity.CrsSchdDeanApprvUsrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CrsSchdDeanApprvUsrId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CrsSchdDeanApprvUsrIdSource = tmpEntity;
				else
					entity.CrsSchdDeanApprvUsrIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.CrsSchdDeanApprvUsrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CrsSchdDeanApprvUsrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CrsSchdDeanApprvUsrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.CrsSchdDeanApprvUsrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CrsSchdDeanApprvUsrIdSource

			#region ExmSchdDeanApprvUsrIdSource	
			if (CanDeepLoad(entity, "SeUser|ExmSchdDeanApprvUsrIdSource", deepLoadType, innerList) 
				&& entity.ExmSchdDeanApprvUsrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ExmSchdDeanApprvUsrId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ExmSchdDeanApprvUsrIdSource = tmpEntity;
				else
					entity.ExmSchdDeanApprvUsrIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.ExmSchdDeanApprvUsrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ExmSchdDeanApprvUsrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ExmSchdDeanApprvUsrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.ExmSchdDeanApprvUsrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ExmSchdDeanApprvUsrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdOfferingId methods when available
			
			#region EdOfferingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetByEdOfferingId(transactionManager, entity.EdOfferingId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdOffering object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdOffering instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOffering Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOffering entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region CrsSchdHodApprvUsrIdSource
			if (CanDeepSave(entity, "SeUser|CrsSchdHodApprvUsrIdSource", deepSaveType, innerList) 
				&& entity.CrsSchdHodApprvUsrIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.CrsSchdHodApprvUsrIdSource);
				entity.CrsSchdHodApprvUsrId = entity.CrsSchdHodApprvUsrIdSource.SeUserId;
			}
			#endregion 
			
			#region ExmSchdHodApprvUsrIdSource
			if (CanDeepSave(entity, "SeUser|ExmSchdHodApprvUsrIdSource", deepSaveType, innerList) 
				&& entity.ExmSchdHodApprvUsrIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.ExmSchdHodApprvUsrIdSource);
				entity.ExmSchdHodApprvUsrId = entity.ExmSchdHodApprvUsrIdSource.SeUserId;
			}
			#endregion 
			
			#region CrsSchdDeanApprvUsrIdSource
			if (CanDeepSave(entity, "SeUser|CrsSchdDeanApprvUsrIdSource", deepSaveType, innerList) 
				&& entity.CrsSchdDeanApprvUsrIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.CrsSchdDeanApprvUsrIdSource);
				entity.CrsSchdDeanApprvUsrId = entity.CrsSchdDeanApprvUsrIdSource.SeUserId;
			}
			#endregion 
			
			#region ExmSchdDeanApprvUsrIdSource
			if (CanDeepSave(entity, "SeUser|ExmSchdDeanApprvUsrIdSource", deepSaveType, innerList) 
				&& entity.ExmSchdDeanApprvUsrIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.ExmSchdDeanApprvUsrIdSource);
				entity.ExmSchdDeanApprvUsrId = entity.ExmSchdDeanApprvUsrIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdOfferingCourse>
				if (CanDeepSave(entity.EdOfferingCourseCollection, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOfferingCourse child in entity.EdOfferingCourseCollection)
					{
						if(child.EdOfferingIdSource != null)
						{
							child.EdOfferingId = child.EdOfferingIdSource.EdOfferingId;
						}
						else
						{
							child.EdOfferingId = entity.EdOfferingId;
						}

					}

					if (entity.EdOfferingCourseCollection.Count > 0 || entity.EdOfferingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseCollection);
						
						deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOfferingCourse >) DataRepository.EdOfferingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdOfferingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdOffering</c>
	///</summary>
	public enum EdOfferingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
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
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at CrsSchdHodApprvUsrIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdOffering</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
	}
	
	#endregion EdOfferingChildEntityTypes
	
	#region EdOfferingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdOfferingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOffering"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOfferingFilterBuilder : SqlFilterBuilder<EdOfferingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingFilterBuilder class.
		/// </summary>
		public EdOfferingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOfferingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOfferingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOfferingFilterBuilder
	
	#region EdOfferingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdOfferingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOffering"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOfferingParameterBuilder : ParameterizedSqlFilterBuilder<EdOfferingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingParameterBuilder class.
		/// </summary>
		public EdOfferingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOfferingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOfferingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOfferingParameterBuilder
	
	#region EdOfferingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdOfferingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOffering"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdOfferingSortBuilder : SqlSortBuilder<EdOfferingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingSqlSortBuilder class.
		/// </summary>
		public EdOfferingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdOfferingSortBuilder
	
} // end namespace
