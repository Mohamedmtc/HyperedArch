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
	/// This class is the base class for any <see cref="CoExamPlaceStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamPlaceStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamPlaceStud, UMIS_VER2.BusinessLyer.CoExamPlaceStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPlaceStudKey key)
		{
			return Delete(transactionManager, key.CoExamPlaceStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamPlaceStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamPlaceStudId)
		{
			return Delete(null, _coExamPlaceStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPlaceStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamPlaceStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(_coExamSchdlPlaceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		fkCoExamCommStudCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		fkCoExamCommStudCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength,out int count)
		{
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_EXAM_COMM_STUD_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public abstract TList<CoExamPlaceStud> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamPlaceStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		fkCoExamCommStudEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		fkCoExamCommStudEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public TList<CoExamPlaceStud> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER key.
		///		FK_CO_EXAM_COMM_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamPlaceStud objects.</returns>
		public abstract TList<CoExamPlaceStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoExamPlaceStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPlaceStudKey key, int start, int pageLength)
		{
			return GetByCoExamPlaceStudId(transactionManager, key.CoExamPlaceStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="_coExamPlaceStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(System.Decimal _coExamPlaceStudId)
		{
			int count = -1;
			return GetByCoExamPlaceStudId(null,_coExamPlaceStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="_coExamPlaceStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(System.Decimal _coExamPlaceStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamPlaceStudId(null, _coExamPlaceStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPlaceStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(TransactionManager transactionManager, System.Decimal _coExamPlaceStudId)
		{
			int count = -1;
			return GetByCoExamPlaceStudId(transactionManager, _coExamPlaceStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPlaceStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(TransactionManager transactionManager, System.Decimal _coExamPlaceStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamPlaceStudId(transactionManager, _coExamPlaceStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="_coExamPlaceStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(System.Decimal _coExamPlaceStudId, int start, int pageLength, out int count)
		{
			return GetByCoExamPlaceStudId(null, _coExamPlaceStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_COMM_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamPlaceStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamPlaceStud GetByCoExamPlaceStudId(TransactionManager transactionManager, System.Decimal _coExamPlaceStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamPlaceStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamPlaceStud&gt;"/></returns>
		public static TList<CoExamPlaceStud> Fill(IDataReader reader, TList<CoExamPlaceStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamPlaceStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamPlaceStud")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_PLACE_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamPlaceStud>(
					key.ToString(), // EntityTrackingKey
					"CoExamPlaceStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamPlaceStud();
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
					c.CoExamPlaceStudId = (System.Decimal)reader["CO_EXAM_PLACE_STUD_ID"];
					c.OriginalCoExamPlaceStudId = c.CoExamPlaceStudId;
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.CoExamSchdlPlaceId = (System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"];
					c.StudScrtNum = Convert.IsDBNull(reader["STUD_SCRT_NUM"]) ? null : (System.String)reader["STUD_SCRT_NUM"];
					c.StudSeatNum = Convert.IsDBNull(reader["STUD_SEAT_NUM"]) ? null : (System.String)reader["STUD_SEAT_NUM"];
					c.AutoFlg = Convert.IsDBNull(reader["AUTO_FLG"]) ? null : (System.Boolean?)reader["AUTO_FLG"];
					c.ExamVersionNo = Convert.IsDBNull(reader["EXAM_VERSION_NO"]) ? null : (System.Int32?)reader["EXAM_VERSION_NO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamPlaceStud entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamPlaceStudId = (System.Decimal)reader[((int)CoExamPlaceStudColumn.CoExamPlaceStudId - 1)];
			entity.OriginalCoExamPlaceStudId = (System.Decimal)reader["CO_EXAM_PLACE_STUD_ID"];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)CoExamPlaceStudColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)CoExamPlaceStudColumn.EdStudSemesterId - 1)];
			entity.CoExamSchdlPlaceId = (System.Decimal)reader[((int)CoExamPlaceStudColumn.CoExamSchdlPlaceId - 1)];
			entity.StudScrtNum = (reader.IsDBNull(((int)CoExamPlaceStudColumn.StudScrtNum - 1)))?null:(System.String)reader[((int)CoExamPlaceStudColumn.StudScrtNum - 1)];
			entity.StudSeatNum = (reader.IsDBNull(((int)CoExamPlaceStudColumn.StudSeatNum - 1)))?null:(System.String)reader[((int)CoExamPlaceStudColumn.StudSeatNum - 1)];
			entity.AutoFlg = (reader.IsDBNull(((int)CoExamPlaceStudColumn.AutoFlg - 1)))?null:(System.Boolean?)reader[((int)CoExamPlaceStudColumn.AutoFlg - 1)];
			entity.ExamVersionNo = (reader.IsDBNull(((int)CoExamPlaceStudColumn.ExamVersionNo - 1)))?null:(System.Int32?)reader[((int)CoExamPlaceStudColumn.ExamVersionNo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamPlaceStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamPlaceStudId = (System.Decimal)dataRow["CO_EXAM_PLACE_STUD_ID"];
			entity.OriginalCoExamPlaceStudId = (System.Decimal)dataRow["CO_EXAM_PLACE_STUD_ID"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.CoExamSchdlPlaceId = (System.Decimal)dataRow["CO_EXAM_SCHDL_PLACE_ID"];
			entity.StudScrtNum = Convert.IsDBNull(dataRow["STUD_SCRT_NUM"]) ? null : (System.String)dataRow["STUD_SCRT_NUM"];
			entity.StudSeatNum = Convert.IsDBNull(dataRow["STUD_SEAT_NUM"]) ? null : (System.String)dataRow["STUD_SEAT_NUM"];
			entity.AutoFlg = Convert.IsDBNull(dataRow["AUTO_FLG"]) ? null : (System.Boolean?)dataRow["AUTO_FLG"];
			entity.ExamVersionNo = Convert.IsDBNull(dataRow["EXAM_VERSION_NO"]) ? null : (System.Int32?)dataRow["EXAM_VERSION_NO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamPlaceStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamPlaceStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPlaceStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoExamSchdlPlaceIdSource	
			if (CanDeepLoad(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepLoadType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoExamSchdlPlaceId;
				CoExamSchdlPlace tmpEntity = EntityManager.LocateEntity<CoExamSchdlPlace>(EntityLocator.ConstructKeyFromPkItems(typeof(CoExamSchdlPlace), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoExamSchdlPlaceIdSource = tmpEntity;
				else
					entity.CoExamSchdlPlaceIdSource = DataRepository.CoExamSchdlPlaceProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoExamSchdlPlaceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoExamSchdlPlaceProvider.DeepLoad(transactionManager, entity.CoExamSchdlPlaceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoExamSchdlPlaceIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamPlaceStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamPlaceStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamPlaceStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamPlaceStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoExamSchdlPlaceIdSource
			if (CanDeepSave(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepSaveType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource != null)
			{
				DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceIdSource);
				entity.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
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
	
	#region CoExamPlaceStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamPlaceStud</c>
	///</summary>
	public enum CoExamPlaceStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoExamSchdlPlace</c> at CoExamSchdlPlaceIdSource
		///</summary>
		[ChildEntityType(typeof(CoExamSchdlPlace))]
		CoExamSchdlPlace,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
	}
	
	#endregion CoExamPlaceStudChildEntityTypes
	
	#region CoExamPlaceStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamPlaceStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPlaceStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamPlaceStudFilterBuilder : SqlFilterBuilder<CoExamPlaceStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudFilterBuilder class.
		/// </summary>
		public CoExamPlaceStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamPlaceStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamPlaceStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamPlaceStudFilterBuilder
	
	#region CoExamPlaceStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamPlaceStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPlaceStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamPlaceStudParameterBuilder : ParameterizedSqlFilterBuilder<CoExamPlaceStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudParameterBuilder class.
		/// </summary>
		public CoExamPlaceStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamPlaceStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamPlaceStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamPlaceStudParameterBuilder
	
	#region CoExamPlaceStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamPlaceStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamPlaceStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamPlaceStudSortBuilder : SqlSortBuilder<CoExamPlaceStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamPlaceStudSqlSortBuilder class.
		/// </summary>
		public CoExamPlaceStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamPlaceStudSortBuilder
	
} // end namespace
