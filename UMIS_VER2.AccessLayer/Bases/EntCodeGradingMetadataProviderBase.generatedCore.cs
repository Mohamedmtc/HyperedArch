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
	/// This class is the base class for any <see cref="EntCodeGradingMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodeGradingMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodeGradingMetadata, UMIS_VER2.BusinessLyer.EntCodeGradingMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadataKey key)
		{
			return Delete(transactionManager, key.EntCodeGradingMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodeGradingMdId">XX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodeGradingMdId)
		{
			return Delete(null, _entCodeGradingMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId">XX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(_entCodeMdTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodeGradingMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		fkEntCodeGradingMetadataEdCodeMdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public abstract TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(_edCodeStudyMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		/// <remarks></remarks>
		public TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodeGradingMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		fkEntCodeGradingMetadataEdCodeStudyMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(System.Decimal? _edCodeStudyMethodId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public abstract TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCodeGradingMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadataKey key, int start, int pageLength)
		{
			return GetByEntCodeGradingMdId(transactionManager, key.EntCodeGradingMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GRAD_REQ index.
		/// </summary>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(null,_entCodeGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(null, _entCodeGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(transactionManager, _entCodeGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(transactionManager, _entCodeGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeGradingMdId(null, _entCodeGradingMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodeGradingMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodeGradingMetadata&gt;"/></returns>
		public static TList<EntCodeGradingMetadata> Fill(IDataReader reader, TList<EntCodeGradingMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodeGradingMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodeGradingMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_GRADING_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodeGradingMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntCodeGradingMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodeGradingMetadata();
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
					c.EntCodeGradingMdId = (System.Decimal)reader["ENT_CODE_GRADING_MD_ID"];
					c.OriginalEntCodeGradingMdId = c.EntCodeGradingMdId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntCodeMdTypeId = (System.Decimal)reader["ENT_CODE_MD_TYPE_ID"];
					c.SpChkName = Convert.IsDBNull(reader["SP_CHK_NAME"]) ? null : (System.String)reader["SP_CHK_NAME"];
					c.TblRltdFlg = (System.Decimal)reader["TBL_RLTD_FLG"];
					c.TblName = Convert.IsDBNull(reader["TBL_NAME"]) ? null : (System.String)reader["TBL_NAME"];
					c.EdCodeStudyMethodId = Convert.IsDBNull(reader["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUDY_METHOD_ID"];
					c.DispOrder = Convert.IsDBNull(reader["DISP_ORDER"]) ? null : (System.Decimal?)reader["DISP_ORDER"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeGradingMdId = (System.Decimal)reader[((int)EntCodeGradingMetadataColumn.EntCodeGradingMdId - 1)];
			entity.OriginalEntCodeGradingMdId = (System.Decimal)reader["ENT_CODE_GRADING_MD_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.DescrAr - 1)))?null:(System.String)reader[((int)EntCodeGradingMetadataColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntCodeGradingMetadataColumn.DescrEn - 1)];
			entity.EntCodeMdTypeId = (System.Decimal)reader[((int)EntCodeGradingMetadataColumn.EntCodeMdTypeId - 1)];
			entity.SpChkName = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.SpChkName - 1)))?null:(System.String)reader[((int)EntCodeGradingMetadataColumn.SpChkName - 1)];
			entity.TblRltdFlg = (System.Decimal)reader[((int)EntCodeGradingMetadataColumn.TblRltdFlg - 1)];
			entity.TblName = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.TblName - 1)))?null:(System.String)reader[((int)EntCodeGradingMetadataColumn.TblName - 1)];
			entity.EdCodeStudyMethodId = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.EdCodeStudyMethodId - 1)))?null:(System.Decimal?)reader[((int)EntCodeGradingMetadataColumn.EdCodeStudyMethodId - 1)];
			entity.DispOrder = (reader.IsDBNull(((int)EntCodeGradingMetadataColumn.DispOrder - 1)))?null:(System.Decimal?)reader[((int)EntCodeGradingMetadataColumn.DispOrder - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeGradingMdId = (System.Decimal)dataRow["ENT_CODE_GRADING_MD_ID"];
			entity.OriginalEntCodeGradingMdId = (System.Decimal)dataRow["ENT_CODE_GRADING_MD_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EntCodeMdTypeId = (System.Decimal)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.SpChkName = Convert.IsDBNull(dataRow["SP_CHK_NAME"]) ? null : (System.String)dataRow["SP_CHK_NAME"];
			entity.TblRltdFlg = (System.Decimal)dataRow["TBL_RLTD_FLG"];
			entity.TblName = Convert.IsDBNull(dataRow["TBL_NAME"]) ? null : (System.String)dataRow["TBL_NAME"];
			entity.EdCodeStudyMethodId = Convert.IsDBNull(dataRow["ED_CODE_STUDY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.DispOrder = Convert.IsDBNull(dataRow["DISP_ORDER"]) ? null : (System.Decimal?)dataRow["DISP_ORDER"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeGradingMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntCodeMdTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeMdTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeMdTypeId;
				EntCodeMdType tmpEntity = EntityManager.LocateEntity<EntCodeMdType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeMdType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeMdTypeIdSource = tmpEntity;
				else
					entity.EntCodeMdTypeIdSource = DataRepository.EntCodeMdTypeProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeMdTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeMdTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeMdTypeProvider.DeepLoad(transactionManager, entity.EntCodeMdTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeMdTypeIdSource

			#region EdCodeStudyMethodIdSource	
			if (CanDeepLoad(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudyMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStudyMethodId ?? 0.0m);
				EdCodeStudyMethod tmpEntity = EntityManager.LocateEntity<EdCodeStudyMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudyMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudyMethodIdSource = tmpEntity;
				else
					entity.EdCodeStudyMethodIdSource = DataRepository.EdCodeStudyMethodProvider.GetByEdCodeStudyMethodId(transactionManager, (entity.EdCodeStudyMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudyMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudyMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudyMethodProvider.DeepLoad(transactionManager, entity.EdCodeStudyMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudyMethodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodeGradingMdId methods when available
			
			#region EntGradingMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntGradingMetadata>|EntGradingMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGradingMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntGradingMetadataCollection = DataRepository.EntGradingMetadataProvider.GetByEntCodeGradingMdId(transactionManager, entity.EntCodeGradingMdId);

				if (deep && entity.EntGradingMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntGradingMetadata>) DataRepository.EntGradingMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntGradingMetadataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeGradingMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeGradingMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntCodeMdTypeIdSource
			if (CanDeepSave(entity, "EntCodeMdType|EntCodeMdTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeMdTypeIdSource != null)
			{
				DataRepository.EntCodeMdTypeProvider.Save(transactionManager, entity.EntCodeMdTypeIdSource);
				entity.EntCodeMdTypeId = entity.EntCodeMdTypeIdSource.EntCodeMdTypeId;
			}
			#endregion 
			
			#region EdCodeStudyMethodIdSource
			if (CanDeepSave(entity, "EdCodeStudyMethod|EdCodeStudyMethodIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudyMethodIdSource != null)
			{
				DataRepository.EdCodeStudyMethodProvider.Save(transactionManager, entity.EdCodeStudyMethodIdSource);
				entity.EdCodeStudyMethodId = entity.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntGradingMetadata>
				if (CanDeepSave(entity.EntGradingMetadataCollection, "List<EntGradingMetadata>|EntGradingMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntGradingMetadata child in entity.EntGradingMetadataCollection)
					{
						if(child.EntCodeGradingMdIdSource != null)
						{
							child.EntCodeGradingMdId = child.EntCodeGradingMdIdSource.EntCodeGradingMdId;
						}
						else
						{
							child.EntCodeGradingMdId = entity.EntCodeGradingMdId;
						}

					}

					if (entity.EntGradingMetadataCollection.Count > 0 || entity.EntGradingMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntGradingMetadataProvider.Save(transactionManager, entity.EntGradingMetadataCollection);
						
						deepHandles.Add("EntGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntGradingMetadata >) DataRepository.EntGradingMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntGradingMetadataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodeGradingMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodeGradingMetadata</c>
	///</summary>
	public enum EntCodeGradingMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeMdType</c> at EntCodeMdTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeMdType))]
		EntCodeMdType,
		
		///<summary>
		/// Composite Property for <c>EdCodeStudyMethod</c> at EdCodeStudyMethodIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudyMethod))]
		EdCodeStudyMethod,
		///<summary>
		/// Collection of <c>EntCodeGradingMetadata</c> as OneToMany for EntGradingMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntGradingMetadata>))]
		EntGradingMetadataCollection,
	}
	
	#endregion EntCodeGradingMetadataChildEntityTypes
	
	#region EntCodeGradingMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodeGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeGradingMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeGradingMetadataFilterBuilder : SqlFilterBuilder<EntCodeGradingMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataFilterBuilder class.
		/// </summary>
		public EntCodeGradingMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeGradingMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeGradingMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeGradingMetadataFilterBuilder
	
	#region EntCodeGradingMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodeGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeGradingMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeGradingMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntCodeGradingMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataParameterBuilder class.
		/// </summary>
		public EntCodeGradingMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeGradingMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeGradingMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeGradingMetadataParameterBuilder
	
	#region EntCodeGradingMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodeGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeGradingMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodeGradingMetadataSortBuilder : SqlSortBuilder<EntCodeGradingMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeGradingMetadataSqlSortBuilder class.
		/// </summary>
		public EntCodeGradingMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodeGradingMetadataSortBuilder
	
} // end namespace
