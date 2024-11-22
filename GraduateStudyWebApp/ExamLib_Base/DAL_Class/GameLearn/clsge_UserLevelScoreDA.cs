﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserLevelScoreDA
 表名:ge_UserLevelScore(01120942)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 用户闯关得分(ge_UserLevelScore)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_UserLevelScoreDA : clsCommBase4DA
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
 return clsge_UserLevelScoreEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_UserLevelScoreEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_UserLevelScoreEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_UserLevelScoreEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_UserLevelScoreEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCurrEduCls)
{
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ge_UserLevelScore中,检查关键字,长度不正确!(clsge_UserLevelScoreDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_UserLevelScore中,关键字不能为空 或 null!(clsge_UserLevelScoreDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_UserLevelScoreDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_UserLevelScore(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable_ge_UserLevelScore)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_UserLevelScore.* from ge_UserLevelScore Left Join {1} on {2} where {3} and ge_UserLevelScore.IdCurrEduCls not in (Select top {5} ge_UserLevelScore.IdCurrEduCls from ge_UserLevelScore Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from ge_UserLevelScore where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from ge_UserLevelScore where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_UserLevelScore.* from ge_UserLevelScore Left Join {1} on {2} where {3} and ge_UserLevelScore.IdCurrEduCls not in (Select top {5} ge_UserLevelScore.IdCurrEduCls from ge_UserLevelScore Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from ge_UserLevelScore where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserLevelScore where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from ge_UserLevelScore where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_UserLevelScoreEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA:GetObjLst)", objException.Message));
}
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = TransNullToBool(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = TransNullToInt(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetObjLst)", objException.Message));
}
objge_UserLevelScoreEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_UserLevelScoreEN);
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
public List<clsge_UserLevelScoreEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = TransNullToBool(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = TransNullToInt(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetObjLst)", objException.Message));
}
objge_UserLevelScoreEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_UserLevelScoreEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_UserLevelScore(ref clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where IdCurrEduCls = " + "'"+ objge_UserLevelScoreEN.IdCurrEduCls+"'" + " and GameLevelId = " + "'"+ objge_UserLevelScoreEN.GameLevelId+"'" + " and UserId = " + "'"+ objge_UserLevelScoreEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_UserLevelScoreEN.IdCurrEduCls = objDT.Rows[0][conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_UserLevelScoreEN.GameLevelId = objDT.Rows[0][conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserLevelScoreEN.UserId = objDT.Rows[0][conge_UserLevelScore.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_UserLevelScoreEN.CourseId = objDT.Rows[0][conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserLevelScoreEN.Passed = TransNullToBool(objDT.Rows[0][conge_UserLevelScore.Passed].ToString().Trim()); //是否合格(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserLevelScoreEN.Credits = TransNullToInt(objDT.Rows[0][conge_UserLevelScore.Credits].ToString().Trim()); //积分(字段类型:int,字段长度:4,是否可空:True)
 objge_UserLevelScoreEN.GetDate = objDT.Rows[0][conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.GetInstructions = objDT.Rows[0][conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明(字段类型:varchar,字段长度:100,是否可空:True)
 objge_UserLevelScoreEN.BadgeNum = TransNullToInt(objDT.Rows[0][conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量(字段类型:int,字段长度:4,是否可空:True)
 objge_UserLevelScoreEN.UpdDate = objDT.Rows[0][conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.UpdUser = objDT.Rows[0][conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.Memo = objDT.Rows[0][conge_UserLevelScore.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_UserLevelScoreDA: Getge_UserLevelScore)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_UserLevelScoreEN GetObjByKeyLst(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'" + " and GameLevelId = " + "'"+ strGameLevelId+"'" + " and UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
 objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分(字段类型:int,字段长度:4,是否可空:True)
 objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明(字段类型:varchar,字段长度:100,是否可空:True)
 objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量(字段类型:int,字段长度:4,是否可空:True)
 objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetObjByKeyLst)", objException.Message));
}
return objge_UserLevelScoreEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_UserLevelScoreEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN()
{
IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(), //教学班流水号
GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(), //游戏关卡Id
UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(), //用户ID
CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(), //课程Id
Passed = TransNullToBool(objRow[conge_UserLevelScore.Passed].ToString().Trim()), //是否合格
Credits = TransNullToInt(objRow[conge_UserLevelScore.Credits].ToString().Trim()), //积分
GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(), //获取日期
GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(), //获取说明
BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()), //徽章数量
UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim() //备注
};
objge_UserLevelScoreEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserLevelScoreEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_UserLevelScoreEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = TransNullToBool(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = TransNullToInt(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetObjByDataRowge_UserLevelScore)", objException.Message));
}
objge_UserLevelScoreEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserLevelScoreEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_UserLevelScoreEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = TransNullToBool(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = TransNullToInt(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_UserLevelScoreDA: GetObjByDataRow)", objException.Message));
}
objge_UserLevelScoreEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserLevelScoreEN;
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
objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_UserLevelScoreEN._CurrTabName, conge_UserLevelScore.IdCurrEduCls, 8, "");
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
objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_UserLevelScoreEN._CurrTabName, conge_UserLevelScore.IdCurrEduCls, 8, strPrefix);
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls,GameLevelId,UserId from ge_UserLevelScore where " + strCondition;
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls,GameLevelId,UserId from ge_UserLevelScore where " + strCondition;
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCurrEduCls, string strGameLevelId, string strUserId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_UserLevelScore", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'" + " and GameLevelId = " + "'"+ strGameLevelId+"'" + " and UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_UserLevelScore", strCondition))
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
objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_UserLevelScore");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
 {
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserLevelScoreEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_UserLevelScore");
objRow = objDS.Tables["ge_UserLevelScore"].NewRow();
objRow[conge_UserLevelScore.IdCurrEduCls] = objge_UserLevelScoreEN.IdCurrEduCls; //教学班流水号
objRow[conge_UserLevelScore.GameLevelId] = objge_UserLevelScoreEN.GameLevelId; //游戏关卡Id
objRow[conge_UserLevelScore.UserId] = objge_UserLevelScoreEN.UserId; //用户ID
objRow[conge_UserLevelScore.CourseId] = objge_UserLevelScoreEN.CourseId; //课程Id
objRow[conge_UserLevelScore.Passed] = objge_UserLevelScoreEN.Passed; //是否合格
objRow[conge_UserLevelScore.Credits] = objge_UserLevelScoreEN.Credits; //积分
 if (objge_UserLevelScoreEN.GetDate !=  "")
 {
objRow[conge_UserLevelScore.GetDate] = objge_UserLevelScoreEN.GetDate; //获取日期
 }
 if (objge_UserLevelScoreEN.GetInstructions !=  "")
 {
objRow[conge_UserLevelScore.GetInstructions] = objge_UserLevelScoreEN.GetInstructions; //获取说明
 }
objRow[conge_UserLevelScore.BadgeNum] = objge_UserLevelScoreEN.BadgeNum; //徽章数量
 if (objge_UserLevelScoreEN.UpdDate !=  "")
 {
objRow[conge_UserLevelScore.UpdDate] = objge_UserLevelScoreEN.UpdDate; //修改日期
 }
 if (objge_UserLevelScoreEN.UpdUser !=  "")
 {
objRow[conge_UserLevelScore.UpdUser] = objge_UserLevelScoreEN.UpdUser; //修改人
 }
 if (objge_UserLevelScoreEN.Memo !=  "")
 {
objRow[conge_UserLevelScore.Memo] = objge_UserLevelScoreEN.Memo; //备注
 }
objDS.Tables[clsge_UserLevelScoreEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_UserLevelScoreEN._CurrTabName);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserLevelScoreEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_UserLevelScoreEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserLevelScoreEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserLevelScoreEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GameLevelId);
 var strGameLevelId = objge_UserLevelScoreEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_UserLevelScoreEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UserId);
 var strUserId = objge_UserLevelScoreEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.CourseId);
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Passed);
 arrValueListForInsert.Add("'" + (objge_UserLevelScoreEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Credits);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.Credits.ToString());
 
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetDate);
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetInstructions);
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.BadgeNum);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.BadgeNum.ToString());
 }
 
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdDate);
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdUser);
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.Memo);
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserLevelScore");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserLevelScoreEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_UserLevelScoreEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserLevelScoreEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserLevelScoreEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GameLevelId);
 var strGameLevelId = objge_UserLevelScoreEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_UserLevelScoreEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UserId);
 var strUserId = objge_UserLevelScoreEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.CourseId);
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Passed);
 arrValueListForInsert.Add("'" + (objge_UserLevelScoreEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Credits);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.Credits.ToString());
 
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetDate);
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetInstructions);
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.BadgeNum);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.BadgeNum.ToString());
 }
 
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdDate);
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdUser);
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.Memo);
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserLevelScore");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_UserLevelScoreEN.IdCurrEduCls;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_UserLevelScoreEN objge_UserLevelScoreEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserLevelScoreEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_UserLevelScoreEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserLevelScoreEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserLevelScoreEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GameLevelId);
 var strGameLevelId = objge_UserLevelScoreEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_UserLevelScoreEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UserId);
 var strUserId = objge_UserLevelScoreEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.CourseId);
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Passed);
 arrValueListForInsert.Add("'" + (objge_UserLevelScoreEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Credits);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.Credits.ToString());
 
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetDate);
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetInstructions);
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.BadgeNum);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.BadgeNum.ToString());
 }
 
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdDate);
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdUser);
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.Memo);
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserLevelScore");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_UserLevelScoreEN.IdCurrEduCls;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_UserLevelScoreEN objge_UserLevelScoreEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserLevelScoreEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_UserLevelScoreEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserLevelScoreEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserLevelScoreEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GameLevelId);
 var strGameLevelId = objge_UserLevelScoreEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_UserLevelScoreEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UserId);
 var strUserId = objge_UserLevelScoreEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.CourseId);
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Passed);
 arrValueListForInsert.Add("'" + (objge_UserLevelScoreEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserLevelScore.Credits);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.Credits.ToString());
 
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetDate);
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.GetInstructions);
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.BadgeNum);
 arrValueListForInsert.Add(objge_UserLevelScoreEN.BadgeNum.ToString());
 }
 
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdDate);
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.UpdUser);
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserLevelScore.Memo);
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserLevelScore");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_UserLevelScores(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where IdCurrEduCls = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_UserLevelScore");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCurrEduCls = oRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim();
string strGameLevelId = oRow[conge_UserLevelScore.GameLevelId].ToString().Trim();
string strUserId = oRow[conge_UserLevelScore.UserId].ToString().Trim();
if (IsExist(strIdCurrEduCls,strGameLevelId,strUserId))
{
 string strResult = "关键字变量值为:" + string.Format("IdCurrEduCls = {0},GameLevelId = {1},UserId = {2}", strIdCurrEduCls,strGameLevelId,strUserId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_UserLevelScoreEN._CurrTabName ].NewRow();
objRow[conge_UserLevelScore.IdCurrEduCls] = oRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conge_UserLevelScore.GameLevelId] = oRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objRow[conge_UserLevelScore.UserId] = oRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objRow[conge_UserLevelScore.CourseId] = oRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objRow[conge_UserLevelScore.Passed] = oRow[conge_UserLevelScore.Passed].ToString().Trim(); //是否合格
objRow[conge_UserLevelScore.Credits] = oRow[conge_UserLevelScore.Credits].ToString().Trim(); //积分
objRow[conge_UserLevelScore.GetDate] = oRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objRow[conge_UserLevelScore.GetInstructions] = oRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objRow[conge_UserLevelScore.BadgeNum] = oRow[conge_UserLevelScore.BadgeNum].ToString().Trim(); //徽章数量
objRow[conge_UserLevelScore.UpdDate] = oRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objRow[conge_UserLevelScore.UpdUser] = oRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objRow[conge_UserLevelScore.Memo] = oRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
 objDS.Tables[clsge_UserLevelScoreEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_UserLevelScoreEN._CurrTabName);
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
 /// <param name = "objge_UserLevelScoreEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserLevelScoreEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserLevelScore where IdCurrEduCls = " + "'"+ objge_UserLevelScoreEN.IdCurrEduCls+"'" + " and GameLevelId = " + "'"+ objge_UserLevelScoreEN.GameLevelId+"'" + " and UserId = " + "'"+ objge_UserLevelScoreEN.UserId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_UserLevelScoreEN._CurrTabName);
