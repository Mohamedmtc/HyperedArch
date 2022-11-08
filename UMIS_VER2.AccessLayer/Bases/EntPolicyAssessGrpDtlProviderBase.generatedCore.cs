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
	/// This class is the base class for any <see cref="EntPolicyAssessGrpDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAssessGrpDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtlKey key)
		{
			return Delete(transactionManager, key.EntPolicyAssessGrpDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAssessGrpDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _entPolicyAssessGrpDtlId)
		{
			return Delete(null, _entPolicyAssessGrpDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(_edCodeCourseAssessId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		fkEntPolicyAssessGrpDtlEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		fkEntPolicyAssessGrpDtlEdCodeCourseAssess Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ED_CODE_COURSE_ASSESS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public abstract TList<EntPolicyAssessGrpDtl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(_entPolicyAssessGrpHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(transactionManager, _entPolicyAssessGrpHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpHdrId(transactionManager, _entPolicyAssessGrpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		fkEntPolicyAssessGrpDtlEntPolicyAssessGrpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyAssessGrpHdrId(null, _entPolicyAssessGrpHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		fkEntPolicyAssessGrpDtlEntPolicyAssessGrpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyAssessGrpHdrId(null, _entPolicyAssessGrpHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_DTL_ENT_POLICY_ASSESS_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl objects.</returns>
		public abstract TList<EntPolicyAssessGrpDtl> GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtlKey key, int start, int pageLength)
		{
			return GetByEntPolicyAssessGrpDtlId(transactionManager, key.EntPolicyAssessGrpDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(System.Int32 _entPolicyAssessGrpDtlId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpDtlId(null,_entPolicyAssessGrpDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(System.Int32 _entPolicyAssessGrpDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpDtlId(null, _entPolicyAssessGrpDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpDtlId)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpDtlId(transactionManager, _entPolicyAssessGrpDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessGrpDtlId(transactionManager, _entPolicyAssessGrpDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(System.Int32 _entPolicyAssessGrpDtlId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessGrpDtlId(null, _entPolicyAssessGrpDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl GetByEntPolicyAssessGrpDtlId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAssessGrpDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAssessGrpDtl&gt;"/></returns>
		public static TList<EntPolicyAssessGrpDtl> Fill(IDataReader reader, TList<EntPolicyAssessGrpDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAssessGrpDtl")
					.Append("|").Append((System.Int32)reader["ENT_POLICY_ASSESS_GRP_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAssessGrpDtl>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAssessGrpDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl();
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
					c.EntPolicyAssessGrpDtlId = (System.Int32)reader["ENT_POLICY_ASSESS_GRP_DTL_ID"];
					c.OriginalEntPolicyAssessGrpDtlId = c.EntPolicyAssessGrpDtlId;
					c.EntPolicyAssessGrpHdrId = (System.Int32)reader["ENT_POLICY_ASSESS_GRP_HDR_ID"];
					c.EdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAssessGrpDtlId = (System.Int32)reader[((int)EntPolicyAssessGrpDtlColumn.EntPolicyAssessGrpDtlId - 1)];
			entity.OriginalEntPolicyAssessGrpDtlId = (System.Int32)reader["ENT_POLICY_ASSESS_GRP_DTL_ID"];
			entity.EntPolicyAssessGrpHdrId = (System.Int32)reader[((int)EntPolicyAssessGrpDtlColumn.EntPolicyAssessGrpHdrId - 1)];
			entity.EdCodeCourseAssessId = (System.Decimal)reader[((int)EntPolicyAssessGrpDtlColumn.EdCodeCourseAssessId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAssessGrpDtlId = (System.Int32)dataRow["ENT_POLICY_ASSESS_GRP_DTL_ID"];
			entity.OriginalEntPolicyAssessGrpDtlId = (System.Int32)dataRow["ENT_POLICY_ASSESS_GRP_DTL_ID"];
			entity.EntPolicyAssessGrpHdrId = (System.Int32)dataRow["ENT_POLICY_ASSESS_GRP_HDR_ID"];
			entity.EdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseAssessId;
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

			#region EntPolicyAssessGrpHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessGrpHdr|EntPolicyAssessGrpHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessGrpHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyAssessGrpHdrId;
				EntPolicyAssessGrpHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessGrpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessGrpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessGrpHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessGrpHdrIdSource = DataRepository.EntPolicyAssessGrpHdrProvider.GetByEntPolicyAssessGrpHdrId(transactionManager, entity.EntPolicyAssessGrpHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessGrpHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessGrpHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessGrpHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessGrpHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessGrpHdrIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
			}
			#endregion 
			
			#region EntPolicyAssessGrpHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessGrpHdr|EntPolicyAssessGrpHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessGrpHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessGrpHdrProvider.Save(transactionManager, entity.EntPolicyAssessGrpHdrIdSource);
				entity.EntPolicyAssessGrpHdrId = entity.EntPolicyAssessGrpHdrIdSource.EntPolicyAssessGrpHdrId;
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
	
	#region EntPolicyAssessGrpDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAssessGrpDtl</c>
	///</summary>
	public enum EntPolicyAssessGrpDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessGrpHdr</c> at EntPolicyAssessGrpHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessGrpHdr))]
		EntPolicyAssessGrpHdr,
	}
	
	#endregion EntPolicyAssessGrpDtlChildEntityTypes
	
	#region EntPolicyAssessGrpDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAssessGrpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessGrpDtlFilterBuilder : SqlFilterBuilder<EntPolicyAssessGrpDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlFilterBuilder class.
		/// </summary>
		public EntPolicyAssessGrpDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessGrpDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessGrpDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessGrpDtlFilterBuilder
	
	#region EntPolicyAssessGrpDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAssessGrpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAssessGrpDtlParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAssessGrpDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlParameterBuilder class.
		/// </summary>
		public EntPolicyAssessGrpDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAssessGrpDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAssessGrpDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAssessGrpDtlParameterBuilder
	
	#region EntPolicyAssessGrpDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAssessGrpDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAssessGrpDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAssessGrpDtlSortBuilder : SqlSortBuilder<EntPolicyAssessGrpDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAssessGrpDtlSqlSortBuilder class.
		/// </summary>
		public EntPolicyAssessGrpDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAssessGrpDtlSortBuilder
	
} // end namespace
