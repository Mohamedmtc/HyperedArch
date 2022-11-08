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
	/// This class is the base class for any <see cref="PgThesisStudTopicProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisStudTopicProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisStudTopic, UMIS_VER2.BusinessLyer.PgThesisStudTopicKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudTopicKey key)
		{
			return Delete(transactionManager, key.PgThesisStudTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisStudTopicId)
		{
			return Delete(null, _pgThesisStudTopicId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisStudTopicId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE Description: 
		/// </summary>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(System.Int32? _pgCodeChangeTypeId)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(_pgCodeChangeTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32? _pgCodeChangeTypeId)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(transactionManager, _pgCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32? _pgCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeChangeTypeId(transactionManager, _pgCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		fkPgThesisStudTopicPgCodeChangeType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(System.Int32? _pgCodeChangeTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCodeChangeTypeId(null, _pgCodeChangeTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		fkPgThesisStudTopicPgCodeChangeType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(System.Int32? _pgCodeChangeTypeId, int start, int pageLength,out int count)
		{
			return GetByPgCodeChangeTypeId(null, _pgCodeChangeTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_CODE_CHANGE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeChangeTypeId">سبب التعديل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public abstract TList<PgThesisStudTopic> GetByPgCodeChangeTypeId(TransactionManager transactionManager, System.Int32? _pgCodeChangeTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(_pgOfferingTopicId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgOfferingTopicId(transactionManager, _pgOfferingTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		fkPgThesisStudTopicPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		fkPgThesisStudTopicPgOfferingTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgOfferingTopicId(System.Int32 _pgOfferingTopicId, int start, int pageLength,out int count)
		{
			return GetByPgOfferingTopicId(null, _pgOfferingTopicId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_OFFERING_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgOfferingTopicId">مجال البحث- مواضيع البحث المطروحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public abstract TList<PgThesisStudTopic> GetByPgOfferingTopicId(TransactionManager transactionManager, System.Int32 _pgOfferingTopicId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudTopic> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		fkPgThesisStudTopicPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		fkPgThesisStudTopicPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public TList<PgThesisStudTopic> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_TOPIC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudTopic objects.</returns>
		public abstract TList<PgThesisStudTopic> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisStudTopic Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudTopicKey key, int start, int pageLength)
		{
			return GetByPgThesisStudTopicId(transactionManager, key.PgThesisStudTopicId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(System.Decimal _pgThesisStudTopicId)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(null,_pgThesisStudTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(System.Decimal _pgThesisStudTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(null, _pgThesisStudTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal _pgThesisStudTopicId)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(transactionManager, _pgThesisStudTopicId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal _pgThesisStudTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudTopicId(transactionManager, _pgThesisStudTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(System.Decimal _pgThesisStudTopicId, int start, int pageLength, out int count)
		{
			return GetByPgThesisStudTopicId(null, _pgThesisStudTopicId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_TOPIC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudTopicId">عنوان ومجال  البحث</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStudTopic GetByPgThesisStudTopicId(TransactionManager transactionManager, System.Decimal _pgThesisStudTopicId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisStudTopic&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisStudTopic&gt;"/></returns>
		public static TList<PgThesisStudTopic> Fill(IDataReader reader, TList<PgThesisStudTopic> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisStudTopic c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisStudTopic")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_STUD_TOPIC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisStudTopic>(
					key.ToString(), // EntityTrackingKey
					"PgThesisStudTopic",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisStudTopic();
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
					c.PgThesisStudTopicId = (System.Decimal)reader["PG_THESIS_STUD_TOPIC_ID"];
					c.OriginalPgThesisStudTopicId = c.PgThesisStudTopicId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.TitleAr = (System.String)reader["TITLE_AR"];
					c.TitleEn = (System.String)reader["TITLE_EN"];
					c.TopicAr = Convert.IsDBNull(reader["TOPIC_AR"]) ? null : (System.String)reader["TOPIC_AR"];
					c.TopicEn = Convert.IsDBNull(reader["TOPIC_EN"]) ? null : (System.String)reader["TOPIC_EN"];
					c.PgOfferingTopicId = (System.Int32)reader["PG_OFFERING_TOPIC_ID"];
					c.PgCodeChangeTypeId = Convert.IsDBNull(reader["PG_CODE_CHANGE_TYPE_ID"]) ? null : (System.Int32?)reader["PG_CODE_CHANGE_TYPE_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsLast = (System.Boolean)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisStudTopic entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisStudTopicId = (System.Decimal)reader[((int)PgThesisStudTopicColumn.PgThesisStudTopicId - 1)];
			entity.OriginalPgThesisStudTopicId = (System.Decimal)reader["PG_THESIS_STUD_TOPIC_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisStudTopicColumn.PgThesisStudId - 1)];
			entity.TitleAr = (System.String)reader[((int)PgThesisStudTopicColumn.TitleAr - 1)];
			entity.TitleEn = (System.String)reader[((int)PgThesisStudTopicColumn.TitleEn - 1)];
			entity.TopicAr = (reader.IsDBNull(((int)PgThesisStudTopicColumn.TopicAr - 1)))?null:(System.String)reader[((int)PgThesisStudTopicColumn.TopicAr - 1)];
			entity.TopicEn = (reader.IsDBNull(((int)PgThesisStudTopicColumn.TopicEn - 1)))?null:(System.String)reader[((int)PgThesisStudTopicColumn.TopicEn - 1)];
			entity.PgOfferingTopicId = (System.Int32)reader[((int)PgThesisStudTopicColumn.PgOfferingTopicId - 1)];
			entity.PgCodeChangeTypeId = (reader.IsDBNull(((int)PgThesisStudTopicColumn.PgCodeChangeTypeId - 1)))?null:(System.Int32?)reader[((int)PgThesisStudTopicColumn.PgCodeChangeTypeId - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisStudTopicColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisStudTopicColumn.Notes - 1)];
			entity.IsLast = (System.Boolean)reader[((int)PgThesisStudTopicColumn.IsLast - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisStudTopicColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudTopicColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisStudTopicColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudTopicColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisStudTopic entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisStudTopicId = (System.Decimal)dataRow["PG_THESIS_STUD_TOPIC_ID"];
			entity.OriginalPgThesisStudTopicId = (System.Decimal)dataRow["PG_THESIS_STUD_TOPIC_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.TitleAr = (System.String)dataRow["TITLE_AR"];
			entity.TitleEn = (System.String)dataRow["TITLE_EN"];
			entity.TopicAr = Convert.IsDBNull(dataRow["TOPIC_AR"]) ? null : (System.String)dataRow["TOPIC_AR"];
			entity.TopicEn = Convert.IsDBNull(dataRow["TOPIC_EN"]) ? null : (System.String)dataRow["TOPIC_EN"];
			entity.PgOfferingTopicId = (System.Int32)dataRow["PG_OFFERING_TOPIC_ID"];
			entity.PgCodeChangeTypeId = Convert.IsDBNull(dataRow["PG_CODE_CHANGE_TYPE_ID"]) ? null : (System.Int32?)dataRow["PG_CODE_CHANGE_TYPE_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsLast = (System.Boolean)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudTopic"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudTopic Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudTopic entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCodeChangeTypeIdSource	
			if (CanDeepLoad(entity, "PgCodeChangeType|PgCodeChangeTypeIdSource", deepLoadType, innerList) 
				&& entity.PgCodeChangeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgCodeChangeTypeId ?? (int)0);
				PgCodeChangeType tmpEntity = EntityManager.LocateEntity<PgCodeChangeType>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCodeChangeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCodeChangeTypeIdSource = tmpEntity;
				else
					entity.PgCodeChangeTypeIdSource = DataRepository.PgCodeChangeTypeProvider.GetByPgCodeChangeTypeId(transactionManager, (entity.PgCodeChangeTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCodeChangeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCodeChangeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCodeChangeTypeProvider.DeepLoad(transactionManager, entity.PgCodeChangeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCodeChangeTypeIdSource

			#region PgOfferingTopicIdSource	
			if (CanDeepLoad(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepLoadType, innerList) 
				&& entity.PgOfferingTopicIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgOfferingTopicId;
				PgOfferingTopic tmpEntity = EntityManager.LocateEntity<PgOfferingTopic>(EntityLocator.ConstructKeyFromPkItems(typeof(PgOfferingTopic), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgOfferingTopicIdSource = tmpEntity;
				else
					entity.PgOfferingTopicIdSource = DataRepository.PgOfferingTopicProvider.GetByPgOfferingTopicId(transactionManager, entity.PgOfferingTopicId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingTopicIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgOfferingTopicIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgOfferingTopicProvider.DeepLoad(transactionManager, entity.PgOfferingTopicIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgOfferingTopicIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisStudTopicId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisStudTopicId(transactionManager, entity.PgThesisStudTopicId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisStudTopic object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisStudTopic instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudTopic Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudTopic entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCodeChangeTypeIdSource
			if (CanDeepSave(entity, "PgCodeChangeType|PgCodeChangeTypeIdSource", deepSaveType, innerList) 
				&& entity.PgCodeChangeTypeIdSource != null)
			{
				DataRepository.PgCodeChangeTypeProvider.Save(transactionManager, entity.PgCodeChangeTypeIdSource);
				entity.PgCodeChangeTypeId = entity.PgCodeChangeTypeIdSource.PgCodeChangeTypeId;
			}
			#endregion 
			
			#region PgOfferingTopicIdSource
			if (CanDeepSave(entity, "PgOfferingTopic|PgOfferingTopicIdSource", deepSaveType, innerList) 
				&& entity.PgOfferingTopicIdSource != null)
			{
				DataRepository.PgOfferingTopicProvider.Save(transactionManager, entity.PgOfferingTopicIdSource);
				entity.PgOfferingTopicId = entity.PgOfferingTopicIdSource.PgOfferingTopicId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisStudTopicIdSource != null)
						{
							child.PgThesisStudTopicId = child.PgThesisStudTopicIdSource.PgThesisStudTopicId;
						}
						else
						{
							child.PgThesisStudTopicId = entity.PgThesisStudTopicId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisStudTopicChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisStudTopic</c>
	///</summary>
	public enum PgThesisStudTopicChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCodeChangeType</c> at PgCodeChangeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(PgCodeChangeType))]
		PgCodeChangeType,
		
		///<summary>
		/// Composite Property for <c>PgOfferingTopic</c> at PgOfferingTopicIdSource
		///</summary>
		[ChildEntityType(typeof(PgOfferingTopic))]
		PgOfferingTopic,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisStudTopic</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
	}
	
	#endregion PgThesisStudTopicChildEntityTypes
	
	#region PgThesisStudTopicFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisStudTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudTopicFilterBuilder : SqlFilterBuilder<PgThesisStudTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicFilterBuilder class.
		/// </summary>
		public PgThesisStudTopicFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudTopicFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudTopicFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudTopicFilterBuilder
	
	#region PgThesisStudTopicParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisStudTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudTopic"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudTopicParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisStudTopicColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicParameterBuilder class.
		/// </summary>
		public PgThesisStudTopicParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudTopicParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudTopicParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudTopicParameterBuilder
	
	#region PgThesisStudTopicSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisStudTopicColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudTopic"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisStudTopicSortBuilder : SqlSortBuilder<PgThesisStudTopicColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudTopicSqlSortBuilder class.
		/// </summary>
		public PgThesisStudTopicSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisStudTopicSortBuilder
	
} // end namespace
