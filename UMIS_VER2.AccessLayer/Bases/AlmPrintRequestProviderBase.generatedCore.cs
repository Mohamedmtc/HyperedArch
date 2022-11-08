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
	/// This class is the base class for any <see cref="AlmPrintRequestProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AlmPrintRequestProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AlmPrintRequest, UMIS_VER2.BusinessLyer.AlmPrintRequestKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmPrintRequestKey key)
		{
			return Delete(transactionManager, key.AlmPrintRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_almPrintRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _almPrintRequestId)
		{
			return Delete(null, _almPrintRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almPrintRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _almPrintRequestId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		FK_ALM_PRINT_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		public TList<AlmPrintRequest> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		FK_ALM_PRINT_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		/// <remarks></remarks>
		public TList<AlmPrintRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		FK_ALM_PRINT_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		public TList<AlmPrintRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		fkAlmPrintRequestEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		public TList<AlmPrintRequest> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		fkAlmPrintRequestEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		public TList<AlmPrintRequest> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ALM_PRINT_REQUEST_ED_STUD key.
		///		FK_ALM_PRINT_REQUEST_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AlmPrintRequest objects.</returns>
		public abstract TList<AlmPrintRequest> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AlmPrintRequest Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmPrintRequestKey key, int start, int pageLength)
		{
			return GetByAlmPrintRequestId(transactionManager, key.AlmPrintRequestId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="_almPrintRequestId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(System.Decimal _almPrintRequestId)
		{
			int count = -1;
			return GetByAlmPrintRequestId(null,_almPrintRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="_almPrintRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(System.Decimal _almPrintRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetByAlmPrintRequestId(null, _almPrintRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almPrintRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(TransactionManager transactionManager, System.Decimal _almPrintRequestId)
		{
			int count = -1;
			return GetByAlmPrintRequestId(transactionManager, _almPrintRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almPrintRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(TransactionManager transactionManager, System.Decimal _almPrintRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetByAlmPrintRequestId(transactionManager, _almPrintRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="_almPrintRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(System.Decimal _almPrintRequestId, int start, int pageLength, out int count)
		{
			return GetByAlmPrintRequestId(null, _almPrintRequestId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ALM_PRINT_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_almPrintRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AlmPrintRequest GetByAlmPrintRequestId(TransactionManager transactionManager, System.Decimal _almPrintRequestId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AlmPrintRequest&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AlmPrintRequest&gt;"/></returns>
		public static TList<AlmPrintRequest> Fill(IDataReader reader, TList<AlmPrintRequest> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AlmPrintRequest c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AlmPrintRequest")
					.Append("|").Append((System.Decimal)reader["ALM_PRINT_REQUEST_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AlmPrintRequest>(
					key.ToString(), // EntityTrackingKey
					"AlmPrintRequest",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AlmPrintRequest();
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
					c.AlmPrintRequestId = (System.Decimal)reader["ALM_PRINT_REQUEST_ID"];
					c.OriginalAlmPrintRequestId = c.AlmPrintRequestId;
					c.RequestDate = Convert.IsDBNull(reader["REQUEST_DATE"]) ? null : (System.DateTime?)reader["REQUEST_DATE"];
					c.PrintDate = Convert.IsDBNull(reader["PRINT_DATE"]) ? null : (System.DateTime?)reader["PRINT_DATE"];
					c.RequiredCopiesNo = Convert.IsDBNull(reader["REQUIRED_COPIES_NO"]) ? null : (System.Int32?)reader["REQUIRED_COPIES_NO"];
					c.PrintedCopiesNo = Convert.IsDBNull(reader["PRINTED_COPIES_NO"]) ? null : (System.Int32?)reader["PRINTED_COPIES_NO"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.PrintTranscriptFlag = Convert.IsDBNull(reader["PRINT_TRANSCRIPT_FLAG"]) ? null : (System.Decimal?)reader["PRINT_TRANSCRIPT_FLAG"];
					c.PrintCertificateFlag = Convert.IsDBNull(reader["PRINT_CERTIFICATE_FLAG"]) ? null : (System.Decimal?)reader["PRINT_CERTIFICATE_FLAG"];
					c.CertificateTypeFlag = Convert.IsDBNull(reader["CERTIFICATE_TYPE_FLAG"]) ? null : (System.Decimal?)reader["CERTIFICATE_TYPE_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AlmPrintRequest entity)
		{
			if (!reader.Read()) return;
			
			entity.AlmPrintRequestId = (System.Decimal)reader[((int)AlmPrintRequestColumn.AlmPrintRequestId - 1)];
			entity.OriginalAlmPrintRequestId = (System.Decimal)reader["ALM_PRINT_REQUEST_ID"];
			entity.RequestDate = (reader.IsDBNull(((int)AlmPrintRequestColumn.RequestDate - 1)))?null:(System.DateTime?)reader[((int)AlmPrintRequestColumn.RequestDate - 1)];
			entity.PrintDate = (reader.IsDBNull(((int)AlmPrintRequestColumn.PrintDate - 1)))?null:(System.DateTime?)reader[((int)AlmPrintRequestColumn.PrintDate - 1)];
			entity.RequiredCopiesNo = (reader.IsDBNull(((int)AlmPrintRequestColumn.RequiredCopiesNo - 1)))?null:(System.Int32?)reader[((int)AlmPrintRequestColumn.RequiredCopiesNo - 1)];
			entity.PrintedCopiesNo = (reader.IsDBNull(((int)AlmPrintRequestColumn.PrintedCopiesNo - 1)))?null:(System.Int32?)reader[((int)AlmPrintRequestColumn.PrintedCopiesNo - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)AlmPrintRequestColumn.EdStudId - 1)];
			entity.PrintTranscriptFlag = (reader.IsDBNull(((int)AlmPrintRequestColumn.PrintTranscriptFlag - 1)))?null:(System.Decimal?)reader[((int)AlmPrintRequestColumn.PrintTranscriptFlag - 1)];
			entity.PrintCertificateFlag = (reader.IsDBNull(((int)AlmPrintRequestColumn.PrintCertificateFlag - 1)))?null:(System.Decimal?)reader[((int)AlmPrintRequestColumn.PrintCertificateFlag - 1)];
			entity.CertificateTypeFlag = (reader.IsDBNull(((int)AlmPrintRequestColumn.CertificateTypeFlag - 1)))?null:(System.Decimal?)reader[((int)AlmPrintRequestColumn.CertificateTypeFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AlmPrintRequest entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AlmPrintRequestId = (System.Decimal)dataRow["ALM_PRINT_REQUEST_ID"];
			entity.OriginalAlmPrintRequestId = (System.Decimal)dataRow["ALM_PRINT_REQUEST_ID"];
			entity.RequestDate = Convert.IsDBNull(dataRow["REQUEST_DATE"]) ? null : (System.DateTime?)dataRow["REQUEST_DATE"];
			entity.PrintDate = Convert.IsDBNull(dataRow["PRINT_DATE"]) ? null : (System.DateTime?)dataRow["PRINT_DATE"];
			entity.RequiredCopiesNo = Convert.IsDBNull(dataRow["REQUIRED_COPIES_NO"]) ? null : (System.Int32?)dataRow["REQUIRED_COPIES_NO"];
			entity.PrintedCopiesNo = Convert.IsDBNull(dataRow["PRINTED_COPIES_NO"]) ? null : (System.Int32?)dataRow["PRINTED_COPIES_NO"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.PrintTranscriptFlag = Convert.IsDBNull(dataRow["PRINT_TRANSCRIPT_FLAG"]) ? null : (System.Decimal?)dataRow["PRINT_TRANSCRIPT_FLAG"];
			entity.PrintCertificateFlag = Convert.IsDBNull(dataRow["PRINT_CERTIFICATE_FLAG"]) ? null : (System.Decimal?)dataRow["PRINT_CERTIFICATE_FLAG"];
			entity.CertificateTypeFlag = Convert.IsDBNull(dataRow["CERTIFICATE_TYPE_FLAG"]) ? null : (System.Decimal?)dataRow["CERTIFICATE_TYPE_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AlmPrintRequest"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AlmPrintRequest Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmPrintRequest entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AlmPrintRequest object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AlmPrintRequest instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AlmPrintRequest Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AlmPrintRequest entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
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
	
	#region AlmPrintRequestChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AlmPrintRequest</c>
	///</summary>
	public enum AlmPrintRequestChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion AlmPrintRequestChildEntityTypes
	
	#region AlmPrintRequestFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AlmPrintRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmPrintRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AlmPrintRequestFilterBuilder : SqlFilterBuilder<AlmPrintRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestFilterBuilder class.
		/// </summary>
		public AlmPrintRequestFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AlmPrintRequestFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AlmPrintRequestFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AlmPrintRequestFilterBuilder
	
	#region AlmPrintRequestParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AlmPrintRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmPrintRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AlmPrintRequestParameterBuilder : ParameterizedSqlFilterBuilder<AlmPrintRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestParameterBuilder class.
		/// </summary>
		public AlmPrintRequestParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AlmPrintRequestParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AlmPrintRequestParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AlmPrintRequestParameterBuilder
	
	#region AlmPrintRequestSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AlmPrintRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AlmPrintRequest"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AlmPrintRequestSortBuilder : SqlSortBuilder<AlmPrintRequestColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AlmPrintRequestSqlSortBuilder class.
		/// </summary>
		public AlmPrintRequestSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AlmPrintRequestSortBuilder
	
} // end namespace
