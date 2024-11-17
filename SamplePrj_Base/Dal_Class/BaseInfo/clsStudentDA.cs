
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentDA
 表名:Student(01160036)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:52
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;

namespace SimplePrj.DAL
{
 /// <summary>
 /// 学生(Student)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsStudentDA : clsCommBase4DA
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
 public override string _CurrTabName_S
 {
 get
 {
 return clsStudentEN._CurrTabName_S;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsStudentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsStudentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsStudentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsStudentEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strid_stu">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strid_stu)
{
strid_stu = strid_stu.Replace("'", "''");
if (strid_stu.Length > 8)
{
throw new Exception("(errid:Data000001)在表:Student中,检查关键字,长度不正确!(clsStudentDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strid_stu)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Student中,关键字不能为空 或 null!(clsStudentDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_stu);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsStudentDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Student(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable_Student)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Student where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Student where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsStudentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Student where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsStudentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} Student.* from Student Left Join {1} on {2} where {3} and Student.id_stu not in (Select top {5} Student.id_stu from Student Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Student where {1} and id_stu not in (Select top {2} id_stu from Student where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Student where {1} and id_stu not in (Select top {3} id_stu from Student where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsStudentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} Student.* from Student Left Join {1} on {2} where {3} and Student.id_stu not in (Select top {5} Student.id_stu from Student Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Student where {1} and id_stu not in (Select top {2} id_stu from Student where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Student where {1} and id_stu not in (Select top {3} id_stu from Student where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsStudentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsStudentDA:GetObjLst)", objException.Message));
}
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = TransNullToInt(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = TransNullToInt(objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = TransNullToBool(objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex].ToString().Trim(); //Sex
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsStudentDA: GetObjLst)", objException.Message));
}
objStudentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objStudentEN);
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
public List<clsStudentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsStudentDA:GetObjLstByTabName)", objException.Message));
}
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = TransNullToInt(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = TransNullToInt(objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = TransNullToBool(objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex].ToString().Trim(); //Sex
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsStudentDA: GetObjLst)", objException.Message));
}
objStudentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objStudentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetStudent(ref clsStudentEN objStudentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where id_stu = " + "'"+ objStudentEN.id_stu+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objStudentEN.id_stu = objDT.Rows[0][conStudent.id_stu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentEN.StuID = objDT.Rows[0][conStudent.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:False)
 objStudentEN.StuName = objDT.Rows[0][conStudent.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objStudentEN.Age = TransNullToInt(objDT.Rows[0][conStudent.Age].ToString().Trim()); //Age(字段类型:int,字段长度:4,是否可空:False)
 objStudentEN.CollegeId = objDT.Rows[0][conStudent.CollegeId].ToString().Trim(); //学院Id(字段类型:varchar,字段长度:6,是否可空:False)
 objStudentEN.id_Major = objDT.Rows[0][conStudent.id_Major].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentEN.Memo = objDT.Rows[0][conStudent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objStudentEN.OrderNum = TransNullToInt(objDT.Rows[0][conStudent.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objStudentEN.IsDelete = TransNullToBool(objDT.Rows[0][conStudent.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objStudentEN.Sex = objDT.Rows[0][conStudent.Sex].ToString().Trim(); //Sex(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsStudentDA: GetStudent)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_stu">表关键字</param>
 /// <returns>表对象</returns>
public clsStudentEN GetObjByid_stu(string strid_stu)
{
CheckPrimaryKey(strid_stu);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where id_stu = " + "'"+ strid_stu+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsStudentEN objStudentEN = new clsStudentEN();
try
{
 objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:False)
 objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age(字段类型:int,字段长度:4,是否可空:False)
 objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id(字段类型:varchar,字段长度:6,是否可空:False)
 objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsStudentDA: GetObjByid_stu)", objException.Message));
}
return objStudentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsStudentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsStudentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsStudentEN objStudentEN = new clsStudentEN()
{
id_stu = objRow[conStudent.id_stu].ToString().Trim(), //学生流水号
StuID = objRow[conStudent.StuID].ToString().Trim(), //学号
StuName = objRow[conStudent.StuName].ToString().Trim(), //姓名
Age = TransNullToInt(objRow[conStudent.Age].ToString().Trim()), //Age
CollegeId = objRow[conStudent.CollegeId].ToString().Trim(), //学院Id
id_Major = objRow[conStudent.id_Major].ToString().Trim(), //专业流水号
Memo = objRow[conStudent.Memo].ToString().Trim(), //备注
OrderNum = TransNullToInt(objRow[conStudent.OrderNum].ToString().Trim()), //排序
IsDelete = TransNullToBool(objRow[conStudent.IsDelete].ToString().Trim()), //是否删除
Sex = objRow[conStudent.Sex].ToString().Trim() //Sex
};
objStudentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsStudentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsStudentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = TransNullToInt(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = TransNullToInt(objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = TransNullToBool(objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex].ToString().Trim(); //Sex
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsStudentDA: GetObjByDataRowStudent)", objException.Message));
}
objStudentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsStudentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = TransNullToInt(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = TransNullToInt(objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = TransNullToBool(objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex].ToString().Trim(); //Sex
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsStudentDA: GetObjByDataRow)", objException.Message));
}
objStudentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentEN;
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
objSQL = clsStudentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsStudentEN._CurrTabName_S, conStudent.id_stu, 8, "");
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
objSQL = clsStudentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsStudentEN._CurrTabName_S, conStudent.id_stu, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select id_stu from Student where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsStudentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select id_stu from Student where " + strCondition;
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
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strid_stu)
{
CheckPrimaryKey(strid_stu);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Student", "id_stu = " + "'"+ strid_stu+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsStudentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Student", strCondition))
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
objSQL = clsStudentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Student");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsStudentEN objStudentEN)
 {
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Student");
objRow = objDS.Tables["Student"].NewRow();
objRow[conStudent.id_stu] = objStudentEN.id_stu; //学生流水号
 if (objStudentEN.StuID !=  "")
 {
objRow[conStudent.StuID] = objStudentEN.StuID; //学号
 }
objRow[conStudent.StuName] = objStudentEN.StuName; //姓名
objRow[conStudent.Age] = objStudentEN.Age; //Age
objRow[conStudent.CollegeId] = objStudentEN.CollegeId; //学院Id
 if (objStudentEN.id_Major !=  "")
 {
objRow[conStudent.id_Major] = objStudentEN.id_Major; //专业流水号
 }
 if (objStudentEN.Memo !=  "")
 {
objRow[conStudent.Memo] = objStudentEN.Memo; //备注
 }
objRow[conStudent.OrderNum] = objStudentEN.OrderNum; //排序
objRow[conStudent.IsDelete] = objStudentEN.IsDelete; //是否删除
 if (objStudentEN.Sex !=  "")
 {
objRow[conStudent.Sex] = objStudentEN.Sex; //Sex
 }
objDS.Tables[clsStudentEN._CurrTabName_S].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsStudentEN._CurrTabName_S);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsStudentEN objStudentEN)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentEN.id_stu !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_stu);
 objStudentEN.id_stu = objStudentEN.id_stu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_stu + "'");
 }
 
 if (objStudentEN.StuID !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuID);
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuID + "'");
 }
 
 if (objStudentEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuName);
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuName + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.Age);
 arrValueListForInsert.Add(objStudentEN.Age.ToString());
 
 if (objStudentEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conStudent.CollegeId);
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.CollegeId + "'");
 }
 
 if (objStudentEN.id_Major !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_Major);
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_Major + "'");
 }
 
 if (objStudentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Memo);
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Memo + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.OrderNum);
 arrValueListForInsert.Add(objStudentEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conStudent.IsDelete);
 arrValueListForInsert.Add("'" + (objStudentEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 if (objStudentEN.Sex !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Sex);
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Sex + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Student");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsStudentEN objStudentEN)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentEN.id_stu !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_stu);
 objStudentEN.id_stu = objStudentEN.id_stu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_stu + "'");
 }
 
 if (objStudentEN.StuID !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuID);
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuID + "'");
 }
 
 if (objStudentEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuName);
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuName + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.Age);
 arrValueListForInsert.Add(objStudentEN.Age.ToString());
 
 if (objStudentEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conStudent.CollegeId);
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.CollegeId + "'");
 }
 
 if (objStudentEN.id_Major !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_Major);
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_Major + "'");
 }
 
 if (objStudentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Memo);
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Memo + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.OrderNum);
 arrValueListForInsert.Add(objStudentEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conStudent.IsDelete);
 arrValueListForInsert.Add("'" + (objStudentEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 if (objStudentEN.Sex !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Sex);
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Sex + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Student");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objStudentEN.id_stu;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsStudentEN objStudentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentEN.id_stu !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_stu);
 objStudentEN.id_stu = objStudentEN.id_stu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_stu + "'");
 }
 
 if (objStudentEN.StuID !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuID);
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuID + "'");
 }
 
 if (objStudentEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuName);
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuName + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.Age);
 arrValueListForInsert.Add(objStudentEN.Age.ToString());
 
 if (objStudentEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conStudent.CollegeId);
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.CollegeId + "'");
 }
 
 if (objStudentEN.id_Major !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_Major);
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_Major + "'");
 }
 
 if (objStudentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Memo);
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Memo + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.OrderNum);
 arrValueListForInsert.Add(objStudentEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conStudent.IsDelete);
 arrValueListForInsert.Add("'" + (objStudentEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 if (objStudentEN.Sex !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Sex);
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Sex + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Student");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objStudentEN.id_stu;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsStudentEN objStudentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentEN.id_stu !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_stu);
 objStudentEN.id_stu = objStudentEN.id_stu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_stu + "'");
 }
 
 if (objStudentEN.StuID !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuID);
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuID + "'");
 }
 
 if (objStudentEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudent.StuName);
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.StuName + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.Age);
 arrValueListForInsert.Add(objStudentEN.Age.ToString());
 
 if (objStudentEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conStudent.CollegeId);
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.CollegeId + "'");
 }
 
 if (objStudentEN.id_Major !=  null)
 {
 arrFieldListForInsert.Add(conStudent.id_Major);
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.id_Major + "'");
 }
 
 if (objStudentEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Memo);
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Memo + "'");
 }
 
 arrFieldListForInsert.Add(conStudent.OrderNum);
 arrValueListForInsert.Add(objStudentEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conStudent.IsDelete);
 arrValueListForInsert.Add("'" + (objStudentEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 if (objStudentEN.Sex !=  null)
 {
 arrFieldListForInsert.Add(conStudent.Sex);
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objStudentEN.Sex + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Student");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewStudents(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where id_stu = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Student");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strid_stu = oRow[conStudent.id_stu].ToString().Trim();
if (IsExist(strid_stu))
{
 string strResult = "关键字变量值为:" + string.Format("id_stu = {0}", strid_stu) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsStudentEN._CurrTabName_S ].NewRow();
objRow[conStudent.id_stu] = oRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objRow[conStudent.StuID] = oRow[conStudent.StuID].ToString().Trim(); //学号
objRow[conStudent.StuName] = oRow[conStudent.StuName].ToString().Trim(); //姓名
objRow[conStudent.Age] = oRow[conStudent.Age].ToString().Trim(); //Age
objRow[conStudent.CollegeId] = oRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objRow[conStudent.id_Major] = oRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objRow[conStudent.Memo] = oRow[conStudent.Memo].ToString().Trim(); //备注
objRow[conStudent.OrderNum] = oRow[conStudent.OrderNum].ToString().Trim(); //排序
objRow[conStudent.IsDelete] = oRow[conStudent.IsDelete].ToString().Trim(); //是否删除
objRow[conStudent.Sex] = oRow[conStudent.Sex].ToString().Trim(); //Sex
 objDS.Tables[clsStudentEN._CurrTabName_S].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsStudentEN._CurrTabName_S);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objStudentEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsStudentEN objStudentEN)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
