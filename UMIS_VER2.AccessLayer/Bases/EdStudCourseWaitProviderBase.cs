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
	/// This class is the base class for any <see cref="EdStudCourseWaitProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseWaitProviderBase : EdStudCourseWaitProviderBaseCore
    {
        #region Custom Methods
        public abstract DataSet GetStudentCourseWaitList(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdCourseID, System.Decimal? _ScScheduleDtlID, System.Decimal? _EntityMainId, System.Decimal _Asc, System.Decimal _OrderColumn);

        public abstract bool DeleteStudentCourseWaitList(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdCourseID, System.Decimal? _ScScheduleDtlID, System.Decimal? _EntityMainId);
        #endregion

    } // end class
} // end namespace
