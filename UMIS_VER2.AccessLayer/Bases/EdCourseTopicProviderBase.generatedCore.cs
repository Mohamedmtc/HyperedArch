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
	/// This class is the base class for any <see cref="EdCourseTopicProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseTopicProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseTopic, UMIS_VER2.BusinessLyer.EdCourseTopicKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseTopicKey key)
		{
			return Delete(transactionManager, key.EdCourseTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseTopicId)
		{
			return Delete(null, _edCourseTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseTopicId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_TOPIC_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_TOPIC_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseTopic> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_TOPIC_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		fkEdCourseTopicAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		fkEdCourseTopicAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_TOPIC_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public abstract TList<EdCourseTopic> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		FK_ED_COURSE_TOPIC_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		FK_ED_COURSE_TOPIC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseTopic> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		FK_ED_COURSE_TOPIC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		fkEdCourseTopicEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		fkEdCourseTopicEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ED_COURSE key.
		///		FK_ED_COURSE_TOPIC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public abstract TList<EdCourseTopic> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		FK_ED_COURSE_TOPIC_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">القسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		FK_ED_COURSE_TOPIC_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">القسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseTopic> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		FK_ED_COURSE_TOPIC_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">القسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		fkEdCourseTopicEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">القسم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		fkEdCourseTopicEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">القسم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public TList<EdCourseTopic> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_TOPIC_ENTITY_MAIN key.
		///		FK_ED_COURSE_TOPIC_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">القسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseTopic objects.</returns>
		public abstract TList<EdCourseTopic> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseTopic Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseTopicKey key, int start, int pageLength)
		{
			return GetByEdCourseTopicId(transactionManager, key.EdCourseTopicId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(System.Decimal _edCourseTopicId)
		{
			int count = -1;
			return GetByEdCourseTopicId(null,_edCourseTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(System.Decimal _edCourseTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseTopicId(null, _edCourseTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal _edCourseTopicId)
		{
			int count = -1;
			return GetByEdCourseTopicId(transactionManager, _edCourseTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal _edCourseTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseTopicId(transactionManager, _edCourseTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(System.Decimal _edCourseTopicId, int start, int pageLength, out int count)
		{
			return GetByEdCourseTopicId(null, _edCourseTopicId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseTopic GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal _edCourseTopicId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseTopic&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseTopic&gt;"/></returns>
		public static TList<EdCourseTopic> Fill(IDataReader reader, TList<EdCourseTopic> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseTopic c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseTopic")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_TOPIC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseTopic>(
					key.ToString(), // EntityTrackingKey
					"EdCourseTopic",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseTopic();
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
					c.EdCourseTopicId = (System.Decimal)reader["ED_COURSE_TOPIC_ID"];
					c.OriginalEdCourseTopicId = c.EdCourseTopicId;
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.TopicAr = (System.String)reader["TOPIC_AR"];
					c.TopicEn = (System.String)reader["TOPIC_EN"];
					c.TopicOrder = Convert.IsDBNull(reader["TOPIC_ORDER"]) ? null : (System.Int32?)reader["TOPIC_ORDER"];
					c.OptionalFlg = (System.Boolean)reader["OPTIONAL_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.TopicContentAr = Convert.IsDBNull(reader["TOPIC_CONTENT_AR"]) ? null : (System.String)reader["TOPIC_CONTENT_AR"];
					c.TopicContentEn = Convert.IsDBNull(reader["TOPIC_CONTENT_EN"]) ? null : (System.String)reader["TOPIC_CONTENT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseTopic entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseTopicId = (System.Decimal)reader[((int)EdCourseTopicColumn.EdCourseTopicId - 1)];
			entity.OriginalEdCourseTopicId = (System.Decimal)reader["ED_COURSE_TOPIC_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseTopicColumn.EdCourseId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCourseTopicColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCourseTopicColumn.AsFacultyInfoId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EdCourseTopicColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EdCourseTopicColumn.EntMainId - 1)];
			entity.TopicAr = (System.String)reader[((int)EdCourseTopicColumn.TopicAr - 1)];
			entity.TopicEn = (System.String)reader[((int)EdCourseTopicColumn.TopicEn - 1)];
			entity.TopicOrder = (reader.IsDBNull(((int)EdCourseTopicColumn.TopicOrder - 1)))?null:(System.Int32?)reader[((int)EdCourseTopicColumn.TopicOrder - 1)];
			entity.OptionalFlg = (System.Boolean)reader[((int)EdCourseTopicColumn.OptionalFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdCourseTopicColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdCourseTopicColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdCourseTopicColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdCourseTopicColumn.LastDate - 1)];
			entity.TopicContentAr = (reader.IsDBNull(((int)EdCourseTopicColumn.TopicContentAr - 1)))?null:(System.String)reader[((int)EdCourseTopicColumn.TopicContentAr - 1)];
			entity.TopicContentEn = (reader.IsDBNull(((int)EdCourseTopicColumn.TopicContentEn - 1)))?null:(System.String)reader[((int)EdCourseTopicColumn.TopicContentEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseTopic entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseTopicId = (System.Decimal)dataRow["ED_COURSE_TOPIC_ID"];
			entity.OriginalEdCourseTopicId = (System.Decimal)dataRow["ED_COURSE_TOPIC_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.TopicAr = (System.String)dataRow["TOPIC_AR"];
			entity.TopicEn = (System.String)dataRow["TOPIC_EN"];
			entity.TopicOrder = Convert.IsDBNull(dataRow["TOPIC_ORDER"]) ? null : (System.Int32?)dataRow["TOPIC_ORDER"];
			entity.OptionalFlg = (System.Boolean)dataRow["OPTIONAL_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.TopicContentAr = Convert.IsDBNull(dataRow["TOPIC_CONTENT_AR"]) ? null : (System.String)dataRow["TOPIC_CONTENT_AR"];
			entity.TopicContentEn = Convert.IsDBNull(dataRow["TOPIC_CONTENT_EN"]) ? null : (System.String)dataRow["TOPIC_CONTENT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseTopic"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseTopic Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseTopic entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCourseTopicId methods when available
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByEdCourseTopicId(transactionManager, entity.EdCourseTopicId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTopicTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTopicTchng>|EdTopicTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTopicTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTopicTchngCollection = DataRepository.EdTopicTchngProvider.GetByEdCourseTopicId(transactionManager, entity.EdCourseTopicId);

				if (deep && entity.EdTopicTchngCollection.Count > 0)
				{
					deepHandles.Add("EdTopicTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTopicTchng>) DataRepository.EdTopicTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTopicTchngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseTopic object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseTopic instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseTopic Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseTopic entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.EdCourseTopicIdSource != null)
						{
							child.EdCourseTopicId = child.EdCourseTopicIdSource.EdCourseTopicId;
						}
						else
						{
							child.EdCourseTopicId = entity.EdCourseTopicId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTopicTchng>
				if (CanDeepSave(entity.EdTopicTchngCollection, "List<EdTopicTchng>|EdTopicTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTopicTchng child in entity.EdTopicTchngCollection)
					{
						if(child.EdCourseTopicIdSource != null)
						{
							child.EdCourseTopicId = child.EdCourseTopicIdSource.EdCourseTopicId;
						}
						else
						{
							child.EdCourseTopicId = entity.EdCourseTopicId;
						}

					}

					if (entity.EdTopicTchngCollection.Count > 0 || entity.EdTopicTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTopicTchngProvider.Save(transactionManager, entity.EdTopicTchngCollection);
						
						deepHandles.Add("EdTopicTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTopicTchng >) DataRepository.EdTopicTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdTopicTchngCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCourseTopicChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseTopic</c>
	///</summary>
	public enum EdCourseTopicChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EdCourseTopic</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>EdCourseTopic</c> as OneToMany for EdTopicTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTopicTchng>))]
		EdTopicTchngCollection,
	}
	
	#endregion EdCourseTopicChildEntityTypes
	
	#region EdCourseTopicFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseTopicFilterBuilder : SqlFilterBuilder<EdCourseTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicFilterBuilder class.
		/// </summary>
		public EdCourseTopicFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseTopicFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseTopicFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseTopicFilterBuilder
	
	#region EdCourseTopicParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseTopicParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicParameterBuilder class.
		/// </summary>
		public EdCourseTopicParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseTopicParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseTopicParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseTopicParameterBuilder
	
	#region EdCourseTopicSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseTopic"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseTopicSortBuilder : SqlSortBuilder<EdCourseTopicColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseTopicSqlSortBuilder class.
		/// </summary>
		public EdCourseTopicSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseTopicSortBuilder
	
} // end namespace