strSQL = "Select * from Student where id_stu = " + "'"+ objStudentEN.id_stu+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsStudentEN._CurrTabName_S);
if (objDS.Tables[clsStudentEN._CurrTabName_S].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:id_stu = " + "'"+ objStudentEN.id_stu+"'");
return false;
}
objRow = objDS.Tables[clsStudentEN._CurrTabName_S].Rows[0];
 if (objStudentEN.IsUpdated(conStudent.id_stu))
 {
objRow[conStudent.id_stu] = objStudentEN.id_stu; //学生流水号
 }
 if (objStudentEN.IsUpdated(conStudent.StuID))
 {
objRow[conStudent.StuID] = objStudentEN.StuID; //学号
 }
 if (objStudentEN.IsUpdated(conStudent.StuName))
 {
objRow[conStudent.StuName] = objStudentEN.StuName; //姓名
 }
 if (objStudentEN.IsUpdated(conStudent.Age))
 {
objRow[conStudent.Age] = objStudentEN.Age; //Age
 }
 if (objStudentEN.IsUpdated(conStudent.CollegeId))
 {
objRow[conStudent.CollegeId] = objStudentEN.CollegeId; //学院Id
 }
 if (objStudentEN.IsUpdated(conStudent.id_Major))
 {
objRow[conStudent.id_Major] = objStudentEN.id_Major; //专业流水号
 }
 if (objStudentEN.IsUpdated(conStudent.Memo))
 {
objRow[conStudent.Memo] = objStudentEN.Memo; //备注
 }
 if (objStudentEN.IsUpdated(conStudent.OrderNum))
 {
objRow[conStudent.OrderNum] = objStudentEN.OrderNum; //排序
 }
 if (objStudentEN.IsUpdated(conStudent.IsDelete))
 {
objRow[conStudent.IsDelete] = objStudentEN.IsDelete; //是否删除
 }
 if (objStudentEN.IsUpdated(conStudent.Sex))
 {
objRow[conStudent.Sex] = objStudentEN.Sex; //Sex
 }
