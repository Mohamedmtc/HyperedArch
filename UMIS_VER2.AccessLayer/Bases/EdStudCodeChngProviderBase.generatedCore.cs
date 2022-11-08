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
	/// This class is the base class for any <see cref="EdStudCodeChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCodeChngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCodeChng, UMIS_VER2.BusinessLyer.EdStudCodeChngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChngKey key)
		{
			return Delete(transactionManager, key.EdStudCodeChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCodeChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCodeChngId)
		{
			return Delete(null, _edStudCodeChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCodeChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCodeChngId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		FK_ED_STUD_CODE_CHNG_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		public TList<EdStudCodeChng> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		FK_ED_STUD_CODE_CHNG_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCodeChng> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		FK_ED_STUD_CODE_CHNG_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		public TList<EdStudCodeChng> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		fkEdStudCodeChngEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		public TList<EdStudCodeChng> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		fkEdStudCodeChngEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		public TList<EdStudCodeChng> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CODE_CHNG_ED_STUD key.
		///		FK_ED_STUD_CODE_CHNG_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCodeChng objects.</returns>
		public abstract TList<EdStudCodeChng> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCodeChng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChngKey key, int start, int pageLength)
		{
			return GetByEdStudCodeChngId(transactionManager, key.EdStudCodeChngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_edStudCodeChngId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(System.Decimal _edStudCodeChngId)
		{
			int count = -1;
			return GetByEdStudCodeChngId(null,_edStudCodeChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_edStudCodeChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(System.Decimal _edStudCodeChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCodeChngId(null, _edStudCodeChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCodeChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(TransactionManager transactionManager, System.Decimal _edStudCodeChngId)
		{
			int count = -1;
			return GetByEdStudCodeChngId(transactionManager, _edStudCodeChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCodeChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(TransactionManager transactionManager, System.Decimal _edStudCodeChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCodeChngId(transactionManager, _edStudCodeChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_edStudCodeChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(System.Decimal _edStudCodeChngId, int start, int pageLength, out int count)
		{
			return GetByEdStudCodeChngId(null, _edStudCodeChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCodeChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCodeChng GetByEdStudCodeChngId(TransactionManager transactionManager, System.Decimal _edStudCodeChngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(System.String _newStudCode, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByNewStudCodeEdStudId(null,_newStudCode, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(System.String _newStudCode, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByNewStudCodeEdStudId(null, _newStudCode, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(TransactionManager transactionManager, System.String _newStudCode, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByNewStudCodeEdStudId(transactionManager, _newStudCode, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(TransactionManager transactionManager, System.String _newStudCode, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByNewStudCodeEdStudId(transactionManager, _newStudCode, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(System.String _newStudCode, System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByNewStudCodeEdStudId(null, _newStudCode, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CODE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_newStudCode"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCodeChng GetByNewStudCodeEdStudId(TransactionManager transactionManager, System.String _newStudCode, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCodeChng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCodeChng&gt;"/></returns>
		public static TList<EdStudCodeChng> Fill(IDataReader reader, TList<EdStudCodeChng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCodeChng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCodeChng")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CODE_CHNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCodeChng>(
					key.ToString(), // EntityTrackingKey
					"EdStudCodeChng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCodeChng();
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
					c.EdStudCodeChngId = (System.Decimal)reader["ED_STUD_CODE_CHNG_ID"];
					c.OriginalEdStudCodeChngId = c.EdStudCodeChngId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.OldStudCode = Convert.IsDBNull(reader["OLD_STUD_CODE"]) ? null : (System.String)reader["OLD_STUD_CODE"];
					c.NewStudCode = Convert.IsDBNull(reader["NEW_STUD_CODE"]) ? null : (System.String)reader["NEW_STUD_CODE"];
					c.ChngDate = Convert.IsDBNull(reader["CHNG_DATE"]) ? null : (System.DateTime?)reader["CHNG_DATE"];
					c.Reason = Convert.IsDBNull(reader["REASON"]) ? null : (System.String)reader["REASON"];
					c.IsLast = (System.Int32)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCodeChng entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCodeChngId = (System.Decimal)reader[((int)EdStudCodeChngColumn.EdStudCodeChngId - 1)];
			entity.OriginalEdStudCodeChngId = (System.Decimal)reader["ED_STUD_CODE_CHNG_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudCodeChngColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudCodeChngColumn.EdStudId - 1)];
			entity.OldStudCode = (reader.IsDBNull(((int)EdStudCodeChngColumn.OldStudCode - 1)))?null:(System.String)reader[((int)EdStudCodeChngColumn.OldStudCode - 1)];
			entity.NewStudCode = (reader.IsDBNull(((int)EdStudCodeChngColumn.NewStudCode - 1)))?null:(System.String)reader[((int)EdStudCodeChngColumn.NewStudCode - 1)];
			entity.ChngDate = (reader.IsDBNull(((int)EdStudCodeChngColumn.ChngDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCodeChngColumn.ChngDate - 1)];
			entity.Reason = (reader.IsDBNull(((int)EdStudCodeChngColumn.Reason - 1)))?null:(System.String)reader[((int)EdStudCodeChngColumn.Reason - 1)];
			entity.IsLast = (System.Int32)reader[((int)EdStudCodeChngColumn.IsLast - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudCodeChngColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudCodeChngColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCodeChng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCodeChngId = (System.Decimal)dataRow["ED_STUD_CODE_CHNG_ID"];
			entity.OriginalEdStudCodeChngId = (System.Decimal)dataRow["ED_STUD_CODE_CHNG_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.OldStudCode = Convert.IsDBNull(dataRow["OLD_STUD_CODE"]) ? null : (System.String)dataRow["OLD_STUD_CODE"];
			entity.NewStudCode = Convert.IsDBNull(dataRow["NEW_STUD_CODE"]) ? null : (System.String)dataRow["NEW_STUD_CODE"];
			entity.ChngDate = Convert.IsDBNull(dataRow["CHNG_DATE"]) ? null : (System.DateTime?)dataRow["CHNG_DATE"];
			entity.Reason = Convert.IsDBNull(dataRow["REASON"]) ? null : (System.String)dataRow["REASON"];
			entity.IsLast = (System.Int32)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCodeChng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCodeChng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCodeChng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCodeChng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCodeChng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdStudCodeChngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCodeChng</c>
	///</summary>
	public enum EdStudCodeChngChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion EdStudCodeChngChildEntityTypes
	
	#region EdStudCodeChngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCodeChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCodeChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCodeChngFilterBuilder : SqlFilterBuilder<EdStudCodeChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngFilterBuilder class.
		/// </summary>
		public EdStudCodeChngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCodeChngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCodeChngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCodeChngFilterBuilder
	
	#region EdStudCodeChngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCodeChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCodeChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCodeChngParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCodeChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngParameterBuilder class.
		/// </summary>
		public EdStudCodeChngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCodeChngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCodeChngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCodeChngParameterBuilder
	
	#region EdStudCodeChngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCodeChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCodeChng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCodeChngSortBuilder : SqlSortBuilder<EdStudCodeChngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCodeChngSqlSortBuilder class.
		/// </summary>
		public EdStudCodeChngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCodeChngSortBuilder
	
} // end namespace
