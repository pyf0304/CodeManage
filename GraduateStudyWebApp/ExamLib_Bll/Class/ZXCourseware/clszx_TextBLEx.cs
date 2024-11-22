
/*-- -- -- -- -- -- -- -- -- -- --
类名:clszx_TextBLEx
表名:zx_Text(01120704)
生成代码版本:2020.07.31.1
生成日期:2020/07/31 22:47:55
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:中学生课件管理
模块英文名:ZXCourseware
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clszx_TextBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objzx_TextENS">源对象</param>
        /// <returns>目标对象=>clszx_TextEN:objzx_TextENT</returns>
        public static clszx_TextENEx CopyToEx(this clszx_TextEN objzx_TextENS)
        {
            try
            {
                clszx_TextENEx objzx_TextENT = new clszx_TextENEx();
                clszx_TextBL.zx_TextDA.CopyTo(objzx_TextENS, objzx_TextENT);
                return objzx_TextENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objzx_TextENS">源对象</param>
        /// <returns>目标对象=>clszx_TextEN:objzx_TextENT</returns>
        public static clszx_TextEN CopyTo(this clszx_TextENEx objzx_TextENS)
        {
            try
            {
                clszx_TextEN objzx_TextENT = new clszx_TextEN();
                clszx_TextBL.CopyTo(objzx_TextENS, objzx_TextENT);
                return objzx_TextENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 中学课件表(zx_Text)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clszx_TextBLEx : clszx_TextBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clszx_TextDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clszx_TextDAEx zx_TextDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clszx_TextDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objzx_TextENS">源对象</param>
        /// <returns>目标对象=>clszx_TextEN:objzx_TextENT</returns>
        public static clszx_TextENEx CopyToEx(clszx_TextEN objzx_TextENS)
        {
            try
            {
                clszx_TextENEx objzx_TextENT = new clszx_TextENEx();
                clszx_TextBL.zx_TextDA.CopyTo(objzx_TextENS, objzx_TextENT);
                return objzx_TextENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clszx_TextENEx> GetObjExLst(string strCondition)
        {
            List<clszx_TextEN> arrObjLst = clszx_TextBL.GetObjLst(strCondition);
            List<clszx_TextENEx> arrObjExLst = new List<clszx_TextENEx>();
            foreach (clszx_TextEN objInFor in arrObjLst)
            {
                clszx_TextENEx objzx_TextENEx = new clszx_TextENEx();
                clszx_TextBL.CopyTo(objInFor, objzx_TextENEx);
                arrObjExLst.Add(objzx_TextENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTextId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clszx_TextENEx GetObjExByTextId(string strTextId)
        {
            clszx_TextEN objzx_TextEN = clszx_TextBL.GetObjByTextId(strTextId);
            clszx_TextENEx objzx_TextENEx = new clszx_TextENEx();
            clszx_TextBL.CopyTo(objzx_TextEN, objzx_TextENEx);
            return objzx_TextENEx;
        }

        //根据课文Id查询其他关联的表是否有引用此课文Id;
        public static bool GetDataTypeCountByTextId(string strTextId)
        {
            bool bolResult = false;
            try
            {
                #region 获取教学班数据
                //得到类型判断调用不同的类型表数据
                clszx_ViewpointEN objzx_ViewpointDate = clszx_ViewpointBL.GetFirstObj_S("TextId ='" + strTextId + "'");
                if (objzx_ViewpointDate != null)
                {
                    bolResult = true;
                }
                else
                {
                    //概念
                    clszx_ConceptEN objzx_Concept = clszx_ConceptBL.GetFirstObj_S("TextId ='" + strTextId + "'");
                    if (objzx_Concept != null)
                    {
                        bolResult = true;
                    }
                    else
                    {
                        //客观
                        clszx_TopicObjectiveEN objzx_TopicObjective = clszx_TopicObjectiveBL.GetFirstObj_S("TextId ='" + strTextId + "'");
                        if (objzx_TopicObjective != null)
                        {
                            bolResult = true;
                        }
                        else
                        {
                            //技能
                            clszx_SkillEN objzx_Skill = clszx_SkillBL.GetFirstObj_S("TextId ='" + strTextId + "'");
                            if (objzx_Skill != null)
                            {
                                bolResult = true;
                            }
                            else
                            {
                                //社会关系
                                clszx_SocialRelationsEN objzx_SocialRelations = clszx_SocialRelationsBL.GetFirstObj_S("TextId ='" + strTextId + "'");
                                if (objzx_SocialRelations != null)
                                {
                                    bolResult = true;
                                }
                            }
                        }
                    }

                }


                #endregion
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("操作记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return bolResult;

        }

        //教师根据教学班布置课文推送
        public static bool RequestPushDataToEduCls(string TextId, string IdCurrEduCls, string UpdUser)
        {
            //根据教学班查询教学班下面的学生；然后进行数据推送 同时把数据插入到 课文阅读表；
            bool bolResult = false;
            try
            {
                //1.查询教学班下面学生；
               // List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>();
                List<clsvCurrEduClsStuEN> arrObjLst = clsvCurrEduClsStuBL.GetObjLst("IdCurrEduCls='"+IdCurrEduCls+"'");
                foreach (clsvCurrEduClsStuEN objCurrEduClsStu in arrObjLst)
                {
                    string strStuId = objCurrEduClsStu.StuId;
                    //先插入推送数据zx_TextRead
                    clssys_RequestPushEN objsys_RequestPush = new clssys_RequestPushEN();

                    //先查询该接受者是否已有这个推送数据 同一课文同一用户不可重复添加
                    clssys_RequestPushEN obj = clssys_RequestPushBL.GetFirstObj_S("PushTypeId ='01' And RequesTypeId ='03' And TableKey='" + TextId+ "' And ReceiveUser='"+ strStuId + "'");
                    if (obj == null)
                    {
                        objsys_RequestPush.RequesTypeId = "03";//中学生课文
                        objsys_RequestPush.TableKey = TextId;
                        objsys_RequestPush.ReceiveUser = strStuId;//接收用户
                        objsys_RequestPush.IsReply = false;//是否回复  
                        objsys_RequestPush.ReplyDate = "";//回复日期
                        objsys_RequestPush.RequestUser = UpdUser;//推送者
                        objsys_RequestPush.RequestDate = DateTime.Now.ToString("yyyy-MM-dd");//推送日期
                        objsys_RequestPush.IdCurrEduCls = IdCurrEduCls;
                        objsys_RequestPush.PushTypeId = "01";//推送类型，01按教学班推送

                        bool i = clssys_RequestPushBL.AddNewRecordBySql2(objsys_RequestPush);
                        if (i == true)
                        {
                            //把数据插入到课文阅读表，给该教学班下面学生布置课文阅读
                            clszx_TextReadEN pobjzx_TextReadEN = new clszx_TextReadEN();

                            //先查询阅读数据 同一课文同一用户不可重复添加 在布置类型01
                            clszx_TextReadEN objTR = clszx_TextReadBL.GetFirstObj_S("ReadTypeId ='01' And TextId='" + TextId + "' And ReaderUserId='" + strStuId + "'");
                            if (objTR == null)
                            {

                                pobjzx_TextReadEN.TextId = TextId;
                                pobjzx_TextReadEN.ReadTypeId = "01";//教师布置
                                pobjzx_TextReadEN.IsSubmit = true;
                                pobjzx_TextReadEN.IsPublic = true;
                                //pobjzx_TextReadEN.IdCurrEduCls = IdCurrEduCls;
                                pobjzx_TextReadEN.CreateDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                pobjzx_TextReadEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                pobjzx_TextReadEN.UpdUser = UpdUser;
                                pobjzx_TextReadEN.ReaderUserId = strStuId;

                               bool j = clszx_TextReadBL.AddNewRecordBySql2(pobjzx_TextReadEN);
                                if (j == true)
                                {
                                    bolResult = true;
                                }
                               
                            }
                        }
                       
                    }

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("操作记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return bolResult;
         }


        public static bool RequestPushDataToStu(string strWhereId_Stu, string TextId, string IdCurrEduCls, string UpdUser) {

            //根据教学班查询教学班下面的学生；然后进行数据推送 同时把数据插入到 课文阅读表；
            bool bolResult = false;
            string strStuId = string.Empty;
            try
            {
                //通过Where条件 得到学生数据；
                string strWhere = strWhereId_Stu;
                List<clsvCurrEduClsStuEN> arrList = clsvCurrEduClsStuBL.GetObjLst(strWhere);
                //循环学生id；
                foreach (clsvCurrEduClsStuEN objCurrStu in arrList) {
                        strStuId = objCurrStu.StuId;
                        //先插入推送数据zx_TextRead
                        clssys_RequestPushEN objsys_RequestPush = new clssys_RequestPushEN();

                        //先查询该接受者是否已有这个推送数据 同一课文同一用户不可重复添加
                        clssys_RequestPushEN obj = clssys_RequestPushBL.GetFirstObj_S("PushTypeId ='02' And RequesTypeId ='03' And TableKey='" + TextId + "' And ReceiveUser='" + strStuId + "'");
                        if (obj == null)
                        {
                            objsys_RequestPush.RequesTypeId = "03";//中学生课文
                            objsys_RequestPush.TableKey = TextId;
                            objsys_RequestPush.ReceiveUser = strStuId;//接收用户
                            objsys_RequestPush.IsReply = false;//是否回复  
                            objsys_RequestPush.ReplyDate = "";//回复日期
                            objsys_RequestPush.RequestUser = UpdUser;//推送者
                            objsys_RequestPush.RequestDate = DateTime.Now.ToString("yyyy-MM-dd");//推送日期
                            objsys_RequestPush.IdCurrEduCls = IdCurrEduCls;
                            objsys_RequestPush.PushTypeId = "02";//推送类型，02按学生推送

                            bool i = clssys_RequestPushBL.AddNewRecordBySql2(objsys_RequestPush);
                            if (i == true)
                            {
                                //把数据插入到课文阅读表，给该教学班下面学生布置课文阅读
                                clszx_TextReadEN pobjzx_TextReadEN = new clszx_TextReadEN();

                                //先查询阅读数据 同一课文同一用户不可重复添加 在布置类型01
                                clszx_TextReadEN objTR = clszx_TextReadBL.GetFirstObj_S("ReadTypeId ='01' And TextId='" + TextId + "' And ReaderUserId='" + strStuId + "'");
                                if (objTR == null)
                                {

                                    pobjzx_TextReadEN.TextId = TextId;
                                    pobjzx_TextReadEN.ReadTypeId = "01";//教师布置
                                    pobjzx_TextReadEN.IsSubmit = true;
                                    pobjzx_TextReadEN.IsPublic = true;
                                    //pobjzx_TextReadEN.IdCurrEduCls = IdCurrEduCls;
                                    pobjzx_TextReadEN.CreateDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                    pobjzx_TextReadEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                    pobjzx_TextReadEN.UpdUser = UpdUser;
                                    pobjzx_TextReadEN.ReaderUserId = strStuId;

                                    bool j = clszx_TextReadBL.AddNewRecordBySql2(pobjzx_TextReadEN);
                                    if (j == true)
                                    {
                                        bolResult = true;
                                    }

                                }
                            }

                        }
                
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("操作记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return bolResult;
        }


        public static bool RequestPushDataToSingerStu(string IdStu, string TextId, string IdCurrEduCls, string UpdUser) {
            //根据教学班查询教学班下面的学生；然后进行数据推送 同时把数据插入到 课文阅读表；
            bool bolResult = false;
            string strStuId = string.Empty;
            try
            {
                //通过学生流水号得到学生ID；
                clsvCurrEduClsStuEN objStuEN = clsvCurrEduClsStuBL.GetFirstObj_S("IdStu='" + IdStu + "'");
                if (objStuEN != null)
                {
                    strStuId = objStuEN.StuId;
                    //先插入推送数据zx_TextRead
                    clssys_RequestPushEN objsys_RequestPush = new clssys_RequestPushEN();
                    //PushTypeId 01代表按教学班推送，02带表按学生；
                    //先查询该接受者是否已有这个推送数据 同一课文同一用户不可重复添加
                    clssys_RequestPushEN obj = clssys_RequestPushBL.GetFirstObj_S("PushTypeId ='02' And RequesTypeId ='03' And TableKey='" + TextId + "' And ReceiveUser='" + strStuId + "'");
                    if (obj == null)
                    {
                        objsys_RequestPush.RequesTypeId = "03";//中学生课文
                        objsys_RequestPush.TableKey = TextId;
                        objsys_RequestPush.ReceiveUser = strStuId;//接收用户
                        objsys_RequestPush.IsReply = false;//是否回复  
                        objsys_RequestPush.ReplyDate = "";//回复日期
                        objsys_RequestPush.RequestUser = UpdUser;//推送者
                        objsys_RequestPush.RequestDate = DateTime.Now.ToString("yyyy-MM-dd");//推送日期
                        objsys_RequestPush.IdCurrEduCls = IdCurrEduCls;
                        objsys_RequestPush.PushTypeId = "02";//推送类型，02按学生推送

                        bool i = clssys_RequestPushBL.AddNewRecordBySql2(objsys_RequestPush);
                        if (i == true)
                        {
                            //把数据插入到课文阅读表，给该教学班下面学生布置课文阅读
                            clszx_TextReadEN pobjzx_TextReadEN = new clszx_TextReadEN();

                            //先查询阅读数据 同一课文同一用户不可重复添加 在布置类型01
                            clszx_TextReadEN objTR = clszx_TextReadBL.GetFirstObj_S("ReadTypeId ='01' And TextId='" + TextId + "' And ReaderUserId='" + strStuId + "'");
                            if (objTR == null)
                            {

                                pobjzx_TextReadEN.TextId = TextId;
                                pobjzx_TextReadEN.ReadTypeId = "01";//教师布置
                                pobjzx_TextReadEN.IsSubmit = true;
                                pobjzx_TextReadEN.IsPublic = true;
                                //pobjzx_TextReadEN.IdCurrEduCls = IdCurrEduCls;
                                pobjzx_TextReadEN.CreateDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                pobjzx_TextReadEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd"); ;
                                pobjzx_TextReadEN.UpdUser = UpdUser;
                                pobjzx_TextReadEN.ReaderUserId = strStuId;

                                bool j = clszx_TextReadBL.AddNewRecordBySql2(pobjzx_TextReadEN);
                                if (j == true)
                                {
                                    bolResult = true;
                                }

                            }
                        }

                    }
                }
                else
                {
                    bolResult = false;
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("操作记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return bolResult;
        }
    }
}

