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
	/// This class is the base class for any <see cref="EdCourseOutcomesDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseOutcomesDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtlKey key)
		{
			return Delete(transactionManager, key.EdCourseOutcomesDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseOutcomesDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseOutcomesDtlId)
		{
			return Delete(null, _edCourseOutcomesDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseOutcomesDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 Description: 
		/// </summary>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(_edCourseOutcomesTopicsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(transactionManager, _edCourseOutcomesTopicsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOutcomesTopicsId(transactionManager, _edCourseOutcomesTopicsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		fkEdCourseOutcomesDtlEdCourseOutcomesTopics1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseOutcomesTopicsId(null, _edCourseOutcomesTopicsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		fkEdCourseOutcomesDtlEdCourseOutcomesTopics1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength,out int count)
		{
			return GetByEdCourseOutcomesTopicsId(null, _edCourseOutcomesTopicsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 key.
		///		FK_ED_Course_Outcomes_DTL_ED_Course_Outcomes_Topics1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesTopicsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public abstract TList<EdCourseOutcomesDtl> GetByEdCourseOutcomesTopicsId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesTopicsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		FK_ED_Course_Outcomes_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		FK_ED_Course_Outcomes_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseOutcomesDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		FK_ED_Course_Outcomes_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		fkEdCourseOutcomesDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		fkEdCourseOutcomesDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public TList<EdCourseOutcomesDtl> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_Course_Outcomes_DTL_SE_USER key.
		///		FK_ED_Course_Outcomes_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl objects.</returns>
		public abstract TList<EdCourseOutcomesDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtlKey key, int start, int pageLength)
		{
			return GetByEdCourseOutcomesDtlId(transactionManager, key.EdCourseOutcomesDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(System.Decimal _edCourseOutcomesDtlId)
		{
			int count = -1;
			return GetByEdCourseOutcomesDtlId(null,_edCourseOutcomesDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(System.Decimal _edCourseOutcomesDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOutcomesDtlId(null, _edCourseOutcomesDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesDtlId)
		{
			int count = -1;
			return GetByEdCourseOutcomesDtlId(transactionManager, _edCourseOutcomesDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOutcomesDtlId(transactionManager, _edCourseOutcomesDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(System.Decimal _edCourseOutcomesDtlId, int start, int pageLength, out int count)
		{
			return GetByEdCourseOutcomesDtlId(null, _edCourseOutcomesDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_Course_Outcomes_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOutcomesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl GetByEdCourseOutcomesDtlId(TransactionManager transactionManager, System.Decimal _edCourseOutcomesDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseOutcomesDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseOutcomesDtl&gt;"/></returns>
		public static TList<EdCourseOutcomesDtl> Fill(IDataReader reader, TList<EdCourseOutcomesDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseOutcomesDtl")
					.Append("|").Append((System.Decimal)reader["ED_Course_Outcomes_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseOutcomesDtl>(
					key.ToString(), // EntityTrackingKey
					"EdCourseOutcomesDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl();
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
					c.EdCourseOutcomesDtlId = (System.Decimal)reader["ED_Course_Outcomes_DTL_ID"];
					c.OriginalEdCourseOutcomesDtlId = c.EdCourseOutcomesDtlId;
					c.EdCourseOutcomesTopicsId = (System.Decimal)reader["ED_Course_Outcomes_Topics_Id"];
					c.CourseObjectives = Convert.IsDBNull(reader["Course_Objectives"]) ? null : (System.String)reader["Course_Objectives"];
					c.LearningOutcomes = Convert.IsDBNull(reader["learning_Outcomes"]) ? null : (System.String)reader["learning_Outcomes"];
					c.Knowledge = Convert.IsDBNull(reader["Knowledge"]) ? null : (System.String)reader["Knowledge"];
					c.Mental = Convert.IsDBNull(reader["Mental"]) ? null : (System.String)reader["Mental"];
					c.Professionalism = Convert.IsDBNull(reader["Professionalism"]) ? null : (System.String)reader["Professionalism"];
					c.General = Convert.IsDBNull(reader["General"]) ? null : (System.String)reader["General"];
					c.CourseContent = Convert.IsDBNull(reader["Course_Content"]) ? null : (System.String)reader["Course_Content"];
					c.Week = Convert.IsDBNull(reader["Week"]) ? null : (System.String)reader["Week"];
					c.Pattern = Convert.IsDBNull(reader["Pattern"]) ? null : (System.String)reader["Pattern"];
					c.Degree = Convert.IsDBNull(reader["Degree"]) ? null : (System.Decimal?)reader["Degree"];
					c.Reference = Convert.IsDBNull(reader["Reference"]) ? null : (System.String)reader["Reference"];
					c.ReferenceType = Convert.IsDBNull(reader["Reference_Type"]) ? null : (System.String)reader["Reference_Type"];
					c.LastDate = Convert.IsDBNull(reader["Last_Date"]) ? null : (System.DateTime?)reader["Last_Date"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseOutcomesDtlId = (System.Decimal)reader[((int)EdCourseOutcomesDtlColumn.EdCourseOutcomesDtlId - 1)];
			entity.OriginalEdCourseOutcomesDtlId = (System.Decimal)reader["ED_Course_Outcomes_DTL_ID"];
			entity.EdCourseOutcomesTopicsId = (System.Decimal)reader[((int)EdCourseOutcomesDtlColumn.EdCourseOutcomesTopicsId - 1)];
			entity.CourseObjectives = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.CourseObjectives - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.CourseObjectives - 1)];
			entity.LearningOutcomes = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.LearningOutcomes - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.LearningOutcomes - 1)];
			entity.Knowledge = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Knowledge - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Knowledge - 1)];
			entity.Mental = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Mental - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Mental - 1)];
			entity.Professionalism = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Professionalism - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Professionalism - 1)];
			entity.General = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.General - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.General - 1)];
			entity.CourseContent = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.CourseContent - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.CourseContent - 1)];
			entity.Week = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Week - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Week - 1)];
			entity.Pattern = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Pattern - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Pattern - 1)];
			entity.Degree = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Degree - 1)))?null:(System.Decimal?)reader[((int)EdCourseOutcomesDtlColumn.Degree - 1)];
			entity.Reference = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.Reference - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.Reference - 1)];
			entity.ReferenceType = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.ReferenceType - 1)))?null:(System.String)reader[((int)EdCourseOutcomesDtlColumn.ReferenceType - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdCourseOutcomesDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdCourseOutcomesDtlColumn.LastDate - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)EdCourseOutcomesDtlColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseOutcomesDtlId = (System.Decimal)dataRow["ED_Course_Outcomes_DTL_ID"];
			entity.OriginalEdCourseOutcomesDtlId = (System.Decimal)dataRow["ED_Course_Outcomes_DTL_ID"];
			entity.EdCourseOutcomesTopicsId = (System.Decimal)dataRow["ED_Course_Outcomes_Topics_Id"];
			entity.CourseObjectives = Convert.IsDBNull(dataRow["Course_Objectives"]) ? null : (System.String)dataRow["Course_Objectives"];
			entity.LearningOutcomes = Convert.IsDBNull(dataRow["learning_Outcomes"]) ? null : (System.String)dataRow["learning_Outcomes"];
			entity.Knowledge = Convert.IsDBNull(dataRow["Knowledge"]) ? null : (System.String)dataRow["Knowledge"];
			entity.Mental = Convert.IsDBNull(dataRow["Mental"]) ? null : (System.String)dataRow["Mental"];
			entity.Professionalism = Convert.IsDBNull(dataRow["Professionalism"]) ? null : (System.String)dataRow["Professionalism"];
			entity.General = Convert.IsDBNull(dataRow["General"]) ? null : (System.String)dataRow["General"];
			entity.CourseContent = Convert.IsDBNull(dataRow["Course_Content"]) ? null : (System.String)dataRow["Course_Content"];
			entity.Week = Convert.IsDBNull(dataRow["Week"]) ? null : (System.String)dataRow["Week"];
			entity.Pattern = Convert.IsDBNull(dataRow["Pattern"]) ? null : (System.String)dataRow["Pattern"];
			entity.Degree = Convert.IsDBNull(dataRow["Degree"]) ? null : (System.Decimal?)dataRow["Degree"];
			entity.Reference = Convert.IsDBNull(dataRow["Reference"]) ? null : (System.String)dataRow["Reference"];
			entity.ReferenceType = Convert.IsDBNull(dataRow["Reference_Type"]) ? null : (System.String)dataRow["Reference_Type"];
			entity.LastDate = Convert.IsDBNull(dataRow["Last_Date"]) ? null : (System.DateTime?)dataRow["Last_Date"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseOutcomesTopicsIdSource	
			if (CanDeepLoad(entity, "EdCourseOutcomesTopics|EdCourseOutcomesTopicsIdSource", deepLoadType, innerList) 
				&& entity.EdCourseOutcomesTopicsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseOutcomesTopicsId;
				EdCourseOutcomesTopics tmpEntity = EntityManager.LocateEntity<EdCourseOutcomesTopics>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseOutcomesTopics), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseOutcomesTopicsIdSource = tmpEntity;
				else
					entity.EdCourseOutcomesTopicsIdSource = DataRepository.EdCourseOutcomesTopicsProvider.GetByEdCourseOutcomesTopicsId(transactionManager, entity.EdCourseOutcomesTopicsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseOutcomesTopicsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad(transactionManager, entity.EdCourseOutcomesTopicsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseOutcomesTopicsIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseOutcomesTopicsIdSource
			if (CanDeepSave(entity, "EdCourseOutcomesTopics|EdCourseOutcomesTopicsIdSource", deepSaveType, innerList) 
				&& entity.EdCourseOutcomesTopicsIdSource != null)
			{
				DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsIdSource);
				entity.EdCourseOutcomesTopicsId = entity.EdCourseOutcomesTopicsIdSource.EdCourseOutcomesTopicsId;
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
	
	#region EdCourseOutcomesDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseOutcomesDtl</c>
	///</summary>
	public enum EdCourseOutcomesDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourseOutcomesTopics</c> at EdCourseOutcomesTopicsIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseOutcomesTopics))]
		EdCourseOutcomesTopics,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion EdCourseOutcomesDtlChildEntityTypes
	
	#region EdCourseOutcomesDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseOutcomesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOutcomesDtlFilterBuilder : SqlFilterBuilder<EdCourseOutcomesDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlFilterBuilder class.
		/// </summary>
		public EdCourseOutcomesDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOutcomesDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOutcomesDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOutcomesDtlFilterBuilder
	
	#region EdCourseOutcomesDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseOutcomesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseOutcomesDtlParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseOutcomesDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlParameterBuilder class.
		/// </summary>
		public EdCourseOutcomesDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseOutcomesDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseOutcomesDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseOutcomesDtlParameterBuilder
	
	#region EdCourseOutcomesDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseOutcomesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseOutcomesDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseOutcomesDtlSortBuilder : SqlSortBuilder<EdCourseOutcomesDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseOutcomesDtlSqlSortBuilder class.
		/// </summary>
		public EdCourseOutcomesDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseOutcomesDtlSortBuilder
	
} // end namespace
