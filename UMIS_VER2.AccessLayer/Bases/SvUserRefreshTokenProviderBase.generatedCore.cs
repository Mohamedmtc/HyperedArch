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
	/// This class is the base class for any <see cref="SvUserRefreshTokenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvUserRefreshTokenProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvUserRefreshToken, UMIS_VER2.BusinessLyer.SvUserRefreshTokenKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserRefreshTokenKey key)
		{
			return Delete(transactionManager, key.SvUserRefreshTokenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svUserRefreshTokenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svUserRefreshTokenId)
		{
			return Delete(null, _svUserRefreshTokenId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserRefreshTokenId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svUserRefreshTokenId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		FK_SV_USER_REFRESH_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		public TList<SvUserRefreshToken> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		FK_SV_USER_REFRESH_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		/// <remarks></remarks>
		public TList<SvUserRefreshToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		FK_SV_USER_REFRESH_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		public TList<SvUserRefreshToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		fkSvUserRefreshTokenSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		public TList<SvUserRefreshToken> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		fkSvUserRefreshTokenSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		public TList<SvUserRefreshToken> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_REFRESH_TOKEN_SE_USER key.
		///		FK_SV_USER_REFRESH_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserRefreshToken objects.</returns>
		public abstract TList<SvUserRefreshToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvUserRefreshToken Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserRefreshTokenKey key, int start, int pageLength)
		{
			return GetBySvUserRefreshTokenId(transactionManager, key.SvUserRefreshTokenId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(System.Decimal _svUserRefreshTokenId)
		{
			int count = -1;
			return GetBySvUserRefreshTokenId(null,_svUserRefreshTokenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(System.Decimal _svUserRefreshTokenId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserRefreshTokenId(null, _svUserRefreshTokenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(TransactionManager transactionManager, System.Decimal _svUserRefreshTokenId)
		{
			int count = -1;
			return GetBySvUserRefreshTokenId(transactionManager, _svUserRefreshTokenId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(TransactionManager transactionManager, System.Decimal _svUserRefreshTokenId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvUserRefreshTokenId(transactionManager, _svUserRefreshTokenId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(System.Decimal _svUserRefreshTokenId, int start, int pageLength, out int count)
		{
			return GetBySvUserRefreshTokenId(null, _svUserRefreshTokenId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_REFRESH_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserRefreshTokenId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvUserRefreshToken GetBySvUserRefreshTokenId(TransactionManager transactionManager, System.Decimal _svUserRefreshTokenId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvUserRefreshToken&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvUserRefreshToken&gt;"/></returns>
		public static TList<SvUserRefreshToken> Fill(IDataReader reader, TList<SvUserRefreshToken> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvUserRefreshToken c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvUserRefreshToken")
					.Append("|").Append((System.Decimal)reader["SV_USER_REFRESH_TOKEN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvUserRefreshToken>(
					key.ToString(), // EntityTrackingKey
					"SvUserRefreshToken",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvUserRefreshToken();
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
					c.SvUserRefreshTokenId = (System.Decimal)reader["SV_USER_REFRESH_TOKEN_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.Token = Convert.IsDBNull(reader["TOKEN"]) ? null : (System.String)reader["TOKEN"];
					c.UserIp = Convert.IsDBNull(reader["USER_IP"]) ? null : (System.String)reader["USER_IP"];
					c.Expire = Convert.IsDBNull(reader["EXPIRE"]) ? null : (System.String)reader["EXPIRE"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvUserRefreshToken entity)
		{
			if (!reader.Read()) return;
			
			entity.SvUserRefreshTokenId = (System.Decimal)reader[((int)SvUserRefreshTokenColumn.SvUserRefreshTokenId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)SvUserRefreshTokenColumn.SeUserId - 1)];
			entity.Token = (reader.IsDBNull(((int)SvUserRefreshTokenColumn.Token - 1)))?null:(System.String)reader[((int)SvUserRefreshTokenColumn.Token - 1)];
			entity.UserIp = (reader.IsDBNull(((int)SvUserRefreshTokenColumn.UserIp - 1)))?null:(System.String)reader[((int)SvUserRefreshTokenColumn.UserIp - 1)];
			entity.Expire = (reader.IsDBNull(((int)SvUserRefreshTokenColumn.Expire - 1)))?null:(System.String)reader[((int)SvUserRefreshTokenColumn.Expire - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SvUserRefreshTokenColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SvUserRefreshTokenColumn.LastDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)SvUserRefreshTokenColumn.Notes - 1)))?null:(System.String)reader[((int)SvUserRefreshTokenColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvUserRefreshToken entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvUserRefreshTokenId = (System.Decimal)dataRow["SV_USER_REFRESH_TOKEN_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.Token = Convert.IsDBNull(dataRow["TOKEN"]) ? null : (System.String)dataRow["TOKEN"];
			entity.UserIp = Convert.IsDBNull(dataRow["USER_IP"]) ? null : (System.String)dataRow["USER_IP"];
			entity.Expire = Convert.IsDBNull(dataRow["EXPIRE"]) ? null : (System.String)dataRow["EXPIRE"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvUserRefreshToken"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserRefreshToken Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserRefreshToken entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvUserRefreshToken object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvUserRefreshToken instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvUserRefreshToken Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserRefreshToken entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
	
	#region SvUserRefreshTokenChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvUserRefreshToken</c>
	///</summary>
	public enum SvUserRefreshTokenChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion SvUserRefreshTokenChildEntityTypes
	
	#region SvUserRefreshTokenFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvUserRefreshTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserRefreshToken"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserRefreshTokenFilterBuilder : SqlFilterBuilder<SvUserRefreshTokenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenFilterBuilder class.
		/// </summary>
		public SvUserRefreshTokenFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserRefreshTokenFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserRefreshTokenFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserRefreshTokenFilterBuilder
	
	#region SvUserRefreshTokenParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvUserRefreshTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserRefreshToken"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvUserRefreshTokenParameterBuilder : ParameterizedSqlFilterBuilder<SvUserRefreshTokenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenParameterBuilder class.
		/// </summary>
		public SvUserRefreshTokenParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvUserRefreshTokenParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvUserRefreshTokenParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvUserRefreshTokenParameterBuilder
	
	#region SvUserRefreshTokenSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvUserRefreshTokenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvUserRefreshToken"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvUserRefreshTokenSortBuilder : SqlSortBuilder<SvUserRefreshTokenColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvUserRefreshTokenSqlSortBuilder class.
		/// </summary>
		public SvUserRefreshTokenSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvUserRefreshTokenSortBuilder
	
} // end namespace
