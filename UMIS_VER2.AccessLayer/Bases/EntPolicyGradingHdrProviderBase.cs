#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="EntPolicyGradingHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingHdrProviderBase : EntPolicyGradingHdrProviderBaseCore
    {
        #region Custom Methods

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, Decimal _entMainId)
        {
            int count = -1;
            return GetByEdCodeGradingTypeId(_edCodeGradingTypeId, _entMainId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, System.Decimal _entMainId)
        {
            int count = -1;
            return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, _entMainId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength)
        {
            int count = -1;
            return GetByEdCodeGradingTypeId(transactionManager, _edCodeGradingTypeId, _entMainId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		fkEntPolicyGradingHdrEdCodeGradingType Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength)
        {
            int count = -1;
            return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, _entMainId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		fkEntPolicyGradingHdrEdCodeGradingType Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength, out int count)
        {
            return GetByEdCodeGradingTypeId(null, _edCodeGradingTypeId, _entMainId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE key.
        ///		FK_ENT_POLICY_GRADING_HDR_ED_CODE_GRADING_TYPE Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCodeGradingTypeId">نوع التقدير:مواد تراكمى مادة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public abstract TList<EntPolicyGradingHdr> GetByEdCodeGradingTypeId(TransactionManager transactionManager, System.Decimal _edCodeGradingTypeId, Decimal _entMainId, int start, int pageLength, out int count);
		

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {
            int count = -1;
            return GetFORCOURSEId(_entMainId, _edcourseid, _entcoursepkghdrId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyGradingHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {
            int count = -1;
            return GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength)
        {
            int count = -1;
            return GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyGradingHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength)
        {
            int count = -1;
            return GetFORCOURSEId(null, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyGradingHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count)
        {
            return GetFORCOURSEId(null, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public abstract TList<EntPolicyGradingHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count);










        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {
            int count = -1;
            return Get_byStudeSemester_Course(_edstudsemesterid, _edcourseid, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {
            int count = -1;
            return Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength)
        {
            int count = -1;
            return Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyGradingHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength)
        {
            int count = -1;
            return Get_byStudeSemester_Course(null, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyGradingHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count)
        {
            return Get_byStudeSemester_Course(null, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_GRADING_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyGradingHdr objects.</returns>
        public abstract TList<EntPolicyGradingHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count);





        public abstract TList<EntPolicyGradingHdr> GetStudPolicies(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.Decimal _edCodeGradingTypeId);


     

        public abstract string CheckRatingLimits(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _EdBylawId, System.Decimal _Lang);

        public abstract DataTable GetEntityMains(TransactionManager transactionManager);

        #endregion
    } // end class
} // end namespace
