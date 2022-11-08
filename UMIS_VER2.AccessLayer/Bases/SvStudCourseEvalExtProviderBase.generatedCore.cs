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
	/// This class is the base class for any <see cref="SvStudCourseEvalExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudCourseEvalExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudCourseEvalExt, UMIS_VER2.BusinessLyer.SvStudCourseEvalExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalExtKey key)
		{
			return Delete(transactionManager, key.SvStudCourseEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudCourseEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudCourseEvalExtId)
		{
			return Delete(null, _svStudCourseEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudCourseEvalExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudCourseEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		fkSvStudCourseEvalExtEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		fkSvStudCourseEvalExtEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public abstract TList<SvStudCourseEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="_svCourseEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(_svCourseEvalExtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(transactionManager, _svCourseEvalExtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(transactionManager, _svCourseEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		fkSvStudCourseEvalExtSvCourseEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCourseEvalExtId(null, _svCourseEvalExtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		fkSvStudCourseEvalExtSvCourseEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId, int start, int pageLength,out int count)
		{
			return GetBySvCourseEvalExtId(null, _svCourseEvalExtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT key.
		///		FK_SV_STUD_COURSE_EVAL_EXT_SV_COURSE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudCourseEvalExt objects.</returns>
		public abstract TList<SvStudCourseEvalExt> GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudCourseEvalExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalExtKey key, int start, int pageLength)
		{
			return GetBySvStudCourseEvalExtId(transactionManager, key.SvStudCourseEvalExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(System.Decimal _svStudCourseEvalExtId)
		{
			int count = -1;
			return GetBySvStudCourseEvalExtId(null,_svStudCourseEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(System.Decimal _svStudCourseEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCourseEvalExtId(null, _svStudCourseEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalExtId)
		{
			int count = -1;
			return GetBySvStudCourseEvalExtId(transactionManager, _svStudCourseEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCourseEvalExtId(transactionManager, _svStudCourseEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(System.Decimal _svStudCourseEvalExtId, int start, int pageLength, out int count)
		{
			return GetBySvStudCourseEvalExtId(null, _svStudCourseEvalExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudCourseEvalExt GetBySvStudCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svStudCourseEvalExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudCourseEvalExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudCourseEvalExt&gt;"/></returns>
		public static TList<SvStudCourseEvalExt> Fill(IDataReader reader, TList<SvStudCourseEvalExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudCourseEvalExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudCourseEvalExt")
					.Append("|").Append((System.Decimal)reader["SV_STUD_COURSE_EVAL_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudCourseEvalExt>(
					key.ToString(), // EntityTrackingKey
					"SvStudCourseEvalExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudCourseEvalExt();
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
					c.SvStudCourseEvalExtId = (System.Decimal)reader["SV_STUD_COURSE_EVAL_EXT_ID"];
					c.OriginalSvStudCourseEvalExtId = c.SvStudCourseEvalExtId;
					c.SvCourseEvalExtId = (System.Decimal)reader["SV_COURSE_EVAL_EXT_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EvalExtRply = Convert.IsDBNull(reader["EVAL_EXT_RPLY"]) ? null : (System.String)reader["EVAL_EXT_RPLY"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudCourseEvalExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudCourseEvalExtId = (System.Decimal)reader[((int)SvStudCourseEvalExtColumn.SvStudCourseEvalExtId - 1)];
			entity.OriginalSvStudCourseEvalExtId = (System.Decimal)reader["SV_STUD_COURSE_EVAL_EXT_ID"];
			entity.SvCourseEvalExtId = (System.Decimal)reader[((int)SvStudCourseEvalExtColumn.SvCourseEvalExtId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)SvStudCourseEvalExtColumn.EdStudId - 1)];
			entity.EvalExtRply = (reader.IsDBNull(((int)SvStudCourseEvalExtColumn.EvalExtRply - 1)))?null:(System.String)reader[((int)SvStudCourseEvalExtColumn.EvalExtRply - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudCourseEvalExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudCourseEvalExtId = (System.Decimal)dataRow["SV_STUD_COURSE_EVAL_EXT_ID"];
			entity.OriginalSvStudCourseEvalExtId = (System.Decimal)dataRow["SV_STUD_COURSE_EVAL_EXT_ID"];
			entity.SvCourseEvalExtId = (System.Decimal)dataRow["SV_COURSE_EVAL_EXT_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EvalExtRply = Convert.IsDBNull(dataRow["EVAL_EXT_RPLY"]) ? null : (System.String)dataRow["EVAL_EXT_RPLY"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudCourseEvalExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudCourseEvalExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SvCourseEvalExtIdSource	
			if (CanDeepLoad(entity, "SvCourseEvalExt|SvCourseEvalExtIdSource", deepLoadType, innerList) 
				&& entity.SvCourseEvalExtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCourseEvalExtId;
				SvCourseEvalExt tmpEntity = EntityManager.LocateEntity<SvCourseEvalExt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCourseEvalExt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCourseEvalExtIdSource = tmpEntity;
				else
					entity.SvCourseEvalExtIdSource = DataRepository.SvCourseEvalExtProvider.GetBySvCourseEvalExtId(transactionManager, entity.SvCourseEvalExtId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalExtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCourseEvalExtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCourseEvalExtProvider.DeepLoad(transactionManager, entity.SvCourseEvalExtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCourseEvalExtIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudCourseEvalExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudCourseEvalExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudCourseEvalExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCourseEvalExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SvCourseEvalExtIdSource
			if (CanDeepSave(entity, "SvCourseEvalExt|SvCourseEvalExtIdSource", deepSaveType, innerList) 
				&& entity.SvCourseEvalExtIdSource != null)
			{
				DataRepository.SvCourseEvalExtProvider.Save(transactionManager, entity.SvCourseEvalExtIdSource);
				entity.SvCourseEvalExtId = entity.SvCourseEvalExtIdSource.SvCourseEvalExtId;
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
	
	#region SvStudCourseEvalExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudCourseEvalExt</c>
	///</summary>
	public enum SvStudCourseEvalExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SvCourseEvalExt</c> at SvCourseEvalExtIdSource
		///</summary>
		[ChildEntityType(typeof(SvCourseEvalExt))]
		SvCourseEvalExt,
	}
	
	#endregion SvStudCourseEvalExtChildEntityTypes
	
	#region SvStudCourseEvalExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCourseEvalExtFilterBuilder : SqlFilterBuilder<SvStudCourseEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtFilterBuilder class.
		/// </summary>
		public SvStudCourseEvalExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCourseEvalExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCourseEvalExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCourseEvalExtFilterBuilder
	
	#region SvStudCourseEvalExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCourseEvalExtParameterBuilder : ParameterizedSqlFilterBuilder<SvStudCourseEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtParameterBuilder class.
		/// </summary>
		public SvStudCourseEvalExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCourseEvalExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCourseEvalExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCourseEvalExtParameterBuilder
	
	#region SvStudCourseEvalExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudCourseEvalExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudCourseEvalExtSortBuilder : SqlSortBuilder<SvStudCourseEvalExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCourseEvalExtSqlSortBuilder class.
		/// </summary>
		public SvStudCourseEvalExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudCourseEvalExtSortBuilder
	
} // end namespace
