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
	/// This class is the base class for any <see cref="EdCodeQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeQual, UMIS_VER2.BusinessLyer.EdCodeQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualKey key)
		{
			return Delete(transactionManager, key.EdCodeQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeQualId)
		{
			return Delete(null, _edCodeQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeQualId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		public TList<EdCodeQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(_edCdeQualCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdCodeQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		public TList<EdCodeQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		fkEdCodeQualEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		public TList<EdCodeQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		fkEdCodeQualEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		public TList<EdCodeQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_CODE_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeQual objects.</returns>
		public abstract TList<EdCodeQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQualKey key, int start, int pageLength)
		{
			return GetByEdCodeQualId(transactionManager, key.EdCodeQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_QUAL_DESCR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeQual GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(null,_edCodeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength, out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeQual GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeQual&gt;"/></returns>
		public static TList<EdCodeQual> Fill(IDataReader reader, TList<EdCodeQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeQual")
					.Append("|").Append((System.Decimal)reader["ED_CODE_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeQual>(
					key.ToString(), // EntityTrackingKey
					"EdCodeQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeQual();
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
					c.EdCodeQualId = (System.Decimal)reader["ED_CODE_QUAL_ID"];
					c.OriginalEdCodeQualId = c.EdCodeQualId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.QualCode = Convert.IsDBNull(reader["QUAL_CODE"]) ? null : (System.String)reader["QUAL_CODE"];
					c.QualLevel = (System.Decimal)reader["QUAL_LEVEL"];
					c.EdCdeQualCatId = Convert.IsDBNull(reader["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_CAT_ID"];
					c.TotalMark = Convert.IsDBNull(reader["TOTAL_MARK"]) ? null : (System.Decimal?)reader["TOTAL_MARK"];
					c.ExmptnFlg = Convert.IsDBNull(reader["EXMPTN_FLG"]) ? null : (System.Boolean?)reader["EXMPTN_FLG"];
					c.MarkTypeFlg = Convert.IsDBNull(reader["MARK_TYPE_FLG"]) ? null : (System.Int32?)reader["MARK_TYPE_FLG"];
					c.ExceedFlg = Convert.IsDBNull(reader["EXCEED_FLG"]) ? null : (System.Int16?)reader["EXCEED_FLG"];
					c.SchoolGradeFlg = Convert.IsDBNull(reader["SCHOOL_GRADE_FLG"]) ? null : (System.Boolean?)reader["SCHOOL_GRADE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeQual entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeQualId = (System.Decimal)reader[((int)EdCodeQualColumn.EdCodeQualId - 1)];
			entity.OriginalEdCodeQualId = (System.Decimal)reader["ED_CODE_QUAL_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeQualColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeQualColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeQualColumn.DescrEn - 1)];
			entity.QualCode = (reader.IsDBNull(((int)EdCodeQualColumn.QualCode - 1)))?null:(System.String)reader[((int)EdCodeQualColumn.QualCode - 1)];
			entity.QualLevel = (System.Decimal)reader[((int)EdCodeQualColumn.QualLevel - 1)];
			entity.EdCdeQualCatId = (reader.IsDBNull(((int)EdCodeQualColumn.EdCdeQualCatId - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualColumn.EdCdeQualCatId - 1)];
			entity.TotalMark = (reader.IsDBNull(((int)EdCodeQualColumn.TotalMark - 1)))?null:(System.Decimal?)reader[((int)EdCodeQualColumn.TotalMark - 1)];
			entity.ExmptnFlg = (reader.IsDBNull(((int)EdCodeQualColumn.ExmptnFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualColumn.ExmptnFlg - 1)];
			entity.MarkTypeFlg = (reader.IsDBNull(((int)EdCodeQualColumn.MarkTypeFlg - 1)))?null:(System.Int32?)reader[((int)EdCodeQualColumn.MarkTypeFlg - 1)];
			entity.ExceedFlg = (reader.IsDBNull(((int)EdCodeQualColumn.ExceedFlg - 1)))?null:(System.Int16?)reader[((int)EdCodeQualColumn.ExceedFlg - 1)];
			entity.SchoolGradeFlg = (reader.IsDBNull(((int)EdCodeQualColumn.SchoolGradeFlg - 1)))?null:(System.Boolean?)reader[((int)EdCodeQualColumn.SchoolGradeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeQualId = (System.Decimal)dataRow["ED_CODE_QUAL_ID"];
			entity.OriginalEdCodeQualId = (System.Decimal)dataRow["ED_CODE_QUAL_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.QualCode = Convert.IsDBNull(dataRow["QUAL_CODE"]) ? null : (System.String)dataRow["QUAL_CODE"];
			entity.QualLevel = (System.Decimal)dataRow["QUAL_LEVEL"];
			entity.EdCdeQualCatId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_CAT_ID"];
			entity.TotalMark = Convert.IsDBNull(dataRow["TOTAL_MARK"]) ? null : (System.Decimal?)dataRow["TOTAL_MARK"];
			entity.ExmptnFlg = Convert.IsDBNull(dataRow["EXMPTN_FLG"]) ? null : (System.Boolean?)dataRow["EXMPTN_FLG"];
			entity.MarkTypeFlg = Convert.IsDBNull(dataRow["MARK_TYPE_FLG"]) ? null : (System.Int32?)dataRow["MARK_TYPE_FLG"];
			entity.ExceedFlg = Convert.IsDBNull(dataRow["EXCEED_FLG"]) ? null : (System.Int16?)dataRow["EXCEED_FLG"];
			entity.SchoolGradeFlg = Convert.IsDBNull(dataRow["SCHOOL_GRADE_FLG"]) ? null : (System.Boolean?)dataRow["SCHOOL_GRADE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeQualCatIdSource	
			if (CanDeepLoad(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualCatId ?? 0.0m);
				EdCdeQualCat tmpEntity = EntityManager.LocateEntity<EdCdeQualCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualCatIdSource = tmpEntity;
				else
					entity.EdCdeQualCatIdSource = DataRepository.EdCdeQualCatProvider.GetByEdCdeQualCatId(transactionManager, (entity.EdCdeQualCatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualCatProvider.DeepLoad(transactionManager, entity.EdCdeQualCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualCatIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeQualId methods when available
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCdeQualBrnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCdeQualBrn>|EdCdeQualBrnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualBrnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCdeQualBrnCollection = DataRepository.EdCdeQualBrnProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);

				if (deep && entity.EdCdeQualBrnCollection.Count > 0)
				{
					deepHandles.Add("EdCdeQualBrnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCdeQualBrn>) DataRepository.EdCdeQualBrnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCdeQualBrnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeQualCatIdSource
			if (CanDeepSave(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualCatIdSource != null)
			{
				DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatIdSource);
				entity.EdCdeQualCatId = entity.EdCdeQualCatIdSource.EdCdeQualCatId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.EdCodeQualIdSource != null)
						{
							child.EdCodeQualId = child.EdCodeQualIdSource.EdCodeQualId;
						}
						else
						{
							child.EdCodeQualId = entity.EdCodeQualId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.EdCodeQualIdSource != null)
						{
							child.EdCodeQualId = child.EdCodeQualIdSource.EdCodeQualId;
						}
						else
						{
							child.EdCodeQualId = entity.EdCodeQualId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCdeQualBrn>
				if (CanDeepSave(entity.EdCdeQualBrnCollection, "List<EdCdeQualBrn>|EdCdeQualBrnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCdeQualBrn child in entity.EdCdeQualBrnCollection)
					{
						if(child.EdCodeQualIdSource != null)
						{
							child.EdCodeQualId = child.EdCodeQualIdSource.EdCodeQualId;
						}
						else
						{
							child.EdCodeQualId = entity.EdCodeQualId;
						}

					}

					if (entity.EdCdeQualBrnCollection.Count > 0 || entity.EdCdeQualBrnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCdeQualBrnProvider.Save(transactionManager, entity.EdCdeQualBrnCollection);
						
						deepHandles.Add("EdCdeQualBrnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCdeQualBrn >) DataRepository.EdCdeQualBrnProvider.DeepSave,
							new object[] { transactionManager, entity.EdCdeQualBrnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdCodeQualIdSource != null)
						{
							child.EdCodeQualId = child.EdCodeQualIdSource.EdCodeQualId;
						}
						else
						{
							child.EdCodeQualId = entity.EdCodeQualId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeQual</c>
	///</summary>
	public enum EdCodeQualChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeQualCat</c> at EdCdeQualCatIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualCat))]
		EdCdeQualCat,
		///<summary>
		/// Collection of <c>EdCodeQual</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>EdCodeQual</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>EdCodeQual</c> as OneToMany for EdCdeQualBrnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCdeQualBrn>))]
		EdCdeQualBrnCollection,
		///<summary>
		/// Collection of <c>EdCodeQual</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion EdCodeQualChildEntityTypes
	
	#region EdCodeQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualFilterBuilder : SqlFilterBuilder<EdCodeQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualFilterBuilder class.
		/// </summary>
		public EdCodeQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualFilterBuilder
	
	#region EdCodeQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeQualParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualParameterBuilder class.
		/// </summary>
		public EdCodeQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeQualParameterBuilder
	
	#region EdCodeQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeQualSortBuilder : SqlSortBuilder<EdCodeQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeQualSqlSortBuilder class.
		/// </summary>
		public EdCodeQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeQualSortBuilder
	
} // end namespace
