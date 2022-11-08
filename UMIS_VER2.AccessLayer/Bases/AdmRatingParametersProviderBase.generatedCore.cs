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
	/// This class is the base class for any <see cref="AdmRatingParametersProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRatingParametersProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRatingParameters, UMIS_VER2.BusinessLyer.AdmRatingParametersKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersKey key)
		{
			return Delete(transactionManager, key.AdmRatingParametersId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRatingParametersId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admRatingParametersId)
		{
			return Delete(null, _admRatingParametersId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admRatingParametersId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(_admAdmissionBandId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParameters> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		fkAdmRatingParametersAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		fkAdmRatingParametersAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmAdmissionBandId(System.Decimal _admAdmissionBandId, int start, int pageLength,out int count)
		{
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND key.
		///		FK_ADM_RATING_PARAMETERS_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId">فئات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public abstract TList<AdmRatingParameters> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal _admAdmissionBandId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRatingParametersAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRatingParametersAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RATING_PARAMETERS_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRatingParameters objects.</returns>
		public abstract TList<AdmRatingParameters> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmRatingParameters Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParametersKey key, int start, int pageLength)
		{
			return GetByAdmRatingParametersId(transactionManager, key.AdmRatingParametersId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="_admRatingParametersId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(System.Decimal _admRatingParametersId)
		{
			int count = -1;
			return GetByAdmRatingParametersId(null,_admRatingParametersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="_admRatingParametersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(System.Decimal _admRatingParametersId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParametersId(null, _admRatingParametersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(TransactionManager transactionManager, System.Decimal _admRatingParametersId)
		{
			int count = -1;
			return GetByAdmRatingParametersId(transactionManager, _admRatingParametersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(TransactionManager transactionManager, System.Decimal _admRatingParametersId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRatingParametersId(transactionManager, _admRatingParametersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="_admRatingParametersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(System.Decimal _admRatingParametersId, int start, int pageLength, out int count)
		{
			return GetByAdmRatingParametersId(null, _admRatingParametersId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RATING_PARAMETERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRatingParametersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRatingParameters GetByAdmRatingParametersId(TransactionManager transactionManager, System.Decimal _admRatingParametersId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRatingParameters&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRatingParameters&gt;"/></returns>
		public static TList<AdmRatingParameters> Fill(IDataReader reader, TList<AdmRatingParameters> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRatingParameters c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRatingParameters")
					.Append("|").Append((System.Decimal)reader["ADM_RATING_PARAMETERS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRatingParameters>(
					key.ToString(), // EntityTrackingKey
					"AdmRatingParameters",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRatingParameters();
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
					c.AdmRatingParametersId = (System.Decimal)reader["ADM_RATING_PARAMETERS_ID"];
					c.OriginalAdmRatingParametersId = c.AdmRatingParametersId;
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.AdmAdmissionBandId = (System.Decimal)reader["ADM_ADMISSION_BAND_ID"];
					c.RequiredNumbers = Convert.IsDBNull(reader["REQUIRED_NUMBERS"]) ? null : (System.Decimal?)reader["REQUIRED_NUMBERS"];
					c.CurrentNumbers = Convert.IsDBNull(reader["CURRENT_NUMBERS"]) ? null : (System.Decimal?)reader["CURRENT_NUMBERS"];
					c.AcceptedNumbers = Convert.IsDBNull(reader["ACCEPTED_NUMBERS"]) ? null : (System.Decimal?)reader["ACCEPTED_NUMBERS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRatingParameters entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRatingParametersId = (System.Decimal)reader[((int)AdmRatingParametersColumn.AdmRatingParametersId - 1)];
			entity.OriginalAdmRatingParametersId = (System.Decimal)reader["ADM_RATING_PARAMETERS_ID"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmRatingParametersColumn.AdmOpenAcadSemesterId - 1)];
			entity.AdmAdmissionBandId = (System.Decimal)reader[((int)AdmRatingParametersColumn.AdmAdmissionBandId - 1)];
			entity.RequiredNumbers = (reader.IsDBNull(((int)AdmRatingParametersColumn.RequiredNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersColumn.RequiredNumbers - 1)];
			entity.CurrentNumbers = (reader.IsDBNull(((int)AdmRatingParametersColumn.CurrentNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersColumn.CurrentNumbers - 1)];
			entity.AcceptedNumbers = (reader.IsDBNull(((int)AdmRatingParametersColumn.AcceptedNumbers - 1)))?null:(System.Decimal?)reader[((int)AdmRatingParametersColumn.AcceptedNumbers - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRatingParameters entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRatingParametersId = (System.Decimal)dataRow["ADM_RATING_PARAMETERS_ID"];
			entity.OriginalAdmRatingParametersId = (System.Decimal)dataRow["ADM_RATING_PARAMETERS_ID"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.AdmAdmissionBandId = (System.Decimal)dataRow["ADM_ADMISSION_BAND_ID"];
			entity.RequiredNumbers = Convert.IsDBNull(dataRow["REQUIRED_NUMBERS"]) ? null : (System.Decimal?)dataRow["REQUIRED_NUMBERS"];
			entity.CurrentNumbers = Convert.IsDBNull(dataRow["CURRENT_NUMBERS"]) ? null : (System.Decimal?)dataRow["CURRENT_NUMBERS"];
			entity.AcceptedNumbers = Convert.IsDBNull(dataRow["ACCEPTED_NUMBERS"]) ? null : (System.Decimal?)dataRow["ACCEPTED_NUMBERS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRatingParameters"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParameters Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParameters entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAdmissionBandIdSource	
			if (CanDeepLoad(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepLoadType, innerList) 
				&& entity.AdmAdmissionBandIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAdmissionBandId;
				AdmAdmissionBand tmpEntity = EntityManager.LocateEntity<AdmAdmissionBand>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAdmissionBand), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAdmissionBandIdSource = tmpEntity;
				else
					entity.AdmAdmissionBandIdSource = DataRepository.AdmAdmissionBandProvider.GetByAdmAdmissionBandId(transactionManager, entity.AdmAdmissionBandId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAdmissionBandIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAdmissionBandIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAdmissionBandProvider.DeepLoad(transactionManager, entity.AdmAdmissionBandIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAdmissionBandIdSource

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmOpenAcadSemesterId;
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRatingParameters object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRatingParameters instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRatingParameters Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRatingParameters entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAdmissionBandIdSource
			if (CanDeepSave(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepSaveType, innerList) 
				&& entity.AdmAdmissionBandIdSource != null)
			{
				DataRepository.AdmAdmissionBandProvider.Save(transactionManager, entity.AdmAdmissionBandIdSource);
				entity.AdmAdmissionBandId = entity.AdmAdmissionBandIdSource.AdmAdmissionBandId;
			}
			#endregion 
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
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
	
	#region AdmRatingParametersChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRatingParameters</c>
	///</summary>
	public enum AdmRatingParametersChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAdmissionBand</c> at AdmAdmissionBandIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAdmissionBand))]
		AdmAdmissionBand,
			
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		}
	
	#endregion AdmRatingParametersChildEntityTypes
	
	#region AdmRatingParametersFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRatingParametersColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParameters"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParametersFilterBuilder : SqlFilterBuilder<AdmRatingParametersColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersFilterBuilder class.
		/// </summary>
		public AdmRatingParametersFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParametersFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParametersFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParametersFilterBuilder
	
	#region AdmRatingParametersParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRatingParametersColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParameters"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRatingParametersParameterBuilder : ParameterizedSqlFilterBuilder<AdmRatingParametersColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersParameterBuilder class.
		/// </summary>
		public AdmRatingParametersParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRatingParametersParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRatingParametersParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRatingParametersParameterBuilder
	
	#region AdmRatingParametersSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRatingParametersColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRatingParameters"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRatingParametersSortBuilder : SqlSortBuilder<AdmRatingParametersColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRatingParametersSqlSortBuilder class.
		/// </summary>
		public AdmRatingParametersSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRatingParametersSortBuilder
	
} // end namespace
