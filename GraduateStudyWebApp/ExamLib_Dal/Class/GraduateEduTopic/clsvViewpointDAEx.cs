using com.taishsoft.commdb;
using com.taishsoft.common;
using ExamLib.DAL;
using System;

namespace ExamLib.DAL
{
    public class clsvViewpointDAEx
    {
        public clsvViewpointDAEx()
        { }

        //得到观点相关用户
        public static System.Data.DataTable GetUserByViewpoint(string strCondition)
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
            objSQL = clsvViewpointDA.GetSpecSQLObj();
            strSQL = "select distinct UpdUser,UserName from vViewpoint where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }


        public static System.Data.DataTable GetAllVNumDataTable(string strPapeId)
        {
            try
            {
                //clsCheckSql.CheckStrSQL_Weak(strCondition);
                //strCondition = clsString.RemoveElementValue(strCondition, "exclude");
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
            strSQL = "SELECT PdfPageNum,SUM(1) as Num FROM(SELECT PdfPageNum, SUM(1) as Num FROM Viewpoint where CitationId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM Concept where CitationId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM TopicObjective where SourceId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM SysSkill where CitationId = '" + strPapeId + "'  GROUP BY PdfPageNum UNION ALL SELECT PdfPageNum,SUM(1) as Num FROM SysSocialRelations where CitationId = '" + strPapeId + "'  GROUP BY PdfPageNum) as a GROUP BY PdfPageNum";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}
