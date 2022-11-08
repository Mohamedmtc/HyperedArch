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
	/// This class is the base class for any <see cref="EdAcadYearProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadYearProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAcadYear, UMIS_VER2.BusinessLyer.EdAcadYearKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYearKey key)
		{
			return Delete(transactionManager, key.EdAcadYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAcadYearId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAcadYearId)
		{
			return Delete(null, _edAcadYearId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAcadYearId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdAcadYear Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYearKey key, int start, int pageLength)
		{
			return GetByEdAcadYearId(transactionManager, key.EdAcadYearId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="_yearCalender"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(System.Decimal _yearCalender)
		{
			int count = -1;
			return GetByYearCalender(null,_yearCalender, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="_yearCalender"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(System.Decimal _yearCalender, int start, int pageLength)
		{
			int count = -1;
			return GetByYearCalender(null, _yearCalender, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearCalender"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(TransactionManager transactionManager, System.Decimal _yearCalender)
		{
			int count = -1;
			return GetByYearCalender(transactionManager, _yearCalender, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearCalender"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(TransactionManager transactionManager, System.Decimal _yearCalender, int start, int pageLength)
		{
			int count = -1;
			return GetByYearCalender(transactionManager, _yearCalender, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="_yearCalender"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(System.Decimal _yearCalender, int start, int pageLength, out int count)
		{
			return GetByYearCalender(null, _yearCalender, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_CALENDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearCalender"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadYear GetByYearCalender(TransactionManager transactionManager, System.Decimal _yearCalender, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadYear GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="_yearOrder"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(System.Decimal _yearOrder)
		{
			int count = -1;
			return GetByYearOrder(null,_yearOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="_yearOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(System.Decimal _yearOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByYearOrder(null, _yearOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearOrder"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(TransactionManager transactionManager, System.Decimal _yearOrder)
		{
			int count = -1;
			return GetByYearOrder(transactionManager, _yearOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(TransactionManager transactionManager, System.Decimal _yearOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByYearOrder(transactionManager, _yearOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="_yearOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(System.Decimal _yearOrder, int start, int pageLength, out int count)
		{
			return GetByYearOrder(null, _yearOrder, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_YEAR_ORDER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_yearOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadYear GetByYearOrder(TransactionManager transactionManager, System.Decimal _yearOrder, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_YEAR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadYear GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAcadYear&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAcadYear&gt;"/></returns>
		public static TList<EdAcadYear> Fill(IDataReader reader, TList<EdAcadYear> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAcadYear c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAcadYear")
					.Append("|").Append((System.Decimal)reader["ED_ACAD_YEAR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAcadYear>(
					key.ToString(), // EntityTrackingKey
					"EdAcadYear",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAcadYear();
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
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.OriginalEdAcadYearId = c.EdAcadYearId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.YearCode = Convert.IsDBNull(reader["YEAR_CODE"]) ? null : (System.String)reader["YEAR_CODE"];
					c.YearOrder = (System.Decimal)reader["YEAR_ORDER"];
					c.YearCalender = (System.Decimal)reader["YEAR_CALENDER"];
					c.CurrentYear = (System.Decimal)reader["CURRENT_YEAR"];
					c.IsClosed = Convert.IsDBNull(reader["IS_CLOSED"]) ? null : (System.Decimal?)reader["IS_CLOSED"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAcadYear entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdAcadYearColumn.EdAcadYearId - 1)];
			entity.OriginalEdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
			entity.DescrAr = (System.String)reader[((int)EdAcadYearColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdAcadYearColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdAcadYearColumn.DescrEn - 1)];
			entity.YearCode = (reader.IsDBNull(((int)EdAcadYearColumn.YearCode - 1)))?null:(System.String)reader[((int)EdAcadYearColumn.YearCode - 1)];
			entity.YearOrder = (System.Decimal)reader[((int)EdAcadYearColumn.YearOrder - 1)];
			entity.YearCalender = (System.Decimal)reader[((int)EdAcadYearColumn.YearCalender - 1)];
			entity.CurrentYear = (System.Decimal)reader[((int)EdAcadYearColumn.CurrentYear - 1)];
			entity.IsClosed = (reader.IsDBNull(((int)EdAcadYearColumn.IsClosed - 1)))?null:(System.Decimal?)reader[((int)EdAcadYearColumn.IsClosed - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAcadYear entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.OriginalEdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.YearCode = Convert.IsDBNull(dataRow["YEAR_CODE"]) ? null : (System.String)dataRow["YEAR_CODE"];
			entity.YearOrder = (System.Decimal)dataRow["YEAR_ORDER"];
			entity.YearCalender = (System.Decimal)dataRow["YEAR_CALENDER"];
			entity.CurrentYear = (System.Decimal)dataRow["CURRENT_YEAR"];
			entity.IsClosed = Convert.IsDBNull(dataRow["IS_CLOSED"]) ? null : (System.Decimal?)dataRow["IS_CLOSED"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadYear"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadYear Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdAcadYearId methods when available
			
			#region EdStudFacultyCollectionGetByEdAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEdAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEdAcadYearId = DataRepository.EdStudFacultyProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudFacultyCollectionGetByEdAcadYearId.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyInstallmentCollection = DataRepository.FeeFacultyInstallmentProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeFacultyInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyInstallment>) DataRepository.FeeFacultyInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTrans>|EdStudTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransCollection = DataRepository.EdStudTransProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudTransCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTrans>) DataRepository.EdStudTransProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAccntYear
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "FeeAccntYear|FeeAccntYear", deepLoadType, innerList))
			{
				entity.FeeAccntYear = DataRepository.FeeAccntYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccntYear' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.FeeAccntYear != null)
				{
					deepHandles.Add("FeeAccntYear",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< FeeAccntYear >) DataRepository.FeeAccntYearProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAccntYear, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadYearFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadYearFacultyCollection = DataRepository.EdAcadYearFacultyProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdAcadYearFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadYearFaculty>) DataRepository.EdAcadYearFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaOfficeHourCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaOfficeHour>|SaOfficeHourCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaOfficeHourCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaOfficeHourCollection = DataRepository.SaOfficeHourProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SaOfficeHourCollection.Count > 0)
				{
					deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaOfficeHour>) DataRepository.SaOfficeHourProvider.DeepLoad,
						new object[] { transactionManager, entity.SaOfficeHourCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudNatSimilarityRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudNatSimilarityRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudNatSimilarityRequestCollection = DataRepository.FeeStudNatSimilarityRequestProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudNatSimilarityRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudNatSimilarityRequest>) DataRepository.FeeStudNatSimilarityRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOpenAcadSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOpenAcadSemester>|AdmOpenAcadSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOpenAcadSemesterCollection = DataRepository.AdmOpenAcadSemesterProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AdmOpenAcadSemesterCollection.Count > 0)
				{
					deepHandles.Add("AdmOpenAcadSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOpenAcadSemester>) DataRepository.AdmOpenAcadSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOpenAcadSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollectionGetByEdAcadYearReqId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdAcadYearReqId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollectionGetByEdAcadYearReqId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId = DataRepository.EdStudIntTrnsProvider.GetByEdAcadYearReqId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollectionGetByEdAcadYearReqId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgMdDataCollection = DataRepository.EntCoursePkgMdDataProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntCoursePkgMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgMdData>) DataRepository.EntCoursePkgMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserBondReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserBondReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserBondReqCollection = DataRepository.FeeUserBondReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeUserBondReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserBondReq>) DataRepository.FeeUserBondReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserBondReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGraduationAward>|EdGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGraduationAwardCollection = DataRepository.EdGraduationAwardProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGraduationAward>) DataRepository.EdGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomWfRequestApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfRequestApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomWfRequestApproveCollection = DataRepository.AccomWfRequestApproveProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AccomWfRequestApproveCollection.Count > 0)
				{
					deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomWfRequestApprove>) DataRepository.AccomWfRequestApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProject>|EdProjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjectCollection = DataRepository.EdProjectProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdProjectCollection.Count > 0)
				{
					deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProject>) DataRepository.EdProjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudRegisterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterCollection = DataRepository.RsrchStudRegisterProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.RsrchStudRegisterCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegister>) DataRepository.RsrchStudRegisterProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollectionGetByEdAcadYearToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdAcadYearToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollectionGetByEdAcadYearToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollectionGetByEdAcadYearToId = DataRepository.SpoSponsorOfferProvider.GetByEdAcadYearToId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorOfferCollectionGetByEdAcadYearToId.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTchng>|EdCourseTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTchngCollection = DataRepository.EdCourseTchngProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdCourseTchngCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTchng>) DataRepository.EdCourseTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTchngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollectionGetByEdAcadYearToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdAcadYearToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollectionGetByEdAcadYearToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollectionGetByEdAcadYearToId = DataRepository.SpoSponsorStudProvider.GetByEdAcadYearToId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorStudCollectionGetByEdAcadYearToId.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControl>|CoControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlCollection = DataRepository.CoControlProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlan>|EdAcadPlanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanCollection = DataRepository.EdAcadPlanProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdAcadPlanCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlan>) DataRepository.EdAcadPlanProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserTaskCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserTask>|SvUserTaskCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserTaskCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserTaskCollection = DataRepository.SvUserTaskProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvUserTaskCollection.Count > 0)
				{
					deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserTask>) DataRepository.SvUserTaskProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserTaskCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudRecordCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudRecord>|MdiStudRecordCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudRecordCollection = DataRepository.MdiStudRecordProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MdiStudRecordCollection.Count > 0)
				{
					deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudRecord>) DataRepository.MdiStudRecordProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudRecordCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollectionGetByEdAcadYearJoinId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdAcadYearJoinId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEdAcadYearJoinId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEdAcadYearJoinId = DataRepository.EdStudFacultyProvider.GetByEdAcadYearJoinId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudFacultyCollectionGetByEdAcadYearJoinId.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEdAcadYearJoinId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearJoinId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacItemAdmYearCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacItemAdmYear>|FeeFacItemAdmYearCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacItemAdmYearCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacItemAdmYearCollection = DataRepository.FeeFacItemAdmYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeFacItemAdmYearCollection.Count > 0)
				{
					deepHandles.Add("FeeFacItemAdmYearCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacItemAdmYear>) DataRepository.FeeFacItemAdmYearProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacItemAdmYearCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudItemCnclCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudItemCnclCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudItemCnclCollection = DataRepository.FeeStudItemCnclProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudItemCnclCollection.Count > 0)
				{
					deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudItemCncl>) DataRepository.FeeStudItemCnclProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudItemCnclCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudBranchPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudBranchPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudBranchPrefCollection = DataRepository.EdStudBranchPrefProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudBranchPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudBranchPref>) DataRepository.EdStudBranchPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudBranchPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcdadvRmkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcdadvRmkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcdadvRmkCollection = DataRepository.EdAcdadvRmkProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdAcdadvRmkCollection.Count > 0)
				{
					deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcdadvRmk>) DataRepository.EdAcdadvRmkProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcdadvRmkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyHdrCollection = DataRepository.SvSrvyHdrProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvSrvyHdrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyHdr>) DataRepository.SvSrvyHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudPayPostponeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudPayPostponeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudPayPostponeCollection = DataRepository.FeeStudPayPostponeProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudPayPostponeCollection.Count > 0)
				{
					deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudPayPostpone>) DataRepository.FeeStudPayPostponeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollectionGetByEdAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollectionGetByEdAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollectionGetByEdAcadYearId = DataRepository.SpoSponsorStudProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorStudCollectionGetByEdAcadYearId.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeLimitRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeLimitRule>|FeeLimitRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeLimitRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudInfo>|MltStudInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudInfoCollection = DataRepository.MltStudInfoProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MltStudInfoCollection.Count > 0)
				{
					deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudInfo>) DataRepository.MltStudInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeTreasuryReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasuryReq>|FeeTreasuryReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryReqCollection = DataRepository.FeeTreasuryReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeTreasuryReqCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasuryReq>) DataRepository.FeeTreasuryReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudAllowanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudAllowanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudAllowanceCollection = DataRepository.FeeStudAllowanceProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudAllowanceCollection.Count > 0)
				{
					deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudAllowance>) DataRepository.FeeStudAllowanceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudAllowanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollectionGetByEdAcadYearFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdAcadYearFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollectionGetByEdAcadYearFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId = DataRepository.SpoSponsorOfferProvider.GetByEdAcadYearFromId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollectionGetByEdAcadYearFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadmicAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadmicAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadmicAdvCollection = DataRepository.EdStudAcadmicAdvProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudAcadmicAdvCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadmicAdv>) DataRepository.EdStudAcadmicAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceWarnCollection = DataRepository.AccomStudAbsenceWarnProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AccomStudAbsenceWarnCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsenceWarn>) DataRepository.AccomStudAbsenceWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdInttransRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdInttransRule>|EdInttransRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdInttransRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdInttransRuleCollection = DataRepository.EdInttransRuleProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdInttransRuleCollection.Count > 0)
				{
					deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdInttransRule>) DataRepository.EdInttransRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdInttransRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MilCodeCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MilCodeCourse>|MilCodeCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MilCodeCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MilCodeCourseCollection = DataRepository.MilCodeCourseProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MilCodeCourseCollection.Count > 0)
				{
					deepHandles.Add("MilCodeCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MilCodeCourse>) DataRepository.MilCodeCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.MilCodeCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFundCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFund>|FeeStudFundCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFundCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFundCollection = DataRepository.FeeStudFundProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudFundCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFund>) DataRepository.FeeStudFundProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFundCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaDtlCollectionGetByFAdmAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollectionGetByFAdmAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaDtlCollectionGetByFAdmAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId = DataRepository.EdSemAgendaDtlProvider.GetByFAdmAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId.Count > 0)
				{
					deepHandles.Add("EdSemAgendaDtlCollectionGetByFAdmAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaDtl>) DataRepository.EdSemAgendaDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCdeDiscTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeDiscTypeCollection = DataRepository.FeeCdeDiscTypeProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeCdeDiscTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeDiscType>) DataRepository.FeeCdeDiscTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudCoursesItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudCoursesItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterOpenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeTreasuryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasury>|FeeTreasuryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryCollection = DataRepository.FeeTreasuryProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeTreasuryCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasury>) DataRepository.FeeTreasuryProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudExp>|CtrStudExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudClnqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudClnq>|MdiStudClnqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudClnqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudClnqCollection = DataRepository.MdiStudClnqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MdiStudClnqCollection.Count > 0)
				{
					deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudClnq>) DataRepository.MdiStudClnqProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudClnqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAgendaHolidayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAgendaHoliday>|GsAgendaHolidayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAgendaHolidayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAgendaHolidayCollection = DataRepository.GsAgendaHolidayProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.GsAgendaHolidayCollection.Count > 0)
				{
					deepHandles.Add("GsAgendaHolidayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAgendaHoliday>) DataRepository.GsAgendaHolidayProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAgendaHolidayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdAcadYearId = DataRepository.EdStudViolProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudViolCollectionGetByEdAcadYearId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceCollection = DataRepository.AccomStudAbsenceProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AccomStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsence>) DataRepository.AccomStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgOffering>|PgOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgOfferingCollection = DataRepository.PgOfferingProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgOfferingCollection.Count > 0)
				{
					deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgOffering>) DataRepository.PgOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.PgOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgHdrCollection = DataRepository.EntCoursePkgHdrProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntCoursePkgHdrCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgHdr>) DataRepository.EntCoursePkgHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransFromReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransFromReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransFromReqCollection = DataRepository.EdStudTransFromReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudTransFromReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTransFromReq>) DataRepository.EdStudTransFromReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransFromReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentCollection = DataRepository.FeeStudInstallmentProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallment>) DataRepository.FeeStudInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmFeePromocodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmFeePromocode>|AdmFeePromocodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmFeePromocodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmFeePromocodeCollection = DataRepository.AdmFeePromocodeProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AdmFeePromocodeCollection.Count > 0)
				{
					deepHandles.Add("AdmFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmFeePromocode>) DataRepository.AdmFeePromocodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmFeePromocodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBranchRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchRule>|EdBranchRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchRuleCollection = DataRepository.EdBranchRuleProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdBranchRuleCollection.Count > 0)
				{
					deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchRule>) DataRepository.EdBranchRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudSemesterCollection = DataRepository.SpoSponsorStudSemesterProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStudSemester>) DataRepository.SpoSponsorStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollection = DataRepository.EdStudProblemProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudProblemCollection.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemSemester>|FeeItemSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemSemesterCollection = DataRepository.FeeItemSemesterProvider.GetByEdAcadYearJoinId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeItemSemesterCollection.Count > 0)
				{
					deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemSemester>) DataRepository.FeeItemSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudOut>|CtrStudOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoOfferStudExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferStudExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferStudExceptionCollection = DataRepository.SpoOfferStudExceptionProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoOfferStudExceptionCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferStudException>) DataRepository.SpoOfferStudExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAccomItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAccomItem>|FeeAccomItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccomItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAccomItemCollection = DataRepository.FeeAccomItemProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeAccomItemCollection.Count > 0)
				{
					deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAccomItem>) DataRepository.FeeAccomItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAccomItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqCollection = DataRepository.EdStudExmptReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudExmptReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReq>) DataRepository.EdStudExmptReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudRetrieveRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudRetrieveRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudRetrieveRequestCollection = DataRepository.FeeStudRetrieveRequestProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudRetrieveRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudRetrieveRequest>) DataRepository.FeeStudRetrieveRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdAcadYearStopToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearStopToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdAcadYearStopToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdAcadYearStopToId = DataRepository.EdStudViolProvider.GetByEdAcadYearStopToId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudViolCollectionGetByEdAcadYearStopToId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdAcadYearStopToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeBusLineItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeBusLineItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeBusLineItemCollection = DataRepository.FeeBusLineItemProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeBusLineItemCollection.Count > 0)
				{
					deepHandles.Add("FeeBusLineItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeBusLineItem>) DataRepository.FeeBusLineItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeBusLineItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantDegreeCollection = DataRepository.PgThesisGrantDegreeProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgThesisGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantDegree>) DataRepository.PgThesisGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExecuseReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExecuseReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExecuseReqCollection = DataRepository.EdStudExecuseReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudExecuseReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExecuseReq>) DataRepository.EdStudExecuseReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExecuseReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeUserFundReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeUserFundReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeUserFundReqCollection = DataRepository.FeeUserFundReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeUserFundReqCollection.Count > 0)
				{
					deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeUserFundReq>) DataRepository.FeeUserFundReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeUserFundReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollection = DataRepository.EdOfferingProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdOfferingCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentRequestCollection = DataRepository.FeeStudInstallmentRequestProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudInstallmentRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallmentRequest>) DataRepository.FeeStudInstallmentRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEdAcadYearPlnId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayStudStsCollectionGetByEdAcadYearJoinId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayStudSts>|MltRptDayStudStsCollectionGetByEdAcadYearJoinId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayStudStsCollectionGetByEdAcadYearJoinId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId = DataRepository.MltRptDayStudStsProvider.GetByEdAcadYearJoinId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId.Count > 0)
				{
					deepHandles.Add("MltRptDayStudStsCollectionGetByEdAcadYearJoinId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayStudSts>) DataRepository.MltRptDayStudStsProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPrecondMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPrecondMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPrecondMdDataCollection = DataRepository.EntPrecondMdDataProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntPrecondMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPrecondMdData>) DataRepository.EntPrecondMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPrecondMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudCarStkrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudCarStkrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudCarStkrCollection = DataRepository.TrnsStudCarStkrProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.TrnsStudCarStkrCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudCarStkr>) DataRepository.TrnsStudCarStkrProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessage>|SvMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageCollection = DataRepository.SvMessageProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvMessageCollection.Count > 0)
				{
					deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessage>) DataRepository.SvMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetByEdAcadYearToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdAcadYearToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdAcadYearToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId = DataRepository.EdStudEnrollChangeProvider.GetByEdAcadYearToId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudPostponeReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudPostponeReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvCollection = DataRepository.SvStudAskAdvProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvStudAskAdvCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdv>) DataRepository.SvStudAskAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudPublishCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudPublish>|PgStudPublishCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudPublishCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudPublishCollection = DataRepository.PgStudPublishProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgStudPublishCollection.Count > 0)
				{
					deepHandles.Add("PgStudPublishCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudPublish>) DataRepository.PgStudPublishProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudPublishCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferExtCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferExtCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferExtCollection = DataRepository.SpoSponsorOfferExtProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SpoSponsorOfferExtCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOfferExt>) DataRepository.SpoSponsorOfferExtProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdPrintReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdPrintReq>|EdPrintReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdPrintReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudTravelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudTravel>|PgStudTravelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudTravelCollection = DataRepository.PgStudTravelProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgStudTravelCollection.Count > 0)
				{
					deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudTravel>) DataRepository.PgStudTravelProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudTravelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaDtlCollectionGetByTAdmAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollectionGetByTAdmAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaDtlCollectionGetByTAdmAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId = DataRepository.EdSemAgendaDtlProvider.GetByTAdmAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId.Count > 0)
				{
					deepHandles.Add("EdSemAgendaDtlCollectionGetByTAdmAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaDtl>) DataRepository.EdSemAgendaDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntFullfillMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntFullfillMdDataCollection = DataRepository.EntFullfillMdDataProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntFullfillMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntFullfillMdData>) DataRepository.EntFullfillMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntFullfillMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollectionGetByEdAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollectionGetByEdAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollectionGetByEdAcadYearId = DataRepository.EdStudIntTrnsProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudIntTrnsCollectionGetByEdAcadYearId.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudHosptlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudHosptlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudHosptlCollection = DataRepository.MdiStudHosptlProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MdiStudHosptlCollection.Count > 0)
				{
					deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudHosptl>) DataRepository.MdiStudHosptlProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudHosptlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCourseExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCourseExp>|FeeCourseExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCourseExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCourseExpCollection = DataRepository.FeeCourseExpProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeCourseExpCollection.Count > 0)
				{
					deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCourseExp>) DataRepository.FeeCourseExpProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCourseExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetByEdAcadYearFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdAcadYearFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdAcadYearFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId = DataRepository.EdStudEnrollChangeProvider.GetByEdAcadYearFromId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdAcadYearFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInstlmntRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInstlmntRuleCollection = DataRepository.FeeInstlmntRuleProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.FeeInstlmntRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntRule>) DataRepository.FeeInstlmntRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTraining>|EdTrainingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainingCollection = DataRepository.EdTrainingProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdTrainingCollection.Count > 0)
				{
					deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTraining>) DataRepository.EdTrainingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlPeriodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlPeriodCollection = DataRepository.ScSchdlPeriodProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.ScSchdlPeriodCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlPeriod>) DataRepository.ScSchdlPeriodProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlPeriodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdAcadYearStopFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearStopFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdAcadYearStopFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdAcadYearStopFromId = DataRepository.EdStudViolProvider.GetByEdAcadYearStopFromId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudViolCollectionGetByEdAcadYearStopFromId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdAcadYearStopFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudConferenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudConference>|PgStudConferenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudConferenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudConferenceCollection = DataRepository.PgStudConferenceProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.PgStudConferenceCollection.Count > 0)
				{
					deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudConference>) DataRepository.PgStudConferenceProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudConferenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvLecNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvLecNote>|SvLecNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvLecNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvLecNoteCollection = DataRepository.SvLecNoteProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.SvLecNoteCollection.Count > 0)
				{
					deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvLecNote>) DataRepository.SvLecNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.SvLecNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStaffCoursePrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStaffCoursePrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStaffCoursePrefCollection = DataRepository.EdStaffCoursePrefProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EdStaffCoursePrefCollection.Count > 0)
				{
					deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStaffCoursePref>) DataRepository.EdStaffCoursePrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayStudStsCollectionGetByEdAcadYearId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayStudSts>|MltRptDayStudStsCollectionGetByEdAcadYearId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayStudStsCollectionGetByEdAcadYearId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayStudStsCollectionGetByEdAcadYearId = DataRepository.MltRptDayStudStsProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.MltRptDayStudStsCollectionGetByEdAcadYearId.Count > 0)
				{
					deepHandles.Add("MltRptDayStudStsCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayStudSts>) DataRepository.MltRptDayStudStsProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCourseMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCourseMdData>|EntCourseMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCourseMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCourseMdDataCollection = DataRepository.EntCourseMdDataProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.EntCourseMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCourseMdData>) DataRepository.EntCourseMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCourseMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollection = DataRepository.GsCommProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);

				if (deep && entity.GsCommCollection.Count > 0)
				{
					deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAcadYear object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAcadYear instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadYear Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeAccntYear
			if (CanDeepSave(entity.FeeAccntYear, "FeeAccntYear|FeeAccntYear", deepSaveType, innerList))
			{

				if (entity.FeeAccntYear != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.FeeAccntYear.EdAcadYearId = entity.EdAcadYearId;
					//DataRepository.FeeAccntYearProvider.Save(transactionManager, entity.FeeAccntYear);
					deepHandles.Add("FeeAccntYear",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< FeeAccntYear >) DataRepository.FeeAccntYearProvider.DeepSave,
						new object[] { transactionManager, entity.FeeAccntYear, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEdAcadYearId, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEdAcadYearId)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEdAcadYearId.Count > 0 || entity.EdStudFacultyCollectionGetByEdAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearId);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyInstallment>
				if (CanDeepSave(entity.FeeFacultyInstallmentCollection, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyInstallment child in entity.FeeFacultyInstallmentCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeFacultyInstallmentCollection.Count > 0 || entity.FeeFacultyInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyInstallmentProvider.Save(transactionManager, entity.FeeFacultyInstallmentCollection);
						
						deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyInstallment >) DataRepository.FeeFacultyInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTrans>
				if (CanDeepSave(entity.EdStudTransCollection, "List<EdStudTrans>|EdStudTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTrans child in entity.EdStudTransCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudTransCollection.Count > 0 || entity.EdStudTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransProvider.Save(transactionManager, entity.EdStudTransCollection);
						
						deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTrans >) DataRepository.EdStudTransProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadYearFaculty>
				if (CanDeepSave(entity.EdAcadYearFacultyCollection, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadYearFaculty child in entity.EdAcadYearFacultyCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdAcadYearFacultyCollection.Count > 0 || entity.EdAcadYearFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadYearFacultyProvider.Save(transactionManager, entity.EdAcadYearFacultyCollection);
						
						deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadYearFaculty >) DataRepository.EdAcadYearFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaOfficeHour>
				if (CanDeepSave(entity.SaOfficeHourCollection, "List<SaOfficeHour>|SaOfficeHourCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaOfficeHour child in entity.SaOfficeHourCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SaOfficeHourCollection.Count > 0 || entity.SaOfficeHourCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaOfficeHourProvider.Save(transactionManager, entity.SaOfficeHourCollection);
						
						deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaOfficeHour >) DataRepository.SaOfficeHourProvider.DeepSave,
							new object[] { transactionManager, entity.SaOfficeHourCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudNatSimilarityRequest>
				if (CanDeepSave(entity.FeeStudNatSimilarityRequestCollection, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudNatSimilarityRequest child in entity.FeeStudNatSimilarityRequestCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudNatSimilarityRequestCollection.Count > 0 || entity.FeeStudNatSimilarityRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudNatSimilarityRequestProvider.Save(transactionManager, entity.FeeStudNatSimilarityRequestCollection);
						
						deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudNatSimilarityRequest >) DataRepository.FeeStudNatSimilarityRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOpenAcadSemester>
				if (CanDeepSave(entity.AdmOpenAcadSemesterCollection, "List<AdmOpenAcadSemester>|AdmOpenAcadSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOpenAcadSemester child in entity.AdmOpenAcadSemesterCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AdmOpenAcadSemesterCollection.Count > 0 || entity.AdmOpenAcadSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterCollection);
						
						deepHandles.Add("AdmOpenAcadSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOpenAcadSemester >) DataRepository.AdmOpenAcadSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOpenAcadSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdAcadYearReqId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId)
					{
						if(child.EdAcadYearReqIdSource != null)
						{
							child.EdAcadYearReqId = child.EdAcadYearReqIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearReqId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId.Count > 0 || entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId);
						
						deepHandles.Add("EdStudIntTrnsCollectionGetByEdAcadYearReqId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearReqId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgMdData>
				if (CanDeepSave(entity.EntCoursePkgMdDataCollection, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgMdData child in entity.EntCoursePkgMdDataCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntCoursePkgMdDataCollection.Count > 0 || entity.EntCoursePkgMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgMdDataProvider.Save(transactionManager, entity.EntCoursePkgMdDataCollection);
						
						deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgMdData >) DataRepository.EntCoursePkgMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeUserBondReq>
				if (CanDeepSave(entity.FeeUserBondReqCollection, "List<FeeUserBondReq>|FeeUserBondReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserBondReq child in entity.FeeUserBondReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeUserBondReqCollection.Count > 0 || entity.FeeUserBondReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserBondReqProvider.Save(transactionManager, entity.FeeUserBondReqCollection);
						
						deepHandles.Add("FeeUserBondReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserBondReq >) DataRepository.FeeUserBondReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserBondReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGraduationAward>
				if (CanDeepSave(entity.EdGraduationAwardCollection, "List<EdGraduationAward>|EdGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGraduationAward child in entity.EdGraduationAwardCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdGraduationAwardCollection.Count > 0 || entity.EdGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardCollection);
						
						deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGraduationAward >) DataRepository.EdGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGraduationAwardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomWfRequestApprove>
				if (CanDeepSave(entity.AccomWfRequestApproveCollection, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomWfRequestApprove child in entity.AccomWfRequestApproveCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AccomWfRequestApproveCollection.Count > 0 || entity.AccomWfRequestApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomWfRequestApproveProvider.Save(transactionManager, entity.AccomWfRequestApproveCollection);
						
						deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomWfRequestApprove >) DataRepository.AccomWfRequestApproveProvider.DeepSave,
							new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProject>
				if (CanDeepSave(entity.EdProjectCollection, "List<EdProject>|EdProjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProject child in entity.EdProjectCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdProjectCollection.Count > 0 || entity.EdProjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjectProvider.Save(transactionManager, entity.EdProjectCollection);
						
						deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProject >) DataRepository.EdProjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudRegister>
				if (CanDeepSave(entity.RsrchStudRegisterCollection, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegister child in entity.RsrchStudRegisterCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.RsrchStudRegisterCollection.Count > 0 || entity.RsrchStudRegisterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterProvider.Save(transactionManager, entity.RsrchStudRegisterCollection);
						
						deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegister >) DataRepository.RsrchStudRegisterProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollectionGetByEdAcadYearToId, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdAcadYearToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollectionGetByEdAcadYearToId)
					{
						if(child.EdAcadYearToIdSource != null)
						{
							child.EdAcadYearToId = child.EdAcadYearToIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearToId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorOfferCollectionGetByEdAcadYearToId.Count > 0 || entity.SpoSponsorOfferCollectionGetByEdAcadYearToId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearToId);
						
						deepHandles.Add("SpoSponsorOfferCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTchng>
				if (CanDeepSave(entity.EdCourseTchngCollection, "List<EdCourseTchng>|EdCourseTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTchng child in entity.EdCourseTchngCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdCourseTchngCollection.Count > 0 || entity.EdCourseTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTchngProvider.Save(transactionManager, entity.EdCourseTchngCollection);
						
						deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTchng >) DataRepository.EdCourseTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTchngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollectionGetByEdAcadYearToId, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdAcadYearToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollectionGetByEdAcadYearToId)
					{
						if(child.EdAcadYearToIdSource != null)
						{
							child.EdAcadYearToId = child.EdAcadYearToIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearToId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorStudCollectionGetByEdAcadYearToId.Count > 0 || entity.SpoSponsorStudCollectionGetByEdAcadYearToId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearToId);
						
						deepHandles.Add("SpoSponsorStudCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControl>
				if (CanDeepSave(entity.CoControlCollection, "List<CoControl>|CoControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControl child in entity.CoControlCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.CoControlCollection.Count > 0 || entity.CoControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlCollection);
						
						deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControl >) DataRepository.CoControlProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudAcadWarnCollection.Count > 0 || entity.EdStudAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadWarnProvider.Save(transactionManager, entity.EdStudAcadWarnCollection);
						
						deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadWarn >) DataRepository.EdStudAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlan>
				if (CanDeepSave(entity.EdAcadPlanCollection, "List<EdAcadPlan>|EdAcadPlanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlan child in entity.EdAcadPlanCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdAcadPlanCollection.Count > 0 || entity.EdAcadPlanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanProvider.Save(transactionManager, entity.EdAcadPlanCollection);
						
						deepHandles.Add("EdAcadPlanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlan >) DataRepository.EdAcadPlanProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserTask>
				if (CanDeepSave(entity.SvUserTaskCollection, "List<SvUserTask>|SvUserTaskCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserTask child in entity.SvUserTaskCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvUserTaskCollection.Count > 0 || entity.SvUserTaskCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserTaskProvider.Save(transactionManager, entity.SvUserTaskCollection);
						
						deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserTask >) DataRepository.SvUserTaskProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserTaskCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudRecord>
				if (CanDeepSave(entity.MdiStudRecordCollection, "List<MdiStudRecord>|MdiStudRecordCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudRecord child in entity.MdiStudRecordCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.MdiStudRecordCollection.Count > 0 || entity.MdiStudRecordCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordCollection);
						
						deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudRecord >) DataRepository.MdiStudRecordProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudRecordCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEdAcadYearJoinId, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdAcadYearJoinId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEdAcadYearJoinId)
					{
						if(child.EdAcadYearJoinIdSource != null)
						{
							child.EdAcadYearJoinId = child.EdAcadYearJoinIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearJoinId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEdAcadYearJoinId.Count > 0 || entity.EdStudFacultyCollectionGetByEdAcadYearJoinId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearJoinId);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEdAcadYearJoinId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdAcadYearJoinId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacItemAdmYear>
				if (CanDeepSave(entity.FeeFacItemAdmYearCollection, "List<FeeFacItemAdmYear>|FeeFacItemAdmYearCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacItemAdmYear child in entity.FeeFacItemAdmYearCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeFacItemAdmYearCollection.Count > 0 || entity.FeeFacItemAdmYearCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacItemAdmYearProvider.Save(transactionManager, entity.FeeFacItemAdmYearCollection);
						
						deepHandles.Add("FeeFacItemAdmYearCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacItemAdmYear >) DataRepository.FeeFacItemAdmYearProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacItemAdmYearCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudItemCncl>
				if (CanDeepSave(entity.FeeStudItemCnclCollection, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudItemCncl child in entity.FeeStudItemCnclCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudItemCnclCollection.Count > 0 || entity.FeeStudItemCnclCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudItemCnclProvider.Save(transactionManager, entity.FeeStudItemCnclCollection);
						
						deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudItemCncl >) DataRepository.FeeStudItemCnclProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudItemCnclCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudBranchPref>
				if (CanDeepSave(entity.EdStudBranchPrefCollection, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudBranchPref child in entity.EdStudBranchPrefCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudBranchPrefCollection.Count > 0 || entity.EdStudBranchPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudBranchPrefProvider.Save(transactionManager, entity.EdStudBranchPrefCollection);
						
						deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudBranchPref >) DataRepository.EdStudBranchPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudBranchPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcdadvRmk>
				if (CanDeepSave(entity.EdAcdadvRmkCollection, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcdadvRmk child in entity.EdAcdadvRmkCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdAcdadvRmkCollection.Count > 0 || entity.EdAcdadvRmkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcdadvRmkProvider.Save(transactionManager, entity.EdAcdadvRmkCollection);
						
						deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcdadvRmk >) DataRepository.EdAcdadvRmkProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcdadvRmkCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyHdr>
				if (CanDeepSave(entity.SvSrvyHdrCollection, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyHdr child in entity.SvSrvyHdrCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvSrvyHdrCollection.Count > 0 || entity.SvSrvyHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrCollection);
						
						deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyHdr >) DataRepository.SvSrvyHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudPayPostpone>
				if (CanDeepSave(entity.FeeStudPayPostponeCollection, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudPayPostpone child in entity.FeeStudPayPostponeCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudPayPostponeCollection.Count > 0 || entity.FeeStudPayPostponeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudPayPostponeProvider.Save(transactionManager, entity.FeeStudPayPostponeCollection);
						
						deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudPayPostpone >) DataRepository.FeeStudPayPostponeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollectionGetByEdAcadYearId, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollectionGetByEdAcadYearId)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorStudCollectionGetByEdAcadYearId.Count > 0 || entity.SpoSponsorStudCollectionGetByEdAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearId);
						
						deepHandles.Add("SpoSponsorStudCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeLimitRule>
				if (CanDeepSave(entity.FeeLimitRuleCollection, "List<FeeLimitRule>|FeeLimitRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeLimitRule child in entity.FeeLimitRuleCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeLimitRuleCollection.Count > 0 || entity.FeeLimitRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeLimitRuleProvider.Save(transactionManager, entity.FeeLimitRuleCollection);
						
						deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeLimitRule >) DataRepository.FeeLimitRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeLimitRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltStudInfo>
				if (CanDeepSave(entity.MltStudInfoCollection, "List<MltStudInfo>|MltStudInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudInfo child in entity.MltStudInfoCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.MltStudInfoCollection.Count > 0 || entity.MltStudInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudInfoProvider.Save(transactionManager, entity.MltStudInfoCollection);
						
						deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudInfo >) DataRepository.MltStudInfoProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeTreasuryReq>
				if (CanDeepSave(entity.FeeTreasuryReqCollection, "List<FeeTreasuryReq>|FeeTreasuryReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasuryReq child in entity.FeeTreasuryReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeTreasuryReqCollection.Count > 0 || entity.FeeTreasuryReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryReqProvider.Save(transactionManager, entity.FeeTreasuryReqCollection);
						
						deepHandles.Add("FeeTreasuryReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasuryReq >) DataRepository.FeeTreasuryReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudAllowance>
				if (CanDeepSave(entity.FeeStudAllowanceCollection, "List<FeeStudAllowance>|FeeStudAllowanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudAllowance child in entity.FeeStudAllowanceCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudAllowanceCollection.Count > 0 || entity.FeeStudAllowanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudAllowanceProvider.Save(transactionManager, entity.FeeStudAllowanceCollection);
						
						deepHandles.Add("FeeStudAllowanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudAllowance >) DataRepository.FeeStudAllowanceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudAllowanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdAcadYearFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId)
					{
						if(child.EdAcadYearFromIdSource != null)
						{
							child.EdAcadYearFromId = child.EdAcadYearFromIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearFromId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId.Count > 0 || entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId);
						
						deepHandles.Add("SpoSponsorOfferCollectionGetByEdAcadYearFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdAcadYearFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadmicAdv>
				if (CanDeepSave(entity.EdStudAcadmicAdvCollection, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadmicAdv child in entity.EdStudAcadmicAdvCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudAcadmicAdvCollection.Count > 0 || entity.EdStudAcadmicAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadmicAdvProvider.Save(transactionManager, entity.EdStudAcadmicAdvCollection);
						
						deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadmicAdv >) DataRepository.EdStudAcadmicAdvProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsenceWarn>
				if (CanDeepSave(entity.AccomStudAbsenceWarnCollection, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsenceWarn child in entity.AccomStudAbsenceWarnCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AccomStudAbsenceWarnCollection.Count > 0 || entity.AccomStudAbsenceWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceWarnProvider.Save(transactionManager, entity.AccomStudAbsenceWarnCollection);
						
						deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsenceWarn >) DataRepository.AccomStudAbsenceWarnProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdInttransRule>
				if (CanDeepSave(entity.EdInttransRuleCollection, "List<EdInttransRule>|EdInttransRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdInttransRule child in entity.EdInttransRuleCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdInttransRuleCollection.Count > 0 || entity.EdInttransRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdInttransRuleProvider.Save(transactionManager, entity.EdInttransRuleCollection);
						
						deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdInttransRule >) DataRepository.EdInttransRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdInttransRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MilCodeCourse>
				if (CanDeepSave(entity.MilCodeCourseCollection, "List<MilCodeCourse>|MilCodeCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MilCodeCourse child in entity.MilCodeCourseCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.MilCodeCourseCollection.Count > 0 || entity.MilCodeCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MilCodeCourseProvider.Save(transactionManager, entity.MilCodeCourseCollection);
						
						deepHandles.Add("MilCodeCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MilCodeCourse >) DataRepository.MilCodeCourseProvider.DeepSave,
							new object[] { transactionManager, entity.MilCodeCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFund>
				if (CanDeepSave(entity.FeeStudFundCollection, "List<FeeStudFund>|FeeStudFundCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFund child in entity.FeeStudFundCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudFundCollection.Count > 0 || entity.FeeStudFundCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFundProvider.Save(transactionManager, entity.FeeStudFundCollection);
						
						deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFund >) DataRepository.FeeStudFundProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFundCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemAgendaDtl>
				if (CanDeepSave(entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollectionGetByFAdmAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaDtl child in entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId)
					{
						if(child.FAdmAcadYearIdSource != null)
						{
							child.FAdmAcadYearId = child.FAdmAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.FAdmAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId.Count > 0 || entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaDtlProvider.Save(transactionManager, entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId);
						
						deepHandles.Add("EdSemAgendaDtlCollectionGetByFAdmAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaDtl >) DataRepository.EdSemAgendaDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaDtlCollectionGetByFAdmAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCdeDiscType>
				if (CanDeepSave(entity.FeeCdeDiscTypeCollection, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeDiscType child in entity.FeeCdeDiscTypeCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeCdeDiscTypeCollection.Count > 0 || entity.FeeCdeDiscTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeCollection);
						
						deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeDiscType >) DataRepository.FeeCdeDiscTypeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudCoursesItem>
				if (CanDeepSave(entity.FeeStudCoursesItemCollection, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudCoursesItem child in entity.FeeStudCoursesItemCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudCoursesItemCollection.Count > 0 || entity.FeeStudCoursesItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudCoursesItemProvider.Save(transactionManager, entity.FeeStudCoursesItemCollection);
						
						deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudCoursesItem >) DataRepository.FeeStudCoursesItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterOpen>
				if (CanDeepSave(entity.EdSemesterOpenCollection, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterOpen child in entity.EdSemesterOpenCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdSemesterOpenCollection.Count > 0 || entity.EdSemesterOpenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenCollection);
						
						deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterOpen >) DataRepository.EdSemesterOpenProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterOpenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeTreasury>
				if (CanDeepSave(entity.FeeTreasuryCollection, "List<FeeTreasury>|FeeTreasuryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasury child in entity.FeeTreasuryCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeTreasuryCollection.Count > 0 || entity.FeeTreasuryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryProvider.Save(transactionManager, entity.FeeTreasuryCollection);
						
						deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasury >) DataRepository.FeeTreasuryProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.CtrStudExpCollection.Count > 0 || entity.CtrStudExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudExpProvider.Save(transactionManager, entity.CtrStudExpCollection);
						
						deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudExp >) DataRepository.CtrStudExpProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudClnq>
				if (CanDeepSave(entity.MdiStudClnqCollection, "List<MdiStudClnq>|MdiStudClnqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudClnq child in entity.MdiStudClnqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.MdiStudClnqCollection.Count > 0 || entity.MdiStudClnqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudClnqProvider.Save(transactionManager, entity.MdiStudClnqCollection);
						
						deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudClnq >) DataRepository.MdiStudClnqProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudClnqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAgendaHoliday>
				if (CanDeepSave(entity.GsAgendaHolidayCollection, "List<GsAgendaHoliday>|GsAgendaHolidayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAgendaHoliday child in entity.GsAgendaHolidayCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.GsAgendaHolidayCollection.Count > 0 || entity.GsAgendaHolidayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAgendaHolidayProvider.Save(transactionManager, entity.GsAgendaHolidayCollection);
						
						deepHandles.Add("GsAgendaHolidayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAgendaHoliday >) DataRepository.GsAgendaHolidayProvider.DeepSave,
							new object[] { transactionManager, entity.GsAgendaHolidayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdAcadYearId, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdAcadYearId)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdAcadYearId.Count > 0 || entity.EdStudViolCollectionGetByEdAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdAcadYearId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsence>
				if (CanDeepSave(entity.AccomStudAbsenceCollection, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsence child in entity.AccomStudAbsenceCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AccomStudAbsenceCollection.Count > 0 || entity.AccomStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceProvider.Save(transactionManager, entity.AccomStudAbsenceCollection);
						
						deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsence >) DataRepository.AccomStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgOffering>
				if (CanDeepSave(entity.PgOfferingCollection, "List<PgOffering>|PgOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgOffering child in entity.PgOfferingCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgOfferingCollection.Count > 0 || entity.PgOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingCollection);
						
						deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgOffering >) DataRepository.PgOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.PgOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgHdr>
				if (CanDeepSave(entity.EntCoursePkgHdrCollection, "List<EntCoursePkgHdr>|EntCoursePkgHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgHdr child in entity.EntCoursePkgHdrCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntCoursePkgHdrCollection.Count > 0 || entity.EntCoursePkgHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrCollection);
						
						deepHandles.Add("EntCoursePkgHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgHdr >) DataRepository.EntCoursePkgHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTransFromReq>
				if (CanDeepSave(entity.EdStudTransFromReqCollection, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTransFromReq child in entity.EdStudTransFromReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudTransFromReqCollection.Count > 0 || entity.EdStudTransFromReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransFromReqProvider.Save(transactionManager, entity.EdStudTransFromReqCollection);
						
						deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTransFromReq >) DataRepository.EdStudTransFromReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransFromReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallment>
				if (CanDeepSave(entity.FeeStudInstallmentCollection, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallment child in entity.FeeStudInstallmentCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudInstallmentCollection.Count > 0 || entity.FeeStudInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentCollection);
						
						deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallment >) DataRepository.FeeStudInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmFeePromocode>
				if (CanDeepSave(entity.AdmFeePromocodeCollection, "List<AdmFeePromocode>|AdmFeePromocodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmFeePromocode child in entity.AdmFeePromocodeCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AdmFeePromocodeCollection.Count > 0 || entity.AdmFeePromocodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmFeePromocodeProvider.Save(transactionManager, entity.AdmFeePromocodeCollection);
						
						deepHandles.Add("AdmFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmFeePromocode >) DataRepository.AdmFeePromocodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmFeePromocodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBranchRule>
				if (CanDeepSave(entity.EdBranchRuleCollection, "List<EdBranchRule>|EdBranchRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchRule child in entity.EdBranchRuleCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdBranchRuleCollection.Count > 0 || entity.EdBranchRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchRuleProvider.Save(transactionManager, entity.EdBranchRuleCollection);
						
						deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchRule >) DataRepository.EdBranchRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStudSemester>
				if (CanDeepSave(entity.SpoSponsorStudSemesterCollection, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStudSemester child in entity.SpoSponsorStudSemesterCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorStudSemesterCollection.Count > 0 || entity.SpoSponsorStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudSemesterProvider.Save(transactionManager, entity.SpoSponsorStudSemesterCollection);
						
						deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStudSemester >) DataRepository.SpoSponsorStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollection, "List<EdStudProblem>|EdStudProblemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudProblemCollection.Count > 0 || entity.EdStudProblemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollection);
						
						deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemSemester>
				if (CanDeepSave(entity.FeeItemSemesterCollection, "List<FeeItemSemester>|FeeItemSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemSemester child in entity.FeeItemSemesterCollection)
					{
						if(child.EdAcadYearJoinIdSource != null)
						{
							child.EdAcadYearJoinId = child.EdAcadYearJoinIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearJoinId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeItemSemesterCollection.Count > 0 || entity.FeeItemSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemSemesterProvider.Save(transactionManager, entity.FeeItemSemesterCollection);
						
						deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemSemester >) DataRepository.FeeItemSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.CtrStudOutCollection.Count > 0 || entity.CtrStudOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudOutProvider.Save(transactionManager, entity.CtrStudOutCollection);
						
						deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudOut >) DataRepository.CtrStudOutProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudOutCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoOfferStudException>
				if (CanDeepSave(entity.SpoOfferStudExceptionCollection, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferStudException child in entity.SpoOfferStudExceptionCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoOfferStudExceptionCollection.Count > 0 || entity.SpoOfferStudExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferStudExceptionProvider.Save(transactionManager, entity.SpoOfferStudExceptionCollection);
						
						deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferStudException >) DataRepository.SpoOfferStudExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAccomItem>
				if (CanDeepSave(entity.FeeAccomItemCollection, "List<FeeAccomItem>|FeeAccomItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAccomItem child in entity.FeeAccomItemCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeAccomItemCollection.Count > 0 || entity.FeeAccomItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAccomItemProvider.Save(transactionManager, entity.FeeAccomItemCollection);
						
						deepHandles.Add("FeeAccomItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAccomItem >) DataRepository.FeeAccomItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAccomItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptReq>
				if (CanDeepSave(entity.EdStudExmptReqCollection, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReq child in entity.EdStudExmptReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudExmptReqCollection.Count > 0 || entity.EdStudExmptReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqCollection);
						
						deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReq >) DataRepository.EdStudExmptReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudRetrieveRequest>
				if (CanDeepSave(entity.FeeStudRetrieveRequestCollection, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudRetrieveRequest child in entity.FeeStudRetrieveRequestCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudRetrieveRequestCollection.Count > 0 || entity.FeeStudRetrieveRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudRetrieveRequestProvider.Save(transactionManager, entity.FeeStudRetrieveRequestCollection);
						
						deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudRetrieveRequest >) DataRepository.FeeStudRetrieveRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdAcadYearStopToId, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearStopToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdAcadYearStopToId)
					{
						if(child.EdAcadYearStopToIdSource != null)
						{
							child.EdAcadYearStopToId = child.EdAcadYearStopToIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearStopToId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdAcadYearStopToId.Count > 0 || entity.EdStudViolCollectionGetByEdAcadYearStopToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopToId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdAcadYearStopToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeBusLineItem>
				if (CanDeepSave(entity.FeeBusLineItemCollection, "List<FeeBusLineItem>|FeeBusLineItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeBusLineItem child in entity.FeeBusLineItemCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeBusLineItemCollection.Count > 0 || entity.FeeBusLineItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeBusLineItemProvider.Save(transactionManager, entity.FeeBusLineItemCollection);
						
						deepHandles.Add("FeeBusLineItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeBusLineItem >) DataRepository.FeeBusLineItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeBusLineItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantDegree>
				if (CanDeepSave(entity.PgThesisGrantDegreeCollection, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantDegree child in entity.PgThesisGrantDegreeCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgThesisGrantDegreeCollection.Count > 0 || entity.PgThesisGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeCollection);
						
						deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantDegree >) DataRepository.PgThesisGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExecuseReq>
				if (CanDeepSave(entity.EdStudExecuseReqCollection, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExecuseReq child in entity.EdStudExecuseReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudExecuseReqCollection.Count > 0 || entity.EdStudExecuseReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExecuseReqProvider.Save(transactionManager, entity.EdStudExecuseReqCollection);
						
						deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExecuseReq >) DataRepository.EdStudExecuseReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExecuseReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeUserFundReq>
				if (CanDeepSave(entity.FeeUserFundReqCollection, "List<FeeUserFundReq>|FeeUserFundReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeUserFundReq child in entity.FeeUserFundReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeUserFundReqCollection.Count > 0 || entity.FeeUserFundReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeUserFundReqProvider.Save(transactionManager, entity.FeeUserFundReqCollection);
						
						deepHandles.Add("FeeUserFundReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeUserFundReq >) DataRepository.FeeUserFundReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeUserFundReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollection, "List<EdOffering>|EdOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdOfferingCollection.Count > 0 || entity.EdOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollection);
						
						deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallmentRequest>
				if (CanDeepSave(entity.FeeStudInstallmentRequestCollection, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallmentRequest child in entity.FeeStudInstallmentRequestCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudInstallmentRequestCollection.Count > 0 || entity.FeeStudInstallmentRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentRequestProvider.Save(transactionManager, entity.FeeStudInstallmentRequestCollection);
						
						deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallmentRequest >) DataRepository.FeeStudInstallmentRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.EdAcadYearPlnIdSource != null)
						{
							child.EdAcadYearPlnId = child.EdAcadYearPlnIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearPlnId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayStudSts>
				if (CanDeepSave(entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId, "List<MltRptDayStudSts>|MltRptDayStudStsCollectionGetByEdAcadYearJoinId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayStudSts child in entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId)
					{
						if(child.EdAcadYearJoinIdSource != null)
						{
							child.EdAcadYearJoinId = child.EdAcadYearJoinIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearJoinId = entity.EdAcadYearId;
						}

					}

					if (entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId.Count > 0 || entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayStudStsProvider.Save(transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId);
						
						deepHandles.Add("MltRptDayStudStsCollectionGetByEdAcadYearJoinId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayStudSts >) DataRepository.MltRptDayStudStsProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearJoinId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPrecondMdData>
				if (CanDeepSave(entity.EntPrecondMdDataCollection, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPrecondMdData child in entity.EntPrecondMdDataCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntPrecondMdDataCollection.Count > 0 || entity.EntPrecondMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPrecondMdDataProvider.Save(transactionManager, entity.EntPrecondMdDataCollection);
						
						deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPrecondMdData >) DataRepository.EntPrecondMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPrecondMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudCarStkr>
				if (CanDeepSave(entity.TrnsStudCarStkrCollection, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudCarStkr child in entity.TrnsStudCarStkrCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.TrnsStudCarStkrCollection.Count > 0 || entity.TrnsStudCarStkrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudCarStkrProvider.Save(transactionManager, entity.TrnsStudCarStkrCollection);
						
						deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudCarStkr >) DataRepository.TrnsStudCarStkrProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMessage>
				if (CanDeepSave(entity.SvMessageCollection, "List<SvMessage>|SvMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessage child in entity.SvMessageCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvMessageCollection.Count > 0 || entity.SvMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageCollection);
						
						deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessage >) DataRepository.SvMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdAcadYearToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId)
					{
						if(child.EdAcadYearToIdSource != null)
						{
							child.EdAcadYearToId = child.EdAcadYearToIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearToId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdAcadYearToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudPostponeReq>
				if (CanDeepSave(entity.RsrchStudPostponeReqCollection, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudPostponeReq child in entity.RsrchStudPostponeReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.RsrchStudPostponeReqCollection.Count > 0 || entity.RsrchStudPostponeReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudPostponeReqProvider.Save(transactionManager, entity.RsrchStudPostponeReqCollection);
						
						deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudPostponeReq >) DataRepository.RsrchStudPostponeReqProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdv>
				if (CanDeepSave(entity.SvStudAskAdvCollection, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdv child in entity.SvStudAskAdvCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvStudAskAdvCollection.Count > 0 || entity.SvStudAskAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvProvider.Save(transactionManager, entity.SvStudAskAdvCollection);
						
						deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdv >) DataRepository.SvStudAskAdvProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudPublish>
				if (CanDeepSave(entity.PgStudPublishCollection, "List<PgStudPublish>|PgStudPublishCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudPublish child in entity.PgStudPublishCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgStudPublishCollection.Count > 0 || entity.PgStudPublishCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudPublishProvider.Save(transactionManager, entity.PgStudPublishCollection);
						
						deepHandles.Add("PgStudPublishCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudPublish >) DataRepository.PgStudPublishProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudPublishCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOfferExt>
				if (CanDeepSave(entity.SpoSponsorOfferExtCollection, "List<SpoSponsorOfferExt>|SpoSponsorOfferExtCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOfferExt child in entity.SpoSponsorOfferExtCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SpoSponsorOfferExtCollection.Count > 0 || entity.SpoSponsorOfferExtCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferExtProvider.Save(transactionManager, entity.SpoSponsorOfferExtCollection);
						
						deepHandles.Add("SpoSponsorOfferExtCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOfferExt >) DataRepository.SpoSponsorOfferExtProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferExtCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdPrintReqCollection.Count > 0 || entity.EdPrintReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdPrintReqProvider.Save(transactionManager, entity.EdPrintReqCollection);
						
						deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdPrintReq >) DataRepository.EdPrintReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdPrintReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudTravel>
				if (CanDeepSave(entity.PgStudTravelCollection, "List<PgStudTravel>|PgStudTravelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudTravel child in entity.PgStudTravelCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgStudTravelCollection.Count > 0 || entity.PgStudTravelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelCollection);
						
						deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudTravel >) DataRepository.PgStudTravelProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudTravelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemAgendaDtl>
				if (CanDeepSave(entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollectionGetByTAdmAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaDtl child in entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId)
					{
						if(child.TAdmAcadYearIdSource != null)
						{
							child.TAdmAcadYearId = child.TAdmAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.TAdmAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId.Count > 0 || entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaDtlProvider.Save(transactionManager, entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId);
						
						deepHandles.Add("EdSemAgendaDtlCollectionGetByTAdmAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaDtl >) DataRepository.EdSemAgendaDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaDtlCollectionGetByTAdmAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntFullfillMdData>
				if (CanDeepSave(entity.EntFullfillMdDataCollection, "List<EntFullfillMdData>|EntFullfillMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntFullfillMdData child in entity.EntFullfillMdDataCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntFullfillMdDataCollection.Count > 0 || entity.EntFullfillMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntFullfillMdDataProvider.Save(transactionManager, entity.EntFullfillMdDataCollection);
						
						deepHandles.Add("EntFullfillMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntFullfillMdData >) DataRepository.EntFullfillMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntFullfillMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollectionGetByEdAcadYearId, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollectionGetByEdAcadYearId)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudIntTrnsCollectionGetByEdAcadYearId.Count > 0 || entity.EdStudIntTrnsCollectionGetByEdAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearId);
						
						deepHandles.Add("EdStudIntTrnsCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudHosptl>
				if (CanDeepSave(entity.MdiStudHosptlCollection, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudHosptl child in entity.MdiStudHosptlCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
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
				
	
			#region List<FeeCourseExp>
				if (CanDeepSave(entity.FeeCourseExpCollection, "List<FeeCourseExp>|FeeCourseExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCourseExp child in entity.FeeCourseExpCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeCourseExpCollection.Count > 0 || entity.FeeCourseExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCourseExpProvider.Save(transactionManager, entity.FeeCourseExpCollection);
						
						deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCourseExp >) DataRepository.FeeCourseExpProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCourseExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdAcadYearFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId)
					{
						if(child.EdAcadYearFromIdSource != null)
						{
							child.EdAcadYearFromId = child.EdAcadYearFromIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearFromId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdAcadYearFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdAcadYearFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInstlmntRule>
				if (CanDeepSave(entity.FeeInstlmntRuleCollection, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInstlmntRule child in entity.FeeInstlmntRuleCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.FeeInstlmntRuleCollection.Count > 0 || entity.FeeInstlmntRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInstlmntRuleProvider.Save(transactionManager, entity.FeeInstlmntRuleCollection);
						
						deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInstlmntRule >) DataRepository.FeeInstlmntRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTraining>
				if (CanDeepSave(entity.EdTrainingCollection, "List<EdTraining>|EdTrainingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTraining child in entity.EdTrainingCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdTrainingCollection.Count > 0 || entity.EdTrainingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainingProvider.Save(transactionManager, entity.EdTrainingCollection);
						
						deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTraining >) DataRepository.EdTrainingProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlPeriod>
				if (CanDeepSave(entity.ScSchdlPeriodCollection, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlPeriod child in entity.ScSchdlPeriodCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.ScSchdlPeriodCollection.Count > 0 || entity.ScSchdlPeriodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodCollection);
						
						deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlPeriod >) DataRepository.ScSchdlPeriodProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlPeriodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdAcadYearStopFromId, "List<EdStudViol>|EdStudViolCollectionGetByEdAcadYearStopFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdAcadYearStopFromId)
					{
						if(child.EdAcadYearStopFromIdSource != null)
						{
							child.EdAcadYearStopFromId = child.EdAcadYearStopFromIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearStopFromId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdAcadYearStopFromId.Count > 0 || entity.EdStudViolCollectionGetByEdAcadYearStopFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopFromId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdAcadYearStopFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdAcadYearStopFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudConference>
				if (CanDeepSave(entity.PgStudConferenceCollection, "List<PgStudConference>|PgStudConferenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudConference child in entity.PgStudConferenceCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.PgStudConferenceCollection.Count > 0 || entity.PgStudConferenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudConferenceProvider.Save(transactionManager, entity.PgStudConferenceCollection);
						
						deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudConference >) DataRepository.PgStudConferenceProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudConferenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvLecNote>
				if (CanDeepSave(entity.SvLecNoteCollection, "List<SvLecNote>|SvLecNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvLecNote child in entity.SvLecNoteCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.SvLecNoteCollection.Count > 0 || entity.SvLecNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvLecNoteProvider.Save(transactionManager, entity.SvLecNoteCollection);
						
						deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvLecNote >) DataRepository.SvLecNoteProvider.DeepSave,
							new object[] { transactionManager, entity.SvLecNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStaffCoursePref>
				if (CanDeepSave(entity.EdStaffCoursePrefCollection, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStaffCoursePref child in entity.EdStaffCoursePrefCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EdStaffCoursePrefCollection.Count > 0 || entity.EdStaffCoursePrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStaffCoursePrefProvider.Save(transactionManager, entity.EdStaffCoursePrefCollection);
						
						deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStaffCoursePref >) DataRepository.EdStaffCoursePrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayStudSts>
				if (CanDeepSave(entity.MltRptDayStudStsCollectionGetByEdAcadYearId, "List<MltRptDayStudSts>|MltRptDayStudStsCollectionGetByEdAcadYearId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayStudSts child in entity.MltRptDayStudStsCollectionGetByEdAcadYearId)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.MltRptDayStudStsCollectionGetByEdAcadYearId.Count > 0 || entity.MltRptDayStudStsCollectionGetByEdAcadYearId.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayStudStsProvider.Save(transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearId);
						
						deepHandles.Add("MltRptDayStudStsCollectionGetByEdAcadYearId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayStudSts >) DataRepository.MltRptDayStudStsProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayStudStsCollectionGetByEdAcadYearId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCourseMdData>
				if (CanDeepSave(entity.EntCourseMdDataCollection, "List<EntCourseMdData>|EntCourseMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCourseMdData child in entity.EntCourseMdDataCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.EntCourseMdDataCollection.Count > 0 || entity.EntCourseMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCourseMdDataProvider.Save(transactionManager, entity.EntCourseMdDataCollection);
						
						deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCourseMdData >) DataRepository.EntCourseMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCourseMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollection, "List<GsComm>|GsCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollection)
					{
						if(child.EdAcadYearIdSource != null)
						{
							child.EdAcadYearId = child.EdAcadYearIdSource.EdAcadYearId;
						}
						else
						{
							child.EdAcadYearId = entity.EdAcadYearId;
						}

					}

					if (entity.GsCommCollection.Count > 0 || entity.GsCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollection);
						
						deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdAcadYearChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAcadYear</c>
	///</summary>
	public enum EdAcadYearChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEdAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeFacultyInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyInstallment>))]
		FeeFacultyInstallmentCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTrans>))]
		EdStudTransCollection,
		///<summary>
		/// Entity <c>FeeAccntYear</c> as OneToOne for FeeAccntYear
		///</summary>
		[ChildEntityType(typeof(FeeAccntYear))]
		FeeAccntYear,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdAcadYearFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadYearFaculty>))]
		EdAcadYearFacultyCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SaOfficeHourCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaOfficeHour>))]
		SaOfficeHourCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudNatSimilarityRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudNatSimilarityRequest>))]
		FeeStudNatSimilarityRequestCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AdmOpenAcadSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOpenAcadSemester>))]
		AdmOpenAcadSemesterCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollectionGetByEdAcadYearReqId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntCoursePkgMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgMdData>))]
		EntCoursePkgMdDataCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeUserBondReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserBondReq>))]
		FeeUserBondReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGraduationAward>))]
		EdGraduationAwardCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AccomWfRequestApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomWfRequestApprove>))]
		AccomWfRequestApproveCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdProjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProject>))]
		EdProjectCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for RsrchStudRegisterCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegister>))]
		RsrchStudRegisterCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollectionGetByEdAcadYearToId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdCourseTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTchng>))]
		EdCourseTchngCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollectionGetByEdAcadYearToId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdAcadPlanCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlan>))]
		EdAcadPlanCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvUserTaskCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserTask>))]
		SvUserTaskCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MdiStudRecordCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudRecord>))]
		MdiStudRecordCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEdAcadYearJoinId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeFacItemAdmYearCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacItemAdmYear>))]
		FeeFacItemAdmYearCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudItemCnclCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudItemCncl>))]
		FeeStudItemCnclCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudBranchPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudBranchPref>))]
		EdStudBranchPrefCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdAcdadvRmkCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcdadvRmk>))]
		EdAcdadvRmkCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvSrvyHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyHdr>))]
		SvSrvyHdrCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudPayPostponeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudPayPostpone>))]
		FeeStudPayPostponeCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollectionGetByEdAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MltStudInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudInfo>))]
		MltStudInfoCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeTreasuryReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasuryReq>))]
		FeeTreasuryReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudAllowanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudAllowance>))]
		FeeStudAllowanceCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollectionGetByEdAcadYearFromId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudAcadmicAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadmicAdv>))]
		EdStudAcadmicAdvCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AccomStudAbsenceWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsenceWarn>))]
		AccomStudAbsenceWarnCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdInttransRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdInttransRule>))]
		EdInttransRuleCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MilCodeCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<MilCodeCourse>))]
		MilCodeCourseCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudFundCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFund>))]
		FeeStudFundCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdSemAgendaDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaDtl>))]
		EdSemAgendaDtlCollectionGetByFAdmAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeCdeDiscTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeDiscType>))]
		FeeCdeDiscTypeCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeTreasuryCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasury>))]
		FeeTreasuryCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MdiStudClnqCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudClnq>))]
		MdiStudClnqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for GsAgendaHolidayCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAgendaHoliday>))]
		GsAgendaHolidayCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AccomStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsence>))]
		AccomStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgOffering>))]
		PgOfferingCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntCoursePkgHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgHdr>))]
		EntCoursePkgHdrCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudTransFromReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTransFromReq>))]
		EdStudTransFromReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallment>))]
		FeeStudInstallmentCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AdmFeePromocodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmFeePromocode>))]
		AdmFeePromocodeCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdBranchRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchRule>))]
		EdBranchRuleCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStudSemester>))]
		SpoSponsorStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeItemSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemSemester>))]
		FeeItemSemesterCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoOfferStudExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferStudException>))]
		SpoOfferStudExceptionCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeAccomItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAccomItem>))]
		FeeAccomItemCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudExmptReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReq>))]
		EdStudExmptReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudRetrieveRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudRetrieveRequest>))]
		FeeStudRetrieveRequestCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdAcadYearStopToId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeBusLineItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeBusLineItem>))]
		FeeBusLineItemCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgThesisGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantDegree>))]
		PgThesisGrantDegreeCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudExecuseReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExecuseReq>))]
		EdStudExecuseReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeUserFundReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeUserFundReq>))]
		FeeUserFundReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudInstallmentRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallmentRequest>))]
		FeeStudInstallmentRequestCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MltRptDayStudStsCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayStudSts>))]
		MltRptDayStudStsCollectionGetByEdAcadYearJoinId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntPrecondMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPrecondMdData>))]
		EntPrecondMdDataCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for TrnsStudCarStkrCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudCarStkr>))]
		TrnsStudCarStkrCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessage>))]
		SvMessageCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdAcadYearToId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvStudAskAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdv>))]
		SvStudAskAdvCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgStudPublishCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudPublish>))]
		PgStudPublishCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SpoSponsorOfferExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOfferExt>))]
		SpoSponsorOfferExtCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgStudTravelCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudTravel>))]
		PgStudTravelCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdSemAgendaDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaDtl>))]
		EdSemAgendaDtlCollectionGetByTAdmAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntFullfillMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntFullfillMdData>))]
		EntFullfillMdDataCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollectionGetByEdAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MdiStudHosptlCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudHosptl>))]
		MdiStudHosptlCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeCourseExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCourseExp>))]
		FeeCourseExpCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdAcadYearFromId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for FeeInstlmntRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntRule>))]
		FeeInstlmntRuleCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdTrainingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTraining>))]
		EdTrainingCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for ScSchdlPeriodCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlPeriod>))]
		ScSchdlPeriodCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdAcadYearStopFromId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for PgStudConferenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudConference>))]
		PgStudConferenceCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for SvLecNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvLecNote>))]
		SvLecNoteCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EdStaffCoursePrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStaffCoursePref>))]
		EdStaffCoursePrefCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for MltRptDayStudStsCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayStudSts>))]
		MltRptDayStudStsCollectionGetByEdAcadYearId,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for EntCourseMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCourseMdData>))]
		EntCourseMdDataCollection,
		///<summary>
		/// Collection of <c>EdAcadYear</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollection,
	}
	
	#endregion EdAcadYearChildEntityTypes
	
	#region EdAcadYearFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAcadYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadYearFilterBuilder : SqlFilterBuilder<EdAcadYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadYearFilterBuilder class.
		/// </summary>
		public EdAcadYearFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadYearFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadYearFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadYearFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadYearFilterBuilder
	
	#region EdAcadYearParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAcadYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadYear"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadYearParameterBuilder : ParameterizedSqlFilterBuilder<EdAcadYearColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadYearParameterBuilder class.
		/// </summary>
		public EdAcadYearParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadYearParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadYearParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadYearParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadYearParameterBuilder
	
	#region EdAcadYearSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAcadYearColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadYear"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAcadYearSortBuilder : SqlSortBuilder<EdAcadYearColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadYearSqlSortBuilder class.
		/// </summary>
		public EdAcadYearSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAcadYearSortBuilder
	
} // end namespace
