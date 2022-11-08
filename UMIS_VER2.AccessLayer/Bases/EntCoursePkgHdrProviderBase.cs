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
	/// This class is the base class for any <see cref="EntCoursePkgHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCoursePkgHdrProviderBase : EntCoursePkgHdrProviderBaseCore
	{

        #region Custom Methods

        public abstract DataTable GetEntityMains(TransactionManager transactionManager);


        public TList<EntCoursePkgHdr> GetByParentEntityMain(TransactionManager transactionManager, System.Decimal _entMainId)
        {
            int count = -1;
            return GetByParentEntityMain(transactionManager, _entMainId, 0, int.MaxValue, out count);
        }
        public abstract TList<EntCoursePkgHdr> GetByParentEntityMain(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);

        public abstract bool InsertImportedCoursePkg(TransactionManager transactionManager, System.Decimal EntMainFromID, System.Decimal EDACADPLANFromID, System.Decimal EntMainToID, System.Decimal EDACADPLANToID, System.Decimal EntCoursePkgHdrID);
  
 
        #endregion
	} // end class
} // end namespace
