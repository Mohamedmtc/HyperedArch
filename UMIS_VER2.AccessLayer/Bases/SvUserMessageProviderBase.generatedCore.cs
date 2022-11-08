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
	/// This class is the base class for any <see cref="SvUserMessageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvUserMessageProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvUserMessage, UMIS_VER2.BusinessLyer.SvUserMessageKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMessageKey key)
		{
			return Delete(transactionManager, key.SvUserMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svUserMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svUserMessageId)
		{
			return Delete(null, _svUserMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svUserMessageId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_USER_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_USER_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_USER_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		fkSvUserMessageAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		fkSvUserMessageAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_USER_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public abstract TList<SvUserMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_USER_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(_seUserAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_USER_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_USER_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		fkSvUserMessageSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		fkSvUserMessageSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public TList<SvUserMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId, int start, int pageLength,out int count)
		{
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_USER_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMessage objects.</returns>
		public abstract TList<SvUserMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvUserMessage Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMessageKey key, int start, int pageLength)
		{
			return GetBySvUserMessageId(transactionManager, key.SvUserMessageId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public TList<SvUserMessage> GetBySvMessageId(System.Decimal _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(null,_svMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public TList<SvUserMessage> GetBySvMessageId(System.Decimal _svMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageId(null, _svMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public TList<SvUserMessage> GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public TList<SvUserMessage> GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public TList<SvUserMessage> GetBySvMessageId(System.Decimal _svMessageId, int start, int pageLength, out int count)
		{
			return GetBySvMessageId(null, _svMessageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_MESSAGE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvUserMessage&gt;"/> class.</returns>
		public abstract TList<SvUserMessage> GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="_svUserMessageId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(System.Decimal _svUserMessageId)
		{
			int count = -1;
			return GetBySvUserMessageId(null,_svUserMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="_svUserMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(System.Decimal _svUserMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserMessageId(null, _svUserMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(TransactionManager transactionManager, System.Decimal _svUserMessageId)
		{
			int count = -1;
			return GetBySvUserMessageId(transactionManager, _svUserMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(TransactionManager transactionManager, System.Decimal _svUserMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserMessageId(transactionManager, _svUserMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="_svUserMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(System.Decimal _svUserMessageId, int start, int pageLength, out int count)
		{
			return GetBySvUserMessageId(null, _svUserMessageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvUserMessage GetBySvUserMessageId(TransactionManager transactionManager, System.Decimal _svUserMessageId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvUserMessage&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvUserMessage&gt;"/></returns>
		public static TList<SvUserMessage> Fill(IDataReader reader, TList<SvUserMessage> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvUserMessage c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvUserMessage")
					.Append("|").Append((System.Decimal)reader["SV_USER_MESSAGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvUserMessage>(
					key.ToString(), // EntityTrackingKey
					"SvUserMessage",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvUserMessage();
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
					c.SvUserMessageId = (System.Decimal)reader["SV_USER_MESSAGE_ID"];
					c.OriginalSvUserMessageId = c.SvUserMessageId;
					c.SvMessageId = (System.Decimal)reader["SV_MESSAGE_ID"];
					c.OpenedFlg = (System.Decimal)reader["OPENED_FLG"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.DeleteFlg = Convert.IsDBNull(reader["DELETE_FLG"]) ? null : (System.Decimal?)reader["DELETE_FLG"];
					c.SeUserAccntId = Convert.IsDBNull(reader["SE_USER_ACCNT_ID"]) ? null : (System.Decimal?)reader["SE_USER_ACCNT_ID"];
					c.MailSentFlg = Convert.IsDBNull(reader["MAIL_SENT_FLG"]) ? null : (System.Boolean?)reader["MAIL_SENT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvUserMessage entity)
		{
			if (!reader.Read()) return;
			
			entity.SvUserMessageId = (System.Decimal)reader[((int)SvUserMessageColumn.SvUserMessageId - 1)];
			entity.OriginalSvUserMessageId = (System.Decimal)reader["SV_USER_MESSAGE_ID"];
			entity.SvMessageId = (System.Decimal)reader[((int)SvUserMessageColumn.SvMessageId - 1)];
			entity.OpenedFlg = (System.Decimal)reader[((int)SvUserMessageColumn.OpenedFlg - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)SvUserMessageColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)SvUserMessageColumn.AdmApplicantId - 1)];
			entity.DeleteFlg = (reader.IsDBNull(((int)SvUserMessageColumn.DeleteFlg - 1)))?null:(System.Decimal?)reader[((int)SvUserMessageColumn.DeleteFlg - 1)];
			entity.SeUserAccntId = (reader.IsDBNull(((int)SvUserMessageColumn.SeUserAccntId - 1)))?null:(System.Decimal?)reader[((int)SvUserMessageColumn.SeUserAccntId - 1)];
			entity.MailSentFlg = (reader.IsDBNull(((int)SvUserMessageColumn.MailSentFlg - 1)))?null:(System.Boolean?)reader[((int)SvUserMessageColumn.MailSentFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvUserMessage entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvUserMessageId = (System.Decimal)dataRow["SV_USER_MESSAGE_ID"];
			entity.OriginalSvUserMessageId = (System.Decimal)dataRow["SV_USER_MESSAGE_ID"];
			entity.SvMessageId = (System.Decimal)dataRow["SV_MESSAGE_ID"];
			entity.OpenedFlg = (System.Decimal)dataRow["OPENED_FLG"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.DeleteFlg = Convert.IsDBNull(dataRow["DELETE_FLG"]) ? null : (System.Decimal?)dataRow["DELETE_FLG"];
			entity.SeUserAccntId = Convert.IsDBNull(dataRow["SE_USER_ACCNT_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ACCNT_ID"];
			entity.MailSentFlg = Convert.IsDBNull(dataRow["MAIL_SENT_FLG"]) ? null : (System.Boolean?)dataRow["MAIL_SENT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMessage"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserMessage Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMessage entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SeUserAccntIdSource	
			if (CanDeepLoad(entity, "SeUserAccnt|SeUserAccntIdSource", deepLoadType, innerList) 
				&& entity.SeUserAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserAccntId ?? 0.0m);
				SeUserAccnt tmpEntity = EntityManager.LocateEntity<SeUserAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUserAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserAccntIdSource = tmpEntity;
				else
					entity.SeUserAccntIdSource = DataRepository.SeUserAccntProvider.GetBySeUserAccntId(transactionManager, (entity.SeUserAccntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserAccntProvider.DeepLoad(transactionManager, entity.SeUserAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserAccntIdSource

			#region SvMessageIdSource	
			if (CanDeepLoad(entity, "SvMessage|SvMessageIdSource", deepLoadType, innerList) 
				&& entity.SvMessageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvMessageId;
				SvMessage tmpEntity = EntityManager.LocateEntity<SvMessage>(EntityLocator.ConstructKeyFromPkItems(typeof(SvMessage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvMessageIdSource = tmpEntity;
				else
					entity.SvMessageIdSource = DataRepository.SvMessageProvider.GetBySvMessageId(transactionManager, entity.SvMessageId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvMessageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvMessageProvider.DeepLoad(transactionManager, entity.SvMessageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvMessageIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvUserMessage object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvUserMessage instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserMessage Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMessage entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SeUserAccntIdSource
			if (CanDeepSave(entity, "SeUserAccnt|SeUserAccntIdSource", deepSaveType, innerList) 
				&& entity.SeUserAccntIdSource != null)
			{
				DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntIdSource);
				entity.SeUserAccntId = entity.SeUserAccntIdSource.SeUserAccntId;
			}
			#endregion 
			
			#region SvMessageIdSource
			if (CanDeepSave(entity, "SvMessage|SvMessageIdSource", deepSaveType, innerList) 
				&& entity.SvMessageIdSource != null)
			{
				DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageIdSource);
				entity.SvMessageId = entity.SvMessageIdSource.SvMessageId;
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
	
	#region SvUserMessageChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvUserMessage</c>
	///</summary>
	public enum SvUserMessageChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>SeUserAccnt</c> at SeUserAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeUserAccnt))]
		SeUserAccnt,
		
		///<summary>
		/// Composite Property for <c>SvMessage</c> at SvMessageIdSource
		///</summary>
		[ChildEntityType(typeof(SvMessage))]
		SvMessage,
	}
	
	#endregion SvUserMessageChildEntityTypes
	
	#region SvUserMessageFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvUserMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserMessageFilterBuilder : SqlFilterBuilder<SvUserMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMessageFilterBuilder class.
		/// </summary>
		public SvUserMessageFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserMessageFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserMessageFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserMessageFilterBuilder
	
	#region SvUserMessageParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvUserMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserMessageParameterBuilder : ParameterizedSqlFilterBuilder<SvUserMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMessageParameterBuilder class.
		/// </summary>
		public SvUserMessageParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserMessageParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserMessageParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserMessageParameterBuilder
	
	#region SvUserMessageSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvUserMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMessage"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvUserMessageSortBuilder : SqlSortBuilder<SvUserMessageColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMessageSqlSortBuilder class.
		/// </summary>
		public SvUserMessageSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvUserMessageSortBuilder
	
} // end namespace
