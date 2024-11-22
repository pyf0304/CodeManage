using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.taishsoft.commdb;
using ExamLib.DAL;

namespace ExamLib.DAL
{
    public class clsSysCommentZxDAEx
    {
        //根据条件 获取数据返回Datatable 评论表类型；主键；评分类型；
        public static System.Data.DataTable GetSysCommentNumDataTable(string strCommentTypeId, string strTableKey)
        {
            //try
            //{
            //    clsCheckSql.CheckStrSQL_Weak(strCondition);
            //    strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            //}
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsSysCommentDA.GetSpecSQLObj();
            strSQL = "select distinct (SELECT COUNT(TableKey) AS pacount FROM dbo.SysComment WHERE TableKey = '" + strTableKey + "' AND CommentTypeId = '" + strCommentTypeId + "' AND ParentId = 'root') as Pacount,(SELECT ROUND(AVG(Score), 2) AS PScore FROM dbo.SysComment WHERE TableKey = '" + strTableKey + "' AND CommentTypeId = '" + strCommentTypeId + "' AND ParentId = 'root') AS PScore,(SELECT ROUND(AVG(Score), 2) AS StuScore FROM dbo.SysComment WHERE TableKey = '" + strTableKey + "' AND CommentTypeId = '" + strCommentTypeId + "' AND ParentId = 'root' AND ScoreType = '1') AS StuScore,(SELECT ROUND(AVG(Score), 2) AS TeaScore FROM dbo.SysComment WHERE TableKey = '" + strTableKey + "' AND CommentTypeId = '" + strCommentTypeId + "' AND ParentId = 'root' AND ScoreType = '2') AS TeaScore from dbo.SysComment WHERE TableKey = '" + strTableKey + "' AND ParentId = 'root' And CommentTypeId = '" + strCommentTypeId + "'";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        //根据条件 获取数据返回Datatable 查询去除重复的教学班数据
        public static System.Data.DataTable GetSysScoreSummaryCurrEduCls()
        {
            //try
            //{
            //    clsCheckSql.CheckStrSQL_Weak(strCondition);
            //    strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperDA: GetDataTable)", objException.Message));
            //}
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsSysCommentDA.GetSpecSQLObj();
            //strSQL = "select distinct IdCurrEduCls from dbo.SysScoreSummary";
            strSQL = "select * from CurrEduCls where IsForPaperReading = '1'";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }



    }
}
