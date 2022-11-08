﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VuCourseAssess.cs instead.
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
	/// An object representation of the 'vuCourseAssess' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VuCourseAssessBase")]
	public abstract partial class VuCourseAssessBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		private System.Decimal		  _edAcadYearId = 0.0m;
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		private System.Decimal		  _asFacultyInfoId = 0.0m;
		
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		private System.Decimal?		  _edCodeLevelId = null;
		
		/// <summary>
		/// ED_SEMESTER_OPEN_ID : 
		/// </summary>
		private System.Decimal		  _edSemesterOpenId = 0.0m;
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		private System.Decimal		  _edCourseId = 0.0m;
		
		/// <summary>
		/// CourseCode : 
		/// </summary>
		private System.String		  _courseCode = string.Empty;
		
		/// <summary>
		/// CourseDescEn : 
		/// </summary>
		private System.String		  _courseDescEn = string.Empty;
		
		/// <summary>
		/// CourseDescAr : 
		/// </summary>
		private System.String		  _courseDescAr = string.Empty;
		
		/// <summary>
		/// CourseMax : 
		/// </summary>
		private System.Decimal?		  _courseMax = null;
		
		/// <summary>
		/// CourseMin : 
		/// </summary>
		private System.Decimal?		  _courseMin = null;
		
		/// <summary>
		/// AssessMaxRate : 
		/// </summary>
		private System.Decimal		  _assessMaxRate = 0.0m;
		
		/// <summary>
		/// AssessMinRate : 
		/// </summary>
		private System.Decimal		  _assessMinRate = 0.0m;
		
		/// <summary>
		/// AssessDescEn : 
		/// </summary>
		private System.String		  _assessDescEn = null;
		
		/// <summary>
		/// AssessDescAr : 
		/// </summary>
		private System.String		  _assessDescAr = string.Empty;
		
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
		/// Creates a new <see cref="VuCourseAssessBase"/> instance.
		///</summary>
		public VuCourseAssessBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VuCourseAssessBase"/> instance.
		///</summary>
		///<param name="_edAcadYearId"></param>
		///<param name="_asFacultyInfoId"></param>
		///<param name="_edCodeLevelId"></param>
		///<param name="_edSemesterOpenId"></param>
		///<param name="_edCourseId"></param>
		///<param name="_courseCode"></param>
		///<param name="_courseDescEn"></param>
		///<param name="_courseDescAr"></param>
		///<param name="_courseMax"></param>
		///<param name="_courseMin"></param>
		///<param name="_assessMaxRate"></param>
		///<param name="_assessMinRate"></param>
		///<param name="_assessDescEn"></param>
		///<param name="_assessDescAr"></param>
		public VuCourseAssessBase(System.Decimal _edAcadYearId, System.Decimal _asFacultyInfoId, System.Decimal? _edCodeLevelId, System.Decimal _edSemesterOpenId, System.Decimal _edCourseId, System.String _courseCode, System.String _courseDescEn, System.String _courseDescAr, System.Decimal? _courseMax, System.Decimal? _courseMin, System.Decimal _assessMaxRate, System.Decimal _assessMinRate, System.String _assessDescEn, System.String _assessDescAr)
		{
			this._edAcadYearId = _edAcadYearId;
			this._asFacultyInfoId = _asFacultyInfoId;
			this._edCodeLevelId = _edCodeLevelId;
			this._edSemesterOpenId = _edSemesterOpenId;
			this._edCourseId = _edCourseId;
			this._courseCode = _courseCode;
			this._courseDescEn = _courseDescEn;
			this._courseDescAr = _courseDescAr;
			this._courseMax = _courseMax;
			this._courseMin = _courseMin;
			this._assessMaxRate = _assessMaxRate;
			this._assessMinRate = _assessMinRate;
			this._assessDescEn = _assessDescEn;
			this._assessDescAr = _assessDescAr;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VuCourseAssess"/> instance.
		///</summary>
		///<param name="_edAcadYearId"></param>
		///<param name="_asFacultyInfoId"></param>
		///<param name="_edCodeLevelId"></param>
		///<param name="_edSemesterOpenId"></param>
		///<param name="_edCourseId"></param>
		///<param name="_courseCode"></param>
		///<param name="_courseDescEn"></param>
		///<param name="_courseDescAr"></param>
		///<param name="_courseMax"></param>
		///<param name="_courseMin"></param>
		///<param name="_assessMaxRate"></param>
		///<param name="_assessMinRate"></param>
		///<param name="_assessDescEn"></param>
		///<param name="_assessDescAr"></param>
		public static VuCourseAssess CreateVuCourseAssess(System.Decimal _edAcadYearId, System.Decimal _asFacultyInfoId, System.Decimal? _edCodeLevelId, System.Decimal _edSemesterOpenId, System.Decimal _edCourseId, System.String _courseCode, System.String _courseDescEn, System.String _courseDescAr, System.Decimal? _courseMax, System.Decimal? _courseMin, System.Decimal _assessMaxRate, System.Decimal _assessMinRate, System.String _assessDescEn, System.String _assessDescAr)
		{
			VuCourseAssess newVuCourseAssess = new VuCourseAssess();
			newVuCourseAssess.EdAcadYearId = _edAcadYearId;
			newVuCourseAssess.AsFacultyInfoId = _asFacultyInfoId;
			newVuCourseAssess.EdCodeLevelId = _edCodeLevelId;
			newVuCourseAssess.EdSemesterOpenId = _edSemesterOpenId;
			newVuCourseAssess.EdCourseId = _edCourseId;
			newVuCourseAssess.CourseCode = _courseCode;
			newVuCourseAssess.CourseDescEn = _courseDescEn;
			newVuCourseAssess.CourseDescAr = _courseDescAr;
			newVuCourseAssess.CourseMax = _courseMax;
			newVuCourseAssess.CourseMin = _courseMin;
			newVuCourseAssess.AssessMaxRate = _assessMaxRate;
			newVuCourseAssess.AssessMinRate = _assessMinRate;
			newVuCourseAssess.AssessDescEn = _assessDescEn;
			newVuCourseAssess.AssessDescAr = _assessDescAr;
			return newVuCourseAssess;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the ED_ACAD_YEAR_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal EdAcadYearId
		{
			get
			{
				return this._edAcadYearId; 
			}
			set
			{
				if (_edAcadYearId == value)
					return;
					
				this._edAcadYearId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EdAcadYearId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the AS_FACULTY_INFO_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal AsFacultyInfoId
		{
			get
			{
				return this._asFacultyInfoId; 
			}
			set
			{
				if (_asFacultyInfoId == value)
					return;
					
				this._asFacultyInfoId = value;
				this._isDirty = true;
				
				OnPropertyChanged("AsFacultyInfoId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ED_CODE_LEVEL_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsEdCodeLevelIdNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? EdCodeLevelId
		{
			get
			{
				return this._edCodeLevelId; 
			}
			set
			{
				if (_edCodeLevelId == value && EdCodeLevelId != null )
					return;
					
				this._edCodeLevelId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EdCodeLevelId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ED_SEMESTER_OPEN_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal EdSemesterOpenId
		{
			get
			{
				return this._edSemesterOpenId; 
			}
			set
			{
				if (_edSemesterOpenId == value)
					return;
					
				this._edSemesterOpenId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EdSemesterOpenId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ED_COURSE_ID property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal EdCourseId
		{
			get
			{
				return this._edCourseId; 
			}
			set
			{
				if (_edCourseId == value)
					return;
					
				this._edCourseId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EdCourseId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CourseCode property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CourseCode
		{
			get
			{
				return this._courseCode; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CourseCode does not allow null values.");
				if (_courseCode == value)
					return;
					
				this._courseCode = value;
				this._isDirty = true;
				
				OnPropertyChanged("CourseCode");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CourseDescEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CourseDescEn
		{
			get
			{
				return this._courseDescEn; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CourseDescEn does not allow null values.");
				if (_courseDescEn == value)
					return;
					
				this._courseDescEn = value;
				this._isDirty = true;
				
				OnPropertyChanged("CourseDescEn");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CourseDescAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CourseDescAr
		{
			get
			{
				return this._courseDescAr; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CourseDescAr does not allow null values.");
				if (_courseDescAr == value)
					return;
					
				this._courseDescAr = value;
				this._isDirty = true;
				
				OnPropertyChanged("CourseDescAr");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CourseMax property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsCourseMaxNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? CourseMax
		{
			get
			{
				return this._courseMax; 
			}
			set
			{
				if (_courseMax == value && CourseMax != null )
					return;
					
				this._courseMax = value;
				this._isDirty = true;
				
				OnPropertyChanged("CourseMax");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CourseMin property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsCourseMinNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? CourseMin
		{
			get
			{
				return this._courseMin; 
			}
			set
			{
				if (_courseMin == value && CourseMin != null )
					return;
					
				this._courseMin = value;
				this._isDirty = true;
				
				OnPropertyChanged("CourseMin");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the AssessMaxRate property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal AssessMaxRate
		{
			get
			{
				return this._assessMaxRate; 
			}
			set
			{
				if (_assessMaxRate == value)
					return;
					
				this._assessMaxRate = value;
				this._isDirty = true;
				
				OnPropertyChanged("AssessMaxRate");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the AssessMinRate property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal AssessMinRate
		{
			get
			{
				return this._assessMinRate; 
			}
			set
			{
				if (_assessMinRate == value)
					return;
					
				this._assessMinRate = value;
				this._isDirty = true;
				
				OnPropertyChanged("AssessMinRate");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the AssessDescEn property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String AssessDescEn
		{
			get
			{
				return this._assessDescEn; 
			}
			set
			{
				if (_assessDescEn == value)
					return;
					
				this._assessDescEn = value;
				this._isDirty = true;
				
				OnPropertyChanged("AssessDescEn");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the AssessDescAr property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String AssessDescAr
		{
			get
			{
				return this._assessDescAr; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "AssessDescAr does not allow null values.");
				if (_assessDescAr == value)
					return;
					
				this._assessDescAr = value;
				this._isDirty = true;
				
				OnPropertyChanged("AssessDescAr");
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
			get { return "vuCourseAssess"; }
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
		///  Returns a Typed VuCourseAssessBase Entity 
		///</summary>
		public virtual VuCourseAssessBase Copy()
		{
			//shallow copy entity
			VuCourseAssess copy = new VuCourseAssess();
				copy.EdAcadYearId = this.EdAcadYearId;
				copy.AsFacultyInfoId = this.AsFacultyInfoId;
				copy.EdCodeLevelId = this.EdCodeLevelId;
				copy.EdSemesterOpenId = this.EdSemesterOpenId;
				copy.EdCourseId = this.EdCourseId;
				copy.CourseCode = this.CourseCode;
				copy.CourseDescEn = this.CourseDescEn;
				copy.CourseDescAr = this.CourseDescAr;
				copy.CourseMax = this.CourseMax;
				copy.CourseMin = this.CourseMin;
				copy.AssessMaxRate = this.AssessMaxRate;
				copy.AssessMinRate = this.AssessMinRate;
				copy.AssessDescEn = this.AssessDescEn;
				copy.AssessDescAr = this.AssessDescAr;
			copy.AcceptChanges();
			return (VuCourseAssess)copy;
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
		///<returns>true if toObject is a <see cref="VuCourseAssessBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VuCourseAssessBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VuCourseAssessBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VuCourseAssessBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VuCourseAssessBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VuCourseAssessBase Object1, VuCourseAssessBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.EdAcadYearId != Object2.EdAcadYearId)
				equal = false;
			if (Object1.AsFacultyInfoId != Object2.AsFacultyInfoId)
				equal = false;
			if (Object1.EdCodeLevelId != null && Object2.EdCodeLevelId != null )
			{
				if (Object1.EdCodeLevelId != Object2.EdCodeLevelId)
					equal = false;
			}
			else if (Object1.EdCodeLevelId == null ^ Object1.EdCodeLevelId == null )
			{
				equal = false;
			}
			if (Object1.EdSemesterOpenId != Object2.EdSemesterOpenId)
				equal = false;
			if (Object1.EdCourseId != Object2.EdCourseId)
				equal = false;
			if (Object1.CourseCode != Object2.CourseCode)
				equal = false;
			if (Object1.CourseDescEn != Object2.CourseDescEn)
				equal = false;
			if (Object1.CourseDescAr != Object2.CourseDescAr)
				equal = false;
			if (Object1.CourseMax != null && Object2.CourseMax != null )
			{
				if (Object1.CourseMax != Object2.CourseMax)
					equal = false;
			}
			else if (Object1.CourseMax == null ^ Object1.CourseMax == null )
			{
				equal = false;
			}
			if (Object1.CourseMin != null && Object2.CourseMin != null )
			{
				if (Object1.CourseMin != Object2.CourseMin)
					equal = false;
			}
			else if (Object1.CourseMin == null ^ Object1.CourseMin == null )
			{
				equal = false;
			}
			if (Object1.AssessMaxRate != Object2.AssessMaxRate)
				equal = false;
			if (Object1.AssessMinRate != Object2.AssessMinRate)
				equal = false;
			if (Object1.AssessDescEn != null && Object2.AssessDescEn != null )
			{
				if (Object1.AssessDescEn != Object2.AssessDescEn)
					equal = false;
			}
			else if (Object1.AssessDescEn == null ^ Object1.AssessDescEn == null )
			{
				equal = false;
			}
			if (Object1.AssessDescAr != Object2.AssessDescAr)
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
		public static object GetPropertyValueByName(VuCourseAssess entity, string propertyName)
		{
			switch (propertyName)
			{
				case "EdAcadYearId":
					return entity.EdAcadYearId;
				case "AsFacultyInfoId":
					return entity.AsFacultyInfoId;
				case "EdCodeLevelId":
					return entity.EdCodeLevelId;
				case "EdSemesterOpenId":
					return entity.EdSemesterOpenId;
				case "EdCourseId":
					return entity.EdCourseId;
				case "CourseCode":
					return entity.CourseCode;
				case "CourseDescEn":
					return entity.CourseDescEn;
				case "CourseDescAr":
					return entity.CourseDescAr;
				case "CourseMax":
					return entity.CourseMax;
				case "CourseMin":
					return entity.CourseMin;
				case "AssessMaxRate":
					return entity.AssessMaxRate;
				case "AssessMinRate":
					return entity.AssessMinRate;
				case "AssessDescEn":
					return entity.AssessDescEn;
				case "AssessDescAr":
					return entity.AssessDescAr;
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
			return GetPropertyValueByName(this as VuCourseAssess, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{15}{14}- EdAcadYearId: {0}{14}- AsFacultyInfoId: {1}{14}- EdCodeLevelId: {2}{14}- EdSemesterOpenId: {3}{14}- EdCourseId: {4}{14}- CourseCode: {5}{14}- CourseDescEn: {6}{14}- CourseDescAr: {7}{14}- CourseMax: {8}{14}- CourseMin: {9}{14}- AssessMaxRate: {10}{14}- AssessMinRate: {11}{14}- AssessDescEn: {12}{14}- AssessDescAr: {13}{14}", 
				this.EdAcadYearId,
				this.AsFacultyInfoId,
				(this.EdCodeLevelId == null) ? string.Empty : this.EdCodeLevelId.ToString(),
			     
				this.EdSemesterOpenId,
				this.EdCourseId,
				this.CourseCode,
				this.CourseDescEn,
				this.CourseDescAr,
				(this.CourseMax == null) ? string.Empty : this.CourseMax.ToString(),
			     
				(this.CourseMin == null) ? string.Empty : this.CourseMin.ToString(),
			     
				this.AssessMaxRate,
				this.AssessMinRate,
				(this.AssessDescEn == null) ? string.Empty : this.AssessDescEn.ToString(),
			     
				this.AssessDescAr,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VuCourseAssess columns.
	/// </summary>
	[Serializable]
	public enum VuCourseAssessColumn
	{
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		[EnumTextValue("ED_ACAD_YEAR_ID")]
		[ColumnEnum("ED_ACAD_YEAR_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		EdAcadYearId,
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		[EnumTextValue("AS_FACULTY_INFO_ID")]
		[ColumnEnum("AS_FACULTY_INFO_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		AsFacultyInfoId,
		/// <summary>
		/// ED_CODE_LEVEL_ID : 
		/// </summary>
		[EnumTextValue("ED_CODE_LEVEL_ID")]
		[ColumnEnum("ED_CODE_LEVEL_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		EdCodeLevelId,
		/// <summary>
		/// ED_SEMESTER_OPEN_ID : 
		/// </summary>
		[EnumTextValue("ED_SEMESTER_OPEN_ID")]
		[ColumnEnum("ED_SEMESTER_OPEN_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		EdSemesterOpenId,
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		[EnumTextValue("ED_COURSE_ID")]
		[ColumnEnum("ED_COURSE_ID", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		EdCourseId,
		/// <summary>
		/// CourseCode : 
		/// </summary>
		[EnumTextValue("CourseCode")]
		[ColumnEnum("CourseCode", typeof(System.String), System.Data.DbType.String, false, false, false, 30)]
		CourseCode,
		/// <summary>
		/// CourseDescEn : 
		/// </summary>
		[EnumTextValue("CourseDescEn")]
		[ColumnEnum("CourseDescEn", typeof(System.String), System.Data.DbType.String, false, false, false, 150)]
		CourseDescEn,
		/// <summary>
		/// CourseDescAr : 
		/// </summary>
		[EnumTextValue("CourseDescAr")]
		[ColumnEnum("CourseDescAr", typeof(System.String), System.Data.DbType.String, false, false, false, 150)]
		CourseDescAr,
		/// <summary>
		/// CourseMax : 
		/// </summary>
		[EnumTextValue("CourseMax")]
		[ColumnEnum("CourseMax", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		CourseMax,
		/// <summary>
		/// CourseMin : 
		/// </summary>
		[EnumTextValue("CourseMin")]
		[ColumnEnum("CourseMin", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		CourseMin,
		/// <summary>
		/// AssessMaxRate : 
		/// </summary>
		[EnumTextValue("AssessMaxRate")]
		[ColumnEnum("AssessMaxRate", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		AssessMaxRate,
		/// <summary>
		/// AssessMinRate : 
		/// </summary>
		[EnumTextValue("AssessMinRate")]
		[ColumnEnum("AssessMinRate", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		AssessMinRate,
		/// <summary>
		/// AssessDescEn : 
		/// </summary>
		[EnumTextValue("AssessDescEn")]
		[ColumnEnum("AssessDescEn", typeof(System.String), System.Data.DbType.String, false, false, true, 150)]
		AssessDescEn,
		/// <summary>
		/// AssessDescAr : 
		/// </summary>
		[EnumTextValue("AssessDescAr")]
		[ColumnEnum("AssessDescAr", typeof(System.String), System.Data.DbType.String, false, false, false, 150)]
		AssessDescAr
	}//End enum

} // end namespace