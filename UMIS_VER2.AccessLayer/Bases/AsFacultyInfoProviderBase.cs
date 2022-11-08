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
	/// This class is the base class for any <see cref="AsFacultyInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AsFacultyInfoProviderBase : AsFacultyInfoProviderBaseCore
	{
        #region Custom Methods

        public abstract decimal GetAsFacultyInfo_for_User(TransactionManager transactionManager, System.Decimal _SeUserId);

        public abstract DataTable GetAcadPlanState(TransactionManager transactionManager, string AsFacultyInfoID, string DgrCode, string DgrNameEn, string DgrNameAr, decimal PageIndex, decimal PageSize);

        //Esraa Ali     27-5-2020     13648
        public abstract DataTable INTEG_GetSchool(System.Decimal _FacID);
        public abstract DataTable GetMajorOfFaculty(System.Decimal _FacID);
        #endregion

	} // end class
} // end namespace
