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
	/// This class is the base class for any <see cref="ScTchngSlotAgendaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScTchngSlotAgendaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScTchngSlotAgenda, UMIS_VER2.BusinessLyer.ScTchngSlotAgendaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotAgendaKey key)
		{
			return Delete(transactionManager, key.ScTchngSlotAgendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scTchngSlotAgendId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scTchngSlotAgendId)
		{
			return Delete(null, _scTchngSlotAgendId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotAgendId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scTchngSlotAgendId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngSlotAgenda> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		fkScTchngSlotAgendaEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		fkScTchngSlotAgendaEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public abstract TList<ScTchngSlotAgenda> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		fkScTchngSlotAgendaEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		fkScTchngSlotAgendaEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER key.
		///		FK_SC_TCHNG_SLOT_AGENDA_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngSlotAgenda objects.</returns>
		public abstract TList<ScTchngSlotAgenda> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScTchngSlotAgenda Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotAgendaKey key, int start, int pageLength)
		{
			return GetByScTchngSlotAgendId(transactionManager, key.ScTchngSlotAgendId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public TList<ScTchngSlotAgenda> GetByScTchngSlotId(System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(null,_scTchngSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public TList<ScTchngSlotAgenda> GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public TList<ScTchngSlotAgenda> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public TList<ScTchngSlotAgenda> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public TList<ScTchngSlotAgenda> GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength, out int count)
		{
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_TCHNG_SLOT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;ScTchngSlotAgenda&gt;"/> class.</returns>
		public abstract TList<ScTchngSlotAgenda> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(System.Decimal _scTchngSlotAgendId)
		{
			int count = -1;
			return GetByScTchngSlotAgendId(null,_scTchngSlotAgendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(System.Decimal _scTchngSlotAgendId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotAgendId(null, _scTchngSlotAgendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(TransactionManager transactionManager, System.Decimal _scTchngSlotAgendId)
		{
			int count = -1;
			return GetByScTchngSlotAgendId(transactionManager, _scTchngSlotAgendId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(TransactionManager transactionManager, System.Decimal _scTchngSlotAgendId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotAgendId(transactionManager, _scTchngSlotAgendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(System.Decimal _scTchngSlotAgendId, int start, int pageLength, out int count)
		{
			return GetByScTchngSlotAgendId(null, _scTchngSlotAgendId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_SLOT_AGENDA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotAgendId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScTchngSlotAgenda GetByScTchngSlotAgendId(TransactionManager transactionManager, System.Decimal _scTchngSlotAgendId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScTchngSlotAgenda&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScTchngSlotAgenda&gt;"/></returns>
		public static TList<ScTchngSlotAgenda> Fill(IDataReader reader, TList<ScTchngSlotAgenda> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScTchngSlotAgenda c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScTchngSlotAgenda")
					.Append("|").Append((System.Decimal)reader["SC_TCHNG_SLOT_AGEND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScTchngSlotAgenda>(
					key.ToString(), // EntityTrackingKey
					"ScTchngSlotAgenda",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScTchngSlotAgenda();
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
					c.ScTchngSlotAgendId = (System.Decimal)reader["SC_TCHNG_SLOT_AGEND_ID"];
					c.OriginalScTchngSlotAgendId = c.ScTchngSlotAgendId;
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.ScTchngSlotId = (System.Decimal)reader["SC_TCHNG_SLOT_ID"];
					c.SlotInterval = Convert.IsDBNull(reader["SLOT_INTERVAL"]) ? null : (System.Decimal?)reader["SLOT_INTERVAL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScTchngSlotAgenda entity)
		{
			if (!reader.Read()) return;
			
			entity.ScTchngSlotAgendId = (System.Decimal)reader[((int)ScTchngSlotAgendaColumn.ScTchngSlotAgendId - 1)];
			entity.OriginalScTchngSlotAgendId = (System.Decimal)reader["SC_TCHNG_SLOT_AGEND_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)ScTchngSlotAgendaColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotAgendaColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)ScTchngSlotAgendaColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotAgendaColumn.EdCodeSemesterId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)ScTchngSlotAgendaColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)ScTchngSlotAgendaColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)ScTchngSlotAgendaColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)ScTchngSlotAgendaColumn.ToDate - 1)];
			entity.ScTchngSlotId = (System.Decimal)reader[((int)ScTchngSlotAgendaColumn.ScTchngSlotId - 1)];
			entity.SlotInterval = (reader.IsDBNull(((int)ScTchngSlotAgendaColumn.SlotInterval - 1)))?null:(System.Decimal?)reader[((int)ScTchngSlotAgendaColumn.SlotInterval - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScTchngSlotAgenda entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScTchngSlotAgendId = (System.Decimal)dataRow["SC_TCHNG_SLOT_AGEND_ID"];
			entity.OriginalScTchngSlotAgendId = (System.Decimal)dataRow["SC_TCHNG_SLOT_AGEND_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.ScTchngSlotId = (System.Decimal)dataRow["SC_TCHNG_SLOT_ID"];
			entity.SlotInterval = Convert.IsDBNull(dataRow["SLOT_INTERVAL"]) ? null : (System.Decimal?)dataRow["SLOT_INTERVAL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngSlotAgenda"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngSlotAgenda Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotAgenda entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

			#region ScTchngSlotIdSource	
			if (CanDeepLoad(entity, "ScTchngSlot|ScTchngSlotIdSource", deepLoadType, innerList) 
				&& entity.ScTchngSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScTchngSlotId;
				ScTchngSlot tmpEntity = EntityManager.LocateEntity<ScTchngSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngSlotIdSource = tmpEntity;
				else
					entity.ScTchngSlotIdSource = DataRepository.ScTchngSlotProvider.GetByScTchngSlotId(transactionManager, entity.ScTchngSlotId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngSlotProvider.DeepLoad(transactionManager, entity.ScTchngSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngSlotIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScTchngSlotAgenda object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScTchngSlotAgenda instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngSlotAgenda Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngSlotAgenda entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region ScTchngSlotIdSource
			if (CanDeepSave(entity, "ScTchngSlot|ScTchngSlotIdSource", deepSaveType, innerList) 
				&& entity.ScTchngSlotIdSource != null)
			{
				DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotIdSource);
				entity.ScTchngSlotId = entity.ScTchngSlotIdSource.ScTchngSlotId;
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
	
	#region ScTchngSlotAgendaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScTchngSlotAgenda</c>
	///</summary>
	public enum ScTchngSlotAgendaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
			
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
			
		///<summary>
		/// Composite Property for <c>ScTchngSlot</c> at ScTchngSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngSlot))]
		ScTchngSlot,
		}
	
	#endregion ScTchngSlotAgendaChildEntityTypes
	
	#region ScTchngSlotAgendaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScTchngSlotAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlotAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngSlotAgendaFilterBuilder : SqlFilterBuilder<ScTchngSlotAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaFilterBuilder class.
		/// </summary>
		public ScTchngSlotAgendaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngSlotAgendaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngSlotAgendaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngSlotAgendaFilterBuilder
	
	#region ScTchngSlotAgendaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScTchngSlotAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlotAgenda"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngSlotAgendaParameterBuilder : ParameterizedSqlFilterBuilder<ScTchngSlotAgendaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaParameterBuilder class.
		/// </summary>
		public ScTchngSlotAgendaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngSlotAgendaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngSlotAgendaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngSlotAgendaParameterBuilder
	
	#region ScTchngSlotAgendaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScTchngSlotAgendaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngSlotAgenda"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScTchngSlotAgendaSortBuilder : SqlSortBuilder<ScTchngSlotAgendaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngSlotAgendaSqlSortBuilder class.
		/// </summary>
		public ScTchngSlotAgendaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScTchngSlotAgendaSortBuilder
	
} // end namespace