if (objDS.Tables[clsge_UserLevelScoreEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCurrEduCls = " + "'"+ objge_UserLevelScoreEN.IdCurrEduCls+"'" + " and GameLevelId = " + "'"+ objge_UserLevelScoreEN.GameLevelId+"'" + " and UserId = " + "'"+ objge_UserLevelScoreEN.UserId+"'");
return false;
}
objRow = objDS.Tables[clsge_UserLevelScoreEN._CurrTabName].Rows[0];
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.IdCurrEduCls))
 {
objRow[conge_UserLevelScore.IdCurrEduCls] = objge_UserLevelScoreEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GameLevelId))
 {
objRow[conge_UserLevelScore.GameLevelId] = objge_UserLevelScoreEN.GameLevelId; //游戏关卡Id
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UserId))
 {
objRow[conge_UserLevelScore.UserId] = objge_UserLevelScoreEN.UserId; //用户ID
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.CourseId))
 {
objRow[conge_UserLevelScore.CourseId] = objge_UserLevelScoreEN.CourseId; //课程Id
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Passed))
 {
objRow[conge_UserLevelScore.Passed] = objge_UserLevelScoreEN.Passed; //是否合格
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Credits))
 {
objRow[conge_UserLevelScore.Credits] = objge_UserLevelScoreEN.Credits; //积分
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetDate))
 {
objRow[conge_UserLevelScore.GetDate] = objge_UserLevelScoreEN.GetDate; //获取日期
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetInstructions))
 {
objRow[conge_UserLevelScore.GetInstructions] = objge_UserLevelScoreEN.GetInstructions; //获取说明
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.BadgeNum))
 {
objRow[conge_UserLevelScore.BadgeNum] = objge_UserLevelScoreEN.BadgeNum; //徽章数量
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdDate))
 {
objRow[conge_UserLevelScore.UpdDate] = objge_UserLevelScoreEN.UpdDate; //修改日期
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdUser))
 {
objRow[conge_UserLevelScore.UpdUser] = objge_UserLevelScoreEN.UpdUser; //修改人
 }
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Memo))
 {
objRow[conge_UserLevelScore.Memo] = objge_UserLevelScoreEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsge_UserLevelScoreEN._CurrTabName);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserLevelScoreEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_UserLevelScore Set ");
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.CourseId))
 {
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_UserLevelScore.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.CourseId); //课程Id
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Passed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserLevelScoreEN.Passed == true?"1":"0", conge_UserLevelScore.Passed); //是否合格
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Credits))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.Credits, conge_UserLevelScore.Credits); //积分
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetDate))
 {
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDate, conge_UserLevelScore.GetDate); //获取日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.GetDate); //获取日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetInstructions))
 {
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetInstructions, conge_UserLevelScore.GetInstructions); //获取说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.GetInstructions); //获取说明
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.BadgeNum))
 {
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.BadgeNum, conge_UserLevelScore.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdDate))
 {
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_UserLevelScore.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.UpdDate); //修改日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdUser))
 {
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_UserLevelScore.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.UpdUser); //修改人
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Memo))
 {
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_UserLevelScore.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}' And GameLevelId = '{1}' And UserId = '{2}'", objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId); 
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
 /// <param name = "objge_UserLevelScoreEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strCondition)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserLevelScoreEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserLevelScore Set ");
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.CourseId))
 {
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Passed))
 {
 sbSQL.AppendFormat(" Passed = '{0}',", objge_UserLevelScoreEN.Passed == true?"1":"0"); //是否合格
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Credits))
 {
 sbSQL.AppendFormat(" Credits = {0},", objge_UserLevelScoreEN.Credits); //积分
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetDate))
 {
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDate = '{0}',", strGetDate); //获取日期
 }
 else
 {
 sbSQL.Append(" GetDate = null,"); //获取日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetInstructions))
 {
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetInstructions = '{0}',", strGetInstructions); //获取说明
 }
 else
 {
 sbSQL.Append(" GetInstructions = null,"); //获取说明
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.BadgeNum))
 {
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.BadgeNum, conge_UserLevelScore.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdDate))
 {
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdUser))
 {
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Memo))
 {
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_UserLevelScoreEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserLevelScoreEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserLevelScore Set ");
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.CourseId))
 {
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Passed))
 {
 sbSQL.AppendFormat(" Passed = '{0}',", objge_UserLevelScoreEN.Passed == true?"1":"0"); //是否合格
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Credits))
 {
 sbSQL.AppendFormat(" Credits = {0},", objge_UserLevelScoreEN.Credits); //积分
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetDate))
 {
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDate = '{0}',", strGetDate); //获取日期
 }
 else
 {
 sbSQL.Append(" GetDate = null,"); //获取日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetInstructions))
 {
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetInstructions = '{0}',", strGetInstructions); //获取说明
 }
 else
 {
 sbSQL.Append(" GetInstructions = null,"); //获取说明
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.BadgeNum))
 {
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.BadgeNum, conge_UserLevelScore.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdDate))
 {
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdUser))
 {
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Memo))
 {
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_UserLevelScoreEN objge_UserLevelScoreEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_UserLevelScoreEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserLevelScoreEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserLevelScore Set ");
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.CourseId))
 {
 if (objge_UserLevelScoreEN.CourseId !=  null)
 {
 var strCourseId = objge_UserLevelScoreEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_UserLevelScore.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.CourseId); //课程Id
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Passed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserLevelScoreEN.Passed == true?"1":"0", conge_UserLevelScore.Passed); //是否合格
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Credits))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.Credits, conge_UserLevelScore.Credits); //积分
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetDate))
 {
 if (objge_UserLevelScoreEN.GetDate !=  null)
 {
 var strGetDate = objge_UserLevelScoreEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDate, conge_UserLevelScore.GetDate); //获取日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.GetDate); //获取日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.GetInstructions))
 {
 if (objge_UserLevelScoreEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserLevelScoreEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetInstructions, conge_UserLevelScore.GetInstructions); //获取说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.GetInstructions); //获取说明
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.BadgeNum))
 {
 if (objge_UserLevelScoreEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserLevelScoreEN.BadgeNum, conge_UserLevelScore.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdDate))
 {
 if (objge_UserLevelScoreEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserLevelScoreEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_UserLevelScore.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.UpdDate); //修改日期
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.UpdUser))
 {
 if (objge_UserLevelScoreEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserLevelScoreEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_UserLevelScore.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.UpdUser); //修改人
 }
 }
 
 if (objge_UserLevelScoreEN.IsUpdated(conge_UserLevelScore.Memo))
 {
 if (objge_UserLevelScoreEN.Memo !=  null)
 {
 var strMemo = objge_UserLevelScoreEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_UserLevelScore.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserLevelScore.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}' And GameLevelId = '{1}' And UserId = '{2}'", objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId); 
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCurrEduCls,string strGameLevelId,string strUserId) 
{
CheckPrimaryKey(strIdCurrEduCls);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCurrEduCls,
 strGameLevelId,
 strUserId,
};
 objSQL.ExecSP("ge_UserLevelScore_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCurrEduCls,string strGameLevelId,string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
//删除ge_UserLevelScore本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_UserLevelScore where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'" + " and GameLevelId = " + "'"+ strGameLevelId+"'" + " and UserId = " + "'"+ strUserId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strIdCurrEduCls = sstrKey[0];
string strGameLevelId = sstrKey[1];
string strUserId = sstrKey[2];
 int intRecNum  = this.DelRecord(strIdCurrEduCls,strGameLevelId,strUserId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "strGameLevelId">给定的关键字值</param>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCurrEduCls,string strGameLevelId,string strUserId) 
{
CheckPrimaryKey(strIdCurrEduCls);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
//删除ge_UserLevelScore本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_UserLevelScore where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'" + " and GameLevelId = " + "'"+ strGameLevelId+"'" + " and UserId = " + "'"+ strUserId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_UserLevelScore(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: Delge_UserLevelScore)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_UserLevelScore where " + strCondition ;
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
public bool Delge_UserLevelScoreWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_UserLevelScoreDA: Delge_UserLevelScoreWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_UserLevelScore where " + strCondition ;
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
 /// <param name = "objge_UserLevelScoreENS">源对象</param>
 /// <param name = "objge_UserLevelScoreENT">目标对象</param>
public void CopyTo(clsge_UserLevelScoreEN objge_UserLevelScoreENS, clsge_UserLevelScoreEN objge_UserLevelScoreENT)
{
objge_UserLevelScoreENT.IdCurrEduCls = objge_UserLevelScoreENS.IdCurrEduCls; //教学班流水号
objge_UserLevelScoreENT.GameLevelId = objge_UserLevelScoreENS.GameLevelId; //游戏关卡Id
objge_UserLevelScoreENT.UserId = objge_UserLevelScoreENS.UserId; //用户ID
objge_UserLevelScoreENT.CourseId = objge_UserLevelScoreENS.CourseId; //课程Id
objge_UserLevelScoreENT.Passed = objge_UserLevelScoreENS.Passed; //是否合格
objge_UserLevelScoreENT.Credits = objge_UserLevelScoreENS.Credits; //积分
objge_UserLevelScoreENT.GetDate = objge_UserLevelScoreENS.GetDate; //获取日期
objge_UserLevelScoreENT.GetInstructions = objge_UserLevelScoreENS.GetInstructions; //获取说明
objge_UserLevelScoreENT.BadgeNum = objge_UserLevelScoreENS.BadgeNum; //徽章数量
objge_UserLevelScoreENT.UpdDate = objge_UserLevelScoreENS.UpdDate; //修改日期
objge_UserLevelScoreENT.UpdUser = objge_UserLevelScoreENS.UpdUser; //修改人
objge_UserLevelScoreENT.Memo = objge_UserLevelScoreENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_UserLevelScoreEN.CourseId, conge_UserLevelScore.CourseId);
clsCheckSql.CheckFieldNotNull(objge_UserLevelScoreEN.Credits, conge_UserLevelScore.Credits);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.IdCurrEduCls, 8, conge_UserLevelScore.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GameLevelId, 8, conge_UserLevelScore.GameLevelId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UserId, 18, conge_UserLevelScore.UserId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.CourseId, 8, conge_UserLevelScore.CourseId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetDate, 20, conge_UserLevelScore.GetDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetInstructions, 100, conge_UserLevelScore.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdDate, 20, conge_UserLevelScore.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdUser, 20, conge_UserLevelScore.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.Memo, 1000, conge_UserLevelScore.Memo);
//检查字段外键固定长度
 objge_UserLevelScoreEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.CourseId, 8, conge_UserLevelScore.CourseId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetDate, 20, conge_UserLevelScore.GetDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetInstructions, 100, conge_UserLevelScore.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdDate, 20, conge_UserLevelScore.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdUser, 20, conge_UserLevelScore.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.Memo, 1000, conge_UserLevelScore.Memo);
