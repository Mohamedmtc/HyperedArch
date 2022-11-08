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
	/// This class is the base class for any <see cref="AdmRatingParamMajorTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRatingParamMajorTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRatingParamMajorType, UMIS_VER2.BusinessLyer.AdmRatingParamMajorTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParamMajorTypeKey key)
		{
			return Delete(transactionManager, key.AdmRatingParamMajorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admRatingParamMajorTypeId)
		{
			return Delete(null, _admRatingParamMajorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admRatingParamMajorTypeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		fkAdmRatingParamMajorTypeAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		fkAdmRatingParamMajorTypeAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(System.Decimal _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public abstract TList<AdmRatingParamMajorType> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS Description: 
		/// </summary>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(_admRatingParametersMajorsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(transactionManager, _admRatingParametersMajorsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParametersMajorsId(transactionManager, _admRatingParametersMajorsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		fkAdmRatingParamMajorTypeAdmRatingParametersMajors Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmRatingParametersMajorsId(null, _admRatingParametersMajorsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		fkAdmRatingParamMajorTypeAdmRatingParametersMajors Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(System.Decimal _admRatingParametersMajorsId, int start, int pageLength,out int count)
		{
			return GetByAdmRatingParametersMajorsId(null, _admRatingParametersMajorsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS key.
		///		FK_ADM_RATING_PARAM_MAJOR_TYPE_ADM_RATING_PARAMETERS_MAJORS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersMajorsId">خطة الأعداد المقترحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParamMajorType objects.</returns>
		public abstract TList<AdmRatingParamMajorType> GetByAdmRatingParametersMajorsId(TransactionManager transactionManager, System.Decimal _admRatingParametersMajorsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmRatingParamMajorType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParamMajorTypeKey key, int start, int pageLength)
		{
			return GetByAdmRatingParamMajorTypeId(transactionManager, key.AdmRatingParamMajorTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(System.Decimal _admRatingParamMajorTypeId)
		{
			int count = -1;
			return GetByAdmRatingParamMajorTypeId(null,_admRatingParamMajorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(System.Decimal _admRatingParamMajorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParamMajorTypeId(null, _admRatingParamMajorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(TransactionManager transactionManager, System.Decimal _admRatingParamMajorTypeId)
		{
			int count = -1;
			return GetByAdmRatingParamMajorTypeId(transactionManager, _admRatingParamMajorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(TransactionManager transactionManager, System.Decimal _admRatingParamMajorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParamMajorTypeId(transactionManager, _admRatingParamMajorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(System.Decimal _admRatingParamMajorTypeId, int start, int pageLength, out int count)
		{
			return GetByAdmRatingParamMajorTypeId(null, _admRatingParamMajorTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAM_MAJOR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParamMajorTypeId">CSS in case UG & AS_CODE_DEGREE_ID=1 بكالريوس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRatingParamMajorType GetByAdmRatingParamMajorTypeId(TransactionManager transactionManager, System.Decimal _admRatingParamMajorTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRatingParamMajorType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRatingParamMajorType&gt;"/></returns>
		public static TList<AdmRatingParamMajorType> Fill(IDataReader reader, TList<AdmRatingParamMajorType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRatingParamMajorType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRatingParamMajorType")
					.Append("|").Append((System.Decimal)reader["ADM_RATING_PARAM_MAJOR_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRatingParamMajorType>(
					key.ToString(), // EntityTrackingKey
					"AdmRatingParamMajorType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRatingParamMajorType();
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
					c.AdmRatingParamMajorTypeId = (System.Decimal)reader["ADM_RATING_PARAM_MAJOR_TYPE_ID"];
					c.OriginalAdmRatingParamMajorTypeId = c.AdmRatingParamMajorTypeId;
					c.AdmRatingParametersMajorsId = (System.Decimal)reader["ADM_RATING_PARAMETERS_MAJORS_ID"];
					c.AdmCdeAppTypeId = (System.Decimal)reader["ADM_CDE_APP_TYPE_ID"];
					c.AllRequiredNumbers = Convert.IsDBNull(reader["ALL_REQUIRED_NUMBERS"]) ? null : (System.Decimal?)reader["ALL_REQUIRED_NUMBERS"];
					c.MaleNumbers = Convert.IsDBNull(reader["MALE_NUMBERS"]) ? null : (System.Decimal?)reader["MALE_NUMBERS"];
					c.FemaleNumbers = Convert.IsDBNull(reader["FEMALE_NUMBERS"]) ? null : (System.Decimal?)reader["FEMALE_NUMBERS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRatingParamMajorType entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRatingParamMajorTypeId = (System.Decimal)reader[((int)AdmRatingParamMajorTypeColumn.AdmRatingParamMajorTypeId - 1)];
			entity.OriginalAdmRatingParamMajorTypeId = (System.Decimal)reader["ADM_RATING_PARAM_MAJOR_TYPE_ID"];
			entity.AdmRatingParametersMajorsId = (System.Decimal)reader[((int)AdmRatingParamMajorTypeColumn.AdmRatingParametersMajorsId - 1)];
			entity.AdmCdeAppTypeId = (System.Decimal)reader[((int)AdmRatingParamMajorTypeColumn.AdmCdeAppTypeId - 1)];
			entity.AllRequiredNumbers = (reader.IsDBNull(((int)AdmRatingParamMajorTypeColumn.AllRequiredNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParamMajorTypeColumn.AllRequiredNumbers - 1)];
			entity.MaleNumbers = (reader.IsDBNull(((int)AdmRatingParamMajorTypeColumn.MaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParamMajorTypeColumn.MaleNumbers - 1)];
			entity.FemaleNumbers = (reader.IsDBNull(((int)AdmRatingParamMajorTypeColumn.FemaleNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParamMajorTypeColumn.FemaleNumbers - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRatingParamMajorType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRatingParamMajorTypeId = (System.Decimal)dataRow["ADM_RATING_PARAM_MAJOR_TYPE_ID"];
			entity.OriginalAdmRatingParamMajorTypeId = (System.Decimal)dataRow["ADM_RATING_PARAM_MAJOR_TYPE_ID"];
			entity.AdmRatingParametersMajorsId = (System.Decimal)dataRow["ADM_RATING_PARAMETERS_MAJORS_ID"];
			entity.AdmCdeAppTypeId = (System.Decimal)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.AllRequiredNumbers = Convert.IsDBNull(dataRow["ALL_REQUIRED_NUMBERS"]) ? null : (System.Decimal?)dataRow["ALL_REQUIRED_NUMBERS"];
			entity.MaleNumbers = Convert.IsDBNull(dataRow["MALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["MALE_NUMBERS"];
			entity.FemaleNumbers = Convert.IsDBNull(dataRow["FEMALE_NUMBERS"]) ? null : (System.Decimal?)dataRow["FEMALE_NUMBERS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParamMajorType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParamMajorType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParamMajorType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeAppTypeId;
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, entity.AdmCdeAppTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

			#region AdmRatingParametersMajorsIdSource	
			if (CanDeepLoad(entity, "AdmRatingParametersMajors|AdmRatingParametersMajorsIdSource", deepLoadType, innerList) 
				&& entity.AdmRatingParametersMajorsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmRatingParametersMajorsId;
				AdmRatingParametersMajors tmpEntity = EntityManager.LocateEntity<AdmRatingParametersMajors>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmRatingParametersMajors), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmRatingParametersMajorsIdSource = tmpEntity;
				else
					entity.AdmRatingParametersMajorsIdSource = DataRepository.AdmRatingParametersMajorsProvider.GetByAdmRatingParametersMajorsId(transactionManager, entity.AdmRatingParametersMajorsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmRatingParametersMajorsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmRatingParametersMajorsProvider.DeepLoad(transactionManager, entity.AdmRatingParametersMajorsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmRatingParametersMajorsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRatingParamMajorType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRatingParamMajorType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParamMajorType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParamMajorType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AdmRatingParametersMajorsIdSource
			if (CanDeepSave(entity, "AdmRatingParametersMajors|AdmRatingParametersMajorsIdSource", deepSaveType, innerList) 
				&& entity.AdmRatingParametersMajorsIdSource != null)
			{
				DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsIdSource);
				entity.AdmRatingParametersMajorsId = entity.AdmRatingParametersMajorsIdSource.AdmRatingParametersMajorsId;
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
	
	#region AdmRatingParamMajorTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRatingParamMajorType</c>
	///</summary>
	public enum AdmRatingParamMajorTypeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmRatingParametersMajors</c> at AdmRatingParametersMajorsIdSource
		///</summary>
		[ChildEntityType(typeof(AdmRatingParametersMajors))]
		AdmRatingParametersMajors,
	}
	
	#endregion AdmRatingParamMajorTypeChildEntityTypes
	
	#region AdmRatingParamMajorTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRatingParamMajorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParamMajorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParamMajorTypeFilterBuilder : SqlFilterBuilder<AdmRatingParamMajorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeFilterBuilder class.
		/// </summary>
		public AdmRatingParamMajorTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParamMajorTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParamMajorTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParamMajorTypeFilterBuilder
	
	#region AdmRatingParamMajorTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRatingParamMajorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParamMajorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParamMajorTypeParameterBuilder : ParameterizedSqlFilterBuilder<AdmRatingParamMajorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeParameterBuilder class.
		/// </summary>
		public AdmRatingParamMajorTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParamMajorTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParamMajorTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParamMajorTypeParameterBuilder
	
	#region AdmRatingParamMajorTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRatingParamMajorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParamMajorType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRatingParamMajorTypeSortBuilder : SqlSortBuilder<AdmRatingParamMajorTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParamMajorTypeSqlSortBuilder class.
		/// </summary>
		public AdmRatingParamMajorTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRatingParamMajorTypeSortBuilder
	
} // end namespace
