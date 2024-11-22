
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzClgDAEx
表名:XzClg
生成代码版本:2017.05.08.1
生成日期:2017/05/08 08:18:13
生成者:
工程名称:问卷调查
工程ID:0112
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
 
using ExamLib.Entity;

namespace ExamLib.DAL
{
    /// <summary>
    /// 学院表(XzClg)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsXzClgDAEx : clsXzClgDA
    {
        //以下是属性变量

        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdXzCollege in ({0})", strKeyList);
            List<clsXzClgEN> arrCollegeLst = GetObjLst(sbCondition.ToString());
            foreach (clsXzClgEN objCollege in arrCollegeLst)
            {

                objCollege.OrderNum = objCollege.OrderNum - 10000;

                UpdateBySql2(objCollege);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdXzCollege in ({0})", strKeyList);
            List<clsXzClgEN> arrCollegeLst = GetObjLst(sbCondition.ToString());
            foreach (clsXzClgEN objCollege in arrCollegeLst)
            {

                objCollege.OrderNum = objCollege.OrderNum + 10000;

                UpdateBySql2(objCollege);
            }
            return true;
        }
        public bool ReOrder()
        {
            List<clsXzClgEN> arrCollegeObjList = new clsXzClgDA().GetObjLst("1 = 1 order by OrderNum ");
            int intIndex = 1;
            foreach (clsXzClgEN objCollege in arrCollegeObjList)
            {
                objCollege.OrderNum = intIndex;
                //objCollege.id_PubClassCaseCollegeVersion
                //objCollege.IdXzCollege
                this.UpdateBySql2(objCollege);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strid_College)
        {
            ///操作步骤：
            ///1、获取当前所选中的关键字IdXzCollege。
            ///2、根据关键字IdXzCollege来获取字的序号
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            ///4、获取下(上)一个序号字段的关键字IdXzCollege
            ///5、把当前关键字IdXzCollege的序号加(减)1
            ///6、把下一个序号的关键字IdXzCollege减(加)1
            ///7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strid_College;
            string strPrevid_College = "";	//上一条序号的关键字IdXzCollege
            string strNextid_College = "";	//下一条序号的关键字IdXzCollege
            int intTabRecNum;		//当前表中字段的记录数
            //string strCurrid_PubClassCaseCollegeVersion;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            ///1、获取当前所选中的字段ID。

            clsXzClgEN objCollege = new clsXzClgEN(strid_College);
            //objCollege.IdXzCollege
            this.GetXzClg(ref objCollege);
            intOrderNum = objCollege.OrderNum??0;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            //strCurrid_PubClassCaseCollegeVersion = objCollege.id_PubClassCaseCollegeVersion;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("XzClg", "1 = 1");	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intOrderNum <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intOrderNum >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            ///4、获取下(上)一个序号字段的关键字IdXzCollege
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" OrderNum = {0}", intOrderNum - 1);
                strPrevid_College = this.GetFirstID(strCondition.ToString());

                if (strPrevid_College == "")
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" OrderNum = {0}", intOrderNum + 1);
                strNextid_College = this.GetFirstID(strCondition.ToString());

                if (strNextid_College == "")
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            ///5、把当前关键字IdXzCollege的序号加(减)1
            ///6、把下一个序号的关键字IdXzCollege减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("XzClg", "OrderNum", intOrderNum - 1, "IdXzCollege = " + strid_College);
                clsGeneralTab2.funSetFldValue("XzClg", "OrderNum", intPrevOrderNum + 1, "IdXzCollege = " + strPrevid_College);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("XzClg", "OrderNum", intOrderNum + 1, "IdXzCollege = " + strid_College);
                clsGeneralTab2.funSetFldValue("XzClg", "OrderNum", intNextOrderNum - 1, "IdXzCollege = " + strNextid_College);
            }
            ///7、重新显示DATAGRID
            return true;
        }

    }
}