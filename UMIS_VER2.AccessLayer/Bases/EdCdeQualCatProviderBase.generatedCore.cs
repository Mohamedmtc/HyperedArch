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
	/// This class is the base class for any <see cref="EdCdeQualCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeQualCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeQualCat, UMIS_VER2.BusinessLyer.EdCdeQualCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualCatKey key)
		{
			return Delete(transactionManager, key.EdCdeQualCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeQualCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeQualCatId)
		{
			return Delete(null, _edCdeQualCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeQualCatId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAdmRegStepsId(System.Decimal? _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(_admRegStepsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		/// <remarks></remarks>
		public TList<EdCdeQualCat> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRegStepsId(transactionManager, _admRegStepsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		fkEdCdeQualCatAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAdmRegStepsId(System.Decimal? _admRegStepsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		fkEdCdeQualCatAdmRegSteps Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAdmRegStepsId(System.Decimal? _admRegStepsId, int start, int pageLength,out int count)
		{
			return GetByAdmRegStepsId(null, _admRegStepsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS key.
		///		FK_ED_CDE_QUAL_CAT_ADM_REG_STEPS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRegStepsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public abstract TList<EdCdeQualCat> GetByAdmRegStepsId(TransactionManager transactionManager, System.Decimal? _admRegStepsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		/// <remarks></remarks>
		public TList<EdCdeQualCat> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		fkEdCdeQualCatAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		fkEdCdeQualCatAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public abstract TList<EdCdeQualCat> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		/// <remarks></remarks>
		public TList<EdCdeQualCat> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		fkEdCdeQualCatAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		fkEdCdeQualCatAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public TList<EdCdeQualCat> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_CDE_QUAL_CAT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualCat objects.</returns>
		public abstract TList<EdCdeQualCat> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeQualCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualCatKey key, int start, int pageLength)
		{
			return GetByEdCdeQualCatId(transactionManager, key.EdCdeQualCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(null,_edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId, int start, int pageLength, out int count)
		{
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeQualCat GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeQualCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeQualCat&gt;"/></returns>
		public static TList<EdCdeQualCat> Fill(IDataReader reader, TList<EdCdeQualCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeQualCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeQualCat")
					.Append("|").Append((System.Decimal)reader["ED_CDE_QUAL_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeQualCat>(
					key.ToString(), // EntityTrackingKey
					"EdCdeQualCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeQualCat();
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
					c.EdCdeQualCatId = (System.Decimal)reader["ED_CDE_QUAL_CAT_ID"];
					c.OriginalEdCdeQualCatId = c.EdCdeQualCatId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.SeatNoFlg = Convert.IsDBNull(reader["SEAT_NO_FLG"]) ? null : (System.Boolean?)reader["SEAT_NO_FLG"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AdmRegStepsId = Convert.IsDBNull(reader["ADM_REG_STEPS_ID"]) ? null : (System.Decimal?)reader["ADM_REG_STEPS_ID"];
					c.UsrPwdFlg = Convert.IsDBNull(reader["USR_PWD_FLG"]) ? null : (System.Boolean?)reader["USR_PWD_FLG"];
					c.SchoolTypeFlg = Convert.IsDBNull(reader["SCHOOL_TYPE_FLG"]) ? null : (System.Boolean?)reader["SCHOOL_TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeQualCat entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeQualCatId = (System.Decimal)reader[((int)EdCdeQualCatColumn.EdCdeQualCatId - 1)];
			entity.OriginalEdCdeQualCatId = (System.Decimal)reader["ED_CDE_QUAL_CAT_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCdeQualCatColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCdeQualCatColumn.DescrEn - 1)];
			entity.SeatNoFlg = (reader.IsDBNull(((int)EdCdeQualCatColumn.SeatNoFlg - 1)))?null:(System.Boolean?)reader[((int)EdCdeQualCatColumn.SeatNoFlg - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EdCdeQualCatColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EdCdeQualCatColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EdCdeQualCatColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EdCdeQualCatColumn.AsCodeDegreeId - 1)];
			entity.AdmRegStepsId = (reader.IsDBNull(((int)EdCdeQualCatColumn.AdmRegStepsId - 1)))?null:(System.Decimal?)reader[((int)EdCdeQualCatColumn.AdmRegStepsId - 1)];
			entity.UsrPwdFlg = (reader.IsDBNull(((int)EdCdeQualCatColumn.UsrPwdFlg - 1)))?null:(System.Boolean?)reader[((int)EdCdeQualCatColumn.UsrPwdFlg - 1)];
			entity.SchoolTypeFlg = (reader.IsDBNull(((int)EdCdeQualCatColumn.SchoolTypeFlg - 1)))?null:(System.Boolean?)reader[((int)EdCdeQualCatColumn.SchoolTypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeQualCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeQualCatId = (System.Decimal)dataRow["ED_CDE_QUAL_CAT_ID"];
			entity.OriginalEdCdeQualCatId = (System.Decimal)dataRow["ED_CDE_QUAL_CAT_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.SeatNoFlg = Convert.IsDBNull(dataRow["SEAT_NO_FLG"]) ? null : (System.Boolean?)dataRow["SEAT_NO_FLG"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AdmRegStepsId = Convert.IsDBNull(dataRow["ADM_REG_STEPS_ID"]) ? null : (System.Decimal?)dataRow["ADM_REG_STEPS_ID"];
			entity.UsrPwdFlg = Convert.IsDBNull(dataRow["USR_PWD_FLG"]) ? null : (System.Boolean?)dataRow["USR_PWD_FLG"];
			entity.SchoolTypeFlg = Convert.IsDBNull(dataRow["SCHOOL_TYPE_FLG"]) ? null : (System.Boolean?)dataRow["SCHOOL_TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmRegStepsIdSource	
			if (CanDeepLoad(entity, "AdmRegSteps|AdmRegStepsIdSource", deepLoadType, innerList) 
				&& entity.AdmRegStepsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmRegStepsId ?? 0.0m);
				AdmRegSteps tmpEntity = EntityManager.LocateEntity<AdmRegSteps>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmRegSteps), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmRegStepsIdSource = tmpEntity;
				else
					entity.AdmRegStepsIdSource = DataRepository.AdmRegStepsProvider.GetByAdmRegStepsId(transactionManager, (entity.AdmRegStepsId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRegStepsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmRegStepsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmRegStepsProvider.DeepLoad(transactionManager, entity.AdmRegStepsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmRegStepsIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeQualCatId methods when available
			
			#region FeeCdeDiscTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeDiscTypeCollection = DataRepository.FeeCdeDiscTypeProvider.GetByEdCdeQualCatId(transactionManager, entity.EdCdeQualCatId);

				if (deep && entity.FeeCdeDiscTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeDiscType>) DataRepository.FeeCdeDiscTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCdeQualCatId(transactionManager, entity.EdCdeQualCatId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQual>|EdCodeQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualCollection = DataRepository.EdCodeQualProvider.GetByEdCdeQualCatId(transactionManager, entity.EdCdeQualCatId);

				if (deep && entity.EdCodeQualCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQual>) DataRepository.EdCodeQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmFeeQualCatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmFeeQualCat>|AdmFeeQualCatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmFeeQualCatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmFeeQualCatCollection = DataRepository.AdmFeeQualCatProvider.GetByEdCdeQualCatId(transactionManager, entity.EdCdeQualCatId);

				if (deep && entity.AdmFeeQualCatCollection.Count > 0)
				{
					deepHandles.Add("AdmFeeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmFeeQualCat>) DataRepository.AdmFeeQualCatProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmFeeQualCatCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeQualCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeQualCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmRegStepsIdSource
			if (CanDeepSave(entity, "AdmRegSteps|AdmRegStepsIdSource", deepSaveType, innerList) 
				&& entity.AdmRegStepsIdSource != null)
			{
				DataRepository.AdmRegStepsProvider.Save(transactionManager, entity.AdmRegStepsIdSource);
				entity.AdmRegStepsId = entity.AdmRegStepsIdSource.AdmRegStepsId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeCdeDiscType>
				if (CanDeepSave(entity.FeeCdeDiscTypeCollection, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeDiscType child in entity.FeeCdeDiscTypeCollection)
					{
						if(child.EdCdeQualCatIdSource != null)
						{
							child.EdCdeQualCatId = child.EdCdeQualCatIdSource.EdCdeQualCatId;
						}
						else
						{
							child.EdCdeQualCatId = entity.EdCdeQualCatId;
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
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdCdeQualCatIdSource != null)
						{
							child.EdCdeQualCatId = child.EdCdeQualCatIdSource.EdCdeQualCatId;
						}
						else
						{
							child.EdCdeQualCatId = entity.EdCdeQualCatId;
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
				
	
			#region List<EdCodeQual>
				if (CanDeepSave(entity.EdCodeQualCollection, "List<EdCodeQual>|EdCodeQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQual child in entity.EdCodeQualCollection)
					{
						if(child.EdCdeQualCatIdSource != null)
						{
							child.EdCdeQualCatId = child.EdCdeQualCatIdSource.EdCdeQualCatId;
						}
						else
						{
							child.EdCdeQualCatId = entity.EdCdeQualCatId;
						}

					}

					if (entity.EdCodeQualCollection.Count > 0 || entity.EdCodeQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualCollection);
						
						deepHandles.Add("EdCodeQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQual >) DataRepository.EdCodeQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmFeeQualCat>
				if (CanDeepSave(entity.AdmFeeQualCatCollection, "List<AdmFeeQualCat>|AdmFeeQualCatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmFeeQualCat child in entity.AdmFeeQualCatCollection)
					{
						if(child.EdCdeQualCatIdSource != null)
						{
							child.EdCdeQualCatId = child.EdCdeQualCatIdSource.EdCdeQualCatId;
						}
						else
						{
							child.EdCdeQualCatId = entity.EdCdeQualCatId;
						}

					}

					if (entity.AdmFeeQualCatCollection.Count > 0 || entity.AdmFeeQualCatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmFeeQualCatProvider.Save(transactionManager, entity.AdmFeeQualCatCollection);
						
						deepHandles.Add("AdmFeeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmFeeQualCat >) DataRepository.AdmFeeQualCatProvider.DeepSave,
							new object[] { transactionManager, entity.AdmFeeQualCatCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeQualCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeQualCat</c>
	///</summary>
	public enum EdCdeQualCatChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmRegSteps</c> at AdmRegStepsIdSource
		///</summary>
		[ChildEntityType(typeof(AdmRegSteps))]
		AdmRegSteps,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		///<summary>
		/// Collection of <c>EdCdeQualCat</c> as OneToMany for FeeCdeDiscTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeDiscType>))]
		FeeCdeDiscTypeCollection,
		///<summary>
		/// Collection of <c>EdCdeQualCat</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>EdCdeQualCat</c> as OneToMany for EdCodeQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQual>))]
		EdCodeQualCollection,
		///<summary>
		/// Collection of <c>EdCdeQualCat</c> as OneToMany for AdmFeeQualCatCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmFeeQualCat>))]
		AdmFeeQualCatCollection,
	}
	
	#endregion EdCdeQualCatChildEntityTypes
	
	#region EdCdeQualCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualCatFilterBuilder : SqlFilterBuilder<EdCdeQualCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatFilterBuilder class.
		/// </summary>
		public EdCdeQualCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualCatFilterBuilder
	
	#region EdCdeQualCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualCatParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeQualCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatParameterBuilder class.
		/// </summary>
		public EdCdeQualCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualCatParameterBuilder
	
	#region EdCdeQualCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeQualCatSortBuilder : SqlSortBuilder<EdCdeQualCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualCatSqlSortBuilder class.
		/// </summary>
		public EdCdeQualCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeQualCatSortBuilder
	
} // end namespace
