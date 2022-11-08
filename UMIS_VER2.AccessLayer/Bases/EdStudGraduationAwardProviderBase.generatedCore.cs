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
	/// This class is the base class for any <see cref="EdStudGraduationAwardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudGraduationAwardProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudGraduationAward, UMIS_VER2.BusinessLyer.EdStudGraduationAwardKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGraduationAwardKey key)
		{
			return Delete(transactionManager, key.EdStudGraduationAwardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudGraduationAwardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudGraduationAwardId)
		{
			return Delete(null, _edStudGraduationAwardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGraduationAwardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudGraduationAwardId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		public TList<EdStudGraduationAward> GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(_edGraduationAwardId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGraduationAward> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		public TList<EdStudGraduationAward> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		fkEdStudGraduationAwardEdGraduationAward Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		public TList<EdStudGraduationAward> GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		fkEdStudGraduationAwardEdGraduationAward Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		public TList<EdStudGraduationAward> GetByEdGraduationAwardId(System.Decimal _edGraduationAwardId, int start, int pageLength,out int count)
		{
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD key.
		///		FK_ED_STUD_GRADUATION_AWARD_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGraduationAward objects.</returns>
		public abstract TList<EdStudGraduationAward> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudGraduationAward Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGraduationAwardKey key, int start, int pageLength)
		{
			return GetByEdStudGraduationAwardId(transactionManager, key.EdStudGraduationAwardId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public TList<EdStudGraduationAward> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public TList<EdStudGraduationAward> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public TList<EdStudGraduationAward> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public TList<EdStudGraduationAward> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public TList<EdStudGraduationAward> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_3097 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudGraduationAward&gt;"/> class.</returns>
		public abstract TList<EdStudGraduationAward> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(System.Decimal _edStudGraduationAwardId)
		{
			int count = -1;
			return GetByEdStudGraduationAwardId(null,_edStudGraduationAwardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(System.Decimal _edStudGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGraduationAwardId(null, _edStudGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(TransactionManager transactionManager, System.Decimal _edStudGraduationAwardId)
		{
			int count = -1;
			return GetByEdStudGraduationAwardId(transactionManager, _edStudGraduationAwardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(TransactionManager transactionManager, System.Decimal _edStudGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGraduationAwardId(transactionManager, _edStudGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(System.Decimal _edStudGraduationAwardId, int start, int pageLength, out int count)
		{
			return GetByEdStudGraduationAwardId(null, _edStudGraduationAwardId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_BESTOWED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdStudGraduationAwardId(TransactionManager transactionManager, System.Decimal _edStudGraduationAwardId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(System.Decimal _edGraduationAwardId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdGraduationAwardIdEdStudId(null,_edGraduationAwardId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(System.Decimal _edGraduationAwardId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardIdEdStudId(null, _edGraduationAwardId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdGraduationAwardIdEdStudId(transactionManager, _edGraduationAwardId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardIdEdStudId(transactionManager, _edGraduationAwardId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(System.Decimal _edGraduationAwardId, System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdGraduationAwardIdEdStudId(null, _edGraduationAwardId, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GRADUATION_AWARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudGraduationAward GetByEdGraduationAwardIdEdStudId(TransactionManager transactionManager, System.Decimal _edGraduationAwardId, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudGraduationAward&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudGraduationAward&gt;"/></returns>
		public static TList<EdStudGraduationAward> Fill(IDataReader reader, TList<EdStudGraduationAward> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudGraduationAward c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudGraduationAward")
					.Append("|").Append((System.Decimal)reader["ED_STUD_GRADUATION_AWARD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudGraduationAward>(
					key.ToString(), // EntityTrackingKey
					"EdStudGraduationAward",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudGraduationAward();
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
					c.EdStudGraduationAwardId = (System.Decimal)reader["ED_STUD_GRADUATION_AWARD_ID"];
					c.OriginalEdStudGraduationAwardId = c.EdStudGraduationAwardId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.CertificateDeliveryFlag = (System.Decimal)reader["CERTIFICATE_DELIVERY_FLAG"];
					c.EdGraduationAwardId = (System.Decimal)reader["ED_GRADUATION_AWARD_ID"];
					c.DeliveryDate = Convert.IsDBNull(reader["DELIVERY_DATE"]) ? null : (System.DateTime?)reader["DELIVERY_DATE"];
					c.CertStatusFlg = Convert.IsDBNull(reader["CERT_STATUS_FLG"]) ? null : (System.Int32?)reader["CERT_STATUS_FLG"];
					c.TransDeliveryDate = Convert.IsDBNull(reader["TRANS_DELIVERY_DATE"]) ? null : (System.DateTime?)reader["TRANS_DELIVERY_DATE"];
					c.TransCertStatusFlg = Convert.IsDBNull(reader["TRANS_CERT_STATUS_FLG"]) ? null : (System.Int32?)reader["TRANS_CERT_STATUS_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudGraduationAward entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudGraduationAwardId = (System.Decimal)reader[((int)EdStudGraduationAwardColumn.EdStudGraduationAwardId - 1)];
			entity.OriginalEdStudGraduationAwardId = (System.Decimal)reader["ED_STUD_GRADUATION_AWARD_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudGraduationAwardColumn.EdStudId - 1)];
			entity.CertificateDeliveryFlag = (System.Decimal)reader[((int)EdStudGraduationAwardColumn.CertificateDeliveryFlag - 1)];
			entity.EdGraduationAwardId = (System.Decimal)reader[((int)EdStudGraduationAwardColumn.EdGraduationAwardId - 1)];
			entity.DeliveryDate = (reader.IsDBNull(((int)EdStudGraduationAwardColumn.DeliveryDate - 1)))?null:(System.DateTime?)reader[((int)EdStudGraduationAwardColumn.DeliveryDate - 1)];
			entity.CertStatusFlg = (reader.IsDBNull(((int)EdStudGraduationAwardColumn.CertStatusFlg - 1)))?null:(System.Int32?)reader[((int)EdStudGraduationAwardColumn.CertStatusFlg - 1)];
			entity.TransDeliveryDate = (reader.IsDBNull(((int)EdStudGraduationAwardColumn.TransDeliveryDate - 1)))?null:(System.DateTime?)reader[((int)EdStudGraduationAwardColumn.TransDeliveryDate - 1)];
			entity.TransCertStatusFlg = (reader.IsDBNull(((int)EdStudGraduationAwardColumn.TransCertStatusFlg - 1)))?null:(System.Int32?)reader[((int)EdStudGraduationAwardColumn.TransCertStatusFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudGraduationAward entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudGraduationAwardId = (System.Decimal)dataRow["ED_STUD_GRADUATION_AWARD_ID"];
			entity.OriginalEdStudGraduationAwardId = (System.Decimal)dataRow["ED_STUD_GRADUATION_AWARD_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.CertificateDeliveryFlag = (System.Decimal)dataRow["CERTIFICATE_DELIVERY_FLAG"];
			entity.EdGraduationAwardId = (System.Decimal)dataRow["ED_GRADUATION_AWARD_ID"];
			entity.DeliveryDate = Convert.IsDBNull(dataRow["DELIVERY_DATE"]) ? null : (System.DateTime?)dataRow["DELIVERY_DATE"];
			entity.CertStatusFlg = Convert.IsDBNull(dataRow["CERT_STATUS_FLG"]) ? null : (System.Int32?)dataRow["CERT_STATUS_FLG"];
			entity.TransDeliveryDate = Convert.IsDBNull(dataRow["TRANS_DELIVERY_DATE"]) ? null : (System.DateTime?)dataRow["TRANS_DELIVERY_DATE"];
			entity.TransCertStatusFlg = Convert.IsDBNull(dataRow["TRANS_CERT_STATUS_FLG"]) ? null : (System.Int32?)dataRow["TRANS_CERT_STATUS_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGraduationAward"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGraduationAward Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGraduationAward entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdGraduationAwardIdSource	
			if (CanDeepLoad(entity, "EdGraduationAward|EdGraduationAwardIdSource", deepLoadType, innerList) 
				&& entity.EdGraduationAwardIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdGraduationAwardId;
				EdGraduationAward tmpEntity = EntityManager.LocateEntity<EdGraduationAward>(EntityLocator.ConstructKeyFromPkItems(typeof(EdGraduationAward), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdGraduationAwardIdSource = tmpEntity;
				else
					entity.EdGraduationAwardIdSource = DataRepository.EdGraduationAwardProvider.GetByEdGraduationAwardId(transactionManager, entity.EdGraduationAwardId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdGraduationAwardIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdGraduationAwardProvider.DeepLoad(transactionManager, entity.EdGraduationAwardIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdGraduationAwardIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudGraduationAward object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudGraduationAward instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGraduationAward Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGraduationAward entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdGraduationAwardIdSource
			if (CanDeepSave(entity, "EdGraduationAward|EdGraduationAwardIdSource", deepSaveType, innerList) 
				&& entity.EdGraduationAwardIdSource != null)
			{
				DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardIdSource);
				entity.EdGraduationAwardId = entity.EdGraduationAwardIdSource.EdGraduationAwardId;
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
	
	#region EdStudGraduationAwardChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudGraduationAward</c>
	///</summary>
	public enum EdStudGraduationAwardChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdGraduationAward</c> at EdGraduationAwardIdSource
		///</summary>
		[ChildEntityType(typeof(EdGraduationAward))]
		EdGraduationAward,
	}
	
	#endregion EdStudGraduationAwardChildEntityTypes
	
	#region EdStudGraduationAwardFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGraduationAward"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGraduationAwardFilterBuilder : SqlFilterBuilder<EdStudGraduationAwardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardFilterBuilder class.
		/// </summary>
		public EdStudGraduationAwardFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGraduationAwardFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGraduationAwardFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGraduationAwardFilterBuilder
	
	#region EdStudGraduationAwardParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGraduationAward"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGraduationAwardParameterBuilder : ParameterizedSqlFilterBuilder<EdStudGraduationAwardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardParameterBuilder class.
		/// </summary>
		public EdStudGraduationAwardParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGraduationAwardParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGraduationAwardParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGraduationAwardParameterBuilder
	
	#region EdStudGraduationAwardSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudGraduationAwardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGraduationAward"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudGraduationAwardSortBuilder : SqlSortBuilder<EdStudGraduationAwardColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGraduationAwardSqlSortBuilder class.
		/// </summary>
		public EdStudGraduationAwardSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudGraduationAwardSortBuilder
	
} // end namespace