//检查外键字段长度
 objge_UserLevelScoreEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.IdCurrEduCls, 8, conge_UserLevelScore.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GameLevelId, 8, conge_UserLevelScore.GameLevelId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UserId, 18, conge_UserLevelScore.UserId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.CourseId, 8, conge_UserLevelScore.CourseId);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetDate, 20, conge_UserLevelScore.GetDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.GetInstructions, 100, conge_UserLevelScore.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdDate, 20, conge_UserLevelScore.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.UpdUser, 20, conge_UserLevelScore.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserLevelScoreEN.Memo, 1000, conge_UserLevelScore.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.IdCurrEduCls, conge_UserLevelScore.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.GameLevelId, conge_UserLevelScore.GameLevelId);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.UserId, conge_UserLevelScore.UserId);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.CourseId, conge_UserLevelScore.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.GetDate, conge_UserLevelScore.GetDate);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.GetInstructions, conge_UserLevelScore.GetInstructions);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.UpdDate, conge_UserLevelScore.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.UpdUser, conge_UserLevelScore.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_UserLevelScoreEN.Memo, conge_UserLevelScore.Memo);
//检查外键字段长度
 objge_UserLevelScoreEN._IsCheckProperty = true;
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_UserLevelScoreEN._CurrTabName);
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_UserLevelScoreEN._CurrTabName, strCondition);
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
 objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}