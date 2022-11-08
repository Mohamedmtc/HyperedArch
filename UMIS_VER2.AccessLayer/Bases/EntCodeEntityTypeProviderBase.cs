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
	/// This class is the base class for any <see cref="EntCodeEntityTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodeEntityTypeProviderBase : EntCodeEntityTypeProviderBaseCore
    {

        #region Custom Method

        public TList<EntCodeEntityType> GetEntityTypeChildes(System.Decimal _entCodeEntityTypeId)
        {
            int count = -1;
            return GetEntityTypeChildes(null, _entCodeEntityTypeId, 0, int.MaxValue, out count);
        }
        public TList<EntCodeEntityType> GetEntityTypeChildes(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
        {
            int count = -1;
            return GetEntityTypeChildes(null, _entCodeEntityTypeId, start, pageLength, out count);
        }
        public TList<EntCodeEntityType> GetEntityTypeChildes(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
        {
            int count = -1;
            return GetEntityTypeChildes(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
        }
        public TList<EntCodeEntityType> GetEntityTypeChildes(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
        {
            int count = -1;
            return GetEntityTypeChildes(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
        }
        public TList<EntCodeEntityType> GetEntityTypeChildes(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
        {
            return GetEntityTypeChildes(null, _entCodeEntityTypeId, start, pageLength, out count);
        }
        public abstract TList<EntCodeEntityType> GetEntityTypeChildes(TransactionManager transactionManager, System.Decimal entCodeEntityTypeId, int start, int pageLength, out int count);
        #endregion
    } // end class
} // end namespace
