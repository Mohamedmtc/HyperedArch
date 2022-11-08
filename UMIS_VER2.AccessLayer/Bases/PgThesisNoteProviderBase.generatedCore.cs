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
	/// This class is the base class for any <see cref="PgThesisNoteProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisNoteProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisNote, UMIS_VER2.BusinessLyer.PgThesisNoteKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisNoteKey key)
		{
			return Delete(transactionManager, key.PgThesisNoteId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisNoteId)
		{
			return Delete(null, _pgThesisNoteId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisNoteId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		FK_PG_THESIS_NOTE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">newcss</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		FK_PG_THESIS_NOTE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">newcss</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisNote> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		FK_PG_THESIS_NOTE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">newcss</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		fkPgThesisNoteEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">newcss</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		fkPgThesisNoteEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">newcss</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_ED_STUD key.
		///		FK_PG_THESIS_NOTE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">newcss</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public abstract TList<PgThesisNote> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_NOTE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_NOTE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisNote> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_NOTE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		fkPgThesisNotePgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		fkPgThesisNotePgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_PG_THESIS_STUD key.
		///		FK_PG_THESIS_NOTE_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public abstract TList<PgThesisNote> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		FK_PG_THESIS_NOTE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId">newcss</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		FK_PG_THESIS_NOTE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">newcss</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisNote> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		FK_PG_THESIS_NOTE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">newcss</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		fkPgThesisNoteSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">newcss</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		fkPgThesisNoteSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">newcss</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public TList<PgThesisNote> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_NOTE_SA_STF_MEMBER key.
		///		FK_PG_THESIS_NOTE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">newcss</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisNote objects.</returns>
		public abstract TList<PgThesisNote> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisNote Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisNoteKey key, int start, int pageLength)
		{
			return GetByPgThesisNoteId(transactionManager, key.PgThesisNoteId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(System.Decimal _pgThesisNoteId)
		{
			int count = -1;
			return GetByPgThesisNoteId(null,_pgThesisNoteId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(System.Decimal _pgThesisNoteId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisNoteId(null, _pgThesisNoteId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(TransactionManager transactionManager, System.Decimal _pgThesisNoteId)
		{
			int count = -1;
			return GetByPgThesisNoteId(transactionManager, _pgThesisNoteId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(TransactionManager transactionManager, System.Decimal _pgThesisNoteId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisNoteId(transactionManager, _pgThesisNoteId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(System.Decimal _pgThesisNoteId, int start, int pageLength, out int count)
		{
			return GetByPgThesisNoteId(null, _pgThesisNoteId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_NOTE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisNoteId">متابعة الأبحاث العلمية للمشرفين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisNote GetByPgThesisNoteId(TransactionManager transactionManager, System.Decimal _pgThesisNoteId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisNote&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisNote&gt;"/></returns>
		public static TList<PgThesisNote> Fill(IDataReader reader, TList<PgThesisNote> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisNote c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisNote")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_NOTE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisNote>(
					key.ToString(), // EntityTrackingKey
					"PgThesisNote",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisNote();
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
					c.PgThesisNoteId = (System.Decimal)reader["PG_THESIS_NOTE_ID"];
					c.OriginalPgThesisNoteId = c.PgThesisNoteId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.TypeFlg = Convert.IsDBNull(reader["TYPE_FLG"]) ? null : (System.Int16?)reader["TYPE_FLG"];
					c.Comment = Convert.IsDBNull(reader["COMMENT"]) ? null : (System.String)reader["COMMENT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.NoteDate = Convert.IsDBNull(reader["NOTE_DATE"]) ? null : (System.DateTime?)reader["NOTE_DATE"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.ReadyDiscuss = Convert.IsDBNull(reader["READY_DISCUSS"]) ? null : (System.Boolean?)reader["READY_DISCUSS"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisNote entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisNoteId = (System.Decimal)reader[((int)PgThesisNoteColumn.PgThesisNoteId - 1)];
			entity.OriginalPgThesisNoteId = (System.Decimal)reader["PG_THESIS_NOTE_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisNoteColumn.PgThesisStudId - 1)];
			entity.TypeFlg = (reader.IsDBNull(((int)PgThesisNoteColumn.TypeFlg - 1)))?null:(System.Int16?)reader[((int)PgThesisNoteColumn.TypeFlg - 1)];
			entity.Comment = (reader.IsDBNull(((int)PgThesisNoteColumn.Comment - 1)))?null:(System.String)reader[((int)PgThesisNoteColumn.Comment - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisNoteColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisNoteColumn.Notes - 1)];
			entity.NoteDate = (reader.IsDBNull(((int)PgThesisNoteColumn.NoteDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisNoteColumn.NoteDate - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)PgThesisNoteColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisNoteColumn.SaStfMemberId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)PgThesisNoteColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)PgThesisNoteColumn.EdStudId - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)PgThesisNoteColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)PgThesisNoteColumn.AttchdDocPath - 1)];
			entity.ReadyDiscuss = (reader.IsDBNull(((int)PgThesisNoteColumn.ReadyDiscuss - 1)))?null:(System.Boolean?)reader[((int)PgThesisNoteColumn.ReadyDiscuss - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisNoteColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisNoteColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisNoteColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisNoteColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisNote entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisNoteId = (System.Decimal)dataRow["PG_THESIS_NOTE_ID"];
			entity.OriginalPgThesisNoteId = (System.Decimal)dataRow["PG_THESIS_NOTE_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.TypeFlg = Convert.IsDBNull(dataRow["TYPE_FLG"]) ? null : (System.Int16?)dataRow["TYPE_FLG"];
			entity.Comment = Convert.IsDBNull(dataRow["COMMENT"]) ? null : (System.String)dataRow["COMMENT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.NoteDate = Convert.IsDBNull(dataRow["NOTE_DATE"]) ? null : (System.DateTime?)dataRow["NOTE_DATE"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.ReadyDiscuss = Convert.IsDBNull(dataRow["READY_DISCUSS"]) ? null : (System.Boolean?)dataRow["READY_DISCUSS"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisNote"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisNote Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisNote entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisStudId;
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisNote object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisNote instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisNote Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisNote entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region PgThesisNoteChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisNote</c>
	///</summary>
	public enum PgThesisNoteChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion PgThesisNoteChildEntityTypes
	
	#region PgThesisNoteFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisNoteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisNote"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisNoteFilterBuilder : SqlFilterBuilder<PgThesisNoteColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteFilterBuilder class.
		/// </summary>
		public PgThesisNoteFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisNoteFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisNoteFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisNoteFilterBuilder
	
	#region PgThesisNoteParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisNoteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisNote"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisNoteParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisNoteColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteParameterBuilder class.
		/// </summary>
		public PgThesisNoteParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisNoteParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisNoteParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisNoteParameterBuilder
	
	#region PgThesisNoteSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisNoteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisNote"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisNoteSortBuilder : SqlSortBuilder<PgThesisNoteColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisNoteSqlSortBuilder class.
		/// </summary>
		public PgThesisNoteSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisNoteSortBuilder
	
} // end namespace
