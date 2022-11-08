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
	/// This class is the base class for any <see cref="EdAcadYearProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadYearProviderBase : EdAcadYearProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetNextAcadYear(TransactionManager transactionManager);

        public abstract bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity, EdAcadYearFaculty objAcadYearFaculty ,decimal? _AsFacultyInfoID= null , decimal? _AsCode_DegreeClassID = null);

        public abstract bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity, EdAcadYearFaculty objAcadyearFac);

        #endregion
	} // end class
} // end namespace
