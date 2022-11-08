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
	/// This class is the base class for any <see cref="EdStudCodeChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCodeChngProviderBase : EdStudCodeChngProviderBaseCore
    {
        #region custom methods
        public abstract DataTable GetSTUDCODECHNGByStuDId(TransactionManager transactionManager, decimal ED_STUD_ID);
        public abstract DataTable GetAcadymicYearGrThanCurrentYear(TransactionManager transactionManager, decimal ED_STUD_ID, decimal asFacultyInfoId);
        public abstract bool InsertNewCode(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity,decimal as_faculty_info_id);
        public abstract DataTable GetMaxChgCode(TransactionManager transactionManager, decimal ED_STUD_ID);
        public abstract bool UpdateNewCode(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity);
    
        #endregion
    } // end class
} // end namespace
