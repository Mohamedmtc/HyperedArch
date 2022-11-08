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
	/// This class is the base class for any <see cref="EdStudPnltyCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudPnltyCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudPnltyCourse, UMIS_VER2.BusinessLyer.EdStudPnltyCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudPnltyCourseKey key)
		{
			return Delete(transactionManager, key.EdStudPnltyCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudPnltyCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudPnltyCourseId)
		{
			return Delete(null, _edStudPnltyCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudPnltyCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudPnltyCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudPnltyCourse> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		fkEdStudPnltyCourseEdStudCourseReg1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		fkEdStudPnltyCourseEdStudCourseReg1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_COURSE_REG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public abstract TList<EdStudPnltyCourse> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudViolId(System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(_edStudViolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudPnltyCourse> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		fkEdStudPnltyCourseEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		fkEdStudPnltyCourseEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public TList<EdStudPnltyCourse> GetByEdStudViolId(System.Decimal _edStudViolId, int start, int pageLength,out int count)
		{
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL key.
		///		FK_ED_STUD_PNLTY_COURSE_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudPnltyCourse objects.</returns>
		public abstract TList<EdStudPnltyCourse> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal _edStudViolId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudPnltyCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudPnltyCourseKey key, int start, int pageLength)
		{
			return GetByEdStudPnltyCourseId(transactionManager, key.EdStudPnltyCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(System.Decimal _edStudPnltyCourseId)
		{
			int count = -1;
			return GetByEdStudPnltyCourseId(null,_edStudPnltyCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(System.Decimal _edStudPnltyCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudPnltyCourseId(null, _edStudPnltyCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(TransactionManager transactionManager, System.Decimal _edStudPnltyCourseId)
		{
			int count = -1;
			return GetByEdStudPnltyCourseId(transactionManager, _edStudPnltyCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(TransactionManager transactionManager, System.Decimal _edStudPnltyCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudPnltyCourseId(transactionManager, _edStudPnltyCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(System.Decimal _edStudPnltyCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudPnltyCourseId(null, _edStudPnltyCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PNLTY_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudPnltyCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudPnltyCourse GetByEdStudPnltyCourseId(TransactionManager transactionManager, System.Decimal _edStudPnltyCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudPnltyCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudPnltyCourse&gt;"/></returns>
		public static TList<EdStudPnltyCourse> Fill(IDataReader reader, TList<EdStudPnltyCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudPnltyCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudPnltyCourse")
					.Append("|").Append((System.Decimal)reader["ED_STUD_PNLTY_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudPnltyCourse>(
					key.ToString(), // EntityTrackingKey
					"EdStudPnltyCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudPnltyCourse();
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
					c.EdStudPnltyCourseId = (System.Decimal)reader["ED_STUD_PNLTY_COURSE_ID"];
					c.OriginalEdStudPnltyCourseId = c.EdStudPnltyCourseId;
					c.EdStudViolId = (System.Decimal)reader["ED_STUD_VIOL_ID"];
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.CancelRegisterationFlag = Convert.IsDBNull(reader["CANCEL_REGISTERATION_FLAG"]) ? null : (System.Decimal?)reader["CANCEL_REGISTERATION_FLAG"];
					c.FailFlag = Convert.IsDBNull(reader["FAIL_FLAG"]) ? null : (System.Decimal?)reader["FAIL_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudPnltyCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudPnltyCourseId = (System.Decimal)reader[((int)EdStudPnltyCourseColumn.EdStudPnltyCourseId - 1)];
			entity.OriginalEdStudPnltyCourseId = (System.Decimal)reader["ED_STUD_PNLTY_COURSE_ID"];
			entity.EdStudViolId = (System.Decimal)reader[((int)EdStudPnltyCourseColumn.EdStudViolId - 1)];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudPnltyCourseColumn.EdStudCourseRegId - 1)];
			entity.CancelRegisterationFlag = (reader.IsDBNull(((int)EdStudPnltyCourseColumn.CancelRegisterationFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudPnltyCourseColumn.CancelRegisterationFlag - 1)];
			entity.FailFlag = (reader.IsDBNull(((int)EdStudPnltyCourseColumn.FailFlag - 1)))?null:(System.Decimal?)reader[((int)EdStudPnltyCourseColumn.FailFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudPnltyCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudPnltyCourseId = (System.Decimal)dataRow["ED_STUD_PNLTY_COURSE_ID"];
			entity.OriginalEdStudPnltyCourseId = (System.Decimal)dataRow["ED_STUD_PNLTY_COURSE_ID"];
			entity.EdStudViolId = (System.Decimal)dataRow["ED_STUD_VIOL_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.CancelRegisterationFlag = Convert.IsDBNull(dataRow["CANCEL_REGISTERATION_FLAG"]) ? null : (System.Decimal?)dataRow["CANCEL_REGISTERATION_FLAG"];
			entity.FailFlag = Convert.IsDBNull(dataRow["FAIL_FLAG"]) ? null : (System.Decimal?)dataRow["FAIL_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudPnltyCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudPnltyCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudPnltyCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdStudViolIdSource	
			if (CanDeepLoad(entity, "EdStudViol|EdStudViolIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudViolId;
				EdStudViol tmpEntity = EntityManager.LocateEntity<EdStudViol>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolIdSource = tmpEntity;
				else
					entity.EdStudViolIdSource = DataRepository.EdStudViolProvider.GetByEdStudViolId(transactionManager, entity.EdStudViolId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolProvider.DeepLoad(transactionManager, entity.EdStudViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudPnltyCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudPnltyCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudPnltyCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudPnltyCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region EdStudViolIdSource
			if (CanDeepSave(entity, "EdStudViol|EdStudViolIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolIdSource != null)
			{
				DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolIdSource);
				entity.EdStudViolId = entity.EdStudViolIdSource.EdStudViolId;
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
	
	#region EdStudPnltyCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudPnltyCourse</c>
	///</summary>
	public enum EdStudPnltyCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>EdStudViol</c> at EdStudViolIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudViol))]
		EdStudViol,
	}
	
	#endregion EdStudPnltyCourseChildEntityTypes
	
	#region EdStudPnltyCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudPnltyCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudPnltyCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudPnltyCourseFilterBuilder : SqlFilterBuilder<EdStudPnltyCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseFilterBuilder class.
		/// </summary>
		public EdStudPnltyCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudPnltyCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudPnltyCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudPnltyCourseFilterBuilder
	
	#region EdStudPnltyCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudPnltyCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudPnltyCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudPnltyCourseParameterBuilder : ParameterizedSqlFilterBuilder<EdStudPnltyCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseParameterBuilder class.
		/// </summary>
		public EdStudPnltyCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudPnltyCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudPnltyCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudPnltyCourseParameterBuilder
	
	#region EdStudPnltyCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudPnltyCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudPnltyCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudPnltyCourseSortBuilder : SqlSortBuilder<EdStudPnltyCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudPnltyCourseSqlSortBuilder class.
		/// </summary>
		public EdStudPnltyCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudPnltyCourseSortBuilder
	
} // end namespace
