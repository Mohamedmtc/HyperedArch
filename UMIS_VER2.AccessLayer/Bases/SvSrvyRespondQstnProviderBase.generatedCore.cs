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
	/// This class is the base class for any <see cref="SvSrvyRespondQstnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvSrvyRespondQstnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvSrvyRespondQstn, UMIS_VER2.BusinessLyer.SvSrvyRespondQstnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondQstnKey key)
		{
			return Delete(transactionManager, key.SvSrvyRespondQstnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svSrvyRespondQstnId)
		{
			return Delete(null, _svSrvyRespondQstnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyRespondQstn> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		fkSvSrvyRespondQstnAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		fkSvSrvyRespondQstnAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT key.
		///		FK_SV_SRVY_RESPOND_QSTN_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public abstract TList<SvSrvyRespondQstn> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		FK_SV_SRVY_RESPOND_QSTN_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		FK_SV_SRVY_RESPOND_QSTN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyRespondQstn> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		FK_SV_SRVY_RESPOND_QSTN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		fkSvSrvyRespondQstnEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		fkSvSrvyRespondQstnEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_ED_STUD key.
		///		FK_SV_SRVY_RESPOND_QSTN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public abstract TList<SvSrvyRespondQstn> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="_svSrvyQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(_svSrvyQstnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		/// <remarks></remarks>
		public TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyQstnId(transactionManager, _svSrvyQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		fkSvSrvyRespondQstnSvSrvyQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		fkSvSrvyRespondQstnSvSrvyQstn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(System.Int32 _svSrvyQstnId, int start, int pageLength,out int count)
		{
			return GetBySvSrvyQstnId(null, _svSrvyQstnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN key.
		///		FK_SV_SRVY_RESPOND_QSTN_SV_SRVY_QSTN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvSrvyRespondQstn objects.</returns>
		public abstract TList<SvSrvyRespondQstn> GetBySvSrvyQstnId(TransactionManager transactionManager, System.Int32 _svSrvyQstnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvSrvyRespondQstn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondQstnKey key, int start, int pageLength)
		{
			return GetBySvSrvyRespondQstnId(transactionManager, key.SvSrvyRespondQstnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(null,_svSrvyRespondQstnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(null, _svSrvyRespondQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(transactionManager, _svSrvyRespondQstnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvSrvyRespondQstnId(transactionManager, _svSrvyRespondQstnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(System.Decimal _svSrvyRespondQstnId, int start, int pageLength, out int count)
		{
			return GetBySvSrvyRespondQstnId(null, _svSrvyRespondQstnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_SRVY_RESPOND_QSTN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svSrvyRespondQstnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvSrvyRespondQstn GetBySvSrvyRespondQstnId(TransactionManager transactionManager, System.Decimal _svSrvyRespondQstnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvSrvyRespondQstn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvSrvyRespondQstn&gt;"/></returns>
		public static TList<SvSrvyRespondQstn> Fill(IDataReader reader, TList<SvSrvyRespondQstn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvSrvyRespondQstn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvSrvyRespondQstn")
					.Append("|").Append((System.Decimal)reader["SV_SRVY_RESPOND_QSTN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvSrvyRespondQstn>(
					key.ToString(), // EntityTrackingKey
					"SvSrvyRespondQstn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvSrvyRespondQstn();
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
					c.SvSrvyRespondQstnId = (System.Decimal)reader["SV_SRVY_RESPOND_QSTN_ID"];
					c.OriginalSvSrvyRespondQstnId = c.SvSrvyRespondQstnId;
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.SvSrvyQstnId = (System.Int32)reader["SV_SRVY_QSTN_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = (System.DateTime)reader["LAST_DATE"];
					c.AnswrMark = Convert.IsDBNull(reader["ANSWR_MARK"]) ? null : (System.Decimal?)reader["ANSWR_MARK"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvSrvyRespondQstn entity)
		{
			if (!reader.Read()) return;
			
			entity.SvSrvyRespondQstnId = (System.Decimal)reader[((int)SvSrvyRespondQstnColumn.SvSrvyRespondQstnId - 1)];
			entity.OriginalSvSrvyRespondQstnId = (System.Decimal)reader["SV_SRVY_RESPOND_QSTN_ID"];
			entity.AdmApplicantId = (reader.IsDBNull(((int)SvSrvyRespondQstnColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)SvSrvyRespondQstnColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)SvSrvyRespondQstnColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SvSrvyRespondQstnColumn.EdStudId - 1)];
			entity.SvSrvyQstnId = (System.Int32)reader[((int)SvSrvyRespondQstnColumn.SvSrvyQstnId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SvSrvyRespondQstnColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SvSrvyRespondQstnColumn.SeUserId - 1)];
			entity.LastDate = (System.DateTime)reader[((int)SvSrvyRespondQstnColumn.LastDate - 1)];
			entity.AnswrMark = (reader.IsDBNull(((int)SvSrvyRespondQstnColumn.AnswrMark - 1)))?null:(System.Decimal?)reader[((int)SvSrvyRespondQstnColumn.AnswrMark - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvSrvyRespondQstn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvSrvyRespondQstnId = (System.Decimal)dataRow["SV_SRVY_RESPOND_QSTN_ID"];
			entity.OriginalSvSrvyRespondQstnId = (System.Decimal)dataRow["SV_SRVY_RESPOND_QSTN_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.SvSrvyQstnId = (System.Int32)dataRow["SV_SRVY_QSTN_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = (System.DateTime)dataRow["LAST_DATE"];
			entity.AnswrMark = Convert.IsDBNull(dataRow["ANSWR_MARK"]) ? null : (System.Decimal?)dataRow["ANSWR_MARK"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvSrvyRespondQstn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyRespondQstn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondQstn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmApplicantId ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.AdmApplicantId ?? 0.0m));		
				
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetBySvSrvyRespondQstnId methods when available
			
			#region SvSrvyRespondAnswrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyRespondAnswr>|SvSrvyRespondAnswrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondAnswrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyRespondAnswrCollection = DataRepository.SvSrvyRespondAnswrProvider.GetBySvSrvyRespondQstnId(transactionManager, entity.SvSrvyRespondQstnId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvSrvyRespondQstn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvSrvyRespondQstn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvSrvyRespondQstn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvSrvyRespondQstn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
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
						if(child.SvSrvyRespondQstnIdSource != null)
						{
							child.SvSrvyRespondQstnId = child.SvSrvyRespondQstnIdSource.SvSrvyRespondQstnId;
						}
						else
						{
							child.SvSrvyRespondQstnId = entity.SvSrvyRespondQstnId;
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
	
	#region SvSrvyRespondQstnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvSrvyRespondQstn</c>
	///</summary>
	public enum SvSrvyRespondQstnChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SvSrvyQstn</c> at SvSrvyQstnIdSource
		///</summary>
		[ChildEntityType(typeof(SvSrvyQstn))]
		SvSrvyQstn,
		///<summary>
		/// Collection of <c>SvSrvyRespondQstn</c> as OneToMany for SvSrvyRespondAnswrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyRespondAnswr>))]
		SvSrvyRespondAnswrCollection,
	}
	
	#endregion SvSrvyRespondQstnChildEntityTypes
	
	#region SvSrvyRespondQstnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvSrvyRespondQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondQstn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyRespondQstnFilterBuilder : SqlFilterBuilder<SvSrvyRespondQstnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnFilterBuilder class.
		/// </summary>
		public SvSrvyRespondQstnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyRespondQstnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyRespondQstnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyRespondQstnFilterBuilder
	
	#region SvSrvyRespondQstnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvSrvyRespondQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondQstn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvSrvyRespondQstnParameterBuilder : ParameterizedSqlFilterBuilder<SvSrvyRespondQstnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnParameterBuilder class.
		/// </summary>
		public SvSrvyRespondQstnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvSrvyRespondQstnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvSrvyRespondQstnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvSrvyRespondQstnParameterBuilder
	
	#region SvSrvyRespondQstnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvSrvyRespondQstnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvSrvyRespondQstn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvSrvyRespondQstnSortBuilder : SqlSortBuilder<SvSrvyRespondQstnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvSrvyRespondQstnSqlSortBuilder class.
		/// </summary>
		public SvSrvyRespondQstnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvSrvyRespondQstnSortBuilder
	
} // end namespace
