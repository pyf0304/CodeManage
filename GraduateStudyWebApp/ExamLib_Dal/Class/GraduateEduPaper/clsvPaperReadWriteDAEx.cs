using com.taishsoft.commdb;
using com.taishsoft.common;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.DAL
{
    public class clsvPaperReadWriteDAEx
    {
        public List<clsvPaperReadWriteEN> GetUserNumObjLst(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA:GetObjLst)", objException.Message));
            }
            List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
            //strSQL = "Select IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName,SUM(1) as Num from vPaperReadWrite where " + strCondition + " Group by IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName order by Num Desc";
            strSQL = "Select UpdUser,SUM(1) as Num from vPaperReadWrite where " + strCondition + " Group by UpdUser order by Num Desc";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
                try
                {


                    objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改用户Id

                    //objvPaperReadWriteEN.UserName = objRow[clsvPaperReadWrite.UserName].ToString().Trim(); //用户名


                    //objvPaperReadWriteEN.CollegeName = objRow[clsvPaperReadWrite.CollegeName].ToString().Trim(); //学院名称
                    //objvPaperReadWriteEN.IdXzCollege = objRow[clsvPaperReadWrite.id_XzCollege].ToString().Trim(); //学院流水号
                    //objvPaperReadWriteEN.IdXzMajor = objRow[clsvPaperReadWrite.id_XzMajor].ToString().Trim(); //专业流水号
                    //objvPaperReadWriteEN.MajorName = objRow[clsvPaperReadWrite.MajorName].ToString().Trim(); //专业名称
                    objvPaperReadWriteEN.Memo = objRow["Num"].ToString().Trim(); //统计字段

                }
                catch (Exception objException)
                {
                    throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjLst)", objException.Message));
                }
                objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjLst.Add(objvPaperReadWriteEN);
            }
            objDT = null;
            return arrObjLst;
        }


        public static System.Data.DataTable GetUserNumDataTable(string strCondition)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
            //strSQL = "Select IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName,SUM(1) as Num from vPaperReadWrite where " + strCondition + " Group by IdXzCollege,CollegeName,IdXzMajor,MajorName,UpdUser,UserName order by Num Desc";
            strSQL = "Select UpdUser,SUM(1) as Num from vPaperReadWrite where " + strCondition + " Group by UpdUser order by Num Desc";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}
