using com.taishsoft.commdb;
using com.taishsoft.common;
using ExamLib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib.DAL
{
    public class clsvTopicObjectiveDAEx
    {
        public clsvTopicObjectiveDAEx() { }

        //得到概念相关用户
        public static System.Data.DataTable GetUserByTopicObjective(string strCondition)
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
            objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
            strSQL = "select distinct UpdUserId,UserName from vTopicObjective where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}
