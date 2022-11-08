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
	/// This class is the base class for any <see cref="EdStudCourseRegAssessSubProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegAssessSubProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSubKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSubKey key)
		{
			return Delete(transactionManager, key.EdStudCrsRegAssessSub);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCrsRegAssessSub)
		{
			return Delete(null, _edStudCrsRegAssessSub);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCrsRegAssessSub);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		fkEdStudCourseRegAssessSubEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		fkEdStudCourseRegAssessSubEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId">اعمال السنة--- ENUM_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public abstract TList<EdStudCourseRegAssessSub> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegAssessSubEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegAssessSubEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SUB_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub objects.</returns>
		public abstract TList<EdStudCourseRegAssessSub> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSubKey key, int start, int pageLength)
		{
			return GetByEdStudCrsRegAssessSub(transactionManager, key.EdStudCrsRegAssessSub, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(System.Decimal _edStudCrsRegAssessSub)
		{
			int count = -1;
			return GetByEdStudCrsRegAssessSub(null,_edStudCrsRegAssessSub, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(System.Decimal _edStudCrsRegAssessSub, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCrsRegAssessSub(null, _edStudCrsRegAssessSub, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(TransactionManager transactionManager, System.Decimal _edStudCrsRegAssessSub)
		{
			int count = -1;
			return GetByEdStudCrsRegAssessSub(transactionManager, _edStudCrsRegAssessSub, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(TransactionManager transactionManager, System.Decimal _edStudCrsRegAssessSub, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCrsRegAssessSub(transactionManager, _edStudCrsRegAssessSub, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(System.Decimal _edStudCrsRegAssessSub, int start, int pageLength, out int count)
		{
			return GetByEdStudCrsRegAssessSub(null, _edStudCrsRegAssessSub, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ASSESS_SUB index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCrsRegAssessSub">السلام درجات كويزات x</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub GetByEdStudCrsRegAssessSub(TransactionManager transactionManager, System.Decimal _edStudCrsRegAssessSub, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRegAssessSub&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRegAssessSub&gt;"/></returns>
		public static TList<EdStudCourseRegAssessSub> Fill(IDataReader reader, TList<EdStudCourseRegAssessSub> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRegAssessSub")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CRS_REG_ASSESS_SUB"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRegAssessSub>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRegAssessSub",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub();
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
					c.EdStudCrsRegAssessSub = (System.Decimal)reader["ED_STUD_CRS_REG_ASSESS_SUB"];
					c.OriginalEdStudCrsRegAssessSub = c.EdStudCrsRegAssessSub;
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.EdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.Quiz1 = Convert.IsDBNull(reader["QUIZ1"]) ? null : (System.Decimal?)reader["QUIZ1"];
					c.Quiz2 = Convert.IsDBNull(reader["QUIZ2"]) ? null : (System.Decimal?)reader["QUIZ2"];
					c.Quiz3 = Convert.IsDBNull(reader["QUIZ3"]) ? null : (System.Decimal?)reader["QUIZ3"];
					c.Quiz4 = Convert.IsDBNull(reader["QUIZ4"]) ? null : (System.Decimal?)reader["QUIZ4"];
					c.Quiz5 = Convert.IsDBNull(reader["QUIZ5"]) ? null : (System.Decimal?)reader["QUIZ5"];
					c.Quiz6 = Convert.IsDBNull(reader["QUIZ6"]) ? null : (System.Decimal?)reader["QUIZ6"];
					c.Quiz7 = Convert.IsDBNull(reader["QUIZ7"]) ? null : (System.Decimal?)reader["QUIZ7"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCrsRegAssessSub = (System.Decimal)reader[((int)EdStudCourseRegAssessSubColumn.EdStudCrsRegAssessSub - 1)];
			entity.OriginalEdStudCrsRegAssessSub = (System.Decimal)reader["ED_STUD_CRS_REG_ASSESS_SUB"];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseRegAssessSubColumn.EdStudCourseRegId - 1)];
			entity.EdCodeCourseAssessId = (System.Decimal)reader[((int)EdStudCourseRegAssessSubColumn.EdCodeCourseAssessId - 1)];
			entity.Quiz1 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz1 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz1 - 1)];
			entity.Quiz2 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz2 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz2 - 1)];
			entity.Quiz3 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz3 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz3 - 1)];
			entity.Quiz4 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz4 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz4 - 1)];
			entity.Quiz5 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz5 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz5 - 1)];
			entity.Quiz6 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz6 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz6 - 1)];
			entity.Quiz7 = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.Quiz7 - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.Quiz7 - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessSubColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseRegAssessSubColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegAssessSubColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCrsRegAssessSub = (System.Decimal)dataRow["ED_STUD_CRS_REG_ASSESS_SUB"];
			entity.OriginalEdStudCrsRegAssessSub = (System.Decimal)dataRow["ED_STUD_CRS_REG_ASSESS_SUB"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.Quiz1 = Convert.IsDBNull(dataRow["QUIZ1"]) ? null : (System.Decimal?)dataRow["QUIZ1"];
			entity.Quiz2 = Convert.IsDBNull(dataRow["QUIZ2"]) ? null : (System.Decimal?)dataRow["QUIZ2"];
			entity.Quiz3 = Convert.IsDBNull(dataRow["QUIZ3"]) ? null : (System.Decimal?)dataRow["QUIZ3"];
			entity.Quiz4 = Convert.IsDBNull(dataRow["QUIZ4"]) ? null : (System.Decimal?)dataRow["QUIZ4"];
			entity.Quiz5 = Convert.IsDBNull(dataRow["QUIZ5"]) ? null : (System.Decimal?)dataRow["QUIZ5"];
			entity.Quiz6 = Convert.IsDBNull(dataRow["QUIZ6"]) ? null : (System.Decimal?)dataRow["QUIZ6"];
			entity.Quiz7 = Convert.IsDBNull(dataRow["QUIZ7"]) ? null : (System.Decimal?)dataRow["QUIZ7"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseAssessId;
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegId;
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
			}
			#endregion 
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
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
	
	#region EdStudCourseRegAssessSubChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRegAssessSub</c>
	///</summary>
	public enum EdStudCourseRegAssessSubChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
	}
	
	#endregion EdStudCourseRegAssessSubChildEntityTypes
	
	#region EdStudCourseRegAssessSubFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegAssessSubColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssessSub"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAssessSubFilterBuilder : SqlFilterBuilder<EdStudCourseRegAssessSubColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubFilterBuilder class.
		/// </summary>
		public EdStudCourseRegAssessSubFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAssessSubFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAssessSubFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAssessSubFilterBuilder
	
	#region EdStudCourseRegAssessSubParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegAssessSubColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssessSub"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAssessSubParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegAssessSubColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubParameterBuilder class.
		/// </summary>
		public EdStudCourseRegAssessSubParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAssessSubParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAssessSubParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAssessSubParameterBuilder
	
	#region EdStudCourseRegAssessSubSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegAssessSubColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssessSub"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegAssessSubSortBuilder : SqlSortBuilder<EdStudCourseRegAssessSubColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSubSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegAssessSubSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegAssessSubSortBuilder
	
} // end namespace
