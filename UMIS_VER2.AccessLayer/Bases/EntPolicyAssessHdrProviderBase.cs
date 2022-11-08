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
	/// This class is the base class for any <see cref="EntPolicyAssessHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAssessHdrProviderBase : EntPolicyAssessHdrProviderBaseCore
    {
        #region Custom Methods


        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {
            int count = -1;
            return GetFORCOURSEId(_entMainId, _edcourseid, _entcoursepkghdrId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyAssessHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId)
        {
            int count = -1;
            return GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength)
        {
            int count = -1;
            return GetFORCOURSEId(transactionManager, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength)
        {
            int count = -1;
            return GetFORCOURSEId(null, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> GetFORCOURSEId(System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count)
        {
            return GetFORCOURSEId(null, _entMainId, _edcourseid, _entcoursepkghdrId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public abstract TList<EntPolicyAssessHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count);







        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {
            int count = -1;
            return Get_byStudeSemester_Course(_edstudsemesterid, _edcourseid, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid)
        {
            int count = -1;
            return Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength)
        {
            int count = -1;
            return Get_byStudeSemester_Course(transactionManager, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength)
        {
            int count = -1;
            return Get_byStudeSemester_Course(null, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count)
        {
            return Get_byStudeSemester_Course(null, _edstudsemesterid, _edcourseid, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public abstract TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count);



        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid)
        {
            int count = -1;
            return Get_bySemester_Course_AcadYear(_asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid)
        {
            int count = -1;
            return Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid,0, 0, int.MaxValue, out count);
        }

        //kamela,12279
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, System.Decimal _Major_Id)
        {
            int count = -1;
            return Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid, _Major_Id, 0, int.MaxValue, out count);
        }
        //end

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, int start, int pageLength)
        {
            int count = -1;
            return Get_bySemester_Course_AcadYear(transactionManager, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid,0, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, int start, int pageLength)
        {
            int count = -1;
            return Get_bySemester_Course_AcadYear(null, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid,0, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		fkEntPolicyAssessHdrEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        public TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, int start, int pageLength, out int count)
        {
            return Get_bySemester_Course_AcadYear(null, _asfacultyinfoId, _acadyearid, _edcourseid, _edcodesemesterid,0, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN key.
        ///		FK_ENT_POLICY_ASSESS_HDR_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessHdr objects.</returns>
        
        //public abstract TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, int start, int pageLength, out int count);
        public abstract TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, System.Decimal _Major_Id, int start, int pageLength, out int count);

		
        #endregion
    } // end class
} // end namespace
