
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperAttentionBLEx
表名:gs_PaperAttention(01120748)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 15:38:24
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_PaperAttentionBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperAttentionENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperAttentionEN:objgs_PaperAttentionENT</returns>
        public static clsgs_PaperAttentionENEx CopyToEx(this clsgs_PaperAttentionEN objgs_PaperAttentionENS)
        {
            try
            {
                clsgs_PaperAttentionENEx objgs_PaperAttentionENT = new clsgs_PaperAttentionENEx();
                clsgs_PaperAttentionBL.gs_PaperAttentionDA.CopyTo(objgs_PaperAttentionENS, objgs_PaperAttentionENT);
                return objgs_PaperAttentionENT;
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
        /// <param name = "objgs_PaperAttentionENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperAttentionEN:objgs_PaperAttentionENT</returns>
        public static clsgs_PaperAttentionEN CopyTo(this clsgs_PaperAttentionENEx objgs_PaperAttentionENS)
        {
            try
            {
                clsgs_PaperAttentionEN objgs_PaperAttentionENT = new clsgs_PaperAttentionEN();
                clsgs_PaperAttentionBL.CopyTo(objgs_PaperAttentionENS, objgs_PaperAttentionENT);
                return objgs_PaperAttentionENT;
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
    /// 论文关注(gs_PaperAttention)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_PaperAttentionBLEx : clsgs_PaperAttentionBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_PaperAttentionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_PaperAttentionDAEx gs_PaperAttentionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_PaperAttentionDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperAttentionENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperAttentionEN:objgs_PaperAttentionENT</returns>
        public static clsgs_PaperAttentionENEx CopyToEx(clsgs_PaperAttentionEN objgs_PaperAttentionENS)
        {
            try
            {
                clsgs_PaperAttentionENEx objgs_PaperAttentionENT = new clsgs_PaperAttentionENEx();
                clsgs_PaperAttentionBL.gs_PaperAttentionDA.CopyTo(objgs_PaperAttentionENS, objgs_PaperAttentionENT);
                return objgs_PaperAttentionENT;
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
        public static List<clsgs_PaperAttentionENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_PaperAttentionEN> arrObjLst = clsgs_PaperAttentionBL.GetObjLst(strCondition);
            List<clsgs_PaperAttentionENEx> arrObjExLst = new List<clsgs_PaperAttentionENEx>();
            foreach (clsgs_PaperAttentionEN objInFor in arrObjLst)
            {
                clsgs_PaperAttentionENEx objgs_PaperAttentionENEx = new clsgs_PaperAttentionENEx();
                clsgs_PaperAttentionBL.CopyTo(objInFor, objgs_PaperAttentionENEx);
                arrObjExLst.Add(objgs_PaperAttentionENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngPaperAttentionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_PaperAttentionENEx GetObjExByPaperAttentionId(long lngPaperAttentionId)
        {
            clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);
            clsgs_PaperAttentionENEx objgs_PaperAttentionENEx = new clsgs_PaperAttentionENEx();
            clsgs_PaperAttentionBL.CopyTo(objgs_PaperAttentionEN, objgs_PaperAttentionENEx);
            return objgs_PaperAttentionENEx;
        }


        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvgs_PaperAttentionEN> GetObjLstEx(string strWhereCond)
        {
            List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
                try
                {
                    objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
                    objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
                    objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
                    objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
                    objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
                    objvgs_PaperAttentionEN.BrowseNumber = clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
                    //objvgs_PaperAttentionEN.IdCurrEduCls = objRow[convgs_PaperAttention.IdCurrEduCls].ToString().Trim(); //当前教学班流水号
                    objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
                    objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
                    objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
                    objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
                    objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
                    objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
                    objvgs_PaperAttentionEN.PaperQCount = clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //PaperQCount
                    objvgs_PaperAttentionEN.SubVCount = clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //SubVCount
                    objvgs_PaperAttentionEN.TagsCount = clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //TagsCount
                    objvgs_PaperAttentionEN.TeaQCount = clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //TeaQCount
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvgs_PaperAttentionEN);
            }
            objDT = null;
            return arrObjLst;
        }



    }
}

