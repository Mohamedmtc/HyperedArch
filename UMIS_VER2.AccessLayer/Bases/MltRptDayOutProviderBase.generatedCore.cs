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
	/// This class is the base class for any <see cref="MltRptDayOutProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltRptDayOutProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltRptDayOut, UMIS_VER2.BusinessLyer.MltRptDayOutKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutKey key)
		{
			return Delete(transactionManager, key.MltRptDayOutId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltRptDayOutId">بيان الخروج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltRptDayOutId)
		{
			return Delete(null, _mltRptDayOutId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltRptDayOutId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(_mltCdeOutRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayOut> GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(transactionManager, _mltCdeOutRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltCdeOutRsnId(transactionManager, _mltCdeOutRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		fkMltRptDayOutMltCdeOutRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltCdeOutRsnId(null, _mltCdeOutRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		fkMltRptDayOutMltCdeOutRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltCdeOutRsnId(System.Int32 _mltCdeOutRsnId, int start, int pageLength,out int count)
		{
			return GetByMltCdeOutRsnId(null, _mltCdeOutRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN key.
		///		FK_MLT_RPT_DAY_OUT_MLT_CDE_OUT_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltCdeOutRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public abstract TList<MltRptDayOut> GetByMltCdeOutRsnId(TransactionManager transactionManager, System.Int32 _mltCdeOutRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(_mltRptDayStudStsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayOut> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		fkMltRptDayOutMltRptDayStudSts Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		fkMltRptDayOutMltRptDayStudSts Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public TList<MltRptDayOut> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength,out int count)
		{
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_OUT_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOut objects.</returns>
		public abstract TList<MltRptDayOut> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltRptDayOut Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutKey key, int start, int pageLength)
		{
			return GetByMltRptDayOutId(transactionManager, key.MltRptDayOutId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(System.Decimal _mltRptDayOutId)
		{
			int count = -1;
			return GetByMltRptDayOutId(null,_mltRptDayOutId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(System.Decimal _mltRptDayOutId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayOutId(null, _mltRptDayOutId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId)
		{
			int count = -1;
			return GetByMltRptDayOutId(transactionManager, _mltRptDayOutId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayOutId(transactionManager, _mltRptDayOutId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(System.Decimal _mltRptDayOutId, int start, int pageLength, out int count)
		{
			return GetByMltRptDayOutId(null, _mltRptDayOutId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltRptDayOut GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltRptDayOut&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltRptDayOut&gt;"/></returns>
		public static TList<MltRptDayOut> Fill(IDataReader reader, TList<MltRptDayOut> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltRptDayOut c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltRptDayOut")
					.Append("|").Append((System.Decimal)reader["MLT_RPT_DAY_OUT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltRptDayOut>(
					key.ToString(), // EntityTrackingKey
					"MltRptDayOut",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltRptDayOut();
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
					c.MltRptDayOutId = (System.Decimal)reader["MLT_RPT_DAY_OUT_ID"];
					c.OriginalMltRptDayOutId = c.MltRptDayOutId;
					c.MltRptDayStudStsId = (System.Decimal)reader["MLT_RPT_DAY_STUD_STS_ID"];
					c.MltCdeOutRsnId = (System.Int32)reader["MLT_CDE_OUT_RSN_ID"];
					c.OutStudCount = (System.Decimal)reader["OUT_STUD_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltRptDayOut entity)
		{
			if (!reader.Read()) return;
			
			entity.MltRptDayOutId = (System.Decimal)reader[((int)MltRptDayOutColumn.MltRptDayOutId - 1)];
			entity.OriginalMltRptDayOutId = (System.Decimal)reader["MLT_RPT_DAY_OUT_ID"];
			entity.MltRptDayStudStsId = (System.Decimal)reader[((int)MltRptDayOutColumn.MltRptDayStudStsId - 1)];
			entity.MltCdeOutRsnId = (System.Int32)reader[((int)MltRptDayOutColumn.MltCdeOutRsnId - 1)];
			entity.OutStudCount = (System.Decimal)reader[((int)MltRptDayOutColumn.OutStudCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltRptDayOut entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltRptDayOutId = (System.Decimal)dataRow["MLT_RPT_DAY_OUT_ID"];
			entity.OriginalMltRptDayOutId = (System.Decimal)dataRow["MLT_RPT_DAY_OUT_ID"];
			entity.MltRptDayStudStsId = (System.Decimal)dataRow["MLT_RPT_DAY_STUD_STS_ID"];
			entity.MltCdeOutRsnId = (System.Int32)dataRow["MLT_CDE_OUT_RSN_ID"];
			entity.OutStudCount = (System.Decimal)dataRow["OUT_STUD_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOut"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayOut Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOut entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MltCdeOutRsnIdSource	
			if (CanDeepLoad(entity, "MltCdeOutRsn|MltCdeOutRsnIdSource", deepLoadType, innerList) 
				&& entity.MltCdeOutRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltCdeOutRsnId;
				MltCdeOutRsn tmpEntity = EntityManager.LocateEntity<MltCdeOutRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(MltCdeOutRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltCdeOutRsnIdSource = tmpEntity;
				else
					entity.MltCdeOutRsnIdSource = DataRepository.MltCdeOutRsnProvider.GetByMltCdeOutRsnId(transactionManager, entity.MltCdeOutRsnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltCdeOutRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltCdeOutRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltCdeOutRsnProvider.DeepLoad(transactionManager, entity.MltCdeOutRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltCdeOutRsnIdSource

			#region MltRptDayStudStsIdSource	
			if (CanDeepLoad(entity, "MltRptDayStudSts|MltRptDayStudStsIdSource", deepLoadType, innerList) 
				&& entity.MltRptDayStudStsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltRptDayStudStsId;
				MltRptDayStudSts tmpEntity = EntityManager.LocateEntity<MltRptDayStudSts>(EntityLocator.ConstructKeyFromPkItems(typeof(MltRptDayStudSts), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltRptDayStudStsIdSource = tmpEntity;
				else
					entity.MltRptDayStudStsIdSource = DataRepository.MltRptDayStudStsProvider.GetByMltRptDayStudStsId(transactionManager, entity.MltRptDayStudStsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayStudStsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltRptDayStudStsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltRptDayStudStsProvider.DeepLoad(transactionManager, entity.MltRptDayStudStsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltRptDayStudStsIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMltRptDayOutId methods when available
			
			#region MltRptDayOutStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayOutStud>|MltRptDayOutStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayOutStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayOutStudCollection = DataRepository.MltRptDayOutStudProvider.GetByMltRptDayOutId(transactionManager, entity.MltRptDayOutId);

				if (deep && entity.MltRptDayOutStudCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayOutStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayOutStud>) DataRepository.MltRptDayOutStudProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayOutStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltRptDayOut object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltRptDayOut instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayOut Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOut entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MltCdeOutRsnIdSource
			if (CanDeepSave(entity, "MltCdeOutRsn|MltCdeOutRsnIdSource", deepSaveType, innerList) 
				&& entity.MltCdeOutRsnIdSource != null)
			{
				DataRepository.MltCdeOutRsnProvider.Save(transactionManager, entity.MltCdeOutRsnIdSource);
				entity.MltCdeOutRsnId = entity.MltCdeOutRsnIdSource.MltCdeOutRsnId;
			}
			#endregion 
			
			#region MltRptDayStudStsIdSource
			if (CanDeepSave(entity, "MltRptDayStudSts|MltRptDayStudStsIdSource", deepSaveType, innerList) 
				&& entity.MltRptDayStudStsIdSource != null)
			{
				DataRepository.MltRptDayStudStsProvider.Save(transactionManager, entity.MltRptDayStudStsIdSource);
				entity.MltRptDayStudStsId = entity.MltRptDayStudStsIdSource.MltRptDayStudStsId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MltRptDayOutStud>
				if (CanDeepSave(entity.MltRptDayOutStudCollection, "List<MltRptDayOutStud>|MltRptDayOutStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayOutStud child in entity.MltRptDayOutStudCollection)
					{
						if(child.MltRptDayOutIdSource != null)
						{
							child.MltRptDayOutId = child.MltRptDayOutIdSource.MltRptDayOutId;
						}
						else
						{
							child.MltRptDayOutId = entity.MltRptDayOutId;
						}

					}

					if (entity.MltRptDayOutStudCollection.Count > 0 || entity.MltRptDayOutStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayOutStudProvider.Save(transactionManager, entity.MltRptDayOutStudCollection);
						
						deepHandles.Add("MltRptDayOutStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayOutStud >) DataRepository.MltRptDayOutStudProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayOutStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region MltRptDayOutChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltRptDayOut</c>
	///</summary>
	public enum MltRptDayOutChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MltCdeOutRsn</c> at MltCdeOutRsnIdSource
		///</summary>
		[ChildEntityType(typeof(MltCdeOutRsn))]
		MltCdeOutRsn,
		
		///<summary>
		/// Composite Property for <c>MltRptDayStudSts</c> at MltRptDayStudStsIdSource
		///</summary>
		[ChildEntityType(typeof(MltRptDayStudSts))]
		MltRptDayStudSts,
		///<summary>
		/// Collection of <c>MltRptDayOut</c> as OneToMany for MltRptDayOutStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayOutStud>))]
		MltRptDayOutStudCollection,
	}
	
	#endregion MltRptDayOutChildEntityTypes
	
	#region MltRptDayOutFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltRptDayOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOut"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayOutFilterBuilder : SqlFilterBuilder<MltRptDayOutColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutFilterBuilder class.
		/// </summary>
		public MltRptDayOutFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayOutFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayOutFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayOutFilterBuilder
	
	#region MltRptDayOutParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltRptDayOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOut"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayOutParameterBuilder : ParameterizedSqlFilterBuilder<MltRptDayOutColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutParameterBuilder class.
		/// </summary>
		public MltRptDayOutParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayOutParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayOutParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayOutParameterBuilder
	
	#region MltRptDayOutSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltRptDayOutColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOut"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltRptDayOutSortBuilder : SqlSortBuilder<MltRptDayOutColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutSqlSortBuilder class.
		/// </summary>
		public MltRptDayOutSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltRptDayOutSortBuilder
	
} // end namespace
