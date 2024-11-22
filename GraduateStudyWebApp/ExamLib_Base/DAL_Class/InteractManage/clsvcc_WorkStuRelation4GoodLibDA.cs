
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4GoodLibDA
 表名:vcc_WorkStuRelation4GoodLib(01120225)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// v学生好题集(vcc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_WorkStuRelation4GoodLibDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvcc_WorkStuRelation4GoodLibEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvcc_WorkStuRelation4GoodLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelation4GoodLibEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvcc_WorkStuRelation4GoodLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelation4GoodLibEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_WorkStuRelation4GoodLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable_vcc_WorkStuRelation4GoodLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vcc_WorkStuRelation4GoodLib.* from vcc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} and vcc_WorkStuRelation4GoodLib.mId not in (Select top {5} vcc_WorkStuRelation4GoodLib.mId from vcc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {2} mId from vcc_WorkStuRelation4GoodLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {3} mId from vcc_WorkStuRelation4GoodLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vcc_WorkStuRelation4GoodLib.* from vcc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} and vcc_WorkStuRelation4GoodLib.mId not in (Select top {5} vcc_WorkStuRelation4GoodLib.mId from vcc_WorkStuRelation4GoodLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {2} mId from vcc_WorkStuRelation4GoodLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_WorkStuRelation4GoodLib where {1} and mId not in (Select top {3} mId from vcc_WorkStuRelation4GoodLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA:GetObjLst)", objException.Message));
}
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetObjLst)", objException.Message));
}
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvcc_WorkStuRelation4GoodLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_WorkStuRelation4GoodLibEN> arrObjLst = new List<clsvcc_WorkStuRelation4GoodLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetObjLst)", objException.Message));
}
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_WorkStuRelation4GoodLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_WorkStuRelation4GoodLib(ref clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where mId = " + ""+ objvcc_WorkStuRelation4GoodLibEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_WorkStuRelation4GoodLibEN.CourseName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.StuID = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.StuName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CollegeName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.MajorID = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.MajorName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.QuestionName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.ChapterName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SectionName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.QuestionID = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objDT.Rows[0][convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseId = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.Creator = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CreateDate = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.RedoDate = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objDT.Rows[0][convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.UpdDate = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.UpdUser = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.Memo = objDT.Rows[0][convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: Getvcc_WorkStuRelation4GoodLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_WorkStuRelation4GoodLibEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
 objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.mId = Int32.Parse(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetObjBymId)", objException.Message));
}
return objvcc_WorkStuRelation4GoodLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_WorkStuRelation4GoodLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
strSQL = "Select * from vcc_WorkStuRelation4GoodLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN()
{
CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(), //课程名称
StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(), //学号
StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(), //姓名
IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(), //年级名称
QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(), //题目内容
CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(), //章简称
SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(), //来源类型名称
QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(), //题目ID
mId = TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()), //mId
CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(), //课程Id
IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(), //学生流水号
Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(), //创建者
CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(), //建立日期
SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(), //来源类型Id
IsRedo = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()), //是否重做
RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(), //重做日期
IsPassed = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()), //是否通过
UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim() //备注
};
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelation4GoodLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkStuRelation4GoodLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetObjByDataRowvcc_WorkStuRelation4GoodLib)", objException.Message));
}
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelation4GoodLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_WorkStuRelation4GoodLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN = new clsvcc_WorkStuRelation4GoodLibEN();
try
{
objvcc_WorkStuRelation4GoodLibEN.CourseName = objRow[convcc_WorkStuRelation4GoodLib.CourseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseName].ToString().Trim(); //课程名称
objvcc_WorkStuRelation4GoodLibEN.StuID = objRow[convcc_WorkStuRelation4GoodLib.StuID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuID].ToString().Trim(); //学号
objvcc_WorkStuRelation4GoodLibEN.StuName = objRow[convcc_WorkStuRelation4GoodLib.StuName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.StuName].ToString().Trim(); //姓名
objvcc_WorkStuRelation4GoodLibEN.IdXzCollege = objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_WorkStuRelation4GoodLibEN.CollegeName = objRow[convcc_WorkStuRelation4GoodLib.CollegeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeName].ToString().Trim(); //学院名称
objvcc_WorkStuRelation4GoodLibEN.CollegeNameA = objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_WorkStuRelation4GoodLibEN.IdXzMajor = objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_WorkStuRelation4GoodLibEN.MajorID = objRow[convcc_WorkStuRelation4GoodLib.MajorID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorID].ToString().Trim(); //专业ID
objvcc_WorkStuRelation4GoodLibEN.MajorName = objRow[convcc_WorkStuRelation4GoodLib.MajorName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.MajorName].ToString().Trim(); //专业名称
objvcc_WorkStuRelation4GoodLibEN.IdGradeBase = objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.IdGradeBase].ToString().Trim(); //年级流水号
objvcc_WorkStuRelation4GoodLibEN.GradeBaseName = objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.GradeBaseName].ToString().Trim(); //年级名称
objvcc_WorkStuRelation4GoodLibEN.QuestionIndex = objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.QuestionIndex].ToString().Trim()); //题目序号
objvcc_WorkStuRelation4GoodLibEN.QuestionName = objRow[convcc_WorkStuRelation4GoodLib.QuestionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionName].ToString().Trim(); //题目名称
objvcc_WorkStuRelation4GoodLibEN.QuestionContent = objRow[convcc_WorkStuRelation4GoodLib.QuestionContent] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionContent].ToString().Trim(); //题目内容
objvcc_WorkStuRelation4GoodLibEN.CourseChapterId = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_WorkStuRelation4GoodLibEN.CourseChapterName = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_WorkStuRelation4GoodLibEN.ChapterName = objRow[convcc_WorkStuRelation4GoodLib.ChapterName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterName].ToString().Trim(); //章名
objvcc_WorkStuRelation4GoodLibEN.SectionName = objRow[convcc_WorkStuRelation4GoodLib.SectionName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionName].ToString().Trim(); //节名
objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim = objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_WorkStuRelation4GoodLibEN.SectionNameSim = objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SectionNameSim].ToString().Trim(); //节名简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeID = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeID].ToString().Trim(); //父节点编号
objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred = objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CourseChapterReferred].ToString().Trim(); //节简称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeName = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred = objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.ParentNodeReferred].ToString().Trim(); //章简称
objvcc_WorkStuRelation4GoodLibEN.SourceTypeName = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.SourceTypeName].ToString().Trim(); //来源类型名称
objvcc_WorkStuRelation4GoodLibEN.QuestionID = objRow[convcc_WorkStuRelation4GoodLib.QuestionID] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.QuestionID].ToString().Trim(); //题目ID
objvcc_WorkStuRelation4GoodLibEN.mId = TransNullToInt(objRow[convcc_WorkStuRelation4GoodLib.mId].ToString().Trim()); //mId
objvcc_WorkStuRelation4GoodLibEN.CourseId = objRow[convcc_WorkStuRelation4GoodLib.CourseId].ToString().Trim(); //课程Id
objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo = objRow[convcc_WorkStuRelation4GoodLib.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelation4GoodLibEN.Creator = objRow[convcc_WorkStuRelation4GoodLib.Creator] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Creator].ToString().Trim(); //创建者
objvcc_WorkStuRelation4GoodLibEN.CreateDate = objRow[convcc_WorkStuRelation4GoodLib.CreateDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.CreateDate].ToString().Trim(); //建立日期
objvcc_WorkStuRelation4GoodLibEN.SourceTypeId = objRow[convcc_WorkStuRelation4GoodLib.SourceTypeId].ToString().Trim(); //来源类型Id
objvcc_WorkStuRelation4GoodLibEN.IsRedo = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsRedo].ToString().Trim()); //是否重做
objvcc_WorkStuRelation4GoodLibEN.RedoDate = objRow[convcc_WorkStuRelation4GoodLib.RedoDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.RedoDate].ToString().Trim(); //重做日期
objvcc_WorkStuRelation4GoodLibEN.IsPassed = TransNullToBool(objRow[convcc_WorkStuRelation4GoodLib.IsPassed].ToString().Trim()); //是否通过
objvcc_WorkStuRelation4GoodLibEN.UpdDate = objRow[convcc_WorkStuRelation4GoodLib.UpdDate] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdDate].ToString().Trim(); //修改日期
objvcc_WorkStuRelation4GoodLibEN.UpdUser = objRow[convcc_WorkStuRelation4GoodLib.UpdUser] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.UpdUser].ToString().Trim(); //修改人
objvcc_WorkStuRelation4GoodLibEN.Memo = objRow[convcc_WorkStuRelation4GoodLib.Memo] == DBNull.Value ? null : objRow[convcc_WorkStuRelation4GoodLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA: GetObjByDataRow)", objException.Message));
}
objvcc_WorkStuRelation4GoodLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_WorkStuRelation4GoodLibEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, convcc_WorkStuRelation4GoodLib.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, convcc_WorkStuRelation4GoodLib.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vcc_WorkStuRelation4GoodLib where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vcc_WorkStuRelation4GoodLib where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkStuRelation4GoodLib", "mId = " + ""+ lngmId+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_WorkStuRelation4GoodLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_WorkStuRelation4GoodLib", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_WorkStuRelation4GoodLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelation4GoodLibENT">目标对象</param>
public void CopyTo(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENS, clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibENT)
{
objvcc_WorkStuRelation4GoodLibENT.CourseName = objvcc_WorkStuRelation4GoodLibENS.CourseName; //课程名称
objvcc_WorkStuRelation4GoodLibENT.StuID = objvcc_WorkStuRelation4GoodLibENS.StuID; //学号
objvcc_WorkStuRelation4GoodLibENT.StuName = objvcc_WorkStuRelation4GoodLibENS.StuName; //姓名
objvcc_WorkStuRelation4GoodLibENT.IdXzCollege = objvcc_WorkStuRelation4GoodLibENS.IdXzCollege; //学院流水号
objvcc_WorkStuRelation4GoodLibENT.CollegeName = objvcc_WorkStuRelation4GoodLibENS.CollegeName; //学院名称
objvcc_WorkStuRelation4GoodLibENT.CollegeNameA = objvcc_WorkStuRelation4GoodLibENS.CollegeNameA; //学院名称简写
objvcc_WorkStuRelation4GoodLibENT.IdXzMajor = objvcc_WorkStuRelation4GoodLibENS.IdXzMajor; //专业流水号
objvcc_WorkStuRelation4GoodLibENT.MajorID = objvcc_WorkStuRelation4GoodLibENS.MajorID; //专业ID
objvcc_WorkStuRelation4GoodLibENT.MajorName = objvcc_WorkStuRelation4GoodLibENS.MajorName; //专业名称
objvcc_WorkStuRelation4GoodLibENT.IdGradeBase = objvcc_WorkStuRelation4GoodLibENS.IdGradeBase; //年级流水号
objvcc_WorkStuRelation4GoodLibENT.GradeBaseName = objvcc_WorkStuRelation4GoodLibENS.GradeBaseName; //年级名称
objvcc_WorkStuRelation4GoodLibENT.QuestionIndex = objvcc_WorkStuRelation4GoodLibENS.QuestionIndex; //题目序号
objvcc_WorkStuRelation4GoodLibENT.QuestionName = objvcc_WorkStuRelation4GoodLibENS.QuestionName; //题目名称
objvcc_WorkStuRelation4GoodLibENT.QuestionContent = objvcc_WorkStuRelation4GoodLibENS.QuestionContent; //题目内容
objvcc_WorkStuRelation4GoodLibENT.CourseChapterId = objvcc_WorkStuRelation4GoodLibENS.CourseChapterId; //课程章节ID
objvcc_WorkStuRelation4GoodLibENT.CourseChapterName = objvcc_WorkStuRelation4GoodLibENS.CourseChapterName; //课程章节名称
objvcc_WorkStuRelation4GoodLibENT.ChapterName = objvcc_WorkStuRelation4GoodLibENS.ChapterName; //章名
objvcc_WorkStuRelation4GoodLibENT.SectionName = objvcc_WorkStuRelation4GoodLibENS.SectionName; //节名
objvcc_WorkStuRelation4GoodLibENT.ChapterNameSim = objvcc_WorkStuRelation4GoodLibENS.ChapterNameSim; //章名简称
objvcc_WorkStuRelation4GoodLibENT.SectionNameSim = objvcc_WorkStuRelation4GoodLibENS.SectionNameSim; //节名简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeID = objvcc_WorkStuRelation4GoodLibENS.ParentNodeID; //父节点编号
objvcc_WorkStuRelation4GoodLibENT.CourseChapterReferred = objvcc_WorkStuRelation4GoodLibENS.CourseChapterReferred; //节简称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeName = objvcc_WorkStuRelation4GoodLibENS.ParentNodeName; //父节点名称
objvcc_WorkStuRelation4GoodLibENT.ParentNodeReferred = objvcc_WorkStuRelation4GoodLibENS.ParentNodeReferred; //章简称
objvcc_WorkStuRelation4GoodLibENT.SourceTypeName = objvcc_WorkStuRelation4GoodLibENS.SourceTypeName; //来源类型名称
objvcc_WorkStuRelation4GoodLibENT.QuestionID = objvcc_WorkStuRelation4GoodLibENS.QuestionID; //题目ID
objvcc_WorkStuRelation4GoodLibENT.mId = objvcc_WorkStuRelation4GoodLibENS.mId; //mId
objvcc_WorkStuRelation4GoodLibENT.CourseId = objvcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objvcc_WorkStuRelation4GoodLibENT.IdStudentInfo = objvcc_WorkStuRelation4GoodLibENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelation4GoodLibENT.Creator = objvcc_WorkStuRelation4GoodLibENS.Creator; //创建者
objvcc_WorkStuRelation4GoodLibENT.CreateDate = objvcc_WorkStuRelation4GoodLibENS.CreateDate; //建立日期
objvcc_WorkStuRelation4GoodLibENT.SourceTypeId = objvcc_WorkStuRelation4GoodLibENS.SourceTypeId; //来源类型Id
objvcc_WorkStuRelation4GoodLibENT.IsRedo = objvcc_WorkStuRelation4GoodLibENS.IsRedo; //是否重做
objvcc_WorkStuRelation4GoodLibENT.RedoDate = objvcc_WorkStuRelation4GoodLibENS.RedoDate; //重做日期
objvcc_WorkStuRelation4GoodLibENT.IsPassed = objvcc_WorkStuRelation4GoodLibENS.IsPassed; //是否通过
objvcc_WorkStuRelation4GoodLibENT.UpdDate = objvcc_WorkStuRelation4GoodLibENS.UpdDate; //修改日期
objvcc_WorkStuRelation4GoodLibENT.UpdUser = objvcc_WorkStuRelation4GoodLibENS.UpdUser; //修改人
objvcc_WorkStuRelation4GoodLibENT.Memo = objvcc_WorkStuRelation4GoodLibENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_WorkStuRelation4GoodLibEN objvcc_WorkStuRelation4GoodLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CourseName, 100, convcc_WorkStuRelation4GoodLib.CourseName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.StuID, 20, convcc_WorkStuRelation4GoodLib.StuID);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.StuName, 50, convcc_WorkStuRelation4GoodLib.StuName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.IdXzCollege, 4, convcc_WorkStuRelation4GoodLib.IdXzCollege);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CollegeName, 100, convcc_WorkStuRelation4GoodLib.CollegeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CollegeNameA, 12, convcc_WorkStuRelation4GoodLib.CollegeNameA);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.IdXzMajor, 8, convcc_WorkStuRelation4GoodLib.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.MajorID, 4, convcc_WorkStuRelation4GoodLib.MajorID);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.MajorName, 100, convcc_WorkStuRelation4GoodLib.MajorName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.IdGradeBase, 4, convcc_WorkStuRelation4GoodLib.IdGradeBase);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.GradeBaseName, 50, convcc_WorkStuRelation4GoodLib.GradeBaseName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.QuestionName, 500, convcc_WorkStuRelation4GoodLib.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.QuestionContent, 4000, convcc_WorkStuRelation4GoodLib.QuestionContent);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CourseChapterId, 8, convcc_WorkStuRelation4GoodLib.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CourseChapterName, 100, convcc_WorkStuRelation4GoodLib.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.ChapterName, 100, convcc_WorkStuRelation4GoodLib.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.SectionName, 100, convcc_WorkStuRelation4GoodLib.SectionName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim, 10, convcc_WorkStuRelation4GoodLib.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.SectionNameSim, 10, convcc_WorkStuRelation4GoodLib.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.ParentNodeID, 8, convcc_WorkStuRelation4GoodLib.ParentNodeID);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred, 10, convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.ParentNodeName, 50, convcc_WorkStuRelation4GoodLib.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred, 10, convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.SourceTypeName, 20, convcc_WorkStuRelation4GoodLib.SourceTypeName);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.QuestionID, 8, convcc_WorkStuRelation4GoodLib.QuestionID);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CourseId, 8, convcc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo, 8, convcc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.Creator, 18, convcc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.CreateDate, 20, convcc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.SourceTypeId, 2, convcc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.RedoDate, 8, convcc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.UpdDate, 20, convcc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.UpdUser, 20, convcc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckFieldLen(objvcc_WorkStuRelation4GoodLibEN.Memo, 1000, convcc_WorkStuRelation4GoodLib.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CourseName, convcc_WorkStuRelation4GoodLib.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.StuID, convcc_WorkStuRelation4GoodLib.StuID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.StuName, convcc_WorkStuRelation4GoodLib.StuName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.IdXzCollege, convcc_WorkStuRelation4GoodLib.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CollegeName, convcc_WorkStuRelation4GoodLib.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CollegeNameA, convcc_WorkStuRelation4GoodLib.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.IdXzMajor, convcc_WorkStuRelation4GoodLib.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.MajorID, convcc_WorkStuRelation4GoodLib.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.MajorName, convcc_WorkStuRelation4GoodLib.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.IdGradeBase, convcc_WorkStuRelation4GoodLib.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.GradeBaseName, convcc_WorkStuRelation4GoodLib.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.QuestionName, convcc_WorkStuRelation4GoodLib.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.QuestionContent, convcc_WorkStuRelation4GoodLib.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CourseChapterId, convcc_WorkStuRelation4GoodLib.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CourseChapterName, convcc_WorkStuRelation4GoodLib.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.ChapterName, convcc_WorkStuRelation4GoodLib.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.SectionName, convcc_WorkStuRelation4GoodLib.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.ChapterNameSim, convcc_WorkStuRelation4GoodLib.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.SectionNameSim, convcc_WorkStuRelation4GoodLib.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.ParentNodeID, convcc_WorkStuRelation4GoodLib.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CourseChapterReferred, convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.ParentNodeName, convcc_WorkStuRelation4GoodLib.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.ParentNodeReferred, convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.SourceTypeName, convcc_WorkStuRelation4GoodLib.SourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.QuestionID, convcc_WorkStuRelation4GoodLib.QuestionID);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CourseId, convcc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.IdStudentInfo, convcc_WorkStuRelation4GoodLib.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.Creator, convcc_WorkStuRelation4GoodLib.Creator);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.CreateDate, convcc_WorkStuRelation4GoodLib.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.SourceTypeId, convcc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.RedoDate, convcc_WorkStuRelation4GoodLib.RedoDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.UpdDate, convcc_WorkStuRelation4GoodLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.UpdUser, convcc_WorkStuRelation4GoodLib.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcc_WorkStuRelation4GoodLibEN.Memo, convcc_WorkStuRelation4GoodLib.Memo);
//检查外键字段长度
 objvcc_WorkStuRelation4GoodLibEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkStuRelation4GoodLibEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_WorkStuRelation4GoodLibEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_WorkStuRelation4GoodLibDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}