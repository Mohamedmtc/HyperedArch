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
	/// This class is the base class for any <see cref="EntMainMatrixProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntMainMatrixProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntMainMatrix, UMIS_VER2.BusinessLyer.EntMainMatrixKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMainMatrixKey key)
		{
			return Delete(transactionManager, key.EntMainMatrixId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entMainMatrixId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entMainMatrixId)
		{
			return Delete(null, _entMainMatrixId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entMainMatrixId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainMajorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMajorId(System.Decimal _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(_entMainMajorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		/// <remarks></remarks>
		public TList<EntMainMatrix> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal _entMainMajorId)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal _entMainMajorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMajorId(transactionManager, _entMainMajorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		fkEntMainMatrixEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMajorId(System.Decimal _entMainMajorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		fkEntMainMatrixEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMajorId(System.Decimal _entMainMajorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMajorId(null, _entMainMajorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMajorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public abstract TList<EntMainMatrix> GetByEntMainMajorId(TransactionManager transactionManager, System.Decimal _entMainMajorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainMinorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMinorId(System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(_entMainMinorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		/// <remarks></remarks>
		public TList<EntMainMatrix> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMinorId(transactionManager, _entMainMinorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		fkEntMainMatrixEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		fkEntMainMatrixEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMinorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainMinorId(System.Decimal? _entMainMinorId, int start, int pageLength,out int count)
		{
			return GetByEntMainMinorId(null, _entMainMinorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMinorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public abstract TList<EntMainMatrix> GetByEntMainMinorId(TransactionManager transactionManager, System.Decimal? _entMainMinorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		/// <remarks></remarks>
		public TList<EntMainMatrix> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		fkEntMainMatrixEntityMain2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		fkEntMainMatrixEntityMain2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public abstract TList<EntMainMatrix> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 Description: 
		/// </summary>
		/// <param name="_entMainSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainSpecId(System.Decimal? _entMainSpecId)
		{
			int count = -1;
			return GetByEntMainSpecId(_entMainSpecId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpecId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		/// <remarks></remarks>
		public TList<EntMainMatrix> GetByEntMainSpecId(TransactionManager transactionManager, System.Decimal? _entMainSpecId)
		{
			int count = -1;
			return GetByEntMainSpecId(transactionManager, _entMainSpecId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainSpecId(TransactionManager transactionManager, System.Decimal? _entMainSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainSpecId(transactionManager, _entMainSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		fkEntMainMatrixEntityMain4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpecId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainSpecId(System.Decimal? _entMainSpecId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainSpecId(null, _entMainSpecId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		fkEntMainMatrixEntityMain4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpecId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public TList<EntMainMatrix> GetByEntMainSpecId(System.Decimal? _entMainSpecId, int start, int pageLength,out int count)
		{
			return GetByEntMainSpecId(null, _entMainSpecId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 key.
		///		FK_ENT_MAIN_MATRIX_ENTITY_MAIN4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpecId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMainMatrix objects.</returns>
		public abstract TList<EntMainMatrix> GetByEntMainSpecId(TransactionManager transactionManager, System.Decimal? _entMainSpecId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntMainMatrix Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMainMatrixKey key, int start, int pageLength)
		{
			return GetByEntMainMatrixId(transactionManager, key.EntMainMatrixId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="_entMainMatrixId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(System.Decimal _entMainMatrixId)
		{
			int count = -1;
			return GetByEntMainMatrixId(null,_entMainMatrixId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(System.Decimal _entMainMatrixId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMatrixId(null, _entMainMatrixId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal _entMainMatrixId)
		{
			int count = -1;
			return GetByEntMainMatrixId(transactionManager, _entMainMatrixId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal _entMainMatrixId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMatrixId(transactionManager, _entMainMatrixId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(System.Decimal _entMainMatrixId, int start, int pageLength, out int count)
		{
			return GetByEntMainMatrixId(null, _entMainMatrixId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAIN_MATRIX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMatrixId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntMainMatrix GetByEntMainMatrixId(TransactionManager transactionManager, System.Decimal _entMainMatrixId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntMainMatrix&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntMainMatrix&gt;"/></returns>
		public static TList<EntMainMatrix> Fill(IDataReader reader, TList<EntMainMatrix> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntMainMatrix c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntMainMatrix")
					.Append("|").Append((System.Decimal)reader["ENT_MAIN_MATRIX_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntMainMatrix>(
					key.ToString(), // EntityTrackingKey
					"EntMainMatrix",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntMainMatrix();
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
					c.EntMainMatrixId = (System.Decimal)reader["ENT_MAIN_MATRIX_ID"];
					c.OriginalEntMainMatrixId = c.EntMainMatrixId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EntMainMajorId = (System.Decimal)reader["ENT_MAIN_MAJOR_ID"];
					c.EntMainMinorId = Convert.IsDBNull(reader["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MINOR_ID"];
					c.EntMainSpecId = Convert.IsDBNull(reader["ENT_MAIN_SPEC_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_SPEC_ID"];
					c.GrntdDegAr = Convert.IsDBNull(reader["GRNTD_DEG_AR"]) ? null : (System.String)reader["GRNTD_DEG_AR"];
					c.GrntdDegEn = Convert.IsDBNull(reader["GRNTD_DEG_EN"]) ? null : (System.String)reader["GRNTD_DEG_EN"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntMainMatrix entity)
		{
			if (!reader.Read()) return;
			
			entity.EntMainMatrixId = (System.Decimal)reader[((int)EntMainMatrixColumn.EntMainMatrixId - 1)];
			entity.OriginalEntMainMatrixId = (System.Decimal)reader["ENT_MAIN_MATRIX_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EntMainMatrixColumn.EntMainId - 1)];
			entity.EntMainMajorId = (System.Decimal)reader[((int)EntMainMatrixColumn.EntMainMajorId - 1)];
			entity.EntMainMinorId = (reader.IsDBNull(((int)EntMainMatrixColumn.EntMainMinorId - 1)))?null:(System.Decimal?)reader[((int)EntMainMatrixColumn.EntMainMinorId - 1)];
			entity.EntMainSpecId = (reader.IsDBNull(((int)EntMainMatrixColumn.EntMainSpecId - 1)))?null:(System.Decimal?)reader[((int)EntMainMatrixColumn.EntMainSpecId - 1)];
			entity.GrntdDegAr = (reader.IsDBNull(((int)EntMainMatrixColumn.GrntdDegAr - 1)))?null:(System.String)reader[((int)EntMainMatrixColumn.GrntdDegAr - 1)];
			entity.GrntdDegEn = (reader.IsDBNull(((int)EntMainMatrixColumn.GrntdDegEn - 1)))?null:(System.String)reader[((int)EntMainMatrixColumn.GrntdDegEn - 1)];
			entity.IsActive = (System.Decimal)reader[((int)EntMainMatrixColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntMainMatrix entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMainMatrixId = (System.Decimal)dataRow["ENT_MAIN_MATRIX_ID"];
			entity.OriginalEntMainMatrixId = (System.Decimal)dataRow["ENT_MAIN_MATRIX_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EntMainMajorId = (System.Decimal)dataRow["ENT_MAIN_MAJOR_ID"];
			entity.EntMainMinorId = Convert.IsDBNull(dataRow["ENT_MAIN_MINOR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MINOR_ID"];
			entity.EntMainSpecId = Convert.IsDBNull(dataRow["ENT_MAIN_SPEC_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_SPEC_ID"];
			entity.GrntdDegAr = Convert.IsDBNull(dataRow["GRNTD_DEG_AR"]) ? null : (System.String)dataRow["GRNTD_DEG_AR"];
			entity.GrntdDegEn = Convert.IsDBNull(dataRow["GRNTD_DEG_EN"]) ? null : (System.String)dataRow["GRNTD_DEG_EN"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMainMatrix"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMainMatrix Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMainMatrix entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntMainMajorIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMajorIdSource", deepLoadType, innerList) 
				&& entity.EntMainMajorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainMajorId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMajorIdSource = tmpEntity;
				else
					entity.EntMainMajorIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainMajorId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMajorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMajorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMajorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMajorIdSource

			#region EntMainMinorIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMinorIdSource", deepLoadType, innerList) 
				&& entity.EntMainMinorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMinorId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMinorIdSource = tmpEntity;
				else
					entity.EntMainMinorIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainMinorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMinorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMinorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMinorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMinorIdSource

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

			#region EntMainSpecIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainSpecIdSource", deepLoadType, innerList) 
				&& entity.EntMainSpecIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainSpecId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainSpecIdSource = tmpEntity;
				else
					entity.EntMainSpecIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainSpecId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainSpecIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainSpecIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainSpecIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainSpecIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntMainMatrixId methods when available
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEntMainMatrixId(transactionManager, entity.EntMainMatrixId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntMainMatrix object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntMainMatrix instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMainMatrix Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMainMatrix entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntMainMajorIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMajorIdSource", deepSaveType, innerList) 
				&& entity.EntMainMajorIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMajorIdSource);
				entity.EntMainMajorId = entity.EntMainMajorIdSource.EntMainId;
			}
			#endregion 
			
			#region EntMainMinorIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMinorIdSource", deepSaveType, innerList) 
				&& entity.EntMainMinorIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMinorIdSource);
				entity.EntMainMinorId = entity.EntMainMinorIdSource.EntMainId;
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
			
			#region EntMainSpecIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainSpecIdSource", deepSaveType, innerList) 
				&& entity.EntMainSpecIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainSpecIdSource);
				entity.EntMainSpecId = entity.EntMainSpecIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EntMainMatrixIdSource != null)
						{
							child.EntMainMatrixId = child.EntMainMatrixIdSource.EntMainMatrixId;
						}
						else
						{
							child.EntMainMatrixId = entity.EntMainMatrixId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntMainMatrixChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntMainMatrix</c>
	///</summary>
	public enum EntMainMatrixChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainMajorIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EntMainMatrix</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
	}
	
	#endregion EntMainMatrixChildEntityTypes
	
	#region EntMainMatrixFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntMainMatrixColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMainMatrix"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMainMatrixFilterBuilder : SqlFilterBuilder<EntMainMatrixColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixFilterBuilder class.
		/// </summary>
		public EntMainMatrixFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMainMatrixFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMainMatrixFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMainMatrixFilterBuilder
	
	#region EntMainMatrixParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntMainMatrixColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMainMatrix"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMainMatrixParameterBuilder : ParameterizedSqlFilterBuilder<EntMainMatrixColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixParameterBuilder class.
		/// </summary>
		public EntMainMatrixParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMainMatrixParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMainMatrixParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMainMatrixParameterBuilder
	
	#region EntMainMatrixSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntMainMatrixColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMainMatrix"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntMainMatrixSortBuilder : SqlSortBuilder<EntMainMatrixColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMainMatrixSqlSortBuilder class.
		/// </summary>
		public EntMainMatrixSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntMainMatrixSortBuilder
	
} // end namespace
