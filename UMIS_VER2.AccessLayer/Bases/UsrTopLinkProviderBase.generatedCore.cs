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
	/// This class is the base class for any <see cref="UsrTopLinkProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class UsrTopLinkProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.UsrTopLink, UMIS_VER2.BusinessLyer.UsrTopLinkKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.UsrTopLinkKey key)
		{
			return Delete(transactionManager, key.UsrTopLinkId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_usrTopLinkId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _usrTopLinkId)
		{
			return Delete(null, _usrTopLinkId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usrTopLinkId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _usrTopLinkId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		FK_USR_TOP_LINK_SE_ACCNT Description: 
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		public TList<UsrTopLink> GetBySeAccntId(System.Decimal? _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(_seAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		FK_USR_TOP_LINK_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		/// <remarks></remarks>
		public TList<UsrTopLink> GetBySeAccntId(TransactionManager transactionManager, System.Decimal? _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		FK_USR_TOP_LINK_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		public TList<UsrTopLink> GetBySeAccntId(TransactionManager transactionManager, System.Decimal? _seAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		fkUsrTopLinkSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		public TList<UsrTopLink> GetBySeAccntId(System.Decimal? _seAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeAccntId(null, _seAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		fkUsrTopLinkSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		public TList<UsrTopLink> GetBySeAccntId(System.Decimal? _seAccntId, int start, int pageLength,out int count)
		{
			return GetBySeAccntId(null, _seAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_USR_TOP_LINK_SE_ACCNT key.
		///		FK_USR_TOP_LINK_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.UsrTopLink objects.</returns>
		public abstract TList<UsrTopLink> GetBySeAccntId(TransactionManager transactionManager, System.Decimal? _seAccntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.UsrTopLink Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.UsrTopLinkKey key, int start, int pageLength)
		{
			return GetByUsrTopLinkId(transactionManager, key.UsrTopLinkId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(null,_seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public abstract TList<UsrTopLink> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public TList<UsrTopLink> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;UsrTopLink&gt;"/> class.</returns>
		public abstract TList<UsrTopLink> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="_usrTopLinkId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(System.Decimal _usrTopLinkId)
		{
			int count = -1;
			return GetByUsrTopLinkId(null,_usrTopLinkId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="_usrTopLinkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(System.Decimal _usrTopLinkId, int start, int pageLength)
		{
			int count = -1;
			return GetByUsrTopLinkId(null, _usrTopLinkId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usrTopLinkId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(TransactionManager transactionManager, System.Decimal _usrTopLinkId)
		{
			int count = -1;
			return GetByUsrTopLinkId(transactionManager, _usrTopLinkId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usrTopLinkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(TransactionManager transactionManager, System.Decimal _usrTopLinkId, int start, int pageLength)
		{
			int count = -1;
			return GetByUsrTopLinkId(transactionManager, _usrTopLinkId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="_usrTopLinkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(System.Decimal _usrTopLinkId, int start, int pageLength, out int count)
		{
			return GetByUsrTopLinkId(null, _usrTopLinkId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_USR_TOP_LINK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usrTopLinkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.UsrTopLink GetByUsrTopLinkId(TransactionManager transactionManager, System.Decimal _usrTopLinkId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;UsrTopLink&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;UsrTopLink&gt;"/></returns>
		public static TList<UsrTopLink> Fill(IDataReader reader, TList<UsrTopLink> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.UsrTopLink c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("UsrTopLink")
					.Append("|").Append((System.Decimal)reader["USR_TOP_LINK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<UsrTopLink>(
					key.ToString(), // EntityTrackingKey
					"UsrTopLink",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.UsrTopLink();
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
					c.UsrTopLinkId = (System.Decimal)reader["USR_TOP_LINK_ID"];
					c.OriginalUsrTopLinkId = c.UsrTopLinkId;
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.SeAccntId = Convert.IsDBNull(reader["SE_ACCNT_ID"]) ? null : (System.Decimal?)reader["SE_ACCNT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.UsrTopLink entity)
		{
			if (!reader.Read()) return;
			
			entity.UsrTopLinkId = (System.Decimal)reader[((int)UsrTopLinkColumn.UsrTopLinkId - 1)];
			entity.OriginalUsrTopLinkId = (System.Decimal)reader["USR_TOP_LINK_ID"];
			entity.SeFormId = (System.Decimal)reader[((int)UsrTopLinkColumn.SeFormId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)UsrTopLinkColumn.SeUserId - 1)];
			entity.SeAccntId = (reader.IsDBNull(((int)UsrTopLinkColumn.SeAccntId - 1)))?null:(System.Decimal?)reader[((int)UsrTopLinkColumn.SeAccntId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.UsrTopLink entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.UsrTopLinkId = (System.Decimal)dataRow["USR_TOP_LINK_ID"];
			entity.OriginalUsrTopLinkId = (System.Decimal)dataRow["USR_TOP_LINK_ID"];
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.SeAccntId = Convert.IsDBNull(dataRow["SE_ACCNT_ID"]) ? null : (System.Decimal?)dataRow["SE_ACCNT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.UsrTopLink"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.UsrTopLink Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.UsrTopLink entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeAccntIdSource	
			if (CanDeepLoad(entity, "SeAccnt|SeAccntIdSource", deepLoadType, innerList) 
				&& entity.SeAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeAccntId ?? 0.0m);
				SeAccnt tmpEntity = EntityManager.LocateEntity<SeAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeAccntIdSource = tmpEntity;
				else
					entity.SeAccntIdSource = DataRepository.SeAccntProvider.GetBySeAccntId(transactionManager, (entity.SeAccntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeAccntProvider.DeepLoad(transactionManager, entity.SeAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeAccntIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormId;
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.UsrTopLink object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.UsrTopLink instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.UsrTopLink Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.UsrTopLink entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeAccntIdSource
			if (CanDeepSave(entity, "SeAccnt|SeAccntIdSource", deepSaveType, innerList) 
				&& entity.SeAccntIdSource != null)
			{
				DataRepository.SeAccntProvider.Save(transactionManager, entity.SeAccntIdSource);
				entity.SeAccntId = entity.SeAccntIdSource.SeAccntId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
	
	#region UsrTopLinkChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.UsrTopLink</c>
	///</summary>
	public enum UsrTopLinkChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeAccnt</c> at SeAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeAccnt))]
		SeAccnt,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion UsrTopLinkChildEntityTypes
	
	#region UsrTopLinkFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;UsrTopLinkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UsrTopLink"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UsrTopLinkFilterBuilder : SqlFilterBuilder<UsrTopLinkColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkFilterBuilder class.
		/// </summary>
		public UsrTopLinkFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UsrTopLinkFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UsrTopLinkFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UsrTopLinkFilterBuilder
	
	#region UsrTopLinkParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;UsrTopLinkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UsrTopLink"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UsrTopLinkParameterBuilder : ParameterizedSqlFilterBuilder<UsrTopLinkColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkParameterBuilder class.
		/// </summary>
		public UsrTopLinkParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UsrTopLinkParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UsrTopLinkParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UsrTopLinkParameterBuilder
	
	#region UsrTopLinkSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;UsrTopLinkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UsrTopLink"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class UsrTopLinkSortBuilder : SqlSortBuilder<UsrTopLinkColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UsrTopLinkSqlSortBuilder class.
		/// </summary>
		public UsrTopLinkSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion UsrTopLinkSortBuilder
	
} // end namespace
