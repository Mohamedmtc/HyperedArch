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
	/// This class is the base class for any <see cref="EdCdeTchngMthdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeTchngMthdProviderBase : EdCdeTchngMthdProviderBaseCore
	{
        public abstract TList<EdCdeTchngMthd> GetAllCourseTchngMthd(TransactionManager transactionManager, System.Decimal _edCourseId);

        public abstract TList<EdCdeTchngMthd> GetTeachingMethod_SchdlSlot(TransactionManager transactionManager, System.Decimal _SchdleSlotID);
	} // end class
} // end namespace
