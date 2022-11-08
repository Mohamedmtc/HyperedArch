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
	/// This class is the base class for any <see cref="SpoSponsorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsor, UMIS_VER2.BusinessLyer.SpoSponsorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorKey key)
		{
			return Delete(transactionManager, key.SpoSponsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorId)
		{
			return Delete(null, _spoSponsorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		FK_SPO_SPONSOR_SPO_SPONSOR_Type Description: 
		/// </summary>
		/// <param name="_spoSponserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		public TList<SpoSponsor> GetBySpoSponserTypeId(System.Decimal? _spoSponserTypeId)
		{
			int count = -1;
			return GetBySpoSponserTypeId(_spoSponserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		FK_SPO_SPONSOR_SPO_SPONSOR_Type Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsor> GetBySpoSponserTypeId(TransactionManager transactionManager, System.Decimal? _spoSponserTypeId)
		{
			int count = -1;
			return GetBySpoSponserTypeId(transactionManager, _spoSponserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		FK_SPO_SPONSOR_SPO_SPONSOR_Type Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		public TList<SpoSponsor> GetBySpoSponserTypeId(TransactionManager transactionManager, System.Decimal? _spoSponserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponserTypeId(transactionManager, _spoSponserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		fkSpoSponsorSpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		public TList<SpoSponsor> GetBySpoSponserTypeId(System.Decimal? _spoSponserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponserTypeId(null, _spoSponserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		fkSpoSponsorSpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		public TList<SpoSponsor> GetBySpoSponserTypeId(System.Decimal? _spoSponserTypeId, int start, int pageLength,out int count)
		{
			return GetBySpoSponserTypeId(null, _spoSponserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_SPO_SPONSOR_Type key.
		///		FK_SPO_SPONSOR_SPO_SPONSOR_Type Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsor objects.</returns>
		public abstract TList<SpoSponsor> GetBySpoSponserTypeId(TransactionManager transactionManager, System.Decimal? _spoSponserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorKey key, int start, int pageLength)
		{
			return GetBySpoSponsorId(transactionManager, key.SpoSponsorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="_spoCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(System.String _spoCode)
		{
			int count = -1;
			return GetBySpoCode(null,_spoCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="_spoCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(System.String _spoCode, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoCode(null, _spoCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(TransactionManager transactionManager, System.String _spoCode)
		{
			int count = -1;
			return GetBySpoCode(transactionManager, _spoCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(TransactionManager transactionManager, System.String _spoCode, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoCode(transactionManager, _spoCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="_spoCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(System.String _spoCode, int start, int pageLength, out int count)
		{
			return GetBySpoCode(null, _spoCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SPO_SPONSOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoCode(TransactionManager transactionManager, System.String _spoCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Table_1_1 index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(null,_spoSponsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1_1 index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1_1 index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Table_1_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsor GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsor&gt;"/></returns>
		public static TList<SpoSponsor> Fill(IDataReader reader, TList<SpoSponsor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsor")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsor>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsor();
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
					c.SpoSponsorId = (System.Decimal)reader["SPO_SPONSOR_ID"];
					c.OriginalSpoSponsorId = c.SpoSponsorId;
					c.SpoCode = Convert.IsDBNull(reader["SPO_Code"]) ? null : (System.String)reader["SPO_Code"];
					c.SpoAccountCode = Convert.IsDBNull(reader["SPO_ACCOUNT_CODE"]) ? null : (System.String)reader["SPO_ACCOUNT_CODE"];
					c.NameAr = Convert.IsDBNull(reader["NAME_AR"]) ? null : (System.String)reader["NAME_AR"];
					c.NameEn = Convert.IsDBNull(reader["NAME_EN"]) ? null : (System.String)reader["NAME_EN"];
					c.Address = Convert.IsDBNull(reader["ADDRESS"]) ? null : (System.String)reader["ADDRESS"];
					c.SpoSponserTypeId = Convert.IsDBNull(reader["SPO_SPONSER_TYPE_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSER_TYPE_ID"];
					c.CoverRepeatedCoursesFlag = Convert.IsDBNull(reader["COVER_REPEATED_COURSES_FLAG"]) ? null : (System.Decimal?)reader["COVER_REPEATED_COURSES_FLAG"];
					c.OfficeTel = Convert.IsDBNull(reader["OFFICE_TEL"]) ? null : (System.String)reader["OFFICE_TEL"];
					c.Mobile = Convert.IsDBNull(reader["MOBILE"]) ? null : (System.String)reader["MOBILE"];
					c.Email = Convert.IsDBNull(reader["EMAIL"]) ? null : (System.String)reader["EMAIL"];
					c.Website = Convert.IsDBNull(reader["WEBSITE"]) ? null : (System.String)reader["WEBSITE"];
					c.UnvSponsorFlag = Convert.IsDBNull(reader["UNV_SPONSOR_FLAG"]) ? null : (System.Decimal?)reader["UNV_SPONSOR_FLAG"];
					c.FeeSponsorFlag = Convert.IsDBNull(reader["FEE_SPONSOR_FLAG"]) ? null : (System.Decimal?)reader["FEE_SPONSOR_FLAG"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.SpoFeeBalance = Convert.IsDBNull(reader["SPO_FEE_BALANCE"]) ? null : (System.Decimal?)reader["SPO_FEE_BALANCE"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsor entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorId = (System.Decimal)reader[((int)SpoSponsorColumn.SpoSponsorId - 1)];
			entity.OriginalSpoSponsorId = (System.Decimal)reader["SPO_SPONSOR_ID"];
			entity.SpoCode = (reader.IsDBNull(((int)SpoSponsorColumn.SpoCode - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.SpoCode - 1)];
			entity.SpoAccountCode = (reader.IsDBNull(((int)SpoSponsorColumn.SpoAccountCode - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.SpoAccountCode - 1)];
			entity.NameAr = (reader.IsDBNull(((int)SpoSponsorColumn.NameAr - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.NameAr - 1)];
			entity.NameEn = (reader.IsDBNull(((int)SpoSponsorColumn.NameEn - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.NameEn - 1)];
			entity.Address = (reader.IsDBNull(((int)SpoSponsorColumn.Address - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.Address - 1)];
			entity.SpoSponserTypeId = (reader.IsDBNull(((int)SpoSponsorColumn.SpoSponserTypeId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.SpoSponserTypeId - 1)];
			entity.CoverRepeatedCoursesFlag = (reader.IsDBNull(((int)SpoSponsorColumn.CoverRepeatedCoursesFlag - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.CoverRepeatedCoursesFlag - 1)];
			entity.OfficeTel = (reader.IsDBNull(((int)SpoSponsorColumn.OfficeTel - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.OfficeTel - 1)];
			entity.Mobile = (reader.IsDBNull(((int)SpoSponsorColumn.Mobile - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.Mobile - 1)];
			entity.Email = (reader.IsDBNull(((int)SpoSponsorColumn.Email - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.Email - 1)];
			entity.Website = (reader.IsDBNull(((int)SpoSponsorColumn.Website - 1)))?null:(System.String)reader[((int)SpoSponsorColumn.Website - 1)];
			entity.UnvSponsorFlag = (reader.IsDBNull(((int)SpoSponsorColumn.UnvSponsorFlag - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.UnvSponsorFlag - 1)];
			entity.FeeSponsorFlag = (reader.IsDBNull(((int)SpoSponsorColumn.FeeSponsorFlag - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.FeeSponsorFlag - 1)];
			entity.IsActive = (reader.IsDBNull(((int)SpoSponsorColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)SpoSponsorColumn.IsActive - 1)];
			entity.SpoFeeBalance = (reader.IsDBNull(((int)SpoSponsorColumn.SpoFeeBalance - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.SpoFeeBalance - 1)];
			entity.EnumId = (reader.IsDBNull(((int)SpoSponsorColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)SpoSponsorColumn.EnumId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoSponsorColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoSponsorColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorId = (System.Decimal)dataRow["SPO_SPONSOR_ID"];
			entity.OriginalSpoSponsorId = (System.Decimal)dataRow["SPO_SPONSOR_ID"];
			entity.SpoCode = Convert.IsDBNull(dataRow["SPO_Code"]) ? null : (System.String)dataRow["SPO_Code"];
			entity.SpoAccountCode = Convert.IsDBNull(dataRow["SPO_ACCOUNT_CODE"]) ? null : (System.String)dataRow["SPO_ACCOUNT_CODE"];
			entity.NameAr = Convert.IsDBNull(dataRow["NAME_AR"]) ? null : (System.String)dataRow["NAME_AR"];
			entity.NameEn = Convert.IsDBNull(dataRow["NAME_EN"]) ? null : (System.String)dataRow["NAME_EN"];
			entity.Address = Convert.IsDBNull(dataRow["ADDRESS"]) ? null : (System.String)dataRow["ADDRESS"];
			entity.SpoSponserTypeId = Convert.IsDBNull(dataRow["SPO_SPONSER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSER_TYPE_ID"];
			entity.CoverRepeatedCoursesFlag = Convert.IsDBNull(dataRow["COVER_REPEATED_COURSES_FLAG"]) ? null : (System.Decimal?)dataRow["COVER_REPEATED_COURSES_FLAG"];
			entity.OfficeTel = Convert.IsDBNull(dataRow["OFFICE_TEL"]) ? null : (System.String)dataRow["OFFICE_TEL"];
			entity.Mobile = Convert.IsDBNull(dataRow["MOBILE"]) ? null : (System.String)dataRow["MOBILE"];
			entity.Email = Convert.IsDBNull(dataRow["EMAIL"]) ? null : (System.String)dataRow["EMAIL"];
			entity.Website = Convert.IsDBNull(dataRow["WEBSITE"]) ? null : (System.String)dataRow["WEBSITE"];
			entity.UnvSponsorFlag = Convert.IsDBNull(dataRow["UNV_SPONSOR_FLAG"]) ? null : (System.Decimal?)dataRow["UNV_SPONSOR_FLAG"];
			entity.FeeSponsorFlag = Convert.IsDBNull(dataRow["FEE_SPONSOR_FLAG"]) ? null : (System.Decimal?)dataRow["FEE_SPONSOR_FLAG"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.SpoFeeBalance = Convert.IsDBNull(dataRow["SPO_FEE_BALANCE"]) ? null : (System.Decimal?)dataRow["SPO_FEE_BALANCE"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SpoSponserTypeIdSource	
			if (CanDeepLoad(entity, "SpoSponsorType|SpoSponserTypeIdSource", deepLoadType, innerList) 
				&& entity.SpoSponserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponserTypeId ?? 0.0m);
				SpoSponsorType tmpEntity = EntityManager.LocateEntity<SpoSponsorType>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponserTypeIdSource = tmpEntity;
				else
					entity.SpoSponserTypeIdSource = DataRepository.SpoSponsorTypeProvider.GetBySpoSponsorTypeId(transactionManager, (entity.SpoSponserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorTypeProvider.DeepLoad(transactionManager, entity.SpoSponserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponserTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoSponsorId methods when available
			
			#region FeeInvoiceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoice>|FeeInvoiceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceCollection = DataRepository.FeeInvoiceProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.FeeInvoiceCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoice>) DataRepository.FeeInvoiceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoResponsiblePersonCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoResponsiblePerson>|SpoResponsiblePersonCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoResponsiblePersonCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoResponsiblePersonCollection = DataRepository.SpoResponsiblePersonProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.SpoResponsiblePersonCollection.Count > 0)
				{
					deepHandles.Add("SpoResponsiblePersonCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoResponsiblePerson>) DataRepository.SpoResponsiblePersonProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoResponsiblePersonCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollection = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.SpoSponsorOfferCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoDepartmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoDepartment>|SpoDepartmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoDepartmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoDepartmentCollection = DataRepository.SpoDepartmentProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.SpoDepartmentCollection.Count > 0)
				{
					deepHandles.Add("SpoDepartmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoDepartment>) DataRepository.SpoDepartmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoDepartmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoContactCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoContact>|SpoContactCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoContactCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoContactCollection = DataRepository.SpoContactProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.SpoContactCollection.Count > 0)
				{
					deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoContact>) DataRepository.SpoContactProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoContactCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmScholorshipCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmScholorship>|AdmScholorshipCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmScholorshipCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmScholorshipCollection = DataRepository.AdmScholorshipProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);

				if (deep && entity.AdmScholorshipCollection.Count > 0)
				{
					deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmScholorship>) DataRepository.AdmScholorshipProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmScholorshipCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SpoSponserTypeIdSource
			if (CanDeepSave(entity, "SpoSponsorType|SpoSponserTypeIdSource", deepSaveType, innerList) 
				&& entity.SpoSponserTypeIdSource != null)
			{
				DataRepository.SpoSponsorTypeProvider.Save(transactionManager, entity.SpoSponserTypeIdSource);
				entity.SpoSponserTypeId = entity.SpoSponserTypeIdSource.SpoSponsorTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeInvoice>
				if (CanDeepSave(entity.FeeInvoiceCollection, "List<FeeInvoice>|FeeInvoiceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoice child in entity.FeeInvoiceCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.FeeInvoiceCollection.Count > 0 || entity.FeeInvoiceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceCollection);
						
						deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoice >) DataRepository.FeeInvoiceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoResponsiblePerson>
				if (CanDeepSave(entity.SpoResponsiblePersonCollection, "List<SpoResponsiblePerson>|SpoResponsiblePersonCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoResponsiblePerson child in entity.SpoResponsiblePersonCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.SpoResponsiblePersonCollection.Count > 0 || entity.SpoResponsiblePersonCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoResponsiblePersonProvider.Save(transactionManager, entity.SpoResponsiblePersonCollection);
						
						deepHandles.Add("SpoResponsiblePersonCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoResponsiblePerson >) DataRepository.SpoResponsiblePersonProvider.DeepSave,
							new object[] { transactionManager, entity.SpoResponsiblePersonCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollection, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.SpoSponsorOfferCollection.Count > 0 || entity.SpoSponsorOfferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollection);
						
						deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoDepartment>
				if (CanDeepSave(entity.SpoDepartmentCollection, "List<SpoDepartment>|SpoDepartmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoDepartment child in entity.SpoDepartmentCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.SpoDepartmentCollection.Count > 0 || entity.SpoDepartmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoDepartmentProvider.Save(transactionManager, entity.SpoDepartmentCollection);
						
						deepHandles.Add("SpoDepartmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoDepartment >) DataRepository.SpoDepartmentProvider.DeepSave,
							new object[] { transactionManager, entity.SpoDepartmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoContact>
				if (CanDeepSave(entity.SpoContactCollection, "List<SpoContact>|SpoContactCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoContact child in entity.SpoContactCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.SpoContactCollection.Count > 0 || entity.SpoContactCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoContactProvider.Save(transactionManager, entity.SpoContactCollection);
						
						deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoContact >) DataRepository.SpoContactProvider.DeepSave,
							new object[] { transactionManager, entity.SpoContactCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmScholorship>
				if (CanDeepSave(entity.AdmScholorshipCollection, "List<AdmScholorship>|AdmScholorshipCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmScholorship child in entity.AdmScholorshipCollection)
					{
						if(child.SpoSponsorIdSource != null)
						{
							child.SpoSponsorId = child.SpoSponsorIdSource.SpoSponsorId;
						}
						else
						{
							child.SpoSponsorId = entity.SpoSponsorId;
						}

					}

					if (entity.AdmScholorshipCollection.Count > 0 || entity.AdmScholorshipCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmScholorshipProvider.Save(transactionManager, entity.AdmScholorshipCollection);
						
						deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmScholorship >) DataRepository.AdmScholorshipProvider.DeepSave,
							new object[] { transactionManager, entity.AdmScholorshipCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoSponsorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsor</c>
	///</summary>
	public enum SpoSponsorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SpoSponsorType</c> at SpoSponserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorType))]
		SpoSponsorType,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for FeeInvoiceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoice>))]
		FeeInvoiceCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for SpoResponsiblePersonCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoResponsiblePerson>))]
		SpoResponsiblePersonCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for SpoDepartmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoDepartment>))]
		SpoDepartmentCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for SpoContactCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoContact>))]
		SpoContactCollection,
		///<summary>
		/// Collection of <c>SpoSponsor</c> as OneToMany for AdmScholorshipCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmScholorship>))]
		AdmScholorshipCollection,
	}
	
	#endregion SpoSponsorChildEntityTypes
	
	#region SpoSponsorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorFilterBuilder : SqlFilterBuilder<SpoSponsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFilterBuilder class.
		/// </summary>
		public SpoSponsorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorFilterBuilder
	
	#region SpoSponsorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorParameterBuilder class.
		/// </summary>
		public SpoSponsorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorParameterBuilder
	
	#region SpoSponsorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorSortBuilder : SqlSortBuilder<SpoSponsorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorSqlSortBuilder class.
		/// </summary>
		public SpoSponsorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorSortBuilder
	
} // end namespace
