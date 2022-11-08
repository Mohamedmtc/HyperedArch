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
	/// This class is the base class for any <see cref="SaWarningProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaWarningProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaWarning, UMIS_VER2.BusinessLyer.SaWarningKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningKey key)
		{
			return Delete(transactionManager, key.SaWarningId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saWarningId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saWarningId)
		{
			return Delete(null, _saWarningId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saWarningId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		FK_AUTO_0377 Description: 
		/// </summary>
		/// <param name="_warningAddTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByWarningAddTypeId(System.Decimal _warningAddTypeId)
		{
			int count = -1;
			return GetByWarningAddTypeId(_warningAddTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		FK_AUTO_0377 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_warningAddTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		/// <remarks></remarks>
		public TList<SaWarning> GetByWarningAddTypeId(TransactionManager transactionManager, System.Decimal _warningAddTypeId)
		{
			int count = -1;
			return GetByWarningAddTypeId(transactionManager, _warningAddTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		FK_AUTO_0377 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_warningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByWarningAddTypeId(TransactionManager transactionManager, System.Decimal _warningAddTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByWarningAddTypeId(transactionManager, _warningAddTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		fkAuto0377 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_warningAddTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByWarningAddTypeId(System.Decimal _warningAddTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByWarningAddTypeId(null, _warningAddTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		fkAuto0377 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_warningAddTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByWarningAddTypeId(System.Decimal _warningAddTypeId, int start, int pageLength,out int count)
		{
			return GetByWarningAddTypeId(null, _warningAddTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0377 key.
		///		FK_AUTO_0377 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_warningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public abstract TList<SaWarning> GetByWarningAddTypeId(TransactionManager transactionManager, System.Decimal _warningAddTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		FK_AUTO_0538 Description: 
		/// </summary>
		/// <param name="_saJobStoppageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetBySaJobStoppageId(System.Decimal _saJobStoppageId)
		{
			int count = -1;
			return GetBySaJobStoppageId(_saJobStoppageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		FK_AUTO_0538 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		/// <remarks></remarks>
		public TList<SaWarning> GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId)
		{
			int count = -1;
			return GetBySaJobStoppageId(transactionManager, _saJobStoppageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		FK_AUTO_0538 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStoppageId(transactionManager, _saJobStoppageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		fkAuto0538 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStoppageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetBySaJobStoppageId(System.Decimal _saJobStoppageId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaJobStoppageId(null, _saJobStoppageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		fkAuto0538 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetBySaJobStoppageId(System.Decimal _saJobStoppageId, int start, int pageLength,out int count)
		{
			return GetBySaJobStoppageId(null, _saJobStoppageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0538 key.
		///		FK_AUTO_0538 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public abstract TList<SaWarning> GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		FK_SA_WARNING_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		FK_SA_WARNING_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		/// <remarks></remarks>
		public TList<SaWarning> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		FK_SA_WARNING_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		fkSaWarningAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		fkSaWarningAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public TList<SaWarning> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_WARNING_AS_FACULTY_INFO key.
		///		FK_SA_WARNING_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaWarning objects.</returns>
		public abstract TList<SaWarning> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaWarning Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningKey key, int start, int pageLength)
		{
			return GetBySaWarningId(transactionManager, key.SaWarningId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_WARNING index.
		/// </summary>
		/// <param name="_saWarningId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(System.Decimal _saWarningId)
		{
			int count = -1;
			return GetBySaWarningId(null,_saWarningId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_WARNING index.
		/// </summary>
		/// <param name="_saWarningId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(System.Decimal _saWarningId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaWarningId(null, _saWarningId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_WARNING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(TransactionManager transactionManager, System.Decimal _saWarningId)
		{
			int count = -1;
			return GetBySaWarningId(transactionManager, _saWarningId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_WARNING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(TransactionManager transactionManager, System.Decimal _saWarningId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaWarningId(transactionManager, _saWarningId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_WARNING index.
		/// </summary>
		/// <param name="_saWarningId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(System.Decimal _saWarningId, int start, int pageLength, out int count)
		{
			return GetBySaWarningId(null, _saWarningId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_WARNING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaWarning GetBySaWarningId(TransactionManager transactionManager, System.Decimal _saWarningId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaWarning&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaWarning&gt;"/></returns>
		public static TList<SaWarning> Fill(IDataReader reader, TList<SaWarning> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaWarning c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaWarning")
					.Append("|").Append((System.Decimal)reader["SA_WARNING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaWarning>(
					key.ToString(), // EntityTrackingKey
					"SaWarning",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaWarning();
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
					c.SaWarningId = (System.Decimal)reader["SA_WARNING_ID"];
					c.OriginalSaWarningId = c.SaWarningId;
					c.WarningNum = (System.Decimal)reader["WARNING_NUM"];
					c.WarningDate = (System.DateTime)reader["WARNING_DATE"];
					c.WarningAddTypeId = (System.Decimal)reader["WARNING_ADD_TYPE_ID"];
					c.Coment = Convert.IsDBNull(reader["COMENT"]) ? null : (System.String)reader["COMENT"];
					c.SaJobStoppageId = (System.Decimal)reader["SA_JOB_STOPPAGE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaWarning entity)
		{
			if (!reader.Read()) return;
			
			entity.SaWarningId = (System.Decimal)reader[((int)SaWarningColumn.SaWarningId - 1)];
			entity.OriginalSaWarningId = (System.Decimal)reader["SA_WARNING_ID"];
			entity.WarningNum = (System.Decimal)reader[((int)SaWarningColumn.WarningNum - 1)];
			entity.WarningDate = (System.DateTime)reader[((int)SaWarningColumn.WarningDate - 1)];
			entity.WarningAddTypeId = (System.Decimal)reader[((int)SaWarningColumn.WarningAddTypeId - 1)];
			entity.Coment = (reader.IsDBNull(((int)SaWarningColumn.Coment - 1)))?null:(System.String)reader[((int)SaWarningColumn.Coment - 1)];
			entity.SaJobStoppageId = (System.Decimal)reader[((int)SaWarningColumn.SaJobStoppageId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaWarningColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaWarning entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaWarningId = (System.Decimal)dataRow["SA_WARNING_ID"];
			entity.OriginalSaWarningId = (System.Decimal)dataRow["SA_WARNING_ID"];
			entity.WarningNum = (System.Decimal)dataRow["WARNING_NUM"];
			entity.WarningDate = (System.DateTime)dataRow["WARNING_DATE"];
			entity.WarningAddTypeId = (System.Decimal)dataRow["WARNING_ADD_TYPE_ID"];
			entity.Coment = Convert.IsDBNull(dataRow["COMENT"]) ? null : (System.String)dataRow["COMENT"];
			entity.SaJobStoppageId = (System.Decimal)dataRow["SA_JOB_STOPPAGE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarning"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaWarning Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarning entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region WarningAddTypeIdSource	
			if (CanDeepLoad(entity, "SaWarningAddType|WarningAddTypeIdSource", deepLoadType, innerList) 
				&& entity.WarningAddTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.WarningAddTypeId;
				SaWarningAddType tmpEntity = EntityManager.LocateEntity<SaWarningAddType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaWarningAddType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.WarningAddTypeIdSource = tmpEntity;
				else
					entity.WarningAddTypeIdSource = DataRepository.SaWarningAddTypeProvider.GetBySaWarningAddTypeId(transactionManager, entity.WarningAddTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WarningAddTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.WarningAddTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaWarningAddTypeProvider.DeepLoad(transactionManager, entity.WarningAddTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion WarningAddTypeIdSource

			#region SaJobStoppageIdSource	
			if (CanDeepLoad(entity, "SaJobStoppage|SaJobStoppageIdSource", deepLoadType, innerList) 
				&& entity.SaJobStoppageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaJobStoppageId;
				SaJobStoppage tmpEntity = EntityManager.LocateEntity<SaJobStoppage>(EntityLocator.ConstructKeyFromPkItems(typeof(SaJobStoppage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaJobStoppageIdSource = tmpEntity;
				else
					entity.SaJobStoppageIdSource = DataRepository.SaJobStoppageProvider.GetBySaJobStoppageId(transactionManager, entity.SaJobStoppageId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStoppageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaJobStoppageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaJobStoppageProvider.DeepLoad(transactionManager, entity.SaJobStoppageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaJobStoppageIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaWarning object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaWarning instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaWarning Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarning entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region WarningAddTypeIdSource
			if (CanDeepSave(entity, "SaWarningAddType|WarningAddTypeIdSource", deepSaveType, innerList) 
				&& entity.WarningAddTypeIdSource != null)
			{
				DataRepository.SaWarningAddTypeProvider.Save(transactionManager, entity.WarningAddTypeIdSource);
				entity.WarningAddTypeId = entity.WarningAddTypeIdSource.SaWarningAddTypeId;
			}
			#endregion 
			
			#region SaJobStoppageIdSource
			if (CanDeepSave(entity, "SaJobStoppage|SaJobStoppageIdSource", deepSaveType, innerList) 
				&& entity.SaJobStoppageIdSource != null)
			{
				DataRepository.SaJobStoppageProvider.Save(transactionManager, entity.SaJobStoppageIdSource);
				entity.SaJobStoppageId = entity.SaJobStoppageIdSource.SaJobStoppageId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
	
	#region SaWarningChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaWarning</c>
	///</summary>
	public enum SaWarningChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaWarningAddType</c> at WarningAddTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SaWarningAddType))]
		SaWarningAddType,
		
		///<summary>
		/// Composite Property for <c>SaJobStoppage</c> at SaJobStoppageIdSource
		///</summary>
		[ChildEntityType(typeof(SaJobStoppage))]
		SaJobStoppage,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion SaWarningChildEntityTypes
	
	#region SaWarningFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaWarningColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarning"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaWarningFilterBuilder : SqlFilterBuilder<SaWarningColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningFilterBuilder class.
		/// </summary>
		public SaWarningFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaWarningFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaWarningFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaWarningFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaWarningFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaWarningFilterBuilder
	
	#region SaWarningParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaWarningColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarning"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaWarningParameterBuilder : ParameterizedSqlFilterBuilder<SaWarningColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningParameterBuilder class.
		/// </summary>
		public SaWarningParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaWarningParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaWarningParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaWarningParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaWarningParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaWarningParameterBuilder
	
	#region SaWarningSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaWarningColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarning"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaWarningSortBuilder : SqlSortBuilder<SaWarningColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningSqlSortBuilder class.
		/// </summary>
		public SaWarningSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaWarningSortBuilder
	
} // end namespace
