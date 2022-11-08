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
	/// This class is the base class for any <see cref="SvUserMobTokenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvUserMobTokenProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvUserMobToken, UMIS_VER2.BusinessLyer.SvUserMobTokenKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobTokenKey key)
		{
			return Delete(transactionManager, key.SvUserMobTokenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svUserMobTokenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svUserMobTokenId)
		{
			return Delete(null, _svUserMobTokenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMobTokenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svUserMobTokenId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserMobToken> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		fkSvUserMobTokenGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		fkSvUserMobTokenGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public abstract TList<SvUserMobToken> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		FK_SV_USER_MOB_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		FK_SV_USER_MOB_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserMobToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		FK_SV_USER_MOB_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		fkSvUserMobTokenSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		fkSvUserMobTokenSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		FK_SV_USER_MOB_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public abstract TList<SvUserMobToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE Description: 
		/// </summary>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySvCdeDeviceTypeId(System.Int32? _svCdeDeviceTypeId)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(_svCdeDeviceTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserMobToken> GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32? _svCdeDeviceTypeId)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(transactionManager, _svCdeDeviceTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32? _svCdeDeviceTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeDeviceTypeId(transactionManager, _svCdeDeviceTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		fkSvUserMobTokenSvCdeDeviceType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySvCdeDeviceTypeId(System.Int32? _svCdeDeviceTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeDeviceTypeId(null, _svCdeDeviceTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		fkSvUserMobTokenSvCdeDeviceType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public TList<SvUserMobToken> GetBySvCdeDeviceTypeId(System.Int32? _svCdeDeviceTypeId, int start, int pageLength,out int count)
		{
			return GetBySvCdeDeviceTypeId(null, _svCdeDeviceTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public abstract TList<SvUserMobToken> GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32? _svCdeDeviceTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvUserMobToken Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobTokenKey key, int start, int pageLength)
		{
			return GetBySvUserMobTokenId(transactionManager, key.SvUserMobTokenId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="_svUserMobTokenId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(System.Decimal _svUserMobTokenId)
		{
			int count = -1;
			return GetBySvUserMobTokenId(null,_svUserMobTokenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="_svUserMobTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(System.Decimal _svUserMobTokenId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserMobTokenId(null, _svUserMobTokenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMobTokenId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(TransactionManager transactionManager, System.Decimal _svUserMobTokenId)
		{
			int count = -1;
			return GetBySvUserMobTokenId(transactionManager, _svUserMobTokenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMobTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(TransactionManager transactionManager, System.Decimal _svUserMobTokenId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserMobTokenId(transactionManager, _svUserMobTokenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="_svUserMobTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(System.Decimal _svUserMobTokenId, int start, int pageLength, out int count)
		{
			return GetBySvUserMobTokenId(null, _svUserMobTokenId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMobTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(TransactionManager transactionManager, System.Decimal _svUserMobTokenId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvUserMobToken&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvUserMobToken&gt;"/></returns>
		public static TList<SvUserMobToken> Fill(IDataReader reader, TList<SvUserMobToken> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvUserMobToken c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvUserMobToken")
					.Append("|").Append((System.Decimal)reader["SV_USER_MOB_TOKEN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvUserMobToken>(
					key.ToString(), // EntityTrackingKey
					"SvUserMobToken",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvUserMobToken();
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
					c.SvUserMobTokenId = (System.Decimal)reader["SV_USER_MOB_TOKEN_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.Token = Convert.IsDBNull(reader["TOKEN"]) ? null : (System.String)reader["TOKEN"];
					c.UserIp = Convert.IsDBNull(reader["USER_IP"]) ? null : (System.String)reader["USER_IP"];
					c.SvCdeDeviceTypeId = Convert.IsDBNull(reader["SV_CDE_DEVICE_TYPE_ID"]) ? null : (System.Int32?)reader["SV_CDE_DEVICE_TYPE_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvUserMobToken entity)
		{
			if (!reader.Read()) return;
			
			entity.SvUserMobTokenId = (System.Decimal)reader[((int)SvUserMobTokenColumn.SvUserMobTokenId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)SvUserMobTokenColumn.SeUserId - 1)];
			entity.Token = (reader.IsDBNull(((int)SvUserMobTokenColumn.Token - 1)))?null:(System.String)reader[((int)SvUserMobTokenColumn.Token - 1)];
			entity.UserIp = (reader.IsDBNull(((int)SvUserMobTokenColumn.UserIp - 1)))?null:(System.String)reader[((int)SvUserMobTokenColumn.UserIp - 1)];
			entity.SvCdeDeviceTypeId = (reader.IsDBNull(((int)SvUserMobTokenColumn.SvCdeDeviceTypeId - 1)))?null:(System.Int32?)reader[((int)SvUserMobTokenColumn.SvCdeDeviceTypeId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SvUserMobTokenColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SvUserMobTokenColumn.LastDate - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)SvUserMobTokenColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)SvUserMobTokenColumn.GsCodeLanguageId - 1)];
			entity.Notes = (reader.IsDBNull(((int)SvUserMobTokenColumn.Notes - 1)))?null:(System.String)reader[((int)SvUserMobTokenColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvUserMobToken entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvUserMobTokenId = (System.Decimal)dataRow["SV_USER_MOB_TOKEN_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.Token = Convert.IsDBNull(dataRow["TOKEN"]) ? null : (System.String)dataRow["TOKEN"];
			entity.UserIp = Convert.IsDBNull(dataRow["USER_IP"]) ? null : (System.String)dataRow["USER_IP"];
			entity.SvCdeDeviceTypeId = Convert.IsDBNull(dataRow["SV_CDE_DEVICE_TYPE_ID"]) ? null : (System.Int32?)dataRow["SV_CDE_DEVICE_TYPE_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserMobToken Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobToken entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource

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

			#region SvCdeDeviceTypeIdSource	
			if (CanDeepLoad(entity, "SvCdeDeviceType|SvCdeDeviceTypeIdSource", deepLoadType, innerList) 
				&& entity.SvCdeDeviceTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeDeviceTypeId ?? (int)0);
				SvCdeDeviceType tmpEntity = EntityManager.LocateEntity<SvCdeDeviceType>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeDeviceType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeDeviceTypeIdSource = tmpEntity;
				else
					entity.SvCdeDeviceTypeIdSource = DataRepository.SvCdeDeviceTypeProvider.GetBySvCdeDeviceTypeId(transactionManager, (entity.SvCdeDeviceTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeDeviceTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeDeviceTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeDeviceTypeProvider.DeepLoad(transactionManager, entity.SvCdeDeviceTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeDeviceTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvUserMobToken object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvUserMobToken instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserMobToken Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobToken entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
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
			
			#region SvCdeDeviceTypeIdSource
			if (CanDeepSave(entity, "SvCdeDeviceType|SvCdeDeviceTypeIdSource", deepSaveType, innerList) 
				&& entity.SvCdeDeviceTypeIdSource != null)
			{
				DataRepository.SvCdeDeviceTypeProvider.Save(transactionManager, entity.SvCdeDeviceTypeIdSource);
				entity.SvCdeDeviceTypeId = entity.SvCdeDeviceTypeIdSource.SvCdeDeviceTypeId;
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
	
	#region SvUserMobTokenChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvUserMobToken</c>
	///</summary>
	public enum SvUserMobTokenChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>SvCdeDeviceType</c> at SvCdeDeviceTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeDeviceType))]
		SvCdeDeviceType,
	}
	
	#endregion SvUserMobTokenChildEntityTypes
	
	#region SvUserMobTokenFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvUserMobTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMobToken"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserMobTokenFilterBuilder : SqlFilterBuilder<SvUserMobTokenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenFilterBuilder class.
		/// </summary>
		public SvUserMobTokenFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserMobTokenFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserMobTokenFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserMobTokenFilterBuilder
	
	#region SvUserMobTokenParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvUserMobTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMobToken"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserMobTokenParameterBuilder : ParameterizedSqlFilterBuilder<SvUserMobTokenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenParameterBuilder class.
		/// </summary>
		public SvUserMobTokenParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserMobTokenParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserMobTokenParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserMobTokenParameterBuilder
	
	#region SvUserMobTokenSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvUserMobTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserMobToken"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvUserMobTokenSortBuilder : SqlSortBuilder<SvUserMobTokenColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserMobTokenSqlSortBuilder class.
		/// </summary>
		public SvUserMobTokenSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvUserMobTokenSortBuilder
	
} // end namespace
