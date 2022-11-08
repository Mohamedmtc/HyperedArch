﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file AdmCdeMedia.cs instead.
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
	/// An object representation of the 'ADM_CDE_MEDIA' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class AdmCdeMediaBase : EntityBase, IAdmCdeMedia, IEntityId<AdmCdeMediaKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private AdmCdeMediaEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private AdmCdeMediaEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private AdmCdeMediaEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<AdmCdeMedia> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event AdmCdeMediaEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event AdmCdeMediaEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="AdmCdeMediaBase"/> instance.
		///</summary>
		public AdmCdeMediaBase()
		{
			this.entityData = new AdmCdeMediaEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="AdmCdeMediaBase"/> instance.
		///</summary>
		///<param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		///<param name="_mediaAr"></param>
		///<param name="_mediaEn"></param>
		public AdmCdeMediaBase(System.Int32 _admCdeMediaId, System.String _mediaAr, System.String _mediaEn)
		{
			this.entityData = new AdmCdeMediaEntityData();
			this.backupData = null;

			this.AdmCdeMediaId = _admCdeMediaId;
			this.MediaAr = _mediaAr;
			this.MediaEn = _mediaEn;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="AdmCdeMedia"/> instance.
		///</summary>
		///<param name="_admCdeMediaId">طريقة التعرف على الجامعة</param>
		///<param name="_mediaAr"></param>
		///<param name="_mediaEn"></param>
		public static AdmCdeMedia CreateAdmCdeMedia(System.Int32 _admCdeMediaId, System.String _mediaAr, System.String _mediaEn)
		{
			AdmCdeMedia newAdmCdeMedia = new AdmCdeMedia();
			newAdmCdeMedia.AdmCdeMediaId = _admCdeMediaId;
			newAdmCdeMedia.MediaAr = _mediaAr;
			newAdmCdeMedia.MediaEn = _mediaEn;
			return newAdmCdeMedia;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the AdmCdeMediaId property. 
		///		طريقة التعرف على الجامعة
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>




		[DescriptionAttribute(@"طريقة التعرف على الجامعة"), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false)]
		public virtual System.Int32 AdmCdeMediaId
		{
			get
			{
				return this.entityData.AdmCdeMediaId; 
			}
			
			set
			{
				if (this.entityData.AdmCdeMediaId == value)
					return;
					
				OnColumnChanging(AdmCdeMediaColumn.AdmCdeMediaId, this.entityData.AdmCdeMediaId);
				this.entityData.AdmCdeMediaId = value;
				this.EntityId.AdmCdeMediaId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmCdeMediaColumn.AdmCdeMediaId, this.entityData.AdmCdeMediaId);
				OnPropertyChanged("AdmCdeMediaId");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the ADM_CDE_MEDIA_ID property.
		///		طريقة التعرف على الجامعة
		/// </summary>
		/// <remarks>This is the original value of the ADM_CDE_MEDIA_ID property.</remarks>
		/// <value>This type is int</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.Int32 OriginalAdmCdeMediaId
		{
			get { return this.entityData.OriginalAdmCdeMediaId; }
			set { this.entityData.OriginalAdmCdeMediaId = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the MediaAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 150)]
		public virtual System.String MediaAr
		{
			get
			{
				return this.entityData.MediaAr; 
			}
			
			set
			{
				if (this.entityData.MediaAr == value)
					return;
					
				OnColumnChanging(AdmCdeMediaColumn.MediaAr, this.entityData.MediaAr);
				this.entityData.MediaAr = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmCdeMediaColumn.MediaAr, this.entityData.MediaAr);
				OnPropertyChanged("MediaAr");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the MediaEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 150)]
		public virtual System.String MediaEn
		{
			get
			{
				return this.entityData.MediaEn; 
			}
			
			set
			{
				if (this.entityData.MediaEn == value)
					return;
					
				OnColumnChanging(AdmCdeMediaColumn.MediaEn, this.entityData.MediaEn);
				this.entityData.MediaEn = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(AdmCdeMediaColumn.MediaEn, this.entityData.MediaEn);
				OnPropertyChanged("MediaEn");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
	
		/// <summary>
		///	Holds a collection of AdmAppMedia objects
		///	which are related to this object through the relation FK_ADM_APP_MEDIA_ADM_CDE_MEDIA
		/// </summary>	
		[System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
		public virtual TList<AdmAppMedia> AdmAppMediaCollection
		{
			get { return entityData.AdmAppMediaCollection; }
			set { entityData.AdmAppMediaCollection = value; }	
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
				new CommonRules.MaxLengthRuleArgs("MediaAr", "Media Ar", 150));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MediaEn", "Media En", 150));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "ADM_CDE_MEDIA"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"ADM_CDE_MEDIA_ID", "MEDIA_AR", "MEDIA_EN"};
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
	            this.backupData = this.entityData.Clone() as AdmCdeMediaEntityData;
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
						this.parentCollection.Remove( (AdmCdeMedia) this ) ;
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
	            this.parentCollection = value as TList<AdmCdeMedia>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as AdmCdeMedia);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed AdmCdeMedia Entity 
		///</summary>
		protected virtual AdmCdeMedia Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			AdmCdeMedia copy = new AdmCdeMedia();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.AdmCdeMediaId = this.AdmCdeMediaId;
					copy.OriginalAdmCdeMediaId = this.OriginalAdmCdeMediaId;
				copy.MediaAr = this.MediaAr;
				copy.MediaEn = this.MediaEn;
			
		
			//deep copy nested objects
			copy.AdmAppMediaCollection = (TList<AdmAppMedia>) MakeCopyOf(this.AdmAppMediaCollection, existingCopies); 
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed AdmCdeMedia Entity 
		///</summary>
		public virtual AdmCdeMedia Copy()
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
		///  Returns a Typed AdmCdeMedia Entity which is a deep copy of the current entity.
		///</summary>
		public virtual AdmCdeMedia DeepCopy()
		{
			return EntityHelper.Clone<AdmCdeMedia>(this as AdmCdeMedia);	
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
				this.entityData = this._originalData.Clone() as AdmCdeMediaEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new AdmCdeMediaEntityData();
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
			this._originalData = this.entityData.Clone() as AdmCdeMediaEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(AdmCdeMediaColumn column)
		{
			switch(column)
			{
					case AdmCdeMediaColumn.AdmCdeMediaId:
					return entityData.AdmCdeMediaId != _originalData.AdmCdeMediaId;
					case AdmCdeMediaColumn.MediaAr:
					return entityData.MediaAr != _originalData.MediaAr;
					case AdmCdeMediaColumn.MediaEn:
					return entityData.MediaEn != _originalData.MediaEn;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< AdmCdeMediaColumn >(columnName));
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
			result = result || entityData.AdmCdeMediaId != _originalData.AdmCdeMediaId;
			result = result || entityData.MediaAr != _originalData.MediaAr;
			result = result || entityData.MediaEn != _originalData.MediaEn;
			return result;
		}	
		
		///<summary>
		///  Returns a AdmCdeMedia Entity with the original data.
		///</summary>
		public AdmCdeMedia GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateAdmCdeMedia(
				_originalData.AdmCdeMediaId,
				_originalData.MediaAr,
				_originalData.MediaEn
				);
				
			return (AdmCdeMedia)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="AdmCdeMediaBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is AdmCdeMediaBase)
				return ValueEquals(this, (AdmCdeMediaBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="AdmCdeMediaBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.AdmCdeMediaId.GetHashCode() ^ 
					((this.MediaAr == null) ? string.Empty : this.MediaAr.ToString()).GetHashCode() ^ 
					((this.MediaEn == null) ? string.Empty : this.MediaEn.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="AdmCdeMediaBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(AdmCdeMediaBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="AdmCdeMediaBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="AdmCdeMediaBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="AdmCdeMediaBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(AdmCdeMediaBase Object1, AdmCdeMediaBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.AdmCdeMediaId != Object2.AdmCdeMediaId)
				equal = false;
			if ( Object1.MediaAr != null && Object2.MediaAr != null )
			{
				if (Object1.MediaAr != Object2.MediaAr)
					equal = false;
			}
			else if (Object1.MediaAr == null ^ Object2.MediaAr == null )
			{
				equal = false;
			}
			if ( Object1.MediaEn != null && Object2.MediaEn != null )
			{
				if (Object1.MediaEn != Object2.MediaEn)
					equal = false;
			}
			else if (Object1.MediaEn == null ^ Object2.MediaEn == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((AdmCdeMediaBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static AdmCdeMediaComparer GetComparer()
        {
            return new AdmCdeMediaComparer();
        }
        */

        // Comparer delegates back to AdmCdeMedia
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
        public int CompareTo(AdmCdeMedia rhs, AdmCdeMediaColumn which)
        {
            switch (which)
            {
            	
            	
            	case AdmCdeMediaColumn.AdmCdeMediaId:
            		return this.AdmCdeMediaId.CompareTo(rhs.AdmCdeMediaId);
            		
            		                 
            	
            	
            	case AdmCdeMediaColumn.MediaAr:
            		return this.MediaAr.CompareTo(rhs.MediaAr);
            		
            		                 
            	
            	
            	case AdmCdeMediaColumn.MediaEn:
            		return this.MediaEn.CompareTo(rhs.MediaEn);
            		
            		                 
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
				
		#region IEntityKey<AdmCdeMediaKey> Members
		
		// member variable for the EntityId property
		private AdmCdeMediaKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual AdmCdeMediaKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new AdmCdeMediaKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("AdmCdeMedia")
					.Append("|").Append( this.AdmCdeMediaId.ToString()).ToString();
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
				"{4}{3}- AdmCdeMediaId: {0}{3}- MediaAr: {1}{3}- MediaEn: {2}{3}{5}", 
				this.AdmCdeMediaId,
				(this.MediaAr == null) ? string.Empty : this.MediaAr.ToString(),
				(this.MediaEn == null) ? string.Empty : this.MediaEn.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'ADM_CDE_MEDIA' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class AdmCdeMediaEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// ADM_CDE_MEDIA_ID : طريقة التعرف على الجامعة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_CDE_MEDIA"</remarks>
		public System.Int32 AdmCdeMediaId;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.Int32 OriginalAdmCdeMediaId;
		
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// MEDIA_AR : 
		/// </summary>
		public System.String		  MediaAr = null;
		
		/// <summary>
		/// MEDIA_EN : 
		/// </summary>
		public System.String		  MediaEn = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#region AdmAppMediaCollection
		
		private TList<AdmAppMedia> _admAppMediaAdmCdeMediaId;
		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppMediaAdmCdeMediaId
		/// </summary>
		
		public TList<AdmAppMedia> AdmAppMediaCollection
		{
			get
			{
				if (_admAppMediaAdmCdeMediaId == null)
				{
				_admAppMediaAdmCdeMediaId = new TList<AdmAppMedia>();
				}
	
				return _admAppMediaAdmCdeMediaId;
			}
			set { _admAppMediaAdmCdeMediaId = value; }
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
			AdmCdeMediaEntityData _tmp = new AdmCdeMediaEntityData();
						
			_tmp.AdmCdeMediaId = this.AdmCdeMediaId;
			_tmp.OriginalAdmCdeMediaId = this.OriginalAdmCdeMediaId;
			
			_tmp.MediaAr = this.MediaAr;
			_tmp.MediaEn = this.MediaEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			if (this._admAppMediaAdmCdeMediaId != null)
				_tmp.AdmAppMediaCollection = (TList<AdmAppMedia>) MakeCopyOf(this.AdmAppMediaCollection); 
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
				
			AdmCdeMediaEntityData _tmp = new AdmCdeMediaEntityData();
						
			_tmp.AdmCdeMediaId = this.AdmCdeMediaId;
			_tmp.OriginalAdmCdeMediaId = this.OriginalAdmCdeMediaId;
			
			_tmp.MediaAr = this.MediaAr;
			_tmp.MediaEn = this.MediaEn;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			_tmp.AdmAppMediaCollection = (TList<AdmAppMedia>) MakeCopyOf(this.AdmAppMediaCollection, existingCopies); 
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
		/// <param name="column">The <see cref="AdmCdeMediaColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(AdmCdeMediaColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmCdeMediaColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(AdmCdeMediaColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmCdeMediaColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(AdmCdeMediaColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				AdmCdeMediaEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new AdmCdeMediaEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="AdmCdeMediaColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(AdmCdeMediaColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				AdmCdeMediaEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new AdmCdeMediaEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region AdmCdeMediaEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="AdmCdeMedia"/> object.
	/// </remarks>
	public class AdmCdeMediaEventArgs : System.EventArgs
	{
		private AdmCdeMediaColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the AdmCdeMediaEventArgs class.
		///</summary>
		public AdmCdeMediaEventArgs(AdmCdeMediaColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the AdmCdeMediaEventArgs class.
		///</summary>
		public AdmCdeMediaEventArgs(AdmCdeMediaColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The AdmCdeMediaColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="AdmCdeMediaColumn" />
		public AdmCdeMediaColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all AdmCdeMedia related events.
	///</summary>
	public delegate void AdmCdeMediaEventHandler(object sender, AdmCdeMediaEventArgs e);
	
	#region AdmCdeMediaComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class AdmCdeMediaComparer : System.Collections.Generic.IComparer<AdmCdeMedia>
	{
		AdmCdeMediaColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:AdmCdeMediaComparer"/> class.
        /// </summary>
		public AdmCdeMediaComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:AdmCdeMediaComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public AdmCdeMediaComparer(AdmCdeMediaColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="AdmCdeMedia"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="AdmCdeMedia"/> to compare.</param>
        /// <param name="b">The second <c>AdmCdeMedia</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(AdmCdeMedia a, AdmCdeMedia b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(AdmCdeMedia entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(AdmCdeMedia a, AdmCdeMedia b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public AdmCdeMediaColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region AdmCdeMediaKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="AdmCdeMedia"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class AdmCdeMediaKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaKey class.
		/// </summary>
		public AdmCdeMediaKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaKey class.
		/// </summary>
		public AdmCdeMediaKey(AdmCdeMediaBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.AdmCdeMediaId = entity.AdmCdeMediaId;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the AdmCdeMediaKey class.
		/// </summary>
		public AdmCdeMediaKey(System.Int32 _admCdeMediaId)
		{
			#region Init Properties

			this.AdmCdeMediaId = _admCdeMediaId;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private AdmCdeMediaBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public AdmCdeMediaBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the AdmCdeMediaId property
		private System.Int32 _admCdeMediaId;
		
		/// <summary>
		/// Gets or sets the AdmCdeMediaId property.
		/// </summary>
		public System.Int32 AdmCdeMediaId
		{
			get { return _admCdeMediaId; }
			set
			{
				if ( this.Entity != null )
					this.Entity.AdmCdeMediaId = value;
				
				_admCdeMediaId = value;
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
				AdmCdeMediaId = ( values["AdmCdeMediaId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["AdmCdeMediaId"], typeof(System.Int32)) : (int)0;
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

			values.Add("AdmCdeMediaId", AdmCdeMediaId);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("AdmCdeMediaId: {0}{1}",
								AdmCdeMediaId,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region AdmCdeMediaColumn Enum
	
	/// <summary>
	/// Enumerate the AdmCdeMedia columns.
	/// </summary>
	[Serializable]
	public enum AdmCdeMediaColumn : int
	{
		/// <summary>
		/// AdmCdeMediaId : طريقة التعرف على الجامعة
		/// </summary>
		[EnumTextValue("ADM_CDE_MEDIA_ID")]
		[ColumnEnum("ADM_CDE_MEDIA_ID", typeof(System.Int32), System.Data.DbType.Int32, true, false, false)]
		AdmCdeMediaId = 1,
		/// <summary>
		/// MediaAr : 
		/// </summary>
		[EnumTextValue("MEDIA_AR")]
		[ColumnEnum("MEDIA_AR", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		MediaAr = 2,
		/// <summary>
		/// MediaEn : 
		/// </summary>
		[EnumTextValue("MEDIA_EN")]
		[ColumnEnum("MEDIA_EN", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		MediaEn = 3
	}//End enum

	#endregion AdmCdeMediaColumn Enum

} // end namespace