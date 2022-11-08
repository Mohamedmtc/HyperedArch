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
	/// This class is the base class for any <see cref="SvSrvyAnswrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvSrvyAnswrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvSrvyAnswr, UMIS_VER2.BusinessLyer.SvSrvyAnswrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyAnswrKey key)
		{
			return Delete(transactionManager, key.SvSrvyAnswrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svSrvyAnswrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svSrvyAnswrId)
		{
			return Delete(null, _svSrvyAnswrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_ANSWR_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		public TList<SvSrvyAnswr> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(_svSrvyQstnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_ANSWR_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyAnswr> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_ANSWR_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		public TList<SvSrvyAnswr> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		fkSvSrvyAnswrSvSrvyQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		public TList<SvSrvyAnswr> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		fkSvSrvyAnswrSvSrvyQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		public TList<SvSrvyAnswr> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_ANSWR_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_ANSWR_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyAnswr objects.</returns>
		public abstract TList<SvSrvyAnswr> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvSrvyAnswr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyAnswrKey key, int start, int pageLength)
		{
			return GetBySvSrvyAnswrId(transactionManager, key.SvSrvyAnswrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyAnswrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(null,_svSrvyAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(null, _svSrvyAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(transactionManager, _svSrvyAnswrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyAnswrId(transactionManager, _svSrvyAnswrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(System.Int32 _svSrvyAnswrId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyAnswrId(null, _svSrvyAnswrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_ANSWR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyAnswrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyAnswrId(TransactionManager transactionManager, System.Int32 _svSrvyAnswrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(System.Int32 _svSrvyQstnId, System.String _answrAr)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrAr(null,_svSrvyQstnId, _answrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(System.Int32 _svSrvyQstnId, System.String _answrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrAr(null, _svSrvyQstnId, _answrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrAr)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrAr(transactionManager, _svSrvyQstnId, _answrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrAr(transactionManager, _svSrvyQstnId, _answrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(System.Int32 _svSrvyQstnId, System.String _answrAr, int start, int pageLength, out int count)
		{
			return GetBySvSrvyQstnIdAnswrAr(null, _svSrvyQstnId, _answrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrAr(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(System.Int32 _svSrvyQstnId, System.String _answrEn)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrEn(null,_svSrvyQstnId, _answrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(System.Int32 _svSrvyQstnId, System.String _answrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrEn(null, _svSrvyQstnId, _answrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrEn)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrEn(transactionManager, _svSrvyQstnId, _answrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnIdAnswrEn(transactionManager, _svSrvyQstnId, _answrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(System.Int32 _svSrvyQstnId, System.String _answrEn, int start, int pageLength, out int count)
		{
			return GetBySvSrvyQstnIdAnswrEn(null, _svSrvyQstnId, _answrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_SRVY_ANSWR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="_answrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyAnswr GetBySvSrvyQstnIdAnswrEn(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, System.String _answrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvSrvyAnswr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvSrvyAnswr&gt;"/></returns>
		public static TList<SvSrvyAnswr> Fill(IDataReader reader, TList<SvSrvyAnswr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvSrvyAnswr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvSrvyAnswr")
					.Append("|").Append((System.Int32)reader["SV_SRVY_ANSWR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvSrvyAnswr>(
					key.ToString(), // EntityTrackingKey
					"SvSrvyAnswr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvSrvyAnswr();
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
					c.SvSrvyAnswrId = (System.Int32)reader["SV_SRVY_ANSWR_ID"];
					c.OriginalSvSrvyAnswrId = c.SvSrvyAnswrId;
					c.SvSrvyQstnId = (System.Int32)reader["SV_SRVY_QSTN_ID"];
					c.AnswrAr = (System.String)reader["ANSWR_AR"];
					c.AnswrEn = (System.String)reader["ANSWR_EN"];
					c.AnsrTxtFlg = (System.Boolean)reader["ANSR_TXT_FLG"];
					c.AnswrOrdr = (System.Int32)reader["ANSWR_ORDR"];
					c.AnswrImg = Convert.IsDBNull(reader["ANSWR_IMG"]) ? null : (System.String)reader["ANSWR_IMG"];
					c.CorrectFlg = (System.Boolean)reader["CORRECT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvSrvyAnswr entity)
		{
			if (!reader.Read()) return;
			
			entity.SvSrvyAnswrId = (System.Int32)reader[((int)SvSrvyAnswrColumn.SvSrvyAnswrId - 1)];
			entity.OriginalSvSrvyAnswrId = (System.Int32)reader["SV_SRVY_ANSWR_ID"];
			entity.SvSrvyQstnId = (System.Int32)reader[((int)SvSrvyAnswrColumn.SvSrvyQstnId - 1)];
			entity.AnswrAr = (System.String)reader[((int)SvSrvyAnswrColumn.AnswrAr - 1)];
			entity.AnswrEn = (System.String)reader[((int)SvSrvyAnswrColumn.AnswrEn - 1)];
			entity.AnsrTxtFlg = (System.Boolean)reader[((int)SvSrvyAnswrColumn.AnsrTxtFlg - 1)];
			entity.AnswrOrdr = (System.Int32)reader[((int)SvSrvyAnswrColumn.AnswrOrdr - 1)];
			entity.AnswrImg = (reader.IsDBNull(((int)SvSrvyAnswrColumn.AnswrImg - 1)))?null:(System.String)reader[((int)SvSrvyAnswrColumn.AnswrImg - 1)];
			entity.CorrectFlg = (System.Boolean)reader[((int)SvSrvyAnswrColumn.CorrectFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvSrvyAnswr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvSrvyAnswrId = (System.Int32)dataRow["SV_SRVY_ANSWR_ID"];
			entity.OriginalSvSrvyAnswrId = (System.Int32)dataRow["SV_SRVY_ANSWR_ID"];
			entity.SvSrvyQstnId = (System.Int32)dataRow["SV_SRVY_QSTN_ID"];
			entity.AnswrAr = (System.String)dataRow["ANSWR_AR"];
			entity.AnswrEn = (System.String)dataRow["ANSWR_EN"];
			entity.AnsrTxtFlg = (System.Boolean)dataRow["ANSR_TXT_FLG"];
			entity.AnswrOrdr = (System.Int32)dataRow["ANSWR_ORDR"];
			entity.AnswrImg = Convert.IsDBNull(dataRow["ANSWR_IMG"]) ? null : (System.String)dataRow["ANSWR_IMG"];
			entity.CorrectFlg = (System.Boolean)dataRow["CORRECT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyAnswr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyAnswr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyAnswr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvSrvyQstnIdSource	
			if (CanDeepLoad(entity, "SvSrvyQstn|SvSrvyQstnIdSource", deepLoadType, innerList) 
				&& entity.SvSrvyQstnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvSrvyQstnId;
				SvSrvyQstn tmpEntity = EntityManager.LocateEntity<SvSrvyQstn>(EntityLocator.ConstructKeyFromPkItems(typeof(SvSrvyQstn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvSrvyQstnIdSource = tmpEntity;
				else
					entity.SvSrvyQstnIdSource = DataRepository.SvSrvyQstnProvider.GetBySvSrvyQstnId(transactionManager, entity.SvSrvyQstnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyQstnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvSrvyQstnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvSrvyQstnProvider.DeepLoad(transactionManager, entity.SvSrvyQstnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvSrvyQstnIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvSrvyAnswrId methods when available
			
			#region SvSrvyRespondAnswrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyRespondAnswr>|SvSrvyRespondAnswrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondAnswrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyRespondAnswrCollection = DataRepository.SvSrvyRespondAnswrProvider.GetBySvSrvyAnswrId(transactionManager, entity.SvSrvyAnswrId);

				if (deep && entity.SvSrvyRespondAnswrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyRespondAnswrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyRespondAnswr>) DataRepository.SvSrvyRespondAnswrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyRespondAnswrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvSrvyAnswr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvSrvyAnswr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyAnswr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyAnswr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvSrvyQstnIdSource
			if (CanDeepSave(entity, "SvSrvyQstn|SvSrvyQstnIdSource", deepSaveType, innerList) 
				&& entity.SvSrvyQstnIdSource != null)
			{
				DataRepository.SvSrvyQstnProvider.Save(transactionManager, entity.SvSrvyQstnIdSource);
				entity.SvSrvyQstnId = entity.SvSrvyQstnIdSource.SvSrvyQstnId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvSrvyRespondAnswr>
				if (CanDeepSave(entity.SvSrvyRespondAnswrCollection, "List<SvSrvyRespondAnswr>|SvSrvyRespondAnswrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyRespondAnswr child in entity.SvSrvyRespondAnswrCollection)
					{
						if(child.SvSrvyAnswrIdSource != null)
						{
							child.SvSrvyAnswrId = child.SvSrvyAnswrIdSource.SvSrvyAnswrId;
						}
						else
						{
							child.SvSrvyAnswrId = entity.SvSrvyAnswrId;
						}

					}

					if (entity.SvSrvyRespondAnswrCollection.Count > 0 || entity.SvSrvyRespondAnswrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyRespondAnswrProvider.Save(transactionManager, entity.SvSrvyRespondAnswrCollection);
						
						deepHandles.Add("SvSrvyRespondAnswrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyRespondAnswr >) DataRepository.SvSrvyRespondAnswrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyRespondAnswrCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvSrvyAnswrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvSrvyAnswr</c>
	///</summary>
	public enum SvSrvyAnswrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvSrvyQstn</c> at SvSrvyQstnIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyQstn))]
		SvSrvyQstn,
		///<summary>
		/// Collection of <c>SvSrvyAnswr</c> as OneToMany for SvSrvyRespondAnswrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyRespondAnswr>))]
		SvSrvyRespondAnswrCollection,
	}
	
	#endregion SvSrvyAnswrChildEntityTypes
	
	#region SvSrvyAnswrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvSrvyAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyAnswr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyAnswrFilterBuilder : SqlFilterBuilder<SvSrvyAnswrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrFilterBuilder class.
		/// </summary>
		public SvSrvyAnswrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyAnswrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyAnswrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyAnswrFilterBuilder
	
	#region SvSrvyAnswrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvSrvyAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyAnswr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyAnswrParameterBuilder : ParameterizedSqlFilterBuilder<SvSrvyAnswrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrParameterBuilder class.
		/// </summary>
		public SvSrvyAnswrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyAnswrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyAnswrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyAnswrParameterBuilder
	
	#region SvSrvyAnswrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvSrvyAnswrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyAnswr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvSrvyAnswrSortBuilder : SqlSortBuilder<SvSrvyAnswrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyAnswrSqlSortBuilder class.
		/// </summary>
		public SvSrvyAnswrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvSrvyAnswrSortBuilder
	
} // end namespace
