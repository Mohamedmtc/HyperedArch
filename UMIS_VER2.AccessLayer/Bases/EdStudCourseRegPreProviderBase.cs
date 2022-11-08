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
	/// This class is the base class for any <see cref="EdStudCourseRegPreProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegPreProviderBase : EdStudCourseRegPreProviderBaseCore
	{
        public abstract DataTable GetStudEarlyReg(TransactionManager transactionManager, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, 
                                                System.Decimal AsFacultyInfoId, System.Decimal EntMainId,
                                                System.String CourseCode, System.String StudCode);

	} // end class
} // end namespace
