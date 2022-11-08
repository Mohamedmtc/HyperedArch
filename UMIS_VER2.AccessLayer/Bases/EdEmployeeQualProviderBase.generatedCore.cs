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
	/// This class is the base class for any <see cref="EdEmployeeQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdEmployeeQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdEmployeeQual, UMIS_VER2.BusinessLyer.EdEmployeeQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdEmployeeQualKey key)
		{
			return Delete(transactionManager, key.EdEmployeeQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edEmployeeQualId)
		{
			return Delete(null, _edEmployeeQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edEmployeeQualId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL Description: 
		/// </summary>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(_edCdeEmpQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdEmployeeQual> GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(transactionManager, _edCdeEmpQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeEmpQualId(transactionManager, _edCdeEmpQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		fkEdEmployeeQualEdCdeEmpQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeEmpQualId(null, _edCdeEmpQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		fkEdEmployeeQualEdCdeEmpQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByEdCdeEmpQualId(System.Decimal _edCdeEmpQualId, int start, int pageLength,out int count)
		{
			return GetByEdCdeEmpQualId(null, _edCdeEmpQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL key.
		///		FK_ED_EMPLOYEE_QUAL_ED_CDE_EMP_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeEmpQualId">مسلسل المؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public abstract TList<EdEmployeeQual> GetByEdCdeEmpQualId(TransactionManager transactionManager, System.Decimal _edCdeEmpQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdEmployeeQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		fkEdEmployeeQualGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		fkEdEmployeeQualGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE key.
		///		FK_ED_EMPLOYEE_QUAL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">مسلسل الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public abstract TList<EdEmployeeQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdEmployeeQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		fkEdEmployeeQualSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		fkEdEmployeeQualSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public TList<EdEmployeeQual> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER key.
		///		FK_ED_EMPLOYEE_QUAL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdEmployeeQual objects.</returns>
		public abstract TList<EdEmployeeQual> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdEmployeeQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdEmployeeQualKey key, int start, int pageLength)
		{
			return GetByEdEmployeeQualId(transactionManager, key.EdEmployeeQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(System.Decimal _edEmployeeQualId)
		{
			int count = -1;
			return GetByEdEmployeeQualId(null,_edEmployeeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(System.Decimal _edEmployeeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdEmployeeQualId(null, _edEmployeeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(TransactionManager transactionManager, System.Decimal _edEmployeeQualId)
		{
			int count = -1;
			return GetByEdEmployeeQualId(transactionManager, _edEmployeeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(TransactionManager transactionManager, System.Decimal _edEmployeeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdEmployeeQualId(transactionManager, _edEmployeeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(System.Decimal _edEmployeeQualId, int start, int pageLength, out int count)
		{
			return GetByEdEmployeeQualId(null, _edEmployeeQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EMPLOYEE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEmployeeQualId">مؤهلات الموظف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdEmployeeQual GetByEdEmployeeQualId(TransactionManager transactionManager, System.Decimal _edEmployeeQualId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdEmployeeQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdEmployeeQual&gt;"/></returns>
		public static TList<EdEmployeeQual> Fill(IDataReader reader, TList<EdEmployeeQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdEmployeeQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdEmployeeQual")
					.Append("|").Append((System.Decimal)reader["ED_EMPLOYEE_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdEmployeeQual>(
					key.ToString(), // EntityTrackingKey
					"EdEmployeeQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdEmployeeQual();
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
					c.EdEmployeeQualId = (System.Decimal)reader["ED_EMPLOYEE_QUAL_ID"];
					c.OriginalEdEmployeeQualId = c.EdEmployeeQualId;
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.EdCdeEmpQualId = (System.Decimal)reader["ED_CDE_EMP_QUAL_ID"];
					c.QualYear = Convert.IsDBNull(reader["QUAL_YEAR"]) ? null : (System.Decimal?)reader["QUAL_YEAR"];
					c.EmpFlg = Convert.IsDBNull(reader["EMP_FLG"]) ? null : (System.Boolean?)reader["EMP_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdEmployeeQual entity)
		{
			if (!reader.Read()) return;
			
			entity.EdEmployeeQualId = (System.Decimal)reader[((int)EdEmployeeQualColumn.EdEmployeeQualId - 1)];
			entity.OriginalEdEmployeeQualId = (System.Decimal)reader["ED_EMPLOYEE_QUAL_ID"];
			entity.SaStfMemberId = (System.Decimal)reader[((int)EdEmployeeQualColumn.SaStfMemberId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)EdEmployeeQualColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)EdEmployeeQualColumn.GsCountryNodeId - 1)];
			entity.EdCdeEmpQualId = (System.Decimal)reader[((int)EdEmployeeQualColumn.EdCdeEmpQualId - 1)];
			entity.QualYear = (reader.IsDBNull(((int)EdEmployeeQualColumn.QualYear - 1)))?null:(System.Decimal?)reader[((int)EdEmployeeQualColumn.QualYear - 1)];
			entity.EmpFlg = (reader.IsDBNull(((int)EdEmployeeQualColumn.EmpFlg - 1)))?null:(System.Boolean?)reader[((int)EdEmployeeQualColumn.EmpFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdEmployeeQualColumn.Notes - 1)))?null:(System.String)reader[((int)EdEmployeeQualColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdEmployeeQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdEmployeeQualId = (System.Decimal)dataRow["ED_EMPLOYEE_QUAL_ID"];
			entity.OriginalEdEmployeeQualId = (System.Decimal)dataRow["ED_EMPLOYEE_QUAL_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.EdCdeEmpQualId = (System.Decimal)dataRow["ED_CDE_EMP_QUAL_ID"];
			entity.QualYear = Convert.IsDBNull(dataRow["QUAL_YEAR"]) ? null : (System.Decimal?)dataRow["QUAL_YEAR"];
			entity.EmpFlg = Convert.IsDBNull(dataRow["EMP_FLG"]) ? null : (System.Boolean?)dataRow["EMP_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdEmployeeQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdEmployeeQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdEmployeeQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeEmpQualIdSource	
			if (CanDeepLoad(entity, "EdCdeEmpQual|EdCdeEmpQualIdSource", deepLoadType, innerList) 
				&& entity.EdCdeEmpQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeEmpQualId;
				EdCdeEmpQual tmpEntity = EntityManager.LocateEntity<EdCdeEmpQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeEmpQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeEmpQualIdSource = tmpEntity;
				else
					entity.EdCdeEmpQualIdSource = DataRepository.EdCdeEmpQualProvider.GetByEdCdeEmpQualId(transactionManager, entity.EdCdeEmpQualId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeEmpQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeEmpQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeEmpQualProvider.DeepLoad(transactionManager, entity.EdCdeEmpQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeEmpQualIdSource

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdEmployeeQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdEmployeeQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdEmployeeQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdEmployeeQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeEmpQualIdSource
			if (CanDeepSave(entity, "EdCdeEmpQual|EdCdeEmpQualIdSource", deepSaveType, innerList) 
				&& entity.EdCdeEmpQualIdSource != null)
			{
				DataRepository.EdCdeEmpQualProvider.Save(transactionManager, entity.EdCdeEmpQualIdSource);
				entity.EdCdeEmpQualId = entity.EdCdeEmpQualIdSource.EdCdeEmpQualId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region EdEmployeeQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdEmployeeQual</c>
	///</summary>
	public enum EdEmployeeQualChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeEmpQual</c> at EdCdeEmpQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeEmpQual))]
		EdCdeEmpQual,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdEmployeeQualChildEntityTypes
	
	#region EdEmployeeQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdEmployeeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdEmployeeQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdEmployeeQualFilterBuilder : SqlFilterBuilder<EdEmployeeQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualFilterBuilder class.
		/// </summary>
		public EdEmployeeQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdEmployeeQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdEmployeeQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdEmployeeQualFilterBuilder
	
	#region EdEmployeeQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdEmployeeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdEmployeeQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdEmployeeQualParameterBuilder : ParameterizedSqlFilterBuilder<EdEmployeeQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualParameterBuilder class.
		/// </summary>
		public EdEmployeeQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdEmployeeQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdEmployeeQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdEmployeeQualParameterBuilder
	
	#region EdEmployeeQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdEmployeeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdEmployeeQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdEmployeeQualSortBuilder : SqlSortBuilder<EdEmployeeQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdEmployeeQualSqlSortBuilder class.
		/// </summary>
		public EdEmployeeQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdEmployeeQualSortBuilder
	
} // end namespace
