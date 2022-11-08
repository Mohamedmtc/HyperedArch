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
	/// This class is the base class for any <see cref="EdProjSupervisorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdProjSupervisorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdProjSupervisor, UMIS_VER2.BusinessLyer.EdProjSupervisorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProjSupervisorKey key)
		{
			return Delete(transactionManager, key.EdProjSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edProjSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edProjSupervisorId)
		{
			return Delete(null, _edProjSupervisorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjSupervisorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edProjSupervisorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		FK_ED_PROJ_SUP_ED_COURSE_PROJECT Description: 
		/// </summary>
		/// <param name="_edProjectId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetByEdProjectId(System.Decimal _edProjectId)
		{
			int count = -1;
			return GetByEdProjectId(_edProjectId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		FK_ED_PROJ_SUP_ED_COURSE_PROJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<EdProjSupervisor> GetByEdProjectId(TransactionManager transactionManager, System.Decimal _edProjectId)
		{
			int count = -1;
			return GetByEdProjectId(transactionManager, _edProjectId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		FK_ED_PROJ_SUP_ED_COURSE_PROJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetByEdProjectId(TransactionManager transactionManager, System.Decimal _edProjectId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdProjectId(transactionManager, _edProjectId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		fkEdProjSupEdCourseProject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edProjectId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetByEdProjectId(System.Decimal _edProjectId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdProjectId(null, _edProjectId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		fkEdProjSupEdCourseProject Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edProjectId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetByEdProjectId(System.Decimal _edProjectId, int start, int pageLength,out int count)
		{
			return GetByEdProjectId(null, _edProjectId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_ED_COURSE_PROJECT key.
		///		FK_ED_PROJ_SUP_ED_COURSE_PROJECT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public abstract TList<EdProjSupervisor> GetByEdProjectId(TransactionManager transactionManager, System.Decimal _edProjectId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		FK_ED_PROJ_SUP_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		FK_ED_PROJ_SUP_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		/// <remarks></remarks>
		public TList<EdProjSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		FK_ED_PROJ_SUP_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		fkEdProjSupSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		fkEdProjSupSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public TList<EdProjSupervisor> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_PROJ_SUP_SA_STF_MEMBER key.
		///		FK_ED_PROJ_SUP_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdProjSupervisor objects.</returns>
		public abstract TList<EdProjSupervisor> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdProjSupervisor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProjSupervisorKey key, int start, int pageLength)
		{
			return GetByEdProjSupervisorId(transactionManager, key.EdProjSupervisorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(System.Decimal _edProjectId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByEdProjectIdSaStfMemberId(null,_edProjectId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(System.Decimal _edProjectId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdProjectIdSaStfMemberId(null, _edProjectId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edProjectId, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetByEdProjectIdSaStfMemberId(transactionManager, _edProjectId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edProjectId, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdProjectIdSaStfMemberId(transactionManager, _edProjectId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(System.Decimal _edProjectId, System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetByEdProjectIdSaStfMemberId(null, _edProjectId, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_PROJ_SUPERVISOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjectId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjectIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _edProjectId, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="_edProjSupervisorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(System.Decimal _edProjSupervisorId)
		{
			int count = -1;
			return GetByEdProjSupervisorId(null,_edProjSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="_edProjSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(System.Decimal _edProjSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdProjSupervisorId(null, _edProjSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjSupervisorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(TransactionManager transactionManager, System.Decimal _edProjSupervisorId)
		{
			int count = -1;
			return GetByEdProjSupervisorId(transactionManager, _edProjSupervisorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(TransactionManager transactionManager, System.Decimal _edProjSupervisorId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdProjSupervisorId(transactionManager, _edProjSupervisorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="_edProjSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(System.Decimal _edProjSupervisorId, int start, int pageLength, out int count)
		{
			return GetByEdProjSupervisorId(null, _edProjSupervisorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_PROJ_SUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edProjSupervisorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdProjSupervisor GetByEdProjSupervisorId(TransactionManager transactionManager, System.Decimal _edProjSupervisorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdProjSupervisor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdProjSupervisor&gt;"/></returns>
		public static TList<EdProjSupervisor> Fill(IDataReader reader, TList<EdProjSupervisor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdProjSupervisor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdProjSupervisor")
					.Append("|").Append((System.Decimal)reader["ED_PROJ_SUPERVISOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdProjSupervisor>(
					key.ToString(), // EntityTrackingKey
					"EdProjSupervisor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdProjSupervisor();
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
					c.EdProjSupervisorId = (System.Decimal)reader["ED_PROJ_SUPERVISOR_ID"];
					c.OriginalEdProjSupervisorId = c.EdProjSupervisorId;
					c.EdProjectId = (System.Decimal)reader["ED_PROJECT_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SupTypeFlg = (System.Decimal)reader["SUP_TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdProjSupervisor entity)
		{
			if (!reader.Read()) return;
			
			entity.EdProjSupervisorId = (System.Decimal)reader[((int)EdProjSupervisorColumn.EdProjSupervisorId - 1)];
			entity.OriginalEdProjSupervisorId = (System.Decimal)reader["ED_PROJ_SUPERVISOR_ID"];
			entity.EdProjectId = (System.Decimal)reader[((int)EdProjSupervisorColumn.EdProjectId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)EdProjSupervisorColumn.SaStfMemberId - 1)];
			entity.SupTypeFlg = (System.Decimal)reader[((int)EdProjSupervisorColumn.SupTypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdProjSupervisor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdProjSupervisorId = (System.Decimal)dataRow["ED_PROJ_SUPERVISOR_ID"];
			entity.OriginalEdProjSupervisorId = (System.Decimal)dataRow["ED_PROJ_SUPERVISOR_ID"];
			entity.EdProjectId = (System.Decimal)dataRow["ED_PROJECT_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SupTypeFlg = (System.Decimal)dataRow["SUP_TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdProjSupervisor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdProjSupervisor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProjSupervisor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdProjectIdSource	
			if (CanDeepLoad(entity, "EdProject|EdProjectIdSource", deepLoadType, innerList) 
				&& entity.EdProjectIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdProjectId;
				EdProject tmpEntity = EntityManager.LocateEntity<EdProject>(EntityLocator.ConstructKeyFromPkItems(typeof(EdProject), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdProjectIdSource = tmpEntity;
				else
					entity.EdProjectIdSource = DataRepository.EdProjectProvider.GetByEdProjectId(transactionManager, entity.EdProjectId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjectIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdProjectIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdProjectProvider.DeepLoad(transactionManager, entity.EdProjectIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdProjectIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdProjSupervisor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdProjSupervisor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdProjSupervisor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProjSupervisor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdProjectIdSource
			if (CanDeepSave(entity, "EdProject|EdProjectIdSource", deepSaveType, innerList) 
				&& entity.EdProjectIdSource != null)
			{
				DataRepository.EdProjectProvider.Save(transactionManager, entity.EdProjectIdSource);
				entity.EdProjectId = entity.EdProjectIdSource.EdProjectId;
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
	
	#region EdProjSupervisorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdProjSupervisor</c>
	///</summary>
	public enum EdProjSupervisorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdProject</c> at EdProjectIdSource
		///</summary>
		[ChildEntityType(typeof(EdProject))]
		EdProject,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdProjSupervisorChildEntityTypes
	
	#region EdProjSupervisorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdProjSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdProjSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdProjSupervisorFilterBuilder : SqlFilterBuilder<EdProjSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorFilterBuilder class.
		/// </summary>
		public EdProjSupervisorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdProjSupervisorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdProjSupervisorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdProjSupervisorFilterBuilder
	
	#region EdProjSupervisorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdProjSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdProjSupervisor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdProjSupervisorParameterBuilder : ParameterizedSqlFilterBuilder<EdProjSupervisorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorParameterBuilder class.
		/// </summary>
		public EdProjSupervisorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdProjSupervisorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdProjSupervisorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdProjSupervisorParameterBuilder
	
	#region EdProjSupervisorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdProjSupervisorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdProjSupervisor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdProjSupervisorSortBuilder : SqlSortBuilder<EdProjSupervisorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdProjSupervisorSqlSortBuilder class.
		/// </summary>
		public EdProjSupervisorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdProjSupervisorSortBuilder
	
} // end namespace
