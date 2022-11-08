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
	/// This class is the base class for any <see cref="AccomStudResponsibleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudResponsibleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudResponsible, UMIS_VER2.BusinessLyer.AccomStudResponsibleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudResponsibleKey key)
		{
			return Delete(transactionManager, key.AccomStudResponsibleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudResponsibleId)
		{
			return Delete(null, _accomStudResponsibleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudResponsibleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		FK_ACCOM_STUD_RESPONSIBLE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		FK_ACCOM_STUD_RESPONSIBLE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudResponsible> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		FK_ACCOM_STUD_RESPONSIBLE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		fkAccomStudResponsibleEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		fkAccomStudResponsibleEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_ED_STUD key.
		///		FK_ACCOM_STUD_RESPONSIBLE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public abstract TList<AccomStudResponsible> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(_gsCodeRelationId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudResponsible> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		fkAccomStudResponsibleGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		fkAccomStudResponsibleGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public TList<AccomStudResponsible> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength,out int count)
		{
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP key.
		///		FK_ACCOM_STUD_RESPONSIBLE_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudResponsible objects.</returns>
		public abstract TList<AccomStudResponsible> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudResponsible Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudResponsibleKey key, int start, int pageLength)
		{
			return GetByAccomStudResponsibleId(transactionManager, key.AccomStudResponsibleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(System.Decimal _accomStudResponsibleId)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(null,_accomStudResponsibleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(System.Decimal _accomStudResponsibleId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(null, _accomStudResponsibleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal _accomStudResponsibleId)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(transactionManager, _accomStudResponsibleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal _accomStudResponsibleId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(transactionManager, _accomStudResponsibleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(System.Decimal _accomStudResponsibleId, int start, int pageLength, out int count)
		{
			return GetByAccomStudResponsibleId(null, _accomStudResponsibleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_RESPONSIBLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudResponsible GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal _accomStudResponsibleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudResponsible&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudResponsible&gt;"/></returns>
		public static TList<AccomStudResponsible> Fill(IDataReader reader, TList<AccomStudResponsible> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudResponsible c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudResponsible")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_RESPONSIBLE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudResponsible>(
					key.ToString(), // EntityTrackingKey
					"AccomStudResponsible",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudResponsible();
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
					c.AccomStudResponsibleId = (System.Decimal)reader["ACCOM_STUD_RESPONSIBLE_ID"];
					c.OriginalAccomStudResponsibleId = c.AccomStudResponsibleId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
					c.PersonNameAr = Convert.IsDBNull(reader["PERSON_NAME_AR"]) ? null : (System.String)reader["PERSON_NAME_AR"];
					c.Cpr = Convert.IsDBNull(reader["CPR"]) ? null : (System.String)reader["CPR"];
					c.MobileNum = Convert.IsDBNull(reader["MOBILE_NUM"]) ? null : (System.String)reader["MOBILE_NUM"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudResponsible entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudResponsibleId = (System.Decimal)reader[((int)AccomStudResponsibleColumn.AccomStudResponsibleId - 1)];
			entity.OriginalAccomStudResponsibleId = (System.Decimal)reader["ACCOM_STUD_RESPONSIBLE_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)AccomStudResponsibleColumn.EdStudId - 1)];
			entity.GsCodeRelationId = (System.Decimal)reader[((int)AccomStudResponsibleColumn.GsCodeRelationId - 1)];
			entity.PersonNameAr = (reader.IsDBNull(((int)AccomStudResponsibleColumn.PersonNameAr - 1)))?null:(System.String)reader[((int)AccomStudResponsibleColumn.PersonNameAr - 1)];
			entity.Cpr = (reader.IsDBNull(((int)AccomStudResponsibleColumn.Cpr - 1)))?null:(System.String)reader[((int)AccomStudResponsibleColumn.Cpr - 1)];
			entity.MobileNum = (reader.IsDBNull(((int)AccomStudResponsibleColumn.MobileNum - 1)))?null:(System.String)reader[((int)AccomStudResponsibleColumn.MobileNum - 1)];
			entity.EMail = (reader.IsDBNull(((int)AccomStudResponsibleColumn.EMail - 1)))?null:(System.String)reader[((int)AccomStudResponsibleColumn.EMail - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)AccomStudResponsibleColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)AccomStudResponsibleColumn.AttchdDocPath - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AccomStudResponsibleColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)AccomStudResponsibleColumn.ApproveFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudResponsibleColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudResponsibleColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudResponsibleColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudResponsibleColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudResponsible entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudResponsibleId = (System.Decimal)dataRow["ACCOM_STUD_RESPONSIBLE_ID"];
			entity.OriginalAccomStudResponsibleId = (System.Decimal)dataRow["ACCOM_STUD_RESPONSIBLE_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.PersonNameAr = Convert.IsDBNull(dataRow["PERSON_NAME_AR"]) ? null : (System.String)dataRow["PERSON_NAME_AR"];
			entity.Cpr = Convert.IsDBNull(dataRow["CPR"]) ? null : (System.String)dataRow["CPR"];
			entity.MobileNum = Convert.IsDBNull(dataRow["MOBILE_NUM"]) ? null : (System.String)dataRow["MOBILE_NUM"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudResponsible"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudResponsible Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudResponsible entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
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

			#region GsCodeRelationIdSource	
			if (CanDeepLoad(entity, "GsCodeKinship|GsCodeRelationIdSource", deepLoadType, innerList) 
				&& entity.GsCodeRelationIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeRelationId;
				GsCodeKinship tmpEntity = EntityManager.LocateEntity<GsCodeKinship>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeKinship), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeRelationIdSource = tmpEntity;
				else
					entity.GsCodeRelationIdSource = DataRepository.GsCodeKinshipProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeRelationIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeRelationIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeKinshipProvider.DeepLoad(transactionManager, entity.GsCodeRelationIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeRelationIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomStudResponsibleId methods when available
			
			#region AccomStudPermtReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudPermtReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudPermtReqCollection = DataRepository.AccomStudPermtReqProvider.GetByAccomStudResponsibleId(transactionManager, entity.AccomStudResponsibleId);

				if (deep && entity.AccomStudPermtReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudPermtReq>) DataRepository.AccomStudPermtReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudPermtReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudResponsible object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudResponsible instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudResponsible Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudResponsible entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeRelationIdSource
			if (CanDeepSave(entity, "GsCodeKinship|GsCodeRelationIdSource", deepSaveType, innerList) 
				&& entity.GsCodeRelationIdSource != null)
			{
				DataRepository.GsCodeKinshipProvider.Save(transactionManager, entity.GsCodeRelationIdSource);
				entity.GsCodeRelationId = entity.GsCodeRelationIdSource.GsCodeRelationId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomStudPermtReq>
				if (CanDeepSave(entity.AccomStudPermtReqCollection, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudPermtReq child in entity.AccomStudPermtReqCollection)
					{
						if(child.AccomStudResponsibleIdSource != null)
						{
							child.AccomStudResponsibleId = child.AccomStudResponsibleIdSource.AccomStudResponsibleId;
						}
						else
						{
							child.AccomStudResponsibleId = entity.AccomStudResponsibleId;
						}

					}

					if (entity.AccomStudPermtReqCollection.Count > 0 || entity.AccomStudPermtReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudPermtReqProvider.Save(transactionManager, entity.AccomStudPermtReqCollection);
						
						deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudPermtReq >) DataRepository.AccomStudPermtReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudPermtReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomStudResponsibleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudResponsible</c>
	///</summary>
	public enum AccomStudResponsibleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeKinship</c> at GsCodeRelationIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeKinship))]
		GsCodeKinship,
		///<summary>
		/// Collection of <c>AccomStudResponsible</c> as OneToMany for AccomStudPermtReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudPermtReq>))]
		AccomStudPermtReqCollection,
	}
	
	#endregion AccomStudResponsibleChildEntityTypes
	
	#region AccomStudResponsibleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudResponsibleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudResponsible"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudResponsibleFilterBuilder : SqlFilterBuilder<AccomStudResponsibleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleFilterBuilder class.
		/// </summary>
		public AccomStudResponsibleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudResponsibleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudResponsibleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudResponsibleFilterBuilder
	
	#region AccomStudResponsibleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudResponsibleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudResponsible"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudResponsibleParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudResponsibleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleParameterBuilder class.
		/// </summary>
		public AccomStudResponsibleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudResponsibleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudResponsibleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudResponsibleParameterBuilder
	
	#region AccomStudResponsibleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudResponsibleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudResponsible"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudResponsibleSortBuilder : SqlSortBuilder<AccomStudResponsibleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudResponsibleSqlSortBuilder class.
		/// </summary>
		public AccomStudResponsibleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudResponsibleSortBuilder
	
} // end namespace
