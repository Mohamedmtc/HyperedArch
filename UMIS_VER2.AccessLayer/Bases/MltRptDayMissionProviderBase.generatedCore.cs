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
	/// This class is the base class for any <see cref="MltRptDayMissionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltRptDayMissionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltRptDayMission, UMIS_VER2.BusinessLyer.MltRptDayMissionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayMissionKey key)
		{
			return Delete(transactionManager, key.MltRptDayMissionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltRptDayMissionId">بيان البعثات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltRptDayMissionId)
		{
			return Delete(null, _mltRptDayMissionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayMissionId">بيان البعثات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltRptDayMissionId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayMission> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		fkMltRptDayMissionGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		fkMltRptDayMissionGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE key.
		///		FK_MLT_RPT_DAY_MISSION_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public abstract TList<MltRptDayMission> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(_mltRptDayStudStsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayMission> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayStudStsId(transactionManager, _mltRptDayStudStsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		fkMltRptDayMissionMltRptDayStudSts Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		fkMltRptDayMissionMltRptDayStudSts Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public TList<MltRptDayMission> GetByMltRptDayStudStsId(System.Decimal _mltRptDayStudStsId, int start, int pageLength,out int count)
		{
			return GetByMltRptDayStudStsId(null, _mltRptDayStudStsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS key.
		///		FK_MLT_RPT_DAY_MISSION_MLT_RPT_DAY_STUD_STS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayStudStsId">تقرير تمام الكلية عن يوم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayMission objects.</returns>
		public abstract TList<MltRptDayMission> GetByMltRptDayStudStsId(TransactionManager transactionManager, System.Decimal _mltRptDayStudStsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltRptDayMission Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayMissionKey key, int start, int pageLength)
		{
			return GetByMltRptDayMissionId(transactionManager, key.MltRptDayMissionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(System.Decimal _mltRptDayMissionId)
		{
			int count = -1;
			return GetByMltRptDayMissionId(null,_mltRptDayMissionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(System.Decimal _mltRptDayMissionId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayMissionId(null, _mltRptDayMissionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(TransactionManager transactionManager, System.Decimal _mltRptDayMissionId)
		{
			int count = -1;
			return GetByMltRptDayMissionId(transactionManager, _mltRptDayMissionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(TransactionManager transactionManager, System.Decimal _mltRptDayMissionId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayMissionId(transactionManager, _mltRptDayMissionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(System.Decimal _mltRptDayMissionId, int start, int pageLength, out int count)
		{
			return GetByMltRptDayMissionId(null, _mltRptDayMissionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_MISSION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayMissionId">بيان البعثات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltRptDayMission GetByMltRptDayMissionId(TransactionManager transactionManager, System.Decimal _mltRptDayMissionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltRptDayMission&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltRptDayMission&gt;"/></returns>
		public static TList<MltRptDayMission> Fill(IDataReader reader, TList<MltRptDayMission> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltRptDayMission c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltRptDayMission")
					.Append("|").Append((System.Decimal)reader["MLT_RPT_DAY_MISSION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltRptDayMission>(
					key.ToString(), // EntityTrackingKey
					"MltRptDayMission",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltRptDayMission();
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
					c.MltRptDayMissionId = (System.Decimal)reader["MLT_RPT_DAY_MISSION_ID"];
					c.OriginalMltRptDayMissionId = c.MltRptDayMissionId;
					c.MltRptDayStudStsId = (System.Decimal)reader["MLT_RPT_DAY_STUD_STS_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.MissionStudCount = (System.Decimal)reader["MISSION_STUD_COUNT"];
					c.MissioExistCount = (System.Decimal)reader["MISSIO_EXIST_COUNT"];
					c.MissionOutCount = (System.Decimal)reader["MISSION_OUT_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltRptDayMission entity)
		{
			if (!reader.Read()) return;
			
			entity.MltRptDayMissionId = (System.Decimal)reader[((int)MltRptDayMissionColumn.MltRptDayMissionId - 1)];
			entity.OriginalMltRptDayMissionId = (System.Decimal)reader["MLT_RPT_DAY_MISSION_ID"];
			entity.MltRptDayStudStsId = (System.Decimal)reader[((int)MltRptDayMissionColumn.MltRptDayStudStsId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)MltRptDayMissionColumn.GsCountryNodeId - 1)];
			entity.MissionStudCount = (System.Decimal)reader[((int)MltRptDayMissionColumn.MissionStudCount - 1)];
			entity.MissioExistCount = (System.Decimal)reader[((int)MltRptDayMissionColumn.MissioExistCount - 1)];
			entity.MissionOutCount = (System.Decimal)reader[((int)MltRptDayMissionColumn.MissionOutCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltRptDayMission entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltRptDayMissionId = (System.Decimal)dataRow["MLT_RPT_DAY_MISSION_ID"];
			entity.OriginalMltRptDayMissionId = (System.Decimal)dataRow["MLT_RPT_DAY_MISSION_ID"];
			entity.MltRptDayStudStsId = (System.Decimal)dataRow["MLT_RPT_DAY_STUD_STS_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.MissionStudCount = (System.Decimal)dataRow["MISSION_STUD_COUNT"];
			entity.MissioExistCount = (System.Decimal)dataRow["MISSIO_EXIST_COUNT"];
			entity.MissionOutCount = (System.Decimal)dataRow["MISSION_OUT_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayMission"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayMission Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayMission entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCountryNodeId;
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltRptDayMission object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltRptDayMission instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayMission Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayMission entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
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
	
	#region MltRptDayMissionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltRptDayMission</c>
	///</summary>
	public enum MltRptDayMissionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>MltRptDayStudSts</c> at MltRptDayStudStsIdSource
		///</summary>
		[ChildEntityType(typeof(MltRptDayStudSts))]
		MltRptDayStudSts,
	}
	
	#endregion MltRptDayMissionChildEntityTypes
	
	#region MltRptDayMissionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltRptDayMissionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayMission"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayMissionFilterBuilder : SqlFilterBuilder<MltRptDayMissionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionFilterBuilder class.
		/// </summary>
		public MltRptDayMissionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayMissionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayMissionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayMissionFilterBuilder
	
	#region MltRptDayMissionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltRptDayMissionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayMission"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayMissionParameterBuilder : ParameterizedSqlFilterBuilder<MltRptDayMissionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionParameterBuilder class.
		/// </summary>
		public MltRptDayMissionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayMissionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayMissionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayMissionParameterBuilder
	
	#region MltRptDayMissionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltRptDayMissionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayMission"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltRptDayMissionSortBuilder : SqlSortBuilder<MltRptDayMissionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayMissionSqlSortBuilder class.
		/// </summary>
		public MltRptDayMissionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltRptDayMissionSortBuilder
	
} // end namespace
