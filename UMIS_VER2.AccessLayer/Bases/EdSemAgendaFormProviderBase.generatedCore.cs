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
	/// This class is the base class for any <see cref="EdSemAgendaFormProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemAgendaFormProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdSemAgendaForm, UMIS_VER2.BusinessLyer.EdSemAgendaFormKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaFormKey key)
		{
			return Delete(transactionManager, key.EdSemAgendaFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edSemAgendaFormId">XXXUOB. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edSemAgendaFormId)
		{
			return Delete(null, _edSemAgendaFormId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaFormId">XXXUOB. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edSemAgendaFormId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="_edSemesterAgendaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(_edSemesterAgendaId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaForm> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemesterAgendaId(transactionManager, _edSemesterAgendaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		fkEdSemAgendaFormEdSemesterAgenda Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		fkEdSemAgendaFormEdSemesterAgenda Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetByEdSemesterAgendaId(System.Decimal _edSemesterAgendaId, int start, int pageLength,out int count)
		{
			return GetByEdSemesterAgendaId(null, _edSemesterAgendaId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA key.
		///		FK_ED_SEM_AGENDA_FORM_ED_SEMESTER_AGENDA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemesterAgendaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public abstract TList<EdSemAgendaForm> GetByEdSemesterAgendaId(TransactionManager transactionManager, System.Decimal _edSemesterAgendaId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		FK_ED_SEM_AGENDA_FORM_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		FK_ED_SEM_AGENDA_FORM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		/// <remarks></remarks>
		public TList<EdSemAgendaForm> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		FK_ED_SEM_AGENDA_FORM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		fkEdSemAgendaFormSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		fkEdSemAgendaFormSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public TList<EdSemAgendaForm> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SEM_AGENDA_FORM_SE_FORM key.
		///		FK_ED_SEM_AGENDA_FORM_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdSemAgendaForm objects.</returns>
		public abstract TList<EdSemAgendaForm> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdSemAgendaForm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaFormKey key, int start, int pageLength)
		{
			return GetByEdSemAgendaFormId(transactionManager, key.EdSemAgendaFormId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(System.Decimal _edSemAgendaFormId)
		{
			int count = -1;
			return GetByEdSemAgendaFormId(null,_edSemAgendaFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(System.Decimal _edSemAgendaFormId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaFormId(null, _edSemAgendaFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(TransactionManager transactionManager, System.Decimal _edSemAgendaFormId)
		{
			int count = -1;
			return GetByEdSemAgendaFormId(transactionManager, _edSemAgendaFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(TransactionManager transactionManager, System.Decimal _edSemAgendaFormId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdSemAgendaFormId(transactionManager, _edSemAgendaFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(System.Decimal _edSemAgendaFormId, int start, int pageLength, out int count)
		{
			return GetByEdSemAgendaFormId(null, _edSemAgendaFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SEM_AGENDA_FORM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edSemAgendaFormId">XXXUOB</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdSemAgendaForm GetByEdSemAgendaFormId(TransactionManager transactionManager, System.Decimal _edSemAgendaFormId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdSemAgendaForm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdSemAgendaForm&gt;"/></returns>
		public static TList<EdSemAgendaForm> Fill(IDataReader reader, TList<EdSemAgendaForm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdSemAgendaForm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdSemAgendaForm")
					.Append("|").Append((System.Decimal)reader["ED_SEM_AGENDA_FORM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdSemAgendaForm>(
					key.ToString(), // EntityTrackingKey
					"EdSemAgendaForm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdSemAgendaForm();
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
					c.EdSemAgendaFormId = (System.Decimal)reader["ED_SEM_AGENDA_FORM_ID"];
					c.OriginalEdSemAgendaFormId = c.EdSemAgendaFormId;
					c.EdSemesterAgendaId = (System.Decimal)reader["ED_SEMESTER_AGENDA_ID"];
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
					c.ViewFlg = (System.Decimal)reader["VIEW_FLG"];
					c.StudFlg = Convert.IsDBNull(reader["STUD_FLG"]) ? null : (System.Decimal?)reader["STUD_FLG"];
					c.StaffFlg = Convert.IsDBNull(reader["STAFF_FLG"]) ? null : (System.Decimal?)reader["STAFF_FLG"];
					c.HodFlg = Convert.IsDBNull(reader["HOD_FLG"]) ? null : (System.Decimal?)reader["HOD_FLG"];
					c.RegadminFlg = Convert.IsDBNull(reader["REGADMIN_FLG"]) ? null : (System.Decimal?)reader["REGADMIN_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdSemAgendaForm entity)
		{
			if (!reader.Read()) return;
			
			entity.EdSemAgendaFormId = (System.Decimal)reader[((int)EdSemAgendaFormColumn.EdSemAgendaFormId - 1)];
			entity.OriginalEdSemAgendaFormId = (System.Decimal)reader["ED_SEM_AGENDA_FORM_ID"];
			entity.EdSemesterAgendaId = (System.Decimal)reader[((int)EdSemAgendaFormColumn.EdSemesterAgendaId - 1)];
			entity.SeFormId = (System.Decimal)reader[((int)EdSemAgendaFormColumn.SeFormId - 1)];
			entity.ViewFlg = (System.Decimal)reader[((int)EdSemAgendaFormColumn.ViewFlg - 1)];
			entity.StudFlg = (reader.IsDBNull(((int)EdSemAgendaFormColumn.StudFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaFormColumn.StudFlg - 1)];
			entity.StaffFlg = (reader.IsDBNull(((int)EdSemAgendaFormColumn.StaffFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaFormColumn.StaffFlg - 1)];
			entity.HodFlg = (reader.IsDBNull(((int)EdSemAgendaFormColumn.HodFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaFormColumn.HodFlg - 1)];
			entity.RegadminFlg = (reader.IsDBNull(((int)EdSemAgendaFormColumn.RegadminFlg - 1)))?null:(System.Decimal?)reader[((int)EdSemAgendaFormColumn.RegadminFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdSemAgendaForm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdSemAgendaFormId = (System.Decimal)dataRow["ED_SEM_AGENDA_FORM_ID"];
			entity.OriginalEdSemAgendaFormId = (System.Decimal)dataRow["ED_SEM_AGENDA_FORM_ID"];
			entity.EdSemesterAgendaId = (System.Decimal)dataRow["ED_SEMESTER_AGENDA_ID"];
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.ViewFlg = (System.Decimal)dataRow["VIEW_FLG"];
			entity.StudFlg = Convert.IsDBNull(dataRow["STUD_FLG"]) ? null : (System.Decimal?)dataRow["STUD_FLG"];
			entity.StaffFlg = Convert.IsDBNull(dataRow["STAFF_FLG"]) ? null : (System.Decimal?)dataRow["STAFF_FLG"];
			entity.HodFlg = Convert.IsDBNull(dataRow["HOD_FLG"]) ? null : (System.Decimal?)dataRow["HOD_FLG"];
			entity.RegadminFlg = Convert.IsDBNull(dataRow["REGADMIN_FLG"]) ? null : (System.Decimal?)dataRow["REGADMIN_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdSemAgendaForm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaForm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaForm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdSemesterAgendaIdSource	
			if (CanDeepLoad(entity, "EdSemesterAgenda|EdSemesterAgendaIdSource", deepLoadType, innerList) 
				&& entity.EdSemesterAgendaIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdSemesterAgendaId;
				EdSemesterAgenda tmpEntity = EntityManager.LocateEntity<EdSemesterAgenda>(EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterAgenda), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdSemesterAgendaIdSource = tmpEntity;
				else
					entity.EdSemesterAgendaIdSource = DataRepository.EdSemesterAgendaProvider.GetByEdSemesterAgendaId(transactionManager, entity.EdSemesterAgendaId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdSemesterAgendaIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdSemesterAgendaProvider.DeepLoad(transactionManager, entity.EdSemesterAgendaIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdSemesterAgendaIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormId;
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdSemAgendaForm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdSemAgendaForm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdSemAgendaForm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemAgendaForm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdSemesterAgendaIdSource
			if (CanDeepSave(entity, "EdSemesterAgenda|EdSemesterAgendaIdSource", deepSaveType, innerList) 
				&& entity.EdSemesterAgendaIdSource != null)
			{
				DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaIdSource);
				entity.EdSemesterAgendaId = entity.EdSemesterAgendaIdSource.EdSemesterAgendaId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
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
	
	#region EdSemAgendaFormChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdSemAgendaForm</c>
	///</summary>
	public enum EdSemAgendaFormChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdSemesterAgenda</c> at EdSemesterAgendaIdSource
		///</summary>
		[ChildEntityType(typeof(EdSemesterAgenda))]
		EdSemesterAgenda,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
	}
	
	#endregion EdSemAgendaFormChildEntityTypes
	
	#region EdSemAgendaFormFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdSemAgendaFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaFormFilterBuilder : SqlFilterBuilder<EdSemAgendaFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormFilterBuilder class.
		/// </summary>
		public EdSemAgendaFormFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaFormFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaFormFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaFormFilterBuilder
	
	#region EdSemAgendaFormParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdSemAgendaFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdSemAgendaFormParameterBuilder : ParameterizedSqlFilterBuilder<EdSemAgendaFormColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormParameterBuilder class.
		/// </summary>
		public EdSemAgendaFormParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdSemAgendaFormParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdSemAgendaFormParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdSemAgendaFormParameterBuilder
	
	#region EdSemAgendaFormSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdSemAgendaFormColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdSemAgendaForm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdSemAgendaFormSortBuilder : SqlSortBuilder<EdSemAgendaFormColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdSemAgendaFormSqlSortBuilder class.
		/// </summary>
		public EdSemAgendaFormSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdSemAgendaFormSortBuilder
	
} // end namespace
