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
	/// This class is the base class for any <see cref="SvSrvyRespondAnswrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvSrvyRespondAnswrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswrKey key)
		{
			return Delete(transactionManager, key.SvSrvyRespondAnswrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svSrvyRespondAnswrId)
		{
			return Delete(null, _svSrvyRespondAnswrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svSrvyRespondAnswrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR Description: 
		/// </summary>
		/// <param name="_svSrvyAnswrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(_svSrvyAnswrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(transactionManager, _svSrvyAnswrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(transactionManager, _svSrvyAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		fkSvSrvyRespondAnswrSvSrvyAnswr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyAnswrId(null, _svSrvyAnswrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		fkSvSrvyRespondAnswrSvSrvyAnswr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyAnswrId(null, _svSrvyAnswrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_ANSWR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public abstract TList<SvSrvyRespondAnswr> GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN Description: 
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(_svSrvyRespondQstnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(transactionManager, _svSrvyRespondQstnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(transactionManager, _svSrvyRespondQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		fkSvSrvyRespondAnswrSvSrvyRespondQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyRespondQstnId(null, _svSrvyRespondQstnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		fkSvSrvyRespondAnswrSvSrvyRespondQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyRespondQstnId(null, _svSrvyRespondQstnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN key.
		///		FK_SV_SRVY_RESPOND_ANSWR_SV_SRVY_RESPOND_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr objects.</returns>
		public abstract TList<SvSrvyRespondAnswr> GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswrKey key, int start, int pageLength)
		{
			return GetBySvSrvyRespondAnswrId(transactionManager, key.SvSrvyRespondAnswrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(System.Decimal _svSrvyRespondAnswrId)
		{
			int count = -1;
			return GetBySvSrvyRespondAnswrId(null,_svSrvyRespondAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(System.Decimal _svSrvyRespondAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondAnswrId(null, _svSrvyRespondAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondAnswrId)
		{
			int count = -1;
			return GetBySvSrvyRespondAnswrId(transactionManager, _svSrvyRespondAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondAnswrId(transactionManager, _svSrvyRespondAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(System.Decimal _svSrvyRespondAnswrId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyRespondAnswrId(null, _svSrvyRespondAnswrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondAnswrId">qstn may have  1 answr or multiple</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondAnswrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnIdSvSrvyAnswrId(null,_svSrvyRespondQstnId, _svSrvyAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnIdSvSrvyAnswrId(null, _svSrvyRespondQstnId, _svSrvyAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnIdSvSrvyAnswrId(transactionManager, _svSrvyRespondQstnId, _svSrvyAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnIdSvSrvyAnswrId(transactionManager, _svSrvyRespondQstnId, _svSrvyAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyRespondQstnIdSvSrvyAnswrId(null, _svSrvyRespondQstnId, _svSrvyAnswrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_RESPOND_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr GetBySvSrvyRespondQstnIdSvSrvyAnswrId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, System.Int32 _svSrvyAnswrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvSrvyRespondAnswr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvSrvyRespondAnswr&gt;"/></returns>
		public static TList<SvSrvyRespondAnswr> Fill(IDataReader reader, TList<SvSrvyRespondAnswr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvSrvyRespondAnswr")
					.Append("|").Append((System.Decimal)reader["SV_SRVY_RESPOND_ANSWR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvSrvyRespondAnswr>(
					key.ToString(), // EntityTrackingKey
					"SvSrvyRespondAnswr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr();
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
					c.SvSrvyRespondAnswrId = (System.Decimal)reader["SV_SRVY_RESPOND_ANSWR_ID"];
					c.OriginalSvSrvyRespondAnswrId = c.SvSrvyRespondAnswrId;
					c.SvSrvyRespondQstnId = (System.Decimal)reader["SV_SRVY_RESPOND_QSTN_ID"];
					c.SvSrvyAnswrId = (System.Int32)reader["SV_SRVY_ANSWR_ID"];
					c.AnswrTxt = Convert.IsDBNull(reader["ANSWR_TXT"]) ? null : (System.String)reader["ANSWR_TXT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr entity)
		{
			if (!reader.Read()) return;
			
			entity.SvSrvyRespondAnswrId = (System.Decimal)reader[((int)SvSrvyRespondAnswrColumn.SvSrvyRespondAnswrId - 1)];
			entity.OriginalSvSrvyRespondAnswrId = (System.Decimal)reader["SV_SRVY_RESPOND_ANSWR_ID"];
			entity.SvSrvyRespondQstnId = (System.Decimal)reader[((int)SvSrvyRespondAnswrColumn.SvSrvyRespondQstnId - 1)];
			entity.SvSrvyAnswrId = (System.Int32)reader[((int)SvSrvyRespondAnswrColumn.SvSrvyAnswrId - 1)];
			entity.AnswrTxt = (reader.IsDBNull(((int)SvSrvyRespondAnswrColumn.AnswrTxt - 1)))?null:(System.String)reader[((int)SvSrvyRespondAnswrColumn.AnswrTxt - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvSrvyRespondAnswrId = (System.Decimal)dataRow["SV_SRVY_RESPOND_ANSWR_ID"];
			entity.OriginalSvSrvyRespondAnswrId = (System.Decimal)dataRow["SV_SRVY_RESPOND_ANSWR_ID"];
			entity.SvSrvyRespondQstnId = (System.Decimal)dataRow["SV_SRVY_RESPOND_QSTN_ID"];
			entity.SvSrvyAnswrId = (System.Int32)dataRow["SV_SRVY_ANSWR_ID"];
			entity.AnswrTxt = Convert.IsDBNull(dataRow["ANSWR_TXT"]) ? null : (System.String)dataRow["ANSWR_TXT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvSrvyAnswrIdSource	
			if (CanDeepLoad(entity, "SvSrvyAnswr|SvSrvyAnswrIdSource", deepLoadType, innerList) 
				&& entity.SvSrvyAnswrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvSrvyAnswrId;
				SvSrvyAnswr tmpEntity = EntityManager.LocateEntity<SvSrvyAnswr>(EntityLocator.ConstructKeyFromPkItems(typeof(SvSrvyAnswr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvSrvyAnswrIdSource = tmpEntity;
				else
					entity.SvSrvyAnswrIdSource = DataRepository.SvSrvyAnswrProvider.GetBySvSrvyAnswrId(transactionManager, entity.SvSrvyAnswrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyAnswrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvSrvyAnswrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvSrvyAnswrProvider.DeepLoad(transactionManager, entity.SvSrvyAnswrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvSrvyAnswrIdSource

			#region SvSrvyRespondQstnIdSource	
			if (CanDeepLoad(entity, "SvSrvyRespondQstn|SvSrvyRespondQstnIdSource", deepLoadType, innerList) 
				&& entity.SvSrvyRespondQstnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvSrvyRespondQstnId;
				SvSrvyRespondQstn tmpEntity = EntityManager.LocateEntity<SvSrvyRespondQstn>(EntityLocator.ConstructKeyFromPkItems(typeof(SvSrvyRespondQstn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvSrvyRespondQstnIdSource = tmpEntity;
				else
					entity.SvSrvyRespondQstnIdSource = DataRepository.SvSrvyRespondQstnProvider.GetBySvSrvyRespondQstnId(transactionManager, entity.SvSrvyRespondQstnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondQstnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvSrvyRespondQstnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvSrvyRespondQstnProvider.DeepLoad(transactionManager, entity.SvSrvyRespondQstnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvSrvyRespondQstnIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvSrvyAnswrIdSource
			if (CanDeepSave(entity, "SvSrvyAnswr|SvSrvyAnswrIdSource", deepSaveType, innerList) 
				&& entity.SvSrvyAnswrIdSource != null)
			{
				DataRepository.SvSrvyAnswrProvider.Save(transactionManager, entity.SvSrvyAnswrIdSource);
				entity.SvSrvyAnswrId = entity.SvSrvyAnswrIdSource.SvSrvyAnswrId;
			}
			#endregion 
			
			#region SvSrvyRespondQstnIdSource
			if (CanDeepSave(entity, "SvSrvyRespondQstn|SvSrvyRespondQstnIdSource", deepSaveType, innerList) 
				&& entity.SvSrvyRespondQstnIdSource != null)
			{
				DataRepository.SvSrvyRespondQstnProvider.Save(transactionManager, entity.SvSrvyRespondQstnIdSource);
				entity.SvSrvyRespondQstnId = entity.SvSrvyRespondQstnIdSource.SvSrvyRespondQstnId;
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
	
	#region SvSrvyRespondAnswrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvSrvyRespondAnswr</c>
	///</summary>
	public enum SvSrvyRespondAnswrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvSrvyAnswr</c> at SvSrvyAnswrIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyAnswr))]
		SvSrvyAnswr,
		
		///<summary>
		/// Composite Property for <c>SvSrvyRespondQstn</c> at SvSrvyRespondQstnIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyRespondQstn))]
		SvSrvyRespondQstn,
	}
	
	#endregion SvSrvyRespondAnswrChildEntityTypes
	
	#region SvSrvyRespondAnswrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvSrvyRespondAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondAnswr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyRespondAnswrFilterBuilder : SqlFilterBuilder<SvSrvyRespondAnswrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrFilterBuilder class.
		/// </summary>
		public SvSrvyRespondAnswrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyRespondAnswrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyRespondAnswrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyRespondAnswrFilterBuilder
	
	#region SvSrvyRespondAnswrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvSrvyRespondAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondAnswr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyRespondAnswrParameterBuilder : ParameterizedSqlFilterBuilder<SvSrvyRespondAnswrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrParameterBuilder class.
		/// </summary>
		public SvSrvyRespondAnswrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyRespondAnswrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyRespondAnswrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyRespondAnswrParameterBuilder
	
	#region SvSrvyRespondAnswrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvSrvyRespondAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondAnswr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvSrvyRespondAnswrSortBuilder : SqlSortBuilder<SvSrvyRespondAnswrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondAnswrSqlSortBuilder class.
		/// </summary>
		public SvSrvyRespondAnswrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvSrvyRespondAnswrSortBuilder
	
} // end namespace
