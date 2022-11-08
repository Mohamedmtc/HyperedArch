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
	/// This class is the base class for any <see cref="EntPlcyAcadWarnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPlcyAcadWarnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPlcyAcadWarn, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnKey key)
		{
			return Delete(transactionManager, key.EntPlcyAcadWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPlcyAcadWarnId)
		{
			return Delete(null, _entPlcyAcadWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		FK_ENT_POLICY_ACAD_WARN_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		public TList<EntPlcyAcadWarn> GetByEdBylawId(System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		FK_ENT_POLICY_ACAD_WARN_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		/// <remarks></remarks>
		public TList<EntPlcyAcadWarn> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		FK_ENT_POLICY_ACAD_WARN_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		public TList<EntPlcyAcadWarn> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		fkEntPolicyAcadWarnEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		public TList<EntPlcyAcadWarn> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		fkEntPolicyAcadWarnEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		public TList<EntPlcyAcadWarn> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ACAD_WARN_ED_BYLAW key.
		///		FK_ENT_POLICY_ACAD_WARN_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarn objects.</returns>
		public abstract TList<EntPlcyAcadWarn> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPlcyAcadWarn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnKey key, int start, int pageLength)
		{
			return GetByEntPlcyAcadWarnId(transactionManager, key.EntPlcyAcadWarnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(null,_entPlcyAcadWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(null, _entPlcyAcadWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(transactionManager, _entPlcyAcadWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(transactionManager, _entPlcyAcadWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId, int start, int pageLength, out int count)
		{
			return GetByEntPlcyAcadWarnId(null, _entPlcyAcadWarnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ACAD_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId">قواعد  عامة على كل الانذارات الاكاديمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPlcyAcadWarn GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPlcyAcadWarn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPlcyAcadWarn&gt;"/></returns>
		public static TList<EntPlcyAcadWarn> Fill(IDataReader reader, TList<EntPlcyAcadWarn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPlcyAcadWarn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPlcyAcadWarn")
					.Append("|").Append((System.Decimal)reader["ENT_PLCY_ACAD_WARN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPlcyAcadWarn>(
					key.ToString(), // EntityTrackingKey
					"EntPlcyAcadWarn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPlcyAcadWarn();
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
					c.EntPlcyAcadWarnId = (System.Decimal)reader["ENT_PLCY_ACAD_WARN_ID"];
					c.OriginalEntPlcyAcadWarnId = c.EntPlcyAcadWarnId;
					c.EdBylawId = (System.Decimal)reader["ED_BYLAW_ID"];
					c.StartSemCount = (System.Decimal)reader["START_SEM_COUNT"];
					c.StartSemCountTrns = (System.Decimal)reader["START_SEM_COUNT_TRNS"];
					c.OptionalSemFlg = (System.Decimal)reader["OPTIONAL_SEM_FLG"];
					c.OrientSemFlg = (System.Decimal)reader["ORIENT_SEM_FLG"];
					c.MaxAcadWarn = Convert.IsDBNull(reader["MAX_ACAD_WARN"]) ? null : (System.Decimal?)reader["MAX_ACAD_WARN"];
					c.MaxAcadWarnSep = Convert.IsDBNull(reader["MAX_ACAD_WARN_SEP"]) ? null : (System.Decimal?)reader["MAX_ACAD_WARN_SEP"];
					c.ChAchvPercent = Convert.IsDBNull(reader["CH_ACHV_PERCENT"]) ? null : (System.Decimal?)reader["CH_ACHV_PERCENT"];
					c.Cgpa = Convert.IsDBNull(reader["CGPA"]) ? null : (System.Decimal?)reader["CGPA"];
					c.Gpa = Convert.IsDBNull(reader["GPA"]) ? null : (System.Decimal?)reader["GPA"];
					c.RegCh = Convert.IsDBNull(reader["REG_CH"]) ? null : (System.Int32?)reader["REG_CH"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPlcyAcadWarn entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPlcyAcadWarnId = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.EntPlcyAcadWarnId - 1)];
			entity.OriginalEntPlcyAcadWarnId = (System.Decimal)reader["ENT_PLCY_ACAD_WARN_ID"];
			entity.EdBylawId = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.EdBylawId - 1)];
			entity.StartSemCount = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.StartSemCount - 1)];
			entity.StartSemCountTrns = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.StartSemCountTrns - 1)];
			entity.OptionalSemFlg = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.OptionalSemFlg - 1)];
			entity.OrientSemFlg = (System.Decimal)reader[((int)EntPlcyAcadWarnColumn.OrientSemFlg - 1)];
			entity.MaxAcadWarn = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.MaxAcadWarn - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.MaxAcadWarn - 1)];
			entity.MaxAcadWarnSep = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.MaxAcadWarnSep - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.MaxAcadWarnSep - 1)];
			entity.ChAchvPercent = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.ChAchvPercent - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.ChAchvPercent - 1)];
			entity.Cgpa = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.Cgpa - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.Cgpa - 1)];
			entity.Gpa = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.Gpa - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.Gpa - 1)];
			entity.RegCh = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.RegCh - 1)))?null:(System.Int32?)reader[((int)EntPlcyAcadWarnColumn.RegCh - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntPlcyAcadWarnColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntPlcyAcadWarnColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPlcyAcadWarn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPlcyAcadWarnId = (System.Decimal)dataRow["ENT_PLCY_ACAD_WARN_ID"];
			entity.OriginalEntPlcyAcadWarnId = (System.Decimal)dataRow["ENT_PLCY_ACAD_WARN_ID"];
			entity.EdBylawId = (System.Decimal)dataRow["ED_BYLAW_ID"];
			entity.StartSemCount = (System.Decimal)dataRow["START_SEM_COUNT"];
			entity.StartSemCountTrns = (System.Decimal)dataRow["START_SEM_COUNT_TRNS"];
			entity.OptionalSemFlg = (System.Decimal)dataRow["OPTIONAL_SEM_FLG"];
			entity.OrientSemFlg = (System.Decimal)dataRow["ORIENT_SEM_FLG"];
			entity.MaxAcadWarn = Convert.IsDBNull(dataRow["MAX_ACAD_WARN"]) ? null : (System.Decimal?)dataRow["MAX_ACAD_WARN"];
			entity.MaxAcadWarnSep = Convert.IsDBNull(dataRow["MAX_ACAD_WARN_SEP"]) ? null : (System.Decimal?)dataRow["MAX_ACAD_WARN_SEP"];
			entity.ChAchvPercent = Convert.IsDBNull(dataRow["CH_ACHV_PERCENT"]) ? null : (System.Decimal?)dataRow["CH_ACHV_PERCENT"];
			entity.Cgpa = Convert.IsDBNull(dataRow["CGPA"]) ? null : (System.Decimal?)dataRow["CGPA"];
			entity.Gpa = Convert.IsDBNull(dataRow["GPA"]) ? null : (System.Decimal?)dataRow["GPA"];
			entity.RegCh = Convert.IsDBNull(dataRow["REG_CH"]) ? null : (System.Int32?)dataRow["REG_CH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPlcyAcadWarn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdBylawId;
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPlcyAcadWarnId methods when available
			
			#region EntPlcyAcadWarnDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPlcyAcadWarnDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPlcyAcadWarnDtlCollection = DataRepository.EntPlcyAcadWarnDtlProvider.GetByEntPlcyAcadWarnId(transactionManager, entity.EntPlcyAcadWarnId);

				if (deep && entity.EntPlcyAcadWarnDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPlcyAcadWarnDtl>) DataRepository.EntPlcyAcadWarnDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPlcyAcadWarn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPlcyAcadWarn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPlcyAcadWarn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPlcyAcadWarnDtl>
				if (CanDeepSave(entity.EntPlcyAcadWarnDtlCollection, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPlcyAcadWarnDtl child in entity.EntPlcyAcadWarnDtlCollection)
					{
						if(child.EntPlcyAcadWarnIdSource != null)
						{
							child.EntPlcyAcadWarnId = child.EntPlcyAcadWarnIdSource.EntPlcyAcadWarnId;
						}
						else
						{
							child.EntPlcyAcadWarnId = entity.EntPlcyAcadWarnId;
						}

					}

					if (entity.EntPlcyAcadWarnDtlCollection.Count > 0 || entity.EntPlcyAcadWarnDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPlcyAcadWarnDtlProvider.Save(transactionManager, entity.EntPlcyAcadWarnDtlCollection);
						
						deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPlcyAcadWarnDtl >) DataRepository.EntPlcyAcadWarnDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPlcyAcadWarnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPlcyAcadWarn</c>
	///</summary>
	public enum EntPlcyAcadWarnChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		///<summary>
		/// Collection of <c>EntPlcyAcadWarn</c> as OneToMany for EntPlcyAcadWarnDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPlcyAcadWarnDtl>))]
		EntPlcyAcadWarnDtlCollection,
	}
	
	#endregion EntPlcyAcadWarnChildEntityTypes
	
	#region EntPlcyAcadWarnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPlcyAcadWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPlcyAcadWarnFilterBuilder : SqlFilterBuilder<EntPlcyAcadWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnFilterBuilder class.
		/// </summary>
		public EntPlcyAcadWarnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPlcyAcadWarnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPlcyAcadWarnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPlcyAcadWarnFilterBuilder
	
	#region EntPlcyAcadWarnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPlcyAcadWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPlcyAcadWarnParameterBuilder : ParameterizedSqlFilterBuilder<EntPlcyAcadWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnParameterBuilder class.
		/// </summary>
		public EntPlcyAcadWarnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPlcyAcadWarnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPlcyAcadWarnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPlcyAcadWarnParameterBuilder
	
	#region EntPlcyAcadWarnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPlcyAcadWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPlcyAcadWarnSortBuilder : SqlSortBuilder<EntPlcyAcadWarnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnSqlSortBuilder class.
		/// </summary>
		public EntPlcyAcadWarnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPlcyAcadWarnSortBuilder
	
} // end namespace
