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
	/// This class is the base class for any <see cref="FeeCourseExpProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCourseExpProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCourseExp, UMIS_VER2.BusinessLyer.FeeCourseExpKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCourseExpKey key)
		{
			return Delete(transactionManager, key.FeeCourseExpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCourseExpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCourseExpId)
		{
			return Delete(null, _feeCourseExpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCourseExpId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCourseExpId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		FK_FEE_COURSE_EXP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		public TList<FeeCourseExp> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		FK_FEE_COURSE_EXP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCourseExp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		FK_FEE_COURSE_EXP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		public TList<FeeCourseExp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		fkFeeCourseExpEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		public TList<FeeCourseExp> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		fkFeeCourseExpEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		public TList<FeeCourseExp> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_COURSE_EXP_ED_ACAD_YEAR key.
		///		FK_FEE_COURSE_EXP_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU/HU Core/Academic Fee different for some years not admission year</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCourseExp objects.</returns>
		public abstract TList<FeeCourseExp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeCourseExp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCourseExpKey key, int start, int pageLength)
		{
			return GetByFeeCourseExpId(transactionManager, key.FeeCourseExpId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByEdCourseId(System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public abstract TList<FeeCourseExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null,_feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyItemId(transactionManager, _feeFacultyItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public TList<FeeCourseExp> GetByFeeFacultyItemId(System.Decimal _feeFacultyItemId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyItemId(null, _feeFacultyItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_FACULTY_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCourseExp&gt;"/> class.</returns>
		public abstract TList<FeeCourseExp> GetByFeeFacultyItemId(TransactionManager transactionManager, System.Decimal _feeFacultyItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_COURSES index.
		/// </summary>
		/// <param name="_feeCourseExpId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(System.Decimal _feeCourseExpId)
		{
			int count = -1;
			return GetByFeeCourseExpId(null,_feeCourseExpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_COURSES index.
		/// </summary>
		/// <param name="_feeCourseExpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(System.Decimal _feeCourseExpId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCourseExpId(null, _feeCourseExpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCourseExpId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(TransactionManager transactionManager, System.Decimal _feeCourseExpId)
		{
			int count = -1;
			return GetByFeeCourseExpId(transactionManager, _feeCourseExpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCourseExpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(TransactionManager transactionManager, System.Decimal _feeCourseExpId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCourseExpId(transactionManager, _feeCourseExpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_COURSES index.
		/// </summary>
		/// <param name="_feeCourseExpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(System.Decimal _feeCourseExpId, int start, int pageLength, out int count)
		{
			return GetByFeeCourseExpId(null, _feeCourseExpId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_COURSES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCourseExpId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCourseExp GetByFeeCourseExpId(TransactionManager transactionManager, System.Decimal _feeCourseExpId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCourseExp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCourseExp&gt;"/></returns>
		public static TList<FeeCourseExp> Fill(IDataReader reader, TList<FeeCourseExp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCourseExp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCourseExp")
					.Append("|").Append((System.Decimal)reader["FEE_COURSE_EXP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCourseExp>(
					key.ToString(), // EntityTrackingKey
					"FeeCourseExp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCourseExp();
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
					c.FeeCourseExpId = (System.Decimal)reader["FEE_COURSE_EXP_ID"];
					c.OriginalFeeCourseExpId = c.FeeCourseExpId;
					c.FeeFacultyItemId = (System.Decimal)reader["FEE_FACULTY_ITEM_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.ChFee = Convert.IsDBNull(reader["CH_FEE"]) ? null : (System.Decimal?)reader["CH_FEE"];
					c.CourseFee = Convert.IsDBNull(reader["COURSE_FEE"]) ? null : (System.Decimal?)reader["COURSE_FEE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCourseExp entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCourseExpId = (System.Decimal)reader[((int)FeeCourseExpColumn.FeeCourseExpId - 1)];
			entity.OriginalFeeCourseExpId = (System.Decimal)reader["FEE_COURSE_EXP_ID"];
			entity.FeeFacultyItemId = (System.Decimal)reader[((int)FeeCourseExpColumn.FeeFacultyItemId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)FeeCourseExpColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)FeeCourseExpColumn.EdAcadYearId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)FeeCourseExpColumn.EdCourseId - 1)];
			entity.ChFee = (reader.IsDBNull(((int)FeeCourseExpColumn.ChFee - 1)))?null:(System.Decimal?)reader[((int)FeeCourseExpColumn.ChFee - 1)];
			entity.CourseFee = (reader.IsDBNull(((int)FeeCourseExpColumn.CourseFee - 1)))?null:(System.Decimal?)reader[((int)FeeCourseExpColumn.CourseFee - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCourseExp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCourseExpId = (System.Decimal)dataRow["FEE_COURSE_EXP_ID"];
			entity.OriginalFeeCourseExpId = (System.Decimal)dataRow["FEE_COURSE_EXP_ID"];
			entity.FeeFacultyItemId = (System.Decimal)dataRow["FEE_FACULTY_ITEM_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.ChFee = Convert.IsDBNull(dataRow["CH_FEE"]) ? null : (System.Decimal?)dataRow["CH_FEE"];
			entity.CourseFee = Convert.IsDBNull(dataRow["COURSE_FEE"]) ? null : (System.Decimal?)dataRow["COURSE_FEE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCourseExp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCourseExp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCourseExp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region FeeFacultyItemIdSource	
			if (CanDeepLoad(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyItemId;
				FeeFacultyItem tmpEntity = EntityManager.LocateEntity<FeeFacultyItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyItemIdSource = tmpEntity;
				else
					entity.FeeFacultyItemIdSource = DataRepository.FeeFacultyItemProvider.GetByFeeFacultyItemId(transactionManager, entity.FeeFacultyItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyItemProvider.DeepLoad(transactionManager, entity.FeeFacultyItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCourseExp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCourseExp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCourseExp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCourseExp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region FeeFacultyItemIdSource
			if (CanDeepSave(entity, "FeeFacultyItem|FeeFacultyItemIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyItemIdSource != null)
			{
				DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemIdSource);
				entity.FeeFacultyItemId = entity.FeeFacultyItemIdSource.FeeFacultyItemId;
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
	
	#region FeeCourseExpChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCourseExp</c>
	///</summary>
	public enum FeeCourseExpChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyItem</c> at FeeFacultyItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyItem))]
		FeeFacultyItem,
	}
	
	#endregion FeeCourseExpChildEntityTypes
	
	#region FeeCourseExpFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCourseExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCourseExp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCourseExpFilterBuilder : SqlFilterBuilder<FeeCourseExpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpFilterBuilder class.
		/// </summary>
		public FeeCourseExpFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCourseExpFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCourseExpFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCourseExpFilterBuilder
	
	#region FeeCourseExpParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCourseExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCourseExp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCourseExpParameterBuilder : ParameterizedSqlFilterBuilder<FeeCourseExpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpParameterBuilder class.
		/// </summary>
		public FeeCourseExpParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCourseExpParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCourseExpParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCourseExpParameterBuilder
	
	#region FeeCourseExpSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCourseExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCourseExp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCourseExpSortBuilder : SqlSortBuilder<FeeCourseExpColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCourseExpSqlSortBuilder class.
		/// </summary>
		public FeeCourseExpSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCourseExpSortBuilder
	
} // end namespace
