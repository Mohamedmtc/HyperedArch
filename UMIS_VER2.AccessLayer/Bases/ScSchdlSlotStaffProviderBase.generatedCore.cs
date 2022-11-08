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
	/// This class is the base class for any <see cref="ScSchdlSlotStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlSlotStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSchdlSlotStaff, UMIS_VER2.BusinessLyer.ScSchdlSlotStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotStaffKey key)
		{
			return Delete(transactionManager, key.ScSchdlSlotStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSchdlSlotStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSchdlSlotStaffId)
		{
			return Delete(null, _scSchdlSlotStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSchdlSlotStaffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlotStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		fkScSchdlSlotStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		fkScSchdlSlotStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER key.
		///		FK_SC_SCHDL_SLOT_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public abstract TList<ScSchdlSlotStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetByScSchdlSlotId(System.Decimal _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(_scSchdlSlotId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlotStaff> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		fkScSchdlSlotStaffScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetByScSchdlSlotId(System.Decimal _scSchdlSlotId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		fkScSchdlSlotStaffScSchdlSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public TList<ScSchdlSlotStaff> GetByScSchdlSlotId(System.Decimal _scSchdlSlotId, int start, int pageLength,out int count)
		{
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT key.
		///		FK_SC_SCHDL_SLOT_STAFF_SC_SCHDL_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">جدول مجموعة طلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlotStaff objects.</returns>
		public abstract TList<ScSchdlSlotStaff> GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSchdlSlotStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotStaffKey key, int start, int pageLength)
		{
			return GetByScSchdlSlotStaffId(transactionManager, key.ScSchdlSlotStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(System.Decimal _scSchdlSlotStaffId)
		{
			int count = -1;
			return GetByScSchdlSlotStaffId(null,_scSchdlSlotStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(System.Decimal _scSchdlSlotStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotStaffId(null, _scSchdlSlotStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(TransactionManager transactionManager, System.Decimal _scSchdlSlotStaffId)
		{
			int count = -1;
			return GetByScSchdlSlotStaffId(transactionManager, _scSchdlSlotStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(TransactionManager transactionManager, System.Decimal _scSchdlSlotStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotStaffId(transactionManager, _scSchdlSlotStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(System.Decimal _scSchdlSlotStaffId, int start, int pageLength, out int count)
		{
			return GetByScSchdlSlotStaffId(null, _scSchdlSlotStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSchdlSlotStaff GetByScSchdlSlotStaffId(TransactionManager transactionManager, System.Decimal _scSchdlSlotStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSchdlSlotStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSchdlSlotStaff&gt;"/></returns>
		public static TList<ScSchdlSlotStaff> Fill(IDataReader reader, TList<ScSchdlSlotStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSchdlSlotStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSchdlSlotStaff")
					.Append("|").Append((System.Decimal)reader["SC_SCHDL_SLOT_STAFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSchdlSlotStaff>(
					key.ToString(), // EntityTrackingKey
					"ScSchdlSlotStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSchdlSlotStaff();
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
					c.ScSchdlSlotStaffId = (System.Decimal)reader["SC_SCHDL_SLOT_STAFF_ID"];
					c.OriginalScSchdlSlotStaffId = c.ScSchdlSlotStaffId;
					c.ScSchdlSlotId = (System.Decimal)reader["SC_SCHDL_SLOT_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.StfRoleFlg = Convert.IsDBNull(reader["STF_ROLE_FLG"]) ? null : (System.Decimal?)reader["STF_ROLE_FLG"];
					c.NoHours = Convert.IsDBNull(reader["NO_HOURS"]) ? null : (System.Decimal?)reader["NO_HOURS"];
					c.ExtLoadFlg = Convert.IsDBNull(reader["EXT_LOAD_FLG"]) ? null : (System.Decimal?)reader["EXT_LOAD_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSchdlSlotStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSchdlSlotStaffId = (System.Decimal)reader[((int)ScSchdlSlotStaffColumn.ScSchdlSlotStaffId - 1)];
			entity.OriginalScSchdlSlotStaffId = (System.Decimal)reader["SC_SCHDL_SLOT_STAFF_ID"];
			entity.ScSchdlSlotId = (System.Decimal)reader[((int)ScSchdlSlotStaffColumn.ScSchdlSlotId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)ScSchdlSlotStaffColumn.SaStfMemberId - 1)];
			entity.StfRoleFlg = (reader.IsDBNull(((int)ScSchdlSlotStaffColumn.StfRoleFlg - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotStaffColumn.StfRoleFlg - 1)];
			entity.NoHours = (reader.IsDBNull(((int)ScSchdlSlotStaffColumn.NoHours - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotStaffColumn.NoHours - 1)];
			entity.ExtLoadFlg = (reader.IsDBNull(((int)ScSchdlSlotStaffColumn.ExtLoadFlg - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotStaffColumn.ExtLoadFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScSchdlSlotStaffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScSchdlSlotStaffColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScSchdlSlotStaffColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotStaffColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSchdlSlotStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSchdlSlotStaffId = (System.Decimal)dataRow["SC_SCHDL_SLOT_STAFF_ID"];
			entity.OriginalScSchdlSlotStaffId = (System.Decimal)dataRow["SC_SCHDL_SLOT_STAFF_ID"];
			entity.ScSchdlSlotId = (System.Decimal)dataRow["SC_SCHDL_SLOT_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.StfRoleFlg = Convert.IsDBNull(dataRow["STF_ROLE_FLG"]) ? null : (System.Decimal?)dataRow["STF_ROLE_FLG"];
			entity.NoHours = Convert.IsDBNull(dataRow["NO_HOURS"]) ? null : (System.Decimal?)dataRow["NO_HOURS"];
			entity.ExtLoadFlg = Convert.IsDBNull(dataRow["EXT_LOAD_FLG"]) ? null : (System.Decimal?)dataRow["EXT_LOAD_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlotStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlSlotStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region ScSchdlSlotIdSource	
			if (CanDeepLoad(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScSchdlSlotId;
				ScSchdlSlot tmpEntity = EntityManager.LocateEntity<ScSchdlSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlSlotIdSource = tmpEntity;
				else
					entity.ScSchdlSlotIdSource = DataRepository.ScSchdlSlotProvider.GetByScSchdlSlotId(transactionManager, entity.ScSchdlSlotId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlSlotProvider.DeepLoad(transactionManager, entity.ScSchdlSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlSlotIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSchdlSlotStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSchdlSlotStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlSlotStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region ScSchdlSlotIdSource
			if (CanDeepSave(entity, "ScSchdlSlot|ScSchdlSlotIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlSlotIdSource != null)
			{
				DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotIdSource);
				entity.ScSchdlSlotId = entity.ScSchdlSlotIdSource.ScSchdlSlotId;
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
	
	#region ScSchdlSlotStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSchdlSlotStaff</c>
	///</summary>
	public enum ScSchdlSlotStaffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>ScSchdlSlot</c> at ScSchdlSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlSlot))]
		ScSchdlSlot,
	}
	
	#endregion ScSchdlSlotStaffChildEntityTypes
	
	#region ScSchdlSlotStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSchdlSlotStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlotStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlSlotStaffFilterBuilder : SqlFilterBuilder<ScSchdlSlotStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffFilterBuilder class.
		/// </summary>
		public ScSchdlSlotStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlSlotStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlSlotStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlSlotStaffFilterBuilder
	
	#region ScSchdlSlotStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSchdlSlotStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlotStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlSlotStaffParameterBuilder : ParameterizedSqlFilterBuilder<ScSchdlSlotStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffParameterBuilder class.
		/// </summary>
		public ScSchdlSlotStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlSlotStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlSlotStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlSlotStaffParameterBuilder
	
	#region ScSchdlSlotStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSchdlSlotStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlotStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSchdlSlotStaffSortBuilder : SqlSortBuilder<ScSchdlSlotStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotStaffSqlSortBuilder class.
		/// </summary>
		public ScSchdlSlotStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSchdlSlotStaffSortBuilder
	
} // end namespace
