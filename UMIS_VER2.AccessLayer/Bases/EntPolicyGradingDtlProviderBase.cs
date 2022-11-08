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
	/// This class is the base class for any <see cref="EntPolicyGradingDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingDtlProviderBase : EntPolicyGradingDtlProviderBaseCore
    {
        #region Custom Methods


        /// <summary>
        /// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(System.Decimal _edStudId, System.Decimal _TotalGpa)
        {
            int count = -1;
            return GetStudAccumGrading(null, _edStudId, _TotalGpa, 0, int.MaxValue, out count);
        }
        public abstract DataTable GetStudAccumGrading(TransactionManager transactionManager, System.Decimal EdacadYearId, System.Decimal _AsFacultyInfoId, System.Decimal _edCodeGradingTypeId, System.Decimal _AsCodeDegreeClassId, System.Decimal Flag, decimal? Major_Id = null, string BylawYearMajorId = null);
        /// <summary>
        /// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength)
        {
            int count = -1;
            return GetStudAccumGrading(null, _edStudId, _TotalGpa, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <remarks></remarks>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _TotalGpa)
        {
            int count = -1;
            return GetStudAccumGrading(transactionManager, _edStudId, _TotalGpa, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength)
        {
            int count = -1;
            return GetStudAccumGrading(transactionManager, _edStudId, _TotalGpa, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength, out int count)
        {
            return GetStudAccumGrading(null, _edStudId, _TotalGpa, start, pageLength, out count);
        }


        /// <summary>
        /// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entPolicyGradingDtlId"></param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
        public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength, out int count);

        public abstract DataTable GetSuccessGrading(TransactionManager transactionManager, System.Decimal _entMainId);

        public abstract DataTable GetEntPolicyGrdDtlUsingEdCodeGrdType(TransactionManager transactionManager, System.Decimal _AsFaculityInfoId, System.Decimal _AsCodeDegreeClassId, System.Decimal _EdCodeGradingTypeId, System.Decimal _EdByLawId);

        public abstract DataTable GetCourseGradingGeneralby_EdByLawID(TransactionManager transactionManager, System.Decimal _EdByLawID);
        #endregion
    } // end class
} // end namespace
