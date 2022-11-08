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
	/// This class is the base class for any <see cref="EntPolicyLoadProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyLoadProviderBase : EntPolicyLoadProviderBaseCore
    {
        #region Custom Methods


        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		FK_ED_BYLAW_LOAD_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        public TList<EntPolicyLoad> GetByStudSemesterId(System.Decimal _StudSemesterId)
        {
            int count = -1;
            return GetByStudSemesterId(_StudSemesterId, 0, int.MaxValue, out count);
            //return GetByEntMainId(_StudSemesterId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		FK_ED_BYLAW_LOAD_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        /// <remarks></remarks>
        public TList<EntPolicyLoad> GetByStudSemesterId(TransactionManager transactionManager, System.Decimal _StudSemesterId)
        {
            int count = -1;
            return GetByStudSemesterId(transactionManager, _StudSemesterId, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		FK_ED_BYLAW_LOAD_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        public TList<EntPolicyLoad> GetByStudSemesterId(TransactionManager transactionManager, System.Decimal _StudSemesterId, int start, int pageLength)
        {
            int count = -1;
            return GetByStudSemesterId(transactionManager, _StudSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		fkEdBylawLoadEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        public TList<EntPolicyLoad> GetByStudSemesterId(System.Decimal _StudSemesterId, int start, int pageLength)
        {
            int count = -1;
            return GetByStudSemesterId(null, _StudSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		fkEdBylawLoadEntityMain Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        public TList<EntPolicyLoad> GetByStudSemesterId(System.Decimal _StudSemesterId, int start, int pageLength, out int count)
        {
            return GetByStudSemesterId(null, _StudSemesterId, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_BYLAW_LOAD_ENTITY_MAIN key.
        ///		FK_ED_BYLAW_LOAD_ENTITY_MAIN Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entMainId">مسلسل الكيان فى الشجرة</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyLoad objects.</returns>
        public abstract TList<EntPolicyLoad> GetByStudSemesterId(TransactionManager transactionManager, System.Decimal _StudSemesterId, int start, int pageLength, out int count);

        public abstract TList<EntPolicyLoad> GetByAsFacultyInfoId(TransactionManager transactionManager, decimal asFacultyInfoId, decimal edCodeSemesterTypeId);


        #endregion
    } // end class
} // end namespace
