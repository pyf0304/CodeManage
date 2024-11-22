
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuErrorLibDA
 表名:ge_StuErrorLib(01120887)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 学生错误作业集(ge_StuErrorLib)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_StuErrorLibDA : clsCommBase4DA
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
 return clsge_StuErrorLibEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_StuErrorLibEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StuErrorLibEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_StuErrorLibEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_StuErrorLibEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_StuErrorLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable_ge_StuErrorLib)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StuErrorLib.* from ge_StuErrorLib Left Join {1} on {2} where {3} and ge_StuErrorLib.mId not in (Select top {5} ge_StuErrorLib.mId from ge_StuErrorLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1} and mId not in (Select top {2} mId from ge_StuErrorLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1} and mId not in (Select top {3} mId from ge_StuErrorLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StuErrorLib.* from ge_StuErrorLib Left Join {1} on {2} where {3} and ge_StuErrorLib.mId not in (Select top {5} ge_StuErrorLib.mId from ge_StuErrorLib Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1} and mId not in (Select top {2} mId from ge_StuErrorLib where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StuErrorLib where {1} and mId not in (Select top {3} mId from ge_StuErrorLib where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_StuErrorLibEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA:GetObjLst)", objException.Message));
}
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = TransNullToInt(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = TransNullToInt(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = TransNullToBool(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = TransNullToBool(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StuErrorLibDA: GetObjLst)", objException.Message));
}
objge_StuErrorLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StuErrorLibEN);
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
public List<clsge_StuErrorLibEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = TransNullToInt(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = TransNullToInt(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = TransNullToBool(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = TransNullToBool(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StuErrorLibDA: GetObjLst)", objException.Message));
}
objge_StuErrorLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_StuErrorLib(ref clsge_StuErrorLibEN objge_StuErrorLibEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where mId = " + ""+ objge_StuErrorLibEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_StuErrorLibEN.mId = TransNullToInt(objDT.Rows[0][conge_StuErrorLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.CourseId = objDT.Rows[0][conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.IdStudentInfo = objDT.Rows[0][conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StuErrorLibEN.QuestionId = TransNullToInt(objDT.Rows[0][conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.Creator = objDT.Rows[0][conge_StuErrorLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objge_StuErrorLibEN.CreateDate = objDT.Rows[0][conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.SourceTypeId = objDT.Rows[0][conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StuErrorLibEN.IsRedo = TransNullToBool(objDT.Rows[0][conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objge_StuErrorLibEN.RedoDate = objDT.Rows[0][conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.IsPassed = TransNullToBool(objDT.Rows[0][conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objge_StuErrorLibEN.UpdDate = objDT.Rows[0][conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.UpdUser = objDT.Rows[0][conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.Memo = objDT.Rows[0][conge_StuErrorLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_StuErrorLibDA: Getge_StuErrorLib)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_StuErrorLibEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
 objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做(字段类型:bit,字段长度:1,是否可空:False)
 objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期(字段类型:varchar,字段长度:8,是否可空:True)
 objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过(字段类型:bit,字段长度:1,是否可空:False)
 objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_StuErrorLibDA: GetObjBymId)", objException.Message));
}
return objge_StuErrorLibEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_StuErrorLibEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN()
{
mId = TransNullToInt(objRow[conge_StuErrorLib.mId].ToString().Trim()), //mId
CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(), //课程Id
IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(), //学生流水号
QuestionId = TransNullToInt(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()), //题目Id
Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(), //创建者
CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(), //建立日期
SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(), //来源类型Id
IsRedo = TransNullToBool(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()), //是否重做
RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(), //重做日期
IsPassed = TransNullToBool(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()), //是否通过
UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim() //备注
};
objge_StuErrorLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuErrorLibEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_StuErrorLibDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_StuErrorLibEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = TransNullToInt(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = TransNullToInt(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = TransNullToBool(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = TransNullToBool(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_StuErrorLibDA: GetObjByDataRowge_StuErrorLib)", objException.Message));
}
objge_StuErrorLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuErrorLibEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_StuErrorLibEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = TransNullToInt(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = TransNullToInt(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = TransNullToBool(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = TransNullToBool(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_StuErrorLibDA: GetObjByDataRow)", objException.Message));
}
objge_StuErrorLibEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StuErrorLibEN;
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
objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StuErrorLibEN._CurrTabName, conge_StuErrorLib.mId, 8, "");
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
objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StuErrorLibEN._CurrTabName, conge_StuErrorLib.mId, 8, strPrefix);
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ge_StuErrorLib where " + strCondition;
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ge_StuErrorLib where " + strCondition;
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StuErrorLib", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StuErrorLib", strCondition))
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
objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_StuErrorLib");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_StuErrorLibEN objge_StuErrorLibEN)
 {
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuErrorLibEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StuErrorLib");
objRow = objDS.Tables["ge_StuErrorLib"].NewRow();
objRow[conge_StuErrorLib.CourseId] = objge_StuErrorLibEN.CourseId; //课程Id
objRow[conge_StuErrorLib.IdStudentInfo] = objge_StuErrorLibEN.IdStudentInfo; //学生流水号
objRow[conge_StuErrorLib.QuestionId] = objge_StuErrorLibEN.QuestionId; //题目Id
 if (objge_StuErrorLibEN.Creator !=  "")
 {
objRow[conge_StuErrorLib.Creator] = objge_StuErrorLibEN.Creator; //创建者
 }
 if (objge_StuErrorLibEN.CreateDate !=  "")
 {
objRow[conge_StuErrorLib.CreateDate] = objge_StuErrorLibEN.CreateDate; //建立日期
 }
objRow[conge_StuErrorLib.SourceTypeId] = objge_StuErrorLibEN.SourceTypeId; //来源类型Id
objRow[conge_StuErrorLib.IsRedo] = objge_StuErrorLibEN.IsRedo; //是否重做
 if (objge_StuErrorLibEN.RedoDate !=  "")
 {
objRow[conge_StuErrorLib.RedoDate] = objge_StuErrorLibEN.RedoDate; //重做日期
 }
objRow[conge_StuErrorLib.IsPassed] = objge_StuErrorLibEN.IsPassed; //是否通过
 if (objge_StuErrorLibEN.UpdDate !=  "")
 {
objRow[conge_StuErrorLib.UpdDate] = objge_StuErrorLibEN.UpdDate; //修改日期
 }
 if (objge_StuErrorLibEN.UpdUser !=  "")
 {
objRow[conge_StuErrorLib.UpdUser] = objge_StuErrorLibEN.UpdUser; //修改人
 }
 if (objge_StuErrorLibEN.Memo !=  "")
 {
objRow[conge_StuErrorLib.Memo] = objge_StuErrorLibEN.Memo; //备注
 }
objDS.Tables[clsge_StuErrorLibEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_StuErrorLibEN._CurrTabName);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuErrorLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CourseId);
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.IdStudentInfo);
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.QuestionId);
 arrValueListForInsert.Add(objge_StuErrorLibEN.QuestionId.ToString());
 
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Creator);
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CreateDate);
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.SourceTypeId);
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsRedo);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.RedoDate);
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsPassed);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdDate);
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdUser);
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Memo);
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuErrorLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuErrorLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CourseId);
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.IdStudentInfo);
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.QuestionId);
 arrValueListForInsert.Add(objge_StuErrorLibEN.QuestionId.ToString());
 
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Creator);
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CreateDate);
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.SourceTypeId);
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsRedo);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.RedoDate);
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsPassed);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdDate);
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdUser);
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Memo);
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuErrorLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StuErrorLibEN objge_StuErrorLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuErrorLibEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CourseId);
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.IdStudentInfo);
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.QuestionId);
 arrValueListForInsert.Add(objge_StuErrorLibEN.QuestionId.ToString());
 
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Creator);
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CreateDate);
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.SourceTypeId);
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsRedo);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.RedoDate);
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsPassed);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdDate);
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdUser);
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Memo);
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuErrorLib");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StuErrorLibEN objge_StuErrorLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StuErrorLibEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CourseId);
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.IdStudentInfo);
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.QuestionId);
 arrValueListForInsert.Add(objge_StuErrorLibEN.QuestionId.ToString());
 
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Creator);
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.CreateDate);
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.SourceTypeId);
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsRedo);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsRedo  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.RedoDate);
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRedoDate + "'");
 }
 
 arrFieldListForInsert.Add(conge_StuErrorLib.IsPassed);
 arrValueListForInsert.Add("'" + (objge_StuErrorLibEN.IsPassed  ==  false ? "0" : "1") + "'");
 
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdDate);
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.UpdUser);
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StuErrorLib.Memo);
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StuErrorLib");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_StuErrorLibs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StuErrorLib");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_StuErrorLibEN._CurrTabName ].NewRow();
objRow[conge_StuErrorLib.CourseId] = oRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objRow[conge_StuErrorLib.IdStudentInfo] = oRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[conge_StuErrorLib.QuestionId] = oRow[conge_StuErrorLib.QuestionId].ToString().Trim(); //题目Id
objRow[conge_StuErrorLib.Creator] = oRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objRow[conge_StuErrorLib.CreateDate] = oRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objRow[conge_StuErrorLib.SourceTypeId] = oRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objRow[conge_StuErrorLib.IsRedo] = oRow[conge_StuErrorLib.IsRedo].ToString().Trim(); //是否重做
objRow[conge_StuErrorLib.RedoDate] = oRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objRow[conge_StuErrorLib.IsPassed] = oRow[conge_StuErrorLib.IsPassed].ToString().Trim(); //是否通过
objRow[conge_StuErrorLib.UpdDate] = oRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objRow[conge_StuErrorLib.UpdUser] = oRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objRow[conge_StuErrorLib.Memo] = oRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
 objDS.Tables[clsge_StuErrorLibEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_StuErrorLibEN._CurrTabName);
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
 /// <param name = "objge_StuErrorLibEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuErrorLibEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
