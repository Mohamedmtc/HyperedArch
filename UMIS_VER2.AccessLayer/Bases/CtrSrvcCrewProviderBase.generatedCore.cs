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
	/// This class is the base class for any <see cref="CtrSrvcCrewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrSrvcCrewProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrSrvcCrew, UMIS_VER2.BusinessLyer.CtrSrvcCrewKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrSrvcCrewKey key)
		{
			return Delete(transactionManager, key.CtrSrvcCrewId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrSrvcCrewId)
		{
			return Delete(null, _ctrSrvcCrewId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrSrvcCrewId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		FK_CTR_SRVC_CREW_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		FK_CTR_SRVC_CREW_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		/// <remarks></remarks>
		public TList<CtrSrvcCrew> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		FK_CTR_SRVC_CREW_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		fkCtrSrvcCrewEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		fkCtrSrvcCrewEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ED_STUD key.
		///		FK_CTR_SRVC_CREW_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public abstract TList<CtrSrvcCrew> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		FK_CTR_SRVC_CREW_ERP_EMP Description: 
		/// </summary>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByErpEmpId(System.Decimal? _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(_erpEmpId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		FK_CTR_SRVC_CREW_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		/// <remarks></remarks>
		public TList<CtrSrvcCrew> GetByErpEmpId(TransactionManager transactionManager, System.Decimal? _erpEmpId)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		FK_CTR_SRVC_CREW_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByErpEmpId(TransactionManager transactionManager, System.Decimal? _erpEmpId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpEmpId(transactionManager, _erpEmpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		fkCtrSrvcCrewErpEmp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByErpEmpId(System.Decimal? _erpEmpId, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpEmpId(null, _erpEmpId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		fkCtrSrvcCrewErpEmp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public TList<CtrSrvcCrew> GetByErpEmpId(System.Decimal? _erpEmpId, int start, int pageLength,out int count)
		{
			return GetByErpEmpId(null, _erpEmpId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_SRVC_CREW_ERP_EMP key.
		///		FK_CTR_SRVC_CREW_ERP_EMP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpEmpId">ظباط - مدنيين[ERP Integration]</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrSrvcCrew objects.</returns>
		public abstract TList<CtrSrvcCrew> GetByErpEmpId(TransactionManager transactionManager, System.Decimal? _erpEmpId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrSrvcCrew Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrSrvcCrewKey key, int start, int pageLength)
		{
			return GetByCtrSrvcCrewId(transactionManager, key.CtrSrvcCrewId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(System.Decimal _ctrSrvcCrewId)
		{
			int count = -1;
			return GetByCtrSrvcCrewId(null,_ctrSrvcCrewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(System.Decimal _ctrSrvcCrewId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrSrvcCrewId(null, _ctrSrvcCrewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(TransactionManager transactionManager, System.Decimal _ctrSrvcCrewId)
		{
			int count = -1;
			return GetByCtrSrvcCrewId(transactionManager, _ctrSrvcCrewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(TransactionManager transactionManager, System.Decimal _ctrSrvcCrewId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrSrvcCrewId(transactionManager, _ctrSrvcCrewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(System.Decimal _ctrSrvcCrewId, int start, int pageLength, out int count)
		{
			return GetByCtrSrvcCrewId(null, _ctrSrvcCrewId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_SRVC_CREW index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrSrvcCrewId">طاقم الخدمة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrSrvcCrew GetByCtrSrvcCrewId(TransactionManager transactionManager, System.Decimal _ctrSrvcCrewId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrSrvcCrew&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrSrvcCrew&gt;"/></returns>
		public static TList<CtrSrvcCrew> Fill(IDataReader reader, TList<CtrSrvcCrew> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrSrvcCrew c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrSrvcCrew")
					.Append("|").Append((System.Decimal)reader["CTR_SRVC_CREW_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrSrvcCrew>(
					key.ToString(), // EntityTrackingKey
					"CtrSrvcCrew",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrSrvcCrew();
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
					c.CtrSrvcCrewId = (System.Decimal)reader["CTR_SRVC_CREW_ID"];
					c.OriginalCtrSrvcCrewId = c.CtrSrvcCrewId;
					c.SrvcDate = (System.DateTime)reader["SRVC_DATE"];
					c.CtrCdeSrvcJobId = (System.Decimal)reader["CTR_CDE_SRVC_JOB_ID"];
					c.ErpEmpId = Convert.IsDBNull(reader["ERP_EMP_ID"]) ? null : (System.Decimal?)reader["ERP_EMP_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrSrvcCrew entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrSrvcCrewId = (System.Decimal)reader[((int)CtrSrvcCrewColumn.CtrSrvcCrewId - 1)];
			entity.OriginalCtrSrvcCrewId = (System.Decimal)reader["CTR_SRVC_CREW_ID"];
			entity.SrvcDate = (System.DateTime)reader[((int)CtrSrvcCrewColumn.SrvcDate - 1)];
			entity.CtrCdeSrvcJobId = (System.Decimal)reader[((int)CtrSrvcCrewColumn.CtrCdeSrvcJobId - 1)];
			entity.ErpEmpId = (reader.IsDBNull(((int)CtrSrvcCrewColumn.ErpEmpId - 1)))?null:(System.Decimal?)reader[((int)CtrSrvcCrewColumn.ErpEmpId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)CtrSrvcCrewColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)CtrSrvcCrewColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrSrvcCrew entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrSrvcCrewId = (System.Decimal)dataRow["CTR_SRVC_CREW_ID"];
			entity.OriginalCtrSrvcCrewId = (System.Decimal)dataRow["CTR_SRVC_CREW_ID"];
			entity.SrvcDate = (System.DateTime)dataRow["SRVC_DATE"];
			entity.CtrCdeSrvcJobId = (System.Decimal)dataRow["CTR_CDE_SRVC_JOB_ID"];
			entity.ErpEmpId = Convert.IsDBNull(dataRow["ERP_EMP_ID"]) ? null : (System.Decimal?)dataRow["ERP_EMP_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrSrvcCrew"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrSrvcCrew Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrSrvcCrew entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region ErpEmpIdSource	
			if (CanDeepLoad(entity, "ErpEmp|ErpEmpIdSource", deepLoadType, innerList) 
				&& entity.ErpEmpIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpEmpId ?? 0.0m);
				ErpEmp tmpEntity = EntityManager.LocateEntity<ErpEmp>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpEmp), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpEmpIdSource = tmpEntity;
				else
					entity.ErpEmpIdSource = DataRepository.ErpEmpProvider.GetByErpEmpId(transactionManager, (entity.ErpEmpId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpEmpIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpEmpIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpEmpProvider.DeepLoad(transactionManager, entity.ErpEmpIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpEmpIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrSrvcCrew object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrSrvcCrew instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrSrvcCrew Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrSrvcCrew entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region ErpEmpIdSource
			if (CanDeepSave(entity, "ErpEmp|ErpEmpIdSource", deepSaveType, innerList) 
				&& entity.ErpEmpIdSource != null)
			{
				DataRepository.ErpEmpProvider.Save(transactionManager, entity.ErpEmpIdSource);
				entity.ErpEmpId = entity.ErpEmpIdSource.ErpEmpId;
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
	
	#region CtrSrvcCrewChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrSrvcCrew</c>
	///</summary>
	public enum CtrSrvcCrewChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>ErpEmp</c> at ErpEmpIdSource
		///</summary>
		[ChildEntityType(typeof(ErpEmp))]
		ErpEmp,
	}
	
	#endregion CtrSrvcCrewChildEntityTypes
	
	#region CtrSrvcCrewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrSrvcCrewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrSrvcCrew"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrSrvcCrewFilterBuilder : SqlFilterBuilder<CtrSrvcCrewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewFilterBuilder class.
		/// </summary>
		public CtrSrvcCrewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrSrvcCrewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrSrvcCrewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrSrvcCrewFilterBuilder
	
	#region CtrSrvcCrewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrSrvcCrewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrSrvcCrew"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrSrvcCrewParameterBuilder : ParameterizedSqlFilterBuilder<CtrSrvcCrewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewParameterBuilder class.
		/// </summary>
		public CtrSrvcCrewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrSrvcCrewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrSrvcCrewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrSrvcCrewParameterBuilder
	
	#region CtrSrvcCrewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrSrvcCrewColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrSrvcCrew"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrSrvcCrewSortBuilder : SqlSortBuilder<CtrSrvcCrewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrSrvcCrewSqlSortBuilder class.
		/// </summary>
		public CtrSrvcCrewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrSrvcCrewSortBuilder
	
} // end namespace
