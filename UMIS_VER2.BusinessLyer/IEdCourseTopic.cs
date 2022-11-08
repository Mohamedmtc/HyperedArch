﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_COURSE_TOPIC' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCourseTopic 
	{
		/// <summary>			
		/// ED_COURSE_TOPIC_ID : مواضيع المقرر الراسي
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_COURSE_TOPIC"</remarks>
		System.Decimal EdCourseTopicId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCourseTopicId { get; set; }
			
		
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal  EdCourseId  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// ENT_MAIN_ID : القسم
		/// </summary>
		System.Decimal?  EntMainId  { get; set; }
		
		/// <summary>
		/// TOPIC_AR : 
		/// </summary>
		System.String  TopicAr  { get; set; }
		
		/// <summary>
		/// TOPIC_EN : 
		/// </summary>
		System.String  TopicEn  { get; set; }
		
		/// <summary>
		/// TOPIC_ORDER : ترتيب دراسةالموضوع
		/// </summary>
		System.Int32?  TopicOrder  { get; set; }
		
		/// <summary>
		/// OPTIONAL_FLG : 
		/// </summary>
		System.Boolean  OptionalFlg  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// TOPIC_CONTENT_AR : 
		/// </summary>
		System.String  TopicContentAr  { get; set; }
		
		/// <summary>
		/// TOPIC_CONTENT_EN : 
		/// </summary>
		System.String  TopicContentEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSchdlSlotEdCourseTopicId
		/// </summary>	
		TList<ScSchdlSlot> ScSchdlSlotCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edTopicTchngEdCourseTopicId
		/// </summary>	
		TList<EdTopicTchng> EdTopicTchngCollection {  get;  set;}	

		#endregion Data Properties

	}
}


