﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file AdmDecisionStatus.cs instead.
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
	/// An object representation of the 'Adm_Decision_Status' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class AdmDecisionStatusBase : EntityBase, IAdmDecisionStatus, IEntityId<AdmDecisionStatusKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private AdmDecisionStatusEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private AdmDecisionStatusEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private AdmDecisionStatusEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<AdmDecisionStatus> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event AdmDecisionStatusEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event AdmDecisionStatusEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="AdmDecisionStatusBase"/> instance.
		///</summary>
		public AdmDecisionStatusBase()
		{
			this.entityData = new AdmDecisionStatusEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="AdmDecisionStatusBase"/> instance.
		///</summary>
		///<param name="_descrAr"></param>
		///<param name="_descrEn"></param>
		public AdmDecisionStatusBase(System.String _descrAr, System.String _descrEn)
		{
			this.entityData = new AdmDecisionStatusEntityData();
			this.backupData = null;

			this.DescrAr = _descrAr;
			this.DescrEn = _descrEn;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="AdmDecisionStatus"/> instance.
		///</summary>
		///<param name="_descrAr"></param>
		///<param name="_descrEn"></param>
		public static AdmDecisionStatus CreateAdmDecisionStatus(System.String _descrAr, System.String _descrEn)
		{
			AdmDecisionStatus newAdmDecisionStatus = new AdmDecisionStatus();
			newAdmDecisionStatus.DescrAr = _descrAr;
			newAdmDecisionStatus.DescrEn = _descrEn;
			return newAdmDecisionStatus;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the AdmDecisionStatusId property. 
		///		
		/// </summary>
		/// <value>This type is numeric.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>




		[ReadOnlyAttribute(false)/*, XmlIgnoreAttribute()*/, DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, true, false)]
		public virtual System.Decimal AdmDecisionStatusId
		{
			get
			{
				return this.entityData.AdmDecisionStatusId; 
			}
			
			set
			{
				if (this.entityData.AdmDecisionStatusId == value)
					return;
					
				OnColumnChanging(AdmDecisionStatusColumn.AdmDecisionStatusId, this.entityData.AdmDecisionStatusId);
				this.entityData.AdmDecisionStatusId = value;
				this.EntityId.AdmDecisionStatusId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmDecisionStatusColumn.AdmDecisionStatusId, this.entityData.AdmDecisionStatusId);
				OnPropertyChanged("AdmDecisionStatusId");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the DescrAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 150)]
		public virtual System.String DescrAr
		{
			get
			{
				return this.entityData.DescrAr; 
			}
			
			set
			{
				if (this.entityData.DescrAr == value)
					return;
					
				OnColumnChanging(AdmDecisionStatusColumn.DescrAr, this.entityData.DescrAr);
				this.entityData.DescrAr = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmDecisionStatusColumn.DescrAr, this.entityData.DescrAr);
				OnPropertyChanged("DescrAr");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the DescrEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 150)]
		public virtual System.String DescrEn
		{
			get
			{
				return this.entityData.DescrEn; 
			}
			
			set
			{
				if (this.entityData.DescrEn == value)
					return;
					
				OnColumnChanging(AdmDecisionStatusColumn.DescrEn, this.entityData.DescrEn);
				this.entityData.DescrEn = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmDecisionStatusColumn.DescrEn, this.entityData.DescrEn);
				OnPropertyChanged("DescrEn");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
	
		/// <summary>
		///	Holds a collection of AdmAppRegHistory objects
		///	which are related to this object through the relation FK_ADM_APP_REG_HISTORY_Adm_Decision_Status
		/// </summary>	
		[System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
		public virtual TList<AdmAppRegHistory> AdmAppRegHistoryCollection
		{
			get { return entityData.AdmAppRegHistoryCollection; }
			set { entityData.AdmAppRegHistoryCollection = value; }	
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
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("DescrAr", "Descr Ar", 150));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("DescrEn", "Descr En", 150));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "Adm_Decision_Status"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"Adm_Decision_Status_Id", "DESCR_AR", "DESCR_EN"};
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
	            this.backupData = this.entityData.Clone() as AdmDecisionStatusEntityData;
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
						this.parentCollection.Remove( (AdmDecisionStatus) this ) ;
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
	            this.parentCollection = value as TList<AdmDecisionStatus>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as AdmDecisionStatus);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed AdmDecisionStatus Entity 
		///</summary>
		protected virtual AdmDecisionStatus Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			AdmDecisionStatus copy = new AdmDecisionStatus();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.AdmDecisionStatusId = this.AdmDecisionStatusId;
				copy.DescrAr = this.DescrAr;
				copy.DescrEn = this.DescrEn;
			
		
			//deep copy nested objects
			copy.AdmAppRegHistoryCollection = (TList<AdmAppRegHistory>) MakeCopyOf(this.AdmAppRegHistoryCollection, existingCopies); 
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed AdmDecisionStatus Entity 
		///</summary>
		public virtual AdmDecisionStatus Copy()
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
		///  Returns a Typed AdmDecisionStatus Entity which is a deep copy of the current entity.
		///</summary>
		public virtual AdmDecisionStatus DeepCopy()
		{
			return EntityHelper.Clone<AdmDecisionStatus>(this as AdmDecisionStatus);	
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
				this.entityData = this._originalData.Clone() as AdmDecisionStatusEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new AdmDecisionStatusEntityData();
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
			this._originalData = this.entityData.Clone() as AdmDecisionStatusEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(AdmDecisionStatusColumn column)
		{
			switch(column)
			{
					case AdmDecisionStatusColumn.AdmDecisionStatusId:
					return entityData.AdmDecisionStatusId != _originalData.AdmDecisionStatusId;
					case AdmDecisionStatusColumn.DescrAr:
					return entityData.DescrAr != _originalData.DescrAr;
					case AdmDecisionStatusColumn.DescrEn:
					return entityData.DescrEn != _originalData.DescrEn;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< AdmDecisionStatusColumn >(columnName));
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
			result = result || entityData.AdmDecisionStatusId != _originalData.AdmDecisionStatusId;
			result = result || entityData.DescrAr != _originalData.DescrAr;
			result = result || entityData.DescrEn != _originalData.DescrEn;
			return result;
		}	
		
		///<summary>
		///  Returns a AdmDecisionStatus Entity with the original data.
		///</summary>
		public AdmDecisionStatus GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateAdmDecisionStatus(
				_originalData.DescrAr,
				_originalData.DescrEn
				);
				
			return (AdmDecisionStatus)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="AdmDecisionStatusBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is AdmDecisionStatusBase)
				return ValueEquals(this, (AdmDecisionStatusBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="AdmDecisionStatusBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.AdmDecisionStatusId.GetHashCode() ^ 
					((this.DescrAr == null) ? string.Empty : this.DescrAr.ToString()).GetHashCode() ^ 
					((this.DescrEn == null) ? string.Empty : this.DescrEn.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="AdmDecisionStatusBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(AdmDecisionStatusBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="AdmDecisionStatusBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="AdmDecisionStatusBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="AdmDecisionStatusBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(AdmDecisionStatusBase Object1, AdmDecisionStatusBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.AdmDecisionStatusId != Object2.AdmDecisionStatusId)
				equal = false;
			if ( Object1.DescrAr != null && Object2.DescrAr != null )
			{
				if (Object1.DescrAr != Object2.DescrAr)
					equal = false;
			}
			else if (Object1.DescrAr == null ^ Object2.DescrAr == null )
			{
				equal = false;
			}
			if ( Object1.DescrEn != null && Object2.DescrEn != null )
			{
				if (Object1.DescrEn != Object2.DescrEn)
					equal = false;
			}
			else if (Object1.DescrEn == null ^ Object2.DescrEn == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((AdmDecisionStatusBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static AdmDecisionStatusComparer GetComparer()
        {
            return new AdmDecisionStatusComparer();
        }
        */

        // Comparer delegates back to AdmDecisionStatus
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
        public int CompareTo(AdmDecisionStatus rhs, AdmDecisionStatusColumn which)
        {
            switch (which)
            {
            	
            	
            	case AdmDecisionStatusColumn.AdmDecisionStatusId:
            		return this.AdmDecisionStatusId.CompareTo(rhs.AdmDecisionStatusId);
            		
            		                 
            	
            	
            	case AdmDecisionStatusColumn.DescrAr:
            		return this.DescrAr.CompareTo(rhs.DescrAr);
            		
            		                 
            	
            	
            	case AdmDecisionStatusColumn.DescrEn:
            		return this.DescrEn.CompareTo(rhs.DescrEn);
            		
            		                 
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
				
		#region IEntityKey<AdmDecisionStatusKey> Members
		
		// member variable for the EntityId property
		private AdmDecisionStatusKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual AdmDecisionStatusKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new AdmDecisionStatusKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("AdmDecisionStatus")
					.Append("|").Append( this.AdmDecisionStatusId.ToString()).ToString();
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
				"{4}{3}- AdmDecisionStatusId: {0}{3}- DescrAr: {1}{3}- DescrEn: {2}{3}{5}", 
				this.AdmDecisionStatusId,
				(this.DescrAr == null) ? string.Empty : this.DescrAr.ToString(),
				(this.DescrEn == null) ? string.Empty : this.DescrEn.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'Adm_Decision_Status' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class AdmDecisionStatusEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// Adm_Decision_Status_Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Adm_Decision_Status"</remarks>
		public System.Decimal AdmDecisionStatusId;
			
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		public System.String		  DescrAr = null;
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		public System.String		  DescrEn = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#region AdmAppRegHistoryCollection
		
		private TList<AdmAppRegHistory> _admAppRegHistoryAdmDecisionStatusId;
		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAdmDecisionStatusId
		/// </summary>
		
		public TList<AdmAppRegHistory> AdmAppRegHistoryCollection
		{
			get
			{
				if (_admAppRegHistoryAdmDecisionStatusId == null)
				{
				_admAppRegHistoryAdmDecisionStatusId = new TList<AdmAppRegHistory>();
				}
	
				return _admAppRegHistoryAdmDecisionStatusId;
			}
			set { _admAppRegHistoryAdmDecisionStatusId = value; }
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
			AdmDecisionStatusEntityData _tmp = new AdmDecisionStatusEntityData();
						
			_tmp.AdmDecisionStatusId = this.AdmDecisionStatusId;
			
			_tmp.DescrAr = this.DescrAr;
			_tmp.DescrEn = this.DescrEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			if (this._admAppRegHistoryAdmDecisionStatusId != null)
				_tmp.AdmAppRegHistoryCollection = (TList<AdmAppRegHistory>) MakeCopyOf(this.AdmAppRegHistoryCollection); 
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
				
			AdmDecisionStatusEntityData _tmp = new AdmDecisionStatusEntityData();
						
			_tmp.AdmDecisionStatusId = this.AdmDecisionStatusId;
			
			_tmp.DescrAr = this.DescrAr;
			_tmp.DescrEn = this.DescrEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			_tmp.AdmAppRegHistoryCollection = (TList<AdmAppRegHistory>) MakeCopyOf(this.AdmAppRegHistoryCollection, existingCopies); 
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
		/// <param name="column">The <see cref="AdmDecisionStatusColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(AdmDecisionStatusColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmDecisionStatusColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(AdmDecisionStatusColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmDecisionStatusColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(AdmDecisionStatusColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				AdmDecisionStatusEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new AdmDecisionStatusEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmDecisionStatusColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(AdmDecisionStatusColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				AdmDecisionStatusEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new AdmDecisionStatusEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region AdmDecisionStatusEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="AdmDecisionStatus"/> object.
	/// </remarks>
	public class AdmDecisionStatusEventArgs : System.EventArgs
	{
		private AdmDecisionStatusColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the AdmDecisionStatusEventArgs class.
		///</summary>
		public AdmDecisionStatusEventArgs(AdmDecisionStatusColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the AdmDecisionStatusEventArgs class.
		///</summary>
		public AdmDecisionStatusEventArgs(AdmDecisionStatusColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The AdmDecisionStatusColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="AdmDecisionStatusColumn" />
		public AdmDecisionStatusColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all AdmDecisionStatus related events.
	///</summary>
	public delegate void AdmDecisionStatusEventHandler(object sender, AdmDecisionStatusEventArgs e);
	
	#region AdmDecisionStatusComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class AdmDecisionStatusComparer : System.Collections.Generic.IComparer<AdmDecisionStatus>
	{
		AdmDecisionStatusColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:AdmDecisionStatusComparer"/> class.
        /// </summary>
		public AdmDecisionStatusComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:AdmDecisionStatusComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public AdmDecisionStatusComparer(AdmDecisionStatusColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="AdmDecisionStatus"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="AdmDecisionStatus"/> to compare.</param>
        /// <param name="b">The second <c>AdmDecisionStatus</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(AdmDecisionStatus a, AdmDecisionStatus b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(AdmDecisionStatus entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(AdmDecisionStatus a, AdmDecisionStatus b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public AdmDecisionStatusColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region AdmDecisionStatusKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="AdmDecisionStatus"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class AdmDecisionStatusKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the AdmDecisionStatusKey class.
		/// </summary>
		public AdmDecisionStatusKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the AdmDecisionStatusKey class.
		/// </summary>
		public AdmDecisionStatusKey(AdmDecisionStatusBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.AdmDecisionStatusId = entity.AdmDecisionStatusId;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the AdmDecisionStatusKey class.
		/// </summary>
		public AdmDecisionStatusKey(System.Decimal _admDecisionStatusId)
		{
			#region Init Properties

			this.AdmDecisionStatusId = _admDecisionStatusId;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private AdmDecisionStatusBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public AdmDecisionStatusBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the AdmDecisionStatusId property
		private System.Decimal _admDecisionStatusId;
		
		/// <summary>
		/// Gets or sets the AdmDecisionStatusId property.
		/// </summary>
		public System.Decimal AdmDecisionStatusId
		{
			get { return _admDecisionStatusId; }
			set
			{
				if ( this.Entity != null )
					this.Entity.AdmDecisionStatusId = value;
				
				_admDecisionStatusId = value;
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
				AdmDecisionStatusId = ( values["AdmDecisionStatusId"] != null ) ? (System.Decimal) EntityUtil.ChangeType(values["AdmDecisionStatusId"], typeof(System.Decimal)) : 0.0m;
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

			values.Add("AdmDecisionStatusId", AdmDecisionStatusId);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("AdmDecisionStatusId: {0}{1}",
								AdmDecisionStatusId,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region AdmDecisionStatusColumn Enum
	
	/// <summary>
	/// Enumerate the AdmDecisionStatus columns.
	/// </summary>
	[Serializable]
	public enum AdmDecisionStatusColumn : int
	{
		/// <summary>
		/// AdmDecisionStatusId : 
		/// </summary>
		[EnumTextValue("Adm_Decision_Status_Id")]
		[ColumnEnum("Adm_Decision_Status_Id", typeof(System.Decimal), System.Data.DbType.Decimal, true, true, false)]
		AdmDecisionStatusId = 1,
		/// <summary>
		/// DescrAr : 
		/// </summary>
		[EnumTextValue("DESCR_AR")]
		[ColumnEnum("DESCR_AR", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		DescrAr = 2,
		/// <summary>
		/// DescrEn : 
		/// </summary>
		[EnumTextValue("DESCR_EN")]
		[ColumnEnum("DESCR_EN", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		DescrEn = 3
	}//End enum

	#endregion AdmDecisionStatusColumn Enum

} // end namespace