strSQL = "Select * from ge_StuErrorLib where mId = " + ""+ objge_StuErrorLibEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_StuErrorLibEN._CurrTabName);
if (objDS.Tables[clsge_StuErrorLibEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objge_StuErrorLibEN.mId+"");
return false;
}
objRow = objDS.Tables[clsge_StuErrorLibEN._CurrTabName].Rows[0];
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CourseId))
 {
objRow[conge_StuErrorLib.CourseId] = objge_StuErrorLibEN.CourseId; //课程Id
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IdStudentInfo))
 {
objRow[conge_StuErrorLib.IdStudentInfo] = objge_StuErrorLibEN.IdStudentInfo; //学生流水号
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.QuestionId))
 {
objRow[conge_StuErrorLib.QuestionId] = objge_StuErrorLibEN.QuestionId; //题目Id
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Creator))
 {
objRow[conge_StuErrorLib.Creator] = objge_StuErrorLibEN.Creator; //创建者
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CreateDate))
 {
objRow[conge_StuErrorLib.CreateDate] = objge_StuErrorLibEN.CreateDate; //建立日期
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.SourceTypeId))
 {
objRow[conge_StuErrorLib.SourceTypeId] = objge_StuErrorLibEN.SourceTypeId; //来源类型Id
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsRedo))
 {
objRow[conge_StuErrorLib.IsRedo] = objge_StuErrorLibEN.IsRedo; //是否重做
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.RedoDate))
 {
objRow[conge_StuErrorLib.RedoDate] = objge_StuErrorLibEN.RedoDate; //重做日期
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsPassed))
 {
objRow[conge_StuErrorLib.IsPassed] = objge_StuErrorLibEN.IsPassed; //是否通过
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdDate))
 {
objRow[conge_StuErrorLib.UpdDate] = objge_StuErrorLibEN.UpdDate; //修改日期
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdUser))
 {
objRow[conge_StuErrorLib.UpdUser] = objge_StuErrorLibEN.UpdUser; //修改人
 }
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Memo))
 {
objRow[conge_StuErrorLib.Memo] = objge_StuErrorLibEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsge_StuErrorLibEN._CurrTabName);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuErrorLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_StuErrorLib Set ");
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CourseId))
 {
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StuErrorLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.CourseId); //课程Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IdStudentInfo))
 {
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, conge_StuErrorLib.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.IdStudentInfo); //学生流水号
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuErrorLibEN.QuestionId, conge_StuErrorLib.QuestionId); //题目Id
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Creator))
 {
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, conge_StuErrorLib.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.Creator); //创建者
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CreateDate))
 {
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conge_StuErrorLib.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.CreateDate); //建立日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.SourceTypeId))
 {
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceTypeId, conge_StuErrorLib.SourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.SourceTypeId); //来源类型Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsRedo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuErrorLibEN.IsRedo == true?"1":"0", conge_StuErrorLib.IsRedo); //是否重做
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.RedoDate))
 {
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRedoDate, conge_StuErrorLib.RedoDate); //重做日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.RedoDate); //重做日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsPassed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuErrorLibEN.IsPassed == true?"1":"0", conge_StuErrorLib.IsPassed); //是否通过
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdDate))
 {
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StuErrorLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.UpdDate); //修改日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdUser))
 {
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StuErrorLib.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.UpdUser); //修改人
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Memo))
 {
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StuErrorLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_StuErrorLibEN.mId); 
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
 /// <param name = "objge_StuErrorLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_StuErrorLibEN objge_StuErrorLibEN, string strCondition)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuErrorLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuErrorLib Set ");
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CourseId))
 {
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IdStudentInfo))
 {
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_StuErrorLibEN.QuestionId); //题目Id
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Creator))
 {
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CreateDate))
 {
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.SourceTypeId))
 {
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceTypeId = '{0}',", strSourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.Append(" SourceTypeId = null,"); //来源类型Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsRedo))
 {
 sbSQL.AppendFormat(" IsRedo = '{0}',", objge_StuErrorLibEN.IsRedo == true?"1":"0"); //是否重做
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.RedoDate))
 {
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RedoDate = '{0}',", strRedoDate); //重做日期
 }
 else
 {
 sbSQL.Append(" RedoDate = null,"); //重做日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsPassed))
 {
 sbSQL.AppendFormat(" IsPassed = '{0}',", objge_StuErrorLibEN.IsPassed == true?"1":"0"); //是否通过
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdDate))
 {
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdUser))
 {
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Memo))
 {
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objge_StuErrorLibEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_StuErrorLibEN objge_StuErrorLibEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuErrorLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuErrorLib Set ");
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CourseId))
 {
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IdStudentInfo))
 {
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_StuErrorLibEN.QuestionId); //题目Id
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Creator))
 {
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CreateDate))
 {
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.SourceTypeId))
 {
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceTypeId = '{0}',", strSourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.Append(" SourceTypeId = null,"); //来源类型Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsRedo))
 {
 sbSQL.AppendFormat(" IsRedo = '{0}',", objge_StuErrorLibEN.IsRedo == true?"1":"0"); //是否重做
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.RedoDate))
 {
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RedoDate = '{0}',", strRedoDate); //重做日期
 }
 else
 {
 sbSQL.Append(" RedoDate = null,"); //重做日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsPassed))
 {
 sbSQL.AppendFormat(" IsPassed = '{0}',", objge_StuErrorLibEN.IsPassed == true?"1":"0"); //是否通过
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdDate))
 {
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdUser))
 {
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Memo))
 {
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StuErrorLibEN objge_StuErrorLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StuErrorLibEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StuErrorLibEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StuErrorLib Set ");
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CourseId))
 {
 if (objge_StuErrorLibEN.CourseId !=  null)
 {
 var strCourseId = objge_StuErrorLibEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StuErrorLib.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.CourseId); //课程Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IdStudentInfo))
 {
 if (objge_StuErrorLibEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objge_StuErrorLibEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, conge_StuErrorLib.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.IdStudentInfo); //学生流水号
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StuErrorLibEN.QuestionId, conge_StuErrorLib.QuestionId); //题目Id
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Creator))
 {
 if (objge_StuErrorLibEN.Creator !=  null)
 {
 var strCreator = objge_StuErrorLibEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, conge_StuErrorLib.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.Creator); //创建者
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.CreateDate))
 {
 if (objge_StuErrorLibEN.CreateDate !=  null)
 {
 var strCreateDate = objge_StuErrorLibEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conge_StuErrorLib.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.CreateDate); //建立日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.SourceTypeId))
 {
 if (objge_StuErrorLibEN.SourceTypeId !=  null)
 {
 var strSourceTypeId = objge_StuErrorLibEN.SourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceTypeId, conge_StuErrorLib.SourceTypeId); //来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.SourceTypeId); //来源类型Id
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsRedo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuErrorLibEN.IsRedo == true?"1":"0", conge_StuErrorLib.IsRedo); //是否重做
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.RedoDate))
 {
 if (objge_StuErrorLibEN.RedoDate !=  null)
 {
 var strRedoDate = objge_StuErrorLibEN.RedoDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRedoDate, conge_StuErrorLib.RedoDate); //重做日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.RedoDate); //重做日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.IsPassed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StuErrorLibEN.IsPassed == true?"1":"0", conge_StuErrorLib.IsPassed); //是否通过
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdDate))
 {
 if (objge_StuErrorLibEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StuErrorLibEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StuErrorLib.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.UpdDate); //修改日期
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.UpdUser))
 {
 if (objge_StuErrorLibEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StuErrorLibEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StuErrorLib.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.UpdUser); //修改人
 }
 }
 
 if (objge_StuErrorLibEN.IsUpdated(conge_StuErrorLib.Memo))
 {
 if (objge_StuErrorLibEN.Memo !=  null)
 {
 var strMemo = objge_StuErrorLibEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StuErrorLib.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StuErrorLib.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_StuErrorLibEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ge_StuErrorLib_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
//删除ge_StuErrorLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuErrorLib where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_StuErrorLib(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除ge_StuErrorLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuErrorLib where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
//删除ge_StuErrorLib本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StuErrorLib where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_StuErrorLib(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: Delge_StuErrorLib)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StuErrorLib where " + strCondition ;
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
public bool Delge_StuErrorLibWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_StuErrorLibDA: Delge_StuErrorLibWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StuErrorLib where " + strCondition ;
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
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <param name = "objge_StuErrorLibENT">目标对象</param>
public void CopyTo(clsge_StuErrorLibEN objge_StuErrorLibENS, clsge_StuErrorLibEN objge_StuErrorLibENT)
{
objge_StuErrorLibENT.mId = objge_StuErrorLibENS.mId; //mId
objge_StuErrorLibENT.CourseId = objge_StuErrorLibENS.CourseId; //课程Id
objge_StuErrorLibENT.IdStudentInfo = objge_StuErrorLibENS.IdStudentInfo; //学生流水号
objge_StuErrorLibENT.QuestionId = objge_StuErrorLibENS.QuestionId; //题目Id
objge_StuErrorLibENT.Creator = objge_StuErrorLibENS.Creator; //创建者
objge_StuErrorLibENT.CreateDate = objge_StuErrorLibENS.CreateDate; //建立日期
objge_StuErrorLibENT.SourceTypeId = objge_StuErrorLibENS.SourceTypeId; //来源类型Id
objge_StuErrorLibENT.IsRedo = objge_StuErrorLibENS.IsRedo; //是否重做
objge_StuErrorLibENT.RedoDate = objge_StuErrorLibENS.RedoDate; //重做日期
objge_StuErrorLibENT.IsPassed = objge_StuErrorLibENS.IsPassed; //是否通过
objge_StuErrorLibENT.UpdDate = objge_StuErrorLibENS.UpdDate; //修改日期
objge_StuErrorLibENT.UpdUser = objge_StuErrorLibENS.UpdUser; //修改人
objge_StuErrorLibENT.Memo = objge_StuErrorLibENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_StuErrorLibEN.CourseId, conge_StuErrorLib.CourseId);
clsCheckSql.CheckFieldNotNull(objge_StuErrorLibEN.IdStudentInfo, conge_StuErrorLib.IdStudentInfo);
clsCheckSql.CheckFieldNotNull(objge_StuErrorLibEN.QuestionId, conge_StuErrorLib.QuestionId);
clsCheckSql.CheckFieldNotNull(objge_StuErrorLibEN.SourceTypeId, conge_StuErrorLib.SourceTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CourseId, 8, conge_StuErrorLib.CourseId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.IdStudentInfo, 8, conge_StuErrorLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Creator, 18, conge_StuErrorLib.Creator);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CreateDate, 20, conge_StuErrorLib.CreateDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.SourceTypeId, 2, conge_StuErrorLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.RedoDate, 8, conge_StuErrorLib.RedoDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdDate, 20, conge_StuErrorLib.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdUser, 20, conge_StuErrorLib.UpdUser);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Memo, 1000, conge_StuErrorLib.Memo);
//检查字段外键固定长度
 objge_StuErrorLibEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CourseId, 8, conge_StuErrorLib.CourseId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.IdStudentInfo, 8, conge_StuErrorLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Creator, 18, conge_StuErrorLib.Creator);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CreateDate, 20, conge_StuErrorLib.CreateDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.SourceTypeId, 2, conge_StuErrorLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.RedoDate, 8, conge_StuErrorLib.RedoDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdDate, 20, conge_StuErrorLib.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdUser, 20, conge_StuErrorLib.UpdUser);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Memo, 1000, conge_StuErrorLib.Memo);
