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
	/// This class is the base class for any <see cref="AdmTansikCodesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTansikCodesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmTansikCodes, UMIS_VER2.BusinessLyer.AdmTansikCodesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikCodesKey key)
		{
			return Delete(transactionManager, key.AdmTansikCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admTansikCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admTansikCodesId)
		{
			return Delete(null, _admTansikCodesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admTansikCodesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikCodes> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		fkAdmTansikCodesAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		fkAdmTansikCodesAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public abstract TList<AdmTansikCodes> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikCodes> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		fkAdmTansikCodesAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		fkAdmTansikCodesAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_Tansik_Codes_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public abstract TList<AdmTansikCodes> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		FK_ADM_Tansik_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		FK_ADM_Tansik_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTansikCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		FK_ADM_Tansik_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		fkAdmTansikCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		fkAdmTansikCodesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public TList<AdmTansikCodes> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_Tansik_Codes_SE_USER key.
		///		FK_ADM_Tansik_Codes_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTansikCodes objects.</returns>
		public abstract TList<AdmTansikCodes> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmTansikCodes Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikCodesKey key, int start, int pageLength)
		{
			return GetByAdmTansikCodesId(transactionManager, key.AdmTansikCodesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="_admTansikCodesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(null,_admTansikCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTansikCodesId(transactionManager, _admTansikCodesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(System.Decimal _admTansikCodesId, int start, int pageLength, out int count)
		{
			return GetByAdmTansikCodesId(null, _admTansikCodesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_Tansik_Codes index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTansikCodesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmTansikCodes GetByAdmTansikCodesId(TransactionManager transactionManager, System.Decimal _admTansikCodesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmTansikCodes&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmTansikCodes&gt;"/></returns>
		public static TList<AdmTansikCodes> Fill(IDataReader reader, TList<AdmTansikCodes> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmTansikCodes c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmTansikCodes")
					.Append("|").Append((System.Decimal)reader["ADM_Tansik_Codes_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmTansikCodes>(
					key.ToString(), // EntityTrackingKey
					"AdmTansikCodes",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmTansikCodes();
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
					c.AdmTansikCodesId = (System.Decimal)reader["ADM_Tansik_Codes_ID"];
					c.OriginalAdmTansikCodesId = c.AdmTansikCodesId;
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_Ar"]) ? null : (System.String)reader["DESCR_Ar"];
					c.IsActive = Convert.IsDBNull(reader["IS_Active"]) ? null : (System.Boolean?)reader["IS_Active"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["Last_Date"]) ? null : (System.DateTime?)reader["Last_Date"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmTansikCodes entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTansikCodesId = (System.Decimal)reader[((int)AdmTansikCodesColumn.AdmTansikCodesId - 1)];
			entity.OriginalAdmTansikCodesId = (System.Decimal)reader["ADM_Tansik_Codes_ID"];
			entity.DescrEn = (reader.IsDBNull(((int)AdmTansikCodesColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmTansikCodesColumn.DescrEn - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)AdmTansikCodesColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmTansikCodesColumn.DescrAr - 1)];
			entity.IsActive = (reader.IsDBNull(((int)AdmTansikCodesColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)AdmTansikCodesColumn.IsActive - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmTansikCodesColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmTansikCodesColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmTansikCodesColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmTansikCodesColumn.AsCodeDegreeId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)AdmTansikCodesColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmTansikCodesColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmTansikCodesColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmTansikCodes entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTansikCodesId = (System.Decimal)dataRow["ADM_Tansik_Codes_ID"];
			entity.OriginalAdmTansikCodesId = (System.Decimal)dataRow["ADM_Tansik_Codes_ID"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_Ar"]) ? null : (System.String)dataRow["DESCR_Ar"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_Active"]) ? null : (System.Boolean?)dataRow["IS_Active"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["Last_Date"]) ? null : (System.DateTime?)dataRow["Last_Date"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTansikCodes"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikCodes Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikCodes entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmTansikCodesId methods when available
			
			#region AdmTansikMajorsCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikMajorsCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikMajorsCodesCollection = DataRepository.AdmTansikMajorsCodesProvider.GetByAdmTansikCodesId(transactionManager, entity.AdmTansikCodesId);

				if (deep && entity.AdmTansikMajorsCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikMajorsCodes>) DataRepository.AdmTansikMajorsCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikAppCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikAppCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikAppCodesCollection = DataRepository.AdmTansikAppCodesProvider.GetByAdmTansikCodesId(transactionManager, entity.AdmTansikCodesId);

				if (deep && entity.AdmTansikAppCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikAppCodes>) DataRepository.AdmTansikAppCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmTansikCodes object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmTansikCodes instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTansikCodes Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTansikCodes entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmTansikMajorsCodes>
				if (CanDeepSave(entity.AdmTansikMajorsCodesCollection, "List<AdmTansikMajorsCodes>|AdmTansikMajorsCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikMajorsCodes child in entity.AdmTansikMajorsCodesCollection)
					{
						if(child.AdmTansikCodesIdSource != null)
						{
							child.AdmTansikCodesId = child.AdmTansikCodesIdSource.AdmTansikCodesId;
						}
						else
						{
							child.AdmTansikCodesId = entity.AdmTansikCodesId;
						}

					}

					if (entity.AdmTansikMajorsCodesCollection.Count > 0 || entity.AdmTansikMajorsCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikMajorsCodesProvider.Save(transactionManager, entity.AdmTansikMajorsCodesCollection);
						
						deepHandles.Add("AdmTansikMajorsCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikMajorsCodes >) DataRepository.AdmTansikMajorsCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikMajorsCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikAppCodes>
				if (CanDeepSave(entity.AdmTansikAppCodesCollection, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikAppCodes child in entity.AdmTansikAppCodesCollection)
					{
						if(child.AdmTansikCodesIdSource != null)
						{
							child.AdmTansikCodesId = child.AdmTansikCodesIdSource.AdmTansikCodesId;
						}
						else
						{
							child.AdmTansikCodesId = entity.AdmTansikCodesId;
						}

					}

					if (entity.AdmTansikAppCodesCollection.Count > 0 || entity.AdmTansikAppCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikAppCodesProvider.Save(transactionManager, entity.AdmTansikAppCodesCollection);
						
						deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikAppCodes >) DataRepository.AdmTansikAppCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmTansikCodesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmTansikCodes</c>
	///</summary>
	public enum AdmTansikCodesChildEntityTypes
	{
		
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
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>AdmTansikCodes</c> as OneToMany for AdmTansikMajorsCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikMajorsCodes>))]
		AdmTansikMajorsCodesCollection,
		///<summary>
		/// Collection of <c>AdmTansikCodes</c> as OneToMany for AdmTansikAppCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikAppCodes>))]
		AdmTansikAppCodesCollection,
	}
	
	#endregion AdmTansikCodesChildEntityTypes
	
	#region AdmTansikCodesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmTansikCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikCodesFilterBuilder : SqlFilterBuilder<AdmTansikCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesFilterBuilder class.
		/// </summary>
		public AdmTansikCodesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikCodesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikCodesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikCodesFilterBuilder
	
	#region AdmTansikCodesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmTansikCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTansikCodesParameterBuilder : ParameterizedSqlFilterBuilder<AdmTansikCodesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesParameterBuilder class.
		/// </summary>
		public AdmTansikCodesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTansikCodesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTansikCodesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTansikCodesParameterBuilder
	
	#region AdmTansikCodesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmTansikCodesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTansikCodes"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmTansikCodesSortBuilder : SqlSortBuilder<AdmTansikCodesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTansikCodesSqlSortBuilder class.
		/// </summary>
		public AdmTansikCodesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmTansikCodesSortBuilder
	
} // end namespace
