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
	/// This class is the base class for any <see cref="EdCourseEquivProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseEquivProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseEquiv, UMIS_VER2.BusinessLyer.EdCourseEquivKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseEquivKey key)
		{
			return Delete(transactionManager, key.EdCourseEquivId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseEquivId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseEquivId)
		{
			return Delete(null, _edCourseEquivId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseEquivId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseEquivId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edEquivCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdEquivCourseId(System.Decimal _edEquivCourseId)
		{
			int count = -1;
			return GetByEdEquivCourseId(_edEquivCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseEquiv> GetByEdEquivCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId)
		{
			int count = -1;
			return GetByEdEquivCourseId(transactionManager, _edEquivCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdEquivCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdEquivCourseId(transactionManager, _edEquivCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		fkEdCourseEquivEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edEquivCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdEquivCourseId(System.Decimal _edEquivCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdEquivCourseId(null, _edEquivCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		fkEdCourseEquivEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdEquivCourseId(System.Decimal _edEquivCourseId, int start, int pageLength,out int count)
		{
			return GetByEdEquivCourseId(null, _edEquivCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public abstract TList<EdCourseEquiv> GetByEdEquivCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseEquiv> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		fkEdCourseEquivEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		fkEdCourseEquivEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public TList<EdCourseEquiv> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_EQUIV_ED_COURSE1 key.
		///		FK_ED_COURSE_EQUIV_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseEquiv objects.</returns>
		public abstract TList<EdCourseEquiv> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseEquiv Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseEquivKey key, int start, int pageLength)
		{
			return GetByEdCourseEquivId(transactionManager, key.EdCourseEquivId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edCourseEquivId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(System.Decimal _edCourseEquivId)
		{
			int count = -1;
			return GetByEdCourseEquivId(null,_edCourseEquivId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edCourseEquivId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(System.Decimal _edCourseEquivId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseEquivId(null, _edCourseEquivId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseEquivId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(TransactionManager transactionManager, System.Decimal _edCourseEquivId)
		{
			int count = -1;
			return GetByEdCourseEquivId(transactionManager, _edCourseEquivId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseEquivId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(TransactionManager transactionManager, System.Decimal _edCourseEquivId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseEquivId(transactionManager, _edCourseEquivId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edCourseEquivId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(System.Decimal _edCourseEquivId, int start, int pageLength, out int count)
		{
			return GetByEdCourseEquivId(null, _edCourseEquivId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseEquivId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdCourseEquivId(TransactionManager transactionManager, System.Decimal _edCourseEquivId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(System.Decimal _edEquivCourseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdEquivCourseIdEdCourseId(null,_edEquivCourseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(System.Decimal _edEquivCourseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdEquivCourseIdEdCourseId(null, _edEquivCourseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdEquivCourseIdEdCourseId(transactionManager, _edEquivCourseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdEquivCourseIdEdCourseId(transactionManager, _edEquivCourseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(System.Decimal _edEquivCourseId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdEquivCourseIdEdCourseId(null, _edEquivCourseId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE_EQUIV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edEquivCourseId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseEquiv GetByEdEquivCourseIdEdCourseId(TransactionManager transactionManager, System.Decimal _edEquivCourseId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseEquiv&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseEquiv&gt;"/></returns>
		public static TList<EdCourseEquiv> Fill(IDataReader reader, TList<EdCourseEquiv> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseEquiv c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseEquiv")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_EQUIV_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseEquiv>(
					key.ToString(), // EntityTrackingKey
					"EdCourseEquiv",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseEquiv();
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
					c.EdCourseEquivId = (System.Decimal)reader["ED_COURSE_EQUIV_ID"];
					c.OriginalEdCourseEquivId = c.EdCourseEquivId;
					c.EdEquivCourseId = (System.Decimal)reader["ED_EQUIV_COURSE_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseEquiv entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseEquivId = (System.Decimal)reader[((int)EdCourseEquivColumn.EdCourseEquivId - 1)];
			entity.OriginalEdCourseEquivId = (System.Decimal)reader["ED_COURSE_EQUIV_ID"];
			entity.EdEquivCourseId = (System.Decimal)reader[((int)EdCourseEquivColumn.EdEquivCourseId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseEquivColumn.EdCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseEquiv entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseEquivId = (System.Decimal)dataRow["ED_COURSE_EQUIV_ID"];
			entity.OriginalEdCourseEquivId = (System.Decimal)dataRow["ED_COURSE_EQUIV_ID"];
			entity.EdEquivCourseId = (System.Decimal)dataRow["ED_EQUIV_COURSE_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseEquiv"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseEquiv Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseEquiv entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdEquivCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdEquivCourseIdSource", deepLoadType, innerList) 
				&& entity.EdEquivCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdEquivCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdEquivCourseIdSource = tmpEntity;
				else
					entity.EdEquivCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdEquivCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdEquivCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdEquivCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdEquivCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdEquivCourseIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseEquiv object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseEquiv instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseEquiv Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseEquiv entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdEquivCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdEquivCourseIdSource", deepSaveType, innerList) 
				&& entity.EdEquivCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdEquivCourseIdSource);
				entity.EdEquivCourseId = entity.EdEquivCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
	
	#region EdCourseEquivChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseEquiv</c>
	///</summary>
	public enum EdCourseEquivChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdEquivCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdCourseEquivChildEntityTypes
	
	#region EdCourseEquivFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseEquivColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseEquiv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseEquivFilterBuilder : SqlFilterBuilder<EdCourseEquivColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivFilterBuilder class.
		/// </summary>
		public EdCourseEquivFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseEquivFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseEquivFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseEquivFilterBuilder
	
	#region EdCourseEquivParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseEquivColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseEquiv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseEquivParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseEquivColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivParameterBuilder class.
		/// </summary>
		public EdCourseEquivParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseEquivParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseEquivParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseEquivParameterBuilder
	
	#region EdCourseEquivSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseEquivColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseEquiv"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseEquivSortBuilder : SqlSortBuilder<EdCourseEquivColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseEquivSqlSortBuilder class.
		/// </summary>
		public EdCourseEquivSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseEquivSortBuilder
	
} // end namespace
