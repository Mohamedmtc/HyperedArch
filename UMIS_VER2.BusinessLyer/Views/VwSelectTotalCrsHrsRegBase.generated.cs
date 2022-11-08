﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwSelectTotalCrsHrsReg.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace UMIS_VER2.BusinessLyer
{
	///<summary>
	/// An object representation of the 'Vw_SelectTotalCrsHrsReg' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwSelectTotalCrsHrsRegBase")]
	public abstract partial class VwSelectTotalCrsHrsRegBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// AccumRegHrs : 
		/// </summary>
		private System.Decimal?		  _accumRegHrs = null;
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		private System.Decimal		  _edStudId = 0.0m;
		
		/// <summary>
		/// Faculty : 
		/// </summary>
		private System.Decimal?		  _faculty = null;
		
		/// <summary>
		/// GradRegHrs : 
		/// </summary>
		private System.Decimal?		  _gradRegHrs = null;
		
		/// <summary>
		/// InCompleteCourse : 
		/// </summary>
		private System.Decimal?		  _inCompleteCourse = null;
		
		/// <summary>
		/// RegsHrs_LastSemester : 
		/// </summary>
		private System.Decimal?		  _regsHrsLastSemester = null;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="VwSelectTotalCrsHrsRegBase"/> instance.
		///</summary>
		public VwSelectTotalCrsHrsRegBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwSelectTotalCrsHrsRegBase"/> instance.
		///</summary>
		///<param name="_accumRegHrs"></param>
		///<param name="_edStudId"></param>
		///<param name="_faculty"></param>
		///<param name="_gradRegHrs"></param>
		///<param name="_inCompleteCourse"></param>
		///<param name="_regsHrsLastSemester"></param>
		public VwSelectTotalCrsHrsRegBase(System.Decimal? _accumRegHrs, System.Decimal _edStudId, System.Decimal? _faculty, System.Decimal? _gradRegHrs, System.Decimal? _inCompleteCourse, System.Decimal? _regsHrsLastSemester)
		{
			this._accumRegHrs = _accumRegHrs;
			this._edStudId = _edStudId;
			this._faculty = _faculty;
			this._gradRegHrs = _gradRegHrs;
			this._inCompleteCourse = _inCompleteCourse;
			this._regsHrsLastSemester = _regsHrsLastSemester;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwSelectTotalCrsHrsReg"/> instance.
		///</summary>
		///<param name="_accumRegHrs"></param>
		///<param name="_edStudId"></param>
		///<param name="_faculty"></param>
		///<param name="_gradRegHrs"></param>
		///<param name="_inCompleteCourse"></param>
		///<param name="_regsHrsLastSemester"></param>
		public static VwSelectTotalCrsHrsReg CreateVwSelectTotalCrsHrsReg(System.Decimal? _accumRegHrs, System.Decimal _edStudId, System.Decimal? _faculty, System.Decimal? _gradRegHrs, System.Decimal? _inCompleteCourse, System.Decimal? _regsHrsLastSemester)
		{
			VwSelectTotalCrsHrsReg newVwSelectTotalCrsHrsReg = new VwSelectTotalCrsHrsReg();
			newVwSelectTotalCrsHrsReg.AccumRegHrs = _accumRegHrs;
			newVwSelectTotalCrsHrsReg.EdStudId = _edStudId;
			newVwSelectTotalCrsHrsReg.Faculty = _faculty;
			newVwSelectTotalCrsHrsReg.GradRegHrs = _gradRegHrs;
			newVwSelectTotalCrsHrsReg.InCompleteCourse = _inCompleteCourse;
			newVwSelectTotalCrsHrsReg.RegsHrsLastSemester = _regsHrsLastSemester;
			return newVwSelectTotalCrsHrsReg;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the AccumRegHrs property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsAccumRegHrsNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? AccumRegHrs
		{
			get
			{
				return this._accumRegHrs; 
			}
			set
			{
				if (_accumRegHrs == value && AccumRegHrs != null )
					return;
					
				this._accumRegHrs = value;
				this._isDirty = true;
				
				OnPropertyChanged("AccumRegHrs");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ED_STUD_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal EdStudId
		{
			get
			{
				return this._edStudId; 
			}
			set
			{
				if (_edStudId == value)
					return;
					
				this._edStudId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EdStudId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Faculty property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsFacultyNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? Faculty
		{
			get
			{
				return this._faculty; 
			}
			set
			{
				if (_faculty == value && Faculty != null )
					return;
					
				this._faculty = value;
				this._isDirty = true;
				
				OnPropertyChanged("Faculty");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GradRegHrs property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsGradRegHrsNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? GradRegHrs
		{
			get
			{
				return this._gradRegHrs; 
			}
			set
			{
				if (_gradRegHrs == value && GradRegHrs != null )
					return;
					
				this._gradRegHrs = value;
				this._isDirty = true;
				
				OnPropertyChanged("GradRegHrs");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the InCompleteCourse property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsInCompleteCourseNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? InCompleteCourse
		{
			get
			{
				return this._inCompleteCourse; 
			}
			set
			{
				if (_inCompleteCourse == value && InCompleteCourse != null )
					return;
					
				this._inCompleteCourse = value;
				this._isDirty = true;
				
				OnPropertyChanged("InCompleteCourse");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the RegsHrs_LastSemester property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsRegsHrsLastSemesterNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? RegsHrsLastSemester
		{
			get
			{
				return this._regsHrsLastSemester; 
			}
			set
			{
				if (_regsHrsLastSemester == value && RegsHrsLastSemester != null )
					return;
					
				this._regsHrsLastSemester = value;
				this._isDirty = true;
				
				OnPropertyChanged("RegsHrsLastSemester");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "Vw_SelectTotalCrsHrsReg"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed VwSelectTotalCrsHrsRegBase Entity 
		///</summary>
		public virtual VwSelectTotalCrsHrsRegBase Copy()
		{
			//shallow copy entity
			VwSelectTotalCrsHrsReg copy = new VwSelectTotalCrsHrsReg();
				copy.AccumRegHrs = this.AccumRegHrs;
				copy.EdStudId = this.EdStudId;
				copy.Faculty = this.Faculty;
				copy.GradRegHrs = this.GradRegHrs;
				copy.InCompleteCourse = this.InCompleteCourse;
				copy.RegsHrsLastSemester = this.RegsHrsLastSemester;
			copy.AcceptChanges();
			return (VwSelectTotalCrsHrsReg)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="VwSelectTotalCrsHrsRegBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwSelectTotalCrsHrsRegBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwSelectTotalCrsHrsRegBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwSelectTotalCrsHrsRegBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwSelectTotalCrsHrsRegBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwSelectTotalCrsHrsRegBase Object1, VwSelectTotalCrsHrsRegBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.AccumRegHrs != null && Object2.AccumRegHrs != null )
			{
				if (Object1.AccumRegHrs != Object2.AccumRegHrs)
					equal = false;
			}
			else if (Object1.AccumRegHrs == null ^ Object1.AccumRegHrs == null )
			{
				equal = false;
			}
			if (Object1.EdStudId != Object2.EdStudId)
				equal = false;
			if (Object1.Faculty != null && Object2.Faculty != null )
			{
				if (Object1.Faculty != Object2.Faculty)
					equal = false;
			}
			else if (Object1.Faculty == null ^ Object1.Faculty == null )
			{
				equal = false;
			}
			if (Object1.GradRegHrs != null && Object2.GradRegHrs != null )
			{
				if (Object1.GradRegHrs != Object2.GradRegHrs)
					equal = false;
			}
			else if (Object1.GradRegHrs == null ^ Object1.GradRegHrs == null )
			{
				equal = false;
			}
			if (Object1.InCompleteCourse != null && Object2.InCompleteCourse != null )
			{
				if (Object1.InCompleteCourse != Object2.InCompleteCourse)
					equal = false;
			}
			else if (Object1.InCompleteCourse == null ^ Object1.InCompleteCourse == null )
			{
				equal = false;
			}
			if (Object1.RegsHrsLastSemester != null && Object2.RegsHrsLastSemester != null )
			{
				if (Object1.RegsHrsLastSemester != Object2.RegsHrsLastSemester)
					equal = false;
			}
			else if (Object1.RegsHrsLastSemester == null ^ Object1.RegsHrsLastSemester == null )
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
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(VwSelectTotalCrsHrsReg entity, string propertyName)
		{
			switch (propertyName)
			{
				case "AccumRegHrs":
					return entity.AccumRegHrs;
				case "EdStudId":
					return entity.EdStudId;
				case "Faculty":
					return entity.Faculty;
				case "GradRegHrs":
					return entity.GradRegHrs;
				case "InCompleteCourse":
					return entity.InCompleteCourse;
				case "RegsHrsLastSemester":
					return entity.RegsHrsLastSemester;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as VwSelectTotalCrsHrsReg, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{7}{6}- AccumRegHrs: {0}{6}- EdStudId: {1}{6}- Faculty: {2}{6}- GradRegHrs: {3}{6}- InCompleteCourse: {4}{6}- RegsHrsLastSemester: {5}{6}", 
				(this.AccumRegHrs == null) ? string.Empty : this.AccumRegHrs.ToString(),
			     
				this.EdStudId,
				(this.Faculty == null) ? string.Empty : this.Faculty.ToString(),
			     
				(this.GradRegHrs == null) ? string.Empty : this.GradRegHrs.ToString(),
			     
				(this.InCompleteCourse == null) ? string.Empty : this.InCompleteCourse.ToString(),
			     
				(this.RegsHrsLastSemester == null) ? string.Empty : this.RegsHrsLastSemester.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwSelectTotalCrsHrsReg columns.
	/// </summary>
	[Serializable]
	public enum VwSelectTotalCrsHrsRegColumn
	{
		/// <summary>
		/// AccumRegHrs : 
		/// </summary>
		[EnumTextValue("AccumRegHrs")]
		[ColumnEnum("AccumRegHrs", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		AccumRegHrs,
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		[EnumTextValue("ED_STUD_ID")]
		[ColumnEnum("ED_STUD_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		EdStudId,
		/// <summary>
		/// Faculty : 
		/// </summary>
		[EnumTextValue("Faculty")]
		[ColumnEnum("Faculty", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		Faculty,
		/// <summary>
		/// GradRegHrs : 
		/// </summary>
		[EnumTextValue("GradRegHrs")]
		[ColumnEnum("GradRegHrs", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		GradRegHrs,
		/// <summary>
		/// InCompleteCourse : 
		/// </summary>
		[EnumTextValue("InCompleteCourse")]
		[ColumnEnum("InCompleteCourse", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		InCompleteCourse,
		/// <summary>
		/// RegsHrs_LastSemester : 
		/// </summary>
		[EnumTextValue("RegsHrs_LastSemester")]
		[ColumnEnum("RegsHrs_LastSemester", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		RegsHrsLastSemester
	}//End enum

} // end namespace
