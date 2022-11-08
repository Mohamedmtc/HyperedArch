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
	/// This class is the base class for any <see cref="PgStudPublishProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgStudPublishProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgStudPublish, UMIS_VER2.BusinessLyer.PgStudPublishKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudPublishKey key)
		{
			return Delete(transactionManager, key.PgStudPublishId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgStudPublishId)
		{
			return Delete(null, _pgStudPublishId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgStudPublishId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		FK_PG_STUD_PUBLISH_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		FK_PG_STUD_PUBLISH_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudPublish> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		FK_PG_STUD_PUBLISH_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		fkPgStudPublishEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		fkPgStudPublishEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_ACAD_YEAR key.
		///		FK_PG_STUD_PUBLISH_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public abstract TList<PgStudPublish> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		FK_PG_STUD_PUBLISH_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		FK_PG_STUD_PUBLISH_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		/// <remarks></remarks>
		public TList<PgStudPublish> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		FK_PG_STUD_PUBLISH_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		fkPgStudPublishEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		fkPgStudPublishEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public TList<PgStudPublish> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_STUD_PUBLISH_ED_STUD key.
		///		FK_PG_STUD_PUBLISH_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">ONLY PG STUD</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgStudPublish objects.</returns>
		public abstract TList<PgStudPublish> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgStudPublish Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudPublishKey key, int start, int pageLength)
		{
			return GetByPgStudPublishId(transactionManager, key.PgStudPublishId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(System.Decimal _pgStudPublishId)
		{
			int count = -1;
			return GetByPgStudPublishId(null,_pgStudPublishId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(System.Decimal _pgStudPublishId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudPublishId(null, _pgStudPublishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal _pgStudPublishId)
		{
			int count = -1;
			return GetByPgStudPublishId(transactionManager, _pgStudPublishId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal _pgStudPublishId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudPublishId(transactionManager, _pgStudPublishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(System.Decimal _pgStudPublishId, int start, int pageLength, out int count)
		{
			return GetByPgStudPublishId(null, _pgStudPublishId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_STUD_PUBLISH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgStudPublish GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal _pgStudPublishId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgStudPublish&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgStudPublish&gt;"/></returns>
		public static TList<PgStudPublish> Fill(IDataReader reader, TList<PgStudPublish> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgStudPublish c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgStudPublish")
					.Append("|").Append((System.Decimal)reader["PG_STUD_PUBLISH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgStudPublish>(
					key.ToString(), // EntityTrackingKey
					"PgStudPublish",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgStudPublish();
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
					c.PgStudPublishId = (System.Decimal)reader["PG_STUD_PUBLISH_ID"];
					c.OriginalPgStudPublishId = c.PgStudPublishId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.PublishDate = Convert.IsDBNull(reader["PUBLISH_DATE"]) ? null : (System.DateTime?)reader["PUBLISH_DATE"];
					c.PaperNum = Convert.IsDBNull(reader["PAPER_NUM"]) ? null : (System.Int32?)reader["PAPER_NUM"];
					c.PaperSubject = Convert.IsDBNull(reader["PAPER_SUBJECT"]) ? null : (System.String)reader["PAPER_SUBJECT"];
					c.PublishOrg = Convert.IsDBNull(reader["PUBLISH_ORG"]) ? null : (System.String)reader["PUBLISH_ORG"];
					c.StudOrdr = Convert.IsDBNull(reader["STUD_ORDR"]) ? null : (System.Int16?)reader["STUD_ORDR"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.PublishFlg = Convert.IsDBNull(reader["PUBLISH_FLG"]) ? null : (System.Int32?)reader["PUBLISH_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgStudPublish entity)
		{
			if (!reader.Read()) return;
			
			entity.PgStudPublishId = (System.Decimal)reader[((int)PgStudPublishColumn.PgStudPublishId - 1)];
			entity.OriginalPgStudPublishId = (System.Decimal)reader["PG_STUD_PUBLISH_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)PgStudPublishColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)PgStudPublishColumn.EdAcadYearId - 1)];
			entity.PublishDate = (reader.IsDBNull(((int)PgStudPublishColumn.PublishDate - 1)))?null:(System.DateTime?)reader[((int)PgStudPublishColumn.PublishDate - 1)];
			entity.PaperNum = (reader.IsDBNull(((int)PgStudPublishColumn.PaperNum - 1)))?null:(System.Int32?)reader[((int)PgStudPublishColumn.PaperNum - 1)];
			entity.PaperSubject = (reader.IsDBNull(((int)PgStudPublishColumn.PaperSubject - 1)))?null:(System.String)reader[((int)PgStudPublishColumn.PaperSubject - 1)];
			entity.PublishOrg = (reader.IsDBNull(((int)PgStudPublishColumn.PublishOrg - 1)))?null:(System.String)reader[((int)PgStudPublishColumn.PublishOrg - 1)];
			entity.StudOrdr = (reader.IsDBNull(((int)PgStudPublishColumn.StudOrdr - 1)))?null:(System.Int16?)reader[((int)PgStudPublishColumn.StudOrdr - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgStudPublishColumn.Notes - 1)))?null:(System.String)reader[((int)PgStudPublishColumn.Notes - 1)];
			entity.PublishFlg = (reader.IsDBNull(((int)PgStudPublishColumn.PublishFlg - 1)))?null:(System.Int32?)reader[((int)PgStudPublishColumn.PublishFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgStudPublishColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgStudPublishColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgStudPublishColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgStudPublishColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgStudPublish entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgStudPublishId = (System.Decimal)dataRow["PG_STUD_PUBLISH_ID"];
			entity.OriginalPgStudPublishId = (System.Decimal)dataRow["PG_STUD_PUBLISH_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.PublishDate = Convert.IsDBNull(dataRow["PUBLISH_DATE"]) ? null : (System.DateTime?)dataRow["PUBLISH_DATE"];
			entity.PaperNum = Convert.IsDBNull(dataRow["PAPER_NUM"]) ? null : (System.Int32?)dataRow["PAPER_NUM"];
			entity.PaperSubject = Convert.IsDBNull(dataRow["PAPER_SUBJECT"]) ? null : (System.String)dataRow["PAPER_SUBJECT"];
			entity.PublishOrg = Convert.IsDBNull(dataRow["PUBLISH_ORG"]) ? null : (System.String)dataRow["PUBLISH_ORG"];
			entity.StudOrdr = Convert.IsDBNull(dataRow["STUD_ORDR"]) ? null : (System.Int16?)dataRow["STUD_ORDR"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.PublishFlg = Convert.IsDBNull(dataRow["PUBLISH_FLG"]) ? null : (System.Int32?)dataRow["PUBLISH_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgStudPublish"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudPublish Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudPublish entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgStudPublishId methods when available
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgStudPublishId(transactionManager, entity.PgStudPublishId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgStudPublish object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgStudPublish instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgStudPublish Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgStudPublish entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgStudPublishIdSource != null)
						{
							child.PgStudPublishId = child.PgStudPublishIdSource.PgStudPublishId;
						}
						else
						{
							child.PgStudPublishId = entity.PgStudPublishId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgStudPublishChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgStudPublish</c>
	///</summary>
	public enum PgStudPublishChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		///<summary>
		/// Collection of <c>PgStudPublish</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgStudPublishChildEntityTypes
	
	#region PgStudPublishFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgStudPublishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudPublish"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudPublishFilterBuilder : SqlFilterBuilder<PgStudPublishColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudPublishFilterBuilder class.
		/// </summary>
		public PgStudPublishFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudPublishFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudPublishFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudPublishFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudPublishFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudPublishFilterBuilder
	
	#region PgStudPublishParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgStudPublishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudPublish"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgStudPublishParameterBuilder : ParameterizedSqlFilterBuilder<PgStudPublishColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudPublishParameterBuilder class.
		/// </summary>
		public PgStudPublishParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgStudPublishParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgStudPublishParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgStudPublishParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgStudPublishParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgStudPublishParameterBuilder
	
	#region PgStudPublishSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgStudPublishColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgStudPublish"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgStudPublishSortBuilder : SqlSortBuilder<PgStudPublishColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgStudPublishSqlSortBuilder class.
		/// </summary>
		public PgStudPublishSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgStudPublishSortBuilder
	
} // end namespace
