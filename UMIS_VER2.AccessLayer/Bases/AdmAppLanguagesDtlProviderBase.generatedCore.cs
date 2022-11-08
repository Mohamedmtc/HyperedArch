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
	/// This class is the base class for any <see cref="AdmAppLanguagesDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppLanguagesDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtlKey key)
		{
			return Delete(transactionManager, key.AdmAppLanguagesDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppLanguagesDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppLanguagesDtlId)
		{
			return Delete(null, _admAppLanguagesDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppLanguagesDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES Description: 
		/// </summary>
		/// <param name="_admAppLanguagesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(_admAppLanguagesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(transactionManager, _admAppLanguagesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(transactionManager, _admAppLanguagesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		fkAdmAppLanguagesDtlAdmAppLanguages Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppLanguagesId(null, _admAppLanguagesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		fkAdmAppLanguagesDtlAdmAppLanguages Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId, int start, int pageLength,out int count)
		{
			return GetByAdmAppLanguagesId(null, _admAppLanguagesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_APP_LANGUAGES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public abstract TList<AdmAppLanguagesDtl> GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY Description: 
		/// </summary>
		/// <param name="_admCodeMasteryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(_admCodeMasteryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(transactionManager, _admCodeMasteryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeMasteryId(transactionManager, _admCodeMasteryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		fkAdmAppLanguagesDtlAdmCodeMastery Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeMasteryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeMasteryId(null, _admCodeMasteryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		fkAdmAppLanguagesDtlAdmCodeMastery Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeMasteryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(System.Decimal _admCodeMasteryId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeMasteryId(null, _admCodeMasteryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_CODE_MASTERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeMasteryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public abstract TList<AdmAppLanguagesDtl> GetByAdmCodeMasteryId(TransactionManager transactionManager, System.Decimal _admCodeMasteryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE Description: 
		/// </summary>
		/// <param name="_admSkillTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(System.Decimal _admSkillTypeId)
		{
			int count = -1;
			return GetByAdmSkillTypeId(_admSkillTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId)
		{
			int count = -1;
			return GetByAdmSkillTypeId(transactionManager, _admSkillTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmSkillTypeId(transactionManager, _admSkillTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		fkAdmAppLanguagesDtlAdmSkillType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admSkillTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(System.Decimal _admSkillTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmSkillTypeId(null, _admSkillTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		fkAdmAppLanguagesDtlAdmSkillType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(System.Decimal _admSkillTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmSkillTypeId(null, _admSkillTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE key.
		///		FK_ADM_APP_LANGUAGES_DTL_ADM_SKILL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admSkillTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl objects.</returns>
		public abstract TList<AdmAppLanguagesDtl> GetByAdmSkillTypeId(TransactionManager transactionManager, System.Decimal _admSkillTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtlKey key, int start, int pageLength)
		{
			return GetByAdmAppLanguagesDtlId(transactionManager, key.AdmAppLanguagesDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(System.Decimal _admAppLanguagesDtlId)
		{
			int count = -1;
			return GetByAdmAppLanguagesDtlId(null,_admAppLanguagesDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(System.Decimal _admAppLanguagesDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppLanguagesDtlId(null, _admAppLanguagesDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(TransactionManager transactionManager, System.Decimal _admAppLanguagesDtlId)
		{
			int count = -1;
			return GetByAdmAppLanguagesDtlId(transactionManager, _admAppLanguagesDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(TransactionManager transactionManager, System.Decimal _admAppLanguagesDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppLanguagesDtlId(transactionManager, _admAppLanguagesDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(System.Decimal _admAppLanguagesDtlId, int start, int pageLength, out int count)
		{
			return GetByAdmAppLanguagesDtlId(null, _admAppLanguagesDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl GetByAdmAppLanguagesDtlId(TransactionManager transactionManager, System.Decimal _admAppLanguagesDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppLanguagesDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppLanguagesDtl&gt;"/></returns>
		public static TList<AdmAppLanguagesDtl> Fill(IDataReader reader, TList<AdmAppLanguagesDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppLanguagesDtl")
					.Append("|").Append((System.Decimal)reader["ADM_APP_LANGUAGES_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppLanguagesDtl>(
					key.ToString(), // EntityTrackingKey
					"AdmAppLanguagesDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl();
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
					c.AdmAppLanguagesDtlId = (System.Decimal)reader["ADM_APP_LANGUAGES_DTL_ID"];
					c.OriginalAdmAppLanguagesDtlId = c.AdmAppLanguagesDtlId;
					c.AdmCodeMasteryId = (System.Decimal)reader["ADM_CODE_MASTERY_ID"];
					c.AdmSkillTypeId = (System.Decimal)reader["ADM_SKILL_TYPE_ID"];
					c.AdmAppLanguagesId = (System.Decimal)reader["ADM_APP_LANGUAGES_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppLanguagesDtlId = (System.Decimal)reader[((int)AdmAppLanguagesDtlColumn.AdmAppLanguagesDtlId - 1)];
			entity.OriginalAdmAppLanguagesDtlId = (System.Decimal)reader["ADM_APP_LANGUAGES_DTL_ID"];
			entity.AdmCodeMasteryId = (System.Decimal)reader[((int)AdmAppLanguagesDtlColumn.AdmCodeMasteryId - 1)];
			entity.AdmSkillTypeId = (System.Decimal)reader[((int)AdmAppLanguagesDtlColumn.AdmSkillTypeId - 1)];
			entity.AdmAppLanguagesId = (System.Decimal)reader[((int)AdmAppLanguagesDtlColumn.AdmAppLanguagesId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppLanguagesDtlId = (System.Decimal)dataRow["ADM_APP_LANGUAGES_DTL_ID"];
			entity.OriginalAdmAppLanguagesDtlId = (System.Decimal)dataRow["ADM_APP_LANGUAGES_DTL_ID"];
			entity.AdmCodeMasteryId = (System.Decimal)dataRow["ADM_CODE_MASTERY_ID"];
			entity.AdmSkillTypeId = (System.Decimal)dataRow["ADM_SKILL_TYPE_ID"];
			entity.AdmAppLanguagesId = (System.Decimal)dataRow["ADM_APP_LANGUAGES_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppLanguagesIdSource	
			if (CanDeepLoad(entity, "AdmAppLanguages|AdmAppLanguagesIdSource", deepLoadType, innerList) 
				&& entity.AdmAppLanguagesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppLanguagesId;
				AdmAppLanguages tmpEntity = EntityManager.LocateEntity<AdmAppLanguages>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppLanguages), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppLanguagesIdSource = tmpEntity;
				else
					entity.AdmAppLanguagesIdSource = DataRepository.AdmAppLanguagesProvider.GetByAdmAppLanguagesId(transactionManager, entity.AdmAppLanguagesId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppLanguagesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppLanguagesProvider.DeepLoad(transactionManager, entity.AdmAppLanguagesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppLanguagesIdSource

			#region AdmCodeMasteryIdSource	
			if (CanDeepLoad(entity, "AdmCodeMastery|AdmCodeMasteryIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeMasteryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCodeMasteryId;
				AdmCodeMastery tmpEntity = EntityManager.LocateEntity<AdmCodeMastery>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeMastery), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeMasteryIdSource = tmpEntity;
				else
					entity.AdmCodeMasteryIdSource = DataRepository.AdmCodeMasteryProvider.GetByAdmCodeMasteryId(transactionManager, entity.AdmCodeMasteryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeMasteryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeMasteryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeMasteryProvider.DeepLoad(transactionManager, entity.AdmCodeMasteryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeMasteryIdSource

			#region AdmSkillTypeIdSource	
			if (CanDeepLoad(entity, "AdmSkillType|AdmSkillTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmSkillTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmSkillTypeId;
				AdmSkillType tmpEntity = EntityManager.LocateEntity<AdmSkillType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmSkillType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmSkillTypeIdSource = tmpEntity;
				else
					entity.AdmSkillTypeIdSource = DataRepository.AdmSkillTypeProvider.GetByAdmSkillTypeId(transactionManager, entity.AdmSkillTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmSkillTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmSkillTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmSkillTypeProvider.DeepLoad(transactionManager, entity.AdmSkillTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmSkillTypeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppLanguagesIdSource
			if (CanDeepSave(entity, "AdmAppLanguages|AdmAppLanguagesIdSource", deepSaveType, innerList) 
				&& entity.AdmAppLanguagesIdSource != null)
			{
				DataRepository.AdmAppLanguagesProvider.Save(transactionManager, entity.AdmAppLanguagesIdSource);
				entity.AdmAppLanguagesId = entity.AdmAppLanguagesIdSource.AdmAppLanguagesId;
			}
			#endregion 
			
			#region AdmCodeMasteryIdSource
			if (CanDeepSave(entity, "AdmCodeMastery|AdmCodeMasteryIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeMasteryIdSource != null)
			{
				DataRepository.AdmCodeMasteryProvider.Save(transactionManager, entity.AdmCodeMasteryIdSource);
				entity.AdmCodeMasteryId = entity.AdmCodeMasteryIdSource.AdmCodeMasteryId;
			}
			#endregion 
			
			#region AdmSkillTypeIdSource
			if (CanDeepSave(entity, "AdmSkillType|AdmSkillTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmSkillTypeIdSource != null)
			{
				DataRepository.AdmSkillTypeProvider.Save(transactionManager, entity.AdmSkillTypeIdSource);
				entity.AdmSkillTypeId = entity.AdmSkillTypeIdSource.AdmSkillTypeId;
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
	
	#region AdmAppLanguagesDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppLanguagesDtl</c>
	///</summary>
	public enum AdmAppLanguagesDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppLanguages</c> at AdmAppLanguagesIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppLanguages))]
		AdmAppLanguages,
		
		///<summary>
		/// Composite Property for <c>AdmCodeMastery</c> at AdmCodeMasteryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeMastery))]
		AdmCodeMastery,
		
		///<summary>
		/// Composite Property for <c>AdmSkillType</c> at AdmSkillTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmSkillType))]
		AdmSkillType,
	}
	
	#endregion AdmAppLanguagesDtlChildEntityTypes
	
	#region AdmAppLanguagesDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppLanguagesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguagesDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppLanguagesDtlFilterBuilder : SqlFilterBuilder<AdmAppLanguagesDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlFilterBuilder class.
		/// </summary>
		public AdmAppLanguagesDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppLanguagesDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppLanguagesDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppLanguagesDtlFilterBuilder
	
	#region AdmAppLanguagesDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppLanguagesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguagesDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppLanguagesDtlParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppLanguagesDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlParameterBuilder class.
		/// </summary>
		public AdmAppLanguagesDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppLanguagesDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppLanguagesDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppLanguagesDtlParameterBuilder
	
	#region AdmAppLanguagesDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppLanguagesDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguagesDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppLanguagesDtlSortBuilder : SqlSortBuilder<AdmAppLanguagesDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesDtlSqlSortBuilder class.
		/// </summary>
		public AdmAppLanguagesDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppLanguagesDtlSortBuilder
	
} // end namespace
