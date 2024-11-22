
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillVerDA
 表名:zx_SkillVer(01120738)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 技能历史版本(zx_SkillVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SkillVerDA : clsCommBase4DA
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
 return clszx_SkillVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SkillVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SkillVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SkillVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SkillVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_SkillVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable_zx_SkillVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SkillVer.* from zx_SkillVer Left Join {1} on {2} where {3} and zx_SkillVer.SkillVId not in (Select top {5} zx_SkillVer.SkillVId from zx_SkillVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1} and SkillVId not in (Select top {2} SkillVId from zx_SkillVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1} and SkillVId not in (Select top {3} SkillVId from zx_SkillVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SkillVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SkillVer.* from zx_SkillVer Left Join {1} on {2} where {3} and zx_SkillVer.SkillVId not in (Select top {5} zx_SkillVer.SkillVId from zx_SkillVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1} and SkillVId not in (Select top {2} SkillVId from zx_SkillVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SkillVer where {1} and SkillVId not in (Select top {3} SkillVId from zx_SkillVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SkillVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SkillVerDA:GetObjLst)", objException.Message));
}
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = TransNullToInt(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = TransNullToBool(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SkillVerDA: GetObjLst)", objException.Message));
}
objzx_SkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SkillVerEN);
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
public List<clszx_SkillVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SkillVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = TransNullToInt(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = TransNullToBool(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SkillVerDA: GetObjLst)", objException.Message));
}
objzx_SkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_SkillVer(ref clszx_SkillVerEN objzx_SkillVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where SkillVId = " + ""+ objzx_SkillVerEN.SkillVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SkillVerEN.SkillVId = TransNullToInt(objDT.Rows[0][conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_SkillVerEN.zxSkillId = objDT.Rows[0][conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SkillVerEN.SkillName = objDT.Rows[0][conzx_SkillVer.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_SkillVerEN.zxOperationTypeId = objDT.Rows[0][conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillVerEN.Process = objDT.Rows[0][conzx_SkillVer.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SkillVerEN.zxLevelId = objDT.Rows[0][conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SkillVerEN.UpdUser = objDT.Rows[0][conzx_SkillVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.CreateDate = objDT.Rows[0][conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.UpdDate = objDT.Rows[0][conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SkillVerEN.TextId = objDT.Rows[0][conzx_SkillVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillVerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_SkillVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.IdCurrEduCls = objDT.Rows[0][conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillVerEN.PdfContent = objDT.Rows[0][conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SkillVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.zxShareId = objDT.Rows[0][conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillVerEN.Memo = objDT.Rows[0][conzx_SkillVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SkillVerEN.PdfDivLet = objDT.Rows[0][conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfDivTop = objDT.Rows[0][conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfPageNumIn = objDT.Rows[0][conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.PdfZoom = objDT.Rows[0][conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.GroupTextId = objDT.Rows[0][conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SkillVerDA: Getzx_SkillVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SkillVerEN GetObjBySkillVId(long lngSkillVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where SkillVId = " + ""+ lngSkillVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
 objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SkillVerDA: GetObjBySkillVId)", objException.Message));
}
return objzx_SkillVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SkillVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SkillVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN()
{
SkillVId = TransNullToInt(objRow[conzx_SkillVer.SkillVId].ToString().Trim()), //SkillVId
zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(), //技能Id
SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(), //技能名称
zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(), //实施过程
zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(), //级别Id
UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()), //是否提交
TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim() //小组Id
};
objzx_SkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SkillVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SkillVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = TransNullToInt(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = TransNullToBool(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SkillVerDA: GetObjByDataRowzx_SkillVer)", objException.Message));
}
objzx_SkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SkillVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = TransNullToInt(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = TransNullToBool(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SkillVerDA: GetObjByDataRow)", objException.Message));
}
objzx_SkillVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SkillVerEN;
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
objSQL = clszx_SkillVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SkillVerEN._CurrTabName, conzx_SkillVer.SkillVId, 8, "");
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
objSQL = clszx_SkillVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SkillVerEN._CurrTabName, conzx_SkillVer.SkillVId, 8, strPrefix);
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SkillVId from zx_SkillVer where " + strCondition;
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SkillVId from zx_SkillVer where " + strCondition;
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
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSkillVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SkillVer", "SkillVId = " + ""+ lngSkillVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SkillVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SkillVer", strCondition))
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
objSQL = clszx_SkillVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_SkillVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SkillVerEN objzx_SkillVerEN)
 {
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SkillVer");
objRow = objDS.Tables["zx_SkillVer"].NewRow();
objRow[conzx_SkillVer.zxSkillId] = objzx_SkillVerEN.zxSkillId; //技能Id
 if (objzx_SkillVerEN.SkillName !=  "")
 {
objRow[conzx_SkillVer.SkillName] = objzx_SkillVerEN.SkillName; //技能名称
 }
 if (objzx_SkillVerEN.zxOperationTypeId !=  "")
 {
objRow[conzx_SkillVer.zxOperationTypeId] = objzx_SkillVerEN.zxOperationTypeId; //操作类型ID
 }
 if (objzx_SkillVerEN.Process !=  "")
 {
objRow[conzx_SkillVer.Process] = objzx_SkillVerEN.Process; //实施过程
 }
 if (objzx_SkillVerEN.zxLevelId !=  "")
 {
objRow[conzx_SkillVer.zxLevelId] = objzx_SkillVerEN.zxLevelId; //级别Id
 }
 if (objzx_SkillVerEN.UpdUser !=  "")
 {
objRow[conzx_SkillVer.UpdUser] = objzx_SkillVerEN.UpdUser; //修改人
 }
 if (objzx_SkillVerEN.CreateDate !=  "")
 {
objRow[conzx_SkillVer.CreateDate] = objzx_SkillVerEN.CreateDate; //建立日期
 }
 if (objzx_SkillVerEN.UpdDate !=  "")
 {
objRow[conzx_SkillVer.UpdDate] = objzx_SkillVerEN.UpdDate; //修改日期
 }
objRow[conzx_SkillVer.IsSubmit] = objzx_SkillVerEN.IsSubmit; //是否提交
 if (objzx_SkillVerEN.TextId !=  "")
 {
objRow[conzx_SkillVer.TextId] = objzx_SkillVerEN.TextId; //课件Id
 }
objRow[conzx_SkillVer.VoteCount] = objzx_SkillVerEN.VoteCount; //点赞计数
objRow[conzx_SkillVer.AppraiseCount] = objzx_SkillVerEN.AppraiseCount; //评论数
objRow[conzx_SkillVer.Score] = objzx_SkillVerEN.Score; //评分
objRow[conzx_SkillVer.StuScore] = objzx_SkillVerEN.StuScore; //学生平均分
objRow[conzx_SkillVer.TeaScore] = objzx_SkillVerEN.TeaScore; //教师评分
 if (objzx_SkillVerEN.IdCurrEduCls !=  "")
 {
objRow[conzx_SkillVer.IdCurrEduCls] = objzx_SkillVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SkillVerEN.PdfContent !=  "")
 {
objRow[conzx_SkillVer.PdfContent] = objzx_SkillVerEN.PdfContent; //Pdf内容
 }
objRow[conzx_SkillVer.PdfPageNum] = objzx_SkillVerEN.PdfPageNum; //Pdf页码
objRow[conzx_SkillVer.CitationCount] = objzx_SkillVerEN.CitationCount; //引用统计
objRow[conzx_SkillVer.VersionCount] = objzx_SkillVerEN.VersionCount; //版本统计
 if (objzx_SkillVerEN.zxShareId !=  "")
 {
objRow[conzx_SkillVer.zxShareId] = objzx_SkillVerEN.zxShareId; //分享Id
 }
 if (objzx_SkillVerEN.Memo !=  "")
 {
objRow[conzx_SkillVer.Memo] = objzx_SkillVerEN.Memo; //备注
 }
 if (objzx_SkillVerEN.PdfDivLet !=  "")
 {
objRow[conzx_SkillVer.PdfDivLet] = objzx_SkillVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SkillVerEN.PdfDivTop !=  "")
 {
objRow[conzx_SkillVer.PdfDivTop] = objzx_SkillVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SkillVerEN.PdfPageNumIn !=  "")
 {
objRow[conzx_SkillVer.PdfPageNumIn] = objzx_SkillVerEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_SkillVer.PdfPageTop] = objzx_SkillVerEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_SkillVerEN.PdfZoom !=  "")
 {
objRow[conzx_SkillVer.PdfZoom] = objzx_SkillVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_SkillVerEN.GroupTextId !=  "")
 {
objRow[conzx_SkillVer.GroupTextId] = objzx_SkillVerEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_SkillVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SkillVerEN._CurrTabName);
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxSkillId);
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.SkillName);
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Process);
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxLevelId);
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdUser);
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CreateDate);
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdDate);
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SkillVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TextId);
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VoteCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VoteCount.ToString());
 }
 
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Score);
 arrValueListForInsert.Add(objzx_SkillVerEN.Score.ToString());
 }
 
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.StuScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.StuScore.ToString());
 }
 
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TeaScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.TeaScore.ToString());
 }
 
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfContent);
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CitationCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.CitationCount.ToString());
 }
 
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VersionCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VersionCount.ToString());
 }
 
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxShareId);
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Memo);
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivLet);
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivTop);
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfZoom);
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.GroupTextId);
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxSkillId);
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.SkillName);
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Process);
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxLevelId);
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdUser);
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CreateDate);
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdDate);
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SkillVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TextId);
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VoteCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VoteCount.ToString());
 }
 
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Score);
 arrValueListForInsert.Add(objzx_SkillVerEN.Score.ToString());
 }
 
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.StuScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.StuScore.ToString());
 }
 
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TeaScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.TeaScore.ToString());
 }
 
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfContent);
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CitationCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.CitationCount.ToString());
 }
 
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VersionCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VersionCount.ToString());
 }
 
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxShareId);
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Memo);
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivLet);
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivTop);
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfZoom);
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.GroupTextId);
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SkillVerEN objzx_SkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxSkillId);
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.SkillName);
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Process);
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxLevelId);
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdUser);
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CreateDate);
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdDate);
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SkillVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TextId);
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VoteCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VoteCount.ToString());
 }
 
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Score);
 arrValueListForInsert.Add(objzx_SkillVerEN.Score.ToString());
 }
 
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.StuScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.StuScore.ToString());
 }
 
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TeaScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.TeaScore.ToString());
 }
 
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfContent);
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CitationCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.CitationCount.ToString());
 }
 
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VersionCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VersionCount.ToString());
 }
 
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxShareId);
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Memo);
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivLet);
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivTop);
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfZoom);
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.GroupTextId);
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SkillVerEN objzx_SkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SkillVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxSkillId);
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxSkillId + "'");
 }
 
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.SkillName);
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSkillName + "'");
 }
 
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxOperationTypeId);
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxOperationTypeId + "'");
 }
 
 if (objzx_SkillVerEN.Process !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Process);
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProcess + "'");
 }
 
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxLevelId);
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxLevelId + "'");
 }
 
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdUser);
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CreateDate);
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.UpdDate);
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SkillVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SkillVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SkillVerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TextId);
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VoteCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VoteCount.ToString());
 }
 
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.AppraiseCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.AppraiseCount.ToString());
 }
 
 if (objzx_SkillVerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Score);
 arrValueListForInsert.Add(objzx_SkillVerEN.Score.ToString());
 }
 
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.StuScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.StuScore.ToString());
 }
 
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.TeaScore);
 arrValueListForInsert.Add(objzx_SkillVerEN.TeaScore.ToString());
 }
 
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfContent);
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNum);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageNum.ToString());
 }
 
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.CitationCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.CitationCount.ToString());
 }
 
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.VersionCount);
 arrValueListForInsert.Add(objzx_SkillVerEN.VersionCount.ToString());
 }
 
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.zxShareId);
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_SkillVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.Memo);
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivLet);
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfDivTop);
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageNumIn);
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfPageTop);
 arrValueListForInsert.Add(objzx_SkillVerEN.PdfPageTop.ToString());
 }
 
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.PdfZoom);
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SkillVer.GroupTextId);
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SkillVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_SkillVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where SkillVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SkillVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSkillVId = TransNullToInt(oRow[conzx_SkillVer.SkillVId].ToString().Trim());
if (IsExist(lngSkillVId))
{
 string strResult = "关键字变量值为:" + string.Format("SkillVId = {0}", lngSkillVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SkillVerEN._CurrTabName ].NewRow();
objRow[conzx_SkillVer.zxSkillId] = oRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objRow[conzx_SkillVer.SkillName] = oRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objRow[conzx_SkillVer.zxOperationTypeId] = oRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objRow[conzx_SkillVer.Process] = oRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objRow[conzx_SkillVer.zxLevelId] = oRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objRow[conzx_SkillVer.UpdUser] = oRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_SkillVer.CreateDate] = oRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_SkillVer.UpdDate] = oRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_SkillVer.IsSubmit] = oRow[conzx_SkillVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_SkillVer.TextId] = oRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objRow[conzx_SkillVer.VoteCount] = oRow[conzx_SkillVer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_SkillVer.AppraiseCount] = oRow[conzx_SkillVer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_SkillVer.Score] = oRow[conzx_SkillVer.Score].ToString().Trim(); //评分
objRow[conzx_SkillVer.StuScore] = oRow[conzx_SkillVer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_SkillVer.TeaScore] = oRow[conzx_SkillVer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_SkillVer.IdCurrEduCls] = oRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_SkillVer.PdfContent] = oRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_SkillVer.PdfPageNum] = oRow[conzx_SkillVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_SkillVer.CitationCount] = oRow[conzx_SkillVer.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_SkillVer.VersionCount] = oRow[conzx_SkillVer.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_SkillVer.zxShareId] = oRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_SkillVer.Memo] = oRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objRow[conzx_SkillVer.PdfDivLet] = oRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_SkillVer.PdfDivTop] = oRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_SkillVer.PdfPageNumIn] = oRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_SkillVer.PdfPageTop] = oRow[conzx_SkillVer.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_SkillVer.PdfZoom] = oRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_SkillVer.GroupTextId] = oRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_SkillVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SkillVerEN._CurrTabName);
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
 /// <param name = "objzx_SkillVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_SkillVer where SkillVId = " + ""+ objzx_SkillVerEN.SkillVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SkillVerEN._CurrTabName);
