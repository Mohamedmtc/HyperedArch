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
	/// This class is the base class for any <see cref="EdTrainingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdTrainingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdTraining, UMIS_VER2.BusinessLyer.EdTrainingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainingKey key)
		{
			return Delete(transactionManager, key.EdTrainingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edTrainingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edTrainingId)
		{
			return Delete(null, _edTrainingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edTrainingId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		FK_ED_TRAINING_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		FK_ED_TRAINING_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		/// <remarks></remarks>
		public TList<EdTraining> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		FK_ED_TRAINING_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		fkEdTrainingEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		fkEdTrainingEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_ACAD_YEAR key.
		///		FK_ED_TRAINING_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public abstract TList<EdTraining> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		FK_ED_TRAINING_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		FK_ED_TRAINING_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		/// <remarks></remarks>
		public TList<EdTraining> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		FK_ED_TRAINING_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		fkEdTrainingEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		fkEdTrainingEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_ED_CODE_SEMESTER key.
		///		FK_ED_TRAINING_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public abstract TList<EdTraining> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		FK_ED_TRAINING_GS_CDE_TRAIN_SITE Description: 
		/// </summary>
		/// <param name="_gsCdeTrainSite"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByGsCdeTrainSite(System.Decimal _gsCdeTrainSite)
		{
			int count = -1;
			return GetByGsCdeTrainSite(_gsCdeTrainSite, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		FK_ED_TRAINING_GS_CDE_TRAIN_SITE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSite"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		/// <remarks></remarks>
		public TList<EdTraining> GetByGsCdeTrainSite(TransactionManager transactionManager, System.Decimal _gsCdeTrainSite)
		{
			int count = -1;
			return GetByGsCdeTrainSite(transactionManager, _gsCdeTrainSite, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		FK_ED_TRAINING_GS_CDE_TRAIN_SITE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSite"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByGsCdeTrainSite(TransactionManager transactionManager, System.Decimal _gsCdeTrainSite, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrainSite(transactionManager, _gsCdeTrainSite, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		fkEdTrainingGsCdeTrainSite Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrainSite"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByGsCdeTrainSite(System.Decimal _gsCdeTrainSite, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeTrainSite(null, _gsCdeTrainSite, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		fkEdTrainingGsCdeTrainSite Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrainSite"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public TList<EdTraining> GetByGsCdeTrainSite(System.Decimal _gsCdeTrainSite, int start, int pageLength,out int count)
		{
			return GetByGsCdeTrainSite(null, _gsCdeTrainSite, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_TRAINING_GS_CDE_TRAIN_SITE key.
		///		FK_ED_TRAINING_GS_CDE_TRAIN_SITE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSite"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdTraining objects.</returns>
		public abstract TList<EdTraining> GetByGsCdeTrainSite(TransactionManager transactionManager, System.Decimal _gsCdeTrainSite, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdTraining Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainingKey key, int start, int pageLength)
		{
			return GetByEdTrainingId(transactionManager, key.EdTrainingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(null,_edTrainingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdTrainingId(transactionManager, _edTrainingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(System.Decimal _edTrainingId, int start, int pageLength, out int count)
		{
			return GetByEdTrainingId(null, _edTrainingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TRAIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edTrainingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdTraining GetByEdTrainingId(TransactionManager transactionManager, System.Decimal _edTrainingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdTraining&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdTraining&gt;"/></returns>
		public static TList<EdTraining> Fill(IDataReader reader, TList<EdTraining> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdTraining c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdTraining")
					.Append("|").Append((System.Decimal)reader["ED_TRAINING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdTraining>(
					key.ToString(), // EntityTrackingKey
					"EdTraining",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdTraining();
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
					c.EdTrainingId = (System.Decimal)reader["ED_TRAINING_ID"];
					c.OriginalEdTrainingId = c.EdTrainingId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.GsCdeTrainSite = (System.Decimal)reader["GS_CDE_TRAIN_SITE"];
					c.MaxStudNo = Convert.IsDBNull(reader["MAX_STUD_NO"]) ? null : (System.Decimal?)reader["MAX_STUD_NO"];
					c.StartDate = Convert.IsDBNull(reader["START_DATE"]) ? null : (System.DateTime?)reader["START_DATE"];
					c.PeriodMonth = Convert.IsDBNull(reader["PERIOD_MONTH"]) ? null : (System.Decimal?)reader["PERIOD_MONTH"];
					c.PeriodDay = Convert.IsDBNull(reader["PERIOD_DAY"]) ? null : (System.Decimal?)reader["PERIOD_DAY"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdTraining entity)
		{
			if (!reader.Read()) return;
			
			entity.EdTrainingId = (System.Decimal)reader[((int)EdTrainingColumn.EdTrainingId - 1)];
			entity.OriginalEdTrainingId = (System.Decimal)reader["ED_TRAINING_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdTrainingColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdTrainingColumn.EdCodeSemesterId - 1)];
			entity.GsCdeTrainSite = (System.Decimal)reader[((int)EdTrainingColumn.GsCdeTrainSite - 1)];
			entity.MaxStudNo = (reader.IsDBNull(((int)EdTrainingColumn.MaxStudNo - 1)))?null:(System.Decimal?)reader[((int)EdTrainingColumn.MaxStudNo - 1)];
			entity.StartDate = (reader.IsDBNull(((int)EdTrainingColumn.StartDate - 1)))?null:(System.DateTime?)reader[((int)EdTrainingColumn.StartDate - 1)];
			entity.PeriodMonth = (reader.IsDBNull(((int)EdTrainingColumn.PeriodMonth - 1)))?null:(System.Decimal?)reader[((int)EdTrainingColumn.PeriodMonth - 1)];
			entity.PeriodDay = (reader.IsDBNull(((int)EdTrainingColumn.PeriodDay - 1)))?null:(System.Decimal?)reader[((int)EdTrainingColumn.PeriodDay - 1)];
			entity.EndDate = (reader.IsDBNull(((int)EdTrainingColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)EdTrainingColumn.EndDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdTraining entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdTrainingId = (System.Decimal)dataRow["ED_TRAINING_ID"];
			entity.OriginalEdTrainingId = (System.Decimal)dataRow["ED_TRAINING_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.GsCdeTrainSite = (System.Decimal)dataRow["GS_CDE_TRAIN_SITE"];
			entity.MaxStudNo = Convert.IsDBNull(dataRow["MAX_STUD_NO"]) ? null : (System.Decimal?)dataRow["MAX_STUD_NO"];
			entity.StartDate = Convert.IsDBNull(dataRow["START_DATE"]) ? null : (System.DateTime?)dataRow["START_DATE"];
			entity.PeriodMonth = Convert.IsDBNull(dataRow["PERIOD_MONTH"]) ? null : (System.Decimal?)dataRow["PERIOD_MONTH"];
			entity.PeriodDay = Convert.IsDBNull(dataRow["PERIOD_DAY"]) ? null : (System.Decimal?)dataRow["PERIOD_DAY"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdTraining"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTraining Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTraining entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

			#region GsCdeTrainSiteSource	
			if (CanDeepLoad(entity, "GsCdeTrainSite|GsCdeTrainSiteSource", deepLoadType, innerList) 
				&& entity.GsCdeTrainSiteSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeTrainSite;
				GsCdeTrainSite tmpEntity = EntityManager.LocateEntity<GsCdeTrainSite>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeTrainSite), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeTrainSiteSource = tmpEntity;
				else
					entity.GsCdeTrainSiteSource = DataRepository.GsCdeTrainSiteProvider.GetByGsCdeTrainSiteId(transactionManager, entity.GsCdeTrainSite);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrainSiteSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeTrainSiteSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeTrainSiteProvider.DeepLoad(transactionManager, entity.GsCdeTrainSiteSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeTrainSiteSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdTrainingId methods when available
			
			#region EdTrainSupervisorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainSupervisor>|EdTrainSupervisorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainSupervisorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainSupervisorCollection = DataRepository.EdTrainSupervisorProvider.GetByEdTrainingId(transactionManager, entity.EdTrainingId);

				if (deep && entity.EdTrainSupervisorCollection.Count > 0)
				{
					deepHandles.Add("EdTrainSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainSupervisor>) DataRepository.EdTrainSupervisorProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainSupervisorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainStud>|EdTrainStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainStudCollection = DataRepository.EdTrainStudProvider.GetByEdTrainingId(transactionManager, entity.EdTrainingId);

				if (deep && entity.EdTrainStudCollection.Count > 0)
				{
					deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainStud>) DataRepository.EdTrainStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdTraining object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdTraining instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdTraining Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTraining entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region GsCdeTrainSiteSource
			if (CanDeepSave(entity, "GsCdeTrainSite|GsCdeTrainSiteSource", deepSaveType, innerList) 
				&& entity.GsCdeTrainSiteSource != null)
			{
				DataRepository.GsCdeTrainSiteProvider.Save(transactionManager, entity.GsCdeTrainSiteSource);
				entity.GsCdeTrainSite = entity.GsCdeTrainSiteSource.GsCdeTrainSiteId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdTrainSupervisor>
				if (CanDeepSave(entity.EdTrainSupervisorCollection, "List<EdTrainSupervisor>|EdTrainSupervisorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainSupervisor child in entity.EdTrainSupervisorCollection)
					{
						if(child.EdTrainingIdSource != null)
						{
							child.EdTrainingId = child.EdTrainingIdSource.EdTrainingId;
						}
						else
						{
							child.EdTrainingId = entity.EdTrainingId;
						}

					}

					if (entity.EdTrainSupervisorCollection.Count > 0 || entity.EdTrainSupervisorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainSupervisorProvider.Save(transactionManager, entity.EdTrainSupervisorCollection);
						
						deepHandles.Add("EdTrainSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainSupervisor >) DataRepository.EdTrainSupervisorProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainSupervisorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTrainStud>
				if (CanDeepSave(entity.EdTrainStudCollection, "List<EdTrainStud>|EdTrainStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainStud child in entity.EdTrainStudCollection)
					{
						if(child.EdTrainingIdSource != null)
						{
							child.EdTrainingId = child.EdTrainingIdSource.EdTrainingId;
						}
						else
						{
							child.EdTrainingId = entity.EdTrainingId;
						}

					}

					if (entity.EdTrainStudCollection.Count > 0 || entity.EdTrainStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainStudProvider.Save(transactionManager, entity.EdTrainStudCollection);
						
						deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainStud >) DataRepository.EdTrainStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdTrainingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdTraining</c>
	///</summary>
	public enum EdTrainingChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>GsCdeTrainSite</c> at GsCdeTrainSiteSource
		///</summary>
		[ChildEntityType(typeof(GsCdeTrainSite))]
		GsCdeTrainSite,
		///<summary>
		/// Collection of <c>EdTraining</c> as OneToMany for EdTrainSupervisorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainSupervisor>))]
		EdTrainSupervisorCollection,
		///<summary>
		/// Collection of <c>EdTraining</c> as OneToMany for EdTrainStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainStud>))]
		EdTrainStudCollection,
	}
	
	#endregion EdTrainingChildEntityTypes
	
	#region EdTrainingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdTrainingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTraining"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainingFilterBuilder : SqlFilterBuilder<EdTrainingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainingFilterBuilder class.
		/// </summary>
		public EdTrainingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainingFilterBuilder
	
	#region EdTrainingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdTrainingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTraining"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdTrainingParameterBuilder : ParameterizedSqlFilterBuilder<EdTrainingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainingParameterBuilder class.
		/// </summary>
		public EdTrainingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdTrainingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdTrainingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdTrainingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdTrainingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdTrainingParameterBuilder
	
	#region EdTrainingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdTrainingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdTraining"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdTrainingSortBuilder : SqlSortBuilder<EdTrainingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdTrainingSqlSortBuilder class.
		/// </summary>
		public EdTrainingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdTrainingSortBuilder
	
} // end namespace