try
{
objDA.Update(objDS, clsStudentEN._CurrTabName_S);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsStudentEN objStudentEN)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Student Set ");
 
 if (objStudentEN.IsUpdated(conStudent.StuID))
 {
 if (objStudentEN.StuID !=  null)
 {
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.StuID, conStudent.StuID); //学号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.StuID); //学号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.StuName))
 {
 if (objStudentEN.StuName !=  null)
 {
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.StuName, conStudent.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.StuName); //姓名
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Age))
 {
 sbSQL.AppendFormat("{1} = {0},",objStudentEN.Age, conStudent.Age); //Age
 }
 
 if (objStudentEN.IsUpdated(conStudent.CollegeId))
 {
 if (objStudentEN.CollegeId !=  null)
 {
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.CollegeId, conStudent.CollegeId); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.CollegeId); //学院Id
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.id_Major))
 {
 if (objStudentEN.id_Major !=  null)
 {
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.id_Major, conStudent.id_Major); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.id_Major); //专业流水号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Memo))
 {
 if (objStudentEN.Memo !=  null)
 {
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.Memo, conStudent.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.Memo); //备注
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objStudentEN.OrderNum, conStudent.OrderNum); //排序
 }
 
 if (objStudentEN.IsUpdated(conStudent.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentEN.IsDelete == true?"1":"0", conStudent.IsDelete); //是否删除
 }
 
 if (objStudentEN.IsUpdated(conStudent.Sex))
 {
 if (objStudentEN.Sex !=  null)
 {
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.Sex, conStudent.Sex); //Sex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.Sex); //Sex
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_stu = '{0}'", objStudentEN.id_stu); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objStudentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsStudentEN objStudentEN, string strCondition)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Student Set ");
 
 if (objStudentEN.IsUpdated(conStudent.StuID))
 {
 if (objStudentEN.StuID !=  null)
 {
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuID = '{0}',", objStudentEN.StuID); //学号
 }
 else
 {
 sbSQL.Append(" StuID = null,"); //学号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.StuName))
 {
 if (objStudentEN.StuName !=  null)
 {
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", objStudentEN.StuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Age))
 {
 sbSQL.AppendFormat(" Age = {0},", objStudentEN.Age); //Age
 }
 
 if (objStudentEN.IsUpdated(conStudent.CollegeId))
 {
 if (objStudentEN.CollegeId !=  null)
 {
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", objStudentEN.CollegeId); //学院Id
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //学院Id
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.id_Major))
 {
 if (objStudentEN.id_Major !=  null)
 {
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" id_Major = '{0}',", objStudentEN.id_Major); //专业流水号
 }
 else
 {
 sbSQL.Append(" id_Major = null,"); //专业流水号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Memo))
 {
 if (objStudentEN.Memo !=  null)
 {
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objStudentEN.Memo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objStudentEN.OrderNum); //排序
 }
 
 if (objStudentEN.IsUpdated(conStudent.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objStudentEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objStudentEN.IsUpdated(conStudent.Sex))
 {
 if (objStudentEN.Sex !=  null)
 {
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sex = '{0}',", objStudentEN.Sex); //Sex
 }
 else
 {
 sbSQL.Append(" Sex = null,"); //Sex
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objStudentEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsStudentEN objStudentEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Student Set ");
 
 if (objStudentEN.IsUpdated(conStudent.StuID))
 {
 if (objStudentEN.StuID !=  null)
 {
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuID = '{0}',", objStudentEN.StuID); //学号
 }
 else
 {
 sbSQL.Append(" StuID = null,"); //学号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.StuName))
 {
 if (objStudentEN.StuName !=  null)
 {
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", objStudentEN.StuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Age))
 {
 sbSQL.AppendFormat(" Age = {0},", objStudentEN.Age); //Age
 }
 
 if (objStudentEN.IsUpdated(conStudent.CollegeId))
 {
 if (objStudentEN.CollegeId !=  null)
 {
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", objStudentEN.CollegeId); //学院Id
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //学院Id
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.id_Major))
 {
 if (objStudentEN.id_Major !=  null)
 {
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" id_Major = '{0}',", objStudentEN.id_Major); //专业流水号
 }
 else
 {
 sbSQL.Append(" id_Major = null,"); //专业流水号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Memo))
 {
 if (objStudentEN.Memo !=  null)
 {
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objStudentEN.Memo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objStudentEN.OrderNum); //排序
 }
 
 if (objStudentEN.IsUpdated(conStudent.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objStudentEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objStudentEN.IsUpdated(conStudent.Sex))
 {
 if (objStudentEN.Sex !=  null)
 {
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sex = '{0}',", objStudentEN.Sex); //Sex
 }
 else
 {
 sbSQL.Append(" Sex = null,"); //Sex
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsStudentEN objStudentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objStudentEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Student Set ");
 
 if (objStudentEN.IsUpdated(conStudent.StuID))
 {
 if (objStudentEN.StuID !=  null)
 {
 objStudentEN.StuID = objStudentEN.StuID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.StuID, conStudent.StuID); //学号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.StuID); //学号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.StuName))
 {
 if (objStudentEN.StuName !=  null)
 {
 objStudentEN.StuName = objStudentEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.StuName, conStudent.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.StuName); //姓名
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Age))
 {
 sbSQL.AppendFormat("{1} = {0},",objStudentEN.Age, conStudent.Age); //Age
 }
 
 if (objStudentEN.IsUpdated(conStudent.CollegeId))
 {
 if (objStudentEN.CollegeId !=  null)
 {
 objStudentEN.CollegeId = objStudentEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.CollegeId, conStudent.CollegeId); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.CollegeId); //学院Id
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.id_Major))
 {
 if (objStudentEN.id_Major !=  null)
 {
 objStudentEN.id_Major = objStudentEN.id_Major.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.id_Major, conStudent.id_Major); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.id_Major); //专业流水号
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.Memo))
 {
 if (objStudentEN.Memo !=  null)
 {
 objStudentEN.Memo = objStudentEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.Memo, conStudent.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.Memo); //备注
 }
 }
 
 if (objStudentEN.IsUpdated(conStudent.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objStudentEN.OrderNum, conStudent.OrderNum); //排序
 }
 
 if (objStudentEN.IsUpdated(conStudent.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentEN.IsDelete == true?"1":"0", conStudent.IsDelete); //是否删除
 }
 
 if (objStudentEN.IsUpdated(conStudent.Sex))
 {
 if (objStudentEN.Sex !=  null)
 {
 objStudentEN.Sex = objStudentEN.Sex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objStudentEN.Sex, conStudent.Sex); //Sex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudent.Sex); //Sex
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_stu = '{0}'", objStudentEN.id_stu); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strid_stu) 
{
CheckPrimaryKey(strid_stu);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strid_stu,
};
 objSQL.ExecSP("Student_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strid_stu, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strid_stu);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
//删除Student本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Student where id_stu = " + "'"+ strid_stu+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelStudent(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除Student本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Student where id_stu in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strid_stu) 
{
CheckPrimaryKey(strid_stu);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
//删除Student本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Student where id_stu = " + "'"+ strid_stu+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelStudent(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsStudentDA: DelStudent)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Student where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelStudentWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsStudentDA: DelStudentWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Student where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objStudentENS">源对象</param>
 /// <param name = "objStudentENT">目标对象</param>
public void CopyTo(clsStudentEN objStudentENS, clsStudentEN objStudentENT)
{
objStudentENT.id_stu = objStudentENS.id_stu; //学生流水号
objStudentENT.StuID = objStudentENS.StuID; //学号
objStudentENT.StuName = objStudentENS.StuName; //姓名
objStudentENT.Age = objStudentENS.Age; //Age
objStudentENT.CollegeId = objStudentENS.CollegeId; //学院Id
objStudentENT.id_Major = objStudentENS.id_Major; //专业流水号
objStudentENT.Memo = objStudentENS.Memo; //备注
objStudentENT.OrderNum = objStudentENS.OrderNum; //排序
objStudentENT.IsDelete = objStudentENS.IsDelete; //是否删除
objStudentENT.Sex = objStudentENS.Sex; //Sex
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsStudentEN objStudentEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objStudentEN.StuName, conStudent.StuName);
clsCheckSql.CheckFieldNotNull(objStudentEN.Age, conStudent.Age);
clsCheckSql.CheckFieldNotNull(objStudentEN.CollegeId, conStudent.CollegeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentEN.id_stu, 8, conStudent.id_stu);
clsCheckSql.CheckFieldLen(objStudentEN.StuID, 20, conStudent.StuID);
clsCheckSql.CheckFieldLen(objStudentEN.StuName, 50, conStudent.StuName);
clsCheckSql.CheckFieldLen(objStudentEN.CollegeId, 6, conStudent.CollegeId);
clsCheckSql.CheckFieldLen(objStudentEN.id_Major, 8, conStudent.id_Major);
clsCheckSql.CheckFieldLen(objStudentEN.Memo, 1000, conStudent.Memo);
clsCheckSql.CheckFieldLen(objStudentEN.Sex, 10, conStudent.Sex);
//检查字段外键固定长度
 objStudentEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsStudentEN objStudentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentEN.StuID, 20, conStudent.StuID);
clsCheckSql.CheckFieldLen(objStudentEN.StuName, 50, conStudent.StuName);
clsCheckSql.CheckFieldLen(objStudentEN.CollegeId, 6, conStudent.CollegeId);
clsCheckSql.CheckFieldLen(objStudentEN.id_Major, 8, conStudent.id_Major);
clsCheckSql.CheckFieldLen(objStudentEN.Memo, 1000, conStudent.Memo);
clsCheckSql.CheckFieldLen(objStudentEN.Sex, 10, conStudent.Sex);
//检查外键字段长度
 objStudentEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsStudentEN objStudentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentEN.id_stu, 8, conStudent.id_stu);
clsCheckSql.CheckFieldLen(objStudentEN.StuID, 20, conStudent.StuID);
clsCheckSql.CheckFieldLen(objStudentEN.StuName, 50, conStudent.StuName);
clsCheckSql.CheckFieldLen(objStudentEN.CollegeId, 6, conStudent.CollegeId);
clsCheckSql.CheckFieldLen(objStudentEN.id_Major, 8, conStudent.id_Major);
clsCheckSql.CheckFieldLen(objStudentEN.Memo, 1000, conStudent.Memo);
clsCheckSql.CheckFieldLen(objStudentEN.Sex, 10, conStudent.Sex);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objStudentEN.id_stu, conStudent.id_stu);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.StuID, conStudent.StuID);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.StuName, conStudent.StuName);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.CollegeId, conStudent.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.id_Major, conStudent.id_Major);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.Memo, conStudent.Memo);
clsCheckSql.CheckSqlInjection4Field(objStudentEN.Sex, conStudent.Sex);
//检查外键字段长度
 objStudentEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable Getid_stu()
{
//获取某学院所有专业信息
string strSQL = "select id_stu, StuName from Student ";
 clsSpecSQLforSql mySql = clsStudentDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strid_stu">学生流水号(主键)</param>
 /// <returns></returns>
public bool CheckStudentUniqueness(string strid_stu )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("id_stu !=  '{0}'", strid_stu);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckStudentUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Student(学生),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objStudentEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr_StuID(clsStudentEN objStudentEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objStudentEN.StuID == null)
{
 sbCondition.AppendFormat(" and StuID is null");
}
else
{
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentEN.StuID);
}
return sbCondition.ToString();
}

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
 objSQL = clsStudentDA.GetSpecSQLObj();
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
 objSQL = clsStudentDA.GetSpecSQLObj();
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
 objSQL = clsStudentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsStudentEN._CurrTabName_S);
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
 objSQL = clsStudentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsStudentEN._CurrTabName_S, strCondition);
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
 objSQL = clsStudentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}