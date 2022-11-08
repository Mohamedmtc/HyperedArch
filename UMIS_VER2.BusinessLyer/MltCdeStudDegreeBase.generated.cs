﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file MltCdeStudDegree.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using UMIS_VER2.BusinessLyer.Validation;
#endregion

namespace UMIS_VER2.BusinessLyer
{
	///<summary>
	/// An object representation of the 'MLT_CDE_STUD_DEGREE' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class MltCdeStudDegreeBase : EntityBase, IMltCdeStudDegree, IEntityId<MltCdeStudDegreeKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private MltCdeStudDegreeEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private MltCdeStudDegreeEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private MltCdeStudDegreeEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<MltCdeStudDegree> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event MltCdeStudDegreeEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event MltCdeStudDegreeEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="MltCdeStudDegreeBase"/> instance.
		///</summary>
		public MltCdeStudDegreeBase()
		{
			this.entityData = new MltCdeStudDegreeEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="MltCdeStudDegreeBase"/> instance.
		///</summary>
		///<param name="_mltCdeDegreeId"></param>
		///<param name="_dgrAr"></param>
		///<param name="_dgrEn"></param>
		public MltCdeStudDegreeBase(System.Decimal _mltCdeDegreeId, System.String _dgrAr, 
			System.String _dgrEn)
		{
			this.entityData = new MltCdeStudDegreeEntityData();
			this.backupData = null;

			this.MltCdeDegreeId = _mltCdeDegreeId;
			this.DgrAr = _dgrAr;
			this.DgrEn = _dgrEn;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="MltCdeStudDegree"/> instance.
		///</summary>
		///<param name="_mltCdeDegreeId"></param>
		///<param name="_dgrAr"></param>
		///<param name="_dgrEn"></param>
		public static MltCdeStudDegree CreateMltCdeStudDegree(System.Decimal _mltCdeDegreeId, System.String _dgrAr, 
			System.String _dgrEn)
		{
			MltCdeStudDegree newMltCdeStudDegree = new MltCdeStudDegree();
			newMltCdeStudDegree.MltCdeDegreeId = _mltCdeDegreeId;
			newMltCdeStudDegree.DgrAr = _dgrAr;
			newMltCdeStudDegree.DgrEn = _dgrEn;
			return newMltCdeStudDegree;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MltCdeDegreeId property. 
		///		
		/// </summary>
		/// <value>This type is numeric.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false)]
		public virtual System.Decimal MltCdeDegreeId
		{
			get
			{
				return this.entityData.MltCdeDegreeId; 
			}
			
			set
			{
				if (this.entityData.MltCdeDegreeId == value)
					return;
					
				OnColumnChanging(MltCdeStudDegreeColumn.MltCdeDegreeId, this.entityData.MltCdeDegreeId);
				this.entityData.MltCdeDegreeId = value;
				this.EntityId.MltCdeDegreeId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(MltCdeStudDegreeColumn.MltCdeDegreeId, this.entityData.MltCdeDegreeId);
				OnPropertyChanged("MltCdeDegreeId");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the MLT_CDE_DEGREE_ID property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the MLT_CDE_DEGREE_ID property.</remarks>
		/// <value>This type is numeric</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.Decimal OriginalMltCdeDegreeId
		{
			get { return this.entityData.OriginalMltCdeDegreeId; }
			set { this.entityData.OriginalMltCdeDegreeId = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the DgrAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 50)]
		public virtual System.String DgrAr
		{
			get
			{
				return this.entityData.DgrAr; 
			}
			
			set
			{
				if (this.entityData.DgrAr == value)
					return;
					
				OnColumnChanging(MltCdeStudDegreeColumn.DgrAr, this.entityData.DgrAr);
				this.entityData.DgrAr = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(MltCdeStudDegreeColumn.DgrAr, this.entityData.DgrAr);
				OnPropertyChanged("DgrAr");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the DgrEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 50)]
		public virtual System.String DgrEn
		{
			get
			{
				return this.entityData.DgrEn; 
			}
			
			set
			{
				if (this.entityData.DgrEn == value)
					return;
					
				OnColumnChanging(MltCdeStudDegreeColumn.DgrEn, this.entityData.DgrEn);
				this.entityData.DgrEn = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(MltCdeStudDegreeColumn.DgrEn, this.entityData.DgrEn);
				OnPropertyChanged("DgrEn");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
	
		/// <summary>
		///	Holds a collection of MltStudInfo objects
		///	which are related to this object through the relation FK_MLT_STUD_INFO_MLT_CDE_STUD_DEGREE
		/// </summary>	
		[System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
		public virtual TList<MltStudInfo> MltStudInfoCollection
		{
			get { return entityData.MltStudInfoCollection; }
			set { entityData.MltStudInfoCollection = value; }	
		}
		#endregion Children Collections
		
		#endregion
		#region Validation
		
		/// <summary>
		/// Assigns validation rules to this object based on model definition.
		/// </summary>
		/// <remarks>This method overrides the base class to add schema related validation.</remarks>
		protected override void AddValidationRules()
		{
			//Validation rules based on database schema.
			ValidationRules.AddRule( CommonRules.NotNull,
				new ValidationRuleArgs("DgrAr", "Dgr Ar"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("DgrAr", "Dgr Ar", 50));
			ValidationRules.AddRule( CommonRules.NotNull,
				new ValidationRuleArgs("DgrEn", "Dgr En"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("DgrEn", "Dgr En", 50));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "MLT_CDE_STUD_DEGREE"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MLT_CDE_DEGREE_ID", "DGR_AR", "DGR_EN"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as MltCdeStudDegreeEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (MltCdeStudDegree) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<MltCdeStudDegree>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as MltCdeStudDegree);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed MltCdeStudDegree Entity 
		///</summary>
		protected virtual MltCdeStudDegree Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			MltCdeStudDegree copy = new MltCdeStudDegree();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MltCdeDegreeId = this.MltCdeDegreeId;
					copy.OriginalMltCdeDegreeId = this.OriginalMltCdeDegreeId;
				copy.DgrAr = this.DgrAr;
				copy.DgrEn = this.DgrEn;
			
		
			//deep copy nested objects
			copy.MltStudInfoCollection = (TList<MltStudInfo>) MakeCopyOf(this.MltStudInfoCollection, existingCopies); 
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed MltCdeStudDegree Entity 
		///</summary>
		public virtual MltCdeStudDegree Copy()
		{
			return this.Copy(null);	
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy(null);
		}
		
		///<summary>
		/// ICloneableEx.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone(IDictionary existingCopies)
		{
			return this.Copy(existingCopies);
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x, IDictionary existingCopies)
		{
			if (x == null)
				return null;
			
			if (x is ICloneableEx)
			{
				// Return a deep copy of the object
				return ((ICloneableEx)x).Clone(existingCopies);
			}
			else if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable or IClonableEx Interface.");
		}
		
		
		///<summary>
		///  Returns a Typed MltCdeStudDegree Entity which is a deep copy of the current entity.
		///</summary>
		public virtual MltCdeStudDegree DeepCopy()
		{
			return EntityHelper.Clone<MltCdeStudDegree>(this as MltCdeStudDegree);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as MltCdeStudDegreeEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new MltCdeStudDegreeEntityData();
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as MltCdeStudDegreeEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(MltCdeStudDegreeColumn column)
		{
			switch(column)
			{
					case MltCdeStudDegreeColumn.MltCdeDegreeId:
					return entityData.MltCdeDegreeId != _originalData.MltCdeDegreeId;
					case MltCdeStudDegreeColumn.DgrAr:
					return entityData.DgrAr != _originalData.DgrAr;
					case MltCdeStudDegreeColumn.DgrEn:
					return entityData.DgrEn != _originalData.DgrEn;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="columnName">The column name.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public override bool IsPropertyChanged(string columnName)
		{
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< MltCdeStudDegreeColumn >(columnName));
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if data has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.MltCdeDegreeId != _originalData.MltCdeDegreeId;
			result = result || entityData.DgrAr != _originalData.DgrAr;
			result = result || entityData.DgrEn != _originalData.DgrEn;
			return result;
		}	
		
		///<summary>
		///  Returns a MltCdeStudDegree Entity with the original data.
		///</summary>
		public MltCdeStudDegree GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateMltCdeStudDegree(
				_originalData.MltCdeDegreeId,
				_originalData.DgrAr,
				_originalData.DgrEn
				);
				
			return (MltCdeStudDegree)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="MltCdeStudDegreeBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is MltCdeStudDegreeBase)
				return ValueEquals(this, (MltCdeStudDegreeBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="MltCdeStudDegreeBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MltCdeDegreeId.GetHashCode() ^ 
					this.DgrAr.GetHashCode() ^ 
					this.DgrEn.GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="MltCdeStudDegreeBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(MltCdeStudDegreeBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="MltCdeStudDegreeBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="MltCdeStudDegreeBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="MltCdeStudDegreeBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(MltCdeStudDegreeBase Object1, MltCdeStudDegreeBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MltCdeDegreeId != Object2.MltCdeDegreeId)
				equal = false;
			if (Object1.DgrAr != Object2.DgrAr)
				equal = false;
			if (Object1.DgrEn != Object2.DgrEn)
				equal = false;
					
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((MltCdeStudDegreeBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static MltCdeStudDegreeComparer GetComparer()
        {
            return new MltCdeStudDegreeComparer();
        }
        */

        // Comparer delegates back to MltCdeStudDegree
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(MltCdeStudDegree rhs, MltCdeStudDegreeColumn which)
        {
            switch (which)
            {
            	
            	
            	case MltCdeStudDegreeColumn.MltCdeDegreeId:
            		return this.MltCdeDegreeId.CompareTo(rhs.MltCdeDegreeId);
            		
            		                 
            	
            	
            	case MltCdeStudDegreeColumn.DgrAr:
            		return this.DgrAr.CompareTo(rhs.DgrAr);
            		
            		                 
            	
            	
            	case MltCdeStudDegreeColumn.DgrEn:
            		return this.DgrEn.CompareTo(rhs.DgrEn);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<MltCdeStudDegreeKey> Members
		
		// member variable for the EntityId property
		private MltCdeStudDegreeKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual MltCdeStudDegreeKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new MltCdeStudDegreeKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) , XmlIgnoreAttribute()]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("MltCdeStudDegree")
					.Append("|").Append( this.MltCdeDegreeId.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- MltCdeDegreeId: {0}{3}- DgrAr: {1}{3}- DgrEn: {2}{3}{5}", 
				this.MltCdeDegreeId,
				this.DgrAr,
				this.DgrEn,
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'MLT_CDE_STUD_DEGREE' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class MltCdeStudDegreeEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MLT_CDE_DEGREE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MLT_CDE_STUD_DEGREE"</remarks>
		public System.Decimal MltCdeDegreeId;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.Decimal OriginalMltCdeDegreeId;
		
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// DGR_AR : 
		/// </summary>
		public System.String		  DgrAr = string.Empty;
		
		/// <summary>
		/// DGR_EN : 
		/// </summary>
		public System.String		  DgrEn = string.Empty;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#region MltStudInfoCollection
		
		private TList<MltStudInfo> _mltStudInfoMltCdeDegreeId;
		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltStudInfoMltCdeDegreeId
		/// </summary>
		
		public TList<MltStudInfo> MltStudInfoCollection
		{
			get
			{
				if (_mltStudInfoMltCdeDegreeId == null)
				{
				_mltStudInfoMltCdeDegreeId = new TList<MltStudInfo>();
				}
	
				return _mltStudInfoMltCdeDegreeId;
			}
			set { _mltStudInfoMltCdeDegreeId = value; }
		}
		
		#endregion

		#endregion Data Properties
		
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			MltCdeStudDegreeEntityData _tmp = new MltCdeStudDegreeEntityData();
						
			_tmp.MltCdeDegreeId = this.MltCdeDegreeId;
			_tmp.OriginalMltCdeDegreeId = this.OriginalMltCdeDegreeId;
			
			_tmp.DgrAr = this.DgrAr;
			_tmp.DgrEn = this.DgrEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			if (this._mltStudInfoMltCdeDegreeId != null)
				_tmp.MltStudInfoCollection = (TList<MltStudInfo>) MakeCopyOf(this.MltStudInfoCollection); 
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone(IDictionary existingCopies)
		{
			if (existingCopies == null)
				existingCopies = new Hashtable();
				
			MltCdeStudDegreeEntityData _tmp = new MltCdeStudDegreeEntityData();
						
			_tmp.MltCdeDegreeId = this.MltCdeDegreeId;
			_tmp.OriginalMltCdeDegreeId = this.OriginalMltCdeDegreeId;
			
			_tmp.DgrAr = this.DgrAr;
			_tmp.DgrEn = this.DgrEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			_tmp.MltStudInfoCollection = (TList<MltStudInfo>) MakeCopyOf(this.MltStudInfoCollection, existingCopies); 
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct











		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MltCdeStudDegreeColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(MltCdeStudDegreeColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MltCdeStudDegreeColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(MltCdeStudDegreeColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MltCdeStudDegreeColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(MltCdeStudDegreeColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				MltCdeStudDegreeEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new MltCdeStudDegreeEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MltCdeStudDegreeColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(MltCdeStudDegreeColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				MltCdeStudDegreeEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new MltCdeStudDegreeEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region MltCdeStudDegreeEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="MltCdeStudDegree"/> object.
	/// </remarks>
	public class MltCdeStudDegreeEventArgs : System.EventArgs
	{
		private MltCdeStudDegreeColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the MltCdeStudDegreeEventArgs class.
		///</summary>
		public MltCdeStudDegreeEventArgs(MltCdeStudDegreeColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the MltCdeStudDegreeEventArgs class.
		///</summary>
		public MltCdeStudDegreeEventArgs(MltCdeStudDegreeColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The MltCdeStudDegreeColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="MltCdeStudDegreeColumn" />
		public MltCdeStudDegreeColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all MltCdeStudDegree related events.
	///</summary>
	public delegate void MltCdeStudDegreeEventHandler(object sender, MltCdeStudDegreeEventArgs e);
	
	#region MltCdeStudDegreeComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class MltCdeStudDegreeComparer : System.Collections.Generic.IComparer<MltCdeStudDegree>
	{
		MltCdeStudDegreeColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:MltCdeStudDegreeComparer"/> class.
        /// </summary>
		public MltCdeStudDegreeComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MltCdeStudDegreeComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public MltCdeStudDegreeComparer(MltCdeStudDegreeColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="MltCdeStudDegree"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="MltCdeStudDegree"/> to compare.</param>
        /// <param name="b">The second <c>MltCdeStudDegree</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(MltCdeStudDegree a, MltCdeStudDegree b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(MltCdeStudDegree entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(MltCdeStudDegree a, MltCdeStudDegree b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public MltCdeStudDegreeColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region MltCdeStudDegreeKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="MltCdeStudDegree"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class MltCdeStudDegreeKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeKey class.
		/// </summary>
		public MltCdeStudDegreeKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeKey class.
		/// </summary>
		public MltCdeStudDegreeKey(MltCdeStudDegreeBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MltCdeDegreeId = entity.MltCdeDegreeId;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the MltCdeStudDegreeKey class.
		/// </summary>
		public MltCdeStudDegreeKey(System.Decimal _mltCdeDegreeId)
		{
			#region Init Properties

			this.MltCdeDegreeId = _mltCdeDegreeId;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private MltCdeStudDegreeBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public MltCdeStudDegreeBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MltCdeDegreeId property
		private System.Decimal _mltCdeDegreeId;
		
		/// <summary>
		/// Gets or sets the MltCdeDegreeId property.
		/// </summary>
		public System.Decimal MltCdeDegreeId
		{
			get { return _mltCdeDegreeId; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MltCdeDegreeId = value;
				
				_mltCdeDegreeId = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				MltCdeDegreeId = ( values["MltCdeDegreeId"] != null ) ? (System.Decimal) EntityUtil.ChangeType(values["MltCdeDegreeId"], typeof(System.Decimal)) : 0.0m;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("MltCdeDegreeId", MltCdeDegreeId);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MltCdeDegreeId: {0}{1}",
								MltCdeDegreeId,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region MltCdeStudDegreeColumn Enum
	
	/// <summary>
	/// Enumerate the MltCdeStudDegree columns.
	/// </summary>
	[Serializable]
	public enum MltCdeStudDegreeColumn : int
	{
		/// <summary>
		/// MltCdeDegreeId : 
		/// </summary>
		[EnumTextValue("MLT_CDE_DEGREE_ID")]
		[ColumnEnum("MLT_CDE_DEGREE_ID", typeof(System.Decimal), System.Data.DbType.Decimal, true, false, false)]
		MltCdeDegreeId = 1,
		/// <summary>
		/// DgrAr : 
		/// </summary>
		[EnumTextValue("DGR_AR")]
		[ColumnEnum("DGR_AR", typeof(System.String), System.Data.DbType.String, false, false, false, 50)]
		DgrAr = 2,
		/// <summary>
		/// DgrEn : 
		/// </summary>
		[EnumTextValue("DGR_EN")]
		[ColumnEnum("DGR_EN", typeof(System.String), System.Data.DbType.String, false, false, false, 50)]
		DgrEn = 3
	}//End enum

	#endregion MltCdeStudDegreeColumn Enum

} // end namespace