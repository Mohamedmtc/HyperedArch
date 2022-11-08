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
	/// This class is the base class for any <see cref="FeeScholarshipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeScholarshipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeScholarship, UMIS_VER2.BusinessLyer.FeeScholarshipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeScholarshipKey key)
		{
			return Delete(transactionManager, key.FeeScholarshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeScholarshipId)
		{
			return Delete(null, _feeScholarshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeScholarshipId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		/// <remarks></remarks>
		public TList<FeeScholarship> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		fkFeeScholarshipAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		fkFeeScholarshipAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO key.
		///		FK_FEE_SCHOLARSHIP_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">الكلية- الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public abstract TList<FeeScholarship> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		/// <remarks></remarks>
		public TList<FeeScholarship> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		fkFeeScholarshipEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		fkFeeScholarshipEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR key.
		///		FK_FEE_SCHOLARSHIP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public abstract TList<FeeScholarship> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(_feeCdeSchshipCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		/// <remarks></remarks>
		public TList<FeeScholarship> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeSchshipCatId(transactionManager, _feeCdeSchshipCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		fkFeeScholarshipFeeCdeSchshipCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		fkFeeScholarshipFeeCdeSchshipCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public TList<FeeScholarship> GetByFeeCdeSchshipCatId(System.Int32 _feeCdeSchshipCatId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeSchshipCatId(null, _feeCdeSchshipCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT key.
		///		FK_FEE_SCHOLARSHIP_FEE_CDE_SCHSHIP_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipCatId">نوع المنحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeScholarship objects.</returns>
		public abstract TList<FeeScholarship> GetByFeeCdeSchshipCatId(TransactionManager transactionManager, System.Int32 _feeCdeSchshipCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeScholarship Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeScholarshipKey key, int start, int pageLength)
		{
			return GetByFeeScholarshipId(transactionManager, key.FeeScholarshipId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(System.Int32 _feeScholarshipId)
		{
			int count = -1;
			return GetByFeeScholarshipId(null,_feeScholarshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(System.Int32 _feeScholarshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeScholarshipId(null, _feeScholarshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(TransactionManager transactionManager, System.Int32 _feeScholarshipId)
		{
			int count = -1;
			return GetByFeeScholarshipId(transactionManager, _feeScholarshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(TransactionManager transactionManager, System.Int32 _feeScholarshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeScholarshipId(transactionManager, _feeScholarshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(System.Int32 _feeScholarshipId, int start, int pageLength, out int count)
		{
			return GetByFeeScholarshipId(null, _feeScholarshipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_SCHOLARSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeScholarshipId">XXXXXXXXXX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeScholarship GetByFeeScholarshipId(TransactionManager transactionManager, System.Int32 _feeScholarshipId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeScholarship&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeScholarship&gt;"/></returns>
		public static TList<FeeScholarship> Fill(IDataReader reader, TList<FeeScholarship> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeScholarship c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeScholarship")
					.Append("|").Append((System.Int32)reader["FEE_SCHOLARSHIP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeScholarship>(
					key.ToString(), // EntityTrackingKey
					"FeeScholarship",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeScholarship();
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
					c.FeeScholarshipId = (System.Int32)reader["FEE_SCHOLARSHIP_ID"];
					c.OriginalFeeScholarshipId = c.FeeScholarshipId;
					c.FeeCdeSchshipCatId = (System.Int32)reader["FEE_CDE_SCHSHIP_CAT_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.ParamFrom = Convert.IsDBNull(reader["PARAM_FROM"]) ? null : (System.Decimal?)reader["PARAM_FROM"];
					c.ParamTo = Convert.IsDBNull(reader["PARAM_TO"]) ? null : (System.Decimal?)reader["PARAM_TO"];
					c.DiscAmnt = Convert.IsDBNull(reader["DISC_AMNT"]) ? null : (System.Decimal?)reader["DISC_AMNT"];
					c.DiscPercent = Convert.IsDBNull(reader["DISC_PERCENT"]) ? null : (System.Decimal?)reader["DISC_PERCENT"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeScholarship entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeScholarshipId = (System.Int32)reader[((int)FeeScholarshipColumn.FeeScholarshipId - 1)];
			entity.OriginalFeeScholarshipId = (System.Int32)reader["FEE_SCHOLARSHIP_ID"];
			entity.FeeCdeSchshipCatId = (System.Int32)reader[((int)FeeScholarshipColumn.FeeCdeSchshipCatId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeScholarshipColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.AsFacultyInfoId - 1)];
			entity.ParamFrom = (reader.IsDBNull(((int)FeeScholarshipColumn.ParamFrom - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.ParamFrom - 1)];
			entity.ParamTo = (reader.IsDBNull(((int)FeeScholarshipColumn.ParamTo - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.ParamTo - 1)];
			entity.DiscAmnt = (reader.IsDBNull(((int)FeeScholarshipColumn.DiscAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.DiscAmnt - 1)];
			entity.DiscPercent = (reader.IsDBNull(((int)FeeScholarshipColumn.DiscPercent - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.DiscPercent - 1)];
			entity.IsActive = (reader.IsDBNull(((int)FeeScholarshipColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)FeeScholarshipColumn.IsActive - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)FeeScholarshipColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)FeeScholarshipColumn.EdAcadYearId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeScholarship entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeScholarshipId = (System.Int32)dataRow["FEE_SCHOLARSHIP_ID"];
			entity.OriginalFeeScholarshipId = (System.Int32)dataRow["FEE_SCHOLARSHIP_ID"];
			entity.FeeCdeSchshipCatId = (System.Int32)dataRow["FEE_CDE_SCHSHIP_CAT_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.ParamFrom = Convert.IsDBNull(dataRow["PARAM_FROM"]) ? null : (System.Decimal?)dataRow["PARAM_FROM"];
			entity.ParamTo = Convert.IsDBNull(dataRow["PARAM_TO"]) ? null : (System.Decimal?)dataRow["PARAM_TO"];
			entity.DiscAmnt = Convert.IsDBNull(dataRow["DISC_AMNT"]) ? null : (System.Decimal?)dataRow["DISC_AMNT"];
			entity.DiscPercent = Convert.IsDBNull(dataRow["DISC_PERCENT"]) ? null : (System.Decimal?)dataRow["DISC_PERCENT"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeScholarship"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeScholarship Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeScholarship entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
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

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region FeeCdeSchshipCatIdSource	
			if (CanDeepLoad(entity, "FeeCdeSchshipCat|FeeCdeSchshipCatIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeSchshipCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeSchshipCatId;
				FeeCdeSchshipCat tmpEntity = EntityManager.LocateEntity<FeeCdeSchshipCat>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeSchshipCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeSchshipCatIdSource = tmpEntity;
				else
					entity.FeeCdeSchshipCatIdSource = DataRepository.FeeCdeSchshipCatProvider.GetByFeeCdeSchshipCatId(transactionManager, entity.FeeCdeSchshipCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeSchshipCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeSchshipCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeSchshipCatProvider.DeepLoad(transactionManager, entity.FeeCdeSchshipCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeSchshipCatIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeScholarship object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeScholarship instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeScholarship Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeScholarship entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region FeeCdeSchshipCatIdSource
			if (CanDeepSave(entity, "FeeCdeSchshipCat|FeeCdeSchshipCatIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeSchshipCatIdSource != null)
			{
				DataRepository.FeeCdeSchshipCatProvider.Save(transactionManager, entity.FeeCdeSchshipCatIdSource);
				entity.FeeCdeSchshipCatId = entity.FeeCdeSchshipCatIdSource.FeeCdeSchshipCatId;
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
	
	#region FeeScholarshipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeScholarship</c>
	///</summary>
	public enum FeeScholarshipChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeCdeSchshipCat</c> at FeeCdeSchshipCatIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeSchshipCat))]
		FeeCdeSchshipCat,
	}
	
	#endregion FeeScholarshipChildEntityTypes
	
	#region FeeScholarshipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeScholarship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeScholarshipFilterBuilder : SqlFilterBuilder<FeeScholarshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipFilterBuilder class.
		/// </summary>
		public FeeScholarshipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeScholarshipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeScholarshipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeScholarshipFilterBuilder
	
	#region FeeScholarshipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeScholarship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeScholarshipParameterBuilder : ParameterizedSqlFilterBuilder<FeeScholarshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipParameterBuilder class.
		/// </summary>
		public FeeScholarshipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeScholarshipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeScholarshipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeScholarshipParameterBuilder
	
	#region FeeScholarshipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeScholarshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeScholarship"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeScholarshipSortBuilder : SqlSortBuilder<FeeScholarshipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeScholarshipSqlSortBuilder class.
		/// </summary>
		public FeeScholarshipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeScholarshipSortBuilder
	
} // end namespace
