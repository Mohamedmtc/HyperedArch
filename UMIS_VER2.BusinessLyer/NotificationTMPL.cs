using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace UMIS_VER2.BusinessLyer
{
   public class NotificationTMPL : SvAutoMsgTmplt
    {
       public NotificationTMPL(decimal TMPLT_ID, int TYPE_FLG)
       {

           ReqParameter=GetParameter(TMPLT_ID, TYPE_FLG);
           this.SvAutoMsgTmpltId = TMPLT_ID;
           
       }
      public  List< MessageParameter> ReqParameter = new List<MessageParameter>();
       public List<int> ApplicantParameter { get; set; }
       public List<int> StudParameter { get; set; }
       public Decimal? UserAccntId { get; set; }
       public bool SendEmailFlag { get; set; }
       public bool SendSmSFlag { get; set; }

       //Kamela, 13202 && 13215
       public Decimal? ToSeUserAccount_Id { get; set; }
       //end
       public bool ContainArabicLetter { get; set; }

       public void addParameter(string paramName,string paramValue)
       {
           MessageParameter param = this.ReqParameter.First(p => p.ParamName == paramName);
           param.ParamValue = paramValue;
       }


       private  List<MessageParameter> GetParameter(decimal TMPLT_ID, int TYPE_FLG)
       {
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
           SqlCommand command = new SqlCommand("SV_MSG_TMPLT_PARAMGet", conn);
           command.CommandType = CommandType.StoredProcedure;
           command.Parameters.Add("TMPLT_ID", SqlDbType.Int).Value = TMPLT_ID;
           command.Parameters.Add("TYPE_FLG", SqlDbType.Int).Value = TYPE_FLG;
           conn.Open();
           List<MessageParameter> DicMSG_TMPLT_PARAM = new List<MessageParameter>();
           SqlDataReader dr = command.ExecuteReader();

           while (dr.Read())
           {
               if (TYPE_FLG == 2)
                   DicMSG_TMPLT_PARAM.Add(new MessageParameter() { ParamName = dr["PARAM_NAME"].ToString(), ParamValue = null });
               else
                   DicMSG_TMPLT_PARAM.Add(new MessageParameter() { ParamName = dr["FIELD_NAME"].ToString(), ParamValue = null });

           }

           return DicMSG_TMPLT_PARAM;

       }

    }


   public class MessageParameter
   {
       public string ParamName { get; set; }
       public string ParamValue { get; set; }

   }

  

    




}
