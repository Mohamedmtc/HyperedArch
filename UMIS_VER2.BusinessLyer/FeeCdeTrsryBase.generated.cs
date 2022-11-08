﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file FeeCdeTrsry.cs instead.
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
	/// An object representation of the 'FEE_CDE_TRSRY' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class FeeCdeTrsryBase : EntityBase, IFeeCdeTrsry, IEntityId<FeeCdeTrsryKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private FeeCdeTrsryEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private FeeCdeTrsryEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private FeeCdeTrsryEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<FeeCdeTrsry> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event FeeCdeTrsryEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event FeeCdeTrsryEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="FeeCdeTrsryBase"/> instance.
		///</summary>
		public FeeCdeTrsryBase()
		{
			this.entityData = new FeeCdeTrsryEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="FeeCdeTrsryBase"/> instance.
		///</summary>
		///<param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		///<param name="_trsryAr"></param>
		///<param name="_trsryEn"></param>
		public FeeCdeTrsryBase(System.Int32 _feeCdeTrsryId, System.String _trsryAr, System.String _trsryEn)
		{
			this.entityData = new FeeCdeTrsryEntityData();
			this.backupData = null;

			this.FeeCdeTrsryId = _feeCdeTrsryId;
			this.TrsryAr = _trsryAr;
			this.TrsryEn = _trsryEn;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="FeeCdeTrsry"/> instance.
		///</summary>
		///<param name="_feeCdeTrsryId">اكواد بنود الخزنة</param>
		///<param name="_trsryAr"></param>
		///<param name="_trsryEn"></param>
		public static FeeCdeTrsry CreateFeeCdeTrsry(System.Int32 _feeCdeTrsryId, System.String _trsryAr, System.String _trsryEn)
		{
			FeeCdeTrsry newFeeCdeTrsry = new FeeCdeTrsry();
			newFeeCdeTrsry.FeeCdeTrsryId = _feeCdeTrsryId;
			newFeeCdeTrsry.TrsryAr = _trsryAr;
			newFeeCdeTrsry.TrsryEn = _trsryEn;
			return newFeeCdeTrsry;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the FeeCdeTrsryId property. 
		///		اكواد بنود الخزنة
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>




		[DescriptionAttribute(@"اكواد بنود الخزنة"), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false)]
		public virtual System.Int32 FeeCdeTrsryId
		{
			get
			{
				return this.entityData.FeeCdeTrsryId; 
			}
			
			set
			{
				if (this.entityData.FeeCdeTrsryId == value)
					return;
					
				OnColumnChanging(FeeCdeTrsryColumn.FeeCdeTrsryId, this.entityData.FeeCdeTrsryId);
				this.entityData.FeeCdeTrsryId = value;
				this.EntityId.FeeCdeTrsryId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(FeeCdeTrsryColumn.FeeCdeTrsryId, this.entityData.FeeCdeTrsryId);
				OnPropertyChanged("FeeCdeTrsryId");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the FEE_CDE_TRSRY_ID property.
		///		اكواد بنود الخزنة
		/// </summary>
		/// <remarks>This is the original value of the FEE_CDE_TRSRY_ID property.</remarks>
		/// <value>This type is int</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.Int32 OriginalFeeCdeTrsryId
		{
			get { return this.entityData.OriginalFeeCdeTrsryId; }
			set { this.entityData.OriginalFeeCdeTrsryId = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the TrsryAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 150)]
		public virtual System.String TrsryAr
		{
			get
			{
				return this.entityData.TrsryAr; 
			}
			
			set
			{
				if (this.entityData.TrsryAr == value)
					return;
					
				OnColumnChanging(FeeCdeTrsryColumn.TrsryAr, this.entityData.TrsryAr);
				this.entityData.TrsryAr = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(FeeCdeTrsryColumn.TrsryAr, this.entityData.TrsryAr);
				OnPropertyChanged("TrsryAr");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the TrsryEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 150)]
		public virtual System.String TrsryEn
		{
			get
			{
				return this.entityData.TrsryEn; 
			}
			
			set
			{
				if (this.entityData.TrsryEn == value)
					return;
					
				OnColumnChanging(FeeCdeTrsryColumn.TrsryEn, this.entityData.TrsryEn);
				this.entityData.TrsryEn = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(FeeCdeTrsryColumn.TrsryEn, this.entityData.TrsryEn);
				OnPropertyChanged("TrsryEn");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
	
		/// <summary>
		///	Holds a collection of FeeTreasury objects
		///	which are related to this object through the relation FK_FEE_TREASURY_FEE_CDE_TRSRY
		/// </summary>	
		[System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
		public virtual TList<FeeTreasury> FeeTreasuryCollection
		{
			get { return entityData.FeeTreasuryCollection; }
			set { entityData.FeeTreasuryCollection = value; }	
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
				new ValidationRuleArgs("TrsryAr", "Trsry Ar"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("TrsryAr", "Trsry Ar", 150));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("TrsryEn", "Trsry En", 150));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "FEE_CDE_TRSRY"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"FEE_CDE_TRSRY_ID", "TRSRY_AR", "TRSRY_EN"};
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
	            this.backupData = this.entityData.Clone() as FeeCdeTrsryEntityData;
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
						this.parentCollection.Remove( (FeeCdeTrsry) this ) ;
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
	            this.parentCollection = value as TList<FeeCdeTrsry>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as FeeCdeTrsry);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed FeeCdeTrsry Entity 
		///</summary>
		protected virtual FeeCdeTrsry Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			FeeCdeTrsry copy = new FeeCdeTrsry();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.FeeCdeTrsryId = this.FeeCdeTrsryId;
					copy.OriginalFeeCdeTrsryId = this.OriginalFeeCdeTrsryId;
				copy.TrsryAr = this.TrsryAr;
				copy.TrsryEn = this.TrsryEn;
			
		
			//deep copy nested objects
			copy.FeeTreasuryCollection = (TList<FeeTreasury>) MakeCopyOf(this.FeeTreasuryCollection, existingCopies); 
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed FeeCdeTrsry Entity 
		///</summary>
		public virtual FeeCdeTrsry Copy()
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
		///  Returns a Typed FeeCdeTrsry Entity which is a deep copy of the current entity.
		///</summary>
		public virtual FeeCdeTrsry DeepCopy()
		{
			return EntityHelper.Clone<FeeCdeTrsry>(this as FeeCdeTrsry);	
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
				this.entityData = this._originalData.Clone() as FeeCdeTrsryEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new FeeCdeTrsryEntityData();
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
			this._originalData = this.entityData.Clone() as FeeCdeTrsryEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(FeeCdeTrsryColumn column)
		{
			switch(column)
			{
					case FeeCdeTrsryColumn.FeeCdeTrsryId:
					return entityData.FeeCdeTrsryId != _originalData.FeeCdeTrsryId;
					case FeeCdeTrsryColumn.TrsryAr:
					return entityData.TrsryAr != _originalData.TrsryAr;
					case FeeCdeTrsryColumn.TrsryEn:
					return entityData.TrsryEn != _originalData.TrsryEn;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< FeeCdeTrsryColumn >(columnName));
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
			result = result || entityData.FeeCdeTrsryId != _originalData.FeeCdeTrsryId;
			result = result || entityData.TrsryAr != _originalData.TrsryAr;
			result = result || entityData.TrsryEn != _originalData.TrsryEn;
			return result;
		}	
		
		///<summary>
		///  Returns a FeeCdeTrsry Entity with the original data.
		///</summary>
		public FeeCdeTrsry GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateFeeCdeTrsry(
				_originalData.FeeCdeTrsryId,
				_originalData.TrsryAr,
				_originalData.TrsryEn
				);
				
			return (FeeCdeTrsry)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="FeeCdeTrsryBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is FeeCdeTrsryBase)
				return ValueEquals(this, (FeeCdeTrsryBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="FeeCdeTrsryBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.FeeCdeTrsryId.GetHashCode() ^ 
					this.TrsryAr.GetHashCode() ^ 
					((this.TrsryEn == null) ? string.Empty : this.TrsryEn.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="FeeCdeTrsryBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(FeeCdeTrsryBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="FeeCdeTrsryBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="FeeCdeTrsryBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="FeeCdeTrsryBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(FeeCdeTrsryBase Object1, FeeCdeTrsryBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.FeeCdeTrsryId != Object2.FeeCdeTrsryId)
				equal = false;
			if (Object1.TrsryAr != Object2.TrsryAr)
				equal = false;
			if ( Object1.TrsryEn != null && Object2.TrsryEn != null )
			{
				if (Object1.TrsryEn != Object2.TrsryEn)
					equal = false;
			}
			else if (Object1.TrsryEn == null ^ Object2.TrsryEn == null )
			{
				equal = false;
			}
					
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((FeeCdeTrsryBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static FeeCdeTrsryComparer GetComparer()
        {
            return new FeeCdeTrsryComparer();
        }
        */

        // Comparer delegates back to FeeCdeTrsry
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
        public int CompareTo(FeeCdeTrsry rhs, FeeCdeTrsryColumn which)
        {
            switch (which)
            {
            	
            	
            	case FeeCdeTrsryColumn.FeeCdeTrsryId:
            		return this.FeeCdeTrsryId.CompareTo(rhs.FeeCdeTrsryId);
            		
            		                 
            	
            	
            	case FeeCdeTrsryColumn.TrsryAr:
            		return this.TrsryAr.CompareTo(rhs.TrsryAr);
            		
            		                 
            	
            	
            	case FeeCdeTrsryColumn.TrsryEn:
            		return this.TrsryEn.CompareTo(rhs.TrsryEn);
            		
            		                 
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
				
		#region IEntityKey<FeeCdeTrsryKey> Members
		
		// member variable for the EntityId property
		private FeeCdeTrsryKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual FeeCdeTrsryKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new FeeCdeTrsryKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("FeeCdeTrsry")
					.Append("|").Append( this.FeeCdeTrsryId.ToString()).ToString();
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
				"{4}{3}- FeeCdeTrsryId: {0}{3}- TrsryAr: {1}{3}- TrsryEn: {2}{3}{5}", 
				this.FeeCdeTrsryId,
				this.TrsryAr,
				(this.TrsryEn == null) ? string.Empty : this.TrsryEn.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'FEE_CDE_TRSRY' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class FeeCdeTrsryEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// FEE_CDE_TRSRY_ID : اكواد بنود الخزنة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "FEE_CDE_TRSRY"</remarks>
		public System.Int32 FeeCdeTrsryId;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.Int32 OriginalFeeCdeTrsryId;
		
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// TRSRY_AR : 
		/// </summary>
		public System.String		  TrsryAr = string.Empty;
		
		/// <summary>
		/// TRSRY_EN : 
		/// </summary>
		public System.String		  TrsryEn = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#region FeeTreasuryCollection
		
		private TList<FeeTreasury> _feeTreasuryFeeCdeTrsryId;
		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeTreasuryFeeCdeTrsryId
		/// </summary>
		
		public TList<FeeTreasury> FeeTreasuryCollection
		{
			get
			{
				if (_feeTreasuryFeeCdeTrsryId == null)
				{
				_feeTreasuryFeeCdeTrsryId = new TList<FeeTreasury>();
				}
	
				return _feeTreasuryFeeCdeTrsryId;
			}
			set { _feeTreasuryFeeCdeTrsryId = value; }
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
			FeeCdeTrsryEntityData _tmp = new FeeCdeTrsryEntityData();
						
			_tmp.FeeCdeTrsryId = this.FeeCdeTrsryId;
			_tmp.OriginalFeeCdeTrsryId = this.OriginalFeeCdeTrsryId;
			
			_tmp.TrsryAr = this.TrsryAr;
			_tmp.TrsryEn = this.TrsryEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			if (this._feeTreasuryFeeCdeTrsryId != null)
				_tmp.FeeTreasuryCollection = (TList<FeeTreasury>) MakeCopyOf(this.FeeTreasuryCollection); 
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
				
			FeeCdeTrsryEntityData _tmp = new FeeCdeTrsryEntityData();
						
			_tmp.FeeCdeTrsryId = this.FeeCdeTrsryId;
			_tmp.OriginalFeeCdeTrsryId = this.OriginalFeeCdeTrsryId;
			
			_tmp.TrsryAr = this.TrsryAr;
			_tmp.TrsryEn = this.TrsryEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			_tmp.FeeTreasuryCollection = (TList<FeeTreasury>) MakeCopyOf(this.FeeTreasuryCollection, existingCopies); 
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
		/// <param name="column">The <see cref="FeeCdeTrsryColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(FeeCdeTrsryColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="FeeCdeTrsryColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(FeeCdeTrsryColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="FeeCdeTrsryColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(FeeCdeTrsryColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				FeeCdeTrsryEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new FeeCdeTrsryEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="FeeCdeTrsryColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(FeeCdeTrsryColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				FeeCdeTrsryEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new FeeCdeTrsryEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region FeeCdeTrsryEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="FeeCdeTrsry"/> object.
	/// </remarks>
	public class FeeCdeTrsryEventArgs : System.EventArgs
	{
		private FeeCdeTrsryColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the FeeCdeTrsryEventArgs class.
		///</summary>
		public FeeCdeTrsryEventArgs(FeeCdeTrsryColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the FeeCdeTrsryEventArgs class.
		///</summary>
		public FeeCdeTrsryEventArgs(FeeCdeTrsryColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The FeeCdeTrsryColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="FeeCdeTrsryColumn" />
		public FeeCdeTrsryColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all FeeCdeTrsry related events.
	///</summary>
	public delegate void FeeCdeTrsryEventHandler(object sender, FeeCdeTrsryEventArgs e);
	
	#region FeeCdeTrsryComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class FeeCdeTrsryComparer : System.Collections.Generic.IComparer<FeeCdeTrsry>
	{
		FeeCdeTrsryColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:FeeCdeTrsryComparer"/> class.
        /// </summary>
		public FeeCdeTrsryComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:FeeCdeTrsryComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public FeeCdeTrsryComparer(FeeCdeTrsryColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="FeeCdeTrsry"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="FeeCdeTrsry"/> to compare.</param>
        /// <param name="b">The second <c>FeeCdeTrsry</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(FeeCdeTrsry a, FeeCdeTrsry b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(FeeCdeTrsry entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(FeeCdeTrsry a, FeeCdeTrsry b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public FeeCdeTrsryColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region FeeCdeTrsryKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="FeeCdeTrsry"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class FeeCdeTrsryKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryKey class.
		/// </summary>
		public FeeCdeTrsryKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryKey class.
		/// </summary>
		public FeeCdeTrsryKey(FeeCdeTrsryBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.FeeCdeTrsryId = entity.FeeCdeTrsryId;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the FeeCdeTrsryKey class.
		/// </summary>
		public FeeCdeTrsryKey(System.Int32 _feeCdeTrsryId)
		{
			#region Init Properties

			this.FeeCdeTrsryId = _feeCdeTrsryId;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private FeeCdeTrsryBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public FeeCdeTrsryBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the FeeCdeTrsryId property
		private System.Int32 _feeCdeTrsryId;
		
		/// <summary>
		/// Gets or sets the FeeCdeTrsryId property.
		/// </summary>
		public System.Int32 FeeCdeTrsryId
		{
			get { return _feeCdeTrsryId; }
			set
			{
				if ( this.Entity != null )
					this.Entity.FeeCdeTrsryId = value;
				
				_feeCdeTrsryId = value;
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
				FeeCdeTrsryId = ( values["FeeCdeTrsryId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["FeeCdeTrsryId"], typeof(System.Int32)) : (int)0;
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

			values.Add("FeeCdeTrsryId", FeeCdeTrsryId);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("FeeCdeTrsryId: {0}{1}",
								FeeCdeTrsryId,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region FeeCdeTrsryColumn Enum
	
	/// <summary>
	/// Enumerate the FeeCdeTrsry columns.
	/// </summary>
	[Serializable]
	public enum FeeCdeTrsryColumn : int
	{
		/// <summary>
		/// FeeCdeTrsryId : اكواد بنود الخزنة
		/// </summary>
		[EnumTextValue("FEE_CDE_TRSRY_ID")]
		[ColumnEnum("FEE_CDE_TRSRY_ID", typeof(System.Int32), System.Data.DbType.Int32, true, false, false)]
		FeeCdeTrsryId = 1,
		/// <summary>
		/// TrsryAr : 
		/// </summary>
		[EnumTextValue("TRSRY_AR")]
		[ColumnEnum("TRSRY_AR", typeof(System.String), System.Data.DbType.String, false, false, false, 150)]
		TrsryAr = 2,
		/// <summary>
		/// TrsryEn : 
		/// </summary>
		[EnumTextValue("TRSRY_EN")]
		[ColumnEnum("TRSRY_EN", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		TrsryEn = 3
	}//End enum

	#endregion FeeCdeTrsryColumn Enum

} // end namespace