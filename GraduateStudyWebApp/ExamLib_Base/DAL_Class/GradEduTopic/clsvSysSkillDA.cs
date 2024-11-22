
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSkillDA
 表名:vSysSkill(01120653)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 技能表视图(vSysSkill)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSysSkillDA : clsCommBase4DA
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
 return clsvSysSkillEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSysSkillEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysSkillEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSysSkillEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysSkillEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSkillId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSkillId)
{
strSkillId = strSkillId.Replace("'", "''");
if (strSkillId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vSysSkill中,检查关键字,长度不正确!(clsvSysSkillDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSkillId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSysSkill中,关键字不能为空 或 null!(clsvSysSkillDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSkillId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSysSkillDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysSkill(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable_vSysSkill)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysSkill.* from vSysSkill Left Join {1} on {2} where {3} and vSysSkill.SkillId not in (Select top {5} vSysSkill.SkillId from vSysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1} and SkillId not in (Select top {2} SkillId from vSysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1} and SkillId not in (Select top {3} SkillId from vSysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysSkillDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysSkill.* from vSysSkill Left Join {1} on {2} where {3} and vSysSkill.SkillId not in (Select top {5} vSysSkill.SkillId from vSysSkill Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1} and SkillId not in (Select top {2} SkillId from vSysSkill where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysSkill where {1} and SkillId not in (Select top {3} SkillId from vSysSkill where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSysSkillEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysSkillDA:GetObjLst)", objException.Message));
}
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = TransNullToBool(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysSkillDA: GetObjLst)", objException.Message));
}
objvSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysSkillEN);
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
public List<clsvSysSkillEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysSkillDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = TransNullToBool(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysSkillDA: GetObjLst)", objException.Message));
}
objvSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysSkill(ref clsvSysSkillEN objvSysSkillEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where SkillId = " + "'"+ objvSysSkillEN.SkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysSkillEN.SkillId = objDT.Rows[0][convSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvSysSkillEN.SkillName = objDT.Rows[0][convSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSysSkillEN.Process = objDT.Rows[0][convSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvSysSkillEN.OperationTypeId = objDT.Rows[0][convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvSysSkillEN.LevelId = objDT.Rows[0][convSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvSysSkillEN.LevelName = objDT.Rows[0][convSysSkill.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysSkillEN.UpdUser = objDT.Rows[0][convSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.UpdDate = objDT.Rows[0][convSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.IsSubmit = TransNullToBool(objDT.Rows[0][convSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvSysSkillEN.CitationId = objDT.Rows[0][convSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvSysSkillEN.OkCount = TransNullToInt(objDT.Rows[0][convSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.Score = TransNullToFloat(objDT.Rows[0][convSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.StuScore = TransNullToFloat(objDT.Rows[0][convSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.TeaScore = TransNullToFloat(objDT.Rows[0][convSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.IdCurrEduCls = objDT.Rows[0][convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysSkillEN.PdfContent = objDT.Rows[0][convSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSysSkillEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.CitationCount = TransNullToInt(objDT.Rows[0][convSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.VersionCount = TransNullToInt(objDT.Rows[0][convSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.Memo = objDT.Rows[0][convSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysSkillEN.OperationTypeName = objDT.Rows[0][convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvSysSkillEN.CreateDate = objDT.Rows[0][convSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.ShareId = objDT.Rows[0][convSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysSkillDA: GetvSysSkill)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysSkillEN GetObjBySkillId(string strSkillId)
{
CheckPrimaryKey(strSkillId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where SkillId = " + "'"+ strSkillId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
 objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysSkillDA: GetObjBySkillId)", objException.Message));
}
return objvSysSkillEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysSkillEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysSkillDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
strSQL = "Select * from vSysSkill where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN()
{
SkillId = objRow[convSysSkill.SkillId].ToString().Trim(), //技能Id
SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(), //技能名称
Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(), //实施过程
OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(), //操作类型ID
LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(), //级别Id
LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(), //级别名称
UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(), //修改日期
IsSubmit = TransNullToBool(objRow[convSysSkill.IsSubmit].ToString().Trim()), //是否提交
CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(), //引用Id
OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.Score].ToString().Trim()), //评分
StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.VersionCount].ToString().Trim()), //版本统计
Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(), //备注
OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(), //操作类型名
CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convSysSkill.ShareId].ToString().Trim() //分享Id
};
objvSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysSkillEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysSkillDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysSkillEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = TransNullToBool(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysSkillDA: GetObjByDataRowvSysSkill)", objException.Message));
}
objvSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysSkillEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysSkillEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = TransNullToBool(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysSkillDA: GetObjByDataRow)", objException.Message));
}
objvSysSkillEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysSkillEN;
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
objSQL = clsvSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysSkillEN._CurrTabName, convSysSkill.SkillId, 10, "");
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
objSQL = clsvSysSkillDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysSkillEN._CurrTabName, convSysSkill.SkillId, 10, strPrefix);
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SkillId from vSysSkill where " + strCondition;
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SkillId from vSysSkill where " + strCondition;
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
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSkillId)
{
CheckPrimaryKey(strSkillId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysSkill", "SkillId = " + "'"+ strSkillId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysSkillDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysSkill", strCondition))
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
objSQL = clsvSysSkillDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysSkill");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <param name = "objvSysSkillENT">目标对象</param>
public void CopyTo(clsvSysSkillEN objvSysSkillENS, clsvSysSkillEN objvSysSkillENT)
{
objvSysSkillENT.SkillId = objvSysSkillENS.SkillId; //技能Id
objvSysSkillENT.SkillName = objvSysSkillENS.SkillName; //技能名称
objvSysSkillENT.Process = objvSysSkillENS.Process; //实施过程
objvSysSkillENT.OperationTypeId = objvSysSkillENS.OperationTypeId; //操作类型ID
objvSysSkillENT.LevelId = objvSysSkillENS.LevelId; //级别Id
objvSysSkillENT.LevelName = objvSysSkillENS.LevelName; //级别名称
objvSysSkillENT.UpdUser = objvSysSkillENS.UpdUser; //修改人
objvSysSkillENT.UpdDate = objvSysSkillENS.UpdDate; //修改日期
objvSysSkillENT.IsSubmit = objvSysSkillENS.IsSubmit; //是否提交
objvSysSkillENT.CitationId = objvSysSkillENS.CitationId; //引用Id
objvSysSkillENT.OkCount = objvSysSkillENS.OkCount; //点赞统计
objvSysSkillENT.AppraiseCount = objvSysSkillENS.AppraiseCount; //评论数
objvSysSkillENT.Score = objvSysSkillENS.Score; //评分
objvSysSkillENT.StuScore = objvSysSkillENS.StuScore; //学生平均分
objvSysSkillENT.TeaScore = objvSysSkillENS.TeaScore; //教师评分
objvSysSkillENT.IdCurrEduCls = objvSysSkillENS.IdCurrEduCls; //教学班流水号
objvSysSkillENT.PdfContent = objvSysSkillENS.PdfContent; //Pdf内容
objvSysSkillENT.PdfPageNum = objvSysSkillENS.PdfPageNum; //Pdf页码
objvSysSkillENT.CitationCount = objvSysSkillENS.CitationCount; //引用统计
objvSysSkillENT.VersionCount = objvSysSkillENS.VersionCount; //版本统计
objvSysSkillENT.Memo = objvSysSkillENS.Memo; //备注
objvSysSkillENT.OperationTypeName = objvSysSkillENS.OperationTypeName; //操作类型名
objvSysSkillENT.CreateDate = objvSysSkillENS.CreateDate; //建立日期
objvSysSkillENT.ShareId = objvSysSkillENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysSkillEN objvSysSkillEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysSkillEN.SkillId, 10, convSysSkill.SkillId);
clsCheckSql.CheckFieldLen(objvSysSkillEN.SkillName, 200, convSysSkill.SkillName);
clsCheckSql.CheckFieldLen(objvSysSkillEN.OperationTypeId, 4, convSysSkill.OperationTypeId);
clsCheckSql.CheckFieldLen(objvSysSkillEN.LevelId, 2, convSysSkill.LevelId);
clsCheckSql.CheckFieldLen(objvSysSkillEN.LevelName, 50, convSysSkill.LevelName);
clsCheckSql.CheckFieldLen(objvSysSkillEN.UpdUser, 20, convSysSkill.UpdUser);
clsCheckSql.CheckFieldLen(objvSysSkillEN.UpdDate, 20, convSysSkill.UpdDate);
clsCheckSql.CheckFieldLen(objvSysSkillEN.CitationId, 8, convSysSkill.CitationId);
clsCheckSql.CheckFieldLen(objvSysSkillEN.IdCurrEduCls, 8, convSysSkill.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvSysSkillEN.PdfContent, 2000, convSysSkill.PdfContent);
clsCheckSql.CheckFieldLen(objvSysSkillEN.Memo, 1000, convSysSkill.Memo);
clsCheckSql.CheckFieldLen(objvSysSkillEN.OperationTypeName, 50, convSysSkill.OperationTypeName);
clsCheckSql.CheckFieldLen(objvSysSkillEN.CreateDate, 20, convSysSkill.CreateDate);
clsCheckSql.CheckFieldLen(objvSysSkillEN.ShareId, 2, convSysSkill.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.SkillId, convSysSkill.SkillId);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.SkillName, convSysSkill.SkillName);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.OperationTypeId, convSysSkill.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.LevelId, convSysSkill.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.LevelName, convSysSkill.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.UpdUser, convSysSkill.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.UpdDate, convSysSkill.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.CitationId, convSysSkill.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.IdCurrEduCls, convSysSkill.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.PdfContent, convSysSkill.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.Memo, convSysSkill.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.OperationTypeName, convSysSkill.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.CreateDate, convSysSkill.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvSysSkillEN.ShareId, convSysSkill.ShareId);
//检查外键字段长度
 objvSysSkillEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSkillId()
{
//获取某学院所有专业信息
string strSQL = "select SkillId, OperationTypeName from vSysSkill ";
 clsSpecSQLforSql mySql = clsvSysSkillDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysSkillEN._CurrTabName);
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysSkillEN._CurrTabName, strCondition);
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
 objSQL = clsvSysSkillDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}