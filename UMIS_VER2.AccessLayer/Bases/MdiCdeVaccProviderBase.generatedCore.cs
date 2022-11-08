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
	/// This class is the base class for any <see cref="MdiCdeVaccProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiCdeVaccProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiCdeVacc, UMIS_VER2.BusinessLyer.MdiCdeVaccKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeVaccKey key)
		{
			return Delete(transactionManager, key.MdiCdeVaccId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiCdeVaccId">نوع التطعيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiCdeVaccId)
		{
			return Delete(null, _mdiCdeVaccId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId);		
		
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
		public override UMIS_VER2.BusinessLyer.MdiCdeVacc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeVaccKey key, int start, int pageLength)
		{
			return GetByMdiCdeVaccId(transactionManager, key.MdiCdeVaccId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId)
		{
			int count = -1;
			return GetByMdiCdeVaccId(null,_mdiCdeVaccId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeVaccId(null, _mdiCdeVaccId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId)
		{
			int count = -1;
			return GetByMdiCdeVaccId(transactionManager, _mdiCdeVaccId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeVaccId(transactionManager, _mdiCdeVaccId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId, int start, int pageLength, out int count)
		{
			return GetByMdiCdeVaccId(null, _mdiCdeVaccId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_CDE_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeVacc GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="_vaccAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(System.String _vaccAr)
		{
			int count = -1;
			return GetByVaccAr(null,_vaccAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="_vaccAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(System.String _vaccAr, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccAr(null, _vaccAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(TransactionManager transactionManager, System.String _vaccAr)
		{
			int count = -1;
			return GetByVaccAr(transactionManager, _vaccAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(TransactionManager transactionManager, System.String _vaccAr, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccAr(transactionManager, _vaccAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="_vaccAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(System.String _vaccAr, int start, int pageLength, out int count)
		{
			return GetByVaccAr(null, _vaccAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccAr(TransactionManager transactionManager, System.String _vaccAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(System.String _vaccCode)
		{
			int count = -1;
			return GetByVaccCode(null,_vaccCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(System.String _vaccCode, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccCode(null, _vaccCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(TransactionManager transactionManager, System.String _vaccCode)
		{
			int count = -1;
			return GetByVaccCode(transactionManager, _vaccCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(TransactionManager transactionManager, System.String _vaccCode, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccCode(transactionManager, _vaccCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(System.String _vaccCode, int start, int pageLength, out int count)
		{
			return GetByVaccCode(null, _vaccCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccCode">كود التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccCode(TransactionManager transactionManager, System.String _vaccCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="_vaccEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(System.String _vaccEn)
		{
			int count = -1;
			return GetByVaccEn(null,_vaccEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="_vaccEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(System.String _vaccEn, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccEn(null, _vaccEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(TransactionManager transactionManager, System.String _vaccEn)
		{
			int count = -1;
			return GetByVaccEn(transactionManager, _vaccEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(TransactionManager transactionManager, System.String _vaccEn, int start, int pageLength)
		{
			int count = -1;
			return GetByVaccEn(transactionManager, _vaccEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="_vaccEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(System.String _vaccEn, int start, int pageLength, out int count)
		{
			return GetByVaccEn(null, _vaccEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_CDE_VACC_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_vaccEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiCdeVacc GetByVaccEn(TransactionManager transactionManager, System.String _vaccEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiCdeVacc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiCdeVacc&gt;"/></returns>
		public static TList<MdiCdeVacc> Fill(IDataReader reader, TList<MdiCdeVacc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiCdeVacc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiCdeVacc")
					.Append("|").Append((System.Decimal)reader["MDI_CDE_VACC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiCdeVacc>(
					key.ToString(), // EntityTrackingKey
					"MdiCdeVacc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiCdeVacc();
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
					c.MdiCdeVaccId = (System.Decimal)reader["MDI_CDE_VACC_ID"];
					c.OriginalMdiCdeVaccId = c.MdiCdeVaccId;
					c.VaccCode = (System.String)reader["VACC_CODE"];
					c.VaccAr = (System.String)reader["VACC_AR"];
					c.VaccEn = (System.String)reader["VACC_EN"];
					c.SideEffect = Convert.IsDBNull(reader["SIDE_EFFECT"]) ? null : (System.String)reader["SIDE_EFFECT"];
					c.DoesCount = Convert.IsDBNull(reader["DOES_COUNT"]) ? null : (System.Decimal?)reader["DOES_COUNT"];
					c.PeriodType = Convert.IsDBNull(reader["PERIOD_TYPE"]) ? null : (System.Decimal?)reader["PERIOD_TYPE"];
					c.DoesPeriod2 = Convert.IsDBNull(reader["DOES_PERIOD2"]) ? null : (System.Decimal?)reader["DOES_PERIOD2"];
					c.DoesPeriod3 = Convert.IsDBNull(reader["DOES_PERIOD3"]) ? null : (System.Decimal?)reader["DOES_PERIOD3"];
					c.ReVaccFlg = Convert.IsDBNull(reader["RE_VACC_FLG"]) ? null : (System.Decimal?)reader["RE_VACC_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiCdeVacc entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiCdeVaccId = (System.Decimal)reader[((int)MdiCdeVaccColumn.MdiCdeVaccId - 1)];
			entity.OriginalMdiCdeVaccId = (System.Decimal)reader["MDI_CDE_VACC_ID"];
			entity.VaccCode = (System.String)reader[((int)MdiCdeVaccColumn.VaccCode - 1)];
			entity.VaccAr = (System.String)reader[((int)MdiCdeVaccColumn.VaccAr - 1)];
			entity.VaccEn = (System.String)reader[((int)MdiCdeVaccColumn.VaccEn - 1)];
			entity.SideEffect = (reader.IsDBNull(((int)MdiCdeVaccColumn.SideEffect - 1)))?null:(System.String)reader[((int)MdiCdeVaccColumn.SideEffect - 1)];
			entity.DoesCount = (reader.IsDBNull(((int)MdiCdeVaccColumn.DoesCount - 1)))?null:(System.Decimal?)reader[((int)MdiCdeVaccColumn.DoesCount - 1)];
			entity.PeriodType = (reader.IsDBNull(((int)MdiCdeVaccColumn.PeriodType - 1)))?null:(System.Decimal?)reader[((int)MdiCdeVaccColumn.PeriodType - 1)];
			entity.DoesPeriod2 = (reader.IsDBNull(((int)MdiCdeVaccColumn.DoesPeriod2 - 1)))?null:(System.Decimal?)reader[((int)MdiCdeVaccColumn.DoesPeriod2 - 1)];
			entity.DoesPeriod3 = (reader.IsDBNull(((int)MdiCdeVaccColumn.DoesPeriod3 - 1)))?null:(System.Decimal?)reader[((int)MdiCdeVaccColumn.DoesPeriod3 - 1)];
			entity.ReVaccFlg = (reader.IsDBNull(((int)MdiCdeVaccColumn.ReVaccFlg - 1)))?null:(System.Decimal?)reader[((int)MdiCdeVaccColumn.ReVaccFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiCdeVacc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiCdeVaccId = (System.Decimal)dataRow["MDI_CDE_VACC_ID"];
			entity.OriginalMdiCdeVaccId = (System.Decimal)dataRow["MDI_CDE_VACC_ID"];
			entity.VaccCode = (System.String)dataRow["VACC_CODE"];
			entity.VaccAr = (System.String)dataRow["VACC_AR"];
			entity.VaccEn = (System.String)dataRow["VACC_EN"];
			entity.SideEffect = Convert.IsDBNull(dataRow["SIDE_EFFECT"]) ? null : (System.String)dataRow["SIDE_EFFECT"];
			entity.DoesCount = Convert.IsDBNull(dataRow["DOES_COUNT"]) ? null : (System.Decimal?)dataRow["DOES_COUNT"];
			entity.PeriodType = Convert.IsDBNull(dataRow["PERIOD_TYPE"]) ? null : (System.Decimal?)dataRow["PERIOD_TYPE"];
			entity.DoesPeriod2 = Convert.IsDBNull(dataRow["DOES_PERIOD2"]) ? null : (System.Decimal?)dataRow["DOES_PERIOD2"];
			entity.DoesPeriod3 = Convert.IsDBNull(dataRow["DOES_PERIOD3"]) ? null : (System.Decimal?)dataRow["DOES_PERIOD3"];
			entity.ReVaccFlg = Convert.IsDBNull(dataRow["RE_VACC_FLG"]) ? null : (System.Decimal?)dataRow["RE_VACC_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiCdeVacc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeVacc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeVacc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiCdeVaccId methods when available
			
			#region MdiStudVaccCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudVacc>|MdiStudVaccCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudVaccCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudVaccCollection = DataRepository.MdiStudVaccProvider.GetByMdiCdeVaccId(transactionManager, entity.MdiCdeVaccId);

				if (deep && entity.MdiStudVaccCollection.Count > 0)
				{
					deepHandles.Add("MdiStudVaccCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudVacc>) DataRepository.MdiStudVaccProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudVaccCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiCdeVacc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiCdeVacc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiCdeVacc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiCdeVacc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<MdiStudVacc>
				if (CanDeepSave(entity.MdiStudVaccCollection, "List<MdiStudVacc>|MdiStudVaccCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudVacc child in entity.MdiStudVaccCollection)
					{
						if(child.MdiCdeVaccIdSource != null)
						{
							child.MdiCdeVaccId = child.MdiCdeVaccIdSource.MdiCdeVaccId;
						}
						else
						{
							child.MdiCdeVaccId = entity.MdiCdeVaccId;
						}

					}

					if (entity.MdiStudVaccCollection.Count > 0 || entity.MdiStudVaccCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudVaccProvider.Save(transactionManager, entity.MdiStudVaccCollection);
						
						deepHandles.Add("MdiStudVaccCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudVacc >) DataRepository.MdiStudVaccProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudVaccCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiCdeVaccChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiCdeVacc</c>
	///</summary>
	public enum MdiCdeVaccChildEntityTypes
	{
		///<summary>
		/// Collection of <c>MdiCdeVacc</c> as OneToMany for MdiStudVaccCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudVacc>))]
		MdiStudVaccCollection,
	}
	
	#endregion MdiCdeVaccChildEntityTypes
	
	#region MdiCdeVaccFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiCdeVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeVacc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeVaccFilterBuilder : SqlFilterBuilder<MdiCdeVaccColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccFilterBuilder class.
		/// </summary>
		public MdiCdeVaccFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeVaccFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeVaccFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeVaccFilterBuilder
	
	#region MdiCdeVaccParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiCdeVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeVacc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiCdeVaccParameterBuilder : ParameterizedSqlFilterBuilder<MdiCdeVaccColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccParameterBuilder class.
		/// </summary>
		public MdiCdeVaccParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiCdeVaccParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiCdeVaccParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiCdeVaccParameterBuilder
	
	#region MdiCdeVaccSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiCdeVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiCdeVacc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiCdeVaccSortBuilder : SqlSortBuilder<MdiCdeVaccColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiCdeVaccSqlSortBuilder class.
		/// </summary>
		public MdiCdeVaccSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiCdeVaccSortBuilder
	
} // end namespace