//检查外键字段长度
 objge_StuErrorLibEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CourseId, 8, conge_StuErrorLib.CourseId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.IdStudentInfo, 8, conge_StuErrorLib.IdStudentInfo);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Creator, 18, conge_StuErrorLib.Creator);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.CreateDate, 20, conge_StuErrorLib.CreateDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.SourceTypeId, 2, conge_StuErrorLib.SourceTypeId);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.RedoDate, 8, conge_StuErrorLib.RedoDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdDate, 20, conge_StuErrorLib.UpdDate);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.UpdUser, 20, conge_StuErrorLib.UpdUser);
clsCheckSql.CheckFieldLen(objge_StuErrorLibEN.Memo, 1000, conge_StuErrorLib.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.CourseId, conge_StuErrorLib.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.IdStudentInfo, conge_StuErrorLib.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.Creator, conge_StuErrorLib.Creator);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.CreateDate, conge_StuErrorLib.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.SourceTypeId, conge_StuErrorLib.SourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.RedoDate, conge_StuErrorLib.RedoDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.UpdDate, conge_StuErrorLib.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.UpdUser, conge_StuErrorLib.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_StuErrorLibEN.Memo, conge_StuErrorLib.Memo);
//检查外键字段长度
 objge_StuErrorLibEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_StuErrorLib(学生错误作业集),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objge_StuErrorLibEN.IdStudentInfo);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuErrorLibEN.QuestionId);
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StuErrorLibEN._CurrTabName);
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StuErrorLibEN._CurrTabName, strCondition);
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
 objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}