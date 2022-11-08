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
	/// This class is the base class for any <see cref="SvCourseEvalExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCourseEvalExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCourseEvalExt, UMIS_VER2.BusinessLyer.SvCourseEvalExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalExtKey key)
		{
			return Delete(transactionManager, key.SvCourseEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCourseEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCourseEvalExtId)
		{
			return Delete(null, _svCourseEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="_svCdeEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(_svCdeEvalExtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvCourseEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeEvalExtId(transactionManager, _svCdeEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		fkSvCourseEvalExtSvCdeEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		fkSvCourseEvalExtSvCdeEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCdeEvalExtId(System.Int32 _svCdeEvalExtId, int start, int pageLength,out int count)
		{
			return GetBySvCdeEvalExtId(null, _svCdeEvalExtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT key.
		///		FK_SV_COURSE_EVAL_EXT_SV_CDE_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public abstract TList<SvCourseEvalExt> GetBySvCdeEvalExtId(TransactionManager transactionManager, System.Int32 _svCdeEvalExtId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL Description: 
		/// </summary>
		/// <param name="_svCourseEvalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCourseEvalId(System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(_svCourseEvalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvCourseEvalExt> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalId(transactionManager, _svCourseEvalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		fkSvCourseEvalExtSvCourseEval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseEvalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		fkSvCourseEvalExtSvCourseEval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public TList<SvCourseEvalExt> GetBySvCourseEvalId(System.Decimal _svCourseEvalId, int start, int pageLength,out int count)
		{
			return GetBySvCourseEvalId(null, _svCourseEvalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL key.
		///		FK_SV_COURSE_EVAL_EXT_SV_COURSE_EVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCourseEvalExt objects.</returns>
		public abstract TList<SvCourseEvalExt> GetBySvCourseEvalId(TransactionManager transactionManager, System.Decimal _svCourseEvalId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCourseEvalExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalExtKey key, int start, int pageLength)
		{
			return GetBySvCourseEvalExtId(transactionManager, key.SvCourseEvalExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCourseEvalExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(null,_svCourseEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(null, _svCourseEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(transactionManager, _svCourseEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCourseEvalExtId(transactionManager, _svCourseEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(System.Decimal _svCourseEvalExtId, int start, int pageLength, out int count)
		{
			return GetBySvCourseEvalExtId(null, _svCourseEvalExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_COURSE_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCourseEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCourseEvalExt GetBySvCourseEvalExtId(TransactionManager transactionManager, System.Decimal _svCourseEvalExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCourseEvalExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCourseEvalExt&gt;"/></returns>
		public static TList<SvCourseEvalExt> Fill(IDataReader reader, TList<SvCourseEvalExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCourseEvalExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCourseEvalExt")
					.Append("|").Append((System.Decimal)reader["SV_COURSE_EVAL_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCourseEvalExt>(
					key.ToString(), // EntityTrackingKey
					"SvCourseEvalExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCourseEvalExt();
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
					c.SvCourseEvalExtId = (System.Decimal)reader["SV_COURSE_EVAL_EXT_ID"];
					c.OriginalSvCourseEvalExtId = c.SvCourseEvalExtId;
					c.SvCourseEvalId = (System.Decimal)reader["SV_COURSE_EVAL_ID"];
					c.SvCdeEvalExtId = (System.Int32)reader["SV_CDE_EVAL_EXT_ID"];
					c.Ordr = Convert.IsDBNull(reader["ORDR"]) ? null : (System.Decimal?)reader["ORDR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCourseEvalExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCourseEvalExtId = (System.Decimal)reader[((int)SvCourseEvalExtColumn.SvCourseEvalExtId - 1)];
			entity.OriginalSvCourseEvalExtId = (System.Decimal)reader["SV_COURSE_EVAL_EXT_ID"];
			entity.SvCourseEvalId = (System.Decimal)reader[((int)SvCourseEvalExtColumn.SvCourseEvalId - 1)];
			entity.SvCdeEvalExtId = (System.Int32)reader[((int)SvCourseEvalExtColumn.SvCdeEvalExtId - 1)];
			entity.Ordr = (reader.IsDBNull(((int)SvCourseEvalExtColumn.Ordr - 1)))?null:(System.Decimal?)reader[((int)SvCourseEvalExtColumn.Ordr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCourseEvalExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCourseEvalExtId = (System.Decimal)dataRow["SV_COURSE_EVAL_EXT_ID"];
			entity.OriginalSvCourseEvalExtId = (System.Decimal)dataRow["SV_COURSE_EVAL_EXT_ID"];
			entity.SvCourseEvalId = (System.Decimal)dataRow["SV_COURSE_EVAL_ID"];
			entity.SvCdeEvalExtId = (System.Int32)dataRow["SV_CDE_EVAL_EXT_ID"];
			entity.Ordr = Convert.IsDBNull(dataRow["ORDR"]) ? null : (System.Decimal?)dataRow["ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCourseEvalExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEvalExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvCdeEvalExtIdSource	
			if (CanDeepLoad(entity, "SvCdeEvalExt|SvCdeEvalExtIdSource", deepLoadType, innerList) 
				&& entity.SvCdeEvalExtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeEvalExtId;
				SvCdeEvalExt tmpEntity = EntityManager.LocateEntity<SvCdeEvalExt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeEvalExt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeEvalExtIdSource = tmpEntity;
				else
					entity.SvCdeEvalExtIdSource = DataRepository.SvCdeEvalExtProvider.GetBySvCdeEvalExtId(transactionManager, entity.SvCdeEvalExtId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeEvalExtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeEvalExtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeEvalExtProvider.DeepLoad(transactionManager, entity.SvCdeEvalExtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeEvalExtIdSource

			#region SvCourseEvalIdSource	
			if (CanDeepLoad(entity, "SvCourseEval|SvCourseEvalIdSource", deepLoadType, innerList) 
				&& entity.SvCourseEvalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCourseEvalId;
				SvCourseEval tmpEntity = EntityManager.LocateEntity<SvCourseEval>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCourseEval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCourseEvalIdSource = tmpEntity;
				else
					entity.SvCourseEvalIdSource = DataRepository.SvCourseEvalProvider.GetBySvCourseEvalId(transactionManager, entity.SvCourseEvalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCourseEvalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCourseEvalProvider.DeepLoad(transactionManager, entity.SvCourseEvalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCourseEvalIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCourseEvalExtId methods when available
			
			#region SvStudCourseEvalExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEvalExt>|SvStudCourseEvalExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalExtCollection = DataRepository.SvStudCourseEvalExtProvider.GetBySvCourseEvalExtId(transactionManager, entity.SvCourseEvalExtId);

				if (deep && entity.SvStudCourseEvalExtCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEvalExt>) DataRepository.SvStudCourseEvalExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalExtCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCourseEvalExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCourseEvalExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCourseEvalExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCourseEvalExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvCdeEvalExtIdSource
			if (CanDeepSave(entity, "SvCdeEvalExt|SvCdeEvalExtIdSource", deepSaveType, innerList) 
				&& entity.SvCdeEvalExtIdSource != null)
			{
				DataRepository.SvCdeEvalExtProvider.Save(transactionManager, entity.SvCdeEvalExtIdSource);
				entity.SvCdeEvalExtId = entity.SvCdeEvalExtIdSource.SvCdeEvalExtId;
			}
			#endregion 
			
			#region SvCourseEvalIdSource
			if (CanDeepSave(entity, "SvCourseEval|SvCourseEvalIdSource", deepSaveType, innerList) 
				&& entity.SvCourseEvalIdSource != null)
			{
				DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalIdSource);
				entity.SvCourseEvalId = entity.SvCourseEvalIdSource.SvCourseEvalId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudCourseEvalExt>
				if (CanDeepSave(entity.SvStudCourseEvalExtCollection, "List<SvStudCourseEvalExt>|SvStudCourseEvalExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEvalExt child in entity.SvStudCourseEvalExtCollection)
					{
						if(child.SvCourseEvalExtIdSource != null)
						{
							child.SvCourseEvalExtId = child.SvCourseEvalExtIdSource.SvCourseEvalExtId;
						}
						else
						{
							child.SvCourseEvalExtId = entity.SvCourseEvalExtId;
						}

					}

					if (entity.SvStudCourseEvalExtCollection.Count > 0 || entity.SvStudCourseEvalExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalExtProvider.Save(transactionManager, entity.SvStudCourseEvalExtCollection);
						
						deepHandles.Add("SvStudCourseEvalExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEvalExt >) DataRepository.SvStudCourseEvalExtProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalExtCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCourseEvalExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCourseEvalExt</c>
	///</summary>
	public enum SvCourseEvalExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvCdeEvalExt</c> at SvCdeEvalExtIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeEvalExt))]
		SvCdeEvalExt,
		
		///<summary>
		/// Composite Property for <c>SvCourseEval</c> at SvCourseEvalIdSource
		///</summary>
		[ChildEntityType(typeof(SvCourseEval))]
		SvCourseEval,
		///<summary>
		/// Collection of <c>SvCourseEvalExt</c> as OneToMany for SvStudCourseEvalExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEvalExt>))]
		SvStudCourseEvalExtCollection,
	}
	
	#endregion SvCourseEvalExtChildEntityTypes
	
	#region SvCourseEvalExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalExtFilterBuilder : SqlFilterBuilder<SvCourseEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtFilterBuilder class.
		/// </summary>
		public SvCourseEvalExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalExtFilterBuilder
	
	#region SvCourseEvalExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCourseEvalExtParameterBuilder : ParameterizedSqlFilterBuilder<SvCourseEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtParameterBuilder class.
		/// </summary>
		public SvCourseEvalExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCourseEvalExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCourseEvalExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCourseEvalExtParameterBuilder
	
	#region SvCourseEvalExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCourseEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCourseEvalExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCourseEvalExtSortBuilder : SqlSortBuilder<SvCourseEvalExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCourseEvalExtSqlSortBuilder class.
		/// </summary>
		public SvCourseEvalExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCourseEvalExtSortBuilder
	
} // end namespace
