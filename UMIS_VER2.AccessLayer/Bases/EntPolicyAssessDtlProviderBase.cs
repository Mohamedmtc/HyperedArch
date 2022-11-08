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
    /// This class is the base class for any <see cref="EntPolicyAssessDtlProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class EntPolicyAssessDtlProviderBase : EntPolicyAssessDtlProviderBaseCore
    {
        public abstract DataTable EntPolicyAssessDtlGetbyEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _EntPolicyAssessHdrId);
        public abstract  TList<EntPolicyAssessDtl> GetEntPolicyAssessDtlForStaffMember(TransactionManager trans, System.Decimal _FacultyId, System.Decimal _AssessHdrId, System.Decimal _CourseId, System.Decimal _EdCodeSemeterId, System.Decimal _AcadYearId, System.Decimal _UserId);
        
    } // end class
} // end namespace