if (objDS.Tables[clszx_SkillVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SkillVId = " + ""+ objzx_SkillVerEN.SkillVId+"");
return false;
}
objRow = objDS.Tables[clszx_SkillVerEN._CurrTabName].Rows[0];
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxSkillId))
 {
objRow[conzx_SkillVer.zxSkillId] = objzx_SkillVerEN.zxSkillId; //技能Id
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.SkillName))
 {
objRow[conzx_SkillVer.SkillName] = objzx_SkillVerEN.SkillName; //技能名称
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxOperationTypeId))
 {
objRow[conzx_SkillVer.zxOperationTypeId] = objzx_SkillVerEN.zxOperationTypeId; //操作类型ID
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Process))
 {
objRow[conzx_SkillVer.Process] = objzx_SkillVerEN.Process; //实施过程
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxLevelId))
 {
objRow[conzx_SkillVer.zxLevelId] = objzx_SkillVerEN.zxLevelId; //级别Id
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdUser))
 {
objRow[conzx_SkillVer.UpdUser] = objzx_SkillVerEN.UpdUser; //修改人
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CreateDate))
 {
objRow[conzx_SkillVer.CreateDate] = objzx_SkillVerEN.CreateDate; //建立日期
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdDate))
 {
objRow[conzx_SkillVer.UpdDate] = objzx_SkillVerEN.UpdDate; //修改日期
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IsSubmit))
 {
objRow[conzx_SkillVer.IsSubmit] = objzx_SkillVerEN.IsSubmit; //是否提交
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TextId))
 {
objRow[conzx_SkillVer.TextId] = objzx_SkillVerEN.TextId; //课件Id
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VoteCount))
 {
objRow[conzx_SkillVer.VoteCount] = objzx_SkillVerEN.VoteCount; //点赞计数
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.AppraiseCount))
 {
objRow[conzx_SkillVer.AppraiseCount] = objzx_SkillVerEN.AppraiseCount; //评论数
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Score))
 {
objRow[conzx_SkillVer.Score] = objzx_SkillVerEN.Score; //评分
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.StuScore))
 {
objRow[conzx_SkillVer.StuScore] = objzx_SkillVerEN.StuScore; //学生平均分
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TeaScore))
 {
objRow[conzx_SkillVer.TeaScore] = objzx_SkillVerEN.TeaScore; //教师评分
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IdCurrEduCls))
 {
objRow[conzx_SkillVer.IdCurrEduCls] = objzx_SkillVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfContent))
 {
objRow[conzx_SkillVer.PdfContent] = objzx_SkillVerEN.PdfContent; //Pdf内容
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNum))
 {
objRow[conzx_SkillVer.PdfPageNum] = objzx_SkillVerEN.PdfPageNum; //Pdf页码
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CitationCount))
 {
objRow[conzx_SkillVer.CitationCount] = objzx_SkillVerEN.CitationCount; //引用统计
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VersionCount))
 {
objRow[conzx_SkillVer.VersionCount] = objzx_SkillVerEN.VersionCount; //版本统计
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxShareId))
 {
objRow[conzx_SkillVer.zxShareId] = objzx_SkillVerEN.zxShareId; //分享Id
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Memo))
 {
objRow[conzx_SkillVer.Memo] = objzx_SkillVerEN.Memo; //备注
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivLet))
 {
objRow[conzx_SkillVer.PdfDivLet] = objzx_SkillVerEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivTop))
 {
objRow[conzx_SkillVer.PdfDivTop] = objzx_SkillVerEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNumIn))
 {
objRow[conzx_SkillVer.PdfPageNumIn] = objzx_SkillVerEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageTop))
 {
objRow[conzx_SkillVer.PdfPageTop] = objzx_SkillVerEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfZoom))
 {
objRow[conzx_SkillVer.PdfZoom] = objzx_SkillVerEN.PdfZoom; //PdfZoom
 }
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.GroupTextId))
 {
objRow[conzx_SkillVer.GroupTextId] = objzx_SkillVerEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_SkillVerEN._CurrTabName);
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_SkillVer Set ");
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxSkillId))
 {
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxSkillId, conzx_SkillVer.zxSkillId); //技能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxSkillId); //技能Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.SkillName))
 {
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conzx_SkillVer.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.SkillName); //技能名称
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxOperationTypeId))
 {
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxOperationTypeId, conzx_SkillVer.zxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxOperationTypeId); //操作类型ID
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Process))
 {
 if (objzx_SkillVerEN.Process !=  null)
 {
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conzx_SkillVer.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Process); //实施过程
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxLevelId))
 {
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SkillVer.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdUser))
 {
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SkillVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.UpdUser); //修改人
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CreateDate))
 {
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SkillVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdDate))
 {
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SkillVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SkillVerEN.IsSubmit == true?"1":"0", conzx_SkillVer.IsSubmit); //是否提交
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TextId))
 {
 if (objzx_SkillVerEN.TextId !=  null)
 {
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SkillVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TextId); //课件Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VoteCount))
 {
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VoteCount, conzx_SkillVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.AppraiseCount))
 {
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.AppraiseCount, conzx_SkillVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Score))
 {
 if (objzx_SkillVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.Score, conzx_SkillVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Score); //评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.StuScore))
 {
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.StuScore, conzx_SkillVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TeaScore))
 {
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.TeaScore, conzx_SkillVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IdCurrEduCls))
 {
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SkillVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfContent))
 {
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SkillVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNum))
 {
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageNum, conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CitationCount))
 {
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.CitationCount, conzx_SkillVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VersionCount))
 {
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VersionCount, conzx_SkillVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxShareId))
 {
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SkillVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Memo))
 {
 if (objzx_SkillVerEN.Memo !=  null)
 {
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SkillVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Memo); //备注
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivLet))
 {
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SkillVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivTop))
 {
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SkillVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNumIn))
 {
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SkillVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageTop))
 {
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageTop, conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfZoom))
 {
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SkillVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.GroupTextId))
 {
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SkillVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillVId = {0}", objzx_SkillVerEN.SkillVId); 
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
 /// <param name = "objzx_SkillVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SkillVerEN objzx_SkillVerEN, string strCondition)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SkillVer Set ");
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxSkillId))
 {
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxSkillId = '{0}',", strzxSkillId); //技能Id
 }
 else
 {
 sbSQL.Append(" zxSkillId = null,"); //技能Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.SkillName))
 {
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxOperationTypeId))
 {
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxOperationTypeId = '{0}',", strzxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" zxOperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Process))
 {
 if (objzx_SkillVerEN.Process !=  null)
 {
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxLevelId))
 {
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdUser))
 {
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CreateDate))
 {
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdDate))
 {
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SkillVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TextId))
 {
 if (objzx_SkillVerEN.TextId !=  null)
 {
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VoteCount))
 {
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VoteCount, conzx_SkillVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.AppraiseCount))
 {
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.AppraiseCount, conzx_SkillVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Score))
 {
 if (objzx_SkillVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.Score, conzx_SkillVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Score); //评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.StuScore))
 {
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.StuScore, conzx_SkillVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TeaScore))
 {
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.TeaScore, conzx_SkillVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IdCurrEduCls))
 {
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfContent))
 {
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNum))
 {
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageNum, conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CitationCount))
 {
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.CitationCount, conzx_SkillVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VersionCount))
 {
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VersionCount, conzx_SkillVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxShareId))
 {
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Memo))
 {
 if (objzx_SkillVerEN.Memo !=  null)
 {
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivLet))
 {
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivTop))
 {
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNumIn))
 {
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageTop))
 {
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageTop, conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfZoom))
 {
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.GroupTextId))
 {
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_SkillVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SkillVerEN objzx_SkillVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SkillVer Set ");
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxSkillId))
 {
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxSkillId = '{0}',", strzxSkillId); //技能Id
 }
 else
 {
 sbSQL.Append(" zxSkillId = null,"); //技能Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.SkillName))
 {
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SkillName = '{0}',", strSkillName); //技能名称
 }
 else
 {
 sbSQL.Append(" SkillName = null,"); //技能名称
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxOperationTypeId))
 {
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxOperationTypeId = '{0}',", strzxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" zxOperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Process))
 {
 if (objzx_SkillVerEN.Process !=  null)
 {
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Process = '{0}',", strProcess); //实施过程
 }
 else
 {
 sbSQL.Append(" Process = null,"); //实施过程
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxLevelId))
 {
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxLevelId = '{0}',", strzxLevelId); //级别Id
 }
 else
 {
 sbSQL.Append(" zxLevelId = null,"); //级别Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdUser))
 {
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CreateDate))
 {
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdDate))
 {
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SkillVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TextId))
 {
 if (objzx_SkillVerEN.TextId !=  null)
 {
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VoteCount))
 {
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VoteCount, conzx_SkillVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.AppraiseCount))
 {
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.AppraiseCount, conzx_SkillVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Score))
 {
 if (objzx_SkillVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.Score, conzx_SkillVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Score); //评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.StuScore))
 {
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.StuScore, conzx_SkillVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TeaScore))
 {
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.TeaScore, conzx_SkillVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IdCurrEduCls))
 {
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfContent))
 {
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNum))
 {
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageNum, conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CitationCount))
 {
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.CitationCount, conzx_SkillVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VersionCount))
 {
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VersionCount, conzx_SkillVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxShareId))
 {
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Memo))
 {
 if (objzx_SkillVerEN.Memo !=  null)
 {
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivLet))
 {
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivTop))
 {
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNumIn))
 {
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageTop))
 {
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageTop, conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfZoom))
 {
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.GroupTextId))
 {
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SkillVerEN objzx_SkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_SkillVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SkillVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SkillVer Set ");
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxSkillId))
 {
 if (objzx_SkillVerEN.zxSkillId !=  null)
 {
 var strzxSkillId = objzx_SkillVerEN.zxSkillId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxSkillId, conzx_SkillVer.zxSkillId); //技能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxSkillId); //技能Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.SkillName))
 {
 if (objzx_SkillVerEN.SkillName !=  null)
 {
 var strSkillName = objzx_SkillVerEN.SkillName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSkillName, conzx_SkillVer.SkillName); //技能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.SkillName); //技能名称
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxOperationTypeId))
 {
 if (objzx_SkillVerEN.zxOperationTypeId !=  null)
 {
 var strzxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxOperationTypeId, conzx_SkillVer.zxOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxOperationTypeId); //操作类型ID
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Process))
 {
 if (objzx_SkillVerEN.Process !=  null)
 {
 var strProcess = objzx_SkillVerEN.Process.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProcess, conzx_SkillVer.Process); //实施过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Process); //实施过程
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxLevelId))
 {
 if (objzx_SkillVerEN.zxLevelId !=  null)
 {
 var strzxLevelId = objzx_SkillVerEN.zxLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxLevelId, conzx_SkillVer.zxLevelId); //级别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxLevelId); //级别Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdUser))
 {
 if (objzx_SkillVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SkillVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SkillVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.UpdUser); //修改人
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CreateDate))
 {
 if (objzx_SkillVerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_SkillVerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_SkillVer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CreateDate); //建立日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.UpdDate))
 {
 if (objzx_SkillVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SkillVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SkillVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SkillVerEN.IsSubmit == true?"1":"0", conzx_SkillVer.IsSubmit); //是否提交
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TextId))
 {
 if (objzx_SkillVerEN.TextId !=  null)
 {
 var strTextId = objzx_SkillVerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_SkillVer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TextId); //课件Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VoteCount))
 {
 if (objzx_SkillVerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VoteCount, conzx_SkillVer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.AppraiseCount))
 {
 if (objzx_SkillVerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.AppraiseCount, conzx_SkillVer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Score))
 {
 if (objzx_SkillVerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.Score, conzx_SkillVer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Score); //评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.StuScore))
 {
 if (objzx_SkillVerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.StuScore, conzx_SkillVer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.StuScore); //学生平均分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.TeaScore))
 {
 if (objzx_SkillVerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.TeaScore, conzx_SkillVer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.TeaScore); //教师评分
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.IdCurrEduCls))
 {
 if (objzx_SkillVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SkillVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfContent))
 {
 if (objzx_SkillVerEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_SkillVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_SkillVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNum))
 {
 if (objzx_SkillVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageNum, conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.CitationCount))
 {
 if (objzx_SkillVerEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.CitationCount, conzx_SkillVer.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.CitationCount); //引用统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.VersionCount))
 {
 if (objzx_SkillVerEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.VersionCount, conzx_SkillVer.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.VersionCount); //版本统计
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.zxShareId))
 {
 if (objzx_SkillVerEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_SkillVerEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_SkillVer.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.zxShareId); //分享Id
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.Memo))
 {
 if (objzx_SkillVerEN.Memo !=  null)
 {
 var strMemo = objzx_SkillVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SkillVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.Memo); //备注
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivLet))
 {
 if (objzx_SkillVerEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_SkillVerEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_SkillVer.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfDivTop))
 {
 if (objzx_SkillVerEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_SkillVerEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_SkillVer.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageNumIn))
 {
 if (objzx_SkillVerEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_SkillVer.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfPageTop))
 {
 if (objzx_SkillVerEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SkillVerEN.PdfPageTop, conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.PdfZoom))
 {
 if (objzx_SkillVerEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_SkillVerEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_SkillVer.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_SkillVerEN.IsUpdated(conzx_SkillVer.GroupTextId))
 {
 if (objzx_SkillVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_SkillVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_SkillVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SkillVer.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SkillVId = {0}", objzx_SkillVerEN.SkillVId); 
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
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngSkillVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSkillVId,
};
 objSQL.ExecSP("zx_SkillVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngSkillVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
//删除zx_SkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SkillVer where SkillVId = " + ""+ lngSkillVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_SkillVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
//删除zx_SkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SkillVer where SkillVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngSkillVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
//删除zx_SkillVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SkillVer where SkillVId = " + ""+ lngSkillVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_SkillVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SkillVerDA: Delzx_SkillVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SkillVer where " + strCondition ;
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
public bool Delzx_SkillVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SkillVerDA: Delzx_SkillVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SkillVer where " + strCondition ;
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
 /// <param name = "objzx_SkillVerENS">源对象</param>
 /// <param name = "objzx_SkillVerENT">目标对象</param>
public void CopyTo(clszx_SkillVerEN objzx_SkillVerENS, clszx_SkillVerEN objzx_SkillVerENT)
{
objzx_SkillVerENT.SkillVId = objzx_SkillVerENS.SkillVId; //SkillVId
objzx_SkillVerENT.zxSkillId = objzx_SkillVerENS.zxSkillId; //技能Id
objzx_SkillVerENT.SkillName = objzx_SkillVerENS.SkillName; //技能名称
objzx_SkillVerENT.zxOperationTypeId = objzx_SkillVerENS.zxOperationTypeId; //操作类型ID
objzx_SkillVerENT.Process = objzx_SkillVerENS.Process; //实施过程
objzx_SkillVerENT.zxLevelId = objzx_SkillVerENS.zxLevelId; //级别Id
objzx_SkillVerENT.UpdUser = objzx_SkillVerENS.UpdUser; //修改人
objzx_SkillVerENT.CreateDate = objzx_SkillVerENS.CreateDate; //建立日期
objzx_SkillVerENT.UpdDate = objzx_SkillVerENS.UpdDate; //修改日期
objzx_SkillVerENT.IsSubmit = objzx_SkillVerENS.IsSubmit; //是否提交
objzx_SkillVerENT.TextId = objzx_SkillVerENS.TextId; //课件Id
objzx_SkillVerENT.VoteCount = objzx_SkillVerENS.VoteCount; //点赞计数
objzx_SkillVerENT.AppraiseCount = objzx_SkillVerENS.AppraiseCount; //评论数
objzx_SkillVerENT.Score = objzx_SkillVerENS.Score; //评分
objzx_SkillVerENT.StuScore = objzx_SkillVerENS.StuScore; //学生平均分
objzx_SkillVerENT.TeaScore = objzx_SkillVerENS.TeaScore; //教师评分
objzx_SkillVerENT.IdCurrEduCls = objzx_SkillVerENS.IdCurrEduCls; //教学班流水号
objzx_SkillVerENT.PdfContent = objzx_SkillVerENS.PdfContent; //Pdf内容
objzx_SkillVerENT.PdfPageNum = objzx_SkillVerENS.PdfPageNum; //Pdf页码
objzx_SkillVerENT.CitationCount = objzx_SkillVerENS.CitationCount; //引用统计
objzx_SkillVerENT.VersionCount = objzx_SkillVerENS.VersionCount; //版本统计
objzx_SkillVerENT.zxShareId = objzx_SkillVerENS.zxShareId; //分享Id
objzx_SkillVerENT.Memo = objzx_SkillVerENS.Memo; //备注
objzx_SkillVerENT.PdfDivLet = objzx_SkillVerENS.PdfDivLet; //PdfDivLet
objzx_SkillVerENT.PdfDivTop = objzx_SkillVerENS.PdfDivTop; //PdfDivTop
objzx_SkillVerENT.PdfPageNumIn = objzx_SkillVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillVerENT.PdfPageTop = objzx_SkillVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillVerENT.PdfZoom = objzx_SkillVerENS.PdfZoom; //PdfZoom
objzx_SkillVerENT.GroupTextId = objzx_SkillVerENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SkillVerEN objzx_SkillVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_SkillVerEN.zxSkillId, conzx_SkillVer.zxSkillId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxSkillId, 10, conzx_SkillVer.zxSkillId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.SkillName, 200, conzx_SkillVer.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxOperationTypeId, 2, conzx_SkillVer.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxLevelId, 2, conzx_SkillVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdUser, 20, conzx_SkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.CreateDate, 20, conzx_SkillVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdDate, 20, conzx_SkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.TextId, 8, conzx_SkillVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.IdCurrEduCls, 8, conzx_SkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfContent, 2000, conzx_SkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxShareId, 2, conzx_SkillVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.Memo, 1000, conzx_SkillVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivLet, 50, conzx_SkillVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivTop, 50, conzx_SkillVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfPageNumIn, 50, conzx_SkillVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfZoom, 50, conzx_SkillVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.GroupTextId, 8, conzx_SkillVer.GroupTextId);
//检查字段外键固定长度
 objzx_SkillVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SkillVerEN objzx_SkillVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxSkillId, 10, conzx_SkillVer.zxSkillId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.SkillName, 200, conzx_SkillVer.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxOperationTypeId, 2, conzx_SkillVer.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxLevelId, 2, conzx_SkillVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdUser, 20, conzx_SkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.CreateDate, 20, conzx_SkillVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdDate, 20, conzx_SkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.TextId, 8, conzx_SkillVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.IdCurrEduCls, 8, conzx_SkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfContent, 2000, conzx_SkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxShareId, 2, conzx_SkillVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.Memo, 1000, conzx_SkillVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivLet, 50, conzx_SkillVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivTop, 50, conzx_SkillVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfPageNumIn, 50, conzx_SkillVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfZoom, 50, conzx_SkillVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.GroupTextId, 8, conzx_SkillVer.GroupTextId);
//检查外键字段长度
 objzx_SkillVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SkillVerEN objzx_SkillVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxSkillId, 10, conzx_SkillVer.zxSkillId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.SkillName, 200, conzx_SkillVer.SkillName);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxOperationTypeId, 2, conzx_SkillVer.zxOperationTypeId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxLevelId, 2, conzx_SkillVer.zxLevelId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdUser, 20, conzx_SkillVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.CreateDate, 20, conzx_SkillVer.CreateDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.UpdDate, 20, conzx_SkillVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.TextId, 8, conzx_SkillVer.TextId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.IdCurrEduCls, 8, conzx_SkillVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfContent, 2000, conzx_SkillVer.PdfContent);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.zxShareId, 2, conzx_SkillVer.zxShareId);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.Memo, 1000, conzx_SkillVer.Memo);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivLet, 50, conzx_SkillVer.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfDivTop, 50, conzx_SkillVer.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfPageNumIn, 50, conzx_SkillVer.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.PdfZoom, 50, conzx_SkillVer.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_SkillVerEN.GroupTextId, 8, conzx_SkillVer.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.zxSkillId, conzx_SkillVer.zxSkillId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.SkillName, conzx_SkillVer.SkillName);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.zxOperationTypeId, conzx_SkillVer.zxOperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.zxLevelId, conzx_SkillVer.zxLevelId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.UpdUser, conzx_SkillVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.CreateDate, conzx_SkillVer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.UpdDate, conzx_SkillVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.TextId, conzx_SkillVer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.IdCurrEduCls, conzx_SkillVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.PdfContent, conzx_SkillVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.zxShareId, conzx_SkillVer.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.Memo, conzx_SkillVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.PdfDivLet, conzx_SkillVer.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.PdfDivTop, conzx_SkillVer.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.PdfPageNumIn, conzx_SkillVer.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.PdfZoom, conzx_SkillVer.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_SkillVerEN.GroupTextId, conzx_SkillVer.GroupTextId);
//检查外键字段长度
 objzx_SkillVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSkillVId()
{
//获取某学院所有专业信息
string strSQL = "select SkillVId, zxLevelId from zx_SkillVer ";
 clsSpecSQLforSql mySql = clszx_SkillVerDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_SkillVer(技能历史版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_SkillVerEN objzx_SkillVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSkillId = '{0}'", objzx_SkillVerEN.zxSkillId);
 if (objzx_SkillVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SkillVerEN.GroupTextId);
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SkillVerEN._CurrTabName);
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SkillVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
 objSQL = clszx_SkillVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}