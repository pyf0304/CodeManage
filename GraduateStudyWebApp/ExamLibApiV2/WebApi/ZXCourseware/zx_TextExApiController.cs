using com.taishsoft.common;
using ExamLib.BusinessLogicEx;
using ExamLib.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Comm.WebApi;

namespace ExamLibApi.Controllers.ZXCourseware
{
    public class zx_TextExApiController : zx_TextApiController
    {  
        //通过课件ID ，判断其他5个表是否存在此ID记录，如果存在则true 否则false 
        [HttpGet("GetDataTypeCountByTextId")]
        public ActionResult GetDataTypeCountByTextId(string TextId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("TextId", TextId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 处理总数据 看课件ID是否被其他表数据引用；
                //通过3个参数 来处理10个类型数据 添加 修改 删除；
                bool i = clszx_TextBLEx.GetDataTypeCountByTextId(TextId);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("GetDataTypeCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetDataTypeCountByTextId", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("GetDataTypeCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetDataTypeCountByTextId", dictParam);
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);


            }
          
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }
        //教师布置课文，按教学班布置、参数; 课文Id，教学班、操作者
        [HttpGet("RequestPushDataToEduCls")]
        public ActionResult RequestPushDataToEduCls(string TextId,string IdCurrEduCls,string UpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("TextId", TextId);
            dictParam.Add("IdCurrEduCls", IdCurrEduCls);
            dictParam.Add("UpdUser", UpdUser);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {
                #region 处理总数据 看课件ID是否被其他表数据引用；
                //通过3个参数 来处理10个类型数据 添加 修改 删除；
                bool i = clszx_TextBLEx.RequestPushDataToEduCls(TextId,IdCurrEduCls,UpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("GetDataTypeCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetDataTypeCountByTextId", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("GetDataTypeCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "GetDataTypeCountByTextId", dictParam);
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);


            }
    
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }

        [HttpGet("RequestPushDataToStu")]
        //教师布置课文，按学生布置、参数; 学生集合、课文Id，操作者
        public ActionResult RequestPushDataToStu(string strWhereId_Stu, string TextId, string IdCurrEduCls, string UpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strWhereId_Stu", strWhereId_Stu);
            dictParam.Add("TextId", TextId);
            dictParam.Add("IdCurrEduCls", IdCurrEduCls);
            dictParam.Add("UpdUser", UpdUser);
         
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {

                bool i = clszx_TextBLEx.RequestPushDataToStu(strWhereId_Stu, TextId, IdCurrEduCls, UpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("RequestPushDataToStu", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "RequestPushDataToStu", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("GetDataTypeRequestPushDataToStuCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "RequestPushDataToStu", dictParam);
                }

                //List<clszx_TextEN> arrzx_TextObjLst = clszx_TextBL.GetObjLstByTextIdLst(lstTextId);
                //                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = 1 });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
      
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }



        [HttpGet("RequestPushDataToSingerStu")]
        //教师布置课文，按单个学生布置、参数; 学生id流水号、课文Id，操作者
        public ActionResult RequestPushDataToSingerStu(string IdStu, string TextId, string IdCurrEduCls, string UpdUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("IdStu", IdStu);
            dictParam.Add("TextId", TextId);
            dictParam.Add("IdCurrEduCls", IdCurrEduCls);
            dictParam.Add("UpdUser", UpdUser);
        
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            bool varResult = false;
            try
            {

                bool i = clszx_TextBLEx.RequestPushDataToSingerStu(IdStu, TextId, IdCurrEduCls, UpdUser);
                if (i == true)
                {
                    varResult = true;
                    string msgpaper = string.Format("操作成功");
                    dictParam.Add("RequestPushDataToStu", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "RequestPushDataToStu", dictParam);
                }
                else
                {
                    varResult = false;
                    string msgpaper = string.Format("操作失败");
                    dictParam.Add("GetDataTypeRequestPushDataToStuCountByTextId", msgpaper);
                    clsPubFun_WebApi.Log4Debug(this, "RequestPushDataToStu", dictParam);
                }

                //List<clszx_TextEN> arrzx_TextObjLst = clszx_TextBL.GetObjLstByTextIdLst(lstTextId);
                //                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = 1 });

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
       
            return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });

        }
    }
}