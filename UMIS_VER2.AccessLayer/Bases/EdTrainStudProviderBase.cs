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
	/// This class is the base class for any <see cref="EdTrainStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdTrainStudProviderBase : EdTrainStudProviderBaseCore
	{

        #region Custom Methods

        public abstract DataTable GetEdTrainStudDetails(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsDeTrainSiteID,  string _StudCode);
        public abstract bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStud entity, decimal acadYearId, decimal semesterId);
        #endregion

	} // end class
} // end namespace
