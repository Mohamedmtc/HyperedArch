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
	/// This class is the base class for any <see cref="EdCourseBarredProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseBarredProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseBarred, UMIS_VER2.BusinessLyer.EdCourseBarredKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseBarredKey key)
		{
			return Delete(transactionManager, key.EdCourseBarredId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseBarredId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseBarredId)
		{
			return Delete(null, _edCourseBarredId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseBarredId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseBarredId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseBarred Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseBarredKey key, int start, int pageLength)
		{
			return GetByEdCourseBarredId(transactionManager, key.EdCourseBarredId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(System.Decimal _edCourseId, System.Decimal _edBarredCourseId)
		{
			int count = -1;
			return GetByEdCourseIdEdBarredCourseId(null,_edCourseId, _edBarredCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(System.Decimal _edCourseId, System.Decimal _edBarredCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEdBarredCourseId(null, _edCourseId, _edBarredCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _edBarredCourseId)
		{
			int count = -1;
			return GetByEdCourseIdEdBarredCourseId(transactionManager, _edCourseId, _edBarredCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _edBarredCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseIdEdBarredCourseId(transactionManager, _edCourseId, _edBarredCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(System.Decimal _edCourseId, System.Decimal _edBarredCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseIdEdBarredCourseId(null, _edCourseId, _edBarredCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SUBJ_OPPOSED_SUBJ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseIdEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _edBarredCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edBarredCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdBarredCourseId(System.Decimal _edBarredCourseId)
		{
			int count = -1;
			return GetByEdBarredCourseId(null,_edBarredCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdBarredCourseId(System.Decimal _edBarredCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBarredCourseId(null, _edBarredCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBarredCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edBarredCourseId)
		{
			int count = -1;
			return GetByEdBarredCourseId(transactionManager, _edBarredCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edBarredCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBarredCourseId(transactionManager, _edBarredCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdBarredCourseId(System.Decimal _edBarredCourseId, int start, int pageLength, out int count)
		{
			return GetByEdBarredCourseId(null, _edBarredCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_BARRED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBarredCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public abstract TList<EdCourseBarred> GetByEdBarredCourseId(TransactionManager transactionManager, System.Decimal _edBarredCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public TList<EdCourseBarred> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseBarred&gt;"/> class.</returns>
		public abstract TList<EdCourseBarred> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="_edCourseBarredId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(System.Decimal _edCourseBarredId)
		{
			int count = -1;
			return GetByEdCourseBarredId(null,_edCourseBarredId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="_edCourseBarredId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(System.Decimal _edCourseBarredId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseBarredId(null, _edCourseBarredId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseBarredId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(TransactionManager transactionManager, System.Decimal _edCourseBarredId)
		{
			int count = -1;
			return GetByEdCourseBarredId(transactionManager, _edCourseBarredId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseBarredId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(TransactionManager transactionManager, System.Decimal _edCourseBarredId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseBarredId(transactionManager, _edCourseBarredId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="_edCourseBarredId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(System.Decimal _edCourseBarredId, int start, int pageLength, out int count)
		{
			return GetByEdCourseBarredId(null, _edCourseBarredId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SUBJECT_OPPOSED index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseBarredId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseBarred GetByEdCourseBarredId(TransactionManager transactionManager, System.Decimal _edCourseBarredId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseBarred&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseBarred&gt;"/></returns>
		public static TList<EdCourseBarred> Fill(IDataReader reader, TList<EdCourseBarred> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseBarred c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseBarred")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_BARRED_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseBarred>(
					key.ToString(), // EntityTrackingKey
					"EdCourseBarred",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseBarred();
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
					c.EdCourseBarredId = (System.Decimal)reader["ED_COURSE_BARRED_ID"];
					c.OriginalEdCourseBarredId = c.EdCourseBarredId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdBarredCourseId = (System.Decimal)reader["ED_BARRED_COURSE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseBarred entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseBarredId = (System.Decimal)reader[((int)EdCourseBarredColumn.EdCourseBarredId - 1)];
			entity.OriginalEdCourseBarredId = (System.Decimal)reader["ED_COURSE_BARRED_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseBarredColumn.EdCourseId - 1)];
			entity.EdBarredCourseId = (System.Decimal)reader[((int)EdCourseBarredColumn.EdBarredCourseId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseBarred entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseBarredId = (System.Decimal)dataRow["ED_COURSE_BARRED_ID"];
			entity.OriginalEdCourseBarredId = (System.Decimal)dataRow["ED_COURSE_BARRED_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdBarredCourseId = (System.Decimal)dataRow["ED_BARRED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseBarred"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseBarred Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseBarred entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdBarredCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdBarredCourseIdSource", deepLoadType, innerList) 
				&& entity.EdBarredCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdBarredCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBarredCourseIdSource = tmpEntity;
				else
					entity.EdBarredCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdBarredCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBarredCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBarredCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdBarredCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBarredCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseBarred object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseBarred instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseBarred Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseBarred entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdBarredCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdBarredCourseIdSource", deepSaveType, innerList) 
				&& entity.EdBarredCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdBarredCourseIdSource);
				entity.EdBarredCourseId = entity.EdBarredCourseIdSource.EdCourseId;
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
	
	#region EdCourseBarredChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseBarred</c>
	///</summary>
	public enum EdCourseBarredChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdCourseBarredChildEntityTypes
	
	#region EdCourseBarredFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseBarredColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseBarred"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseBarredFilterBuilder : SqlFilterBuilder<EdCourseBarredColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredFilterBuilder class.
		/// </summary>
		public EdCourseBarredFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseBarredFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseBarredFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseBarredFilterBuilder
	
	#region EdCourseBarredParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseBarredColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseBarred"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseBarredParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseBarredColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredParameterBuilder class.
		/// </summary>
		public EdCourseBarredParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseBarredParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseBarredParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseBarredParameterBuilder
	
	#region EdCourseBarredSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseBarredColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseBarred"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseBarredSortBuilder : SqlSortBuilder<EdCourseBarredColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseBarredSqlSortBuilder class.
		/// </summary>
		public EdCourseBarredSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseBarredSortBuilder
	
} // end namespace
