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
	/// This class is the base class for any <see cref="EntPolicyGradingLevelCoursesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingLevelCoursesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCoursesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCoursesKey key)
		{
			return Delete(transactionManager, key.EntPolicyGradingLevelCoursesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyGradingLevelCoursesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyGradingLevelCoursesId)
		{
			return Delete(null, _entPolicyGradingLevelCoursesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelCoursesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelCoursesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingLevelCourses> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		fkEntPolicyGradingLevelCoursesEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		fkEntPolicyGradingLevelCoursesEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public abstract TList<EntPolicyGradingLevelCourses> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL Description: 
		/// </summary>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(_entPolicyGradingLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(transactionManager, _entPolicyGradingLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelId(transactionManager, _entPolicyGradingLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		fkEntPolicyGradingLevelCoursesEntPolicyGradingLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyGradingLevelId(null, _entPolicyGradingLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		fkEntPolicyGradingLevelCoursesEntPolicyGradingLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(System.Decimal _entPolicyGradingLevelId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyGradingLevelId(null, _entPolicyGradingLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL key.
		///		FK_ENT_POLICY_GRADING_LEVEL_COURSES_ENT_POLICY_GRADING_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses objects.</returns>
		public abstract TList<EntPolicyGradingLevelCourses> GetByEntPolicyGradingLevelId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCoursesKey key, int start, int pageLength)
		{
			return GetByEntPolicyGradingLevelCoursesId(transactionManager, key.EntPolicyGradingLevelCoursesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(System.Decimal _entPolicyGradingLevelCoursesId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelCoursesId(null,_entPolicyGradingLevelCoursesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(System.Decimal _entPolicyGradingLevelCoursesId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelCoursesId(null, _entPolicyGradingLevelCoursesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelCoursesId)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelCoursesId(transactionManager, _entPolicyGradingLevelCoursesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelCoursesId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingLevelCoursesId(transactionManager, _entPolicyGradingLevelCoursesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(System.Decimal _entPolicyGradingLevelCoursesId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingLevelCoursesId(null, _entPolicyGradingLevelCoursesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_LEVEL_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingLevelCoursesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses GetByEntPolicyGradingLevelCoursesId(TransactionManager transactionManager, System.Decimal _entPolicyGradingLevelCoursesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyGradingLevelCourses&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyGradingLevelCourses&gt;"/></returns>
		public static TList<EntPolicyGradingLevelCourses> Fill(IDataReader reader, TList<EntPolicyGradingLevelCourses> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyGradingLevelCourses")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_COURSES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyGradingLevelCourses>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyGradingLevelCourses",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses();
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
					c.EntPolicyGradingLevelCoursesId = (System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_COURSES_ID"];
					c.OriginalEntPolicyGradingLevelCoursesId = c.EntPolicyGradingLevelCoursesId;
					c.EntPolicyGradingLevelId = (System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.Percentage = (System.Decimal)reader["Percentage"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyGradingLevelCoursesId = (System.Decimal)reader[((int)EntPolicyGradingLevelCoursesColumn.EntPolicyGradingLevelCoursesId - 1)];
			entity.OriginalEntPolicyGradingLevelCoursesId = (System.Decimal)reader["ENT_POLICY_GRADING_LEVEL_COURSES_ID"];
			entity.EntPolicyGradingLevelId = (System.Decimal)reader[((int)EntPolicyGradingLevelCoursesColumn.EntPolicyGradingLevelId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EntPolicyGradingLevelCoursesColumn.EdCourseId - 1)];
			entity.Percentage = (System.Decimal)reader[((int)EntPolicyGradingLevelCoursesColumn.Percentage - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntPolicyGradingLevelCoursesColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingLevelCoursesColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntPolicyGradingLevelCoursesColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntPolicyGradingLevelCoursesColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyGradingLevelCoursesId = (System.Decimal)dataRow["ENT_POLICY_GRADING_LEVEL_COURSES_ID"];
			entity.OriginalEntPolicyGradingLevelCoursesId = (System.Decimal)dataRow["ENT_POLICY_GRADING_LEVEL_COURSES_ID"];
			entity.EntPolicyGradingLevelId = (System.Decimal)dataRow["ENT_POLICY_GRADING_LEVEL_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.Percentage = (System.Decimal)dataRow["Percentage"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntPolicyGradingLevelIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingLevel|EntPolicyGradingLevelIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyGradingLevelId;
				EntPolicyGradingLevel tmpEntity = EntityManager.LocateEntity<EntPolicyGradingLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingLevelIdSource = tmpEntity;
				else
					entity.EntPolicyGradingLevelIdSource = DataRepository.EntPolicyGradingLevelProvider.GetByEntPolicyGradingLevelId(transactionManager, entity.EntPolicyGradingLevelId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyGradingLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyGradingLevelProvider.DeepLoad(transactionManager, entity.EntPolicyGradingLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyGradingLevelIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EntPolicyGradingLevelIdSource
			if (CanDeepSave(entity, "EntPolicyGradingLevel|EntPolicyGradingLevelIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyGradingLevelIdSource != null)
			{
				DataRepository.EntPolicyGradingLevelProvider.Save(transactionManager, entity.EntPolicyGradingLevelIdSource);
				entity.EntPolicyGradingLevelId = entity.EntPolicyGradingLevelIdSource.EntPolicyGradingLevelId;
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
	
	#region EntPolicyGradingLevelCoursesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyGradingLevelCourses</c>
	///</summary>
	public enum EntPolicyGradingLevelCoursesChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntPolicyGradingLevel</c> at EntPolicyGradingLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyGradingLevel))]
		EntPolicyGradingLevel,
	}
	
	#endregion EntPolicyGradingLevelCoursesChildEntityTypes
	
	#region EntPolicyGradingLevelCoursesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyGradingLevelCoursesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevelCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingLevelCoursesFilterBuilder : SqlFilterBuilder<EntPolicyGradingLevelCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesFilterBuilder class.
		/// </summary>
		public EntPolicyGradingLevelCoursesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingLevelCoursesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingLevelCoursesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingLevelCoursesFilterBuilder
	
	#region EntPolicyGradingLevelCoursesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyGradingLevelCoursesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevelCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingLevelCoursesParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyGradingLevelCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesParameterBuilder class.
		/// </summary>
		public EntPolicyGradingLevelCoursesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingLevelCoursesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingLevelCoursesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingLevelCoursesParameterBuilder
	
	#region EntPolicyGradingLevelCoursesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyGradingLevelCoursesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingLevelCourses"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyGradingLevelCoursesSortBuilder : SqlSortBuilder<EntPolicyGradingLevelCoursesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingLevelCoursesSqlSortBuilder class.
		/// </summary>
		public EntPolicyGradingLevelCoursesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyGradingLevelCoursesSortBuilder
	
} // end namespace
