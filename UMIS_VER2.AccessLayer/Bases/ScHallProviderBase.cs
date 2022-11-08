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
	/// This class is the base class for any <see cref="ScHallProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScHallProviderBase : ScHallProviderBaseCore
	{
        public TList<ScHall> GetHalls(TransactionManager transactionManager, System.Decimal ScBuildingId, decimal? AsFacultyInfoId)
        {
            int count = -1;
            return GetHalls(transactionManager, ScBuildingId, AsFacultyInfoId, 0, int.MaxValue);
        }

        public abstract TList<ScHall> GetHalls(TransactionManager transactionManager, System.Decimal ScBuildingId, decimal? AsFacultyInfoId, int start, int pageLength);

	} // end class
} // end namespace
