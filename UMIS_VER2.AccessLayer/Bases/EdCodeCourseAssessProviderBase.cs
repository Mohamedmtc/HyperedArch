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
	/// This class is the base class for any <see cref="EdCodeCourseAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseAssessProviderBase : EdCodeCourseAssessProviderBaseCore
    {
        public abstract DataTable Get_couse_code(TransactionManager transactionManager, Hashtable htParameters);
        #region
        public TList<EdCodeCourseAssess> GetByUniversity()
        {
            int count = -1;
            return GetByUniversity(0, int.MaxValue, out count);
        }
        public TList<EdCodeCourseAssess> GetByUniversity(TransactionManager transactionManager)
        {
            int count = -1;
            return GetByUniversity(transactionManager, 0, int.MaxValue, out count);
        }
        public TList<EdCodeCourseAssess> GetByUniversity(TransactionManager transactionManager, int start, int pageLength)
        {
            int count = -1;
            return GetByUniversity(transactionManager, start, pageLength, out count);
        }
        public TList<EdCodeCourseAssess> GetByUniversity(int start, int pageLength)
        {
            int count = -1;
            return GetByUniversity(null, start, pageLength, out count);
        }
        public TList<EdCodeCourseAssess> GetByUniversity(int start, int pageLength, out int count)
        {
            return GetByUniversity(null, start, pageLength, out count);
        }
        public abstract TList<EdCodeCourseAssess> GetByUniversity(TransactionManager transactionManager, int start, int pageLength, out int count);
        public abstract TList<EdCodeCourseAssess> GetByCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID);

        public abstract TList<EdCodeCourseAssess> GetByCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID, int EntPolicyAssessId, int EdAcadYearID, int EdCodeSemeterId);

        public abstract TList<EdCodeCourseAssess> GetByMakeUpCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID);

        public abstract TList<EdCodeCourseAssess> GetCourseAssess(TransactionManager transactionManager, decimal asFacultyInfoID, string edCourseCode);
        #endregion
    } // end class
} // end namespace
