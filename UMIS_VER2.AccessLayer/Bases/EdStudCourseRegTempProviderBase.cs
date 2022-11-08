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
	/// This class is the base class for any <see cref="EdStudCourseRegTempProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegTempProviderBase : EdStudCourseRegTempProviderBaseCore
	{
        public abstract bool LoadEdStudCourseRegTemp(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.String _StudCode);
        public abstract bool UnLoadEdStudCourseRegTemp(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.String _StudCode);
        public abstract bool ApproveStudCourseTemp(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.String _StudCode);
	} // end class
} // end namespace
