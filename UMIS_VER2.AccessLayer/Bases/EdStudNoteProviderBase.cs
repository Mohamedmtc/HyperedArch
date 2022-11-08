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
	/// This class is the base class for any <see cref="EdStudNoteProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudNoteProviderBase : EdStudNoteProviderBaseCore
	{

        /*---task 12370 KU ---*/
        #region Custom Method
        public abstract DataTable GetStudFeeNote(TransactionManager transactionManager, decimal StudID);
        #endregion
	} // end class
    
    
} // end namespace
