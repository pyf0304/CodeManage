/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_UserRelaDAEx
表名:gs_UserRela(01120773)
生成代码版本:2020.12.02.1
生成日期:2020/12/09 17:30:50
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:数据处理扩展层(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using com.taishsoft.commdb;
using System;

namespace ExamLib.DAL
{
    /// <summary>
    /// 用户关系(gs_UserRela)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsgs_UserRelaDAEx : clsgs_UserRelaDA
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsgs_UserRelaDAEx()
        {
        }

        public static System.Data.DataTable GetUserRelaNumDataTable(string strUserId,string strid_CurrEduCls)
        {
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strUserId);
                //strUserId = clsString.RemoveElementValue(strUserId, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsgs_UserRelaDA.GetSpecSQLObj();
            strSQL = "SELECT UserId as UserId FROM SysComment where UpdUser='" + strUserId + "' and UserId<>'' and UserId<>'" + strUserId + "' and IdCurrEduCls='" + strid_CurrEduCls + "'";
            strSQL += " UNION SELECT UpdUser as UserId FROM SysComment where UserId='" + strUserId + "' and UserId<>'' and UpdUser<>'" + strUserId + "' and IdCurrEduCls='" + strid_CurrEduCls + "'";
            strSQL += " UNION SELECT UserId as UserId FROM vqa_Answer where UpdUser='" + strUserId + "' and UserId<>'' and UserId<>'" + strUserId + "' and IdCurrEduCls='" + strid_CurrEduCls + "'";
            strSQL += " UNION SELECT UpdUser as UserId FROM vqa_Answer where UserId='" + strUserId + "' and UserId<>'' and UpdUser<>'" + strUserId + "' and IdCurrEduCls='" + strid_CurrEduCls + "'";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

    }
}