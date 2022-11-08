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
	/// This class is the base class for any <see cref="EdStudContactMethodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudContactMethodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudContactMethod, UMIS_VER2.BusinessLyer.EdStudContactMethodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudContactMethodKey key)
		{
			return Delete(transactionManager, key.EdStudContactMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudContactMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudContactMethodId)
		{
			return Delete(null, _edStudContactMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudContactMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudContactMethodId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		public TList<EdStudContactMethod> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudContactMethod> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		public TList<EdStudContactMethod> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		fkEdStudContactMethodAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		public TList<EdStudContactMethod> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		fkEdStudContactMethodAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		public TList<EdStudContactMethod> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS key.
		///		FK_ED_STUD_CONTACT_METHOD_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudContactMethod objects.</returns>
		public abstract TList<EdStudContactMethod> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudContactMethod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudContactMethodKey key, int start, int pageLength)
		{
			return GetByEdStudContactMethodId(transactionManager, key.EdStudContactMethodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public abstract TList<EdStudContactMethod> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null,_gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public TList<EdStudContactMethod> GetByGsCodeContactMethodId(System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count)
		{
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CONTACT_METH_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudContactMethod&gt;"/> class.</returns>
		public abstract TList<EdStudContactMethod> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal _gsCodeContactMethodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_edStudContactMethodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(System.Decimal _edStudContactMethodId)
		{
			int count = -1;
			return GetByEdStudContactMethodId(null,_edStudContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_edStudContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(System.Decimal _edStudContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudContactMethodId(null, _edStudContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudContactMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(TransactionManager transactionManager, System.Decimal _edStudContactMethodId)
		{
			int count = -1;
			return GetByEdStudContactMethodId(transactionManager, _edStudContactMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(TransactionManager transactionManager, System.Decimal _edStudContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudContactMethodId(transactionManager, _edStudContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="_edStudContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(System.Decimal _edStudContactMethodId, int start, int pageLength, out int count)
		{
			return GetByEdStudContactMethodId(null, _edStudContactMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CONTACT_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudContactMethod GetByEdStudContactMethodId(TransactionManager transactionManager, System.Decimal _edStudContactMethodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudContactMethod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudContactMethod&gt;"/></returns>
		public static TList<EdStudContactMethod> Fill(IDataReader reader, TList<EdStudContactMethod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudContactMethod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudContactMethod")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CONTACT_METHOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudContactMethod>(
					key.ToString(), // EntityTrackingKey
					"EdStudContactMethod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudContactMethod();
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
					c.EdStudContactMethodId = (System.Decimal)reader["ED_STUD_CONTACT_METHOD_ID"];
					c.OriginalEdStudContactMethodId = c.EdStudContactMethodId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.GsCodeContactMethodId = (System.Decimal)reader["GS_CODE_CONTACT_METHOD_ID"];
					c.MethodDescr = (System.String)reader["METHOD_DESCR"];
					c.MethodNotes = Convert.IsDBNull(reader["METHOD_NOTES"]) ? null : (System.String)reader["METHOD_NOTES"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.MainFlg = Convert.IsDBNull(reader["MAIN_FLG"]) ? null : (System.Decimal?)reader["MAIN_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudContactMethod entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudContactMethodId = (System.Decimal)reader[((int)EdStudContactMethodColumn.EdStudContactMethodId - 1)];
			entity.OriginalEdStudContactMethodId = (System.Decimal)reader["ED_STUD_CONTACT_METHOD_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudContactMethodColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudContactMethodColumn.EdStudId - 1)];
			entity.GsCodeContactMethodId = (System.Decimal)reader[((int)EdStudContactMethodColumn.GsCodeContactMethodId - 1)];
			entity.MethodDescr = (System.String)reader[((int)EdStudContactMethodColumn.MethodDescr - 1)];
			entity.MethodNotes = (reader.IsDBNull(((int)EdStudContactMethodColumn.MethodNotes - 1)))?null:(System.String)reader[((int)EdStudContactMethodColumn.MethodNotes - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)EdStudContactMethodColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)EdStudContactMethodColumn.AdmApplicantId - 1)];
			entity.MainFlg = (reader.IsDBNull(((int)EdStudContactMethodColumn.MainFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudContactMethodColumn.MainFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudContactMethod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudContactMethodId = (System.Decimal)dataRow["ED_STUD_CONTACT_METHOD_ID"];
			entity.OriginalEdStudContactMethodId = (System.Decimal)dataRow["ED_STUD_CONTACT_METHOD_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.GsCodeContactMethodId = (System.Decimal)dataRow["GS_CODE_CONTACT_METHOD_ID"];
			entity.MethodDescr = (System.String)dataRow["METHOD_DESCR"];
			entity.MethodNotes = Convert.IsDBNull(dataRow["METHOD_NOTES"]) ? null : (System.String)dataRow["METHOD_NOTES"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.MainFlg = Convert.IsDBNull(dataRow["MAIN_FLG"]) ? null : (System.Decimal?)dataRow["MAIN_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudContactMethod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudContactMethod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudContactMethod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeContactMethodIdSource	
			if (CanDeepLoad(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodeContactMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeContactMethodId;
				GsCodeContactMethod tmpEntity = EntityManager.LocateEntity<GsCodeContactMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeContactMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeContactMethodIdSource = tmpEntity;
				else
					entity.GsCodeContactMethodIdSource = DataRepository.GsCodeContactMethodProvider.GetByGsCodeContactMethodId(transactionManager, entity.GsCodeContactMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeContactMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeContactMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeContactMethodProvider.DeepLoad(transactionManager, entity.GsCodeContactMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeContactMethodIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudContactMethod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudContactMethod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudContactMethod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudContactMethod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeContactMethodIdSource
			if (CanDeepSave(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodeContactMethodIdSource != null)
			{
				DataRepository.GsCodeContactMethodProvider.Save(transactionManager, entity.GsCodeContactMethodIdSource);
				entity.GsCodeContactMethodId = entity.GsCodeContactMethodIdSource.GsCodeContactMethodId;
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
	
	#region EdStudContactMethodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudContactMethod</c>
	///</summary>
	public enum EdStudContactMethodChildEntityTypes
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
		/// Composite Property for <c>GsCodeContactMethod</c> at GsCodeContactMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeContactMethod))]
		GsCodeContactMethod,
	}
	
	#endregion EdStudContactMethodChildEntityTypes
	
	#region EdStudContactMethodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudContactMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudContactMethodFilterBuilder : SqlFilterBuilder<EdStudContactMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodFilterBuilder class.
		/// </summary>
		public EdStudContactMethodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudContactMethodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudContactMethodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudContactMethodFilterBuilder
	
	#region EdStudContactMethodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudContactMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudContactMethodParameterBuilder : ParameterizedSqlFilterBuilder<EdStudContactMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodParameterBuilder class.
		/// </summary>
		public EdStudContactMethodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudContactMethodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudContactMethodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudContactMethodParameterBuilder
	
	#region EdStudContactMethodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudContactMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudContactMethod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudContactMethodSortBuilder : SqlSortBuilder<EdStudContactMethodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudContactMethodSqlSortBuilder class.
		/// </summary>
		public EdStudContactMethodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudContactMethodSortBuilder
	
} // end namespace
