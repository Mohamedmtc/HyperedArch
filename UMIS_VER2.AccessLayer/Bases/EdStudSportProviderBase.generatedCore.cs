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
	/// This class is the base class for any <see cref="EdStudSportProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSportProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudSport, UMIS_VER2.BusinessLyer.EdStudSportKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSportKey key)
		{
			return Delete(transactionManager, key.EdStudSportId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudSportId)
		{
			return Delete(null, _edStudSportId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudSportId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		FK_ED_STUD_SPORT_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		FK_ED_STUD_SPORT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSport> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		FK_ED_STUD_SPORT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		fkEdStudSportEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		fkEdStudSportEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_ED_STUD key.
		///		FK_ED_STUD_SPORT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public abstract TList<EdStudSport> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE Description: 
		/// </summary>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(_gsCdeSportTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSport> GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(transactionManager, _gsCdeSportTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSportTypeId(transactionManager, _gsCdeSportTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		fkEdStudSportGsCdeSportType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSportTypeId(null, _gsCdeSportTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		fkEdStudSportGsCdeSportType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public TList<EdStudSport> GetByGsCdeSportTypeId(System.Decimal _gsCdeSportTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSportTypeId(null, _gsCdeSportTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE key.
		///		FK_ED_STUD_SPORT_GS_CDE_SPORT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSportTypeId">كود نوع اللعبة الرياضة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSport objects.</returns>
		public abstract TList<EdStudSport> GetByGsCdeSportTypeId(TransactionManager transactionManager, System.Decimal _gsCdeSportTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudSport Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSportKey key, int start, int pageLength)
		{
			return GetByEdStudSportId(transactionManager, key.EdStudSportId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(System.Decimal _edStudSportId)
		{
			int count = -1;
			return GetByEdStudSportId(null,_edStudSportId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(System.Decimal _edStudSportId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSportId(null, _edStudSportId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(TransactionManager transactionManager, System.Decimal _edStudSportId)
		{
			int count = -1;
			return GetByEdStudSportId(transactionManager, _edStudSportId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(TransactionManager transactionManager, System.Decimal _edStudSportId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSportId(transactionManager, _edStudSportId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(System.Decimal _edStudSportId, int start, int pageLength, out int count)
		{
			return GetByEdStudSportId(null, _edStudSportId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SPORT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSportId">الانشطة الرياضية للطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSport GetByEdStudSportId(TransactionManager transactionManager, System.Decimal _edStudSportId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudSport&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudSport&gt;"/></returns>
		public static TList<EdStudSport> Fill(IDataReader reader, TList<EdStudSport> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudSport c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudSport")
					.Append("|").Append((System.Decimal)reader["ED_STUD_SPORT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudSport>(
					key.ToString(), // EntityTrackingKey
					"EdStudSport",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudSport();
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
					c.EdStudSportId = (System.Decimal)reader["ED_STUD_SPORT_ID"];
					c.OriginalEdStudSportId = c.EdStudSportId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.GsCdeSportTypeId = (System.Decimal)reader["GS_CDE_SPORT_TYPE_ID"];
					c.TeamNameAr = Convert.IsDBNull(reader["TEAM_NAME_AR"]) ? null : (System.String)reader["TEAM_NAME_AR"];
					c.TournDscrAr = Convert.IsDBNull(reader["TOURN_DSCR_AR"]) ? null : (System.String)reader["TOURN_DSCR_AR"];
					c.TournDate = Convert.IsDBNull(reader["TOURN_DATE"]) ? null : (System.DateTime?)reader["TOURN_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudSport entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudSportId = (System.Decimal)reader[((int)EdStudSportColumn.EdStudSportId - 1)];
			entity.OriginalEdStudSportId = (System.Decimal)reader["ED_STUD_SPORT_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudSportColumn.EdStudId - 1)];
			entity.GsCdeSportTypeId = (System.Decimal)reader[((int)EdStudSportColumn.GsCdeSportTypeId - 1)];
			entity.TeamNameAr = (reader.IsDBNull(((int)EdStudSportColumn.TeamNameAr - 1)))?null:(System.String)reader[((int)EdStudSportColumn.TeamNameAr - 1)];
			entity.TournDscrAr = (reader.IsDBNull(((int)EdStudSportColumn.TournDscrAr - 1)))?null:(System.String)reader[((int)EdStudSportColumn.TournDscrAr - 1)];
			entity.TournDate = (reader.IsDBNull(((int)EdStudSportColumn.TournDate - 1)))?null:(System.DateTime?)reader[((int)EdStudSportColumn.TournDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudSport entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudSportId = (System.Decimal)dataRow["ED_STUD_SPORT_ID"];
			entity.OriginalEdStudSportId = (System.Decimal)dataRow["ED_STUD_SPORT_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.GsCdeSportTypeId = (System.Decimal)dataRow["GS_CDE_SPORT_TYPE_ID"];
			entity.TeamNameAr = Convert.IsDBNull(dataRow["TEAM_NAME_AR"]) ? null : (System.String)dataRow["TEAM_NAME_AR"];
			entity.TournDscrAr = Convert.IsDBNull(dataRow["TOURN_DSCR_AR"]) ? null : (System.String)dataRow["TOURN_DSCR_AR"];
			entity.TournDate = Convert.IsDBNull(dataRow["TOURN_DATE"]) ? null : (System.DateTime?)dataRow["TOURN_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSport"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSport Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSport entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCdeSportTypeIdSource	
			if (CanDeepLoad(entity, "GsCdeSportType|GsCdeSportTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSportTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeSportTypeId;
				GsCdeSportType tmpEntity = EntityManager.LocateEntity<GsCdeSportType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSportType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSportTypeIdSource = tmpEntity;
				else
					entity.GsCdeSportTypeIdSource = DataRepository.GsCdeSportTypeProvider.GetByGsCdeSportTypeId(transactionManager, entity.GsCdeSportTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSportTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSportTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSportTypeProvider.DeepLoad(transactionManager, entity.GsCdeSportTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSportTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudSport object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSport instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSport Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSport entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCdeSportTypeIdSource
			if (CanDeepSave(entity, "GsCdeSportType|GsCdeSportTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSportTypeIdSource != null)
			{
				DataRepository.GsCdeSportTypeProvider.Save(transactionManager, entity.GsCdeSportTypeIdSource);
				entity.GsCdeSportTypeId = entity.GsCdeSportTypeIdSource.GsCdeSportTypeId;
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
	
	#region EdStudSportChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudSport</c>
	///</summary>
	public enum EdStudSportChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCdeSportType</c> at GsCdeSportTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSportType))]
		GsCdeSportType,
	}
	
	#endregion EdStudSportChildEntityTypes
	
	#region EdStudSportFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudSportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSportFilterBuilder : SqlFilterBuilder<EdStudSportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSportFilterBuilder class.
		/// </summary>
		public EdStudSportFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSportFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSportFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSportFilterBuilder
	
	#region EdStudSportParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudSportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSportParameterBuilder : ParameterizedSqlFilterBuilder<EdStudSportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSportParameterBuilder class.
		/// </summary>
		public EdStudSportParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSportParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSportParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSportParameterBuilder
	
	#region EdStudSportSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudSportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSport"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSportSortBuilder : SqlSortBuilder<EdStudSportColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSportSqlSortBuilder class.
		/// </summary>
		public EdStudSportSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSportSortBuilder
	
} // end namespace
