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
	/// This class is the base class for any <see cref="EdStudAcadmicAdvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudAcadmicAdvProviderBase : EdStudAcadmicAdvProviderBaseCore
	{
        //added by mmq at 08-01-2017
        public abstract decimal CopyStudentsAcadmicAdv(TransactionManager transactionManager, string edAcadYear, string edCodeSemster);

	} // end class
} // end namespace
