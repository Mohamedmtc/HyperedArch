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
	/// This class is the base class for any <see cref="SpoDepartmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoDepartmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoDepartment, UMIS_VER2.BusinessLyer.SpoDepartmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoDepartmentKey key)
		{
			return Delete(transactionManager, key.SpoDepartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoDepartmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoDepartmentId)
		{
			return Delete(null, _spoDepartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoDepartmentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		FK_SPO_Department_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		public TList<SpoDepartment> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		FK_SPO_Department_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		/// <remarks></remarks>
		public TList<SpoDepartment> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		FK_SPO_Department_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		public TList<SpoDepartment> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		fkSpoDepartmentSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		public TList<SpoDepartment> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		fkSpoDepartmentSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		public TList<SpoDepartment> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_Department_SPO_SPONSOR key.
		///		FK_SPO_Department_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoDepartment objects.</returns>
		public abstract TList<SpoDepartment> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoDepartment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoDepartmentKey key, int start, int pageLength)
		{
			return GetBySpoDepartmentId(transactionManager, key.SpoDepartmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_Department index.
		/// </summary>
		/// <param name="_spoDepartmentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(System.Decimal _spoDepartmentId)
		{
			int count = -1;
			return GetBySpoDepartmentId(null,_spoDepartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_Department index.
		/// </summary>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(System.Decimal _spoDepartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoDepartmentId(null, _spoDepartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_Department index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal _spoDepartmentId)
		{
			int count = -1;
			return GetBySpoDepartmentId(transactionManager, _spoDepartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_Department index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal _spoDepartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoDepartmentId(transactionManager, _spoDepartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_Department index.
		/// </summary>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(System.Decimal _spoDepartmentId, int start, int pageLength, out int count)
		{
			return GetBySpoDepartmentId(null, _spoDepartmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_Department index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal _spoDepartmentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(System.Decimal? _spoSponsorId, System.String _descrAr)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrAr(null,_spoSponsorId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(System.Decimal? _spoSponsorId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrAr(null, _spoSponsorId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrAr)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrAr(transactionManager, _spoSponsorId, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrAr(transactionManager, _spoSponsorId, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(System.Decimal? _spoSponsorId, System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorIdDescrAr(null, _spoSponsorId, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrAr(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(System.Decimal? _spoSponsorId, System.String _descrEn)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrEn(null,_spoSponsorId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(System.Decimal? _spoSponsorId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrEn(null, _spoSponsorId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrEn)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrEn(transactionManager, _spoSponsorId, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorIdDescrEn(transactionManager, _spoSponsorId, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(System.Decimal? _spoSponsorId, System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorIdDescrEn(null, _spoSponsorId, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_DEPARTMENT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoDepartment GetBySpoSponsorIdDescrEn(TransactionManager transactionManager, System.Decimal? _spoSponsorId, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoDepartment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoDepartment&gt;"/></returns>
		public static TList<SpoDepartment> Fill(IDataReader reader, TList<SpoDepartment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoDepartment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoDepartment")
					.Append("|").Append((System.Decimal)reader["SPO_DEPARTMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoDepartment>(
					key.ToString(), // EntityTrackingKey
					"SpoDepartment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoDepartment();
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
					c.SpoDepartmentId = (System.Decimal)reader["SPO_DEPARTMENT_ID"];
					c.OriginalSpoDepartmentId = c.SpoDepartmentId;
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoDepartment entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoDepartmentId = (System.Decimal)reader[((int)SpoDepartmentColumn.SpoDepartmentId - 1)];
			entity.OriginalSpoDepartmentId = (System.Decimal)reader["SPO_DEPARTMENT_ID"];
			entity.SpoSponsorId = (reader.IsDBNull(((int)SpoDepartmentColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)SpoDepartmentColumn.SpoSponsorId - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)SpoDepartmentColumn.DescrAr - 1)))?null:(System.String)reader[((int)SpoDepartmentColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)SpoDepartmentColumn.DescrEn - 1)))?null:(System.String)reader[((int)SpoDepartmentColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoDepartment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoDepartmentId = (System.Decimal)dataRow["SPO_DEPARTMENT_ID"];
			entity.OriginalSpoDepartmentId = (System.Decimal)dataRow["SPO_DEPARTMENT_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoDepartment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoDepartment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoDepartment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorId ?? 0.0m);
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, (entity.SpoSponsorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySpoDepartmentId methods when available
			
			#region SpoContactCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoContact>|SpoContactCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoContactCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoContactCollection = DataRepository.SpoContactProvider.GetBySpoDepartmentId(transactionManager, entity.SpoDepartmentId);

				if (deep && entity.SpoContactCollection.Count > 0)
				{
					deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoContact>) DataRepository.SpoContactProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoContactCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoDepartment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoDepartment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoDepartment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoDepartment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SpoContact>
				if (CanDeepSave(entity.SpoContactCollection, "List<SpoContact>|SpoContactCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoContact child in entity.SpoContactCollection)
					{
						if(child.SpoDepartmentIdSource != null)
						{
							child.SpoDepartmentId = child.SpoDepartmentIdSource.SpoDepartmentId;
						}
						else
						{
							child.SpoDepartmentId = entity.SpoDepartmentId;
						}

					}

					if (entity.SpoContactCollection.Count > 0 || entity.SpoContactCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoContactProvider.Save(transactionManager, entity.SpoContactCollection);
						
						deepHandles.Add("SpoContactCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoContact >) DataRepository.SpoContactProvider.DeepSave,
							new object[] { transactionManager, entity.SpoContactCollection, deepSaveType, childTypes, innerList }
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
	
	#region SpoDepartmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoDepartment</c>
	///</summary>
	public enum SpoDepartmentChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>SpoDepartment</c> as OneToMany for SpoContactCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoContact>))]
		SpoContactCollection,
	}
	
	#endregion SpoDepartmentChildEntityTypes
	
	#region SpoDepartmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoDepartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoDepartmentFilterBuilder : SqlFilterBuilder<SpoDepartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentFilterBuilder class.
		/// </summary>
		public SpoDepartmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoDepartmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoDepartmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoDepartmentFilterBuilder
	
	#region SpoDepartmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoDepartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoDepartmentParameterBuilder : ParameterizedSqlFilterBuilder<SpoDepartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentParameterBuilder class.
		/// </summary>
		public SpoDepartmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoDepartmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoDepartmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoDepartmentParameterBuilder
	
	#region SpoDepartmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoDepartment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoDepartmentSortBuilder : SqlSortBuilder<SpoDepartmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoDepartmentSqlSortBuilder class.
		/// </summary>
		public SpoDepartmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoDepartmentSortBuilder
	
} // end namespace
