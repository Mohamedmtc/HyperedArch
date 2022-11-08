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
	/// This class is the base class for any <see cref="SvAutoMsgTmpltProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvAutoMsgTmpltProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvAutoMsgTmplt, UMIS_VER2.BusinessLyer.SvAutoMsgTmpltKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvAutoMsgTmpltKey key)
		{
			return Delete(transactionManager, key.SvAutoMsgTmpltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svAutoMsgTmpltId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svAutoMsgTmpltId)
		{
			return Delete(null, _svAutoMsgTmpltId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		/// <remarks></remarks>
		public TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		fkSvAutoMsgTmpltAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		fkSvAutoMsgTmpltAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO key.
		///		FK_SV_AUTO_MSG_TMPLT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public abstract TList<SvAutoMsgTmplt> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		/// <remarks></remarks>
		public TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		fkSvAutoMsgTmpltSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		fkSvAutoMsgTmpltSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE key.
		///		FK_SV_AUTO_MSG_TMPLT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvAutoMsgTmplt objects.</returns>
		public abstract TList<SvAutoMsgTmplt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvAutoMsgTmplt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvAutoMsgTmpltKey key, int start, int pageLength)
		{
			return GetBySvAutoMsgTmpltId(transactionManager, key.SvAutoMsgTmpltId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(null,_svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(System.Decimal _svAutoMsgTmpltId, int start, int pageLength, out int count)
		{
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_AUTO_MSG_TMPLT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvAutoMsgTmplt GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal _svAutoMsgTmpltId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvAutoMsgTmplt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvAutoMsgTmplt&gt;"/></returns>
		public static TList<SvAutoMsgTmplt> Fill(IDataReader reader, TList<SvAutoMsgTmplt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvAutoMsgTmplt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvAutoMsgTmplt")
					.Append("|").Append((System.Decimal)reader["SV_AUTO_MSG_TMPLT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvAutoMsgTmplt>(
					key.ToString(), // EntityTrackingKey
					"SvAutoMsgTmplt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvAutoMsgTmplt();
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
					c.SvAutoMsgTmpltId = (System.Decimal)reader["SV_AUTO_MSG_TMPLT_ID"];
					c.OriginalSvAutoMsgTmpltId = c.SvAutoMsgTmpltId;
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.MsgType = (System.String)reader["MSG_TYPE"];
					c.MsgTitleAr = (System.String)reader["MSG_TITLE_AR"];
					c.MsgTitleEn = (System.String)reader["MSG_TITLE_EN"];
					c.MsgBodyAr = (System.String)reader["MSG_BODY_AR"];
					c.MsgBodyEn = (System.String)reader["MSG_BODY_EN"];
					c.NotifyFlg = Convert.IsDBNull(reader["NOTIFY_FLG"]) ? null : (System.Int16?)reader["NOTIFY_FLG"];
					c.InboxFlg = Convert.IsDBNull(reader["INBOX_FLG"]) ? null : (System.Boolean?)reader["INBOX_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.MsgTmpltFlg = Convert.IsDBNull(reader["MSG_TMPLT_FLG"]) ? null : (System.Int16?)reader["MSG_TMPLT_FLG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvAutoMsgTmplt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvAutoMsgTmpltId = (System.Decimal)reader[((int)SvAutoMsgTmpltColumn.SvAutoMsgTmpltId - 1)];
			entity.OriginalSvAutoMsgTmpltId = (System.Decimal)reader["SV_AUTO_MSG_TMPLT_ID"];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)SvAutoMsgTmpltColumn.SeCodeUserTypeId - 1)];
			entity.MsgType = (System.String)reader[((int)SvAutoMsgTmpltColumn.MsgType - 1)];
			entity.MsgTitleAr = (System.String)reader[((int)SvAutoMsgTmpltColumn.MsgTitleAr - 1)];
			entity.MsgTitleEn = (System.String)reader[((int)SvAutoMsgTmpltColumn.MsgTitleEn - 1)];
			entity.MsgBodyAr = (System.String)reader[((int)SvAutoMsgTmpltColumn.MsgBodyAr - 1)];
			entity.MsgBodyEn = (System.String)reader[((int)SvAutoMsgTmpltColumn.MsgBodyEn - 1)];
			entity.NotifyFlg = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.NotifyFlg - 1)))?null:(System.Int16?)reader[((int)SvAutoMsgTmpltColumn.NotifyFlg - 1)];
			entity.InboxFlg = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.InboxFlg - 1)))?null:(System.Boolean?)reader[((int)SvAutoMsgTmpltColumn.InboxFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.Notes - 1)))?null:(System.String)reader[((int)SvAutoMsgTmpltColumn.Notes - 1)];
			entity.MsgTmpltFlg = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.MsgTmpltFlg - 1)))?null:(System.Int16?)reader[((int)SvAutoMsgTmpltColumn.MsgTmpltFlg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SvAutoMsgTmpltColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SvAutoMsgTmpltColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvAutoMsgTmplt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvAutoMsgTmpltId = (System.Decimal)dataRow["SV_AUTO_MSG_TMPLT_ID"];
			entity.OriginalSvAutoMsgTmpltId = (System.Decimal)dataRow["SV_AUTO_MSG_TMPLT_ID"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.MsgType = (System.String)dataRow["MSG_TYPE"];
			entity.MsgTitleAr = (System.String)dataRow["MSG_TITLE_AR"];
			entity.MsgTitleEn = (System.String)dataRow["MSG_TITLE_EN"];
			entity.MsgBodyAr = (System.String)dataRow["MSG_BODY_AR"];
			entity.MsgBodyEn = (System.String)dataRow["MSG_BODY_EN"];
			entity.NotifyFlg = Convert.IsDBNull(dataRow["NOTIFY_FLG"]) ? null : (System.Int16?)dataRow["NOTIFY_FLG"];
			entity.InboxFlg = Convert.IsDBNull(dataRow["INBOX_FLG"]) ? null : (System.Boolean?)dataRow["INBOX_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.MsgTmpltFlg = Convert.IsDBNull(dataRow["MSG_TMPLT_FLG"]) ? null : (System.Int16?)dataRow["MSG_TMPLT_FLG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvAutoMsgTmplt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvAutoMsgTmplt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvAutoMsgTmplt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource

			#region SvAutoMsgTmpltIdSource	
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepLoadType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvAutoMsgTmpltId;
				SvAutoMsgTmplt tmpEntity = EntityManager.LocateEntity<SvAutoMsgTmplt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvAutoMsgTmplt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvAutoMsgTmpltIdSource = tmpEntity;
				else
					entity.SvAutoMsgTmpltIdSource = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvAutoMsgTmpltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvAutoMsgTmpltProvider.DeepLoad(transactionManager, entity.SvAutoMsgTmpltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvAutoMsgTmpltIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvAutoMsgTmpltId methods when available
			
			#region SvMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessage>|SvMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageCollection = DataRepository.SvMessageProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);

				if (deep && entity.SvMessageCollection.Count > 0)
				{
					deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessage>) DataRepository.SvMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeAppStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeAppStatusCollection = DataRepository.AdmCdeAppStatusProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);

				if (deep && entity.AdmCdeAppStatusCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeAppStatus>) DataRepository.AdmCdeAppStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeStatus>|AdmCdeStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeStatusCollection = DataRepository.AdmCdeStatusProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);

				if (deep && entity.AdmCdeStatusCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeStatus>) DataRepository.AdmCdeStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvAutoMsgTmplt
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmplt", deepLoadType, innerList))
			{
				entity.SvAutoMsgTmplt = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmplt' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.SvAutoMsgTmplt != null)
				{
					deepHandles.Add("SvAutoMsgTmplt",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< SvAutoMsgTmplt >) DataRepository.SvAutoMsgTmpltProvider.DeepLoad,
						new object[] { transactionManager, entity.SvAutoMsgTmplt, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region SvMsgTmpltParamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMsgTmpltParam>|SvMsgTmpltParamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMsgTmpltParamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMsgTmpltParamCollection = DataRepository.SvMsgTmpltParamProvider.GetBySvAutoMsgTmpltId(transactionManager, entity.SvAutoMsgTmpltId);

				if (deep && entity.SvMsgTmpltParamCollection.Count > 0)
				{
					deepHandles.Add("SvMsgTmpltParamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMsgTmpltParam>) DataRepository.SvMsgTmpltParamProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMsgTmpltParamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvAutoMsgTmplt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvAutoMsgTmplt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvAutoMsgTmplt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvAutoMsgTmplt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			
			#region SvAutoMsgTmpltIdSource
			if (CanDeepSave(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepSaveType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource != null)
			{
				DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltIdSource);
				entity.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region SvAutoMsgTmplt
			if (CanDeepSave(entity.SvAutoMsgTmplt, "SvAutoMsgTmplt|SvAutoMsgTmplt", deepSaveType, innerList))
			{

				if (entity.SvAutoMsgTmplt != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.SvAutoMsgTmplt.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltId;
					//DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmplt);
					deepHandles.Add("SvAutoMsgTmplt",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< SvAutoMsgTmplt >) DataRepository.SvAutoMsgTmpltProvider.DeepSave,
						new object[] { transactionManager, entity.SvAutoMsgTmplt, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<SvMessage>
				if (CanDeepSave(entity.SvMessageCollection, "List<SvMessage>|SvMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessage child in entity.SvMessageCollection)
					{
						if(child.SvAutoMsgTmpltIdSource != null)
						{
							child.SvAutoMsgTmpltId = child.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
						}
						else
						{
							child.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltId;
						}

					}

					if (entity.SvMessageCollection.Count > 0 || entity.SvMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageCollection);
						
						deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessage >) DataRepository.SvMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeAppStatus>
				if (CanDeepSave(entity.AdmCdeAppStatusCollection, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeAppStatus child in entity.AdmCdeAppStatusCollection)
					{
						if(child.SvAutoMsgTmpltIdSource != null)
						{
							child.SvAutoMsgTmpltId = child.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
						}
						else
						{
							child.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltId;
						}

					}

					if (entity.AdmCdeAppStatusCollection.Count > 0 || entity.AdmCdeAppStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeAppStatusProvider.Save(transactionManager, entity.AdmCdeAppStatusCollection);
						
						deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeAppStatus >) DataRepository.AdmCdeAppStatusProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeStatus>
				if (CanDeepSave(entity.AdmCdeStatusCollection, "List<AdmCdeStatus>|AdmCdeStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeStatus child in entity.AdmCdeStatusCollection)
					{
						if(child.SvAutoMsgTmpltIdSource != null)
						{
							child.SvAutoMsgTmpltId = child.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
						}
						else
						{
							child.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltId;
						}

					}

					if (entity.AdmCdeStatusCollection.Count > 0 || entity.AdmCdeStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeStatusProvider.Save(transactionManager, entity.AdmCdeStatusCollection);
						
						deepHandles.Add("AdmCdeStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeStatus >) DataRepository.AdmCdeStatusProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeStatusCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMsgTmpltParam>
				if (CanDeepSave(entity.SvMsgTmpltParamCollection, "List<SvMsgTmpltParam>|SvMsgTmpltParamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMsgTmpltParam child in entity.SvMsgTmpltParamCollection)
					{
						if(child.SvAutoMsgTmpltIdSource != null)
						{
							child.SvAutoMsgTmpltId = child.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
						}
						else
						{
							child.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltId;
						}

					}

					if (entity.SvMsgTmpltParamCollection.Count > 0 || entity.SvMsgTmpltParamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMsgTmpltParamProvider.Save(transactionManager, entity.SvMsgTmpltParamCollection);
						
						deepHandles.Add("SvMsgTmpltParamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMsgTmpltParam >) DataRepository.SvMsgTmpltParamProvider.DeepSave,
							new object[] { transactionManager, entity.SvMsgTmpltParamCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvAutoMsgTmpltChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvAutoMsgTmplt</c>
	///</summary>
	public enum SvAutoMsgTmpltChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SvAutoMsgTmplt</c> at SvAutoMsgTmpltIdSource
		///</summary>
		[ChildEntityType(typeof(SvAutoMsgTmplt))]
		SvAutoMsgTmplt,
		///<summary>
		/// Collection of <c>SvAutoMsgTmplt</c> as OneToMany for SvMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessage>))]
		SvMessageCollection,
		///<summary>
		/// Collection of <c>SvAutoMsgTmplt</c> as OneToMany for AdmCdeAppStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeAppStatus>))]
		AdmCdeAppStatusCollection,
		///<summary>
		/// Collection of <c>SvAutoMsgTmplt</c> as OneToMany for AdmCdeStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeStatus>))]
		AdmCdeStatusCollection,
		///<summary>
		/// Collection of <c>SvAutoMsgTmplt</c> as OneToMany for SvMsgTmpltParamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMsgTmpltParam>))]
		SvMsgTmpltParamCollection,
	}
	
	#endregion SvAutoMsgTmpltChildEntityTypes
	
	#region SvAutoMsgTmpltFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvAutoMsgTmpltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvAutoMsgTmplt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvAutoMsgTmpltFilterBuilder : SqlFilterBuilder<SvAutoMsgTmpltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltFilterBuilder class.
		/// </summary>
		public SvAutoMsgTmpltFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvAutoMsgTmpltFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvAutoMsgTmpltFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvAutoMsgTmpltFilterBuilder
	
	#region SvAutoMsgTmpltParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvAutoMsgTmpltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvAutoMsgTmplt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvAutoMsgTmpltParameterBuilder : ParameterizedSqlFilterBuilder<SvAutoMsgTmpltColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltParameterBuilder class.
		/// </summary>
		public SvAutoMsgTmpltParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvAutoMsgTmpltParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvAutoMsgTmpltParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvAutoMsgTmpltParameterBuilder
	
	#region SvAutoMsgTmpltSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvAutoMsgTmpltColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvAutoMsgTmplt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvAutoMsgTmpltSortBuilder : SqlSortBuilder<SvAutoMsgTmpltColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvAutoMsgTmpltSqlSortBuilder class.
		/// </summary>
		public SvAutoMsgTmpltSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvAutoMsgTmpltSortBuilder
	
} // end namespace
