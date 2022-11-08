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
	/// This class is the base class for any <see cref="MdiCdeHosptlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeHosptlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeHosptl, UMIS_VER2.BusinessLyer.MdiCdeHosptlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeHosptlKey key)
		{
			return Delete(transactionManager, key.MdiCdeHosptlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeHosptlId)
		{
			return Delete(null, _mdiCdeHosptlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeHosptlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.MdiCdeHosptl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeHosptlKey key, int start, int pageLength)
		{
			return GetByMdiCdeHosptlId(transactionManager, key.MdiCdeHosptlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(System.Decimal _mdiCdeHosptlId)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(null,_mdiCdeHosptlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(System.Decimal _mdiCdeHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(null, _mdiCdeHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal _mdiCdeHosptlId)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(transactionManager, _mdiCdeHosptlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal _mdiCdeHosptlId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeHosptlId(transactionManager, _mdiCdeHosptlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(System.Decimal _mdiCdeHosptlId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeHosptlId(null, _mdiCdeHosptlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_HOSPTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeHosptlId">مسلسل المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByMdiCdeHosptlId(TransactionManager transactionManager, System.Decimal _mdiCdeHosptlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(System.String _hosptlAr)
		{
			int count = -1;
			return GetByHosptlAr(null,_hosptlAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(System.String _hosptlAr, int start, int pageLength)
		{
			int count = -1;
			return GetByHosptlAr(null, _hosptlAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(TransactionManager transactionManager, System.String _hosptlAr)
		{
			int count = -1;
			return GetByHosptlAr(transactionManager, _hosptlAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(TransactionManager transactionManager, System.String _hosptlAr, int start, int pageLength)
		{
			int count = -1;
			return GetByHosptlAr(transactionManager, _hosptlAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(System.String _hosptlAr, int start, int pageLength, out int count)
		{
			return GetByHosptlAr(null, _hosptlAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlAr">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlAr(TransactionManager transactionManager, System.String _hosptlAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(System.String _hosptlEn)
		{
			int count = -1;
			return GetByHosptlEn(null,_hosptlEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(System.String _hosptlEn, int start, int pageLength)
		{
			int count = -1;
			return GetByHosptlEn(null, _hosptlEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(TransactionManager transactionManager, System.String _hosptlEn)
		{
			int count = -1;
			return GetByHosptlEn(transactionManager, _hosptlEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(TransactionManager transactionManager, System.String _hosptlEn, int start, int pageLength)
		{
			int count = -1;
			return GetByHosptlEn(transactionManager, _hosptlEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(System.String _hosptlEn, int start, int pageLength, out int count)
		{
			return GetByHosptlEn(null, _hosptlEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_HOSPTL_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hosptlEn">اسم المستشفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeHosptl GetByHosptlEn(TransactionManager transactionManager, System.String _hosptlEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeHosptl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeHosptl&gt;"/></returns>
		public static TList<MdiCdeHosptl> Fill(IDataReader reader, TList<MdiCdeHosptl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeHosptl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeHosptl")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_HOSPTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeHosptl>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeHosptl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeHosptl();
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
					c.MdiCdeHosptlId = (System.Decimal)reader["MDI_CDE_HOSPTL_ID"];
					c.OriginalMdiCdeHosptlId = c.MdiCdeHosptlId;
					c.HosptlAr = (System.String)reader["HOSPTL_AR"];
					c.HosptlEn = (System.String)reader["HOSPTL_EN"];
					c.HosptlAddress = Convert.IsDBNull(reader["HOSPTL_ADDRESS"]) ? null : (System.String)reader["HOSPTL_ADDRESS"];
					c.HosptlTel = Convert.IsDBNull(reader["HOSPTL_TEL"]) ? null : (System.Decimal?)reader["HOSPTL_TEL"];
					c.HosptlMob = Convert.IsDBNull(reader["HOSPTL_MOB"]) ? null : (System.Decimal?)reader["HOSPTL_MOB"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeHosptl entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeHosptlId = (System.Decimal)reader[((int)MdiCdeHosptlColumn.MdiCdeHosptlId - 1)];
			entity.OriginalMdiCdeHosptlId = (System.Decimal)reader["MDI_CDE_HOSPTL_ID"];
			entity.HosptlAr = (System.String)reader[((int)MdiCdeHosptlColumn.HosptlAr - 1)];
			entity.HosptlEn = (System.String)reader[((int)MdiCdeHosptlColumn.HosptlEn - 1)];
			entity.HosptlAddress = (reader.IsDBNull(((int)MdiCdeHosptlColumn.HosptlAddress - 1)))?null:(System.String)reader[((int)MdiCdeHosptlColumn.HosptlAddress - 1)];
			entity.HosptlTel = (reader.IsDBNull(((int)MdiCdeHosptlColumn.HosptlTel - 1)))?null:(System.Decimal?)reader[((int)MdiCdeHosptlColumn.HosptlTel - 1)];
			entity.HosptlMob = (reader.IsDBNull(((int)MdiCdeHosptlColumn.HosptlMob - 1)))?null:(System.Decimal?)reader[((int)MdiCdeHosptlColumn.HosptlMob - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeHosptl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeHosptlId = (System.Decimal)dataRow["MDI_CDE_HOSPTL_ID"];
			entity.OriginalMdiCdeHosptlId = (System.Decimal)dataRow["MDI_CDE_HOSPTL_ID"];
			entity.HosptlAr = (System.String)dataRow["HOSPTL_AR"];
			entity.HosptlEn = (System.String)dataRow["HOSPTL_EN"];
			entity.HosptlAddress = Convert.IsDBNull(dataRow["HOSPTL_ADDRESS"]) ? null : (System.String)dataRow["HOSPTL_ADDRESS"];
			entity.HosptlTel = Convert.IsDBNull(dataRow["HOSPTL_TEL"]) ? null : (System.Decimal?)dataRow["HOSPTL_TEL"];
			entity.HosptlMob = Convert.IsDBNull(dataRow["HOSPTL_MOB"]) ? null : (System.Decimal?)dataRow["HOSPTL_MOB"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeHosptl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeHosptl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeHosptl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeHosptlId methods when available
			
			#region MdiStudHosptlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudHosptlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudHosptlCollection = DataRepository.MdiStudHosptlProvider.GetByMdiCdeHosptlId(transactionManager, entity.MdiCdeHosptlId);

				if (deep && entity.MdiStudHosptlCollection.Count > 0)
				{
					deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudHosptl>) DataRepository.MdiStudHosptlProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudHosptlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeHosptl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeHosptl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeHosptl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeHosptl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MdiStudHosptl>
				if (CanDeepSave(entity.MdiStudHosptlCollection, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudHosptl child in entity.MdiStudHosptlCollection)
					{
						if(child.MdiCdeHosptlIdSource != null)
						{
							child.MdiCdeHosptlId = child.MdiCdeHosptlIdSource.MdiCdeHosptlId;
						}
						else
						{
							child.MdiCdeHosptlId = entity.MdiCdeHosptlId;
						}

					}

					if (entity.MdiStudHosptlCollection.Count > 0 || entity.MdiStudHosptlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudHosptlProvider.Save(transactionManager, entity.MdiStudHosptlCollection);
						
						deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudHosptl >) DataRepository.MdiStudHosptlProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudHosptlCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeHosptlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeHosptl</c>
	///</summary>
	public enum MdiCdeHosptlChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeHosptl</c> as OneToMany for MdiStudHosptlCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudHosptl>))]
		MdiStudHosptlCollection,
	}
	
	#endregion MdiCdeHosptlChildEntityTypes
	
	#region MdiCdeHosptlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeHosptl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeHosptlFilterBuilder : SqlFilterBuilder<MdiCdeHosptlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlFilterBuilder class.
		/// </summary>
		public MdiCdeHosptlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeHosptlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeHosptlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeHosptlFilterBuilder
	
	#region MdiCdeHosptlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeHosptl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeHosptlParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeHosptlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlParameterBuilder class.
		/// </summary>
		public MdiCdeHosptlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeHosptlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeHosptlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeHosptlParameterBuilder
	
	#region MdiCdeHosptlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeHosptlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeHosptl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeHosptlSortBuilder : SqlSortBuilder<MdiCdeHosptlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeHosptlSqlSortBuilder class.
		/// </summary>
		public MdiCdeHosptlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeHosptlSortBuilder
	
} // end namespace
