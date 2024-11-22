/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPaperSubViewpointDAEx
表名:vPaperSubViewpoint(01120551)
生成代码版本:2020.02.10.2
生成日期:2020/02/13 19:04:03
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:数据处理扩展层(DALExCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using com.taishsoft.commdb;
using com.taishsoft.common;
using System;

namespace ExamLib.DAL
{
    /// <summary>
    /// v子观点表(vPaperSubViewpoint)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>
    public class clsvPaperSubViewpointDAEx 
    {
        //以下是属性变量

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsvPaperSubViewpointDAEx()
        {
        }

        public static System.Data.DataTable GetSubViewpointNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperDA.GetSpecSQLObj();
            //strSQL = "SELECT UpdUser,UserName,SUM(1) as Num,SUM(OkCount)AS OkCount,SUM(AppraiseCount)AS AppraiseCount FROM vPaperSubViewpoint where " + strCondition + " Group by UpdUser,UserName order by Num Desc";
            strSQL = "SELECT UpdUser,SUM(1) as Num,SUM(OkCount)AS OkCount,SUM(AppraiseCount)AS AppraiseCount FROM vPaperSubViewpoint where " + strCondition + " Group by UpdUser order by Num Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        public static System.Data.DataTable GetSubViewpointLikeNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperLikeLogDA.GetSpecSQLObj();
            strSQL = "select UpdUser,UserName,SUM(1) as LikeNum FROM vPaperSubViewpointLikeLog where " + strCondition + " Group by UpdUser,UserName order by LikeNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }



        public static System.Data.DataTable GetSubViewpointAppraiseNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperAppraiseDA.GetSpecSQLObj();
            strSQL = "select UpdUser,UserName,SUM(1) as AppraiseNum FROM vPaperSubViewpointAppraise where " + strCondition + " Group by UpdUser,UserName order by AppraiseNum Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }



        public static System.Data.DataTable GetSubViewpointTypeNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperSubViewpointDA.GetSpecSQLObj();
            strSQL = "select SubViewpointTypeId,SubViewpointTypeName,SUM(1) as TypeCount FROM vPaperSubViewpoint where " + strCondition + " Group by SubViewpointTypeId,SubViewpointTypeName order by SubViewpointTypeId Asc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}